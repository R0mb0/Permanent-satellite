using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace SatellitePermanente.LogicAndMath
{
    class DatabaseWithRescue: Database
    {
        /*create a base database that will be serialized*/
        private static OriginDatabase database;

        /*Class for Singelton*/
        private static DatabaseWithRescue istance = null;

        /*Builder*/
        protected DatabaseWithRescue()
        {
            database = new OriginDatabase();/*create a new base database to salve into a file*/
           
        }

        /*Method for Singleton*/
        public static DatabaseWithRescue Istance()
        {
            if (istance == null)
            {
                istance = new DatabaseWithRescue();
            }

            return istance; 
        }

        public Boolean SaveDatabase()
        {
            /*set the database vcalues to salve*/
            database.pointList = base.pointList;
            database.nodeList = base.nodeList;
            database.maxLatitude = base.maxLatitude;
            database.minLatitude = base.minLatitude;
            database.maxLongitude = base.maxLongitude;
            database.minLongitude = base.minLongitude;

            String json = JsonConvert.SerializeObject(database);/*serialize the satabase*/
            System.IO.File.WriteAllText("Database.txt", json);/*writing od the serialized database*/

            return File.Exists("Database.txt");/*Return true if the file realy exist*/
        }

        public Boolean LoadDatabase()
        {
            if (File.Exists("Database.txt"))
            {
                String json = File.ReadAllText("Database.txt");/*read the file created*/
                database = JsonConvert.DeserializeObject<OriginDatabase>(json);/*deserialize the salved database*/

                if (database.pointList.Count >0)/*if exist loaded values*/
                {
                    /*when the databse is loaded the state is not in first run*/
                    base.firstRun = false;

                    /*in case of there are other point into the list that arent linked with the database value*/
                    base.pointList.Clear();
                    base.nodeList.Clear();

                    /*setting the value loaded into the effective database*/
                    base.nodeList = database.nodeList;
                    base.maxLatitude = database.maxLatitude;
                    base.minLatitude = database.minLatitude;
                    base.maxLongitude = database.maxLongitude;
                    base.minLongitude = database.minLongitude;

                    /*in this method is possible to use the list method : last()*/
                    database.pointList.ForEach(delegate (Point myPoint) 
                    {
                        if (myPoint.meetingPoint)
                        {
                            base.meetingPoint = myPoint;
                            base.flagMeetingPoint = true;
                        }

                        base.pointList.Add(myPoint);
                    });

                    return true;
                }
            }

            return false;
        }

    }
}
