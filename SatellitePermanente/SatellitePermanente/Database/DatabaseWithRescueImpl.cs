using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace SatellitePermanente.LogicAndMath
{
    class DatabaseWithRescueImpl: DatabaseImpl,DatabaseWithRescue
    {
        private OriginDatabase database { get; set; }

        /*Builder*/
        public DatabaseWithRescueImpl()
        {
            this.database = new OriginDatabaseImpl();/*create a new base database to salve into a file*/
           
        }

        public Boolean SaveDatabase()
        {
            /*set the base database*/
            this.database.pointList = base.pointList;
            this.database.nodeList = base.nodeList;

            String json = JsonConvert.SerializeObject(this.database);/*serialize the satabase*/
            System.IO.File.WriteAllText("Database.txt", json);/*writing od the serialized database*/

            return File.Exists("Database.txt");/*Return true if the file realy exist*/
        }

        public Boolean LoadDatabase()
        {
            if (File.Exists("Database.txt"))
            {
                String json = File.ReadAllText("Database.txt");/*read the file created*/
                this.database = JsonConvert.DeserializeObject<OriginDatabaseImpl>(json);/*deserialize the salved database*/

                if (this.database.pointList.Count >0)/*if exist loaded values*/
                {
                    base.pointList = this.database.pointList;
                    base.nodeList = this.database.nodeList;
                    return true;
                }
            }

            return false;
        }

    }
}
