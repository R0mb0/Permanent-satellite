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
            return (eartRadius * DecimalMath.Acos( (DecimalMath.Sin(pointA.GetPointLatitude().GetLatitude()) * pointB.GetPointLatitude().GetLatitude())
                + (DecimalMath.Cos(pointA.GetPointLatitude().GetLatitude()) * DecimalMath.Cos(pointB.GetPointLatitude().GetLatitude())) 
                * DecimalMath.Cos( pointA.GetPointLatitude().GetLatitude() - pointB.GetPointLatitude().GetLatitude())));
        }

        public decimal CalculateDirection(Point pointA, Point pointB)
        {
            decimal phi = DecimalMath.Log( DecimalMath.Tan( (pointB.GetPointLatitude().GetLatitude() /2) + (Convert.ToDecimal(Math.PI) /4)) 
                / DecimalMath.Tan((pointA.GetPointLatitude().GetLatitude() / 2) + (Convert.ToDecimal(Math.PI) / 4)));

            decimal lon = DecimalMath.Abs(pointA.GetPointLongitude().GetLongitude() - pointB.GetPointLongitude().GetLongitude());

            return DecimalMath.Atan2(lon, phi);
        }

        public TimeSpan CalculateTimeDifference(Point pointA, Point pointB)
        {
           return pointA.GetDateTime().Subtract(pointB.GetDateTime());
        }

        public int ? CalculateAltitudeDifference(Point pointA, Point pointB)
        {
            if (pointA.GetAltitude() == null || pointB.GetAltitude() == null)
            {
                return null;
            }

            return Math.Abs(pointA.GetAltitude().Value - pointB.GetAltitude().Value);
        }

        public decimal CalculateSpeed(Point pointA, Point pointB)
        {
            return CalculateDistance(pointA, pointB) / Convert.ToDecimal(CalculateTimeDifference(pointA, pointB).TotalHours);
        }

    }
}
