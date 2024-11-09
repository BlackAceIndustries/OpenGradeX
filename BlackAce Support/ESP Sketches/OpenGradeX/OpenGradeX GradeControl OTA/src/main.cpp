/*
  * UDP Grade Control Module Code
  * For OpenGradeX   ONLY WORKS WITH OPENGRADEX NOT REGULAR OPENGRADE
  * 4 Feb 2022, Black Ace 
  * Like all Arduino code - copied from somewhere else
  * So don't claim it as your own
  *
  * Huge Thanks to Brian Tischler For doing all the legwork to make projects like this possible  
  * Check out his Git-Hub https://github.com/farmerbriantee   
*/
#include <Arduino.h>
#include <WiFi.h>
#include <WiFiUdp.h>
#include <ArduinoOTA.h>
#include <ESPmDNS.h>
#include <Adafruit_Sensor.h>
#include <Adafruit_MCP4725.h>
#include <Adafruit_BNO055.h>
#include <utility/imumaths.h>
#include <SPI.h>
#include <Wire.h>
#include <ArduinoJson.h>
#include "messages.h"
#include <iostream>
#include <string>

#include <FS.h>
#include <LittleFS.h>

///
/// BUILD VERSION
///
const char *hwVersion = "1.2.2.0";
const char *fwVersion = "2.3.1.0";

// Function STUBS for Platform IO

// GRADECONTROL
bool SetupGradeControlModule();
bool SetAutoState();
void SetOutput();
void SetOutput2();
void SetValveLimits();

// UDP
bool SetupUdp();
bool SendUdpData(int _header);
bool RecvUdpData();
bool SendUdpDataJSON(uint8_t moduleType, uint8_t msgType, uint8_t _msgID);
bool RecvUdpDataJSON();

// WIFI
void ConnectToOGX();
void ReconnectToOGX();

// OTA
void CheckForUpdate();
void loadSettings();
void saveSettings();


struct_message_GradeControl_data gcDataMsg;
struct_message_GradeControl_settings gcSettingsMsg;
struct_message_Firmware gcFirmwareMsg;
struct_message_Connect connectMsg;


/// UDP Variables
WiFiUDP UdpGradeControl;  // Creation of wifi UdpGradeControl instance
const char *ssid = {"OGX"};

char packetBuffer[1460];
uint16_t openGradePort = 9999; //OpenGrade Server Port
uint16_t gradeControlPort = 7777; // GradeControl  Port
uint16_t antennaPort = 8888; // Antenna Port
uint16_t senderPort;
///Ip Addresses
IPAddress openGradeIP(192,168,1,226);   //OpenGradeX Server
IPAddress gradeControlIP(192,168,1,229);   // GradeControl Module IP
IPAddress antennaIP(192,168,1,225);   // Antenna Module IP
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
#define AUTO_ENGAGE 23 // Diagnostic TX
#define PWM_DRIVE 12 // Diagnostic TX
#define PWM_DIR 14 // Diagnostic TX

#define CONST_180_DIVIDED_BY_PI 57.2957795130823
#define DEBUG Serial
#define RTK Serial1

//UDP HEADERS
#define DATA_HEADER 10001
#define SETTINGS_HEADER 10002
#define GPS_HEADER 10003
#define IMU_HEADER 10004
#define RESET_HEADER 10100
#define SYSTEM_HEADER 10101
#define WIFI_HEADER 10102

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

// setting PWM properties
#define PWM_Channel1  0
#define PWM_Channel2  1
#define PWM_Resolution 8
#define PWM_Frequency 5000


float delta_setpoint = 0;  

/////////////PID VALUES/////////////
float PID_p, PID_i, PID_d, PID_previous , PID_total;
float delta_previous_error, delta_error;

/////////////IMU///////////////
char *OG_data[1460];
int16_t dataSize = sizeof(OG_data);





byte b_bladeOffsetOut = 0;


/////////////// CNH Valve /////////////////////////
uint16_t analogOutput1 = VALVE_FLOAT; //send to MCP4725
uint16_t analogOutput2 = VALVE_FLOAT; //send to MCP4725
uint8_t PWMOutput = 0;
uint8_t PWMDir = 0;
int cut1 = -1;

