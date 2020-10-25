using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente
{

    /*This Class in usefull to shape a short of standar Point of detecion in DMS format.
     This Class will be extended to Latitude Class and Longitude Class in way to specialize the coordinates*/

    public class OriginImpl: Origin
    {
        private readonly char sign; /*Sign = 'N' 'E' 'S' 'O'*/
        private readonly int degrees;
        private readonly int prime;
        private readonly decimal latter;

        public OriginImpl(char sign, int degrees, int prime, decimal latter)
        {
            this.sign = sign;
            this.degrees = degrees;
            this.prime = prime;
            this.latter = latter;
        }

        /*Gets Method*/

        public char GetSign()
        {
            return this.sign;
        }

        public int GetDegrees()
        {
            return this.degrees;
        }

        public int GetPrime()
        {
            return this.prime;
        }

        public decimal GetLatter()
        {
            return this.latter;
        }

        /*This method serves to print the coordinates salved*/
        public String GetString()
        {
            return Convert.ToString(this.sign) + " " + Convert.ToString(this.degrees) + "° " + Convert.ToString(this.prime) + "' " + Convert.ToString(this.latter) + "''";
        }
    }
}
