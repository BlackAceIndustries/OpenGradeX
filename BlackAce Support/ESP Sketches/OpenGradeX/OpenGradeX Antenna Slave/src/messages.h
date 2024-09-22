#include "String.h"
#include <ArduinoJson.h>


enum dataType {Connect, Data, Settings, Diagnostic, Error};
enum moduleType {Antenna_Master , Antenna_Slave, Grade_Control_Slave};



typedef struct struct_message_Connect {
  uint8_t modType;
  uint8_t msgType;
  uint8_t modId;
  uint8_t connected = 0;
  unsigned int readingId;
} struct_message_Connect;

typedef struct struct_message_Firmware {
  uint8_t modType;
  uint8_t msgType;
  uint8_t modId;
  String firmware = "-";
  String hardware = "-";
  unsigned int readingId;
} struct_message_Firmware;


typedef struct struct_message_Antenna_data {
  uint8_t modType = Antenna_Slave;
  uint8_t msgType = Data;
  uint8_t modId;
  String GGA = "$GGA";
  String VTG = "$VTG";
  String GSA = "$GSA";
  double roll = 0.0;
  double pitch = 0.0;
  double yaw = 0.0;
  String battery = "-";
  unsigned int readingId;

} struct_message_Antenna_data;

typedef struct struct_message_Antenna_settings {
  uint8_t modType;
  uint8_t msgType;
  uint8_t modId; 
  unsigned int readingId;

} struct_message_Antenna_settings;


typedef struct struct_message_GradeControl_data {
  uint8_t modType = Grade_Control_Slave;
  uint8_t msgType;
  uint8_t modId;
  String setPointA = "-";
  String setPointB = "-";
  String autoVert = "OFF";
  String autoTilt = "OFF";
  unsigned int readingId;

} struct_message_GradeControl_data;

typedef struct struct_message_GradeControl_settings {
  uint8_t modType;
  uint8_t msgType;
  uint8_t modId;
  uint8_t KP;
  uint8_t KI;
  uint8_t KD;
  uint8_t retDead;
  uint8_t extDead;
  uint8_t ValveType;
  unsigned int readingId;

} struct_message_GradeControl_settings;