int retDeadband = 1845;
int extDeadband = 2250;
int retMin = (0.11 * 4096);   //450.56  CNH 
int extMax = (0.89 * 4096);   //3645
bool isAutoActive = false;
bool isCutting = false;

//loop time variables in milliseconds
const u16_t LOOP_TIME = 50; //20hz  
const u16_t LOOP_TIME2 = 30000; //.033HZ    
const u16_t LOOP_TIME3 = 100; //2HZ  

unsigned long lastTime = LOOP_TIME;
unsigned long lastTime2 = LOOP_TIME2;
unsigned long lastTime3 = LOOP_TIME3;  
unsigned long currentTime = 0; 

//Communication with OpenGradeX
bool isOGXConnected = false;
const int OGXTimeout = 50;
unsigned long watchdogTimer = OGXTimeout;   //make sure we are talking to OGX
 


///////////////////////Initalize Objects///////////////////////
// I2C
TwoWire esp = TwoWire(5); 
// DAC's
Adafruit_MCP4725 Dac1 = Adafruit_MCP4725();
Adafruit_MCP4725 Dac2 = Adafruit_MCP4725();

void setup()
{ 
  if (!LittleFS.begin(true)) {
    Serial.println("An Error has occurred while mounting LittleFS");
    return;
  }
  loadSettings();
  ConnectToOGX();  
  SetupGradeControlModule();  
  CheckForUpdate(); 
 
}
  

void loop(){  //Loop triggers every 50 msec (20hz) and sends back offsets Pid ect

  currentTime = millis();  
  ArduinoOTA.handle();
  SetOutput2();  // Run PID Controller  
  RecvUdpDataJSON(); 
  if(digitalRead(AUTO_ENGAGE) == LOW)
  {
    gcDataMsg.autoVert = false;
    gcDataMsg.autoTilt = false;
    //SendUdpDataJSON(int(Grade_Control_Slave), Data, 1 );
  }
  
  if (currentTime - lastTime >= LOOP_TIME) // 10 HZ
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
    
    (watchdogTimer > OGXTimeout*5000)? watchdogTimer = 50 : watchdogTimer; // Prevent overflow
    
    
  }
  
  if (currentTime - lastTime2 >= LOOP_TIME2){ // .33 HZ
    lastTime2 = currentTime;
    ReconnectToOGX();
    //SendUdpData(SYSTEM_HEADER);  // Send System info to OenGradeX
  }
  
  if (currentTime - lastTime3 >= LOOP_TIME3){ // 2 HZ
    lastTime3 = currentTime;
    if(isOGXConnected){
      SendUdpDataJSON(int(Grade_Control_Slave), Data, 1 );     

    }
  }
}

////////////////
//GRADECONTROL// 
////////////////

bool 
SetupGradeControlModule()
{
  // Configure LED PWM channel
  ledcSetup(PWM_Channel1, PWM_Frequency, PWM_Resolution);
  
  pinMode(BUILTIN_LED, OUTPUT);  // Initialize the BUILTIN_LED pin as an output
  pinMode(AUTO_ENGAGE, INPUT_PULLUP);  // Initialize the BUILTIN_LED pin as an output

  
  
  
  
  ledcAttachPin(PWM_DRIVE, PWM_Channel1 );  // MOTOR DRIVE A

  pinMode(PWM_DIR, OUTPUT);  // Initialize the BUILTIN_LED pin as an output


  esp.begin(SDA_PIN , SCL_PIN);
  //set the baud rate
  DEBUG.begin(SERIAL_BAUD);    

  digitalWrite(2, HIGH); delay(20); digitalWrite(2, LOW); delay(20); digitalWrite(2, HIGH); delay(20);
  digitalWrite(2, LOW); delay(20); digitalWrite(2, HIGH); delay(20); digitalWrite(2, LOW); delay(20);

  Dac1.begin(0x62, &esp);
  Dac2.begin(0x63, &esp);

  SetupUdp(); 

  Dac1.setVoltage(VALVE_FLOAT, false);
  Dac2.setVoltage(VALVE_FLOAT, false); 

   

  return true;

}

