using System;
using System.IO;
using System.Windows.Forms;

namespace OpenGrade
{
    public partial class FormRemote : Form
    {
        //class variables
        private readonly FormGPS mf = null;

        struct CodeToFunction_st
        {
            public string name;
            public string descript;
        };

        public string remoteChoice;

        enum RemoteButtons
        {
            aBtnFunc,
            bBtnFunc,
            xBtnFunc,
            yBtnFunc,
            upBtnFunc,
            downBtnFunc,
            leftBtnFunc,
            rightBtnFunc,
            startBtnFunc
        }

        enum RemoteFunctions
        {
            toggleAuto,
            toggleSurvey,
            toggleTabs,
            incBladeOff,
            decBladeOff,
            resetBladeOff,
            saveCut,
            openJob,
            openGPSData
        }

        //int functionsNums = Enum.GetNames(typeof(RemoteButtons)).Length;

        CodeToFunction_st[] m_functions = new CodeToFunction_st[Enum.GetNames(typeof(RemoteButtons)).Length];

        public int[] remoteFunctions = new int[9];

        public FormRemote(Form callingForm)
        {
            //get copy of the calling main form
            mf = callingForm as FormGPS;

            InitializeComponent();
        }

        private void FormRemote_Load(object sender, EventArgs e)
        {
            listA.Text = Properties.Remote.Default.aBtnFunc;
            listB.Text = Properties.Remote.Default.bBtnFunc;
            listX.Text = Properties.Remote.Default.xBtnFunc;
            listY.Text = Properties.Remote.Default.yBtnFunc;
            listUp.Text = Properties.Remote.Default.upBtnFunc;
            listDown.Text = Properties.Remote.Default.downBtnFunc;
            listLeft.Text = Properties.Remote.Default.leftBtnFunc;
            listRight.Text = Properties.Remote.Default.rightBtnFunc;
            listStart.Text = Properties.Remote.Default.startBtnFunc;
            listY.Text = Properties.Remote.Default.yBtnFunc;
            listY.Text = Properties.Remote.Default.yBtnFunc;

            //SetName((int)RemoteFunctions.toggleAuto, "Toggle Auto Cut", "Description");
            //SetName((int)RemoteFunctions.toggleSurvey, "Toggle Survey", "Description");
            //SetName((int)RemoteFunctions.toggleTabs, "Toggle Tabs", "Description");
            //SetName((int)RemoteFunctions.incBladeOff, "Increase Blade Offset", "Description");
            //SetName((int)RemoteFunctions.decBladeOff, "Decrease Blade Offset", "Description");
            //SetName((int)RemoteFunctions.resetBladeOff, "Reset Blade Offset", "Description");
            //SetName((int)RemoteFunctions.openGPSData, "Open GPS Data", "Description");
            //SetName((int)RemoteFunctions.openJob, "Open Job", "Description");
            //SetName((int)RemoteFunctions.saveCut, "Save Cut", "Description");
        }

        private void btnRemoteSaveSettings_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            //SaveRemoteConfig();
            Properties.Remote.Default.Save();
            Close();

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            return;

        }

