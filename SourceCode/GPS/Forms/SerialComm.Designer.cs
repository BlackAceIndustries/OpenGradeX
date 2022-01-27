//Please, if you use this, share the improvements

using System.IO.Ports;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization;

namespace OpenGrade
{
    public partial class FormGPS
    {
        public static string portNameGPS = "COM GPS";
        public static int baudRateGPS = 115200;

        public static string portNameGradeControl = "COM Sect";
        public static int baudRateGradeControl = 115200;

        public static string portNameAutoSteer = "COM AS";
        public static int baudRateAutoSteer = 38400;

        //private string[] words;

        public string NMEASentence = "No Data";

        //used to decide to autoconnect section arduino this run
        public bool wasGradeControlConnectedLastRun = false;
        public string recvSentenceSettings = "InitalSetting";

        //used to decide to autoconnect autosteer arduino this run
        public bool wasAutoSteerConnectedLastRun = false;

        //serial port gps is connected to
        public SerialPort sp = new SerialPort(portNameGPS, baudRateGPS, Parity.None, 8, StopBits.One);

        //serial port Grade Control Module is connected to
        public SerialPort spGradeControl = new SerialPort(portNameGradeControl, baudRateGradeControl, Parity.None, 8, StopBits.One);

        //serial port AutoSteer is connected to
        public SerialPort spAutoSteer = new SerialPort(portNameAutoSteer, baudRateAutoSteer, Parity.None, 8, StopBits.One);

        #region AutoSteerPort //--------------------------------------------------------------------

        public void AutoSteerDataOutToPort()
        {
            //Tell Arduino the steering parameter values
            if (spAutoSteer.IsOpen)
            {
                try { spAutoSteer.Write(mc.autoSteerData, 0, CModuleComm.numSteerDataItems); }
                catch (Exception e)
                {
                    WriteErrorLog("Out Data to Steering Port " + e.ToString());
                    SerialPortAutoSteerClose();
                }
            }
 
        }

        public void AutoSteerSettingsOutToPort()
        {
            //Tell Arduino autoSteer settings
            if (spAutoSteer.IsOpen)
            {
                try { spAutoSteer.Write(mc.autoSteerSettings, 0, CModuleComm.numSteerSettingItems ); }
                catch (Exception e)
                {
                    WriteErrorLog("Out Settings to Steer Port " + e.ToString());
                    SerialPortAutoSteerClose();
                }
            }
        }

        //called by the AutoSteer module delegate every time a chunk is rec'd
        private void SerialLineReceivedAutoSteer(string sentence)
        {
            //spit it out no matter what it says
            mc.serialRecvAutoSteerStr = sentence;

            //0 - steer angle, 1 - pwm, 2 - heading in degrees * 16, 3 - roll in degrees * 16, 4 - steerSwitch position

            string[] words = mc.serialRecvAutoSteerStr.Split(',');
            if (words.Length == 5)
            {
                //first 2 used for display mainly in autosteer window chart as strings
                //parse the values
                mc.prevGyroHeading = mc.gyroHeading;
                int.TryParse(words[2], out mc.gyroHeading);
                int.TryParse(words[3], out mc.rollRaw);
                int.TryParse(words[4], out mc.steerSwitchValue);
            }
        }

        //the delegate for thread
        private delegate void LineReceivedEventHandlerAutoSteer(string sentence);

        //Arduino serial port receive in its own thread
        private void sp_DataReceivedAutoSteer(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (spAutoSteer.IsOpen)
            {
                try
                {
                    System.Threading.Thread.Sleep(25);
                    string sentence = spAutoSteer.ReadLine();
                    this.BeginInvoke(new LineReceivedEventHandlerAutoSteer(SerialLineReceivedAutoSteer), sentence);
                }
                //this is bad programming, it just ignores errors until its hooked up again.
                catch (Exception ex)
                {
                    WriteErrorLog("AutoSteer Recv" + ex.ToString());
                }

            }
        }

