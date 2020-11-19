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
        }

        private void ButtonAddPoint_Click(object sender, EventArgs e)
        {
            DefaultValueBridge.ResetValue();

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





        }
    }
}
