using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Drawing;
using System.Globalization;

// Declare the delegate prototype to send data back to the form
delegate void UpdateRTCM_Data(byte[] data);

namespace OpenGrade
{
    public partial class FormGPS
    {

        private Socket clientSocket;                      // Server connection
        private byte[] casterRecBuffer = new byte[2048];    // Recieved data buffer
        private event UpdateRTCM_Data updateRTCM_DataEvent;              // Add Message Event handler for Form
        private readonly StringBuilder sbRTCM = new StringBuilder();


        //Send GGA back timer
        Timer tmr;

        public bool isNTRIPOn;
        private string rtcm;
        private string rtcmRaw;
        
        private string mount;
        private string username;
        private string password;
        public int reconnectCounter = 0;
        
        

        private string broadCasterIP;
        private int broadCasterPort;

        private int sendGGAInterval = 0;
        private string GGASentence;

        public  long  tripBytes = 0;
        private int toUDP_Port = 0;
        private int NTRIP_Watchdog = 100;

        public bool isNTRIP_RequiredOn = false;
        public bool isNTRIP_Connected = false;
        public bool isNTRIP_Starting = false;
        public bool isNTRIP_Connecting = false;
        public bool isNTRIP_Sending = false;
        public bool isRunGGAInterval = false;

        private void NTRIPtick(object o, EventArgs e)
        {
            //SendGGA();
        }

        private void ReconnectRequest()
        {
            //TimedMessageBox(2000, "NTRIP Not Connected", " Reconnect Request");
            ntripCounter = 10;
            isNTRIP_Connected = false;
            isNTRIP_Starting = false;
            isNTRIP_Connecting = false;

            //if we had a timer already, kill it
            if (tmr != null)
            {
                tmr.Dispose();
            }
        }

        private void IncrementNTRIPWatchDog()
        {
            //increment once every second
            ntripCounter++;

            //Thinks is connected but not receiving anything
            if (NTRIP_Watchdog++ > 800 && isNTRIP_Connected)
            {
                mf.ledNTRIP.BackColor = Color.Black;
                mf.isNTRIPOn = false;
                ReconnectRequest();
            }


            //Once all connected set the timer GGA to NTRIP Settings
            if (sendGGAInterval > 0 && ntripCounter == 40) tmr.Interval = sendGGAInterval * 1000;
            
        }

        //set up connection to Caster
        public void StartNTRIP()
        {
            broadCasterIP = Properties.Settings.Default.setNTRIP_casterIP; //Select correct Address
            reconnectCounter++;

            tboxNTRIPBuffer.Text = "Start";

            string actualIP = Properties.Settings.Default.setNTRIP_casterURL.Trim();
            try
            {
                IPAddress[] addresslist = Dns.GetHostAddresses(actualIP);
                broadCasterIP = addresslist[0].ToString().Trim();
            }
            catch (Exception)
            {
                TimedMessageBox(2500, gStr.gsNoIPLocated, gStr.gsCannotFind + Properties.Settings.Default.setNTRIP_casterURL);
            }
                                          
            broadCasterPort = Properties.Settings.Default.setNTRIP_casterPort; //Select correct port (usually 80 or 2101)
            
            mount = Properties.Settings.Default.setNTRIP_mount; //Insert the correct mount
            
            username = Properties.Settings.Default.setNTRIP_userName; //Insert your username!
            password = Properties.Settings.Default.setNTRIP_userPassword; //Insert your password!            
            sendGGAInterval = Properties.Settings.Default.setNTRIP_sendGGAInterval; //how often to send fixes

            tboxNTRIPBuffer.Text += "  Ip -> " + broadCasterIP + " Port -> " + 
                broadCasterPort + " Mount -> " + mount + " GGA -> " + sendGGAInterval.ToString() + 
                " Connection Attempt -> " + reconnectCounter + "\r\n\r\n";
            


            //if we had a timer already, kill it
            if (tmr != null)
            {
                tboxNTRIPBuffer.Text += "Timer Killed \r\n";
                tmr.Dispose();
            }

            //create new timer at fast rate to start
            if (sendGGAInterval > 0)
            {
                this.tmr = new System.Windows.Forms.Timer();
                this.tmr.Interval = 5000;
                this.tmr.Tick += new EventHandler(NTRIPtick);
            }
            

            try
            {
                // Close the socket if it is still open
                if (clientSocket != null && clientSocket.Connected)
                {
                    tboxNTRIPBuffer.Text += "Close Socket \r\n";
                    clientSocket.Shutdown(SocketShutdown.Both);
                    System.Threading.Thread.Sleep(100);
                    clientSocket.Close();
                }

                // Create the socket object
                clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                // Define the Server address and port
                IPEndPoint epCaster = new IPEndPoint(IPAddress.Parse(broadCasterIP), broadCasterPort);

                // Connect to server non-Blocking method
                clientSocket.Blocking = false;
                AsyncCallback onconnect = new AsyncCallback(OnConnect);
                clientSocket.BeginConnect(epCaster, onconnect, clientSocket);
            }
            catch (Exception)
            {
                TimedMessageBox(1000, gStr.gsNTRIPNotConnectedRetrying, gStr.gsAtSocketConnect);
                ReconnectRequest();
                return;
            }
           
            isNTRIP_Connecting = true;
            
            //make sure connection is made
            //System.Threading.Thread.Sleep(2000);
        }

