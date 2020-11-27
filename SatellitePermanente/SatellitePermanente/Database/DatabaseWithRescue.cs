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
        private OriginDatabase database;

        /*Builder*/
        public DatabaseWithRescue()
        {
            this.database = new OriginDatabase();/*create a new base database to salve into a file*/
           
        }

        public Boolean SaveDatabase()
        {
            /*set the database to salve*/
            this.database.pointList = base.pointList;
            this.database.nodeList = base.nodeList;
            this.database.maxLatitude = base.maxLatitude;
            this.database.minLatitude = base.minLatitude;
            this.database.maxLongitude = base.maxLongitude;
            this.database.minLongitude = base.minLongitude;

            String json = JsonConvert.SerializeObject(this.database);/*serialize the satabase*/
            System.IO.File.WriteAllText("Database.txt", json);/*writing od the serialized database*/

            return File.Exists("Database.txt");/*Return true if the file realy exist*/
        }

        public Boolean LoadDatabase()
        {
            if (File.Exists("Database.txt"))
            {
                String json = File.ReadAllText("Database.txt");/*read the file created*/
                this.database = JsonConvert.DeserializeObject<OriginDatabase>(json);/*deserialize the salved database*/

                if (this.database.pointList.Count >0)/*if exist loaded values*/
                {
                    base.pointList = this.database.pointList;
                    base.nodeList = this.database.nodeList;
                    base.maxLatitude = this.database.maxLatitude;
                    base.minLatitude = this.database.minLatitude;
                    base.maxLongitude = this.database.maxLongitude;
                    base.minLongitude = this.database.minLongitude;

                    /*when the databse is loaded the state is not in first run*/
                    base.firstRun = false;

                    return true;
                }
            }

            return false;
        }

    }
}
