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
    public partial class FormAltSet : Form
    {
        private readonly FormGPS mf = null;

        public FormAltSet(Form callingForm)
        {
            mf = callingForm as FormGPS;
            InitializeComponent();
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
            double temp1, temp2, temp3, temp4;

            temp1 = (mf.pn.altitude - user1) * 100;
            temp2 = (mf.pn.altitude - user2) * 100;
            temp3 = (mf.pn.altitude - user3) * 100;
            temp4 = (mf.pn.altitude - user4) * 100;

            if (mf.isMetric)
            {
                lblUserOne.Text = temp1.ToString("N1");
                lblUserTwo.Text = temp2.ToString("N1");
                lblUserThree.Text = temp3.ToString("N1");
                lblUserFour.Text = temp4.ToString("N1");

            }
            else
            {
                temp1 /= 2.54;
                temp2 /= 2.54;
                temp3 /= 2.54;
                temp4 /= 2.54;
                lblUserOne.Text = temp1.ToString("N1");
                lblUserTwo.Text = temp2.ToString("N1");
                lblUserThree.Text = temp3.ToString("N1");
                lblUserFour.Text = temp4.ToString("N1");



            }

            if (temp1 < 0) lblUserOne.BackColor = Color.Tomato;
            else lblUserOne.BackColor = Color.Lime;

            if (temp2 < 0) lblUserTwo.BackColor = Color.Tomato;
            else lblUserTwo.BackColor = Color.Lime;

            if (temp3 < 0) lblUserThree.BackColor = Color.Tomato;
            else lblUserThree.BackColor = Color.Lime;

            if (temp4 < 0) lblUserFour.BackColor = Color.Tomato;
            else lblUserFour.BackColor = Color.Lime;

        }

        private void lblUserOne_Click(object sender, EventArgs e)
        {
            user1 = mf.pn.altitude;
            Properties.Settings.Default.setUser1_Alt = user1; 
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
            mf.toolStripMenuItem1.Checked = false;

        }
    }

}
