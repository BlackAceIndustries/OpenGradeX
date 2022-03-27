//Please, if you use this, share the improvements

using System;
using System.IO;
using System.Windows.Forms;

namespace OpenGrade
{
    public partial class FormSettings : Form
    {
       //class variables
        private readonly FormGPS mf = null;

        private double antennaHeight, plowHeight, minSlope,minShoreSlope, toolWidth, maxTileCut, 
            maxDitchCut, minTileCover, minDitchCut,viewDistAboveGnd, viewDistUnderGnd;
        private byte KpGain, KiGain, KdGain, retDeadband, extDeadband, valveType;
      
        private readonly double metImp2m, m2MetImp;

        //constructor
        public FormSettings(Form callingForm, int page)
        {
            //get copy of the calling main form
            mf = callingForm as FormGPS;
            InitializeComponent();

            if (mf.isMetric)
            {
                metImp2m = 0.01;
                m2MetImp = 100.0;
                lblInchesCm.Text = "Centimeters";
            }
            else
            {
                metImp2m = glm.in2m;
                m2MetImp = glm.m2in;
                lblInchesCm.Text = "Inches";
            }
            //select the page as per calling menu or button from mainGPS form
            tabOpenGrade.SelectedIndex = page;
        }

        //do any field initializing for form here
        private void FormSettings_Load(object sender, EventArgs e)
        {
            //Vehicle settings to what it is in the settings page------------------------------------------------
            antennaHeight = Properties.Vehicle.Default.setVehicle_antennaHeight;
            plowHeight = Properties.Vehicle.Default.setVehicle_plowHeight;

            maxTileCut = Properties.Vehicle.Default.setVehicle_maxTileCut;  
            minDitchCut = Properties.Vehicle.Default.setVehicle_minDitchCut;
            maxDitchCut = Properties.Vehicle.Default.setVehicle_maxDitchCut;
            minTileCover = Properties.Vehicle.Default.setVehicle_minTileCover;      
            

            KpGain = Properties.Settings.Default.set_KpGain;
            KiGain = Properties.Settings.Default.set_KiGain; /// 10
            KdGain = Properties.Settings.Default.set_KdGain;//* 100

            retDeadband = Properties.Settings.Default.set_RetDeadband;
            extDeadband = Properties.Settings.Default.set_ExtDeadband;
            valveType = Properties.Settings.Default.set_ValveType;

            valveSelectChoice.Text = Properties.Settings.Default.set_ValveName;
           
            toolWidth = Properties.Vehicle.Default.setVehicle_toolWidth;
            minSlope = Math.Abs(Properties.Vehicle.Default.setVehicle_minSlope * 100);
            minShoreSlope = Properties.Vehicle.Default.setVehicle_minShoreSlope;





            nudAntennaHeight.ValueChanged -= nudAntennaHeight_ValueChanged;
            nudAntennaHeight.Value = (decimal)(antennaHeight * m2MetImp);
            nudAntennaHeight.ValueChanged += nudAntennaHeight_ValueChanged;

            nudPlowHeight.ValueChanged -= nudPlowHeight_ValueChanged;
            nudPlowHeight.Value = (decimal)(plowHeight * m2MetImp);
            nudPlowHeight.ValueChanged += nudPlowHeight_ValueChanged;

            //Black Ace Industries

            nudMaxTileCut.ValueChanged -= nudMaxTileCut_ValueChanged;
            nudMaxTileCut.Value = (decimal)(maxTileCut * m2MetImp);
            nudMaxTileCut.ValueChanged += nudMaxTileCut_ValueChanged;

            nudMinTileCover.ValueChanged -= nudMinTileCover_ValueChanged;
            nudMinTileCover.Value = (decimal)(minTileCover * m2MetImp);
            nudMinTileCover.ValueChanged += nudMinTileCover_ValueChanged;

            nudMaxDitchCut.ValueChanged -= nudMaxDitchCut_ValueChanged;
            nudMaxDitchCut.Value = (decimal)(maxDitchCut * m2MetImp);
            nudMaxDitchCut.ValueChanged += nudMaxDitchCut_ValueChanged;

            nudMinDitchCut.ValueChanged -= nudMinDitchCut_ValueChanged;
            nudMinDitchCut.Value = (decimal)(minDitchCut * m2MetImp);
            nudMinDitchCut.ValueChanged += nudMinDitchCut_ValueChanged;

            nudKp.ValueChanged -= nudKp_ValueChanged;
            nudKp.Value = KpGain;
            nudKp.ValueChanged += nudKp_ValueChanged;

            nudKi.ValueChanged -= nudKi_ValueChanged;
            nudKi.Value = KiGain;
            nudKi.ValueChanged += nudKi_ValueChanged;

            nudKd.ValueChanged -= nudKd_ValueChanged;
            nudKd.Value = KdGain;
            nudKd.ValueChanged += nudKd_ValueChanged;

            nudExtDeadband.ValueChanged -= nudExtDeadband_ValueChanged;
            nudExtDeadband.Value = extDeadband;
            nudExtDeadband.ValueChanged += nudExtDeadband_ValueChanged;

            nudRetDeadband.ValueChanged -= nudRetDeadband_ValueChanged;
            nudRetDeadband.Value = retDeadband;
            nudRetDeadband.ValueChanged += nudRetDeadband_ValueChanged;

            ///

            nudToolWidth.ValueChanged -= nudToolWidth_ValueChanged;
            nudToolWidth.Value = (decimal)(toolWidth * m2MetImp);
            nudToolWidth.ValueChanged += nudToolWidth_ValueChanged;

            nudMinSlope.ValueChanged -= nudMinSlope_ValueChanged;
            nudMinSlope.Value = (decimal)(minSlope);
            nudMinSlope.ValueChanged += nudMinSlope_ValueChanged;

            nudMinShoreSlope.ValueChanged -= nudMinShoreSlope_ValueChanged;
            nudMinShoreSlope.Value = (decimal)(minShoreSlope);
            nudMinShoreSlope.ValueChanged += nudMinShoreSlope_ValueChanged;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //Vehicle settings -------------------------------------------------------------------------------
            mf.vehicle.minSlope = minSlope/100;
            Properties.Vehicle.Default.setVehicle_minSlope = mf.vehicle.minSlope;

            mf.vehicle.minShoreSlope = minShoreSlope;
            Properties.Vehicle.Default.setVehicle_minShoreSlope = mf.vehicle.minShoreSlope;

            mf.vehicle.plowHeight = plowHeight;
            Properties.Vehicle.Default.setVehicle_plowHeight = mf.vehicle.plowHeight;
            
            //
            // Black Ace Industries
            //
            mf.vehicle.maxTileCut = maxTileCut;
            Properties.Vehicle.Default.setVehicle_maxTileCut = mf.vehicle.maxTileCut;
            mf.vehicle.minDitchCut = minDitchCut;
            Properties.Vehicle.Default.setVehicle_minDitchCut = mf.vehicle.minDitchCut;
            mf.vehicle.maxDitchCut = maxDitchCut;
            Properties.Vehicle.Default.setVehicle_maxDitchCut = mf.vehicle.maxDitchCut;
            mf.vehicle.minTileCover = minTileCover;
            Properties.Vehicle.Default.setVehicle_minTileCover = mf.vehicle.minTileCover;

            mf.vehicle.KpGain = KpGain;
            Properties.Settings.Default.set_KpGain = mf.vehicle.KpGain;
            mf.vehicle.KiGain = KiGain;
            Properties.Settings.Default.set_KiGain = mf.vehicle.KiGain;
            mf.vehicle.KdGain = KdGain;
            Properties.Settings.Default.set_KdGain = mf.vehicle.KdGain;

            mf.vehicle.retDeadband = retDeadband;
            Properties.Settings.Default.set_RetDeadband = mf.vehicle.retDeadband;
            mf.vehicle.extDeadband = extDeadband;
            Properties.Settings.Default.set_ExtDeadband = mf.vehicle.extDeadband;

            mf.vehicle.valveType = valveType;
            Properties.Settings.Default.set_ValveType = mf.vehicle.valveType;

            mf.mc.gradeControlSettings[mf.mc.gsKpGain] = Properties.Settings.Default.set_KpGain;
            mf.mc.gradeControlSettings[mf.mc.gsKiGain] = Properties.Settings.Default.set_KiGain;
            mf.mc.gradeControlSettings[mf.mc.gsKdGain] = Properties.Settings.Default.set_KdGain;
            mf.mc.gradeControlSettings[mf.mc.gsRetDeadband] = Properties.Settings.Default.set_RetDeadband;
            mf.mc.gradeControlSettings[mf.mc.gsExtDeadband] = Properties.Settings.Default.set_ExtDeadband;
            mf.mc.gradeControlSettings[mf.mc.gsValveType] = Properties.Settings.Default.set_ValveType;
            
            ////
            ////
            ///

            mf.vehicle.antennaHeight = antennaHeight;
            Properties.Vehicle.Default.setVehicle_antennaHeight = mf.vehicle.antennaHeight;

            mf.vehicle.toolWidth = toolWidth;
            Properties.Vehicle.Default.setVehicle_toolWidth = toolWidth;

            //Sections ------------------------------------------------------------------------------------------

            Properties.Settings.Default.Save();
            Properties.Vehicle.Default.Save();

            mf.SendUDPMessage(FormGPS.SETTINGS_HEADER, mf.epGradeControl);

            //back to FormGPS
            DialogResult = DialogResult.OK;

            
            Close();
        }

