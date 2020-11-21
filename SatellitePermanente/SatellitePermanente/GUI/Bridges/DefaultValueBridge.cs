

using System;

static class DefaultValueBridge 
{ 
    /*This is anthoer bridge class the is usefull for passing vlaues fron two or more forms*/

    /*Fields*/
    public static bool controll { get; set; }
    /*--------------------------------------------------------------------------------------*/
    public static String? latitudeSign { get; set; }
    public static int? latitudeDegree { get; set; }
    public static int? latitudePrime { get; set; }
    public static decimal? latitudeLatter { get; set; }
    /*--------------------------------------------------------------------------------------*/
    public static String? longitudeSign { get; set; }
    public static int? longitudeDegree { get; set; }
    public static int? longitudePrime { get; set; }
    public static decimal? longitudeLatter { get; set; }
    /*--------------------------------------------------------------------------------------*/
    public static int? year { get; set; }
    public static int? month { get; set; }
    public static int? day { get; set; }
    public static int? hour { get; set; }
    public static int? minutes { get; set; }
    /*--------------------------------------------------------------------------------------*/
    public static bool checkAngle { get; set; }
    public static int? angle { get; set; }
    /*--------------------------------------------------------------------------------------*/
    public static bool checkAltitude { get; set; }
    public static int? altitude { get; set; }

    /*this method is usefull for reset the current values*/
    public static void ResetValue()
    {
        latitudeSign = null;
        latitudePrime = null;
        latitudeLatter = null;
        latitudeDegree = null;
        /*----------------------*/
        year = null;
        month = null;
        day = null;
        year = null;
        minutes = null;
        /*----------------------*/
        longitudeSign = null;
        longitudePrime = null;
        longitudeLatter = null;
        longitudeDegree = null;
        /*----------------------*/
        checkAngle = false;
        angle = null;
        /*----------------------*/
        checkAltitude = false;
        altitude = null;
    }


}
