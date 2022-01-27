﻿//Please, if you use this give me some credit
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
            //all the fixings and position
            lblZone.Text = mf.Zone;
            lblNorthing.Text = mf.FixNorthing;
            lblEasting.Text = mf.FixEasting;
            lblLatitude.Text = mf.Latitude;
            lblLongitude.Text = mf.Longitude;
            lblAltitude.Text = mf.Altitude;

            //other sat and GPS info
            lblFixQuality.Text = mf.FixQuality;
            lblSatsTracked.Text = mf.SatsTracked;
            lblStatus.Text = mf.Status;
            lblHDOP.Text = mf.HDOP;            

            tboxSerialFromGradeControl.Text = mf.mc.serialRecvGradeControlStr;
            txtBoxSendGradeControl.Text = "32762 " + mf.mc.GradeControlData[mf.mc.gcHeaderHi]+"-" + mf.mc.GradeControlData[mf.mc.gcHeaderLo] + "," + mf.mc.GradeControlData[mf.mc.gcDeltaDir] + ", " + mf.mc.GradeControlData[mf.mc.gcCutDelta] + ", " + mf.mc.GradeControlData[mf.mc.gcisAutoActive];  

            tboxNMEASerial.Text = mf.recvSentenceSettings;
            //tboxNMEASerial.Text = mf.pn.rawBuffer;

            tboxSerialFromAutoSteer.Text = mf.mc.serialRecvAutoSteerStr;
            tboxSerialToAutoSteer.Text = "32766, " + mf.mc.autoSteerData[mf.mc.sdRelay] + ", " + mf.mc.autoSteerData[mf.mc.sdSpeed]
                                    + ", " + mf.guidanceLineDistanceOff + ", " + mf.guidanceLineSteerAngle;
             


        }

        private void tboxSerialToGradeControl_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