void SetOutput2(){
 
    // Early exit if pre-conditions are not met
    if (!gcDataMsg.autoVert || !isOGXConnected) {
        analogOutput1 = VALVE_FLOAT;
        analogOutput2 = VALVE_FLOAT;
        gcDataMsg.setPointA = analogOutput1;
        gcDataMsg.setPointB = analogOutput2;
        Dac1.setVoltage(analogOutput1, false);
        Dac2.setVoltage(analogOutput2, false);
        ledcWrite(PWM_Channel1, 0);
        return;
    }

    double delta_error = delta_setpoint - (double)gcDataMsg.deltaA;

    double delta_abs = abs(delta_error);
    
    
    PID_p = double(gcSettingsMsg.KP) * delta_abs;
    
    PID_d = double(gcSettingsMsg.KD) * 100 * (delta_abs - delta_previous_error) / LOOP_TIME;

    //PID_i = PID_previous; // Store the integral component for the next iteration
    
    // // if (gcSettingsMsg.retDead < delta_abs && delta_abs < gcSettingsMsg.extDead) {
    // //   PID_i = PID_previous + (double(gcSettingsMsg.KI)*.01 * delta_error);      
    // // }



    if ( 20 > delta_abs && delta_abs > 1){
      PID_i = PID_previous + (double(gcSettingsMsg.KI) * .001  * delta_abs);      
      //Serial.println(PID_i);
    }
    else
    {
      PID_previous = 0;
      PID_i=0;
    }       
      PID_total = PID_p + PID_i + PID_d;
    
    if (PID_total >  4096) PID_total = 4096;       

    if (gcDataMsg.deltaA > 0) {
      analogOutput1 = map(PID_total, 0.0, 4096, gcSettingsMsg.retDead, retMin);      
      PWMOutput = map(PID_total, 0.0, 4096, abs((gcSettingsMsg.retDead - VALVE_FLOAT)/16), 255);
      PWMDir = 0;
    }
    else if (gcDataMsg.deltaA < 0) {
      analogOutput1 = map(PID_total, 0.0, 4096, gcSettingsMsg.extDead, extMax);
      PWMOutput = map(PID_total, 0.0, 4096, abs((gcSettingsMsg.extDead- VALVE_FLOAT)/16), 255);
      PWMDir = 1;
    }
    else {
      analogOutput1 = VALVE_FLOAT;

    }


    if (analogOutput1 >= extMax) analogOutput1 = extMax; // do not exceed 4096
    if (analogOutput1 <= retMin) analogOutput1 = retMin; // do not write negative numbers 


    gcDataMsg.setPointA = analogOutput1;
    gcDataMsg.setPointB = PWMOutput; // Ensure analogOutput2 is set correctly elsewhere in the code

   

    delta_previous_error = delta_abs;
     PID_previous = PID_i; // Store the integral component for the next iteration
    digitalWrite(PWM_DIR , PWMDir);
    ledcWrite(PWM_Channel1, PWMOutput);
    Dac1.setVoltage(analogOutput1, false);
    Dac2.setVoltage(analogOutput2, false);
}


// void SetOutput()
// {
//   if (gcDataMsg.autoVert  && isOGXConnected){    //&& isCutting
    
//     analogOutput1 = VALVE_FLOAT;    
//     delta_error = (delta_setpoint) - gcDataMsg.deltaA;
    
//     PID_p = double(gcSettingsMsg.KP) * delta_error;// calculate the P errror  
    
//     PID_d = double(gcSettingsMsg.KD)*((delta_error - delta_previous_error)/LOOP_TIME);// calculate the d error
    
//     if(gcSettingsMsg.retDead < delta_error && delta_error < gcSettingsMsg.extDead){  // 3 cm deadband for i
//       PID_i = PID_i + (double(gcSettingsMsg.KI) * delta_error);//calculate the i error
//     }
//     else{
//       PID_i = 0;
//     }

//     PID_total = PID_p + PID_i + PID_d;
//     Serial.println(PID_total);
//     if (PID_total >  2300) PID_total = 2300;      
//     if (PID_total <  -2300) PID_total = -2300;

//     if (gcDataMsg.deltaA >= 0){ // Delta is Positive need to lower IMP RETRACT
//       analogOutput1 = map(PID_total, 0.0, -2300, gcSettingsMsg.retDead , retMin);
//     }
//     else if (gcDataMsg.deltaA < 0){// Delta is Negative need to raise IMP
//       analogOutput1 = map(PID_total,  0.0, 2300, gcSettingsMsg.extDead, extMax);
//     }
    
