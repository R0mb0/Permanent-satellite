using raminrahimzada;
using System;
using System.Collections.Generic;
using System.Text;


namespace SatellitePermanente.LogicAndMath
{
    class UtilityImpl:Utility
    {
        private const decimal eartRadius = 6372.795477598m;
        public UtilityImpl() { }

        public decimal AllNumberLate(decimal n)
        {
            decimal number = n;

            while (number > 0.9m)
            {
                number = number / 10.0m;
            }

            return number;
        }

        public decimal CalculateDistance(Point pointA, Point pointB)
        {
            
        }
    }
}
