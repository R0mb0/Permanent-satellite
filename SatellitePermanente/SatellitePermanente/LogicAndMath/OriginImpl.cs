using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente
{
    public class OriginImpl: Origin
    {
        private readonly char sign;
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

        public String GetString()
        {
            return Convert.ToString(this.sign) + " " + Convert.ToString(this.degrees) + "° " + Convert.ToString(this.prime) + "' " + Convert.ToString(this.latter) + "''";
        }
    }
}
