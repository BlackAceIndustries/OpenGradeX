using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;

namespace OpenGrade
{
    public class CRemote
    {
        private readonly FormGPS mf;

        public int aBtn;
        public int bBtn;
        public int xBtn;
        public int yBtn;
        public int upBtn;
        public int downBtn;
        public int leftBtn;
        public int rightBtn;
        public int startBtn;

       /* CodeToFunction_st[] m_functions = new CodeToFunction_st[Enum.GetNames(typeof(RemoteButtons)).Length];

        struct CodeToFunction_st
        {
            public string name;
            public string descript;
        };
       */

        public string remoteChoice;

        enum RemoteButtons
        {
            aBtn,
            bBtn,
            xBtn,
            yBtn,
            upBtn,
            downBtn,
            leftBtn,
            rightBtn,
            startBtn
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

        /// Variables  ///
        /// 


        public CRemote(FormGPS _f)
        {
            mf = _f;
            //Contructor
            
            aBtn = Properties.Remote.Default.aBtn;
            bBtn = Properties.Remote.Default.bBtn;
            xBtn = Properties.Remote.Default.xBtn;
            yBtn = Properties.Remote.Default.yBtn;
            upBtn = Properties.Remote.Default.upBtn;
            downBtn = Properties.Remote.Default.downBtn;
            leftBtn = Properties.Remote.Default.leftBtn;
            rightBtn = Properties.Remote.Default.rightBtn;
            startBtn = Properties.Remote.Default.startBtn;

        }

        //
        //Class Functions
        //
    
        /*private void FormRemote_Load(object sender, EventArgs e)
        //{
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
        //}
        */

        public void DoFunction(int func)      
        {
            switch (func)
            {
                case (int)RemoteFunctions.toggleAuto:
                    ToggleAutoCut();
                    break;

                case (int)RemoteFunctions.toggleSurvey:
                    ToggleSurvey();
                    break;

                case (int)RemoteFunctions.toggleTabs:
                    ToggleTabs();
                    break;

                case (int)RemoteFunctions.incBladeOff:
                    IncreaseBladeOffset();
                    break;

                case (int)RemoteFunctions.decBladeOff:
                    DecreaseBladeOffset();
                    break;

                case (int)RemoteFunctions.resetBladeOff:
                    ResetBladeOffset();
                    break;

                case (int)RemoteFunctions.saveCut:
                    SaveCut();
                    break;

                case (int)RemoteFunctions.openJob:
                    OpenJobTab();
                    break;

                case (int)RemoteFunctions.openGPSData:
                    ShowGpsData();
                    break;

                default:
                    break;
            }

        }

        /*private string GetName(int func)
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
                case (int)RemoteButtons.aBtn:


                    break;

                case (int)RemoteButtons.bBtn:



                    break;
                case (int)RemoteButtons.xBtn:



                    break;
                case (int)RemoteButtons.yBtn:



                    break;
                case (int)RemoteButtons.startBtn:



                    break;
                case (int)RemoteButtons.upBtn:


                    break;
                case (int)RemoteButtons.downBtn:



                    break;
                case (int)RemoteButtons.leftBtn:



                    break;
                case (int)RemoteButtons.rightBtn:



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

        private void doSomething()
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

        private int CheckRemoteSettings(string name)
        {
            if (name == "Toggle Auto Cut")
            {
                return (int)RemoteFunctions.toggleAuto;
            }
            if (name == "Toggle Survey")
            {
                return (int)RemoteFunctions.toggleSurvey;
            }
            if (name == "Toggle Tabs")
            {
                return (int)RemoteFunctions.toggleTabs;
            }
            if (name == "Increase Blade Offset")
            {
                return (int)RemoteFunctions.incBladeOff;
            }
            if (name == "Decrease Blade Offset")
            {
                return (int)RemoteFunctions.decBladeOff;
            }
            if (name == "Reset Blade Offset")
            {
                return (int)RemoteFunctions.resetBladeOff;
            }
            if (name == "Open GPS Data")
            {
                return (int)RemoteFunctions.openGPSData;
            }
            if (name == "Open Job")
            {
                return (int)RemoteFunctions.openJob;
            }
            if (name == "Save Cut")
            {
                return (int)RemoteFunctions.saveCut;
            }
            else
            {
                return 9999;
            }


        }
        */
        private void ToggleAutoCut()
        {
            mf.btnManualOffOn.PerformClick();
        }

        private void ToggleSurvey()
        {
            mf.btnManualOffOn.PerformClick();
        }

        private void ToggleTabs()
        {
            int tab = mf.tabGradeControl.SelectedIndex;
            tab++;
            if (tab > 1) tab = 0;
            mf.tabGradeControl.SelectTab(tab);
        }

        private void IncreaseBladeOffset()
        {
            mf.bladeOffset++;
            if (mf.bladeOffset > 50) mf.bladeOffset = 50;
            //lblBladeOffset.Text = mf.bladeOffset.ToString();
        }

        private void DecreaseBladeOffset()
        {
            mf.bladeOffset--;
            if (mf.bladeOffset < -50) mf.bladeOffset = -50;
            mf.lblBladeOffset.Text = mf.bladeOffset.ToString();
        }

        private void ResetBladeOffset()
        {
            mf.bladeOffset = 0;
            //lblBladeOffset.Text = mf.bladeOffset.ToString();
        }

        private void OpenJobTab()
        {
            mf.JobNewOpenResume();
        }

        private void SaveCut()
        {
            mf.btnSaveCut.PerformClick();
        }

        private void ShowGpsData()
        {
            Form form = new FormGPSData(mf);
            form.Show();
        }

    }
}
