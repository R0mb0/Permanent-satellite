using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente
{
    /*Interface of Longitude that extend Origin Inteface. For working the associate class use Utility Class*/
    interface Longitude : Origin
    {
        /*Return the raw data, usefull for the elaboration, in DMS mode*/
        public decimal GetLongitude(); 
    }
}
