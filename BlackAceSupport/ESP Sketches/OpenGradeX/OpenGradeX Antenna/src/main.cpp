#include <Arduino.h>
#include <WiFi.h>
#include <WiFiUdp.h>
#include <Adafruit_Sensor.h>
#include <Adafruit_MCP4725.h>
#include <Adafruit_BNO055.h>
#include <utility/imumaths.h>
#include <SPI.h>
#include <Wire.h>


/* Board layout:
            Front
         +----------+
         |         *| RST   PITCH  ROLL  HEADING
     ADR |*        *| SCL
     INT |*        *| SDA     ^            /->
     PS1 |*        *| GND     |            |
     PS0 |*        *| 3VO     Y    Z-->    \-X
         |         *| VIN
         +----------+
*/


// Function STUBS for Platform IO

//GRADE CONTROL
// bool SetAutoState();
// void GetGradeControlData();
// void SetOutput();
// void SetValveLimits();

//SERIAL
bool SetupGradeController();
void RecvSerialPortData();
void SendDataToPort();
void ClearSerialBuff();
// IMU
bool SetupIMU();
void GetIMUData();
// UDP
void RecvGPSDAta();
void SendGPSOverUDP();
bool SetupUdp();
bool SendUdpData(const char *_dataHeader);
bool RecvUdpData();

/// UDP Variables
WiFiUDP UdpAntenna;  // Creation of wifi UdpAntenna instance
const char *ssid = {"OpenGradeX"};
char buff[1025];
char GNGGA[1000];
char GNVTG[1000];
char packetBuffer[255];

///Ports
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
#define DAC1_ENABLE 4      // DAC 1 enable/
#define DAC2_ENABLE 5     //  DAC 2 enable/
#define SCL_PIN 22      // I2C SCL PIN
#define SDA_PIN 21      // I2C SCL PIN
#define RXD2 16  // Diagnostic RX
#define TXD2 17 // Diagnostic TX
#define IMU_ID 1200
#define CONST_180_DIVIDED_BY_PI 57.2957795130823
#define BNO055_SAMPLERATE_DELAY_MS (95)
//UDP HEADERS
#define DATA_HEADER 10001
#define SETTINGS_HEADER 10002
#define GPS_HEADER 10003
#define IMU_HEADER 10004
#define DEBUG Serial
#define RTK Serial1

const char *dataHeader = "DATA";
const char *gpsHeader = "GPS";
const char *settingsHeader = "SETTINGS";
const char *imuHeader = "IMU";

/////////////IMU///////////////
char *OG_data[255];
int16_t dataSize = sizeof(OG_data);
float headingIMU = 0;
float rollIMU = 0;
float pitchIMU = 0;
int16_t bno08xHeading10x = 0;
int16_t bno08xRoll10x = 0;

//loop time variables in milliseconds
const byte LOOP_TIME = 50; //20hz  Send Serial Loop 
const byte LOOP_TIME2 = 5; //100HZ    Recv Serial Loop
const byte LOOP_TIME3 = BNO055_SAMPLERATE_DELAY_MS; //10HZ  Poll IMU Loop

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
// IMU
Adafruit_BNO055 bnoIMU = Adafruit_BNO055(IMU_ID, 0x28, &esp);  


void setup()
{  
  esp.begin(SDA_PIN , SCL_PIN);
  SetupGradeController();
  SetupUdp();
  SetupIMU();

}
  