//     if (analogOutput1 >= extMax) analogOutput1 = extMax; // do not exceed 4096
//     if (analogOutput1 <= retMin) analogOutput1 = retMin; // do not write negative numbers 
    
//     //  if (gcDataMsg.deltaA < 1.5){
    
//     //    analogOutput1 = VALVE_FLOAT;
//     //    gcDataMsg.setPointA = ((double)(VALVE_FLOAT/4096.0) * 100);
//     //    gcDataMsg.setPointB = ((double)(VALVE_FLOAT/4096.0) * 100);
//     //  }
//      //else
//      //{ 
//        //gcDataMsg.setPointA = ((double)(analogOutput1/4096.0) * 1000);
//        //gcDataMsg.setPointB = ((double)(analogOutput2/4096.0) * 1000); 
    
//       gcDataMsg.setPointA = analogOutput1;
//       gcDataMsg.setPointB = analogOutput2; 
//     //}
    
//     //Serial.println(gcDataMsg.setPointA);
    
    
//     delta_previous_error = delta_error;
//   }
//   else{
    
//     analogOutput1 = VALVE_FLOAT;
//     analogOutput2 = VALVE_FLOAT;       
//     gcDataMsg.setPointA = analogOutput1;
//     gcDataMsg.setPointB = analogOutput2; 
//   }  
  
//   Dac1.setVoltage(analogOutput1, false);
//   Dac2.setVoltage(analogOutput2, false);

    
// }

void SetValveLimits(){

  switch(gcSettingsMsg.ValveType) {
  
    case CNH:
      gcSettingsMsg.retDead = VALVE_FLOAT - ((gcSettingsMsg.retDead/200.0)*4096);
      gcSettingsMsg.extDead = VALVE_FLOAT + ((gcSettingsMsg.extDead/200.0)*4096);    
      retMin = (CNH_MIN * 4096);
      extMax = (CNH_MAX * 4096);
      break;
      
    case DEERE:
      gcSettingsMsg.retDead = VALVE_FLOAT - ((gcSettingsMsg.retDead/200.0)*4096);
      gcSettingsMsg.extDead = VALVE_FLOAT + ((gcSettingsMsg.extDead/200.0)*4096);
      retMin = (DEERE_MIN * 4096);
      extMax = (DEERE_MIN * 4096);
      break;
      
    case DANFOSS:
      gcSettingsMsg.retDead = VALVE_FLOAT - ((gcSettingsMsg.retDead/200.0)*4096);
      gcSettingsMsg.extDead = VALVE_FLOAT + ((gcSettingsMsg.extDead/200.0)*4096);
      retMin = (DANFOSS_MIN * 4096);
      extMax = (DANFOSS_MAX * 4096);
      break;

    default:
      gcSettingsMsg.retDead - ((gcSettingsMsg.retDead/200.0)*4096);
      gcSettingsMsg.extDead + ((gcSettingsMsg.extDead/200.0)*4096);    
      retMin = (CNH_MIN * 4096);
      extMax = (CNH_MAX * 4096);
      
  }
}

///////
//UDP// 
///////

bool SetupUdp(){ 
  
  UdpGradeControl.begin(gradeControlIP, gradeControlPort); //  this UDP address and port  
  return true;
}

