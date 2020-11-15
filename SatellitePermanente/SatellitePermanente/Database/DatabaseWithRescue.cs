using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente.LogicAndMath
{
    interface DatabaseWithRescue: Database
    {
        public Boolean SaveDatabase();

        public Boolean LoadDatabase();
       
    }
}
