using SatellitePermanente.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente.LogicAndMath
{
    /*this is the base class to build the database, in fact it conteins the most important fields that must be saved into a file. 
     * (there are other values that going to be salved, because in this way there aren`t much count to do)*/
    class OriginDatabase: MaxCoordinates
    {
        /*Fields*/
        public List<Point> pointList { get; set; }

        public List<Node> nodeList { get; set; }

        /*Builder*/
        public OriginDatabase()
        {
            this.pointList = new List<Point>();
            this.nodeList = new List<Node>();
        }
    }
}
