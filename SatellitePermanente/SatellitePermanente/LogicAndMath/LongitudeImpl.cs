using SatellitePermanente.LogicAndMath;
using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente
{
    class LongitudeImpl : OriginImpl ,Longitude
    {
        private static readonly Utility util = new UtilityImpl();

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

        decimal Longitude.GetLongitude()
        {
            decimal temp = util.AllNumberLate(base.GetLatter());
            temp =+ base.GetPrime();
            temp = util.AllNumberLate(temp);
            temp =+ base.GetDegrees();

            if(char.ToLower(base.GetSign()) == 'o')
            {
                temp = (temp * (-1));
            }

            return temp;
        }
    }
}
