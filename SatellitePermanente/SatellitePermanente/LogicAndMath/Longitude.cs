using SatellitePermanente.LogicAndMath;
using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente
{
    /*This Class specialized the Origin Class, in way to is possible register a coordinate compatible with the Longitude*/
    class Longitude : Origin
    {
        /*In the builder it specialize the coordinates, in way to make compatible with the Longitude*/
        public Longitude(String sign, int degrees, int prime, decimal latter): base(sign, degrees, prime, latter)
        {
            if (sign.Length > 1 || sign.ToLower() != "e" && sign.ToLower() != "w") 
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
        public decimal GetLongitude()
        {
            decimal temp = Utility.AllNumberLate(base.latter);
            temp =+ base.prime;
            temp = Utility.AllNumberLate(temp);
            temp =+ base.degrees;

            if(sign.ToLower() == "o")
            {
                temp = (temp * (-1));
            }

            return temp;
        }
    }
}
