using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente.LogicAndMath
{
    /*This class shape a Node from two Point*/
     class Node
    {
        /*Fields*/
        public Point pointA { get; }
        public Point pointB { get; }

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

        public string GetDistanceString()
        {
            return Math.Round(GetDistance(), 2) + "Km";
        }

        public decimal GetDirection()
        {
            return Utility.CalculateDirection(this.pointA, this.pointB);
        }

        public string GetDirectionString()
        {
            return Math.Round(GetDirection(), 2) + "°";
        }

        public decimal GetTimeDifference()
        {
            return Utility.CalculateTimeDifference(this.pointA, this.pointB);
        }

        public string GetTimeDifferenceString()
        {
            return Math.Round(GetTimeDifference(), 2) + "h";
        }

        public decimal GetSpeed()
        {
            return Utility.CalculateSpeed(this.pointA, this.pointB);
        }

        public string GetSpeedString()
        {
            return Math.Round(GetSpeed(), 2) + "Km/h";
        }

        public int? GetAltitudeDifference()
        {
            return Utility.CalculateAltitudeDifference(this.pointA, this.pointB);
        }

        public string GetAltitudeDifferenceString()
        {
            return GetAltitudeDifference() + "m";
        }

        public string GetNodeString()
        {
            return GetDistanceString() + "\n" + GetDirectionString();
        }
    }
}
