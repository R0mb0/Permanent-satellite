using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente.Observer
{
    class ObserverImpl: Observer
    {
        public bool status { get; private set; }

        public void SetStatus(bool status)
        {
            this.status = status;
        }
    }
}
