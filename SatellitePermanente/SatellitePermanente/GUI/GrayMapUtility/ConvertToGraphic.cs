using SatellitePermanente.Database;
using SatellitePermanente.LogicAndMath;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SatellitePermanente.GUI.GrayMapUtility
{
    /*this class is usfell for convert the decimal coordinates in pixel coordinates, in way to draw the figures*/
    class ConvertToGraphic
    {
        /*private fields*/
        private readonly decimal Y,X;
        /*ΔLat*/
        public decimal DLat { get; private set; }
        /*ΔLon*/
        public decimal DLon { get; private set; }

        /*this are the extreme values elaborated for the GrayMap zoom, because thia values change an every adding point, in way to rappresent a place in scale*/
        public MaxCoordinates extremeCoordinates { get; private set; }

        /*builder*/
        public ConvertToGraphic(int Y, int X, MaxCoordinates coordinates)
        {
            this.Y = Y;
            this.X = X;
            GetExtremes(coordinates);
           
        }
        
        /*this method return the elaborated extremes*/
        private void GetExtremes(MaxCoordinates coordinates)
        {
            /*private filed to inizialize the max coordinates */
            Latitude maxLatitude;
            Latitude minLatitude;
            Longitude maxLongitude;
            Longitude minLongitude;

            /*definiction of the filter*/

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


            /*Time to inizialize the MaxCoordinates with the elaborated values*/
            this.extremeCoordinates = new MaxCoordinates();
            this.extremeCoordinates.maxLatitude = maxLatitude;
            this.extremeCoordinates.minLatitude = minLatitude;
            this.extremeCoordinates.maxLongitude = maxLongitude;
            this.extremeCoordinates.minLongitude = minLongitude;

        }

        /*this method convert a latitude/longitude poiont into a grahpical point, ready to be drawed*/
        public System.Drawing.Point GetDrawingPoint(LogicAndMath.Point point)
        {
            /*ΔLat*/
            DLat = extremeCoordinates.maxLatitude.GetLatitude() - extremeCoordinates.minLatitude.GetLatitude();

            /*ΔLon*/
           DLon = extremeCoordinates.maxLongitude.GetLongitude() - extremeCoordinates.minLongitude.GetLongitude();

            System.Drawing.Point drawPoint = new System.Drawing.Point();

            /*return the decimal coordinate in pixel coordinate -> using a drawing point*/

            drawPoint.X = Convert.ToInt32((point.longitude.GetLongitude() - extremeCoordinates.minLongitude.GetLongitude()) * (this.X / this.DLon));
            drawPoint.Y = Convert.ToInt32((point.latitude.GetLatitude() - extremeCoordinates.minLatitude.GetLatitude()) * (this.Y / this.DLat));

            return drawPoint;
        }

    }
}
