using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;


namespace OpenGrade
{
    public partial class FormGPS
    {
        private readonly FormGPS mf = null;
        private readonly FormUDP com = null;
        // Send and Recv socket
        private Socket sendSocket;
        private Socket recvSocket;

        public const int DATA_HEADER = 10001;
        public const int SETTINGS_HEADER = 10002;
        public const int GPS_HEADER = 10003;
        public const int IMU_HEADER = 10004;
        public const int NTRIP_HEADER = 10005;

        public const int RESET_HEADER = 10100;
        public const int SYSTEM_HEADER = 10101;
        public const int WIFI_HEADER = 10102;

        public string[] SSID = new string[] {"-", "-", "-", "-" , "-"};
        public string[] SSID_PASS = new string[25];
        public bool isWifidone = false;
        public string ssidPass = "";
        public string ssidName = "";

        public long gradeControlTimeout = 0;
        public long antennaModuleTimeout = 0;
        public long udpIMUTimeout = 0;

        ///Ports
        private static int openGradePort = 9999; //OpenGrade Server Port
        private static int gradeControlPort = 7777; // GradeControl  Port
        private static int antennaPort = 8888; // Antenna Port
        private static int senderPort;
        ///Ip Addresses
        private static byte[] openGrade = new byte[] { 192, 168, 0, 226 };
        private static byte[] gradeControl = new byte[] { 192, 168, 0, 229 };
        private static byte[] antennaModule = new byte[] { 192, 168, 0, 225 };

        private static IPAddress openGradeIP = new IPAddress(openGrade);   //OpenGradeX Server
        private static IPAddress gradeControlIP = new IPAddress(gradeControl);   // GradeControl Module IP
        private static IPAddress antennaIP = new IPAddress(antennaModule);   // Antenna Module IP 
        
        private bool isSendConnected;
        public byte[] ipAddress = new byte[] {192, 168, 1, 110};

        public IPEndPoint epAntennaModule;
        public IPEndPoint epGradeControl;

        // Data stream
        private byte[] buffer = new byte[1024];

        // Status delegate
        private delegate void UpdateRecvMessageDelegate(string recvMessage);
        private UpdateRecvMessageDelegate updateRecvMessageDelegate = null;



