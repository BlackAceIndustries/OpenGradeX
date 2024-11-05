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

            double temp = 0;

            if (mf.mc.gcData.setPointA < 2048)
            {
                temp = (2048-(4096 - mf.mc.gcData.setPointA))/16;
            }
            if (mf.mc.gcData.setPointA > 2048)
            {
                temp = (mf.mc.gcData.setPointA - 2048)/16;

            }


            label5.Text = (mf.mc.gcData.setPointA).ToString("F2");
            label6.Text = temp.ToString("F2");
            label1.Text = (mf.mc.gcData.deltaA).ToString("F2");
            


        }
        private void timer2_Tick(object sender, EventArgs e)
        {
           

            if (mf.isManualOverride)
            {
                mf.mc.gcData.deltaA = (int)((mf.mc.pitchSlope - manTargetPitch) * 10.0);
            }


        }

        private void btnValveAUp_MouseDown(object sender, MouseEventArgs e)
        {
            mf.mc.gcData.deltaA = -100;
            btnValveAUp.BackColor = Color.Lime;
        }

        private void btnValveAUp_MouseUp(object sender, MouseEventArgs e)
        {
            mf.mc.gcData.deltaA = 0;
            btnValveAUp.BackColor = Color.DimGray;



        }
        private void btnValveADown_MouseDown(object sender, MouseEventArgs e)
        {  
            mf.mc.gcData.deltaA = 100;
            btnValveADown.BackColor = Color.Lime;

        }

        private void btnValveADown_MouseUp(object sender, MouseEventArgs e)
        {
            mf.mc.gcData.deltaA = 0;
            btnValveADown.BackColor = Color.DimGray;

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
            manTargetPitch -= .1;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (!mf.isManualOverride)// && 
            {
                mf.isManualOverride = true;                
                mf.mc.gcData.autoVert = true;               
                button1.BackColor = Color.LimeGreen;
                button1.Text = "ENABLED";
                btnValveADown.Enabled = true;
                btnValveAUp.Enabled = true;
                mf.mc.gcData.deltaA = 0;
            }
            else
            {
                mf.isManualOverride = false;
                mf.mc.gcData.autoVert = false;
                button1.Text = "DISABLED";
                button1.BackColor = Color.IndianRed;
                btnValveADown.Enabled = false;
                btnValveAUp.Enabled = false;

                if (mf.isAutoVert)
                {
                    mf.mc.gcData.autoVert = true;
                    mf.mc.gcData.deltaA = 0;

                }


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
            manTargetPitch += .1;
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

        private void button2_Click(object sender, EventArgs e)
        {
            mf.mc.gcData.deltaA += 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mf.mc.gcData.deltaA -= 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mf.SettingsPageOpen(0);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
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
            mf.isManualOverride = false;


        }
    }

}
