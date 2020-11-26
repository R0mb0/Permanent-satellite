using SatellitePermanente.Database;
using SatellitePermanente.LogicAndMath;
using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente.GUI.GrayMapUtility
{
    class ConvertToGraphic
    {
        /*private fields*/
        private readonly int Y,X;
        public MaxCoordinates extremeCoordinates { get; private set; }

        public ConvertToGraphic(int Y, int X, MaxCoordinates coordinates)
        {
            this.Y = Y;
            this.X = X;
            GetExtremes(coordinates);
        }

        private void GetExtremes(MaxCoordinates coordinates)
        {
            /*get the latitude extremes*/
            if (coordinates.maxLatitude.sign.Equals(coordinates.minLatitude.sign))
            {
                if(coordinates.maxLatitude.degrees == coordinates.minLatitude.degrees)
                {
                    if(coordinates.maxLatitude.prime == coordinates.minLatitude.prime)
                    {
                        try
                        {
                            extremeCoordinates.maxLatitude = new Latitude(coordinates.maxLatitude.sign, coordinates.maxLatitude.degrees, coordinates.maxLatitude.prime +1,0000); 
                        }
                        catch (ArgumentException)
                        {
                            extremeCoordinates.maxLatitude = new Latitude(coordinates.maxLatitude.sign, coordinates.maxLatitude.degrees+1, 00, 0000);
                        }

                            extremeCoordinates.minLatitude = new Latitude(coordinates.minLatitude.sign, coordinates.minLatitude.degrees, coordinates.minLatitude.prime, 0000);
                        
                    }
                    else
                    {
                        try
                        {
                            extremeCoordinates.maxLatitude = new Latitude(coordinates.maxLatitude.sign, coordinates.maxLatitude.degrees, coordinates.maxLatitude.prime +1, 0000); 
                        }
                        catch(ArgumentException)
                        {
                            extremeCoordinates.maxLatitude = new Latitude(coordinates.maxLatitude.sign, coordinates.maxLatitude.degrees +1, 00, 0000);
                        }


                        try
                        {
                            extremeCoordinates.minLatitude = new Latitude(coordinates.minLatitude.sign, coordinates.minLatitude.degrees, coordinates.minLatitude.prime - 1, 0000);
                        }
                        catch (ArgumentException)
                        {
                            extremeCoordinates.minLatitude = new Latitude(coordinates.minLatitude.sign, coordinates.minLatitude.degrees -1, 00, 0000);
                        }

                    }
                }
                else
                {
                    try
                    {
                        extremeCoordinates.maxLatitude = new Latitude(coordinates.maxLatitude.sign, coordinates.maxLatitude.degrees +1, 00, 0000);
                    }
                    catch (ArgumentException)
                    {
                        extremeCoordinates.maxLatitude = new Latitude(coordinates.maxLatitude.sign, coordinates.maxLatitude.degrees, 00, 0000);
                    }

                    try
                    {
                        extremeCoordinates.minLatitude = new Latitude(coordinates.minLatitude.sign, coordinates.minLatitude.degrees - 1, 00, 0000);
                    }
                    catch (ArgumentException)
                    {
                        extremeCoordinates.minLatitude = new Latitude(coordinates.minLatitude.sign, coordinates.minLatitude.degrees, 00, 0000);
                    }
                }
            }
            else
            {
                try
                {
                    extremeCoordinates.maxLatitude = new Latitude(coordinates.maxLatitude.sign, coordinates.maxLatitude.degrees +1, 00, 0000);
                }
                catch(ArgumentException)
                {
                    extremeCoordinates.maxLatitude = new Latitude(coordinates.maxLatitude.sign, coordinates.maxLatitude.degrees, 00, 0000);
                }

                extremeCoordinates.minLatitude = new Latitude(coordinates.minLatitude.sign, coordinates.minLatitude.degrees, 00, 0000); 
            }


            /*get the longitude extremes*/
            if (coordinates.maxLongitude.sign.Equals(coordinates.minLongitude.sign))
            {
                if (coordinates.maxLongitude.degrees == coordinates.minLongitude.degrees)
                {
                    if (coordinates.maxLongitude.prime == coordinates.minLongitude.prime)
                    {
                        try
                        {
                            extremeCoordinates.maxLongitude = new Longitude(coordinates.maxLatitude.sign, coordinates.maxLatitude.degrees, coordinates.maxLatitude.prime + 1, 0000);
                        }
                        catch (ArgumentException)
                        {
                            extremeCoordinates.maxLongitude = new Longitude(coordinates.maxLongitude.sign, coordinates.maxLongitude.degrees + 1, 00, 0000);
                        }

                        extremeCoordinates.minLongitude = new Longitude(coordinates.minLongitude.sign, coordinates.minLongitude.degrees, coordinates.minLongitude.prime, 0000);

                    }
                    else
                    {
                        try
                        {
                            extremeCoordinates.maxLongitude = new Longitude(coordinates.maxLongitude.sign, coordinates.maxLongitude.degrees, coordinates.maxLongitude.prime + 1, 0000);
                        }
                        catch (ArgumentException)
                        {
                            extremeCoordinates.maxLongitude = new Longitude(coordinates.maxLongitude.sign, coordinates.maxLongitude.degrees + 1, 00, 0000);
                        }


                        try
                        {
                            extremeCoordinates.minLongitude = new Longitude(coordinates.minLongitude.sign, coordinates.minLongitude.degrees, coordinates.minLongitude.prime - 1, 0000);
                        }
                        catch (ArgumentException)
                        {
                            extremeCoordinates.minLongitude = new Longitude(coordinates.minLongitude.sign, coordinates.minLongitude.degrees - 1, 00, 0000);
                        }

                    }
                }
                else
                {
                    try
                    {
                        extremeCoordinates.maxLongitude = new Longitude(coordinates.maxLongitude.sign, coordinates.maxLongitude.degrees + 1, 00, 0000);
                    }
                    catch (ArgumentException)
                    {
                        extremeCoordinates.maxLongitude = new Longitude(coordinates.maxLongitude.sign, coordinates.maxLongitude.degrees, 00, 0000);
                    }

                    try
                    {
                        extremeCoordinates.minLongitude = new Longitude(coordinates.minLongitude.sign, coordinates.minLongitude.degrees - 1, 00, 0000);
                    }
                    catch (ArgumentException)
                    {
                        extremeCoordinates.minLongitude = new Longitude(coordinates.minLongitude.sign, coordinates.minLongitude.degrees, 00, 0000);
                    }
                }
            }
            else
            {
                try
                {
                    extremeCoordinates.maxLongitude = new Longitude(coordinates.maxLongitude.sign, coordinates.maxLongitude.degrees + 1, 00, 0000);
                }
                catch (ArgumentException)
                {
                    extremeCoordinates.maxLongitude = new Longitude(coordinates.maxLongitude.sign, coordinates.maxLongitude.degrees, 00, 0000);
                }

                extremeCoordinates.minLongitude = new Longitude(coordinates.minLongitude.sign, coordinates.minLongitude.degrees, 00, 0000);
            }

        }


        



    }
}
