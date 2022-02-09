#include <Arduino.h>
#include <WiFi.h>
#include <WiFiUdp.h>
#include <Adafruit_Sensor.h>
#include <Adafruit_MCP4725.h>
#include <Adafruit_BNO055.h>
#include <utility/imumaths.h>
#include <SPI.h>
#include <Wire.h>

// Function STUBS for Platform IO
bool SetupGradeController();
bool SetAutoState();
void GetGradeControlData();
void SetOutput();
void SetValveLimits();

// UDP
void ConnectToOG();
void Reconnect();
bool SetupUdp();
bool SendUdpData(const char *_dataHeader);
bool RecvUdpData();

/// UDP Variables
WiFiUDP UdpGradeControl;  // Creation of wifi UdpGradeControl instance
const char *ssid = {"OpenGradeX"};

char packetBuffer[255];
uint16_t openGradePort = 9999; //OpenGrade Server Port
uint16_t gradeControlPort = 7777; // GradeControl  Port
uint16_t antennaPort = 8888; // Antenna Port
uint16_t senderPort;
///Ip Addresses
IPAddress openGradeIP(192,168,1,156);   //OpenGradeX Server
IPAddress gradeControlIP(192,168,1,255);   // GradeControl Module IP
IPAddress antennaIP(192,168,1,155);   // Antenna Module IP
IPAddress gatewayIP(192,168,1,1);   // what we want the sp 32 IPAddress to be
IPAddress Subnet(255, 255, 255, 0);
IPAddress Dns(8,8,8,8);
IPAddress senderIP;

///////////////////////PINS///////////////////////
#define SERIAL_BAUD 115200
#define SCL_PIN 22      // I2C SCL PIN
#define SDA_PIN 21      // I2C SCL PIN
#define RXD2 16  // Diagnostic RX
#define TXD2 17 // Diagnostic TX
#define CONST_180_DIVIDED_BY_PI 57.2957795130823

//UDP HEADERS
#define DATA_HEADER 10001
#define SETTINGS_HEADER 10002
#define GPS_HEADER 10003
#define DEBUG Serial
#define RTK Serial1


// Valve Definitions
#define VALVE_FLOAT 2048
#define CNH 0
#define DEERE 1
#define DANFOSS 2
#define CNH_MIN .11
#define CNH_MAX .89
#define DEERE_MIN .11
#define DEERE_MAX .89
#define DANFOSS_MIN .26
#define DANFOSS_MAX .74

const char *dataHeader = "DATA";
const char *gpsHeader = "GPS";
const char *settingsHeader = "SETTINGS";
const char *imuHeader = "IMU";

//////////////SETTINGS////////////
float Kp=45; //Mine was 38
float Ki=.02; //Mine was 0.02
float Kd=3100; //Mine was 2800
float delta_setpoint = 0;  

/////////////IMU///////////////
char *OG_data[255];
int16_t dataSize = sizeof(OG_data);


///////////// Com Bytes///////////////////////
byte b_Ki, b_Kp, b_Kd;
byte b_autoState = 0, b_deltaDir = 0, b_cutDelta = 0;
byte b_bladeOffsetOut = 0;
byte b_retDeadband = 25;
byte b_extDeadband = 75;
byte b_valveType = 255;   // 0= CNH    1= Deere     2= Danfoss
byte b_deadband = 2;


///////////////////PID/////////////////////////
float PID_p, PID_i, PID_d, PID_total;
float delta_previous_error, delta_error;

/////////////// CNH Valve /////////////////////////
uint16_t analogOutput1 = VALVE_FLOAT; //send to MCP4725
uint16_t analogOutput2 = VALVE_FLOAT; //send to MCP4725
int cut1 = -1;
double voltage = 0; // diagnostic Voltage
int retDeadband = 1845;
int extDeadband = 2250;
int retMin = (0.11 * 4096);   //450.56  CNH 
int extMax = (0.89 * 4096);   //3645
bool isAutoActive = false;
bool isCutting = false;

//loop time variables in milliseconds
const byte LOOP_TIME = 50; //20hz  
const unsigned int LOOP_TIME2 = 30000; //.033HZ    
const byte LOOP_TIME3 = 500; //2HZ  

unsigned long lastTime = LOOP_TIME;
unsigned long lastTime2 = LOOP_TIME2;
unsigned long lastTime3 = LOOP_TIME3;  
unsigned long currentTime = 0; 

//Communication with OpenGrade
bool isDataFound = false, isSettingFound = false;
int header = 0, tempHeader = 0, temp;

