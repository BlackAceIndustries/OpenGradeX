using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Security.Cryptography;


namespace OpenGrade
{
    public partial class FormGPS
    {
        private readonly FormGPS mf = null;
        private readonly FormUDP com = null;
        // Send and Recv socket
        private Socket sendSocket;
        private Socket recvSocket;

        enum dataType {Connect, Data, Settings, Diagnostic, Error}
        enum moduleType { Antenna_Master, Antenna_Slave, Grade_Control_Slave}


       



        public string[] SSID = new string[] { "-", "-", "-", "-", "-" };
        public string[] SSID_PASS = new string[25];
        public bool isWifidone = false;
        public string ssidPass = "";
        public string ssidName = "";

       
        public long a1Timeout = 0, a2Timeout = 0, gcTimeout = 0;
        public long udpIMUTimeout = 0;

        ///Ports
        private static int openGradePort = 9999; //OpenGrade Server Port
        private static int gradeControlPort = 7777; // GradeControl  Port
        private static int antennaMasterPort = 8888; // Antenna Port
        private static int antennaSlavePort = 8888; // Antenna Port
        private static int senderPort;
        ///Ip Addresses
        private static byte[] openGrade = new byte[] { 192, 168, 0, 226 };
        private static byte[] gradeControl = new byte[] { 192, 168, 0, 229 };
        private static byte[] antennaModule = new byte[] { 192, 168, 0, 225 };
        private static byte[] a2Module = new byte[] { 192, 168, 0, 230 };

        private static IPAddress openGradeIP = new IPAddress(openGrade);   //OpenGradeX Server
        private static IPAddress gradeControlIP = new IPAddress(gradeControl);   // GradeControl Module IP
        private static IPAddress antennaIP = new IPAddress(antennaModule);   // Antenna Module IP 
        private static IPAddress a2IP = new IPAddress(a2Module);   // Antenna Module IP 

        private bool isSendConnected;

        public IPEndPoint epA1;
        public IPEndPoint epA2;
        public IPEndPoint epGradeControl;

        // Data stream
        private byte[] buffer = new byte[1024];

        // Status delegate
        private delegate void UpdateRecvMessageDelegate(string recvMessage);
        private UpdateRecvMessageDelegate updateRecvMessageDelegate = null;