        public void SendAuthorization()
        {

            //send the authourization info for Broadcaster

            // Check we are connected
            if (clientSocket == null || !clientSocket.Connected)
            {
                TimedMessageBox(2000, gStr.gsNTRIPNotConnected, " Re-Connecting ");
                ReconnectRequest();
                return;
            }
            

            // Read the message from settings and send it
            try
            {
                /*string str = 
                 * GET /SRG HTTP / 1.1\r\n
                 * User - Agent: NTRIP LefebureNTRIPClient/ 20131124\r\n
                 * Accept: +/* \r\n
                 * Authorization: Basic (userName+Password)
                 * Connection: close\r\n
                 */

               
                //encode user and password
                string auth = ToBase64(username + ":" + password);

                //grab location sentence
                BuildGGA();
                GGASentence = sbGGA.ToString();
                tboxNTRIPBuffer.Text += " Send Authorization" + '\n';

                string htt;
                if (Properties.Settings.Default.setNTRIP_isHTTP10) htt = "1.0";
                else htt = "1.1";

                //Build authorization string
                string str = 
                    "GET /" + mount + " HTTP/" + htt + "\r\n" +
                    "User-Agent: NTRIP u-blox\r\n" +
                    "Accept: */* \r\n" +
                    "Authorization: Basic " + auth + "\r\n" +                    
                    "Connection: close \r\n" +                                          //str += GGASentence; //this line can be removed if no position feedback is needed                
                    "\r\n";

                


                tboxNTRIPBuffer.Text += " Authorization String > \r\n" + str + "\r\n";
                // Convert to byte array and send.
                Byte[] byteDateLine = Encoding.ASCII.GetBytes(str.ToCharArray());
                clientSocket.Send(byteDateLine, byteDateLine.Length, 0);
                    
                
                //enable to periodically send GGA sentence to server.
                if (sendGGAInterval > 0) tmr.Enabled = true;
               
                //say its connected
                isNTRIP_Connected = true;
                isNTRIP_Starting = false;
                isNTRIP_Connecting = false;
                isNTRIPOn = true;
                tboxNTRIPBuffer.Text += " Authorization Sent" + '\n';
                

                //btnStartStopNtrip.Text = gStr.gsStop;

            }
            catch (Exception)
            {
               MessageBox.Show(this, "Error lol", "Send Message Failed!");
            }

        }

