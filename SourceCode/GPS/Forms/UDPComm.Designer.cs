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

        public const int RESET_HEADER = 10100;
        public const int SYSTEM_HEADER = 10101;



        public long udpDataTimeout = 0;
        public long udpGPSTimeout = 0;
        public long udpIMUTimeout = 0;

        ///Ports
        private static int openGradePort = 9999; //OpenGrade Server Port
        private static int gradeControlPort = 7777; // GradeControl  Port
        private static int antennaPort = 8888; // Antenna Port
        private static int senderPort;
        ///Ip Addresses
        private static byte[] openGrade = new byte[] { 192, 168, 1, 0 };
        private static byte[] gradeControl = new byte[] { 192, 168, 1, 255 };
        private static byte[] antennaModule = new byte[] { 192, 168, 1, 155 };

        private static IPAddress openGradeIP = new IPAddress(openGrade);   //OpenGradeX Server
        private static IPAddress gradeControlIP = new IPAddress(gradeControl);   // GradeControl Module IP
        private static IPAddress antennaIP = new IPAddress(antennaModule);   // Antenna Module IP 
        
        private bool isSendConnected;
        public byte[] ipAddress = new byte[] {192, 168, 1, 110};

        public IPEndPoint epAntennaModule;
        public IPEndPoint epGradeControl;

        //IPEndPoint epAntennaModule = new IPEndPoint(antennaIP ,antennaPort);
        //IPEndPoint epGradeControl = new IPEndPoint(gradeControlIP, gradeControlPort);

        // Data stream
        private byte[] buffer = new byte[1024];

        // Status delegate
        private delegate void UpdateRecvMessageDelegate(string recvMessage);
        private UpdateRecvMessageDelegate updateRecvMessageDelegate = null;

       public void SendGradeControlUDPMessage(string message)
       {
           if (isSendConnected)
           {
               try
               {
                   // Get packet as byte array
                   byte[] byteData = Encoding.ASCII.GetBytes(message);

                   if (byteData.Length != 0)

                       // Send packet to the zero
                       sendSocket.BeginSendTo(byteData, 0, byteData.Length, SocketFlags.None, epGradeControl, new AsyncCallback(SendData), null);
               }
               catch (Exception e)
               {
                   WriteErrorLog("Sending UDP Message" + e.ToString());

                   //MessageBox.Show("Send Error: " + e.Message, "UDP Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
           }
       }

       public void SendAntennaUDPMessage(string message)
       {
           if (isSendConnected)
           {
               try
               {
                   // Get packet as byte array
                   byte[] byteData = Encoding.ASCII.GetBytes(message);

                   if (byteData.Length != 0)

                       // Send packet to the zero
                       sendSocket.BeginSendTo(byteData, 0, byteData.Length, SocketFlags.None, epAntennaModule, new AsyncCallback(SendData), null);
               }
               catch (Exception e)
               {
                   WriteErrorLog("Sending UDP Message" + e.ToString());

                   //MessageBox.Show("Send Error: " + e.Message, "UDP Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
           }
       }

        public void SendUDPMessage(int header, IPEndPoint _module)
        {

            string msg = "-";
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
    
                            msg = (header.ToString() + "," + mf.mc.gradeControlSettings[mf.mc.gsKpGain] + "," + mf.mc.gradeControlSettings[mf.mc.gsKiGain] + "," + mf.mc.gradeControlSettings[mf.mc.gsKdGain]
                                + "," + mf.mc.gradeControlSettings[mf.mc.gsRetDeadband] + "," + mf.mc.gradeControlSettings[mf.mc.gsExtDeadband] + "," + mf.mc.gradeControlSettings[mf.mc.gsValveType] + "\r\n");


                            break;

                        case GPS_HEADER:

                            break;

                        case IMU_HEADER:

                            break;
                        case RESET_HEADER:

                            break;
                        case SYSTEM_HEADER:
                            

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
                        udpDataTimeout = 0;
                        ledGradeControl.BackColor = Color.Lime;
                        voltageBar.BarColorSolid = Color.RoyalBlue;
                        voltageBar2.BarColorSolid = Color.RoyalBlue;

                        int.TryParse(words[1], out mc.autoState);
                        double.TryParse(words[2], out mc.voltage);
                        double.TryParse(words[3], out mc.voltage2);

                    }
                    else if ((temp > 5))
                    {
                        udpDataTimeout = 0;
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
                    udpGPSTimeout = 0;
                    if (udpIMUTimeout < 50) ledAntenna.BackColor = Color.Lime;
                    else ledAntenna.BackColor = Color.Orange;
                    pn.rawBuffer = recvd.Remove(0, 6);  // Remove the GPS, Header
                    recvSentenceSettings = pn.rawBuffer;

                    break;

                case IMU_HEADER:
                    mc.prevHeadingIMU = mc.headingIMU;
                    udpIMUTimeout = 0;
                    if (udpGPSTimeout < 50) ledAntenna.BackColor = Color.Lime;
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
                        mf.mc.gcFirmware = words[2];

                    }
                    if (mod == 155)
                    {
                        mf.mc.atFirmware = words[2];                        

                    }
                    break;


                default:
                    break;
                    

            }


            //if (words[0] == "DATA" && temp < 4)// Seperate Modules
            //{
            //    udpDataTimeout = 0;
            //    ledGradeControl.BackColor = Color.Lime;
            //    voltageBar.BarColorSolid = Color.RoyalBlue;

            //    int.TryParse(words[1], out mc.autoState);
            //    double.TryParse(words[2], out mc.voltage);
                
            //}
            //if (words[0] == "DATA" && temp > 4) // All in one module 
            //{
            //    udpDataTimeout = 0;
            //    ledGradeControl.BackColor = Color.Lime;

            //    int.TryParse(words[1], out mc.autoState);
            //    double.TryParse(words[2], out mc.voltage);
            //    float.TryParse(words[3], out mc.headingIMU);
            //    float.TryParse(words[4], out mc.pitchIMU);
            //    float.TryParse(words[5], out mc.rollIMU);
            //}

            //if (words[0] == "GPS")
            //{   
            //    udpGPSTimeout = 0;
            //    if (udpIMUTimeout < 50) ledAntenna.BackColor = Color.Lime;
            //    else ledAntenna.BackColor = Color.Orange;
            //    pn.rawBuffer = recvd.Remove(0, 4);  // Remove the GPS, Header
            //    recvSentenceSettings = pn.rawBuffer;            

            //}
            //if (words[0] == "IMU")
            //{
            //    mc.prevHeadingIMU = mc.headingIMU;
            //    udpIMUTimeout = 0;
            //    if (udpGPSTimeout < 50) ledAntenna.BackColor = Color.Lime;
            //    else ledAntenna.BackColor = Color.Orange;
            //    float.TryParse(words[1], out mc.headingIMU);
            //    float.TryParse(words[2], out mc.pitchIMU);
            //    float.TryParse(words[3], out mc.rollIMU);

            //}
  
        }  
    }
}
