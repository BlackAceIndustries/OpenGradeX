#include "String.h"
#include <ArduinoJson.h>


enum dataType {Connect, Data, Settings, Diagnostic, Error};
enum moduleType {Antenna_Master , Antenna_Slave, Grade_Control_Slave};



typedef struct struct_message_Connect {
  uint8_t modType;
  uint8_t msgType;
  uint8_t modId;
  uint8_t connected = 0;
  uint64_t readingId;
} struct_message_Connect;

typedef struct struct_message_Firmware {
  uint8_t modType;
  uint8_t msgType;
  uint8_t modId;
  String firmware = "-";
  String hardware = "-";
  uint64_t readingId;
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
  uint64_t readingId;

} struct_message_Antenna_data;

typedef struct struct_message_Antenna_settings {
  uint8_t modType;
  uint8_t msgType;
  uint8_t modId; 
  uint64_t readingId;

} struct_message_Antenna_settings;


typedef struct struct_message_GradeControl_data {
  uint8_t modType = Grade_Control_Slave;
  uint8_t msgType = Data;
  uint8_t modId;
  int deltaA;
  int deltaB;
  int setPointA;
  int setPointB;
  bool autoVert;
  bool autoTilt;
  // bool autoVert = false;
  // bool autoTilt = false;
  uint64_t readingId;

} struct_message_GradeControl_data;

typedef struct struct_message_GradeControl_settings {
  uint8_t modType;
  uint8_t msgType;
  uint8_t modId;
  int KP = 40;
  int KI = 1;
  int KD = 3100;
  int retDead  = 1845;
  int extDead = 2250;
  uint8_t ValveType;
  uint64_t readingId;

} struct_message_GradeControl_settings;