        //open the Arduino serial port
        public void SerialPortAutoSteerOpen()
        {
            if (!spAutoSteer.IsOpen)
            {
                spAutoSteer.PortName = portNameAutoSteer;
                spAutoSteer.BaudRate = baudRateAutoSteer;
                spAutoSteer.DataReceived += sp_DataReceivedAutoSteer;
            }

            try { spAutoSteer.Open(); }
            catch (Exception e)
            {
                WriteErrorLog("Opening Steer Port" + e.ToString());

                MessageBox.Show(e.Message + "\n\r" + "\n\r" + "Go to Settings -> COM Ports to Fix", "No AutoSteer Port Active");

                //update port status label
                stripOnlineAutoSteer.Value = 1;

                Properties.Settings.Default.setPort_wasAutoSteerConnected = false;
                Properties.Settings.Default.Save();
            }

            if (spAutoSteer.IsOpen)
            {
                spAutoSteer.DiscardOutBuffer();
                spAutoSteer.DiscardInBuffer();

                //update port status label
                stripOnlineAutoSteer.Value = 100;


                Properties.Settings.Default.setPort_portNameAutoSteer = portNameAutoSteer;
                Properties.Settings.Default.setPort_wasAutoSteerConnected = true;
                Properties.Settings.Default.Save();
            }
        }

        public void SerialPortAutoSteerClose()
        {
            if (spAutoSteer.IsOpen)
            {
                spAutoSteer.DataReceived -= sp_DataReceivedAutoSteer;
                try { spAutoSteer.Close(); }
                catch (Exception e)
                {
                    WriteErrorLog("Closing steer Port" + e.ToString());
                    MessageBox.Show(e.Message, "Connection already terminated??");
                }

                //update port status label
                stripOnlineAutoSteer.Value = 1;

                Properties.Settings.Default.setPort_wasAutoSteerConnected = false;
                Properties.Settings.Default.Save();

                spAutoSteer.Dispose();
            }

        }

        #endregion

        #region GradeControlSerialPort //--------------------------------------------------------------------

        //Send GradeControl info out to GradeControl board
        public void GradeControlDataOutToPort()
        {
            //Tell Arduino the Grade Control values
            if (spGradeControl.IsOpen)
            {
                try { spGradeControl.Write(mc.GradeControlData, 0, CModuleComm.numGradeControlDataItems); }
                catch (Exception e)
                {
                    WriteErrorLog("Out Data to Grade Control Port " + e.ToString());
                    SerialPortGradeControlClose();
                }
            }

        }

        public void GradeControlSettingsOutToPort()
        
        {
            //Tell Arduino to turn section on or off accordingly
            if (spGradeControl.IsOpen)
            {
                try { spGradeControl.Write(mc.gradeControlSettings, 0, CModuleComm.numGradeControlSettingsItems); } 
                catch (Exception e)
                {
                    WriteErrorLog("Out Settings to Section relays" + e.ToString());
                    SerialPortGradeControlClose();
                }
            }
        }
        //Arduino port called by the GradeControl delegate every time
        private void SerialLineReceivedGradeControl(string sentence)
        {
            //spit it out no matter what it says

            
            mc.serialRecvGradeControlStr = sentence;

            string[] words = mc.serialRecvGradeControlStr.Split(',');
            if (words.Length == 5)
            {
                //first 2 used for display mainly in autosteer window chart as strings
                //parse the values
                mc.prevHeadingIMU = mc.headingIMU;

                int.TryParse(words[0], out mc.autoState);
                double.TryParse(words[1], out mc.voltage);
                float.TryParse(words[2], out mc.headingIMU);
                float.TryParse(words[3], out mc.pitchIMU);
                float.TryParse(words[4], out mc.rollIMU);
            }

        }

        //the delegate for thread
        private delegate void LineReceivedEventHandlerRelay(string sentence);



        //Grade Control serial port receive in its own thread
        private void sp_DataReceivedGradeControl(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (spGradeControl.IsOpen)
            {
                try
                {   //Black Ace Industries
                    System.Threading.Thread.Sleep(25);
                    string sentence = spGradeControl.ReadLine();
                    this.BeginInvoke(new LineReceivedEventHandlerRelay(SerialLineReceivedGradeControl), sentence);                    
                    if (spGradeControl.BytesToRead > 15) spGradeControl.DiscardInBuffer();
                }
                //this is bad programming, it just ignores errors until its hooked up again.
                catch (Exception ex)
                {
                    WriteErrorLog("GradeControl Data Recvd " + ex.ToString());
                }

            }
        }

