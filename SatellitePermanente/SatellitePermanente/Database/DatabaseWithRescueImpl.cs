using Newtonsoft.Json;
using SatellitePermanente.Database;
using SatellitePermanente.Observer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace SatellitePermanente.LogicAndMath
{
    class DatabaseWithRescueImpl: DatabaseWithRescue
    {
        /*create a base database that will be serialized*/
        private Rescue rescue;

        /*Salve the status of the primary class*/
        private static NormalDatabaseImpl database;

        /*private istance*/
        private static DatabaseWithRescueImpl istance = null;

        /*Builder*/
        private DatabaseWithRescueImpl(NormalDatabaseImpl d)
        {
            database = d;
        }

        /*get istance*/
        public static DatabaseWithRescueImpl GetIstance()
        {
            if(istance == null)
            {
                istance = new DatabaseWithRescueImpl(NormalDatabaseImpl.GetIstance());
            }

            return istance;
        }

        public override Boolean SaveDatabase()
        {
            /*set the database values to salve*/
           this.rescue = new Rescue(database.GetPointList(), database.GetNodeList(), database.GetMaxLatitude(), database.GetMinLatitude(), database.GetMaxLongitude(), database.GetMinLongitude());


            String json = JsonConvert.SerializeObject(this.rescue);/*serialize the satabase*/
            System.IO.File.WriteAllText("Database.txt", json);/*writing od the serialized database*/

            return File.Exists("Database.txt");/*Return true if the file realy exist*/
        }

        public override Boolean LoadDatabase()
        {
            if (File.Exists("Database.txt"))
            {
                String json = File.ReadAllText("Database.txt");/*read the file created*/
                this.rescue = JsonConvert.DeserializeObject<Rescue>(json);/*deserialize the salved database*/

                

                if (this.rescue.pointList.Count >0)/*if exist loaded values*/
                {
                    /*when the databse is loaded the state is not in first run*/
                    database.firstRun = false;

                    /*in case of there are other point into the list that arent linked with the database value*/
                    database.GetPointList().Clear();
                    database.GetNodeList().Clear();

                    /*setting the value loaded into the effective database*/
                    database.SetNodeList(this.rescue.nodeList);
                    database.SetMaxLatitude(this.rescue.maxLatitude);
                    database.SetMinLatitude(this.rescue.minLatitude);
                    database.SetMaxLongitude(this.rescue.maxLongitude);
                    database.SetMinLongitude(this.rescue.minLongitude);

                    /*in this method is possible to use the list method : last()*/
                    this.rescue.pointList.ForEach(delegate (Point myPoint) 
                    {
                        if (myPoint.meetingPoint)
                        {
                            database.meetingPoint = myPoint;
                            database.flagMeetingPoint = true;
                        }

                        database.GetPointList().Add(myPoint);
                    });

                    /*Update the observer*/ 
                    DatabaseObserver.Update();

                    return true;
                }
            }

            return false;
        }

        /*---------------------------------------------Implement the abstract methods-------------------------------------------------------------*/
        public override List<Node> GetLastNodeAdded()
        {
            return database.GetLastNodeAdded();
        }

        public override List<Node> GetLastNodeDelected()
        {
            return database.GetLastNodeDelected();
        }

        public override bool AddPoint(Point point)
        {
            return database.AddPoint(point);
        }

        public override bool DelettePoint(Point point)
        {
            return database.DelettePoint(point);
        }

        public override bool DeletePointFromIndex(int index)
        {
            return database.DeletePointFromIndex(index);
        }

        public override List<Point> GetPointList()
        {
            return database.GetPointList();
        }

        public override List<Node> GetNodeList()
        {
            return database.GetNodeList();
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
            database.SetPointList(pointList);
        }

        public override void SetNodeList(List<Node> nodeList)
        {
            database.SetNodeList(nodeList);
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
