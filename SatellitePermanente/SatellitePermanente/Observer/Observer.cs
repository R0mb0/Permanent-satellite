﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente.Observer
{
    interface Observer
    {
        /*This interface define an Observer that can change its internal status*/
        public void SetStatus(bool status);
    }
}