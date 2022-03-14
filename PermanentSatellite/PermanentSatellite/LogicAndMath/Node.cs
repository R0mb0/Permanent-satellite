using System;
using System.Collections.Generic;
using System.Text;

namespace PermanentSatellite.LogicAndMath
{
    /*This class shape a Node from two Point*/
     class Node
    {
        /*Fields*/
        public Point pointA { get; private set; }
        public Point pointB { get; private set; }

        public Node(Point pointA, Point pointB)
        {
            this.pointA = pointA;
            this.pointB = pointB;
        }

        
        /*Get Property of nodes*/
        public decimal GetDistance()
        {
            return Utility.CalculateDistance(this.pointA, this.pointB);
        }

        /*Get the distance in string way, ready to be printed into GrayMap*/
        public string GetDistanceString()
        {
            return Math.Round(GetDistance(), 2) + "Km";
        }

        public decimal GetDirection1()
        {
            return Utility.CalculateDirection1(this.pointA, this.pointB);
        }

        public decimal GetDirection2()
        {
            return Utility.CalculateDirection2(this.pointA, this.pointB);
        }

        /*Get the direction in string way, ready to be printed into GrayMap*/
        public string GetDirection1String()
        {
            return Math.Round(GetDirection1(), 2) + "°";
        }

        public string GetDirection2String()
        {
            return Math.Round(GetDirection2(), 2) + "°";
        }

        public decimal GetTimeDifference()
        {
            return Utility.CalculateTimeDifference(this.pointA, this.pointB);
        }
        /*Get the time difference in string way, ready to be printed into GrayMap*/
        public string GetTimeDifferenceString()
        {
            return Math.Round(GetTimeDifference(), 2) + "h";
        }

        public decimal GetSpeed()
        {
            return Utility.CalculateSpeed(this.pointA, this.pointB);
        }

        /*Get the speed in string way, ready to be printed into GrayMap*/
        public string GetSpeedString()
        {
            return Math.Round(GetSpeed(), 2) + "Km/h";
        }

        public int? GetAltitudeDifference()
        {
            return Utility.CalculateAltitudeDifference(this.pointA, this.pointB);
        }

        /*if the altitude difference exist, get the altitude difference in string way, ready to be printed into GrayMap*/
        public string GetAltitudeDifferenceString()
        {
            return GetAltitudeDifference() + "m";
        }

        /*this method return the corect long string deeping on the registred values*/
        public string GetNodeString()
        {
            if(GetAltitudeDifference() != null)
            {
                return GetDistanceString() + "\n" + GetDirection1String() + "\n" + GetDirection2String() + "\n" + GetTimeDifferenceString() + "\n" + GetSpeedString() + "\n" + GetAltitudeDifferenceString();
            }


            return GetDistanceString() + "\n" + GetDirection1String() + "\n" + GetDirection2String() + "\n" + GetTimeDifferenceString() + "\n" + GetSpeedString();
        }
    }
}
