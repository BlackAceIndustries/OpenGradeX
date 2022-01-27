﻿
using System;
using System.Windows.Forms;
using System.Threading;
using Microsoft.Win32;
using OpenGrade.Properties;

namespace OpenGrade
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static readonly Mutex Mutex = new Mutex(true, "{8F6F0AC5-B9A1-55fd-A8CF-72F04E6BDE8F}");
        [STAThread]
        static void Main()
        {
            if (Mutex.WaitOne(TimeSpan.Zero, true))
            {
                //opening the subkey  
                RegistryKey regKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\OpenGrade");

                //create default keys if not existing
                if (regKey == null)
                {
                    RegistryKey Key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\OpenGrade");

                    //storing the values  
                    Key.SetValue("Language", "en");
                    Key.SetValue("Directory", "Default");
                    Key.Close();

                    Settings.Default.set_culture = "en";
                    Settings.Default.setF_workingDirectory = "Default";
                    Settings.Default.Save();
                }

                else
                {
                    Settings.Default.set_culture = regKey.GetValue("Language").ToString();
                    Settings.Default.setF_workingDirectory = regKey.GetValue("Directory").ToString();
                    Settings.Default.Save();
                    regKey.Close();
                }



                //if (Environment.OSVersion.Version.Major >= 6) SetProcessDPIAware();
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(Properties.Settings.Default.set_culture);
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Settings.Default.set_culture);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormGPS());
            }
            else
            {
                MessageBox.Show("OpenGrade is Already Running");
            }
        }

        //[System.Runtime.InteropServices.DllImport("user32.dll")]
        //private static extern bool SetProcessDPIAware();
    }
}
