

using System;

static class DefaultValueBridge 
{ 
    public static String? latitudeSign { get; set; }
    public static int? latitudeDegree { get; set; }
    public static int? latitudePrime { get; set; }
    public static decimal? latitudeLatter { get; set; }

    public static String? longitudeSign { get; set; }
    public static int? longitudeDegree { get; set; }
    public static int? longitudePrime { get; set; }
    public static decimal? longitudeLatter { get; set; }

    public static bool checkAngle { get; set; }
    public static int? angle { get; set; }

    public static bool checkAltitude { get; set; }
    public static int? altitude { get; set; }


    public static void ResetValue()
    {
        latitudeSign = null;
        latitudePrime = null;
        latitudeLatter = null;
        latitudeDegree = null;

        longitudeSign = null;
        longitudePrime = null;
        longitudeLatter = null;
        longitudeDegree = null;

        checkAngle = false;
        angle = null;

        checkAltitude = false;
        altitude = null;
    }


}