bool SendUdpDataJSON(uint8_t _moduleType, uint8_t _msgType, uint8_t _modID)
{ 
  StaticJsonDocument<1000> root;
  String payload;
  bool sent;
  switch (_msgType){
    case Connect: 
      // root["modType"] = connectMsg.modType;
      // root["msgType"] = connectMsg.msgType;
      // root["modId"] = connectMsg.modId;
      root["modType"] = _moduleType;
      root["msgType"] = _msgType;
      root["modId"] = _modID;
      root["connected"] = connectMsg.connected;
      root["readingId"] = connectMsg.readingId++; 
      serializeJson(root, payload);

      UdpGradeControl.beginPacket(openGradeIP,openGradePort);   //Initiate transmission of data  
      UdpGradeControl.print(payload);
      UdpGradeControl.endPacket();  // Close communication    

        
      break;


    case Data:

        // root["modType"] = antennaDataMsg.modType;
        // root["msgType"] = antennaDataMsg.msgType;
        // root["modId"] = antennaDataMsg.modId;
        root["modType"] = _moduleType;
        root["msgType"] = _msgType;
        root["modId"] = _modID;
        root["deltaA"] = gcDataMsg.deltaA;
        root["deltaB"] = gcDataMsg.deltaB;
        root["setpointA"] = gcDataMsg.setPointA; 
        root["setpointB"] = gcDataMsg.setPointB;
        root["autoVert"] = gcDataMsg.autoVert;
        root["autoTilt"] = gcDataMsg.autoTilt;
        root["readingId"] = gcDataMsg.readingId++;
        serializeJson(root, payload);

        UdpGradeControl.beginPacket(openGradeIP,openGradePort);   //Initiate transmission of data
        UdpGradeControl.print(payload);
        sent = UdpGradeControl.endPacket();  // Close communication
        

        if (!sent && errno == 5){
          ESP.restart();    
        } 
        
        break;

    case Settings:
    
      root["modType"] = gcSettingsMsg.modType;
      root["msgType"] = gcSettingsMsg.msgType;
      root["modId"] = gcSettingsMsg.modId;
      root["readingId"] = gcSettingsMsg.readingId++;
      serializeJson(root, payload);
    
      UdpGradeControl.beginPacket(openGradeIP,openGradePort);   //Initiate transmission of data
      UdpGradeControl.print(payload);               
      sent = UdpGradeControl.endPacket();  // Close communication
      
        break;

    case Diagnostic:
      
      root["modType"] = gcFirmwareMsg.modType;
      root["msgType"] = gcFirmwareMsg.msgType;
      root["modId"] = gcFirmwareMsg.modId;
      root["fw"] = gcFirmwareMsg.firmware = fwVersion;
      root["hw"] = gcFirmwareMsg.hardware = hwVersion;
      root["readingId"] = gcFirmwareMsg.readingId++;
      serializeJson(root, payload);
      
      UdpGradeControl.beginPacket(openGradeIP,openGradePort);   //Initiate transmission of data
      UdpGradeControl.print(payload);                 
      UdpGradeControl.endPacket();  // Close communication   

      //UdpAntenna.write((const uint8_t*)&antennaFirmwareMsg, sizeof(antennaFirmwareMsg));
        break;

    case Error:
        break;

    default:
      break; 
  }
  //(">>> ");
  Serial.println(payload);



  return true;
}

