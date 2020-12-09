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

            /*ΔLat*/
            DLat = extremeCoordinates.GetMaxLatitude().GetLatitude() - extremeCoordinates.GetMinLatitude().GetLatitude();

            /*ΔLon*/
            DLon = extremeCoordinates.GetMaxLongitude().GetLongitude() - extremeCoordinates.GetMinLongitude().GetLongitude();


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
            if (coordinates.GetMaxLatitude().sign.Equals(coordinates.GetMinLatitude().sign))
            {
                if(coordinates.GetMaxLatitude().degrees == coordinates.GetMinLatitude().degrees)
                {
                    if(coordinates.GetMaxLatitude().prime == coordinates.GetMinLatitude().prime)
                    {
                        try
                        {
                            maxLatitude = new Latitude(coordinates.GetMaxLatitude().sign, coordinates.GetMaxLatitude().degrees, coordinates.GetMaxLatitude().prime + 1, 0000); 
                        }
                        catch (ArgumentException)
                        {
                            maxLatitude = new Latitude(coordinates.GetMaxLatitude().sign, coordinates.GetMaxLatitude().degrees+1, 00, 0000);
                        }

                            minLatitude = new Latitude(coordinates.GetMinLatitude().sign, coordinates.GetMinLatitude().degrees, coordinates.GetMinLatitude().prime, 0000);
                        
                    }
                    else
                    {
                        try
                        {
                            maxLatitude = new Latitude(coordinates.GetMaxLatitude().sign, coordinates.GetMaxLatitude().degrees, coordinates.GetMaxLatitude().prime +1, 0000); 
                        }
                        catch(ArgumentException)
                        {
                            maxLatitude = new Latitude(coordinates.GetMaxLatitude().sign, coordinates.GetMaxLatitude().degrees +1, 00, 0000);
                        }


                        try
                        {
                            minLatitude = new Latitude(coordinates.GetMinLatitude().sign, coordinates.GetMinLatitude().degrees, coordinates.GetMinLatitude().prime - 1, 0000);
                        }
                        catch (ArgumentException)
                        {
                            minLatitude = new Latitude(coordinates.GetMinLatitude().sign, coordinates.GetMinLatitude().degrees -1, 00, 0000);
                        }

                    }
                }
                else
                {
                    try
                    {
                        maxLatitude = new Latitude(coordinates.GetMaxLatitude().sign, coordinates.GetMaxLatitude().degrees +1, 00, 0000);
                    }
                    catch (ArgumentException)
                    {
                        maxLatitude = new Latitude(coordinates.GetMaxLatitude().sign, coordinates.GetMaxLatitude().degrees, 00, 0000);
                    }

                    try
                    {
                       minLatitude = new Latitude(coordinates.GetMinLatitude().sign, coordinates.GetMinLatitude().degrees - 1, 00, 0000);
                    }
                    catch (ArgumentException)
                    {
                        minLatitude = new Latitude(coordinates.GetMinLatitude().sign, coordinates.GetMinLatitude().degrees, 00, 0000);
                    }
                }
            }
            else
            {
                try
                {
                    maxLatitude = new Latitude(coordinates.GetMaxLatitude().sign, coordinates.GetMaxLatitude().degrees +1, 00, 0000);
                }
                catch(ArgumentException)
                {
                    maxLatitude = new Latitude(coordinates.GetMaxLatitude().sign, coordinates.GetMaxLatitude().degrees, 00, 0000);
                }

                minLatitude = new Latitude(coordinates.GetMinLatitude().sign, coordinates.GetMinLatitude().degrees, 00, 0000); 
            }


            /*get the longitude extremes*/
            if (coordinates.GetMaxLongitude().sign.Equals(coordinates.GetMinLongitude().sign))
            {
                if (coordinates.GetMaxLongitude().degrees == coordinates.GetMinLongitude().degrees)
                {
                    if (coordinates.GetMaxLongitude().prime == coordinates.GetMinLongitude().prime)
                    {
                        try
                        {
                            maxLongitude = new Longitude(coordinates.GetMaxLongitude().sign, coordinates.GetMaxLongitude().degrees, coordinates.GetMaxLongitude().prime + 1, 0000);
                        }
                        catch (ArgumentException)
                        {
                            maxLongitude = new Longitude(coordinates.GetMaxLongitude().sign, coordinates.GetMaxLongitude().degrees + 1, 00, 0000);
                            MessageBox.Show("Intercettato un errore");
                        }

                        minLongitude = new Longitude(coordinates.GetMinLongitude().sign, coordinates.GetMinLongitude().degrees, coordinates.GetMinLongitude().prime, 0000);

                    }
                    else
                    {
                        try
                        {
                            maxLongitude = new Longitude(coordinates.GetMaxLongitude().sign, coordinates.GetMaxLongitude().degrees, coordinates.GetMaxLongitude().prime + 1, 0000);
                        }
                        catch (ArgumentException)
                        {
                            maxLongitude = new Longitude(coordinates.GetMaxLongitude().sign, coordinates.GetMaxLongitude().degrees + 1, 00, 0000);
                        }


                        try
                        {
                            minLongitude = new Longitude(coordinates.GetMinLongitude().sign, coordinates.GetMinLongitude().degrees, coordinates.GetMinLongitude().prime - 1, 0000);
                        }
                        catch (ArgumentException)
                        {
                            minLongitude = new Longitude(coordinates.GetMinLongitude().sign, coordinates.GetMinLongitude().degrees - 1, 00, 0000);
                        }

                    }
                }
                else
                {
                    try
                    {
                        maxLongitude = new Longitude(coordinates.GetMaxLongitude().sign, coordinates.GetMaxLongitude().degrees + 1, 00, 0000);
                    }
                    catch (ArgumentException)
                    {
                        maxLongitude = new Longitude(coordinates.GetMaxLongitude().sign, coordinates.GetMaxLongitude().degrees, 00, 0000);
                    }

                    try
                    {
                        minLongitude = new Longitude(coordinates.GetMinLongitude().sign, coordinates.GetMinLongitude().degrees - 1, 00, 0000);
                    }
                    catch (ArgumentException)
                    {
                        minLongitude = new Longitude(coordinates.GetMinLongitude().sign, coordinates.GetMinLongitude().degrees, 00, 0000);
                    }
                }
            }
            else
            {
                try
                {
                    maxLongitude = new Longitude(coordinates.GetMaxLongitude().sign, coordinates.GetMaxLongitude().degrees + 1, 00, 0000);
                }
                catch (ArgumentException)
                {
                    maxLongitude = new Longitude(coordinates.GetMaxLongitude().sign, coordinates.GetMaxLongitude().degrees, 00, 0000);
                }

                minLongitude = new Longitude(coordinates.GetMinLongitude().sign, coordinates.GetMinLongitude().degrees, 00, 0000);
            }


            /*Time to inizialize the MaxCoordinates with the elaborated values*/
            this.extremeCoordinates = new MaxCoordinatesImpl();
            this.extremeCoordinates.SetMaxLatitude(maxLatitude); 
            this.extremeCoordinates.SetMinLatitude(minLatitude);
            this.extremeCoordinates.SetMaxLongitude(maxLongitude);
            this.extremeCoordinates.SetMinLongitude(minLongitude);

        }

        /*this method convert a latitude/longitude poiont into a grahpical point, ready to be drawed*/
        public System.Drawing.Point GetDrawingPoint(LogicAndMath.Point point)
        {
           
            System.Drawing.Point drawPoint = new System.Drawing.Point();

            /*return the decimal coordinate in pixel coordinate -> using a drawing point*/

            drawPoint.X = Convert.ToInt32((point.longitude.GetLongitude() - extremeCoordinates.GetMinLongitude().GetLongitude()) * (this.X / this.DLon));
            drawPoint.Y = Convert.ToInt32((point.latitude.GetLatitude() - extremeCoordinates.GetMinLatitude().GetLatitude()) * (this.Y / this.DLat));

            return drawPoint;
        }

    }
}
