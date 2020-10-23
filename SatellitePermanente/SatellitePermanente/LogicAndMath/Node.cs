using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente.LogicAndMath
{
    interface Node
    {
        public decimal GetDistance();

        public decimal GetDirection();

        public TimeSpan GetTimeDiffrence();

        public decimal GetSpeed();

        public int? GetAltitudeDifference();
    }
}
