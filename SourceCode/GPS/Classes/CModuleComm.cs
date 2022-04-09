
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

        // PGN - 32762 - 127.250
        public static int numGradeControlDataItems = 5;
        public byte[] GradeControlData = new byte[numGradeControlDataItems];
        public int gcHeaderHi, gcHeaderLo = 1, gcDeltaDir = 2, gcCutDelta = 3, gcisAutoActive = 4;                                

        //info coming from Grade Control Mod
        public int autoState = 0, bladeOffset = 0; //public byte autoState = 0;        
        public double voltage = 0;
        public double voltage2 = 0;

        // PGN - 32760 - 127.248
        public static int numGradeControlSettingsItems = 8;
        public byte[] gradeControlSettings = new byte[numGradeControlSettingsItems];
        public int gsHeaderHi, gsHeaderLo = 1, gsKpGain = 2, gsKiGain = 3, gsKdGain = 4, gsRetDeadband = 5, gsExtDeadband = 6, gsValveType = 7;

        //AutoSteer ------------------------------------------------------------------------------------------------
        public string serialRecvAutoSteerStr;

        // PGN - 32766 - 127.254
        public static int numSteerDataItems = 8;
        public byte[] autoSteerData = new byte[numSteerDataItems];
        public int sdHeaderHi, sdHeaderLo = 1, sdRelay = 2, sdSpeed = 3, sdDistanceHi = 4, sdDistanceLo = 5,
                    sdSteerAngleHi = 6, sdSteerAngleLo = 7;

        // PGN - 32764 - 127.252
        public static int numSteerSettingItems = 10;
        public byte[] autoSteerSettings = new byte[numSteerSettingItems];
        public int ssHeaderHi, ssHeaderLo = 1, ssKp = 2, ssKi = 3, ssKd = 4, ssKo = 5,
                    ssSteerOffset = 6, ssMinPWM = 7, ssMaxIntegral = 8, ssCountsPerDegree = 9;


        //for the workswitch
        public bool isWorkSwitchActiveLow, isWorkSwitchEnabled;
        public int workSwitchValue;

        public bool isImuCorrection = false;

        public float headingIMU = 9999, prevHeadingIMU = 9999, rollIMU = 9999, pitchIMU = 9999;
        
        public string gcFirmware;
        public string atFirmware;

        

        //constructor
        public CModuleComm(FormGPS _f)
        {
            mf = _f;            
            gcFirmware = "----";
            atFirmware = "----";

            //WorkSwitch logic
            isWorkSwitchEnabled = false;

            //does a low, grounded out, mean on
            isWorkSwitchActiveLow = true;
        }

        //Reset all the byte arrays from modules
        public void ResetAllModuleCommValues()
        {         
            GradeControlData[gcDeltaDir] = 0;
            GradeControlData[gcCutDelta] = 0;
            GradeControlData[gcisAutoActive] = 0;

            mf.SendUDPMessage(FormGPS.DATA_HEADER, mf.epGradeControl);

            gradeControlSettings[gsKpGain] = Properties.Settings.Default.set_KpGain;
            gradeControlSettings[gsKiGain] = Properties.Settings.Default.set_KiGain;
            gradeControlSettings[gsKdGain] = Properties.Settings.Default.set_KdGain;
            gradeControlSettings[gsRetDeadband] = Properties.Settings.Default.set_RetDeadband;
            gradeControlSettings[gsExtDeadband] = Properties.Settings.Default.set_ExtDeadband;
            gradeControlSettings[gsValveType] = Properties.Settings.Default.set_ValveType;

            mf.SendUDPMessage(FormGPS.SETTINGS_HEADER, mf.epGradeControl);

            mf.SendUDPMessage(FormGPS.IMU_HEADER, mf.epAntennaModule);

        }
    }
}
