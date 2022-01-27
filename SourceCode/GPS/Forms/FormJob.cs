using System;
using System.IO;
using System.Windows.Forms;

namespace OpenGrade
{
    public partial class FormJob : Form
    {
        //class variables
        private readonly FormGPS mf = null;
       

        public FormJob(Form callingForm)
        {
            //get copy of the calling main form
            mf = callingForm as FormGPS;

            InitializeComponent();
        }

        private void btnJobOpen_Click(object sender, EventArgs e)
        {
            mf.FileOpenField("Open");

            //determine if field was actually opened
            if (mf.isJobStarted)

            {
                //back to FormGPS
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                //back to FormGPS
                DialogResult = DialogResult.Cancel;
                mf.JobClose();
                Close();
            }
        }

        private void btnJobNew_Click(object sender, EventArgs e)
        {
            //start a new job
            mf.JobNew();
                        
            //back to FormGPS
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void btnJobResume_Click(object sender, EventArgs e)
        {
            //open the Resume.txt and continue from last exit            
            
            mf.FileOpenField("Resume");

            //back to FormGPS
            DialogResult = DialogResult.OK;
            
            
            Close();
        }

        private void FormJob_Load(object sender, EventArgs e)
        {
            //check if directory and file exists, maybe was deleted etc            
            string directoryName = mf.fieldsDirectory + mf.currentFieldDirectory + "\\";
            

            if (mf.isJobStarted)
            {
                btnJobOpen.Enabled = false;
                btnJobNew.Enabled = false;
                btnJobResume.Enabled = false;
                btnJobCloseField.Enabled = true;
                btnJobCutOpen.Enabled = true;
            }
            else
            {
                btnJobOpen.Enabled = true;
                btnJobNew.Enabled = true;
                if (String.IsNullOrEmpty(mf.currentFieldDirectory)) btnJobResume.Enabled = false;
                else btnJobResume.Enabled = true;                
                btnJobCloseField.Enabled = false;
                btnJobCutOpen.Enabled = false;
            }

            string fileAndDirectory = directoryName + "Field.txt";

            if (!File.Exists(fileAndDirectory))
            {

                lblResumeDirectory.Text = "";                
                mf.currentFieldDirectory = "";
                Properties.Settings.Default.setF_CurrentDir = "";
                Properties.Settings.Default.Save();
            }
            else lblResumeDirectory.Text = mf.currentFieldDirectory;
        }


        

        private void btnCutOpen_Click(object sender, EventArgs e)
        {
            mf.FileLoadCut("Open");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            int choice = mf.SaveOrNot();
            switch (choice)
            {
                //OK
                case 0:
                    Properties.Settings.Default.setF_CurrentDir = mf.currentFieldDirectory;
                    //Text = "OpenGrade - Press Start To Begin";
                    Properties.Settings.Default.Save();
                    mf.FileSaveEverythingBeforeClosingField();
                    break;
                //Ignore and return
                case 1:
                    break;
            }
        }

        private void btnDeleteAB_Click(object sender, EventArgs e)
        {

        }
    }
}
