using System;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;
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

            lblAntennaVersion.Text = mf.mc.atFirmware;
            lblGCVersion.Text = mf.mc.gcFirmware;
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void choiceWiFi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
