using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente.LogicAndMath
{
    /*This Interfare shape a Node form two Point. For working the associate class use Utility Class*/
    interface Node
    {
        public Point pointA { get; }
        public Point pointB { get; }

        /*Property of the node*/

        public decimal GetDistance();

        public decimal GetDirection();

        public TimeSpan GetTimeDiffrence();

        public decimal GetSpeed();

        public int? GetAltitudeDifference();
    }
}
