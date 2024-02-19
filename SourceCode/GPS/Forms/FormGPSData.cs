//Please, if you use this give me some credit
//Copyright BrianTee, copy right out of it.

using System;
using System.Windows.Forms;

namespace OpenGrade
{
    public partial class FormGPSData : Form
    {
        private readonly FormGPS mf = null;

        //public decimal ReturnValue1 { get; set; }

        public FormGPSData(Form callingForm)
        {
            mf = callingForm as FormGPS;
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ////all the fixings and position
            //lblZone.Text = mf.Zone;
            //lblNorthing.Text = mf.pn.FixNorthing;
            //lblEasting.Text = mf.FixEasting;
            //lblLatitude.Text = mf.Latitude;
            //lblLongitude.Text = mf.Longitude;
            //lblAltitude.Text = mf.Altitude;



            ////other sat and GPS info
            //lblFixQuality.Text = mf.FixQuality;
            //lblSatsTracked.Text = mf.SatsTracked;
            //lblStatus.Text = mf.Status;
            //lblHDOP.Text = mf.HDOP;


            lblStatus.Text = mf.Heading.ToString();

            lblZone.Text = mf.Zone;
            lblNorthing.Text = mf.pn.northing.ToString();
            lblEasting.Text = mf.pn.easting.ToString();
            lblLatitude.Text = mf.pn.latitude.ToString();
            lblLongitude.Text = mf.pn.longitude.ToString();
            lblAltitude.Text = mf.pn.altitude.ToString();
            lblSpeed.Text = mf.pn.speed.ToString();


            lblPitch.Text = mf.mc.pitchIMU.ToString();
            lblRoll.Text = mf.mc.rollIMU.ToString();
            lblGyro.Text = mf.mc.headingIMU.ToString();



            //other sat and GPS info


            lblFixQuality.Text = mf.FixQuality;
            //lblFixQuality.Text = mf.pn.fixQuality.ToString();
            lblSatsTracked.Text = mf.pn.satellitesTracked.ToString();
            //lblStatus.Text = mf.pn.status.ToString();
            lblHDOP.Text = mf.pn.hdop.ToString();
            tboxNMEASerial.Text = mf.pn.rawBuffer.ToString();

            //tboxSerialToAutoSteer.Text = mf.mc.Antenna
            txtBoxSendGradeControl.Text =  mf.mc.GradeControlData.ToString();








        }

        private void tboxNMEASerial_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxSendGradeControl_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click_1(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }
    }
}
