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

        /*This method convert a sexagesimal coordinate to decimal coordinate*/
        public static decimal ConvertToDecimal(Origin coordinate)
        {
            /*math operation to convert the value*/
            decimal temp = (coordinate.latter / 60);
            temp = temp + coordinate.prime;
            temp = (temp / 60);
            temp = temp + coordinate.degrees;

            /*controll of the sign of the values, usign the IT standard*/
            if (coordinate.sign.ToLower() == "o" || coordinate.sign.ToLower() == "s")
            {
                temp = (temp * (-1));
            }

            return temp;
        }

        /*This method convert a decimal coordinate to a sexagesimal coordinate*/
        public static Origin ConvertToSexagesimal(decimal coordinate)
        {
            int degrees = Convert.ToInt32(Math.Truncate(coordinate));

            decimal n = coordinate - degrees;
            n = n * 60;

            int prime = Convert.ToInt32(Math.Truncate(n));

            n = n - prime;
            n = n * 60;

            return new Origin("o", degrees, prime, n);
        }



        /*This method implement this formula, that is usefull to claculate the distance from two geographic points:
         distance (A,B) = R * arccos(sin(latA) * sin(latB) + cos(latA) * cos(latB) * cos(lonA-lonB))*/
        public static decimal CalculateDistance(Point pointA, Point pointB)
        {
            return (eartRadius * DecimalMath.Acos( DecimalMath.Sin(pointA.latitude.GetLatitude()) * DecimalMath.Sin(pointB.latitude.GetLatitude())
                + DecimalMath.Cos(pointA.latitude.GetLatitude()) * DecimalMath.Cos(pointB.latitude.GetLatitude())
                * DecimalMath.Cos(pointA.longitude.GetLongitude() - pointB.longitude.GetLongitude())));
        }

        /*This method implement this formula, that is usefull for calculate the direction from two geographic points:
         Δφ = ln( tan( latB / 2 + π / 4 ) / tan( latA / 2 + π / 4) ) 
         Δlon = abs( lonA - lonB ) 
         direction :  θ = atan2( Δlon ,  Δφ ) */
        public static decimal CalculateDirection(Point pointA, Point pointB)
        {
            decimal phi;
            decimal lon;

            /*protection the formula in case that appear the same latitude*/
            if (pointB.latitude.GetLatitude() == pointA.latitude.GetLatitude())
            {
                /*this is a arbitrary value (is the most small value that work with the final formula)*/
                phi = 0.000000000000001M;
            }
            else
            {
                phi= DecimalMath.Log(
                (DecimalMath.Tan(((pointB.latitude.GetLatitude() / 2) + Convert.ToDecimal(Math.PI)) / 4))
                / DecimalMath.Tan(((pointA.latitude.GetLatitude() / 2) + Convert.ToDecimal(Math.PI)) / 4));
            }

            /*protection the formula in case that appear the same longitude*/
            if (pointA.longitude.GetLongitude() == pointB.longitude.GetLongitude())
            {
                /*this is a arbitrary value (is the most small value that work with the final formula)*/
                lon = 0.000000000000001M;
            }
            else
            {
                lon = DecimalMath.Abs(pointA.longitude.GetLongitude() - pointB.longitude.GetLongitude());
            }

            return DecimalMath.Atan2(lon, phi);
           
        }

        /*This method calculate the difference of time from two Points, it is usefull for calculate the Speed*/
        public static decimal CalculateTimeDifference(Point pointA, Point pointB)
        {
           return Math.Abs(Convert.ToDecimal(pointA.dateTime.Subtract(pointB.dateTime).TotalHours));
        }

        /*This method calculate the difference of altitude from two Points*/
        public static int ? CalculateAltitudeDifference(Point pointA, Point pointB)
        {
            /*controll to verify the the points altitude exists*/
            if (pointA.altitude == null || pointB.altitude == null)
            {
                return null;
            }

            return Math.Abs(pointA.altitude.Value - pointB.altitude.Value);
        }

        /*This method implement this formula, that calculate the travel speed:
         Speed= space/time  */
        public static decimal CalculateSpeed(Point pointA, Point pointB)
        {
            return(CalculateDistance(pointA, pointB)) / CalculateTimeDifference(pointA, pointB);
        }

    }
}
