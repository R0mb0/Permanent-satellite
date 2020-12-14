using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente.Observer
{
    class ObserverImpl: Observer
    {
        /*This class implements the Observer interface, implementing the SetStatus method and the status methods in way to get the status value*/

        /*Fileds*/
        public bool status { get; private set; }

        /*using the default builder*/

        /*public methods*/
        public void SetStatus(bool status)
        {
            this.status = status;
        }
    }
}
