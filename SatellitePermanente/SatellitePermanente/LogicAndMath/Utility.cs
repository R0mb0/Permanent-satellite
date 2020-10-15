using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente.LogicAndMath
{
    class Utility
    {
        private const decimal eartRadius = 6372.795477598m;
        public Utility() { }

        public decimal AllNumberLate(decimal n)
        {
            decimal number = n;

            while (number > 0.9m)
            {
                number = number / 10.0m;
            }

            return number;
        }
    }
}