        public void SendUDPMessageNTRIP(int header, byte[] byteData)
        {
            tboxNTRIPBuffer.Text = byteData.Length.ToString();  
            
            try
            { 
                // Send packet to the zero
                if (byteData.Length != 0)

                    sendSocket.BeginSendTo(byteData, 0, byteData.Length, SocketFlags.None, epAntennaModule, new AsyncCallback(SendData), null);


            }
            catch (Exception)
            {
                //WriteErrorLog("Sending UDP Message" + e.ToString());
                //MessageBox.Show("Send Error: " + e.Message, "UDP Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        /*
        public void SendUDPMessageNTRIP(int header, string msg)
        {           
            try
            {
                // Get packet as byte array
                byte[] byteData = Encoding.ASCII.GetBytes(msg);

                tboxNTRIPBuffer.Text = byteData.Length.ToString();

                // Send packet to the zero
                if (byteData.Length != 0) sendSocket.BeginSendTo(byteData, 0, byteData.Length, SocketFlags.None, epAntennaModule, new AsyncCallback(SendData), null);
               

            }
            catch (Exception)
            {
                //WriteErrorLog("Sending UDP Message" + e.ToString());
                //MessageBox.Show("Send Error: " + e.Message, "UDP Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        */

        public void SendUDPMessage(int header, IPEndPoint _module, int secCase = 0)
        {

            string msg = "";
            if (isSendConnected)
            {
                try
                {
                    switch(header)
                    {
                        case DATA_HEADER:  // DATA
                            
                            msg = (header.ToString() + "," + mc.GradeControlData[mc.gcDeltaDir] + "," + mc.GradeControlData[mc.gcisAutoActive]
                                        + "," + Math.Abs(cutDelta) + "\r\n");
                            break;

                        case SETTINGS_HEADER:  // SETTINGS
    
                            msg = (header.ToString() + "," + mc.gradeControlSettings[mc.gsKpGain] + "," + mc.gradeControlSettings[mc.gsKiGain] + "," + mc.gradeControlSettings[mc.gsKdGain]
                                + "," + mc.gradeControlSettings[mc.gsRetDeadband] + "," + mc.gradeControlSettings[mc.gsExtDeadband] + "," + mc.gradeControlSettings[mc.gsValveType]) + "\r\n"; 

                            break;

                        case GPS_HEADER:

                            break;

                        case IMU_HEADER:
                            
                            msg = (header.ToString() + "," + 0);

                            break;

                        case NTRIP_HEADER:

                            msg = (header.ToString() + "," + 0);                          

                            break;

                        case WIFI_HEADER:

                            switch (secCase)
                            {
                                case 1:
                                    msg = (header.ToString() + "," + secCase);
                                    break;
                                case 2:
                                    msg = (header.ToString() + "," + secCase + "," + ssidName + "," + ssidPass );
                                    break;
                                default:
                                    break;

                            }
                            
                            break;

                        case RESET_HEADER:

                            msg = (header.ToString() + "," + 0);

                            break;
                        case SYSTEM_HEADER:
                            
                            msg = (header.ToString() + "," + 1);


                            break;


                        default: 

                            break;

                    }

                    // Get packet as byte array
                    byte[] byteData = Encoding.ASCII.GetBytes(msg);

                    if (byteData.Length != 0)

                        // Send packet to the zero
                        sendSocket.BeginSendTo(byteData, 0, byteData.Length, SocketFlags.None, _module, new AsyncCallback(SendData), null);
                }
                catch (Exception e)
                {
                    WriteErrorLog("Sending UDP Message" + e.ToString());

                    //MessageBox.Show("Send Error: " + e.Message, "UDP Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        public void SendUDPMessage(int header, IPEndPoint _module, string _msg)
        {
            string msg = "";
            if (isSendConnected)
            {
                try
                {
                    switch (header)
                    {
                        case DATA_HEADER: 

                            msg = (header.ToString() + _msg +  "\r\n");
                            break;

                        case SETTINGS_HEADER:  

                            msg = (header.ToString() + _msg + "\r\n");
                            break;

                        case GPS_HEADER:

                            msg = (header.ToString() + _msg + "\r\n");
                            break;

                        case NTRIP_HEADER:

                            msg = (header.ToString() + _msg + "\r\n"); ;

                            break;

                        case IMU_HEADER:

                            msg = (header.ToString() + _msg + "\r\n");

                            break;
                        case RESET_HEADER:

                            msg = (header.ToString() + _msg + "\r\n");

                            break;
                        case SYSTEM_HEADER:

                            msg = (header.ToString() + _msg + "\r\n");

                            break;


                        default:

                            break;

                    }

                    // Get packet as byte array
                    byte[] byteData = Encoding.ASCII.GetBytes(msg);

                    if (byteData.Length != 0)

                        // Send packet to the zero
                        sendSocket.BeginSendTo(byteData, 0, byteData.Length, SocketFlags.None, _module, new AsyncCallback(SendData), null);
                }
                catch (Exception e)
                {
                    WriteErrorLog("Sending UDP Message" + e.ToString());

                }
            }









        }

        public void SendData(IAsyncResult asyncResult)
        {
            try
            {
                sendSocket.EndSend(asyncResult);
            }
            catch (Exception e)
            {
                WriteErrorLog(" UDP Send Data" + e.ToString());

                //MessageBox.Show("SendData Error: " + e.Message, "UDP Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReceiveData(IAsyncResult asyncResult)
        {
            try
            {
                // Initialise the IPEndPoint for the client
                EndPoint epSender = new IPEndPoint(IPAddress.Any, 0);
            
                // Receive all data
                int msgLen = recvSocket.EndReceiveFrom(asyncResult, ref epSender);

                byte[] localMsg = new byte[msgLen];
                Array.Copy(buffer, localMsg, msgLen);

                // Listen for more connections again...
                recvSocket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epSender, new AsyncCallback(ReceiveData), epSender);

                string text = Encoding.ASCII.GetString(localMsg);
                


                // Update status through a delegate
                Invoke(updateRecvMessageDelegate, new object[] { text });
            }
            catch (Exception e)
            {
                WriteErrorLog("UDP Recv data " + e.ToString());
                //MessageBox.Show("ReceiveData Error: " + e.Message, "UDP Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // parse through Messages recieved
        private void UpdateRecvMessage(string recvd)
        {     
            string[] words = recvd.Split(',');
            int temp = words.Count();
            int tempHeader;
            //int.TryParse(words[0], out temp);

            int.TryParse(words[0], out tempHeader);
            
            switch (tempHeader) {

                case DATA_HEADER:
                    if (temp < 5)
                    {
                        gradeControlTimeout = 0;
                        ledGradeControl.BackColor = Color.Lime;
                        voltageBar.BarColorSolid = Color.RoyalBlue;
                        voltageBar2.BarColorSolid = Color.RoyalBlue;

                        int.TryParse(words[1], out mc.autoState);
                        double.TryParse(words[2], out mc.voltage);
                        double.TryParse(words[3], out mc.voltage2);

                    }
                    else if ((temp > 5))
                    {
                        gradeControlTimeout = 0;
                        ledGradeControl.BackColor = Color.Lime;
                        voltageBar.BarColorSolid = Color.RoyalBlue;

                        int.TryParse(words[1], out mc.autoState);
                        double.TryParse(words[2], out mc.voltage);
                        float.TryParse(words[3], out mc.headingIMU);
                        float.TryParse(words[4], out mc.pitchIMU);
                        float.TryParse(words[5], out mc.rollIMU);
                    }
                    break;

                case SETTINGS_HEADER:
                    break;

                case GPS_HEADER:
                    antennaModuleTimeout = 0;
                    if (antennaModuleTimeout < 50) ledAntenna.BackColor = Color.Lime;
                    else ledAntenna.BackColor = Color.Orange;
                    pn.rawBuffer = recvd.Remove(0, 6);  // Remove the GPS, Header
                    recvSentenceSettings = pn.rawBuffer;



                    break;

                case IMU_HEADER:
                    mc.prevHeadingIMU = mc.headingIMU;
                    antennaModuleTimeout = 0;
                    if (antennaModuleTimeout < 50) ledAntenna.BackColor = Color.Lime;
                    else ledAntenna.BackColor = Color.Orange;
                    float.TryParse(words[1], out mc.headingIMU);
                    float.TryParse(words[2], out mc.pitchIMU);
                    float.TryParse(words[3], out mc.rollIMU);
                    break;

                case RESET_HEADER:
                    break;

                case SYSTEM_HEADER:
                    int mod;
                    
                    int.TryParse(words[1], out mod);

                    if (mod == 255)
                    {
                        Properties.Settings.Default.set_GcModVersion = words[2];
                        //mf.mc.gcFirmware = words[1];

                    }
                    if (mod == 155)
                    {
                        Properties.Settings.Default.set_AntModVersion = words[2];
                        //mf.mc.atFirmware = words[1];                        

                    }
                    //SendUDPMessage(FormGPS.SETTINGS_HEADER, mf.epGradeControl);
                    break;
                    

                case WIFI_HEADER:

                    for (int i = 1; i < temp-1; ++i)
                    {
                      SSID[i-1] = words[i]; 
                      isWifidone = true;
                    } 
                    break;

                    
                default:
                    break;
                    

            }
        }  
    }
}
