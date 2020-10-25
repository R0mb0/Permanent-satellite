using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente.LogicAndMath
{
    /*Interface of Latitude Class that extend Origin Inteface. For working the associate class use Utility Class*/

    interface Latitude : Origin
    {
        /*Return the raw data, usefull for the elaboration, in DMS mode*/
        public decimal GetLatitude();
    }
}