bool RecvUdpDataJSON()
{ 
  //RECEPTION
  int packetSize = UdpGradeControl.parsePacket();   // Size of packet to receive  
  StaticJsonDocument<1000> root;  
  String payload;

  
  senderIP = UdpGradeControl.remoteIP();  //Sent from IP
  senderPort = UdpGradeControl.remotePort();  //Sent from IP

  if (packetSize) {       // If we received a package
     
    UdpGradeControl.read(packetBuffer, sizeof(packetBuffer)); 
    payload = packetBuffer;
    //Serial.print("<<< ");
    //Serial.println(payload);
    deserializeJson(root, payload);

    uint8_t modType = root["modType"].as<uint8_t>();  
    uint8_t msgType= root["msgType"].as<uint8_t>();
    uint8_t modID = root["modId"].as<uint8_t>();
    
    
    if (modType == Grade_Control_Slave  && modID == 1){   
      watchdogTimer = 0;      
      if (msgType == int(Connect))
      {
        
        connectMsg.modType = root["modType"].as<uint8_t>();  
        connectMsg.msgType = root["msgType"].as<uint8_t>();
        connectMsg.modId = root["modId"].as<uint8_t>();
        connectMsg.connected = root["connected"].as<uint8_t>();  
        root["readingId"].as<u64_t>();//connectMsg.readingId =           
        
        if(connectMsg.connected == 0){             
          connectMsg.connected = 1;  
          
          SendUdpDataJSON(Grade_Control_Slave, Connect, 1 );              

        }
        
      }
      if (msgType == int(Data))
      {
        gcDataMsg.modType = root["modType"].as<uint8_t>();  
        gcDataMsg.msgType = root["msgType"].as<uint8_t>();
        gcDataMsg.modId = root["modId"].as<uint8_t>();
        gcDataMsg.deltaA = root["deltaA"].as<int>();
        gcDataMsg.deltaB = root["deltaB"].as<int>();
        gcDataMsg.setPointA = root["setpointA"].as<int>();
        gcDataMsg.setPointB = root["setpointB"].as<int>();
        gcDataMsg.autoVert = root["autoVert"].as<bool>();
        gcDataMsg.autoTilt = root["autoTilt"].as<bool>();
        root["readingId"].as<u64_t>(); //gcDataMsg.readingId =    

        //SendUdpDataJSON(int(Grade_Control_Slave), Data, 1 );




      }
      if (msgType == int(Settings))
      {
        gcSettingsMsg.modType = root["modType"].as<uint8_t>();  
        gcSettingsMsg.msgType = root["msgType"].as<uint8_t>();
        gcSettingsMsg.modId = root["modId"].as<uint8_t>();
        gcSettingsMsg.KP = root["KP"].as<uint8_t>();
        gcSettingsMsg.KI = root["KI"].as<uint8_t>();
        gcSettingsMsg.KD = root["KD"].as<uint8_t>();
        gcSettingsMsg.retDead = -root["retDead"].as<uint8_t>()*16 + VALVE_FLOAT;
        gcSettingsMsg.extDead = root["extDead"].as<uint8_t>()*16 + VALVE_FLOAT;
        gcSettingsMsg.ValveType = root["valveType"].as<uint8_t>();
        root["readingId"].as<u64_t>(); //gcSettingsMsg.readingId = 
        saveSettings();



      }
      if (msgType == int(Diagnostic))
      {
        //memcpy(&antennaFirmwareMsg, packetBuffer, sizeof(antennaFirmwareMsg));

        gcFirmwareMsg.modType = root["modType"].as<uint8_t>();  
        gcFirmwareMsg.msgType = root["msgType"].as<uint8_t>();
        gcFirmwareMsg.modId = root["modId"].as<uint8_t>();
        gcFirmwareMsg.firmware = root["fw"].as<String>();
        gcFirmwareMsg.hardware = root["hw"].as<String>();
        root["readingId"].as<u64_t>(); //gcFirmwareMsg.readingId = 



      }
      if (msgType == Error)
      {
        //memcpy(&connectMsg, packetBuffer, sizeof(connectMsg));

      }
      
    }

    
    int index = 0;    
    return true;
  }

  memset(packetBuffer, 0, sizeof(packetBuffer));
  UdpGradeControl.flush();
  return false;
}


////////
//WIFI//
////////
void ConnectToOGX() {
  WiFi.mode(WIFI_STA);
  WiFi.config(gradeControlIP , gatewayIP, Subnet);
  WiFi.begin(ssid);
  DEBUG.print("Connecting to WiFi ..");
  while (WiFi.status() != WL_CONNECTED) {
    DEBUG.print('.');
    delay(1000);
  }
  DEBUG.println(WiFi.localIP());
}

void ReconnectToOGX(){
  
  if (WiFi.status() != WL_CONNECTED) {
    DEBUG.print(millis());
    DEBUG.println("Reconnecting to WiFi...");
    WiFi.disconnect();
    WiFi.reconnect();   
  }
}


///OTA

