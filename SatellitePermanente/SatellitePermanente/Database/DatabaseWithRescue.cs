using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente.Database
{
    abstract class DatabaseWithRescue:NormalDatabase
    {
        public abstract Boolean SaveDatabase();

        public abstract Boolean LoadDatabase();
    }
}