        //don't save anything, leave the settings as before
        private void btnCancel_Click(object sender, EventArgs e)
        { DialogResult = DialogResult.Cancel; Close(); }


        #region Vehicle //----------------------------------------------------------------

        private void nudAntennaHeight_ValueChanged(object sender, EventArgs e)
        {
            antennaHeight = (double)nudAntennaHeight.Value * metImp2m;
        }

        private void valveSelectChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (valveSelectChoice.Text == "CNH")
            {
                mf.mc.gradeControlSettings[mf.mc.gsValveType] = 0;
                Properties.Settings.Default.set_ValveType = mf.mc.gradeControlSettings[mf.mc.gsValveType];
                valveType = mf.mc.gradeControlSettings[mf.mc.gsValveType];
                Properties.Settings.Default.set_ValveName = valveSelectChoice.Text;
                Properties.Settings.Default.Save();
                

            }
            if (valveSelectChoice.Text == "DEERE")
            {
                mf.mc.gradeControlSettings[mf.mc.gsValveType] = 1;
                Properties.Settings.Default.set_ValveType = mf.mc.gradeControlSettings[mf.mc.gsValveType];
                valveType = mf.mc.gradeControlSettings[mf.mc.gsValveType];
                Properties.Settings.Default.set_ValveName = valveSelectChoice.Text;
                Properties.Settings.Default.Save();
               

            }
            if (valveSelectChoice.Text == "DANFOSS")
            {
                mf.mc.gradeControlSettings[mf.mc.gsValveType] = 2;
                Properties.Settings.Default.set_ValveType = mf.mc.gradeControlSettings[mf.mc.gsValveType];
                valveType = mf.mc.gradeControlSettings[mf.mc.gsValveType];
                Properties.Settings.Default.set_ValveName = valveSelectChoice.Text;
                Properties.Settings.Default.Save();
                
            }
            else 
            {
                mf.mc.gradeControlSettings[mf.mc.gsValveType] = 0;
                Properties.Settings.Default.set_ValveType = mf.mc.gradeControlSettings[mf.mc.gsValveType];
                valveType = mf.mc.gradeControlSettings[mf.mc.gsValveType];
                Properties.Settings.Default.set_ValveName = valveSelectChoice.Text;
                Properties.Settings.Default.Save();
                
            }
        }


