using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SatellitePermanente.GUI
{
    public partial class DefaultValue : Form
    {
        public DefaultValue()
        {
            InitializeComponent();


            LatitudeSignText.Text = DefaultValueBridge.latitudeSign;
            LatitudeDegreeText.Text = DefaultValueBridge.latitudeDegree.ToString();
            LatitudePrimeText.Text = DefaultValueBridge.latitudePrime.ToString();
            LatitudeLatterText.Text = DefaultValueBridge.latitudeLatter.ToString();

            LongitudeSignText.Text = DefaultValueBridge.longitudeSign;
            LongitudeDegreeText.Text = DefaultValueBridge.longitudeDegree.ToString();
            LongitudePrimeText.Text = DefaultValueBridge.longitudePrime.ToString();
            LongitudeLatterText.Text = DefaultValueBridge.longitudeLatter.ToString();

            DateAndTimeYearText.Text = DefaultValueBridge.year.ToString();
            DateAndTimeMonthText.Text = DefaultValueBridge.month.ToString();
            DateAndTimeDayText.Text = DefaultValueBridge.day.ToString();
            DateAndTimeHourText.Text = DefaultValueBridge.hour.ToString();
            DateAndTimeMinutesText.Text = DefaultValueBridge.minutes.ToString();

            Angle.Checked = DefaultValueBridge.checkAngle;
            AngleText.Text = DefaultValueBridge.angle.ToString();

            Altitude.Checked = DefaultValueBridge.checkAltitude;
            AltitudeText.Text = DefaultValueBridge.altitude.ToString();
        }

        private void SetValues_Click(object sender, EventArgs e)
        {
            DefaultValueBridge.ResetValue();

            DefaultValueBridge.controll = true;

            if (LatitudeSignText.Text.Length > 0)
            {
                DefaultValueBridge.latitudeSign = LatitudeSignText.Text;
            }

            if (LatitudeDegreeText.Text.Length > 0)
            {
                DefaultValueBridge.latitudeDegree = Convert.ToInt32(LatitudeDegreeText.Text);
            }

            if (LatitudePrimeText.Text.Length > 0)
            {
                DefaultValueBridge.latitudePrime = Convert.ToInt32(LatitudePrimeText.Text);
            }

            if (LatitudeLatterText.Text.Length > 0)
            {
                DefaultValueBridge.latitudeLatter = Convert.ToDecimal(LatitudeLatterText.Text);
            }



            if (LongitudeSignText.Text.Length > 0)
            {
                DefaultValueBridge.longitudeSign = LongitudeSignText.Text;
            }

            if (LongitudeDegreeText.Text.Length > 0)
            {
                DefaultValueBridge.longitudeDegree = Convert.ToInt32(LongitudeDegreeText.Text);
            }

            if (LongitudePrimeText.Text.Length > 0)
            {
                DefaultValueBridge.longitudePrime = Convert.ToInt32(LongitudePrimeText.Text);
            }

            if (LongitudeLatterText.Text.Length > 0)
            {
                DefaultValueBridge.longitudeLatter = Convert.ToDecimal(LongitudeLatterText.Text);
            }




            if(DateAndTimeYearText.Text.Length > 0)
            {
                DefaultValueBridge.year = Convert.ToInt32(DateAndTimeYearText.Text);
            }

            if(DateAndTimeMonthText.Text.Length > 0)
            {
                DefaultValueBridge.month = Convert.ToInt32(DateAndTimeMonthText.Text);
            }

            if (DateAndTimeDayText.Text.Length > 0)
            {
                DefaultValueBridge.day = Convert.ToInt32(DateAndTimeDayText.Text);
            }

            if(DateAndTimeHourText.Text.Length > 0)
            {
                DefaultValueBridge.hour = Convert.ToInt32(DateAndTimeHourText.Text);
            }

            if (DateAndTimeMinutesText.Text.Length > 0)
            {
                DefaultValueBridge.minutes = Convert.ToInt32(DateAndTimeMinutesText.Text);
            }



            if (Angle.Checked)
            {
                DefaultValueBridge.checkAngle = true;
                DefaultValueBridge.angle = Convert.ToInt32(AngleText.Text);
            }



            if (Altitude.Checked)
            {
                DefaultValueBridge.checkAltitude = true;
                DefaultValueBridge.altitude = Convert.ToInt32(AltitudeText.Text);
            }

            this.Close();
        }
    }
}
