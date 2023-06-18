using System;
using System.Windows.Forms;

namespace OpenGrade
{
    public partial class FormSurveyStart : Form
    {
        //class variables
        private FormGPS mf = null;

        private int curStep = 1;
        private double startHt = 0;
        private double surveyHt = 0; 

        //public decimal ReturnValue1 { get; set; }



        public FormSurveyStart(Form callingForm, int timeInMsec, string str, string str2)
        {
            InitializeComponent();

            //get copy of the calling main form
            mf = callingForm as FormGPS;


            timer1.Interval = timeInMsec;

            //int messWidth = str2.Length;
            //Width = messWidth * 15 + 75;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            switch (curStep){
                
                
                case 1: {
                        startHt = mf.pn.altitude;
                        lblStepCnt.Text = "STEP 2";
                        btnNext.Text = "NEXT";
                        lblMessage.Text = "Raise implement to survey height";
                        curStep = 2;
                        timer2.Enabled = true;
                    break;
                }
                case 2:
                {

                        timer1.Enabled = true;                         
                        lblStepCnt.Text = "STEP 3";
                        btnNext.Text = "CLOSE";
                        btnNext.Visible = false;
                        lblMessage.Text = "Begin Surveying";
                        mf.ct.surveyHeight = (mf.pn.altitude - startHt);
                        mf.manualBtnState = FormGPS.btnStates.Rec;
                        curStep = 3;
                    break;
                }

                case 3:
                {
                        Close();
                        lblStepCnt.Text = "STEP 4";
                        curStep = 4;
                        break;
                }

                default:
                    break; 
            }

                





            }

        private void timer2_Tick(object sender, EventArgs e)
        {

            surveyHt = ((mf.pn.altitude - startHt) * 100);
            lblSurveyHeight.Text = surveyHt.ToString("N2"); 
            

        }
    }
    
}
