using SatellitePermanente.LogicAndMath;
using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente
{
    /*This Class specialized the Origin Class, in way to is possible register a coordinate compatible with the Longitude*/
    class LongitudeImpl : OriginImpl ,Longitude
    {
        private static readonly Utility util = new UtilityImpl();

        /*In the builder it specialize the coordinates, in way to make compatible with the Longitude*/
        public LongitudeImpl(char sign, int degrees, int prime, decimal latter): base(sign, degrees, prime, latter)
        {
            if (char.ToLower(sign) != 'e' || char.ToLower(sign) != 'o') { }
            else
            {
                throw new ArgumentException("Sign is not valid!");
            }

            if (degrees < 0 || degrees > 180)
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
        decimal Longitude.GetLongitude()
        {
            decimal temp = util.AllNumberLate(base.latter);
            temp =+ base.prime;
            temp = util.AllNumberLate(temp);
            temp =+ base.degrees;

            if(char.ToLower(base.sign) == 'o')
            {
                temp = (temp * (-1));
            }

            return temp;
        }
    }
}
