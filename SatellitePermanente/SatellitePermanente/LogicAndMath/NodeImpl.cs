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
        private static readonly Utility util = new UtilityImpl();

        public NodeImpl(Point pointA, Point pointB)
        {
            this.pointA = pointA;
            this.pointB = pointB;
        }

        
        /*Get Property of nodes*/

        public decimal GetDistance()
        {
            return util.CalculateDistance(pointA, pointB);
        }

        public decimal GetDirection()
        {
            return util.CalculateDirection(pointA, pointB);
        }

        public TimeSpan GetTimeDiffrence()
        {
            return util.CalculateTimeDifference(pointA, pointB);
        }

        public decimal GetSpeed()
        {
            return util.CalculateSpeed(pointA, pointB);
        }

        public int? GetAltitudeDifference()
        {
            return util.CalculateAltitudeDifference(pointA, pointB);
        }
    }
}