        private void btnCancelChanges_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Close();
        }

        private void listA_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Remote.Default.aBtnFunc = listA.Text;
            Properties.Remote.Default.aBtn = CheckRemoteSettings(listA.Text);
            Properties.Remote.Default.Save();
        }

        private void listB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Remote.Default.bBtnFunc = listB.Text;
            Properties.Remote.Default.bBtn = CheckRemoteSettings(listB.Text);
            Properties.Remote.Default.Save();
        }

        private void listX_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Remote.Default.xBtnFunc = listX.Text;
            Properties.Remote.Default.xBtn = CheckRemoteSettings(listX.Text);
            Properties.Remote.Default.Save();
        }

        private void listY_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Remote.Default.yBtnFunc = listY.Text;
            Properties.Remote.Default.yBtn = CheckRemoteSettings(listY.Text);
            Properties.Remote.Default.Save();
        }

        private void listRight_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Remote.Default.rightBtnFunc = listRight.Text;
            Properties.Remote.Default.rightBtn = CheckRemoteSettings(listRight.Text);
            Properties.Remote.Default.Save();
        }

        private void listLeft_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Remote.Default.leftBtnFunc = listLeft.Text;
            Properties.Remote.Default.leftBtn = CheckRemoteSettings(listLeft.Text);
            Properties.Remote.Default.Save();
        }

        private void ListDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Remote.Default.downBtnFunc = listDown.Text;
            Properties.Remote.Default.downBtn = CheckRemoteSettings(listDown.Text);
            Properties.Remote.Default.Save();
        }

        private void listUp_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Remote.Default.upBtnFunc = listUp.Text;
            Properties.Remote.Default.upBtn = CheckRemoteSettings(listUp.Text);
            Properties.Remote.Default.Save();
        }

        private void listStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Remote.Default.startBtnFunc = listStart.Text;
            Properties.Remote.Default.startBtn = CheckRemoteSettings(listStart.Text);
            Properties.Remote.Default.Save();
        }



        // Procedures and Functions ---------------------------------------

        


        /*private void DoFunction(int func)      ///DoFunction(Properties.Remote.Default.startBtn, )
        {
            switch (func)
            {
                case (int)RemoteFunctions.toggleAuto:
                    mf.btnGradeControl.PerformClick();
                    break;

                case (int)RemoteFunctions.toggleSurvey:
                    mf.btnManualOffOn.PerformClick();
                    break;

                case (int)RemoteFunctions.toggleTabs:
                    int tab = mf.tabGradeControl.SelectedIndex;
                    tab++;
                    if (tab > 1) tab = 0;
                    mf.tabGradeControl.SelectTab(tab);
                    break;

                case (int)RemoteFunctions.incBladeOff:
                    mf.bladeOffset++;
                    if (mf.bladeOffset > 50) mf.bladeOffset = 50;
                    mf.lblBladeOffset.Text = mf.bladeOffset.ToString();
                    break;

                case (int)RemoteFunctions.decBladeOff:
                    mf.bladeOffset--;
                    if (mf.bladeOffset < -50) mf.bladeOffset = -50;
                    mf.lblBladeOffset.Text = mf.bladeOffset.ToString();
                    break;

                case (int)RemoteFunctions.resetBladeOff:
                    mf.bladeOffset = 0;
                    mf.lblBladeOffset.Text = mf.bladeOffset.ToString();
                    break;

                case (int)RemoteFunctions.saveCut:
                    mf.btnSaveCut.PerformClick();
                    break;

                case (int)RemoteFunctions.openJob:
                    mf.JobNewOpenResume();
                    break;

                case (int)RemoteFunctions.openGPSData:
                    Form form = new FormGPSData(mf);
                    form.Show();
                    break;

                default:
                    break;
            }

        }

        private string GetName(int func)
        {
            if (Enum.GetNames(typeof(RemoteButtons)).Length > 0) return (m_functions[func].name);
            else return ("");
        }

        private string GetDescription(int func)
        {
            if (Enum.GetNames(typeof(RemoteButtons)).Length > 0) return (m_functions[func].descript);
            else return ("");
        }

        private void SetName(int index, string name, string description)
        {
            (m_functions[index].descript) = description;
            (m_functions[index].name) = name;
        }

        private void OnChoiceSelected(string choice, int Btn)
        {

            switch (Btn)
            {
                case (int)RemoteButtons.aBtnFunc:


                    break;

                case (int)RemoteButtons.bBtnFunc:



                    break;
                case (int)RemoteButtons.xBtnFunc:



                    break;
                case (int)RemoteButtons.yBtnFunc:



                    break;
                case (int)RemoteButtons.startBtnFunc:



                    break;
                case (int)RemoteButtons.upBtnFunc:


                    break;
                case (int)RemoteButtons.downBtnFunc:



                    break;
                case (int)RemoteButtons.leftBtnFunc:



                    break;
                case (int)RemoteButtons.rightBtnFunc:



                    break;

            }

            for (int i = 0; i < Enum.GetNames(typeof(RemoteButtons)).Length - 1; i++)
            {
                if (choice == m_functions[i].name)
                {
                    Properties.Remote.Default.aBtnFunc = choice;
                    break;
                }

            }

        }

        private void doSomething( )
        {            
            for (int i = 0; i < m_functions.Length - 1; i++)
            {
                if (remoteChoice == m_functions[i].name)
                {
                    Properties.Remote.Default.aBtnFunc = remoteChoice;

                    break;
                }
            }
        }


        private void SaveRemoteConfig()
        {

        }
        */
        private int CheckRemoteSettings(string name)
        {
            if (name == "Toggle Auto Cut")
            {
                return (int)RemoteFunctions.toggleAuto;
            }
            else if (name == "Toggle Survey")
            {
                return (int)RemoteFunctions.toggleSurvey;
            }
            else if(name == "Toggle Tabs")
            {
                return (int)RemoteFunctions.toggleTabs;
            }
            else if(name == "Increase Blade Offset")
            {
                return (int)RemoteFunctions.incBladeOff;
            }
            else if(name == "Decrease Blade Offset")
            {
                return (int)RemoteFunctions.decBladeOff;
            }
            else if(name == "Reset Blade Offset")
            {
                return (int)RemoteFunctions.resetBladeOff;
            }
            else if (name == "Open Gps Data")
            {
                return (int)RemoteFunctions.openGPSData;
            }
            else if (name == "Open Job")
            {
                return (int)RemoteFunctions.openJob;
            }
            else if (name == "Save Cut")
            {
                return  (int)RemoteFunctions.saveCut;
            }
            else
            {
                return 9999;  
            }
        }





    }



    

}