        public void OnAddMessage(byte[] data)
        {
            //update gui with stats 
            uint nBytesRecvd = (uint)data.Length;            
            tripBytes += (uint)nBytesRecvd;
         
            //reset watchdog since we have updated data
            NTRIP_Watchdog = 0;

            //send out UDP Port          

            try
            {             

                if (nBytesRecvd > 0)
                {

                    byte[] localMsg = new byte[nBytesRecvd];
                    Array.Copy(data, localMsg, nBytesRecvd);

                    // Write the data to the List
                    sbRTCM.Clear();
                    sbRTCM.Append(NTRIP_HEADER);
                    sbRTCM.Append(",");
                    
                    for (int i = 0; i < nBytesRecvd; i++)
                    {
                        
                        sbRTCM.Append(data[i]);
                        sbRTCM.Append(",");

                        rtcmRaw += data[i];
                        rtcmRaw += " ";


                    }
                    sbRTCM.Append("\r\n");
                    rtcm = sbRTCM.ToString();

                    //SendUDPMessageNTRIP(NTRIP_HEADER, rtcm);
                    SendUDPMessageNTRIP(NTRIP_HEADER, data);

                }



            }
            catch (Exception ex)
            {
                WriteErrorLog("NTRIP Data UDP Send" + ex.ToString());
            }

            sbRTCM.Clear();
            sbRTCM.Append("Bytes Recieved-> " + (nBytesRecvd) + "\r\n");
            sbRTCM.Append("Total Bytes Recieved -> " + tripBytes.ToString() + "\r\n");
            sbRTCM.Append("Message Recieved -> " + rtcmRaw + "\r\n");
            sbRTCM.Append("\r\n");
            tboxNTRIPBuffer.Text = sbRTCM.ToString();            
            rtcmRaw = "";
            
        }

        public void SendGGA()
        {
            //timer may have brought us here so return if not connected
            if (!isNTRIP_Connected)
                return;
            // Check we are connected
            if (clientSocket == null || !clientSocket.Connected)
            {
                TimedMessageBox(1000, gStr.gsNTRIPNotConnectedToSendGGA, gStr.gsRestartingAndReconnectingToCaster);
                ReconnectRequest();

                return;
            }

            // Read the message from the text box and send it
            try
            {   
                //tboxNTRIPBuffer.Text += "GGA SENT" + '\n';

                isNTRIP_Sending = true;
                BuildGGA();
                string str = sbGGA.ToString();
                
                Byte[] byteDateLine = Encoding.ASCII.GetBytes(str.ToCharArray());
                clientSocket.Send(byteDateLine, byteDateLine.Length, 0);
            }
            catch (Exception)
            {
                //MessageBox.Show(this, ex.Message, "Send Message Failed!");
            }
        }

        public void OnConnect(IAsyncResult ar)
        {
            // Socket was the passed in object
            Socket sock = (Socket)ar.AsyncState;
            
            // Check if we were sucessfull
            try
            {
                //sock.EndConnect( ar );
                if (sock.Connected)                {
                    //tboxNTRIPBuffer.Text = "Setup RecievCallback";
                    SetupRecieveCallback(sock);
                }
                else
                    MessageBox.Show("Unable to connect to remote machine", "Connect Failed!");
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message, "Unusual error during Connect!");
            }
        }

