using raminrahimzada;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SatellitePermanente.LogicAndMath
{
    /*This class is usefull for calculate the properties of Nodes and for create a raw data on Latitude Class and Longitude Class*/
    static class Utility
    {
        private const decimal eartRadius = 6372.795477598m;
        

        public static decimal AllNumberLate(decimal n)
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
        public static decimal CalculateDistance(Point pointA, Point pointB)
        {
            return (eartRadius * DecimalMath.Acos( DecimalMath.Sin(pointA.latitude.GetLatitude()) * DecimalMath.Sin(pointB.latitude.GetLatitude())
                + DecimalMath.Cos(pointA.latitude.GetLatitude()) * DecimalMath.Cos(pointB.latitude.GetLatitude())
                * DecimalMath.Cos(pointA.longitude.GetLongitude() - pointB.longitude.GetLongitude())));
        }

        /*This method implement this formula:
         Δφ = ln( tan( latB / 2 + π / 4 ) / tan( latA / 2 + π / 4) ) 
         Δlon = abs( lonA - lonB ) 
         direction :  θ = atan2( Δlon ,  Δφ ) */
        public static decimal CalculateDirection(Point pointA, Point pointB)
        {
            decimal phi = DecimalMath.Log( 
                (DecimalMath.Tan( pointB.latitude.GetLatitude() /2 + Convert.ToDecimal(Math.PI) /4)) 
                / DecimalMath.Tan(pointA.latitude.GetLatitude() / 2 + Convert.ToDecimal(Math.PI) / 4));

            decimal lon = DecimalMath.Abs(pointA.longitude.GetLongitude() - pointB.longitude.GetLongitude());

            /*MessageBox.Show("Phi :" + phi+"\n"+
                "Lon :" + lon);*/

            return DecimalMath.Atan2(lon, phi);
            //return -1;
        }

        /*This method calculate the difference of time from two Points, it is usefull for calculate the Speed*/
        public static decimal CalculateTimeDifference(Point pointA, Point pointB)
        {
           return Math.Abs(Convert.ToDecimal(pointA.dateTime.Subtract(pointB.dateTime).TotalHours));
        }

        /*This method calculate the difference of altitude from two Points*/
        public static int ? CalculateAltitudeDifference(Point pointA, Point pointB)
        {
            if (pointA.altitude == null || pointB.altitude == null)
            {
                return null;
            }

            return Math.Abs(pointA.altitude.Value - pointB.altitude.Value);
        }

        /*This method implement this formula:
         Speed= space/time  */
        public static decimal CalculateSpeed(Point pointA, Point pointB)
        {
            return(CalculateDistance(pointA, pointB)) / CalculateTimeDifference(pointA, pointB);
        }

    }
}
