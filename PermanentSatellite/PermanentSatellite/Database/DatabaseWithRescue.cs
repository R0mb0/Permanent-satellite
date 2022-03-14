using System;
using System.Collections.Generic;
using System.Text;

namespace PermanentSatellite.Database
{
    abstract class DatabaseWithRescue:NormalDatabase
    {
        /*Public methods to load and salve the database.*/
        public abstract Boolean SaveDatabase();

        public abstract Boolean LoadDatabase();
    }
}