        private void nudKp_ValueChanged_1(object sender, EventArgs e)
        {
            KpGain = (byte)nudKp.Value;            
            mf.mc.gradeControlSettings[mf.mc.gsKpGain] = KpGain;
            Properties.Settings.Default.set_KdGain = KdGain;
            KpGain = Properties.Settings.Default.set_KpGain;
            Properties.Settings.Default.Save();
            
        }

        private void nudKi_ValueChanged_1(object sender, EventArgs e)
        {
            KiGain = (byte)nudKi.Value;            
            mf.mc.gradeControlSettings[mf.mc.gsKiGain] = KiGain;
            Properties.Settings.Default.set_KiGain = KiGain;
            KiGain = Properties.Settings.Default.set_KiGain; /// 10
            Properties.Settings.Default.Save();
            

        }

        private void nudKd_ValueChanged_1(object sender, EventArgs e)
        {
            KdGain = (byte)nudKd.Value;            
            mf.mc.gradeControlSettings[mf.mc.gsKdGain] = KdGain;
            Properties.Settings.Default.set_KdGain = KdGain;
            KdGain = Properties.Settings.Default.set_KdGain;
            Properties.Settings.Default.Save();
            

        }
      

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            extDeadband = (byte)nudExtDeadband.Value;
            mf.mc.gradeControlSettings[mf.mc.gsExtDeadband] = extDeadband;
            Properties.Settings.Default.set_ExtDeadband = extDeadband;            
            extDeadband = Properties.Settings.Default.set_ExtDeadband;
            Properties.Settings.Default.Save();
            

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            retDeadband = (byte)nudRetDeadband.Value;
            mf.mc.gradeControlSettings[mf.mc.gsRetDeadband] = retDeadband;
            Properties.Settings.Default.set_RetDeadband = retDeadband;
            Properties.Settings.Default.Save();
           

        }


        // Black Ace Industries
        private void nudPlowHeight_ValueChanged(object sender, EventArgs e)
        {
            plowHeight = (double)nudPlowHeight.Value * metImp2m;
        }
        private void nudMinTileCover_ValueChanged(object sender, EventArgs e)
        {
            minTileCover = (double)nudMinTileCover.Value * metImp2m;
        }
        private void nudMaxTileCut_ValueChanged(object sender, EventArgs e)
        {
            maxTileCut = (double)nudMaxTileCut.Value * metImp2m;
        }
        private void nudMinDitchCut_ValueChanged(object sender, EventArgs e)
        {
            minDitchCut = (double)nudMinDitchCut.Value * metImp2m;
        }private void nudMaxDitchCut_ValueChanged(object sender, EventArgs e)
        {
            maxDitchCut = (double)nudMaxDitchCut.Value * metImp2m;
        }        
        private void nudKp_ValueChanged(object sender, EventArgs e)
        {
            KpGain = (byte)nudKp.Value;
            
        }
        private void nudKi_ValueChanged(object sender, EventArgs e)
        {
            KiGain = (byte)nudKi.Value;
            
            
        }
        private void nudKd_ValueChanged(object sender, EventArgs e)
        {
            KdGain = (byte)nudKd.Value;
            
        }

        private void nudRetDeadband_ValueChanged(object sender, EventArgs e)
        {
            retDeadband = (byte)nudRetDeadband.Value;
            
        }
      
        private void nudExtDeadband_ValueChanged(object sender, EventArgs e)
        {
            extDeadband = (byte)nudExtDeadband.Value;            
        }
        
        private void nudMinSlope_ValueChanged(object sender, EventArgs e)
        {
            minSlope = (double)nudMinSlope.Value;
        }

        private void nudMinShoreSlope_ValueChanged(object sender, EventArgs e)
        {
            minShoreSlope = (double)nudMinShoreSlope.Value;
        }


        private void nudToolWidth_ValueChanged(object sender, EventArgs e)
        {
            toolWidth = (double)nudToolWidth.Value * metImp2m;
        }





      #endregion Vehicle
    }
}