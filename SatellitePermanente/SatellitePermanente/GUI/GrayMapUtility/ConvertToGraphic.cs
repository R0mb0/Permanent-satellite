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
        public ConvertToGraphic(int X, int Y, MaxCoordinates coordinates)
        {
            this.Y = Y;
            this.X = X;
            GetExtremes(coordinates);

            /*ΔLat*/
            DLat = Math.Abs(extremeCoordinates.GetMaxLatitude().GetLatitude() - extremeCoordinates.GetMinLatitude().GetLatitude());

            /*ΔLon*/
            DLon = Math.Abs(extremeCoordinates.GetMaxLongitude().GetLongitude() - extremeCoordinates.GetMinLongitude().GetLongitude());
        }
        
        /*this method return the elaborated extremes*/
        private void GetExtremes(MaxCoordinates coordinates)
        {
            /*private filed to inizialize the max coordinates */
            this.extremeCoordinates = new MaxCoordinatesImpl();
            Latitude maxLatitude;
            Latitude minLatitude;
            Longitude maxLongitude;
            Longitude minLongitude;

            /*definiction of the filter*/

            /*get the latitude extremes*/
            if (coordinates.GetMaxLatitude().sign.ToLower().Equals(coordinates.GetMinLatitude().sign.ToLower()))
            {

                if(coordinates.GetMaxLatitude().degrees == coordinates.GetMinLatitude().degrees)
                {

                    if (coordinates.GetMaxLatitude().prime == coordinates.GetMinLatitude().prime)
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
            if (coordinates.GetMaxLongitude().sign.ToLower().Equals(coordinates.GetMinLongitude().sign.ToLower()))
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
            if(drawPoint.X < 0)
            {
                drawPoint.X = Convert.ToInt32(this.X + drawPoint.X);
            }

            drawPoint.Y = Convert.ToInt32(this.Y - (point.latitude.GetLatitude() - extremeCoordinates.GetMinLatitude().GetLatitude()) * (this.Y / this.DLat));
            if (drawPoint.Y < 0)
            {
                drawPoint.Y = Convert.ToInt32(this.Y + drawPoint.Y);
            }

            return drawPoint;
        }

    }
}
