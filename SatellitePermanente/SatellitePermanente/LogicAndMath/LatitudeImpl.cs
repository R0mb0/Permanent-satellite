using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente.LogicAndMath
{
    /*This Class specialized the Origin Class, in way to is possible register a coordinate compatible with the Latitude*/
    class LatitudeImpl : OriginImpl ,Latitude
    {
       private static readonly Utility util = new UtilityImpl();

        /*In the builder it specialize the coordinates, in way to make compatible with the Latitude*/
        public LatitudeImpl (char sign, int degrees, int prime, decimal latter): base(sign, degrees, prime, latter)
        {
            if (char.ToLower(sign) != 'n' || char.ToLower(sign) != 's') { }
            else
            {
                throw new ArgumentException("Sign is not valid!");
            }

            if (degrees < 0 || degrees > 90)
            {
                throw new ArgumentException("Degree are not valid!");
            }
            if (prime < 0 || prime > 59)
            {
                throw new ArgumentException("Prime are not valid!");
            }
            if (latter < 0 || latter > 59)
            {
                throw new ArgumentException("Latter are not valid!");
            }
        }

        /*Return the raw data, in this format: XX°,XX'XXXXX''*/
        decimal Latitude.GetLatitude()
        {
            decimal temp = util.AllNumberLate(base.GetLatter());
            temp =+ base.GetPrime();
            temp = util.AllNumberLate(temp);
            temp =+ base.GetDegrees();

            if (char.ToLower(base.GetSign()) == 's')
            {
                temp = (temp * (-1));
            }

            return temp;
        }
    }
}
