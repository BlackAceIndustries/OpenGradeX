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
    public partial class Form2dSurvey : Form
    {

        //access to the main GPS form and all its variables
        private readonly FormGPS mf = null;
                
        public Form2dSurvey(Form callingForm)
        {
            mf = callingForm as FormGPS;
            InitializeComponent();
            
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
            

            // Add a link to the LinkLabel.
            LinkLabel.Link linkCf = new LinkLabel.Link
            {
                LinkData = "http://www.thecombineforum.com/forums/31-technology/278810-OpenGrade.html"
            };
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

        private void button2_Click(object sender, EventArgs e)
        {
            switch (mf.manualBtnState)
            {

                case FormGPS.btnStates.Off:
                    {



                        var form = new FormSurveyStart(mf, 2000, "", "");
                        form.Show();

                        if (mf.ct.ptList.Count > 0 && !mf.isCutSaved)// && mf.btnSaveCut.Enabled == true
                        {
                            DialogResult result3 = MessageBox.Show("Do you wish to start a new survey Line? \nThis will erase Your current cut if it has not been saved \n \n Do you wish to Continue?", "Do you wish to start a new survey Line?",
                                                 MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                            if (result3 == DialogResult.Yes)
                            {

                                button2.Image = Properties.Resources.SurveyStop1;
                               mf.userDistance = 0;
                               //mf.lblCut.Text = "*";
                               //mf.lblFill.Text = "*";
                               //mf.lblCutFillRatio.Text = "*";
                               // mf.lblDrawSlope.Text = "*";

                                btnDoneDraw.Enabled = false;
                                btnDeleteLastPoint.Enabled = false;
                                btnStartDraw.Enabled = false;

                            }
                        }



                        else
                        {

                            button2.Image = Properties.Resources.SurveyStop1;
                            mf.userDistance = 0;
                            //mf.lblCut.Text = "*";
                            //mf.lblFill.Text = "*";
                            //mf.lblCutFillRatio.Text = "*";
                            //mf.lblDrawSlope.Text = "*";

                            btnDoneDraw.Enabled = false;
                            btnDeleteLastPoint.Enabled = false;
                            btnStartDraw.Enabled = false;

                        }

                        break;
                    }



                case FormGPS.btnStates.Rec:
                    {
                        mf.manualBtnState = FormGPS.btnStates.Off;
                        button2.Image = Properties.Resources.SurveyStart;
                        mf.CalculateContourPointDistances();                    
                        mf.FileSaveContour();
                        btnDoneDraw.Enabled = false;
                        btnDeleteLastPoint.Enabled = false;
                        btnStartDraw.Enabled = true;

                        //mf.btnSaveCut.Enabled = true;
                        mf.isCutSaved = false;

                        break;

                    }

                case FormGPS.btnStates.Stdby:
                    mf.manualBtnState = FormGPS.btnStates.RecBnd;
                    button2.Image = null;
                    button2.Text = "Recording Boundary";
                    mf.userDistance = 0;
                    //btnStartPause.Visible = true;
                    // btnBoundarySide.Visible = true;
                    mf.ct.isBtnStartPause = false;
                    //btnStartPause.Text = "START";


                    //cboxLastPass.Checked = false;
                    //cboxRecLastOnOff.Checked = false;
                    //cboxLaserModeOnOff.Checked = false;
                    //btnDoneDraw.Enabled = false;
                    //btnDeleteLastPoint.Enabled = false;
                    //btnStartDraw.Enabled = false;
                    mf.ct.isSurveyOn = true;
                    mf.ct.markBM = true;



                    break;

                case FormGPS.btnStates.RecBnd:
                    mf.manualBtnState = FormGPS.btnStates.Rec;
                    button2.Image = Properties.Resources.ManualOn;
                    button2.Text = null;
                    mf.userDistance = 0;
                    // btnBoundarySide.Visible = false;
                    mf.ct.isBtnStartPause = false;
                    //btnStartPause.Text = "START";

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

            }
        }

        private void btnSerialCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnStartDraw_Click(object sender, EventArgs e)
        {
            if (mf.ct.ptList.Count > 5)
            {
                btnAutoDrain.Enabled = true;
                mf.ct.drawList.Clear();
                mf.ct.isDrawingRefLine = true;
                //lblCut.Text = "-";
                //lblFill.Text = "-";
                //lblCutFillRatio.Text = "-";

                btnDoneDraw.Enabled = true;
                btnDeleteLastPoint.Enabled = true;
                btnStartDraw.Enabled = false;
            }
            else mf.TimedMessageBox(1500, "No Surveyed Points", "Survey a Contour First");
        }

        private void btnDoneDraw_Click(object sender, EventArgs e)
        {
            //btnSaveCut.Enabled = true;
            btnAutoDrain.Enabled = false;
            btnDoneDraw.Enabled = false;
            btnDeleteLastPoint.Enabled = false;
            btnStartDraw.Enabled = true;

            mf.ct.isDrawingRefLine = false;
            int cnt = mf.ct.ptList.Count;
            int drawPts = mf.ct.drawList.Count - 1;
            double slope = 0.5;

            if (drawPts > 0)
            {
                for (int i = 0; i < cnt; i++)
                {
                    //points before the drawn line are -1
                    if (i < mf.ct.drawList[0].easting)
                    {
                        mf.ct.ptList[i].cutAltitude = -1;
                        continue;
                    }

                    //points after drawn line are -1
                    if (i > mf.ct.drawList[drawPts].easting)
                    {
                        mf.ct.ptList[i].cutAltitude = -1;
                        continue;
                    }

                    //find out where its between
                    for (int j = 0; j < drawPts; j++)
                    {
                        if (i >= mf.ct.drawList[j].easting && i <= mf.ct.drawList[j + 1].easting)
                        {
                            slope = (mf.ct.drawList[j + 1].northing - mf.ct.drawList[j].northing) / (mf.ct.drawList[j + 1].easting - mf.ct.drawList[j].easting);
                            mf.ct.ptList[i].cutAltitude = ((i - mf.ct.drawList[j].easting) * slope) + mf.ct.drawList[j].northing;
                            break;
                        }
                    }
                }

                //Fill in cut and fill
                //mf.CalculateTotalCutFillLabels();
            }
            //mf.isCutSaved = true;
            //mf.ct.SaveToCut();
            //this.Close();

            //CheckMaxCut();
        }

        private void btnDeleteLastPoint_Click(object sender, EventArgs e)
        {
            int ptCnt = mf.ct.drawList.Count;
            if (ptCnt > 0) mf.ct.drawList.RemoveAt(ptCnt - 1);
        }

        private void btnAutoDrain_Click(object sender, EventArgs e)
        {
            mf.ct.AutoDrain();
        }

        private void vrbSave_Click(object sender, EventArgs e)
        {
            mf.isCutSaved = true;
            mf.ct.SaveToCut();
        }
    }
}
