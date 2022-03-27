﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenGrade
{
    public partial class FormSource : Form
    {
        private List<string> dataList = new List<string>();
        private readonly FormGPS mf = null;
        private readonly FormNtrip nf = null;
        double lat, lon;

        string site;

        public FormSource(List<string> _dataList, double _lat, double _lon, string syte, Form callingForm, Form callingForm2)
        {
            InitializeComponent();
            //get copy of the calling main form
            mf = callingForm as FormGPS;
            nf = callingForm2 as FormNtrip;
            dataList = _dataList;
            lat = _lat;
            lon = _lon;
            site = syte;
        }

        private void FormSource_Load(object sender, EventArgs e)
        {
            double minDist = 999999999, cLat = 0, cLon = 0;
            int place = 99999;
            ListViewItem itm;
            if (dataList.Count > 0)
            {
                double temp;

                for (int i = 0; i < dataList.Count; i++)
                {
                    string[] data = dataList[i].Split(',');
                    double.TryParse(data[1].Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out cLat);
                    double.TryParse(data[2].Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out cLon);

                    if (cLat == 0 || cLon == 0)
                    {
                        temp = 9999999.9;
                    }
                    else
                    {
                        temp = GetDistance(cLon, cLat, lon, lat);
                        temp *= .001;

                    }
                    if (temp < minDist)
                    {
                        minDist = temp;
                        place = i;
                    }

                    string temp2;
                    if (mf.isMetric)
                    {
                        temp2 = temp.ToString("#######").PadLeft(10) + " KM";
                    }
                    else
                    {
                        temp *= 0.621371;
                        temp2 = temp.ToString("#######").PadLeft(10) + " Miles";

                    }
                        
                    
                    

                    //load up the listview
                    string[] baseNames = { temp2 ,data[0].Trim(), data[1].Trim(),
                                                    data[2].Trim(), data[3].Trim(), data[4].Trim() };
                    itm = new ListViewItem(baseNames);
                    lvLines.Items.Add(itm);
                }

                string[] dataM = dataList[place].Split(',');
                tboxMount.Text = dataM[0];
            }
            this.chName.Width = 250;
        }

        private void btnSite_Click(object sender, EventArgs e)
        {
            Process.Start(site);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lvLines_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tboxMount.Text = lvLines.SelectedItems.ToString();           


        }

        public double GetDistance(double longitude, double latitude, double otherLongitude, double otherLatitude)
        {
            var d1 = latitude * (Math.PI / 180.0);
            var num1 = longitude * (Math.PI / 180.0);
            var d2 = otherLatitude * (Math.PI / 180.0);
            var num2 = otherLongitude * (Math.PI / 180.0) - num1;
            var d3 = Math.Pow(Math.Sin((d2 - d1) / 2.0), 2.0) + Math.Cos(d1) * Math.Cos(d2) * Math.Pow(Math.Sin(num2 / 2.0), 2.0);

            return 6376500.0 * (2.0 * Math.Atan2(Math.Sqrt(d3), Math.Sqrt(1.0 - d3)));
        }
    }
}
