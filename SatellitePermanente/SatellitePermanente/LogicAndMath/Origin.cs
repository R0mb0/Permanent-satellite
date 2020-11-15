using System;
using System.Collections.Generic;
using System.Text;

/*Interface of Origin Class, this Class in usefull to shape a short of standar Point of detecion in DMS format*/

namespace SatellitePermanente
{
    interface Origin
    {
        /*Sign = 'N' 'E' 'S' 'O'*/
        public String sign { get; }

        public int degrees { get; }

        public int prime { get; }

        public decimal latter { get; }

        public String GetString();

    }
}
