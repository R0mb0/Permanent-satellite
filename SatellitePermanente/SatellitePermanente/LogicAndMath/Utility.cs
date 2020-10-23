using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente.LogicAndMath
{
    interface Utility
    {
        public decimal AllNumberLate(decimal n);

        public decimal CalculateDistance(Point pointA, Point pointB);

        public decimal CalculateDirection(Point pointA, Point pointB);

        public TimeSpan CalculateTimeDifference(Point pointA, Point pointB);

        public int ? CalculateAltitudeDifference(Point pointA, Point pointB);

        public decimal CalculateSpeed(Point pointA, Point pointB);
    }
}
