using SatellitePermanente.Database;
using SatellitePermanente.LogicAndMath;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

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
           // extremeCoordinates = new MaxCoordinates();


        }

        private void GetExtremes(MaxCoordinates coordinates)
        {

            Latitude maxLatitude;
            Latitude minLatitude;
            Longitude maxLongitude;
            Longitude minLongitude;

            /*get the latitude extremes*/
            if (coordinates.maxLatitude.sign.Equals(coordinates.minLatitude.sign))
            {
                if(coordinates.maxLatitude.degrees == coordinates.minLatitude.degrees)
                {
                    if(coordinates.maxLatitude.prime == coordinates.minLatitude.prime)
                    {
                        try
                        {
                            maxLatitude = new Latitude(coordinates.maxLatitude.sign, coordinates.maxLatitude.degrees, coordinates.maxLatitude.prime + 1, 0000); 
                        }
                        catch (ArgumentException)
                        {
                            maxLatitude = new Latitude(coordinates.maxLatitude.sign, coordinates.maxLatitude.degrees+1, 00, 0000);
                        }

                            minLatitude = new Latitude(coordinates.minLatitude.sign, coordinates.minLatitude.degrees, coordinates.minLatitude.prime, 0000);
                        
                    }
                    else
                    {
                        try
                        {
                            maxLatitude = new Latitude(coordinates.maxLatitude.sign, coordinates.maxLatitude.degrees, coordinates.maxLatitude.prime +1, 0000); 
                        }
                        catch(ArgumentException)
                        {
                            maxLatitude = new Latitude(coordinates.maxLatitude.sign, coordinates.maxLatitude.degrees +1, 00, 0000);
                        }


                        try
                        {
                            minLatitude = new Latitude(coordinates.minLatitude.sign, coordinates.minLatitude.degrees, coordinates.minLatitude.prime - 1, 0000);
                        }
                        catch (ArgumentException)
                        {
                            minLatitude = new Latitude(coordinates.minLatitude.sign, coordinates.minLatitude.degrees -1, 00, 0000);
                        }

                    }
                }
                else
                {
                    try
                    {
                        maxLatitude = new Latitude(coordinates.maxLatitude.sign, coordinates.maxLatitude.degrees +1, 00, 0000);
                    }
                    catch (ArgumentException)
                    {
                        maxLatitude = new Latitude(coordinates.maxLatitude.sign, coordinates.maxLatitude.degrees, 00, 0000);
                    }

                    try
                    {
                       minLatitude = new Latitude(coordinates.minLatitude.sign, coordinates.minLatitude.degrees - 1, 00, 0000);
                    }
                    catch (ArgumentException)
                    {
                        minLatitude = new Latitude(coordinates.minLatitude.sign, coordinates.minLatitude.degrees, 00, 0000);
                    }
                }
            }
            else
            {
                try
                {
                    maxLatitude = new Latitude(coordinates.maxLatitude.sign, coordinates.maxLatitude.degrees +1, 00, 0000);
                }
                catch(ArgumentException)
                {
                    maxLatitude = new Latitude(coordinates.maxLatitude.sign, coordinates.maxLatitude.degrees, 00, 0000);
                }

                minLatitude = new Latitude(coordinates.minLatitude.sign, coordinates.minLatitude.degrees, 00, 0000); 
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
                            maxLongitude = new Longitude(coordinates.maxLongitude.sign, coordinates.maxLongitude.degrees, coordinates.maxLongitude.prime + 1, 0000);
                        }
                        catch (ArgumentException)
                        {
                            maxLongitude = new Longitude(coordinates.maxLongitude.sign, coordinates.maxLongitude.degrees + 1, 00, 0000);
                            MessageBox.Show("Intercettato un errore");
                        }

                        minLongitude = new Longitude(coordinates.minLongitude.sign, coordinates.minLongitude.degrees, coordinates.minLongitude.prime, 0000);

                    }
                    else
                    {
                        try
                        {
                            maxLongitude = new Longitude(coordinates.maxLongitude.sign, coordinates.maxLongitude.degrees, coordinates.maxLongitude.prime + 1, 0000);
                        }
                        catch (ArgumentException)
                        {
                            maxLongitude = new Longitude(coordinates.maxLongitude.sign, coordinates.maxLongitude.degrees + 1, 00, 0000);
                        }


                        try
                        {
                            minLongitude = new Longitude(coordinates.minLongitude.sign, coordinates.minLongitude.degrees, coordinates.minLongitude.prime - 1, 0000);
                        }
                        catch (ArgumentException)
                        {
                            minLongitude = new Longitude(coordinates.minLongitude.sign, coordinates.minLongitude.degrees - 1, 00, 0000);
                        }

                    }
                }
                else
                {
                    try
                    {
                        maxLongitude = new Longitude(coordinates.maxLongitude.sign, coordinates.maxLongitude.degrees + 1, 00, 0000);
                    }
                    catch (ArgumentException)
                    {
                        maxLongitude = new Longitude(coordinates.maxLongitude.sign, coordinates.maxLongitude.degrees, 00, 0000);
                    }

                    try
                    {
                        minLongitude = new Longitude(coordinates.minLongitude.sign, coordinates.minLongitude.degrees - 1, 00, 0000);
                    }
                    catch (ArgumentException)
                    {
                        minLongitude = new Longitude(coordinates.minLongitude.sign, coordinates.minLongitude.degrees, 00, 0000);
                    }
                }
            }
            else
            {
                try
                {
                    maxLongitude = new Longitude(coordinates.maxLongitude.sign, coordinates.maxLongitude.degrees + 1, 00, 0000);
                }
                catch (ArgumentException)
                {
                    maxLongitude = new Longitude(coordinates.maxLongitude.sign, coordinates.maxLongitude.degrees, 00, 0000);
                }

                minLongitude = new Longitude(coordinates.minLongitude.sign, coordinates.minLongitude.degrees, 00, 0000);
            }

            this.extremeCoordinates = new MaxCoordinates();
            this.extremeCoordinates.maxLatitude = maxLatitude;
            this.extremeCoordinates.minLatitude = minLatitude;
            this.extremeCoordinates.maxLongitude = maxLongitude;
            this.extremeCoordinates.minLongitude = minLongitude;

        }


        



    }
}
