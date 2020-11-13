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
        public AddPoint()
        {
            InitializeComponent();
        }

        private void ButtonAddPoint_Click(object sender, EventArgs e)
        {
            LogicAndMath.Point point;
            Latitude latitude = new LatitudeImpl(Convert.ToChar("N"),00,00,00000);
            Longitude longitude = new LongitudeImpl(Convert.ToChar("E"), 00, 00, 00000);
            DateTime time;
            int angle =0;
            int altitude =0;
            bool meetingPoint = false;
            bool error = false;

            
            try
            {
                latitude = new LatitudeImpl(char.ToLower(Convert.ToChar(LatitudeSignText.Text)), Convert.ToInt32(this.LatitudeDegreeText.Text), Convert.ToInt32(LatitudePrimeText.Text), Convert.ToDecimal(LatitudeLatterText.Text));
            }
            catch (ArgumentException)
            {
                error = true;
                MessageBox.Show("LATITUDE IS NOT VALID!\n" + "This is the acepted format: N/S - XX - XX - XX,XXX");
            }

            try 
            {
                longitude = new LongitudeImpl(Convert.ToChar(LongitudeSignText.Text), Convert.ToInt32(this.LongitudeDegreeText.Text), Convert.ToInt32(LongitudePrimeText.Text), Convert.ToDecimal(LongitudeLatterText.Text));
            }
            catch (ArgumentException)
            {
                error = true;
                MessageBox.Show("LONGITUDE IS NOT VALID!\n" + "This is the acepted format: E/W - XX - XX - XX,XXX");
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

            if (!error)
            {
                if(this.Angle.Checked|| this.Altitude.Checked)
                {
                    point = new PointImpl(latitude, longitude, time, meetingPoint, angle, altitude);
                    MessageBox.Show("THE POINT IS VALID!\n");
                }
                else
                {
                    point = new PointImpl(latitude, longitude, time, meetingPoint);
                    MessageBox.Show("THE POINT IS VALID!\n");
                }
            }
        }
    }
}