void loop(){  //Loop triggers every 50 msec (20hz) and sends back offsets Pid ect

  currentTime = millis();  // Send GradeControl Data to OG  
  RecvGPSDAta();
  RecvUdpData();
  
  
  if (currentTime - lastTime >= LOOP_TIME)
  {  
    lastTime = currentTime;
  }
  
  if (currentTime - lastTime2 >= LOOP_TIME2){ // Recv Data from OG 
    lastTime2 = currentTime;
  }
  
  if (currentTime - lastTime3 >= LOOP_TIME3){ // READ IMU data
    lastTime3 = currentTime;
    GetIMUData();
    SendUdpData(imuHeader);

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
 

  return true;

}

bool SetupIMU()
{  
  if(!bnoIMU.begin())
  {
    /* There was a problem detecting the BNO055 ... check your connections */
    Serial.print("NO IMU");
    while(1);
  }   
   
  /* Use external crystal for better accuracy */
  bnoIMU.setExtCrystalUse(true);
  return true;
}

void GetIMUData()
{  
  /* Get a new sensor event*/ 
  sensors_event_t event;
  bnoIMU.getEvent(&event);  
  
  headingIMU = (360 - (float)event.orientation.x); // YAW  
  pitchIMU = ((float)event.orientation.y); // PITCH
  rollIMU = ((float)event.orientation.z); // ROLL   
}


///
/// UDP Stuff
///

void RecvGPSDAta(){
    
  if(RTK.available()){   
    
    int size = RTK.readBytesUntil('\n', buff, sizeof(buff));  
    for(int h = 0; h < size; h++) 
    {
      GNVTG[h] = buff[h];    
      //UdpAntenna.print(buff[i]);
    }
    memset(buff, 0, sizeof(buff)); // clear buff   
    
    int size2 = RTK.readBytesUntil('\n', buff, sizeof(buff));
    for(int h = 0; h < size2; h++) 
    {
      GNGGA[h] = buff[h];    
      //UdpAntenna.print(buff[i]);
    }
    memset(buff, 0, sizeof(buff)); // clear buff 

    //SENDING
    SendGPSOverUDP();
    
  }
}


void SendGPSOverUDP(){
  
  UdpAntenna.beginPacket(openGradeIP,openGradePort);   //Initiate transmission of data
  UdpAntenna.print(gpsHeader);
  UdpAntenna.print(",");
  UdpAntenna.print(GNGGA);
  UdpAntenna.print(GNVTG);
  UdpAntenna.print("\r\n"); // End segment    
  UdpAntenna.endPacket();  // Close communication
  
  memset(buff, 0, sizeof(buff));
  memset(GNGGA, 0, sizeof(GNGGA));
  memset(GNGGA, 0, sizeof(GNGGA)); // clear buff

}

bool SetupUdp(){  
  
  WiFi.mode(WIFI_AP);
  WiFi.softAP(ssid);
  delay(100);
  
  WiFi.softAPConfig(antennaIP, gatewayIP, Subnet);  

  DEBUG.println(ssid);
  DEBUG.println(WiFi.softAPIP());
  
  UdpAntenna.begin(antennaIP, antennaPort);
  
 
  return true;
}

bool SendUdpData(const char * _dataType)
{  
  //SENDING
  UdpAntenna.beginPacket(openGradeIP,openGradePort);   //Initiate transmission of data
  UdpAntenna.print(_dataType);  
  UdpAntenna.print(",");
  UdpAntenna.print(headingIMU);
  UdpAntenna.print(",");
  UdpAntenna.print(pitchIMU);
  UdpAntenna.print(",");
  UdpAntenna.print(rollIMU);      
  UdpAntenna.print("\r\n");   // End segment    
  UdpAntenna.endPacket();  // Close communication

  return true;
}

bool RecvUdpData()
{ 
  //DEBUG.print("RECV Func Called-> ");
  char *strings[20];
  char *ptr = NULL;  

  //RECEPTION
  int packetSize = UdpAntenna.parsePacket();   // Size of packet to receive
  
  //if (!packetSize) DEBUG.println("Nothing Recieved");

  senderIP = UdpAntenna.remoteIP();  //Sent from IP
  senderPort = UdpAntenna.remotePort();  //Sent from IP

  if (packetSize) {       // If we received a package
    //DEBUG.print("UDP Message Recieved Bytes to Read->");
    UdpAntenna.read(packetBuffer, sizeof(packetBuffer));  
    
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
    
    // convert to int to read couldn't read PTR for some rsn   
    header = atoi(OG_data[0]);         
      
    switch (header)
    {
      case DATA_HEADER:
        DEBUG.println("DATA");        
        return true;
      break;

      case SETTINGS_HEADER:
        DEBUG.println("SETTINGS FOUND!"); 
        return true;
      break;

      case IMU_HEADER:
        DEBUG.println("IMU FOUND!"); 
        return true;
      break;

      case GPS_HEADER:
        DEBUG.println("GPS FOUND!"); 
        return true;
      break;

      default:
      break;
    }
    return true;
  }
  return false;
}

