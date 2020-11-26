using SatellitePermanente.LogicAndMath;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SatellitePermanente.GUI
{
    public partial class AddPoint : Form
    {
        /*Builder*/
        public AddPoint()
        {
            InitializeComponent();
            this.MeetingPoint.Checked = false; /*in way to not forghet to uncheck in other adding point*/
        }

        /*this is the part of code where are call back two method for create a node*/
        private void ButtonAddPoint_Click(object sender, EventArgs e)
        {
            /*Local fields for create a new node*/
            LogicAndMath.Point point;
            LogicAndMath.Latitude latitude = new LogicAndMath.Latitude("N", 00, 00, 00000);
            Longitude longitude = new Longitude("E", 00, 00, 00000);
            DateTime time;
            int? angle = null;
            int? altitude = null;
            String? name = null;
            bool meetingPoint = false;
            bool error = false;

            try
            {
                latitude = new LogicAndMath.Latitude(LatitudeSignText.Text, Convert.ToInt32(this.LatitudeDegreeText.Text), Convert.ToInt32(LatitudePrimeText.Text), Convert.ToDecimal(LatitudeLatterText.Text));
            }
            catch (ArgumentException catchError)
            {
                error = true;
                MessageBox.Show("LATITUDE IS NOT VALID!\n" + "This is the acepted format: N/S - XX - XX - XX,XXX\n" + "Error message:" + catchError.Message);
                return;
            }

            try
            {
                longitude = new Longitude(LongitudeSignText.Text, Convert.ToInt32(this.LongitudeDegreeText.Text), Convert.ToInt32(LongitudePrimeText.Text), Convert.ToDecimal(LongitudeLatterText.Text));
            }
            catch (ArgumentException catchError)
            {
                error = true;
                MessageBox.Show("LONGITUDE IS NOT VALID!\n" + "This is the acepted format: E/W - XX - XX - XX,XXX\n" + "Error message:" + catchError.Message);
                return;
            }

            time = new DateTime(Convert.ToInt32(this.DateAndTimeYearText.Text), Convert.ToInt32(this.DateAndTimeMonthText.Text), Convert.ToInt32(this.DateAndTimeDayText.Text), Convert.ToInt32(this.DateAndTimeHourText.Text), Convert.ToInt32(this.DateAndTimeMinutesText.Text), 00);

            if (this.Angle.Checked)
            {
                angle = Convert.ToInt32(this.AngleText.Text);
            }

            if (this.Altitude.Checked)
            {
                altitude = Convert.ToInt32(this.AltitudeText.Text);
            }

            if (this.MeetingPoint.Checked)
            {
                meetingPoint = true;
            }

            if (this.Names.Checked)
            {
                name = NameText.Text;
            }

            if (!error)
            {
                point = new LogicAndMath.Point(latitude, longitude, time, meetingPoint, angle, altitude, name);
                FormBridge.returnPoint = point;
                MessageBox.Show("THE POINT IS VALID!\n");
                this.Close();
            }
        }

    }
}
