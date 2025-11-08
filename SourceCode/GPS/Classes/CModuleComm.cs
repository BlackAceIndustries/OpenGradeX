
using System.Drawing;
using System.Windows.Forms;
using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Runtime;

namespace OpenGrade
{
    public class CModuleComm
    {
        //copy of the mainform address
        private readonly FormGPS mf = null;

        //GradeControl ------------------------------------------------------------------------------------------------
        public string serialRecvGradeControlStr;   ///Black Ace Industries

        //For parsing incoming int on serial port
        public int incomingInt;                   
        

        public enum DataType { Connect, Data, Settings, Diagnostic, Error, NTRIP}
        public enum ModuleType { Antenna_Master, Antenna_Slave, GradeControl_Slave }

        public struct MessageConnect
        {
            public byte modType;
            public byte msgType;
            public byte modId;
            public byte connected;
            public ulong readingId;
        }

        public struct MessageFirmware
        {
            public byte modType;
            public byte msgType;
            public byte modId;
            public string firmware;
            public string hardware;
            public ulong readingId;
        }

        public struct MessageAntennaData
        {
            public byte modType;
            public byte msgType;
            public byte modId;
            public string GGA;
            public string VTG;
            public string GSA;
            public double roll;
            public double pitch;
            public double yaw;
            public string battery;
            public ulong readingId;
        }

        public struct MessageAntennaSettings
        {
            public byte modType;
            public byte msgType;
            public byte modId;
            public ulong readingId;
        }

        public struct MessageGradeControlData
        {
            public byte modType;
            public byte msgType;
            public byte modId;
            public int deltaA;
            public int deltaB;
            public int setPointA;
            public int setPointB;
            public bool autoVert;
            public bool autoTilt;
            public ulong readingId;
        }

        public struct MessageGradeControlSettings
        {
            public byte modType;
            public byte msgType;
            public byte modId;
            public byte KP;
            public byte KI;
            public byte KD;
            public byte retDead;
            public byte extDead;
            public byte valveType;
            public ulong readingId;
        }

        public MessageConnect gcconnectMsg = new MessageConnect();
        public MessageGradeControlSettings gcSetting = new MessageGradeControlSettings();
        public MessageGradeControlData gcData = new MessageGradeControlData();
        public MessageFirmware gcFirmware = new MessageFirmware();

        public MessageConnect a1connectMsg = new MessageConnect();
        public MessageAntennaData a1Data = new MessageAntennaData();
        public MessageAntennaSettings a1Setting = new MessageAntennaSettings();
        public MessageFirmware a1Firmware = new MessageFirmware();

        public MessageConnect a2connectMsg = new MessageConnect();
        public MessageAntennaData a2Data = new MessageAntennaData();
        public MessageAntennaSettings a2Setting = new MessageAntennaSettings();
        public MessageFirmware a2Firmware = new MessageFirmware();

        //for the workswitch
        public bool isWorkSwitchActiveLow, isWorkSwitchEnabled;
        public int workSwitchValue;

        public bool isImuCorrection = true;
        public bool isPitchCorrection = false;

        public string a1RawString;
        public string a1NtripString;
        public string a2RawString;
        public string gcRawString;

        public double imuRollOffset = 0, imuPitchOffset = 0, imuYawOffset = 0;

        public double headingIMU = 9999, prevHeadingIMU = 9999, rollIMU = 9999, pitchIMU = 9999;
        public float avgrollIMU = 9999, avgpitchIMU = 9999;

        public double rollSlope = 9999, pitchSlope = 9999;


        public bool isAutoVertLast = false, isAutoTiltLast = false;

        //constructor
        public CModuleComm(FormGPS _f)
        {
            mf = _f;            
            //WorkSwitch logic
            isWorkSwitchEnabled = false;

            //does a low, grounded out, mean on
            isWorkSwitchActiveLow = true;

        }

        //Reset all the byte arrays from modules
        public void ResetAllModuleCommValues()
        {
            gcData.setPointA = 0;
            gcData.setPointB = 0;
            gcData.autoVert = false;
            gcData.autoTilt = false;           

            //gcSetting.modType = 
            //gcSetting.msgType = 
            //gcSetting.modId = 
                
            gcSetting.KP = Properties.Settings.Default.set_KpGain;
            gcSetting.KI = Properties.Settings.Default.set_KiGain;
            gcSetting.KD = Properties.Settings.Default.set_KdGain;
            gcSetting.retDead = Properties.Settings.Default.set_RetDeadband;
            gcSetting.extDead  = Properties.Settings.Default.set_ExtDeadband;
            gcSetting.valveType  = Properties.Settings.Default.set_ValveType;

            //mf.SendUDPMessageJSON((int)ModuleType.Antenna_Master, (int)DataType.Connect, 1, mf.epAntennaModule);

            //mf.SendUDPMessage(FormGPS.DATA_HEADER, mf.epGradeControl);
            //mf.SendUDPMessage(FormGPS.SETTINGS_HEADER, mf.epGradeControl);
            //mf.SendUDPMessage(FormGPS.IMU_HEADER, mf.epAntennaModule);

        }

        public void ToggleIMUCorrection()
        {
            if (isImuCorrection)
            {
                isImuCorrection = false;
                mf.tStripRoll.ForeColor = Color.Yellow;
                mf.tStripPitch.ForeColor = Color.Yellow;
            }
            else
            {
                isImuCorrection = true;
                mf.tStripRoll.ForeColor = Color.Lime;
                mf.tStripPitch.ForeColor = Color.Lime;
            }


        }

        public void AvgRoll()
        {
            avgrollIMU = (avgrollIMU * .8f) + ((float)rollIMU * 0.2f);
        }
        public void AvgPitch()
        {
            avgpitchIMU = (avgpitchIMU * .2f) + ((float)pitchIMU * .8f);

        }



    }
}
