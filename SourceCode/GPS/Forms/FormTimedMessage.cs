﻿using System;
using System.Windows.Forms;

namespace OpenGrade
{
    public partial class FormTimedMessage : Form
    {
        //class variables
        //private FormGPS mf = null;

        public FormTimedMessage(int timeInMsec, string str, string str2)
        {
            InitializeComponent();

            //get copy of the calling main form
            //mf = callingForm as FormGPS;

            lblMessage.Text = str;
            lblMessage2.Text = str2;

            timer1.Interval = timeInMsec;

            int messWidth = str2.Length;
            Width = messWidth * 15 + 75;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
