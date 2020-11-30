using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente.LogicAndMath
{
    /*This Class specialized the Origin Class, in way to is possible register a coordinate compatible with the Latitude*/
    class Latitude : Origin
    {
        /*In the builder it specialize the coordinates, in way to make compatible with the Latitude values*/
        public Latitude (String sign, int degrees, int prime, decimal latter): base(sign, degrees, prime, latter)
        {
            if (sign.Length > 1 || sign.ToLower() != "n" && sign.ToLower() != "s") 
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

        /*Return the raw data, in decimal format, in way to have a ready number for the operation*/
        public decimal GetLatitude()
        {
            return Utility.ConvertToDecimal(new Origin(base.sign, base.degrees, base.prime, base.latter));
        }
    }
}