        public void SendUDPMessageNTRIP(int header, byte[] byteData)
        {
            //tboxNTRIPBuffer.Text = byteData.Length.ToString();  

            try
            {
                // Send packet to the zero
                if (byteData.Length != 0) sendSocket.BeginSendTo(byteData, 0, byteData.Length, SocketFlags.None, epA1, new AsyncCallback(SendData), null);


            }
            catch (Exception)
            {
                //WriteErrorLog("Sending UDP Message" + e.ToString());
                //MessageBox.Show("Send Error: " + e.Message, "UDP Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        //public void SendUDPMessage(int header, IPEndPoint _module, int secCase = 0)
        //{

        //    string msg = "";
        //    if (isSendConnected)
        //    {
        //        try
        //        {
        //            switch(header)
        //            {
        //                case DATA_HEADER:  // DATA
                            
        //                    msg = (header.ToString() + "," + mc.GradeControlData[mc.gcDeltaDir] + "," + mc.GradeControlData[mc.gcisAutoActive]
        //                                + "," + Math.Abs(cutDelta) + "\r\n");
        //                    break;

        //                case SETTINGS_HEADER:  // SETTINGS
    
        //                    msg = (header.ToString() + "," + mc.gradeControlSettings[mc.gsKpGain] + "," + mc.gradeControlSettings[mc.gsKiGain] + "," + mc.gradeControlSettings[mc.gsKdGain]
        //                        + "," + mc.gradeControlSettings[mc.gsRetDeadband] + "," + mc.gradeControlSettings[mc.gsExtDeadband] + "," + mc.gradeControlSettings[mc.gsValveType]) + "\r\n"; 

        //                    break;

        //                case GPS_HEADER:

        //                    break;

        //                case IMU_HEADER:
                            
        //                    msg = (header.ToString() + "," + 0);

        //                    break;

        //                case NTRIP_HEADER:

        //                    msg = (header.ToString() + "," + 0);                          

        //                    break;

        //                case WIFI_HEADER:

        //                    switch (secCase)
        //                    {
        //                        case 1:
        //                            msg = (header.ToString() + "," + secCase);
        //                            break;
        //                        case 2:
        //                            msg = (header.ToString() + "," + secCase + "," + ssidName + "," + ssidPass );
        //                            break;
        //                        default:
        //                            break;

        //                    }
                            
        //                    break;

        //                case RESET_HEADER:

        //                    msg = (header.ToString() + "," + 0);

        //                    break;
        //                case SYSTEM_HEADER:
                            
        //                    msg = (header.ToString() + "," + 1);


        //                    break;


        //                default: 

        //                    break;

        //            }

        //            // Get packet as byte array
        //            byte[] byteData = Encoding.ASCII.GetBytes(msg);

        //            if (byteData.Length != 0)

        //                // Send packet to the zero
        //                sendSocket.BeginSendTo(byteData, 0, byteData.Length, SocketFlags.None, _module, new AsyncCallback(SendData), null);
        //        }
        //        catch (Exception e)
        //        {
        //            WriteErrorLog("Sending UDP Message" + e.ToString());

        //            //MessageBox.Show("Send Error: " + e.Message, "UDP Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}


        public void SendUDPMessageJSON(int _mod, int _msg, int _id, IPEndPoint _module)
        {
            Dictionary<string, object> root = new Dictionary<string, object>();
            string jsonString = "";

            //moduleType.Antenna_Master;

            if (isSendConnected)
            {
                try
                {
                    switch (_mod)
                    {
                        case (int)moduleType.Antenna_Master:
                            
                            switch (_msg)
                            {
                                case (int)dataType.Connect:

                                    root["modType"] = _mod;
                                    root["msgType"] = _msg;
                                    root["modId"] = _id;
                                    root["connected"] = mc.a1connectMsg.connected;
                                    root["readingId"] = mc.a1connectMsg.readingId;
                                    // Serialize the root dictionary into a JSON string
                                    jsonString = JsonSerializer.Serialize(root);

                                    break;

                                case (int)dataType.Data:

                                    //root["modType"] = mc.a1Data.modType;
                                    //root["msgType"] = mc.a1Data.msgType;
                                    //root["modId"] = mc.a1Data.modId;
                                    root["modType"] = _mod;
                                    root["msgType"] = _msg;
                                    root["modId"] = _id;
                                    root["GGA"] = mc.a1Data.GGA;
                                    root["VTG"] = mc.a1Data.VTG;
                                    root["GSA"] = mc.a1Data.GSA;
                                    root["roll"] = mc.a1Data.roll;
                                    root["pitch"] = mc.a1Data.pitch;
                                    root["yaw"] = mc.a1Data.yaw;
                                    root["battery"] = mc.a1Data.battery;
                                    root["readingId"] = mc.a1Data.readingId;
                                    jsonString = JsonSerializer.Serialize(root);

                                    break;

                                case (int)dataType.Settings:
                                    root["modType"] = mc.a1Setting.modType;
                                    root["msgType"] = mc.a1Setting.msgType;
                                    root["modId"] = mc.a1Setting.modId;
                                    root["readingId"] = mc.a1Setting.readingId;
                                    jsonString = JsonSerializer.Serialize(root);

                                    break;

                                case (int)dataType.Diagnostic:
                                    root["modType"] = mc.a1Firmware.modType;
                                    root["msgType"] = mc.a1Firmware.msgType;
                                    root["modId"] = mc.a1Firmware.modId;
                                    root["modId"] = mc.a1Firmware.firmware;
                                    root["modId"] = mc.a1Firmware.hardware;
                                    root["readingId"] = mc.a1Firmware.readingId;
                                    jsonString = JsonSerializer.Serialize(root);

                                    break;

                                case (int)dataType.Error:

                                    break;

                                default:

                                    break;
                            }
                            break;


                        case (int)moduleType.Antenna_Slave:

                            switch (_msg)
                            {
                                case (int)dataType.Connect:

                                    root["modType"] = _mod;
                                    root["msgType"] = _msg;
                                    root["modId"] = _id;
                                    root["connected"] = mc.a2connectMsg.connected;
                                    root["readingId"] = mc.a2connectMsg.readingId;
                                    // Serialize the root dictionary into a JSON string
                                    jsonString = JsonSerializer.Serialize(root);

                                    break;

                                case (int)dataType.Data:

                                    //root["modType"] = mc.a2Data.modType;
                                    //root["msgType"] = mc.a2Data.msgType;
                                    //root["modId"] = mc.a2Data.modId;
                                    root["modType"] = _mod;
                                    root["msgType"] = _msg;
                                    root["modId"] = _id;
                                    root["GGA"] = mc.a2Data.GGA;
                                    root["VTG"] = mc.a2Data.VTG;
                                    root["GSA"] = mc.a2Data.GSA;
                                    root["roll"] = mc.a2Data.roll;
                                    root["pitch"] = mc.a2Data.pitch;
                                    root["yaw"] = mc.a2Data.yaw;
                                    root["battery"] = mc.a2Data.battery;
                                    root["readingId"] = mc.a2Data.readingId;
                                    jsonString = JsonSerializer.Serialize(root);

                                    break;

                                case (int)dataType.Settings:
                                    //root["modType"] = mc.a2Setting.modType;
                                    //root["msgType"] = mc.a2Setting.msgType;
                                    //root["modId"] = mc.a2Setting.modId;
                                    root["modType"] = _mod;
                                    root["msgType"] = _msg;
                                    root["modId"] = _id;
                                    root["readingId"] = mc.a2Setting.readingId;
                                    jsonString = JsonSerializer.Serialize(root);

                                    break;

                                case (int)dataType.Diagnostic:
                                    //root["modType"] = mc.a2Firmware.modType;
                                    //root["msgType"] = mc.a2Firmware.msgType;
                                    //root["modId"] = mc.a2Firmware.modId;
                                    root["modType"] = _mod;
                                    root["msgType"] = _msg;
                                    root["modId"] = _id;
                                    root["modId"] = mc.a2Firmware.firmware;
                                    root["modId"] = mc.a2Firmware.hardware;
                                    root["readingId"] = mc.a2Firmware.readingId;
                                    jsonString = JsonSerializer.Serialize(root);

                                    break;

                                case (int)dataType.Error:

                                    break;

                                default:

                                    break;
                            }
                            break;
                        case (int)moduleType.Grade_Control_Slave:

                            switch (_msg)
                            {
                                case (int)dataType.Connect:

                                    root["modType"] = _mod;
                                    root["msgType"] = _msg;
                                    root["modId"] = _id;
                                    root["connected"] = mc.gcconnectMsg.connected;
                                    root["readingId"] = mc.gcconnectMsg.readingId;
                                    // Serialize the root dictionary into a JSON string
                                    jsonString = JsonSerializer.Serialize(root);

                                    break;

                                case (int)dataType.Data:

                                    root["modType"] = _mod;
                                    root["msgType"] = _msg;
                                    root["modId"] = _id;
                                    //root["modType"] = mc.gcData.modType;
                                    //root["msgType"] = mc.gcData.msgType;
                                    //root["modId"] = mc.gcData.modId;
                                    root["deltaA"] = mc.gcData.deltaA;
                                    root["deltaB"] = mc.gcData.deltaB;
                                    root["setpointA"] = mc.gcData.setPointA;
                                    root["setpointB"] = mc.gcData.setPointB;
                                    root["autoVert"] = mc.gcData.autoVert;
                                    root["autoTilt"] = mc.gcData.autoTilt;
                                    root["readingId"] = mc.gcData.readingId;
                                    jsonString = JsonSerializer.Serialize(root);

                                    break;

                                case (int)dataType.Settings:


                                    //root["modType"] = mc.gcSetting.modType;
                                    //root["msgType"] = mc.gcSetting.msgType;
                                    //root["modId"] = mc.gcSetting.modId;
                                    root["modType"] = _mod;
                                    root["msgType"] = _msg;
                                    root["modId"] = _id;
                                    root["KP"] = mc.gcSetting.KP;
                                    root["KI"] = mc.gcSetting.KI;
                                    root["KD"] = mc.gcSetting.KD;
                                    root["retDead"] = mc.gcSetting.retDead;
                                    root["extDead"] = mc.gcSetting.extDead;
                                    root["valveType"] = mc.gcSetting.valveType;
                                    root["readingId"] = mc.gcData.readingId;
                                    jsonString = JsonSerializer.Serialize(root);
                                    break;

                                case (int)dataType.Diagnostic:
                                    //root["modType"] = mc.gcFirmware.modType;
                                    //root["msgType"] = mc.gcFirmware.msgType;
                                    //root["modId"] = mc.gcFirmware.modId;
                                    root["modType"] = _mod;
                                    root["msgType"] = _msg;
                                    root["modId"] = _id;
                                    root["fw"] = mc.gcFirmware.firmware;
                                    root["hw"] = mc.gcFirmware.hardware;
                                    root["readingId"] = mc.gcFirmware.readingId++;
                                    jsonString = JsonSerializer.Serialize(root);


                                    break;

                                case (int)dataType.Error:

                                    break;

                                default:

                                    break;
                            }
                            break;

                        default:

                            break;


                    }

                            // Get packet as byte array
                            byte[] byteData = Encoding.ASCII.GetBytes(jsonString);

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
                // Cleanup resources (optional)
                //sendSocket.Close();
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
            char[] recv = recvd.ToCharArray();            

            JsonDocument doc = JsonDocument.Parse(recvd);

            byte modType = doc.RootElement.GetProperty("modType").GetByte();
            byte msgType = doc.RootElement.GetProperty("msgType").GetByte();
            byte modID = doc.RootElement.GetProperty("modId").GetByte();


            switch (modType) {

                case (byte)moduleType.Antenna_Master:
                    {
                        a1Timeout = 0;
                        
                        if (msgType == (byte)dataType.Connect)
                        {
                            mc.a1connectMsg.modType = doc.RootElement.GetProperty("modType").GetByte();
                            mc.a1connectMsg.msgType = doc.RootElement.GetProperty("msgType").GetByte();
                            mc.a1connectMsg.modId = doc.RootElement.GetProperty("modId").GetByte();
                            mc.a1connectMsg.connected = doc.RootElement.GetProperty("connected").GetByte();
                            mc.a1connectMsg.readingId = doc.RootElement.GetProperty("readingId").GetUInt16();


                        }
                        if (msgType == (byte)dataType.Data)
                        {                          
                            

                            mc.a1Data.modType = doc.RootElement.GetProperty("modType").GetByte();
                            mc.a1Data.msgType = doc.RootElement.GetProperty("msgType").GetByte();
                            mc.a1Data.modId = doc.RootElement.GetProperty("modId").GetByte();
                            mc.a1Data.GGA = doc.RootElement.GetProperty("GGA").GetString();
                            mc.a1Data.VTG = doc.RootElement.GetProperty("VTG").GetString();
                            mc.a1Data.GSA = doc.RootElement.GetProperty("GSA").GetString();
                            mc.a1Data.roll = Convert.ToDouble(doc.RootElement.GetProperty("roll").GetString());
                            mc.a1Data.pitch = Convert.ToDouble(doc.RootElement.GetProperty("pitch").GetString());
                            mc.a1Data.yaw = Convert.ToDouble(doc.RootElement.GetProperty("yaw").GetString());
                            mc.a1Data.battery = doc.RootElement.GetProperty("battery").GetString();
                            //mc.a1Data.readingId = doc.RootElement.GetProperty("readingId").GetUInt16();
                            mc.a1Data.readingId = doc.RootElement.GetProperty("readingId").GetUInt64();


                            pn.rawBuffer = mc.a1Data.GGA + "\r\n";
                            pn.rawBuffer = pn.rawBuffer + mc.a1Data.VTG + "\r\n";
                            pn.rawBuffer = pn.rawBuffer + mc.a1Data.GSA + "\r\n";
                            recvSentenceSettings = pn.rawBuffer;

                            //SendUDPMessageJSON((int)CModuleComm.ModuleType.Antenna_Master, (int)CModuleComm.DataType.Data, 1, epAntennaModule);




                        }
                        if (msgType == (byte)dataType.Settings)
                        {

                            mc.a1Setting.modType = doc.RootElement.GetProperty("modType").GetByte();
                            mc.a1Setting.msgType = doc.RootElement.GetProperty("msgType").GetByte();
                            mc.a1Setting.modId = doc.RootElement.GetProperty("modId").GetByte();                           
                            mc.a1Setting.readingId = doc.RootElement.GetProperty("readingId").GetUInt64();


                        }
                        if (msgType == (byte)dataType.Diagnostic)
                        {
                            mc.a1Firmware.modType = doc.RootElement.GetProperty("modType").GetByte();
                            mc.a1Firmware.msgType = doc.RootElement.GetProperty("msgType").GetByte();
                            mc.a1Firmware.modId = doc.RootElement.GetProperty("modId").GetByte();
                            mc.a1Firmware.firmware = doc.RootElement.GetProperty("fw").GetString();
                            mc.a1Firmware.hardware = doc.RootElement.GetProperty("hw").GetString();
                            mc.a1Firmware.readingId = doc.RootElement.GetProperty("readingId").GetUInt64();

                        }
                        if (msgType == (byte)dataType.Error)
                        {

                        }

                        break;
                    }


                case (byte)moduleType.Antenna_Slave:
                    {
                        a2Timeout = 0;
                        
                        if (msgType == (byte)dataType.Connect)
                        {
                            mc.a2connectMsg.modType = doc.RootElement.GetProperty("modType").GetByte();
                            mc.a2connectMsg.msgType = doc.RootElement.GetProperty("msgType").GetByte();
                            mc.a2connectMsg.modId = doc.RootElement.GetProperty("modId").GetByte();
                            mc.a2connectMsg.connected = doc.RootElement.GetProperty("connected").GetByte();
                            mc.a2connectMsg.readingId = doc.RootElement.GetProperty("readingId").GetUInt64();


                        }
                        if (msgType == (byte)dataType.Data)
                        {   

                            mc.a2Data.modType = doc.RootElement.GetProperty("modType").GetByte();
                            mc.a2Data.msgType = doc.RootElement.GetProperty("msgType").GetByte();
                            mc.a2Data.modId = doc.RootElement.GetProperty("modId").GetByte();
                            mc.a2Data.GGA = doc.RootElement.GetProperty("GGA").GetString();
                            mc.a2Data.VTG = doc.RootElement.GetProperty("VTG").GetString();
                            mc.a2Data.GSA = doc.RootElement.GetProperty("GSA").GetString();
                            mc.a2Data.roll = doc.RootElement.GetProperty("roll").GetDouble();
                            mc.a2Data.pitch = doc.RootElement.GetProperty("pitch").GetDouble();
                            mc.a2Data.yaw = doc.RootElement.GetProperty("yaw").GetDouble();
                            mc.a2Data.battery = doc.RootElement.GetProperty("battery").GetString();
                            mc.a2Data.readingId = doc.RootElement.GetProperty("readingId").GetUInt64();

                            pn2.rawBuffer = mc.a2Data.GGA + "\r\n";
                            pn2.rawBuffer = pn2.rawBuffer + mc.a2Data.VTG + "\r\n";
                            recvSentenceSettings2 = pn2.rawBuffer;


                        }
                        if (msgType == (byte)dataType.Settings)
                        {

                            mc.a2Setting.modType = doc.RootElement.GetProperty("modType").GetByte();
                            mc.a2Setting.msgType = doc.RootElement.GetProperty("msgType").GetByte();
                            mc.a2Setting.modId = doc.RootElement.GetProperty("modId").GetByte();
                            mc.a2Setting.readingId = doc.RootElement.GetProperty("readingId").GetUInt64();


                        }
                        if (msgType == (byte)dataType.Diagnostic)
                        {
                            mc.a2Firmware.modType = doc.RootElement.GetProperty("modType").GetByte();
                            mc.a2Firmware.msgType = doc.RootElement.GetProperty("msgType").GetByte();
                            mc.a2Firmware.modId = doc.RootElement.GetProperty("modId").GetByte();
                            mc.a2Firmware.firmware = doc.RootElement.GetProperty("fw").GetString();
                            mc.a2Firmware.hardware = doc.RootElement.GetProperty("hw").GetString();
                            mc.a2Firmware.readingId = doc.RootElement.GetProperty("readingId").GetUInt64();

                        }


                        if (msgType == (byte)dataType.Error)
                        {

                        }


                        break;
                    }

                case (byte)moduleType.Grade_Control_Slave:
                    {
                        gcTimeout = 0;

                        if (msgType == (byte)dataType.Connect)
                        {
                            mc.gcconnectMsg.modType = doc.RootElement.GetProperty("modType").GetByte();
                            mc.gcconnectMsg.msgType = doc.RootElement.GetProperty("msgType").GetByte();
                            mc.gcconnectMsg.modId = doc.RootElement.GetProperty("modId").GetByte();
                            mc.gcconnectMsg.connected = doc.RootElement.GetProperty("connected").GetByte();
                            mc.gcconnectMsg.readingId = doc.RootElement.GetProperty("readingId").GetUInt64();

                        }
                        if (msgType == (byte)dataType.Data)
                        {
                            mc.gcData.modType = doc.RootElement.GetProperty("modType").GetByte();
                            mc.gcData.msgType = doc.RootElement.GetProperty("msgType").GetByte();
                            mc.gcData.modId = doc.RootElement.GetProperty("modId").GetByte();
                            //mc.gcData.deltaA = doc.RootElement.GetProperty("deltaA").GetInt16();
                            //mc.gcData.deltaB = doc.RootElement.GetProperty("deltaB").GetInt16();
                            mc.gcData.setPointA = doc.RootElement.GetProperty("setpointA").GetInt16();
                            mc.gcData.setPointB = doc.RootElement.GetProperty("setpointB").GetInt16();
                            //mc.gcData.autoVert = doc.RootElement.GetProperty("autoVert").GetBoolean();
                            //mc.gcData.autoTilt = doc.RootElement.GetProperty("autoTilt").GetBoolean();
                            mc.isAutoVertIn = doc.RootElement.GetProperty("autoVert").GetBoolean();
                            mc.isAutoTiltIn = doc.RootElement.GetProperty("autoTilt").GetBoolean();
                            mc.gcData.readingId = doc.RootElement.GetProperty("readingId").GetUInt64();





                            if (mc.isAutoVertIn != mc.gcData.autoVert)
                            {
                                //btnVertAuto.PerformClick();

                            }
                           

                            if (mc.isAutoTiltIn != mc.gcData.autoTilt)
                            {

                            }

                            SendUDPMessageJSON((int)CModuleComm.ModuleType.GradeControl_Slave, (int)CModuleComm.DataType.Data, 1, epGradeControl);


                        }
                        if (msgType == (byte)dataType.Settings)
                        {
                            mc.gcSetting.modType = doc.RootElement.GetProperty("modType").GetByte();
                            mc.gcSetting.msgType = doc.RootElement.GetProperty("msgType").GetByte();
                            mc.gcSetting.modId = doc.RootElement.GetProperty("modId").GetByte();
                            mc.gcSetting.KP = doc.RootElement.GetProperty("KP").GetByte();
                            mc.gcSetting.KI = doc.RootElement.GetProperty("KI").GetByte();
                            mc.gcSetting.KD = doc.RootElement.GetProperty("KD").GetByte();
                            mc.gcSetting.retDead = doc.RootElement.GetProperty("retDead").GetByte();
                            mc.gcSetting.extDead = doc.RootElement.GetProperty("extDead").GetByte();
                            mc.gcSetting.valveType = doc.RootElement.GetProperty("valveType").GetByte();
                            mc.gcData.readingId = doc.RootElement.GetProperty("readingId").GetUInt64();

                        }
                        if (msgType == (byte)dataType.Diagnostic)
                        {
                            mc.gcFirmware.modType = doc.RootElement.GetProperty("modType").GetByte();
                            mc.gcFirmware.msgType = doc.RootElement.GetProperty("msgType").GetByte();
                            mc.gcFirmware.modId = doc.RootElement.GetProperty("modId").GetByte();
                            mc.gcFirmware.firmware = doc.RootElement.GetProperty("fw").GetString();
                            mc.gcFirmware.hardware = doc.RootElement.GetProperty("hw").GetString();
                            mc.gcFirmware.readingId = doc.RootElement.GetProperty("readingId").GetUInt64();


                        }
                        if (msgType == (byte)dataType.Error)
                        {

                        }
                        


                        break;
                    }




                    
                default:
                    break;
                    

            }
        }  
    }
}
