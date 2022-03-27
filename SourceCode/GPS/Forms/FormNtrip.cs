using System;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Text;
using System.Threading;
using System.Collections.Generic;

namespace OpenGrade
{
    public partial class FormNtrip : Form
    {
        //class variables
        private readonly FormGPS mf;

        public FormNtrip(Form callingForm)
        {
            mf = callingForm as FormGPS;
            InitializeComponent();

        }

        private void FormNtrip_Load(object sender, EventArgs e)
        {
            

            tboxEnterURL.Text = Properties.Settings.Default.setNTRIP_casterURL;

            tboxCasterIP.Text = Properties.Settings.Default.setNTRIP_casterIP;
            nudCasterPort.Value = Properties.Settings.Default.setNTRIP_casterPort;

            tboxUserName.Text = Properties.Settings.Default.setNTRIP_userName;
            tboxUserPassword.Text = Properties.Settings.Default.setNTRIP_userPassword;
            tboxMount.Text = Properties.Settings.Default.setNTRIP_mount;

            nudGGAInterval.Value = Properties.Settings.Default.setNTRIP_sendGGAInterval;


            nudLatitude.Value = (decimal)Properties.Settings.Default.setNTRIP_manualLat;
            nudLongitude.Value = (decimal)Properties.Settings.Default.setNTRIP_manualLon;

            if (Properties.Settings.Default.setNTRIP_isOn)
            {
                btnNtripOnOff.Text = "ON";
                btnNtripOnOff.BackColor = System.Drawing.Color.Lime;
                mf.isNTRIPOn = true;
                mf.isNTRIP_RequiredOn = true;

            }
            else
            {
                btnNtripOnOff.Text = "OFF";
                btnNtripOnOff.BackColor = System.Drawing.Color.Red;
                mf.isNTRIPOn = false;
                mf.isNTRIP_RequiredOn = false;
            }   
                if (Properties.Settings.Default.setNTRIP_isGGAManual) cboxGGAManual.Text = "Use Manual Fix";
            else cboxGGAManual.Text = "Use GPS Fix";

            if (Properties.Settings.Default.setNTRIP_isHTTP10) cboxHTTP.Text = "1.0";
            else cboxHTTP.Text = "1.1";

        }

        //get the ipv4 address only
        public static string GetIP4Address()
        {
            string IP4Address = String.Empty;

            foreach (IPAddress IPA in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                if (IPA.AddressFamily == AddressFamily.InterNetwork)
                {
                    IP4Address = IPA.ToString();
                    break;
                }
            }

            return IP4Address;
        }

        

        public Boolean CheckIPValid(String strIP)
        {
            //  Split string by ".", check that array length is 3
            string[] arrOctets = strIP.Split('.');

            //at least 4 groups in the IP
            if (arrOctets.Length != 4) return false;

            //  Check each substring checking that the int value is less than 255 and that is char[] length is !> 2
            const Int16 MAXVALUE = 255;
            Int32 temp; // Parse returns Int32
            foreach (String strOctet in arrOctets)
            {
                //check if at least 3 digits but not more OR 0 length
                if (strOctet.Length > 3 || strOctet.Length == 0) return false;

                //make sure all digits
                if (!int.TryParse(strOctet, out int temp2)) return false;

                //make sure not more then 255
                temp = int.Parse(strOctet);
                if (temp > MAXVALUE || temp < 0) return false;
            }
            return true;
        }

