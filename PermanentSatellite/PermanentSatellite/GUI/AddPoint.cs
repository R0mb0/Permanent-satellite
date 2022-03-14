using PermanentSatellite.LogicAndMath;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PermanentSatellite.GUI
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
            /*the returned point*/
            LogicAndMath.Point point;
            /*the latiute and longitude that will be inserted into the return point*/
            LogicAndMath.Latitude latitude = new LogicAndMath.Latitude("N", 00, 00, 00000);
            Longitude longitude = new Longitude("E", 00, 00, 00000);
            /*other point proterties to inserto to the returned point*/
            DateTime time;
            int? angle = null;
            int? altitude = null;
            String? name = null;
            bool meetingPoint = false;

            /*in case of error during the inserting values, don`t create the point*/
            bool error = false;

            /*try to define a new Latitude to insert into the new point*/
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

            /*try to define a new Longitude to insert into the new point*/
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

            /*try to set the time*/
            try
            {
                time = new DateTime(Convert.ToInt32(this.DateAndTimeYearText.Text), Convert.ToInt32(this.DateAndTimeMonthText.Text), Convert.ToInt32(this.DateAndTimeDayText.Text), Convert.ToInt32(this.DateAndTimeHourText.Text), Convert.ToInt32(this.DateAndTimeMinutesText.Text), 00);
            }
            catch (ArgumentOutOfRangeException catchError)
            {
                error = true;
                MessageBox.Show("DATE AND TIME ARE NOT VALID!\n" + "the acepted format is : 24H format " + "Error message:" + catchError.Message);
                return;
            }

            /*if is possibe set the compass angle*/
            if (this.Angle.Checked)
            {
                angle = Convert.ToInt32(this.AngleText.Text);
            }

            /*if is possibe set the altitude value*/
            if (this.Altitude.Checked)
            {
                altitude = Convert.ToInt32(this.AltitudeText.Text);
            }

            /*if this is a meeting point */
            meetingPoint = this.MeetingPoint.Checked;

            /*if is possibe set the point name*/
            if (this.Names.Checked)
            {
                name = NameText.Text;
            }

            /*if there aren`t error can create the point*/
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
