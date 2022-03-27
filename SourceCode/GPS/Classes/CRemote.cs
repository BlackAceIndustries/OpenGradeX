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
        //private readonly FormRemote rem;

        public int aBtn;
        public int bBtn;
        public int xBtn;
        public int yBtn;
        public int start_aBtn;
        public int start_bBtn;
        public int start_xBtn;
        public int start_yBtn;
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

        //enum RemoteButtons
        //{
        //    aBtn,
        //    bBtn,
        //    xBtn,
        //    yBtn,
        //    upBtn,
        //    downBtn,
        //    leftBtn,
        //    rightBtn,
        //    startBtn
        //}

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


        //Contructor

        public CRemote(FormGPS _f)
        {
            mf = _f;         
            

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


        /// <summary>
        /// Functions for Remote
        /// </summary>

        private void ToggleAutoCut()
        {
            mf.btnGradeControl.PerformClick();
        }

        private void ToggleSurvey()
        {
            mf.btnManualOffOn.PerformClick();
        }

        private void ToggleTabs()
        {
            int tab = mf.tabGradeControl.SelectedIndex;
            tab++;
            if (tab > 2) tab = 0;
            mf.tabGradeControl.SelectTab(tab);
        }

        private void IncreaseBladeOffset()
        {
            mf.bladeOffset++;
            if (mf.bladeOffset > 50) mf.bladeOffset = 50;
            mf.lblBladeOffset.Text = mf.bladeOffset.ToString();
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
            mf.lblBladeOffset.Text = mf.bladeOffset.ToString();
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




}
*/