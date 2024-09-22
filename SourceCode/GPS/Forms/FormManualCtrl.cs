using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OpenGrade
{
    public partial class FormManualCtrl : Form
    {
            
        double manTargetPitch = 0.0;  
        private readonly FormGPS mf = null;

        public FormManualCtrl(Form callingForm)
        {
            mf = callingForm as FormGPS;
            InitializeComponent();

            mf.mc.gcData.deltaA = 0;
            


            if (mf.isLevelOn)
            {
                mf.ToggleLaserMode();
            }
        }

        private double user1 = 0.0, user2 = 0.0, user3 = 0.0, user4 = 0.0;

        private void lblUserTwo_Click(object sender, EventArgs e)
        {
            user2 = mf.pn.altitude;
            Properties.Settings.Default.setUser2_Alt = user2;

        }

        private void lblUserThree_Click(object sender, EventArgs e)
        {
            user3 = mf.pn.altitude;
            Properties.Settings.Default.setUser3_Alt = user3;
        }

        private void lblUserFour_Click(object sender, EventArgs e)
        {
            user4 = mf.pn.altitude;
            Properties.Settings.Default.setUser4_Alt = user4;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(306, 165); 

        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(592, 165);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(306, 291);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(592, 291);
        }



        //306, 165

        //592, 291
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblTargetPitch.Text = manTargetPitch.ToString("F2");


        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            //mf.mc.gcData.deltaA = (int)(mf.mc.pitchSlope - manTargetPitch);

            mf.mc.gcData.deltaA = (int)((mf.mc.pitchSlope - manTargetPitch) * 100.0);
        } 

        private void btnValveAUp_MouseDown(object sender, MouseEventArgs e)
        {
            mf.mc.gcData.deltaA = 1000;
            //timer1.Start();
            
            //mf.cutDeltaCenter = 255;
        }

        private void btnValveAUp_MouseUp(object sender, MouseEventArgs e)
        {
            mf.mc.gcData.deltaA = 0;
            //timer1.Stop();
            
        }
        private void btnValveADown_MouseDown(object sender, MouseEventArgs e)
        {  
            mf.mc.gcData.deltaA = -1000;         
            //timer2.Start();
            
        }

        private void btnValveADown_MouseUp(object sender, MouseEventArgs e)
        {
            mf.mc.gcData.deltaA = 0;
            //timer2.Stop();

        }

        private void btnValveADown_Click(object sender, EventArgs e)
        {
            //mf.cutDeltaCenter = -255;
            
        }

        private void btnValveBUp_Click(object sender, EventArgs e)
        {
            //mf.cutDeltaCenter = 255;
        }

      



        private void btnValveBDown_Click(object sender, EventArgs e)
        {
            manTargetPitch -= .01;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OpenGrade.Properties.Resources.OK64
            if (mf.mc.gcData.autoVert)
            {
                mf.mc.gcData.autoVert = false;
                button1.Image = OpenGrade.Properties.Resources.Cancel64;
                //timer1.Enabled = false;
                //timer2.Enabled = false;
                btnValveADown.Enabled = false;
                btnValveAUp.Enabled = false;
            }
            else
            {
                mf.mc.gcData.autoVert = true;
                button1.Image = OpenGrade.Properties.Resources.OK64;
                //timer1.Enabled = true;
                //timer2.Enabled = true;
                btnValveADown.Enabled = true;
                btnValveAUp.Enabled = true;
                //timer1.Stop();
                //timer2.Stop();

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {

           lblCurrentPitch.Text = mf.mc.pitchSlope.ToString("F2");

        }

        private void btnValveAUp_Click(object sender, EventArgs e)
        {

        }

        private void btnValveADown_Click_1(object sender, EventArgs e)
        {

        }

        private void btnValveBUp_Click_1(object sender, EventArgs e)
        {
            manTargetPitch += .01;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                timer2.Enabled = true;
                mf.mc.gcData.deltaA = (int)((mf.mc.pitchSlope - manTargetPitch)*10.0);
            }
            else
            {
                timer2.Enabled = false;
                mf.mc.gcData.deltaA = 0;
            }
            
            
        }

        private void lblUserOne_Click(object sender, EventArgs e)
        {
            
        }


        private void FormAltSet_Load(object sender, EventArgs e)
        {
           

            user1 = Properties.Settings.Default.setUser1_Alt;
            user2 = Properties.Settings.Default.setUser2_Alt;
            user3 = Properties.Settings.Default.setUser3_Alt;
            user4 = Properties.Settings.Default.setUser4_Alt;

        }

        private void FormAltSet_FormClosing(object sender, EventArgs e)
        {
            mf.mc.gcData.autoVert = false;
            mf.mc.gcData.deltaA = 0;


        }
    }

}
