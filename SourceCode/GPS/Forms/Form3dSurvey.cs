using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static OpenGrade.FormGPS;

namespace OpenGrade
{
    public partial class Form3dSurvey : Form
    {       
        //access to the main GPS form and all its variables
        private readonly FormGPS mf = null;
            


         public Form3dSurvey(Form callingForm)
        {
            InitializeComponent();
            //access to the main GPS form and all its variables
            //get copy of the calling main form
            mf = callingForm as FormGPS;
            if (mf.ct.isBoundarySideRight)
            {
                btnBoundarySide.Image = Properties.Resources.BoundaryRight;
            }
            else
            {
                btnBoundarySide.Image = Properties.Resources.BoundaryLeft;
            }

        }

        private void linkLabelGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void linkLabelCombineForum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void Form_About_Load(object sender, EventArgs e)
        {
            // Add a link to the LinkLabel.
            LinkLabel.Link link = new LinkLabel.Link { LinkData = "https://github.com/farmerbriantee/OpenGrade" };
            //linkLabelGit.Links.Add(link);

            // Add a link to the LinkLabel.
            LinkLabel.Link linkCf = new LinkLabel.Link
            {
                LinkData = "http://www.thecombineforum.com/forums/31-technology/278810-OpenGrade.html"
            };
            //linkLabelCombineForum.Links.Add(linkCf);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnStartDraw_Click(object sender, EventArgs e)
        {

        }

        private void btnDoneDraw_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteLastPoint_Click(object sender, EventArgs e)
        {

        }

        private void btnAutoDrain_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (mf.manualBtnState)
            {
                case btnStates.Off:
                    mf.manualBtnState = btnStates.Stdby;
                    button2.Image = null;
                    button2.Text = "BENCHMARK";
                    mf.userDistance = 0;
                    //btnStartPause.Visible = true;


                    //cboxLastPass.Checked = false;
                    //cboxRecLastOnOff.Checked = false;
                    //cboxLaserModeOnOff.Checked = false;
                    //btnDoneDraw.Enabled = false;
                    //btnDeleteLastPoint.Enabled = false;
                    //btnStartDraw.Enabled = false;
                    mf.ct.isSurveyOn = true;
                    mf.ct.clearSurveyList = true;
                    mf.ct.isBtnStartPause = false;
                    
                    
                    //btnStartPause.Text = "START";
                    btnStartPause.BackgroundImage = Properties.Resources.BoundaryRecord;
                    break;

                case btnStates.Stdby:
                    mf.manualBtnState = btnStates.RecBnd;
                    button2.Image = null;
                    button2.Text = "BOUNDARY";
                    mf.userDistance = 0;
                    btnStartPause.Visible = true;
                    btnBoundarySide.Visible = true;
                    mf.ct.isBtnStartPause = false;
                    //btnStartPause.Text = "START";
                    btnStartPause.BackgroundImage = Properties.Resources.BoundaryRecord;


                    // cboxLastPass.Checked = false;
                    //cboxRecLastOnOff.Checked = false;
                    //cboxLaserModeOnOff.Checked = false;
                    //btnDoneDraw.Enabled = false;button2
                    //btnDeleteLastPoint.Enabled = false;
                    //btnStartDraw.Enabled = false;
                    mf.ct.isSurveyOn = true;
                    mf.ct.markBM = true;



                    break;

                case btnStates.RecBnd:
                    mf.manualBtnState = btnStates.Rec;
                    //button2.Image = Properties.Resources.BoundaryRecord;
                    button2.Text = "SURVEY";
                    mf.userDistance = 0;
                    btnBoundarySide.Visible = false;
                    mf.ct.isBtnStartPause = false;
                    //btnStartPause.Text = "START";
                    btnStartPause.BackgroundImage = Properties.Resources.BoundaryRecord;

                    //cboxLastPass.Checked = false;
                    //cboxRecLastOnOff.Checked = false;
                    //cboxLaserModeOnOff.Checked = false;
                    //btnDoneDraw.Enabled = false;
                    //btnDeleteLastPoint.Enabled = false;
                    //btnStartDraw.Enabled = false;
                    mf.ct.isSurveyOn = true;
                    mf.ct.recBoundary = false;
                    mf.ct.recSurveyPt = true;


                    break;

                case btnStates.Rec:
                    mf.manualBtnState = btnStates.Off;
                    button2.Text = "COMPLETE";

                    btnManualOffOn.Text = null;
                    //CalculateContourPointDistances();
                    //FileSaveContour();
                    //btnDoneDraw.Enabled = false;
                    //btnDeleteLastPoint.Enabled = false;
                    //btnStartDraw.Enabled = true;
                    mf.ct.isSurveyOn = false;
                    btnStartPause.Visible = false;

                    DialogResult = DialogResult.OK;
                    Close();



                    break;
            }
        }

        private void btnStartPause_Click(object sender, EventArgs e)
        {
            if (mf.ct.isBtnStartPause)
            {
                //btnStartPause.Text = "START";
                btnStartPause.BackgroundImage = Properties.Resources.BoundaryRecord;
                btnAddPoint.Enabled = true;
                btnPointDelete.Enabled = true;

                mf.ct.isBtnStartPause = false;
            }
            else
            {
                //btnStartPause.Text = "PAUSE";

               

                btnAddPoint.Enabled = false;
                btnPointDelete.Enabled = false;
                btnStartPause.BackgroundImage = Properties.Resources.boundaryPause;

                mf.ct.isBtnStartPause = true;
            }
        }

        private void btnBoundarySide_Click(object sender, EventArgs e)
        {
            if (mf.ct.isBoundarySideRight)
            {


                btnBoundarySide.Image = Properties.Resources.BoundaryLeft;
                //btnBoundarySide.Text = "Boundary Left";
                mf.ct.isBoundarySideRight = false;
            }
            else
            {
                //btnBoundarySide.Text = "Boundary Right";
                btnBoundarySide.Image = Properties.Resources.BoundaryRight;
                mf.ct.isBoundarySideRight = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            mf.SelectMode();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnFixQuality_Click(object sender, EventArgs e)
        {

        }

        private void btnPointDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
