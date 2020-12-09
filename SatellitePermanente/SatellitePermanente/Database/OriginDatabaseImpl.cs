using SatellitePermanente.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente.LogicAndMath
{
    /*this is the base class to build the database, in fact it conteins the most important fields that must be saved into a file. 
     * (there are other values that going to be salved, because in this way there aren`t much count to do)*/
    class OriginDatabaseImpl: OriginDatabase
    {        
        
        
        private static MaxCoordinatesImpl database;
        
        /*Builder*/
        public OriginDatabaseImpl( MaxCoordinatesImpl d)
        {
            database = d;

            this.pointList = new List<Point>();
            this.nodeList = new List<Node>();
        }


        /*Implementation of the abstract method*/
        public override List<Point> GetPointList()
        {
            return this.pointList;
        }


        public override List<Node> GetNodeList()
        {
            return this.nodeList;
        }

        public override Latitude GetMinLatitude()
        {
            return database.GetMinLatitude();
        }

        public override Latitude GetMaxLatitude()
        {
            return database.GetMaxLatitude();
        }

        public override Longitude GetMinLongitude()
        {
            return database.GetMinLongitude();
        }

        public override Longitude GetMaxLongitude()
        {
            return database.GetMaxLongitude();
        }

        public override void SetPointList(List<Point> pointList)
        {
            this.pointList = pointList;
        }

        public override void SetNodeList(List<Node> nodeList)
        {
            this.nodeList = nodeList;
        }

        public override void SetMinLatitude(Latitude minLatitude)
        {
            database.SetMinLatitude(minLatitude);
        }

        public override void SetMaxLatitude(Latitude maxLatitude)
        {
            database.SetMaxLatitude(maxLatitude);
        }

        public override void SetMinLongitude(Longitude minLongitude)
        {
            database.SetMinLongitude(minLongitude);
        }

        public override void SetMaxLongitude(Longitude maxLongitude)
        {
            database.SetMaxLongitude(maxLongitude);
        }
    }
}
