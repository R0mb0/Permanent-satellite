﻿using PermanentSatellite.Database;
using PermanentSatellite.LogicAndMath;

static class FormBridge
{
    /*This is a default class used for passing information between two (or more) forms*/
    public static PermanentSatellite.LogicAndMath.Point  returnPoint{ get; set;}
   
    public static int ? returnInteger { get; set; }
    public static bool ? retunrBoolean { get; set; }

    /*Simple method for return the GrayMapScreeen value to debug*/
    public static MaxCoordinates coordinates { get; set; }

    /*method for reset all class, in this program is not necessary, but it could be usefful in other contest*/
    public static void ResetValue()
    {
        returnPoint = null;
        returnInteger = null;
        retunrBoolean = null;
        coordinates = null;
    }
        
}