        private void tboxCasterIP_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckIPValid(tboxCasterIP.Text))
            {
                tboxCasterIP.Text = "127.0.0.1";
                tboxCasterIP.Focus();
                mf.TimedMessageBox(2000, "Invalid IP Address", "Set to Default Local 127.0.0.1");
            }
        }

        private void btnSerialOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.setNTRIP_casterIP = tboxCasterIP.Text;
            Properties.Settings.Default.setNTRIP_casterPort = (int)nudCasterPort.Value;

            Properties.Settings.Default.setNTRIP_userName = tboxUserName.Text;
            Properties.Settings.Default.setNTRIP_userPassword = tboxUserPassword.Text;
            Properties.Settings.Default.setNTRIP_mount = tboxMount.Text;

            Properties.Settings.Default.setNTRIP_sendGGAInterval = (int)nudGGAInterval.Value;
            Properties.Settings.Default.setNTRIP_manualLat = (double)nudLatitude.Value;
            Properties.Settings.Default.setNTRIP_manualLon = (double)nudLongitude.Value;

            Properties.Settings.Default.setNTRIP_casterURL = tboxEnterURL.Text;
            Properties.Settings.Default.setNTRIP_isGGAManual = cboxGGAManual.Text == "Use Manual Fix";
            Properties.Settings.Default.setNTRIP_isHTTP10 = cboxHTTP.Text == "1.0";

            Properties.Settings.Default.Save();
            Close();
        }

        private void btnSetManualPosition_Click(object sender, EventArgs e)
        {
            nudLatitude.Value = (decimal)mf.pn.latitude;
            nudLongitude.Value = (decimal)mf.pn.longitude;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }


        private List<string> dataList = new List<string>();

        private void btnGetSourceTable_Click(object sender, EventArgs e)
        {
            IPAddress casterIP = IPAddress.Parse(tboxCasterIP.Text.Trim()); //Select correct Address
            int casterPort = (int)nudCasterPort.Value; //Select correct port (usually 2101)

            Socket sckt;
            dataList?.Clear();

            try
            {
                sckt = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
                {
                    Blocking = true
                };
                sckt.Connect(new IPEndPoint(casterIP, casterPort));

                string msg = 
                    "GET / HTTP/1.0\r\n" + 
                    "User-Agent: NTRIP u-blox\r\n" + 
                    "Accept: */*\r\n" + 
                    "Authorization: Basic YmxhY2thY2VpbmR1c3RyaWVzbHRkQGdtYWlsLmNvbTpub25l\r\n"+                                     
                    "Connection: close\r\n" + 
                    "\r\n";
               
                //Send request
                byte[] data = System.Text.Encoding.ASCII.GetBytes(msg);
                sckt.Send(data);
                int bytes = 0;
                byte[] bytesReceived = new byte[1024];
                string page = String.Empty;
                Thread.Sleep(200);

                do
                {
                    bytes = sckt.Receive(bytesReceived, bytesReceived.Length, SocketFlags.None);
                    page += Encoding.ASCII.GetString(bytesReceived, 0, bytes);
                }
                while (bytes > 0);

                if (page.Length > 0)
                {
                    string[] words = page.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < words.Length; i++)
                    {
                        string [] words2 = words[i].Split(';');

                        if (words2[0] == "STR")
                        {
                            dataList.Add(words2[1].Trim().ToString() + "," + words2[9].ToString() + "," + words2[10].ToString()
                          + "," + words2[3].Trim().ToString() + "," + words2[6].Trim().ToString()
                                );
                        }
                    }
                }
            }

            catch (SocketException)
            {
                mf.TimedMessageBox(2000, "Socket Exception", "Invalid IP:Port");
                return;
            }

            catch (Exception)
            {
                mf.TimedMessageBox(2000, "Exception", "Get Source Table Error");
                return;
            }

            if (dataList.Count > 0)
            {
                string syte = "http://monitor.use-snip.com/?hostUrl=" + tboxCasterIP.Text + "&port=" + nudCasterPort.Value.ToString();
                var form = new FormSource(dataList, mf.pn.latitude, mf.pn.longitude, syte, mf, this);
                form.ShowDialog();
            }
            else
            {
                mf.TimedMessageBox(2000, "Error", "No Source Data");
            }


            // Console.WriteLine(page);
            // Process.Start(syte);
        }

        private void NudCasterPort_Enter(object sender, EventArgs e)
        {
            //mf.KeypadToNUD((NumericUpDown)sender);
            btnSerialCancel.Focus();
        }

        private void NudGGAInterval_Enter(object sender, EventArgs e)
        {
            //mf.KeypadToNUD((NumericUpDown)sender);
            btnSerialCancel.Focus();
        }

        private void NudLatitude_Enter(object sender, EventArgs e)
        {
            //mf.KeypadToNUD((NumericUpDown)sender);
            btnSerialCancel.Focus();
        }

        private void NudLongitude_Enter(object sender, EventArgs e)
        {
            //mf.KeypadToNUD((NumericUpDown)sender);
            btnSerialCancel.Focus();
        }

        private void NudSendToUDPPort_Enter(object sender, EventArgs e)
        {
            //mf.KeypadToNUD((NumericUpDown)sender);
            btnSerialCancel.Focus();
        }

        private void tboxEnterURL_Click(object sender, EventArgs e)
        {
            //if (mf.isKeyboardOn)
            //{
            //    mf.KeyboardToText((TextBox)sender);
            //    btnSerialCancel.Focus();
            //}
        }

        private void tboxMount_Click(object sender, EventArgs e)
        {
            //if (mf.isKeyboardOn)
            //{
            //    mf.KeyboardToText((TextBox)sender);
            //    btnSerialCancel.Focus();
            //}
        }

        private void tboxUserName_Click(object sender, EventArgs e)
        {
            //if (mf.isKeyboardOn)
            //{
            //    mf.KeyboardToText((TextBox)sender);
            //    btnSerialCancel.Focus();
            //}
        }

        private void tboxUserPassword_Click(object sender, EventArgs e)
        {
            //if (mf.isKeyboardOn)
            //{
            //    mf.KeyboardToText((TextBox)sender);
            //    btnSerialCancel.Focus();
            //}
        }

       

        private void btnPassPassword_Click(object sender, EventArgs e)
        {
            string actualIP = tboxEnterURL.Text.Trim();
            
            try
            {
                IPAddress[] addresslist = Dns.GetHostAddresses(actualIP);
                tboxCasterIP.Text = "";
                tboxCasterIP.Text = addresslist[0].ToString().Trim();
            }
            catch (Exception)
            {
                mf.TimedMessageBox(1500, "No IP Located", "Can't Find: " + actualIP);
            }
        }

        private void cBoxManPos_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxManPos.Checked)
            {
                nudLatitude.Value = (decimal)mf.pn.latitude;
                nudLongitude.Value = (decimal)mf.pn.longitude;
                nudLatitude.Enabled = false;
                nudLongitude.Enabled = false;
            }
            else
            {
                nudLatitude.Enabled = true;
                nudLongitude.Enabled = true;

            }
            

        }

        private void btnNtripOnOff_Click(object sender, EventArgs e)
        {
            if (btnNtripOnOff.Text == "ON")
            {
                btnNtripOnOff.Text = "OFF";
                btnNtripOnOff.BackColor = System.Drawing.Color.Red;                
                Properties.Settings.Default.setNTRIP_isOn = false;
                mf.isNTRIPOn = false;
                //ShutDownNTRIP();
                //Also stop the requests now
                mf.isNTRIP_RequiredOn = false;

            }
            else
            {
                btnNtripOnOff.Text = "ON";
                btnNtripOnOff.BackColor = System.Drawing.Color.Lime;
                Properties.Settings.Default.setNTRIP_isOn = true;
                mf.isNTRIPOn = true;                

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void nudGGAInterval_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tboxMount_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMnt_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void nudLatitude_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nudLongitude_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboxGGAManual_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnStartNtrip_Click(object sender, EventArgs e)
        {
           mf.SendAuthorization();
        }
    }
}