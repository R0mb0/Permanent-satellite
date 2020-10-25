using System;
using System.Collections.Generic;
using System.Text;

/*Interface of Origin Class, this Class in usefull to shape a short of standar Point of detecion in DMS format*/

namespace SatellitePermanente
{
    interface Origin
    {
        /*Sign = 'N' 'E' 'S' 'O'*/
        public char GetSign();

        public int GetDegrees();

        public int GetPrime();

        public decimal GetLatter();
 
        public String GetString();

    }
}
