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
        /*Fields*/
        DefaultValue value;

        /*Builder*/
        public AddPoint()
        {
            InitializeComponent();
            value = new DefaultValue();
        }

        /*this is the part of code where are call back two method for create a node*/
        private void ButtonAddPoint_Click(object sender, EventArgs e)
        {
            if (DefaultValue.Checked && DefaultValueBridge.controll)
            {
                DefaultAddPoint();
            }
            else
            {
                NormalAddPoint();
            }
        }

        /*This is the method for set the default values*/
        private void DefaultValuesBotton_Click(object sender, EventArgs e)
        {
            DefaultValueBridge.controll = false;
            value.ShowDialog();
        }

        /*this methos create (and load into the bridge class) a new point without using the default values*/
        private void NormalAddPoint()
        {
            LogicAndMath.Point point;
            Latitude latitude = new Latitude("N", 00, 00, 00000);
            Longitude longitude = new Longitude("E", 00, 00, 00000);
            DateTime time;
            int? angle = null;
            int? altitude = null;
            String? name = null;
            bool meetingPoint = false;
            bool error = false;

            try
            {
                latitude = new Latitude(LatitudeSignText.Text, Convert.ToInt32(this.LatitudeDegreeText.Text), Convert.ToInt32(LatitudePrimeText.Text), Convert.ToDecimal(LatitudeLatterText.Text));
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

        /*this method create a new point (and load into the bridge class) unsing the default values jointed whioth the current values fron the gui*/
        private void DefaultAddPoint()
        {
            String latitudeSign;
            int latitudeDegree;
            int latitudePrime;
            decimal latitudeLatter;

            String longitudeSign;
            int longitudeDegree;
            int longitudePrime;
            decimal longitudeLatter;

            int year;
            int month;
            int day;
            int hour;
            int minutes;

            int? angle = null;
            int? altitude = null;

            if(DefaultValueBridge.latitudeSign != null)
            {
                latitudeSign = DefaultValueBridge.latitudeSign;
            }
            else
            {
                latitudeSign = LatitudeSignText.Text;
            }

            if (DefaultValueBridge.latitudeDegree != null)
            {
                latitudeDegree = Convert.ToInt32(DefaultValueBridge.latitudeDegree);
            }
            else
            {
                latitudeDegree = Convert.ToInt32(LatitudeDegreeText.Text);
            }

            if (DefaultValueBridge.latitudePrime != null)
            {
                latitudePrime = Convert.ToInt32(DefaultValueBridge.latitudePrime);
            }
            else
            {
                latitudePrime = Convert.ToInt32(LatitudePrimeText.Text);
            }

            if (DefaultValueBridge.latitudeLatter != null)
            {
                latitudeLatter = Convert.ToDecimal(DefaultValueBridge.latitudeLatter);
            }
            else
            {
                latitudeLatter = Convert.ToDecimal(LatitudeLatterText.Text);
            }



            if (DefaultValueBridge.longitudeSign != null)
            {
                longitudeSign = DefaultValueBridge.longitudeSign;
            }
            else
            {
                longitudeSign = LongitudeSignText.Text;
            }

            if (DefaultValueBridge.longitudeDegree != null)
            {
                longitudeDegree = Convert.ToInt32(DefaultValueBridge.longitudeDegree);
            }
            else
            {
                longitudeDegree = Convert.ToInt32(LongitudeDegreeText.Text);
            }

            if (DefaultValueBridge.longitudePrime != null)
            {
                longitudePrime = Convert.ToInt32(DefaultValueBridge.longitudePrime);
            }
            else
            {
                longitudePrime = Convert.ToInt32(LongitudePrimeText.Text);
            }

            if (DefaultValueBridge.longitudeLatter != null)
            {
                longitudeLatter = Convert.ToDecimal(DefaultValueBridge.longitudeLatter);
            }
            else
            {
                longitudeLatter = Convert.ToDecimal(LongitudeLatterText.Text);
            }



            if(DefaultValueBridge.year != null)
            {
                year = Convert.ToInt32(DefaultValueBridge.year);
            }
            else
            {
                year = Convert.ToInt32(DateAndTimeYearText.Text);
            }

            if (DefaultValueBridge.month != null)
            {
                month = Convert.ToInt32(DefaultValueBridge.month);
            }
            else
            {
                month = Convert.ToInt32(DateAndTimeMonthText.Text);
            }

            if (DefaultValueBridge.day != null)
            {
                day = Convert.ToInt32(DefaultValueBridge.day);
            }
            else
            {
                day = Convert.ToInt32(DateAndTimeDayText.Text);
            }

            if (DefaultValueBridge.hour != null)
            {
                hour = Convert.ToInt32(DefaultValueBridge.hour);
            }
            else
            {
                hour = Convert.ToInt32(DateAndTimeHourText.Text);
            }

            if (DefaultValueBridge.minutes != null)
            {
                minutes = Convert.ToInt32(DefaultValueBridge.minutes);
            }
            else
            {
                minutes = Convert.ToInt32(DateAndTimeMinutesText.Text);
            }


            if (DefaultValueBridge.checkAngle)
            {
                angle = DefaultValueBridge.angle;
            }
            else
            {
                if (Angle.Checked)
                {
                    angle = Convert.ToInt32(AngleText.Text);
                }
            }


            if (DefaultValueBridge.checkAltitude)
            {
                altitude = DefaultValueBridge.altitude;
            }
            else
            {
                if (Angle.Checked)
                {
                    altitude = Convert.ToInt32(AltitudeText.Text);
                }
            }

            LogicAndMath.Point point;
            Latitude latitude = new Latitude("N", 00, 00, 00000);
            Longitude longitude = new Longitude("E", 00, 00, 00000);
            DateTime time;
            String? name = null;
            bool meetingPoint = false;
            bool error = false;

            try
            {
                latitude = new Latitude(latitudeSign, latitudeDegree, latitudePrime, latitudeLatter);
            }
            catch (ArgumentException catchError)
            {
                error = true;
                MessageBox.Show("DEFAULT LATITUDE IS NOT VALID!\n" + "This is the acepted format: N/S - XX - XX - XX,XXX\n" + "Error message:" + catchError.Message);
                return;
            }

            try
            {
                longitude = new Longitude(longitudeSign, longitudeDegree,longitudePrime, longitudeLatter);
            }
            catch (ArgumentException catchError)
            {
                error = true;
                MessageBox.Show("DEFAULD LONGITUDE IS NOT VALID!\n" + "This is the acepted format: E/W - XX - XX - XX,XXX\n" + "Error message:" + catchError.Message);
                return;
            }

            time = new DateTime(year, month, day, hour, minutes, 00);

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