        //open the Grade Control
        public void SerialPortGradeControlOpen()
        {
            if (!spGradeControl.IsOpen)
            {
                spGradeControl.PortName = portNameGradeControl;
                spGradeControl.BaudRate = baudRateGradeControl;
                spGradeControl.DataReceived += sp_DataReceivedGradeControl;
            }

            try { spGradeControl.Open(); }
            catch (Exception e)
            {
                WriteErrorLog("Opening GradeControl Port" + e.ToString());

                MessageBox.Show(e.Message + "\n\r" + "\n\r" + "Go to Settings -> COM Ports to Fix", "No Arduino Port Active");

                Properties.Settings.Default.setPort_wasRateRelayConnected = false;
                Properties.Settings.Default.Save();
            }

            if (spGradeControl.IsOpen)
            {
                spGradeControl.DiscardOutBuffer();
                spGradeControl.DiscardInBuffer();

                Properties.Settings.Default.setPort_portNameGradeControl = portNameGradeControl;
                Properties.Settings.Default.setPort_wasRateRelayConnected = true;
                Properties.Settings.Default.Save();
            }
        }

        //close the GradeControl port
        public void SerialPortGradeControlClose()
        {
            if (spGradeControl.IsOpen)
            {
                spGradeControl.DataReceived -= sp_DataReceivedGradeControl;
                try { spGradeControl.Close(); }
                catch (Exception e)
                {
                    WriteErrorLog("Closing GradeControl Serial Port" + e.ToString());
                    MessageBox.Show(e.Message, "Connection already terminated??");
                }

                Properties.Settings.Default.setPort_wasRateRelayConnected = false;
                Properties.Settings.Default.Save();

                spGradeControl.Dispose();
            }

        }
        #endregion

        #region GPS SerialPort //--------------------------------------------------------------------------

        //called by the GPS delegate every time a chunk is rec'd
        private void SerialLineReceived(string sentence)
        {
            //spit it out no matter what it says
            pn.rawBuffer += sentence;
            recvSentenceSettings = pn.rawBuffer;
        }

        private delegate void LineReceivedEventHandler(string sentence);

        //serial port receive in its own thread
        private void sp_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (sp.IsOpen)
            {
                try
                {
                    //give it a sec to spit it out
                    System.Threading.Thread.Sleep(50);

                    //read whatever is in port
                    string sentence = sp.ReadExisting();   //sp.ReadExisting();
                    this.BeginInvoke(new LineReceivedEventHandler(SerialLineReceived), sentence);
                }
                catch (Exception ex)
                {
                    WriteErrorLog("GPS Data Recv" + ex.ToString());

                    //MessageBox.Show(ex.Message + "\n\r" + "\n\r" + "Go to Settings -> COM Ports to Fix", "ComPort Failure!");
                }

            }

        }

        public void SerialPortOpenGPS()
        {
            //close it first
            SerialPortCloseGPS();

            if (!sp.IsOpen)
            {
                sp.PortName = portNameGPS;
                sp.BaudRate = baudRateGPS;
                sp.DataReceived += sp_DataReceived;
                sp.WriteTimeout = 1000;
            }

            try { sp.Open(); }
            catch (Exception e)
            {
                //MessageBox.Show(exc.Message + "\n\r" + "\n\r" + "Go to Settings -> COM Ports to Fix", "No Serial Port Active");
                WriteErrorLog("Open GPS Port " + e.ToString());

                stripOnlineGPS.Value = 1;

                //SettingsPageOpen(0);
            }

            if (sp.IsOpen)
            {
                //btnOpenSerial.Enabled = false;

                //discard any stuff in the buffers
                sp.DiscardOutBuffer();
                sp.DiscardInBuffer();

                Properties.Settings.Default.setPort_portNameGPS = portNameGPS;
                Properties.Settings.Default.setPort_baudRate = baudRateGPS;
                Properties.Settings.Default.Save();
            }
        }

        public void SerialPortCloseGPS()
        {
            //if (sp.IsOpen)
            {
                sp.DataReceived -= sp_DataReceived;
                try { sp.Close(); }
                catch (Exception e)
                {
                    WriteErrorLog("Closing GPS Port" + e.ToString());
                    MessageBox.Show(e.Message, "Connection already terminated?");
                }

                //update port status labels
                stripOnlineGPS.Value = 1;

                sp.Dispose();
            }

        }

        #endregion SerialPortGPS

    }//end class
}//end namespace