void CheckForUpdate(){
  
  // Port defaults to 3232
  // ArduinoOTA.setPort(3232);

  // Hostname defaults to esp3232-[MAC]
  ArduinoOTA.setHostname("OGX_GradeControl");

  // No authentication by default
  // ArduinoOTA.setPassword("admin");

  // Password can be set with it's md5 value as well
  // MD5(admin) = 21232f297a57a5a743894a0e4a801fc3
  // ArduinoOTA.setPasswordHash("21232f297a57a5a743894a0e4a801fc3");  
  
  ArduinoOTA
    .onStart([]() {
      String type;
      if (ArduinoOTA.getCommand() == U_FLASH)
        type = "sketch";
      else // U_SPIFFS
        type = "filesystem";

      // NOTE: if updating SPIFFS this would be the place to unmount SPIFFS using SPIFFS.end()
      DEBUG.println("Start updating " + type);
    })
    .onEnd([]() {
      DEBUG.println("\nEnd");
    })
    .onProgress([](unsigned int progress, unsigned int total) {
      DEBUG.printf("Progress: %u%%\r", (progress / (total / 100)));
    })
    .onError([](ota_error_t error) {
      DEBUG.printf("Error[%u]: ", error);
      if (error == OTA_AUTH_ERROR) Serial.println("Auth Failed");
      else if (error == OTA_BEGIN_ERROR) Serial.println("Begin Failed");
      else if (error == OTA_CONNECT_ERROR) Serial.println("Connect Failed");
      else if (error == OTA_RECEIVE_ERROR) Serial.println("Receive Failed");
      else if (error == OTA_END_ERROR) Serial.println("End Failed");
    });

  ArduinoOTA.begin();

  DEBUG.println("Ready");
  DEBUG.print("IP address: ");
  DEBUG.println(WiFi.localIP());

}

void loadSettingsnocheck() {
  
  
  File file = LittleFS.open("/GradeSettings.json", FILE_READ);

  if (!file) {
    Serial.println("There was an error opening the file for reading");
    return;
  }

  DynamicJsonDocument doc(1024);
  DeserializationError error = deserializeJson(doc, file);

  if (error) {
    Serial.println("Failed to parse JSON");
    return;
  }

  gcSettingsMsg.KP =doc["Kp"];
  gcSettingsMsg.KI= doc["Ki"];
  gcSettingsMsg.KD  = doc["Kd"];
  gcSettingsMsg.retDead = doc["retDead"];
  gcSettingsMsg.extDead = doc["extDead"];
  gcSettingsMsg.ValveType = doc["valve"];

  file.close();
}

void loadSettings() {
  // Check if the settings file exists
  if (!LittleFS.exists("/GradeSettings.json")) {
    Serial.println("Settings file does not exist, using default values.");
    
    // Load default values
    gcSettingsMsg.KP;
    gcSettingsMsg.KI;
    gcSettingsMsg.KD;
    gcSettingsMsg.retDead;
    gcSettingsMsg.extDead;
    gcSettingsMsg.ValveType;

    // Save the default values to the file for future use
    saveSettings();
  } else {
    // Open the file for reading
    File file = LittleFS.open("/GradeSettings.json", FILE_READ);

    if (!file) {
      Serial.println("There was an error opening the file for reading");
      return;
    }

    // Parse the JSON data from the file
    DynamicJsonDocument doc(1024);
    DeserializationError error = deserializeJson(doc, file);

    if (error) {
      Serial.println("Failed to parse JSON, using default values.");
      
      // Load default values if JSON parsing fails
      // gcSettingsMsg.KP = gcSettingsMsg.KP;
      // gcSettingsMsg.KI = defaultKi;
      // gcSettingsMsg.KD = defaultKd;
      // gcSettingsMsg.retDead = defaultRetDead;
      // gcSettingsMsg.extDead = defaultExtDead;
      // gcSettingsMsg.ValveType = defaultValveType;

      file.close();
      return;
    }

    // Load values from the JSON document
    gcSettingsMsg.KP = doc["Kp"];
    gcSettingsMsg.KI = doc["Ki"];
    gcSettingsMsg.KD = doc["Kd"];
    gcSettingsMsg.retDead = doc["retDead"];
    gcSettingsMsg.extDead = doc["extDead"];
    gcSettingsMsg.ValveType = doc["valve"];

    file.close();
  }
}

void saveSettings() {
  DynamicJsonDocument doc(1024);
  
  doc["Kp"] = gcSettingsMsg.KP;
  doc["Ki"] = gcSettingsMsg.KI;
  doc["Kd"] = gcSettingsMsg.KD;
  doc["retDead"] = gcSettingsMsg.retDead;
  doc["extDead"] = gcSettingsMsg.extDead;
  doc["valve"] = gcSettingsMsg.ValveType;

  File file = LittleFS.open("/GradeSettings.json", FILE_WRITE);

  if (!file) {
    Serial.println("There was an error opening the file for writing");
    return;
  }

  if (serializeJson(doc, file) == 0) {
    Serial.println("File write failed");
  }

  file.close();
}