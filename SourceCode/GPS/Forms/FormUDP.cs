using System;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;
using System.Reflection;
using System.Windows;

namespace OpenGrade
{
    public partial class FormUDP : Form
    {
        //class variables
        private readonly FormGPS mf = null;

        public FormUDP(Form callingForm)
        {
            //get copy of the calling main form
            mf = callingForm as FormGPS;
            InitializeComponent();
        }

        private void btnSerialOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.setIP_thisPort = (int)nudThisPort.Value;

            Properties.Settings.Default.setIP_AntennaIP = tboxAutoSteerIP.Text;
            Properties.Settings.Default.setIP_AntennaPort = (int)nudAutoSteerPort.Value;

            Properties.Settings.Default.setIP_gradeControlIP = tboxGradeControlIP.Text;
            Properties.Settings.Default.setIP_gradeControlPort = (int)nudGradeControlPort.Value;

            Properties.Settings.Default.Save();
            
            for(int i = 0; i < mf.SSID.Length; i++)
            {
                mf.SSID[i] = "-";
            }

            Close();
        }

        private void FormUDp_Load(object sender, EventArgs e)
        {
            string hostName = Dns.GetHostName(); // Retrieve the Name of HOST 
            tboxHostName.Text = hostName;

            IPAddress[] ipaddress = Dns.GetHostAddresses(hostName);
            tboxThisIP.Text = ipaddress[1].ToString();

            nudThisPort.Value = Properties.Settings.Default.setIP_thisPort;

            tboxAutoSteerIP.Text = Properties.Settings.Default.setIP_AntennaIP;
            nudAutoSteerPort.Value = Properties.Settings.Default.setIP_AntennaPort;

            tboxGradeControlIP.Text = Properties.Settings.Default.setIP_gradeControlIP;
            nudGradeControlPort.Value = Properties.Settings.Default.setIP_gradeControlPort;

            lblAntennaVersion.Text = Properties.Settings.Default.set_AntModVersion; 
            lblGCVersion.Text = Properties.Settings.Default.set_GcModVersion;

            
            lblProgramName.Text = Assembly.GetEntryAssembly().GetName().Name;
            lblOGXVersion.Text = Assembly.GetEntryAssembly().GetName().Version.ToString();

            choiceWiFi.Items.AddRange(mf.SSID);




            //for (int i = 0; i <= 9; i++)
            //{
            //    mf.SSID[i] = "Item" + i;
            //}

            //choiceWiFi.Items.AddRange(mf.SSID);
            //choicePassword.Items.AddRange(mf.SSID_PASS);



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
                if (strOctet.Length > 3 | strOctet.Length == 0) return false;

                //make sure all digits
                int temp2;
                if (!int.TryParse(strOctet, out temp2)) return false;

                //make sure not more then 255
                temp = int.Parse(strOctet);
                if (temp > MAXVALUE | temp < 0) return false;
            }
            return true;
        }

        private void tboxAutoSteerIP_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckIPValid(tboxAutoSteerIP.Text))
            {
                tboxAutoSteerIP.Text = Properties.Settings.Default.setIP_AntennaIP;
                tboxAutoSteerIP.Focus();
                mf.TimedMessageBox(3000, "Invalid IP Address", "Set to Default Local 127.0.0.1");
            }
        }

        private void tboxGradeControlIP_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckIPValid(tboxGradeControlIP.Text))
            {
                tboxGradeControlIP.Text = Properties.Settings.Default.setIP_gradeControlIP;
                tboxGradeControlIP.Focus();
                mf.TimedMessageBox(3000, "Invalid IP Address", "Set to Default Local 127.0.0.1");
            }
        }


        private void btnHotSpotConnect_Click(object sender, EventArgs e)
        {
            
            
            if (cbSavePassword.Checked)
            {
                mf.SSID_PASS[0] = choicePassword.Text;
                choicePassword.Items.Add(choicePassword.Text);
            }

            mf.ssidName = choiceWiFi.Text;
            mf.ssidPass = choicePassword.Text;

            mf.SendUDPMessage(FormGPS.WIFI_HEADER, mf.epAntennaModule, 2);

            mf.ssidName = "";
            mf.ssidPass = "";



        }

        private void button1_Click(object sender, EventArgs e)
        {

            mf.SendUDPMessage(FormGPS.WIFI_HEADER, mf.epAntennaModule, 1);

        }                

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mf.isWifidone)
            {
                choiceWiFi.Items.Clear();
                choiceWiFi.Text = mf.SSID[0]; 
                choiceWiFi.Items.AddRange(mf.SSID);
                
                mf.isWifidone = false;
                
            }
            

        }
    }
}