///////////////////////Initalize Objects///////////////////////
// I2C
TwoWire esp = TwoWire(5); 
// DAC's
Adafruit_MCP4725 Dac1 = Adafruit_MCP4725();
Adafruit_MCP4725 Dac2 = Adafruit_MCP4725();

void setup()
{  
  esp.begin(SDA_PIN , SCL_PIN);
  SetupGradeController();
  SetupUdp(); 

  Dac1.setVoltage(VALVE_FLOAT, false);
  Dac2.setVoltage(VALVE_FLOAT, false);
}
  

void loop(){  //Loop triggers every 50 msec (20hz) and sends back offsets Pid ect

  currentTime = millis();  
  SetOutput();  // Run PID Controller
  SetAutoState();  // Set Flags
  RecvUdpData();  // Read Udp Data if Available
   
  
  if (currentTime - lastTime >= LOOP_TIME)
  {  
    lastTime = currentTime;    
    SendUdpData(dataHeader);    
  }
  
  if (currentTime - lastTime2 >= LOOP_TIME2){ // Recv Data from OG 
    lastTime2 = currentTime;
    Reconnect();
  }
  
  if (currentTime - lastTime3 >= LOOP_TIME3){ // READ IMU data
    lastTime3 = currentTime;
  }
}

///
/// Functions
///


bool SetupGradeController()
{
  //set the baud rate
  DEBUG.begin(SERIAL_BAUD);  
  RTK.begin(115200, SERIAL_8N1, RXD2, TXD2); 

  digitalWrite(2, HIGH); delay(500); digitalWrite(2, LOW); delay(500); digitalWrite(2, HIGH); delay(500);
  digitalWrite(2, LOW); delay(500); digitalWrite(2, HIGH); delay(500); digitalWrite(2, LOW); delay(500);

  
  Dac1.begin(0x62, &esp);
  Dac2.begin(0x63, &esp); 

  return true;

}


bool SetAutoState(){
  if (b_deltaDir == 3){
    isCutting = false;
  }
  else{
    isCutting = true;
  }
  
  if (b_autoState == 1){
    isAutoActive = true;
    return true;
  }
  else {
    isAutoActive = false;
    return false;
    
  }     
}

void SetOutput()
{
  if (isAutoActive && isCutting){    
    analogOutput1 = VALVE_FLOAT;  
  
    if (b_deltaDir == 0){
      cut1 = -(int)b_cutDelta;
    }  
    else {
      cut1 = (int)b_cutDelta;
    }

    delta_error = (delta_setpoint) - cut1;

    PID_p = Kp * delta_error;// calculate the P errror  
    
    PID_d = Kd*((delta_error - delta_previous_error)/LOOP_TIME);// calculate the d error
    
    if(-b_deadband < delta_error && delta_error < b_deadband){  // 3 cm deadband for i
      PID_i = PID_i + (Ki * delta_error);//calculate the i error
    }
    else{
      PID_i = 0;
    }

    PID_total = PID_p + PID_i + PID_d;

    if (PID_total >  2300) PID_total = 2300;      
    if (PID_total <  -2300) PID_total = -2300;

    if (b_deltaDir == 1){ // Delta is Positive need to lower IMP RETRACT
      analogOutput1 = map(PID_total, 0.0, -2300, retDeadband , retMin);
    }
    else if (b_deltaDir == 0){// Delta is Negative need to raise IMP
      analogOutput1 = map(PID_total,  0.0, 2300, extDeadband, extMax);
    }
    
    if (analogOutput1 >= extMax) analogOutput1 = extMax; // do not exceed 4096
    if (analogOutput1 <= retMin) analogOutput1 = retMin; // do not write negative numbers 
    
    
    if (b_cutDelta < b_deadband){
      analogOutput1 = VALVE_FLOAT;
    }
    
    Dac1.setVoltage(analogOutput1, false);  
    voltage = ((double)analogOutput1/4096) * 5.0;
    delta_previous_error = delta_error;
  }
  else{
    analogOutput1 = VALVE_FLOAT;   
    Dac1.setVoltage(analogOutput1, false);
    voltage = ((double)analogOutput1/4096) * 5.0;                          
  }  
    
}

