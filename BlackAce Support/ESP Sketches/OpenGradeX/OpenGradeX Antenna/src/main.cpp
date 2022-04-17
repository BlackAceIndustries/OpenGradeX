/*
  * UDP Antenna Module Code
  * For OpenGradeX   ONLY WORKS WITH OPENGRADEX NOT REGULAR OPENGRADE
  * 4 Feb 2022, Black Ace 
  * Like all code - copied from somewhere else
  * So don't claim it as your own
  *
  * Huge Thanks to Brian Tischler For doing all the legwork to make projects like this possible  
  * Check out his Git-Hub https://github.com/farmerbriantee   
*/
#include <Arduino.h>
#include <WiFi.h>
#include "WiFiUdp.h"
#include <Adafruit_Sensor.h>
#include <Adafruit_BNO055.h>
#include <utility/imumaths.h>
#include <SPI.h>
#include <Wire.h>
/* IMU Board layout:
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

/////////////////
//BUILD VERSION//
/////////////////
const char *version = "1.3.4.0";

//////////////////////////////////
//Function STUBS for Platform IO//
//////////////////////////////////

// ANTENNA MODULE
bool SetupAntennaModule();
// IMU
bool SetupIMU();
void GetIMUData();
// UDP
bool SetupUdp();
void RelayGPSData();
bool SendUdpData(int _header);
bool RecvUdpData();
// WIFI
bool SetupAP();
void ConnectToHotSpot(); 
int ScanForWifi();


/// UDP Variables
WiFiUDP UdpAntenna;  // Creation of wifi UdpAntenna instance
const char *ssid = {"OpenGradeX"};
char *hotspotSSID; 
char *hotspotSSID_Pass;
char buff[1024];
char GNGGA[1000];
char GNVTG[1000];

String SSID[40];
String RSSI[40];
String SSID_PASS[40];
char *ssid2;
char *pass2;
char packetBuffer[2048];
char *OG_data[1024];

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
#define DEBUG_BAUD 460800
#define RTK_BAUD 460800
#define DAC1_ENABLE 4      // DAC 1 enable/
#define DAC2_ENABLE 5     //  DAC 2 enable/
#define SCL_PIN 22      // I2C SCL PIN
#define SDA_PIN 21      // I2C SCL PIN
#define RXD2 16  // RTK2B RX
#define TXD2 17 // RTK2B TX
#define DEBUG Serial
#define RTK Serial1
#define IMU_ID 1200
#define CONST_180_DIVIDED_BY_PI 57.2957795130823
#define BNO055_SAMPLERATE_DELAY_MS (95)

//UDP HEADERS
#define DATA_HEADER 10001
#define SETTINGS_HEADER 10002
#define GPS_HEADER 10003
#define IMU_HEADER 10004
#define NTRIP_HEADER 10005

#define RESET_HEADER 10100
#define SYSTEM_HEADER 10101
#define WIFI_HEADER 10102


/////////////IMU///////////////

int16_t dataSize = sizeof(OG_data);
float rawHeadingIMU = 0;
float rawRollIMU = 0;
float rawPitchIMU = 0;
float headingIMU = 0;
float rollIMU = 0;
float pitchIMU = 0;
float headingIMUSetPos= 0;
float rollIMUSetPos = 0;
float pitchIMUSetPos = 0;

////////////TIMING//////////

//loop time variables in milliseconds
const long LOOP_TIME = 50; //20hz  Send Serial Loop 
const long LOOP_TIME2 = 15000; //100HZ    Recv Serial Loop
const long LOOP_TIME3 = BNO055_SAMPLERATE_DELAY_MS; //10HZ  Poll IMU Loop

unsigned long lastTime = LOOP_TIME;
unsigned long lastTime2 = LOOP_TIME2;
unsigned long lastTime3 = LOOP_TIME3;  
unsigned long currentTime = 0; 

//Communication with OpenGradeX
bool isDataFound = false, isSettingFound = false;
int header = 0, tempHeader = 0, temp;
bool isOGXConnected = false;
unsigned long watchdogTimer = 0;   //make sure we are talking to OGX
const int OGXTimeout = 50;    
bool isRtcmNext = false;

///////////////////////Initalize Objects///////////////////////
// I2C
TwoWire esp = TwoWire(5);
// IMU
Adafruit_BNO055 bnoIMU = Adafruit_BNO055(IMU_ID, 0x28, &esp);  


void setup()
{   
  SetupAntennaModule();
}
  

void loop(){ 

  currentTime = millis();  //  
  RelayGPSData();  // Relay serial to UDP
  RecvUdpData();  // Receive commands from OPENGRADEX
  
  
  if (currentTime - lastTime >= LOOP_TIME)
  {  
    watchdogTimer++;
    lastTime = currentTime;

    if (watchdogTimer > OGXTimeout){
      isOGXConnected = false;
      digitalWrite(BUILTIN_LED, LOW);
    }    
    else{
      isOGXConnected = true;
      digitalWrite(BUILTIN_LED, HIGH); // make sure connected to OGX   Time
    }
      
    if (watchdogTimer > OGXTimeout*50000) watchdogTimer = 50; // Prevent overflow

  }
  
  if (currentTime - lastTime2 >= LOOP_TIME2){ // every 15 seconds
    lastTime2 = currentTime;
    SendUdpData(SYSTEM_HEADER);
  }
  
  if (currentTime - lastTime3 >= LOOP_TIME3){ // READ IMU data 10hz
    lastTime3 = currentTime;
    GetIMUData();
    SendUdpData(IMU_HEADER);

  }
}

///
/// Functions
///


/////////////////
//ANTENNAMODULE// 
/////////////////

bool SetupAntennaModule()
{
  
  pinMode(BUILTIN_LED, OUTPUT);  // Initialize the BUILTIN_LED pin as an output
  esp.begin(SDA_PIN , SCL_PIN);
  //set the baud rate
  DEBUG.begin(DEBUG_BAUD);  
  RTK.begin(460800, SERIAL_8N1, RXD2, TXD2); 

  digitalWrite(2, HIGH); delay(500); digitalWrite(2, LOW); delay(500); digitalWrite(2, HIGH); delay(500);
  digitalWrite(2, LOW); delay(500); digitalWrite(2, HIGH); delay(500); digitalWrite(2, LOW); delay(500);
 
  SetupAP();
  SetupUdp();
  SetupIMU();

  return true;

}

///////
//IMU//
///////

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
  
  rawHeadingIMU = (360 - (float)event.orientation.x); // YAW  
  rawPitchIMU = ((float)event.orientation.y); // PITCH
  rawRollIMU = ((float)event.orientation.z); // ROLL

  headingIMU = rawHeadingIMU - headingIMUSetPos; // YAW  
  pitchIMU = rawPitchIMU - pitchIMUSetPos; // PITCH
  rollIMU = rawRollIMU -rollIMUSetPos; // ROLL 
}

///////
//UDP// 
///////

void RelayGPSData(){
    
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
    SendUdpData(GPS_HEADER);
    
  }
}

bool SetupUdp(){
  UdpAntenna.begin(antennaIP, antennaPort);
 
  return true;
}

bool SendUdpData(int _header)
{ 
  switch (_header){
    case DATA_HEADER:      
      
      break;


    case SETTINGS_HEADER:
    
        break;

    case GPS_HEADER:
        bool sent;
        UdpAntenna.beginPacket(openGradeIP,openGradePort);   //Initiate transmission of data
        UdpAntenna.print(_header);
        UdpAntenna.print(",");
        UdpAntenna.print(GNGGA);
        UdpAntenna.print(GNVTG);
        UdpAntenna.print("\r\n"); // End segment    
        sent = UdpAntenna.endPacket();  // Close communication
        
        while (RTK.available()){
          RTK.read();
        }

        if (!sent && errno == 5){
          ESP.restart();    
        } 
        
        memset(buff, 0, sizeof(buff));
        memset(GNGGA, 0, sizeof(GNGGA));
        memset(GNVTG, 0, sizeof(GNVTG)); // clear buff
              
        break;

    case IMU_HEADER:
      //SENDING
      UdpAntenna.beginPacket(openGradeIP,openGradePort);   //Initiate transmission of data
      UdpAntenna.print(_header);  
      UdpAntenna.print(",");
      UdpAntenna.print(headingIMU);
      UdpAntenna.print(",");
      UdpAntenna.print(pitchIMU);
      UdpAntenna.print(",");
      UdpAntenna.print(rollIMU);      
      UdpAntenna.print("\r\n");   // End segment    
      UdpAntenna.endPacket();  // Close communication
        
        break;

    case RESET_HEADER:
        break;

    case SYSTEM_HEADER:
      UdpAntenna.beginPacket(openGradeIP,openGradePort);   //Initiate transmission of data
      UdpAntenna.print(_header);
      UdpAntenna.print(",");
      UdpAntenna.print(155);
      UdpAntenna.print(",");
      UdpAntenna.print(version);     
      UdpAntenna.print("\r\n");   // End segment    
      UdpAntenna.endPacket();  // Close communication    
         

        break;

    case WIFI_HEADER:    
      
      //int n = sizeof(SSID);
      UdpAntenna.beginPacket(openGradeIP,openGradePort);   //Initiate transmission of data
      UdpAntenna.print(_header);
      DEBUG.print(_header);
      for (int i = 0; i < 5; ++i) {      
        UdpAntenna.print(",");
        UdpAntenna.print(SSID[i]);
        DEBUG.print(",");
        DEBUG.print(SSID[i]); 
      }
      DEBUG.print("END\r\n"); 
      UdpAntenna.print("\r\n");   // End segment    
      UdpAntenna.endPacket();  // Close communication  
      
    break;


    //default:
      //break; 
  }

  return true;
}

bool RecvUdpData()
{ 
  
  char *strings[1460];
  char *ptr = NULL; 
  

  //RECEPTION
  int packetSize = UdpAntenna.parsePacket();   // Size of packet to receive  
  
  senderIP = UdpAntenna.remoteIP();  //Sent from IP
  senderPort = UdpAntenna.remotePort();  //Sent from IP

  if (packetSize) {       // If we received a package

    UdpAntenna.read(packetBuffer, sizeof(packetBuffer));      
    
    watchdogTimer = 0;   
    DEBUG.print("Num Bytes Recv-> ");
    DEBUG.println(packetSize);

    int index = 0;
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
      

      case GPS_HEADER:
        DEBUG.println("GPS FOUND!"); 
        return true;
      break;
  
      case IMU_HEADER:
          DEBUG.println("IMU FOUND!");
          headingIMUSetPos = rawHeadingIMU;
          pitchIMUSetPos = rawPitchIMU;
          rollIMUSetPos = rawRollIMU; 
          return true;
        break;

      case NTRIP_HEADER:

        isRtcmNext = true;  
        return true;
      break;



      case RESET_HEADER:
        ESP.restart(); 
        return true;
      break;

      case SYSTEM_HEADER:     
        
        if (atoi(OG_data[1]) != 0){
          SendUdpData(SYSTEM_HEADER);
        }
        digitalWrite(BUILTIN_LED, HIGH);
                  

      break;

      case WIFI_HEADER:
                
        switch (atoi(OG_data[1])){
          
          case 1:          
            ScanForWifi();
            SendUdpData(WIFI_HEADER);
          break;
          
          case 2:         
            hotspotSSID = OG_data[2]; 
            hotspotSSID_Pass = OG_data[3];
            DEBUG.println(hotspotSSID);
            DEBUG.println(hotspotSSID_Pass);
            ConnectToHotSpot();         

          break;

        }          
        
      break;

      //default:
      //break;
    }

    if (packetSize > 100 && packetSize < 1024 && isRtcmNext) {    ///  This is a Very bad thing to do if this program crashes it is because of these                 
      RTK.write(packetBuffer, sizeof(packetBuffer));  /// lines of code....... that being said im going to do it anyways cause im lazy   
      isRtcmNext = false;                
    }

    memset(packetBuffer, 0, sizeof(packetBuffer));
    memset(OG_data, 0, sizeof(OG_data));
    return true;
  }

  memset(packetBuffer, 0, sizeof(packetBuffer));
  memset(OG_data, 0, sizeof(OG_data));
  UdpAntenna.flush();
  return false;
}

////////
//WIFI//
////////

bool SetupAP(){  
  
  WiFi.mode(WIFI_AP_STA);
  WiFi.softAP(ssid);
  delay(100);
  
  if (WiFi.softAPConfig(antennaIP, gatewayIP, Subnet)){
    //digitalWrite(BUILTIN_LED, HIGH); // Turn the LED on (Note that LOW is the voltage level but actually the LED is on; this is because it is active low on the ESP-01)
  }  

  DEBUG.println(ssid);
  DEBUG.println(WiFi.softAPIP()); 
  
  return true;
}

void ConnectToHotSpot() {  

  //WiFi.setHostname(ssid);

  int curTime = millis();
  int timer = 0;
  int dur = 0;

  WiFi.begin(hotspotSSID, hotspotSSID_Pass);  
  while (WiFi.status() != WL_CONNECTED && timer - curTime  < dur) {
    
    timer = millis();
    
  }
  
}

int ScanForWifi(){
  // WiFi.scanNetworks will return the number of networks found
  int n = WiFi.scanNetworks();
  
  if (n != 0) {    
    
    for (int i = 0; i < n; ++i) {      
      
            
      SSID[i] = WiFi.SSID(i);      
      RSSI[i] = WiFi.RSSI(i);     
    }
    
  }  
  return n;

}