        public void OnRecievedData(IAsyncResult ar)
        {
            // Socket was the passed in object
            Socket sock = (Socket)ar.AsyncState;
            //tboxNTRIPBuffer.Text += "Data Receieved -> SUCCESS" + '\n';

            // Check if we got any data
            try
            {                
                int nBytesRec = sock.EndReceive(ar);
                //nBytesRec += 500;
                if (nBytesRec > 0)
                {

                    byte[] localMsg = new byte[nBytesRec];
                    Array.Copy(casterRecBuffer, localMsg, nBytesRec);                    

                    // Wrote the data to the List
                    string sRecieved = Encoding.ASCII.GetString(casterRecBuffer, 0, nBytesRec);                    

                    // WARNING : The following line is NOT thread safe. Invoke is                   
                    Invoke(updateRTCM_DataEvent, new object[] { localMsg });

                    // If the connection is still usable restablish the callback                    
                    SetupRecieveCallback(sock);
                }
                else
                {
                    // If no data was recieved then the connection is probably dead
                    Console.WriteLine("Client {0}, disconnected", sock.RemoteEndPoint);
                    sock.Shutdown(SocketShutdown.Both);
                    sock.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show( this, "Unusual error druing Recieve!", "Unusual error druing Recieve!" );
            }
        }

        public void SetupRecieveCallback(Socket sock)
        {
            try
            {
                //tboxNTRIPBuffer.Text = "Setup Recieve Callback Try!";
                AsyncCallback recieveData = new AsyncCallback(OnRecievedData);
                sock.BeginReceive(casterRecBuffer, 0, casterRecBuffer.Length, SocketFlags.None, recieveData, sock);
            }
            catch (Exception)
            {
                //tboxNTRIPBuffer.Text = "Setup Recieve Callback failed!";
                //MessageBox.Show(this, ex.Message, );
            }
        }

        private string ToBase64(string str)
        {
            Encoding asciiEncoding = Encoding.ASCII;
            byte[] byteArray = new byte[asciiEncoding.GetByteCount(str)];
            byteArray = asciiEncoding.GetBytes(str);
            return Convert.ToBase64String(byteArray, 0, byteArray.Length);
        }

        public void ShutDownNTRIP()
        {
            if (clientSocket != null && clientSocket.Connected)
            {
                clientSocket.Shutdown(SocketShutdown.Both);
                clientSocket.Close();
                System.Threading.Thread.Sleep(500);

                TimedMessageBox(2000, gStr.gsNTRIPOff, gStr.gsClickStartToResume);
                ReconnectRequest();

                //Also stop the requests now
                isNTRIP_RequiredOn = false;
            }

        }

        private void SettingsShutDownNTRIP()
        {
            if (clientSocket != null && clientSocket.Connected)
            {
                clientSocket.Shutdown(SocketShutdown.Both);
                clientSocket.Close();
                System.Threading.Thread.Sleep(500);

                TimedMessageBox(2000, gStr.gsNTRIPRestarting, gStr.gsResumingWithNewSettings);
                ReconnectRequest();

                //Continue to restart
                isNTRIP_RequiredOn = true;
            }
        }

        //calculate the NMEA checksum to stuff at the end
        public string CalculateChecksum(string Sentence)
        {
            int sum = 0, inx;
            char[] sentence_chars = Sentence.ToCharArray();
            char tmp;
            // All character xor:ed results in the trailing hex checksum
            // The checksum calc starts after '$' and ends before '*'
            for (inx = 1; ; inx++)
            {
                tmp = sentence_chars[inx];
                // Indicates end of data and start of checksum
                if (tmp == '*')
                    break;
                sum ^= tmp;    // Build checksum
            }
            // Calculated checksum converted to a 2 digit hex string
            return String.Format("{0:X2}", sum);
        }

        private readonly StringBuilder sbGGA = new StringBuilder();

        private void BuildGGA()
        {
            double latitude = 0;
            double longitude = 0;

            if (Properties.Settings.Default.setNTRIP_isGGAManual)
            {
                latitude = Properties.Settings.Default.setNTRIP_manualLat;
                longitude = Properties.Settings.Default.setNTRIP_manualLon;
            }
            else
            {
                latitude = pn.latitude;
                longitude = pn.longitude;
            }
            //convert to DMS from Degrees
            double latMinu = latitude;
            double longMinu = longitude;

            double latDeg = (int)latitude;
            double longDeg = (int)longitude;

            latMinu -= latDeg;
            longMinu -= longDeg;

            latMinu = Math.Round(latMinu * 60.0, 7);
            longMinu = Math.Round(longMinu * 60.0, 7);

            latDeg *= 100.0;
            longDeg *= 100.0;

            double latNMEA = latMinu + latDeg;
            double longNMEA = longMinu + longDeg;

            char NS = 'W';
            char EW = 'N';
            if (latitude >= 0) NS = 'N';
            else NS = 'S';
            if (longitude >= 0) EW = 'E';
            else EW = 'W';

            sbGGA.Clear();
            sbGGA.Append("$GPGGA,");
            sbGGA.Append(DateTime.Now.ToString("HHmmss.00,", CultureInfo.InvariantCulture));
            sbGGA.Append(Math.Abs(latNMEA).ToString("0000.000", CultureInfo.InvariantCulture)).Append(',').Append(NS).Append(',');
            sbGGA.Append(Math.Abs(longNMEA).ToString("00000.000", CultureInfo.InvariantCulture)).Append(',').Append(EW);
            sbGGA.Append(",1,10,1,43.4,M,46.4,M,5,0*");

            sbGGA.Append(CalculateChecksum(sbGGA.ToString()));
            sbGGA.Append("\r\n");
            /*
        $GPGGA,123519,4807.038,N,01131.000,E,1,08,0.9,545.4,M,46.9,M,5,0*47
           0     1      2      3    4      5 6  7  8   9    10 11  12 13  14
                Time      Lat       Lon     FixSatsOP Alt */
        }
    }
}