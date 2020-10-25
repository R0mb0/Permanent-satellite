using raminrahimzada;
using System;
using System.Collections.Generic;
using System.Text;


namespace SatellitePermanente.LogicAndMath
{
    /*This class is usefull for calculate the properties of Nodes and for create a raw data on Latitude Class and Longitude Class*/
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

        /*This method implement this formula:
         distance (A,B) = R * arccos(sin(latA) * sin(latB) + cos(latA) * cos(latB) * cos(lonA-lonB))*/
        public decimal CalculateDistance(Point pointA, Point pointB)
        {
            return (eartRadius * DecimalMath.Acos( (DecimalMath.Sin(pointA.GetPointLatitude().GetLatitude()) * pointB.GetPointLatitude().GetLatitude())
                + (DecimalMath.Cos(pointA.GetPointLatitude().GetLatitude()) * DecimalMath.Cos(pointB.GetPointLatitude().GetLatitude())) 
                * DecimalMath.Cos( pointA.GetPointLatitude().GetLatitude() - pointB.GetPointLatitude().GetLatitude())));
        }

        /*This method implement this formula:
         Δφ = ln( tan( latB / 2 + π / 4 ) / tan( latA / 2 + π / 4) ) 
         Δlon = abs( lonA - lonB ) 
         direction :  θ = atan2( Δlon ,  Δφ ) */
        public decimal CalculateDirection(Point pointA, Point pointB)
        {
            decimal phi = DecimalMath.Log( DecimalMath.Tan( (pointB.GetPointLatitude().GetLatitude() /2) + (Convert.ToDecimal(Math.PI) /4)) 
                / DecimalMath.Tan((pointA.GetPointLatitude().GetLatitude() / 2) + (Convert.ToDecimal(Math.PI) / 4)));

            decimal lon = DecimalMath.Abs(pointA.GetPointLongitude().GetLongitude() - pointB.GetPointLongitude().GetLongitude());

            return DecimalMath.Atan2(lon, phi);
        }

        /*This method calculate the difference of time from two Points, it is usefull for calculate the Speed*/
        public TimeSpan CalculateTimeDifference(Point pointA, Point pointB)
        {
           return pointA.GetDateTime().Subtract(pointB.GetDateTime());
        }

        /*This method calculate the difference of altitude from two Points*/
        public int ? CalculateAltitudeDifference(Point pointA, Point pointB)
        {
            if (pointA.GetAltitude() == null || pointB.GetAltitude() == null)
            {
                return null;
            }

            return Math.Abs(pointA.GetAltitude().Value - pointB.GetAltitude().Value);
        }

        /*This method implement this formula:
         Speed= space/time  */
        public decimal CalculateSpeed(Point pointA, Point pointB)
        {
            return CalculateDistance(pointA, pointB) / Convert.ToDecimal(CalculateTimeDifference(pointA, pointB).TotalHours);
        }

    }
}
