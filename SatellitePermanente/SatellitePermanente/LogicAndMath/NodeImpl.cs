using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente.LogicAndMath
{
    /*This class shape a Node from two Point*/
    class NodeImpl: Node
    {
        /*Fields*/
        public Point pointA { get; }
        public Point pointB { get; }

        public NodeImpl(Point pointA, Point pointB)
        {
            this.pointA = pointA;
            this.pointB = pointB;
        }

        
        /*Get Property of nodes*/

        public decimal GetDistance()
        {
            return Utility.CalculateDistance(pointA, pointB);
        }

        public decimal GetDirection()
        {
            return Utility.CalculateDirection(pointA, pointB);
        }

        public TimeSpan GetTimeDiffrence()
        {
            return Utility.CalculateTimeDifference(pointA, pointB);
        }

        public decimal GetSpeed()
        {
            return Utility.CalculateSpeed(pointA, pointB);
        }

        public int? GetAltitudeDifference()
        {
            return Utility.CalculateAltitudeDifference(pointA, pointB);
        }
    }
}
