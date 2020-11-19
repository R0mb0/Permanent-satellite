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

        public decimal GetDirection()
        {
            return Utility.CalculateDirection(this.pointA, this.pointB);
        }

        public decimal GetTimeDiffrence()
        {
            return Utility.CalculateTimeDifference(this.pointA, this.pointB);
        }

        public decimal GetSpeed()
        {
            return Utility.CalculateSpeed(this.pointA, this.pointB);
        }

        public int? GetAltitudeDifference()
        {
            return Utility.CalculateAltitudeDifference(this.pointA, this.pointB);
        }
    }
}