void SetValveLimits(){

  switch(b_valveType) {
  
    case CNH:
      retDeadband = VALVE_FLOAT - ((b_retDeadband/200.0)*4096);
      extDeadband = VALVE_FLOAT + ((b_extDeadband/200.0)*4096);    
      retMin = (CNH_MIN * 4096);
      extMax = (CNH_MAX * 4096);
      break;
      
    case DEERE:
      retDeadband = VALVE_FLOAT - ((b_retDeadband/200.0)*4096);
      extDeadband = VALVE_FLOAT + ((b_extDeadband/200.0)*4096);
      retMin = (DEERE_MIN * 4096);
      extMax = (DEERE_MIN * 4096);
      break;
      
    case DANFOSS:
      retDeadband = VALVE_FLOAT - ((b_retDeadband/200.0)*4096);
      extDeadband = VALVE_FLOAT + ((b_extDeadband/200.0)*4096);
      retMin = (DANFOSS_MIN * 4096);
      extMax = (DANFOSS_MAX * 4096);
      break;

    default:
      retDeadband = VALVE_FLOAT - ((b_retDeadband/200.0)*4096);
      extDeadband = VALVE_FLOAT + ((b_extDeadband/200.0)*4096);    
      retMin = (CNH_MIN * 4096);
      extMax = (CNH_MAX * 4096);
      
  }
}


///
/// UDP Stuff
///

bool SetupUdp(){  
  
  ConnectToOG();  
  UdpGradeControl.begin(gradeControlIP, gradeControlPort);
  
  return true;
}

void ConnectToOG() {
  WiFi.mode(WIFI_STA);
  WiFi.config(gradeControlIP , gatewayIP, Subnet);
  WiFi.begin(ssid);
  Serial.print("Connecting to WiFi ..");
  while (WiFi.status() != WL_CONNECTED) {
    Serial.print('.');
    delay(1000);
  }
  Serial.println(WiFi.localIP());
}

void Reconnect(){
  if (WiFi.status() != WL_CONNECTED) {
    DEBUG.print(millis());
    DEBUG.println("Reconnecting to WiFi...");
    WiFi.disconnect();
    WiFi.reconnect();   
  }
}


bool SendUdpData(const char * _dataType)
{  
  //SENDING
  UdpGradeControl.beginPacket(openGradeIP,openGradePort);   //Initiate transmission of data
  UdpGradeControl.print(_dataType);
  UdpGradeControl.print(",");
  UdpGradeControl.print(b_autoState);
  UdpGradeControl.print(",");    
  UdpGradeControl.print(voltage);     
  UdpGradeControl.print("\r\n");   // End segment    
  UdpGradeControl.endPacket();  // Close communication

  return true;
}

bool RecvUdpData()
{ 
  //DEBUG.print("RECV Func Called-> ");
  char *strings[20];
  char *ptr = NULL;  

  //RECEPTION
  int packetSize = UdpGradeControl.parsePacket();   // Size of packet to receive
  
  //if (!packetSize) DEBUG.println("Nothing Recieved");

  senderIP = UdpGradeControl.remoteIP();  //Sent from IP
  senderPort = UdpGradeControl.remotePort();  //Sent from IP

  if (packetSize) {       // If we received a package
    //DEBUG.print("UDP Message Recieved Bytes to Read->");
    UdpGradeControl.read(packetBuffer, sizeof(packetBuffer));  
    
    //DEBUG.println(packetBuffer);

    byte index = 0;
    ptr = strtok(packetBuffer, ",");  // takes a list of delimiters    
    
    while(ptr != NULL)
    {
      strings[index] = ptr;      
      index++;
      ptr = strtok(NULL, ",");  // takes a list of delimiters
    }
    
    for(int n = 0; n < index; n++)
    { 
      OG_data[n] = strings[n];        
    }
    
    // convert to int to read couldnt read PTR fro some rsn   
    header = atoi(OG_data[0]);         
      
    switch (header)
    {
      case DATA_HEADER:
        DEBUG.println("DATA");
        b_deltaDir =  atoi(OG_data[1]);   // Cut Delta Dir
        b_autoState =  atoi(OG_data[2]);    // Cut Delta 
        b_cutDelta =  atoi(OG_data[3]);   // Auto State
        return true;
      break;


      case SETTINGS_HEADER:
        DEBUG.println("SETTINGS FOUND!");      
        b_Kp = atoi(OG_data[1]);
        b_Ki = atoi(OG_data[2]);
        b_Kd = atoi(OG_data[3]);
        b_retDeadband = atoi(OG_data[4]);
        b_extDeadband = atoi(OG_data[5]);
        b_valveType = atoi(OG_data[6]);
        Kp = double(b_Kp);
        Ki = double(b_Ki / 100);
        Kd = double(b_Kp * 100);  
        SetValveLimits();
        return true;
      break;

      default:
      break;
    }  

    return true;
  }
  return false;
}
