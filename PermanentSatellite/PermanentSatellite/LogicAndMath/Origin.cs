﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PermanentSatellite
{

    /*This Class in usefull to shape a short of standar Point of detecion in DMS format.
     This Class will be extended to Latitude Class and Longitude Class in way to specialize the coordinates*/

    public class Origin
    {
        /*Fields*/
        public String sign { get; private set; } /*Sign = 'N' 'E' 'S' 'O'*/

        public int degrees { get; private set; }

        public int prime { get; private set; }

        public decimal latter { get; private set; }

        /*Builder*/
        public Origin(String sign, int degrees, int prime, decimal latter)
        {
            this.sign = sign;
            this.degrees = degrees;
            this.prime = prime;
            this.latter = latter;
        }

        
        /*This method serves to print the coordinates salved in standard format*/
        public String GetString()
        {
            return Convert.ToString(this.sign) + " " + Convert.ToString(this.degrees) + "° " + Convert.ToString(this.prime) + "' " + Convert.ToString(this.latter) + "''";
        }
    }
}
