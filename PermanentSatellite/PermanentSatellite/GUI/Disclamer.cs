﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PermanentSatellite.GUI
{
    public partial class Disclamer : Form
    {
        /*This form is like a messagge box, but in this case this form return a value usefull for confirm the elimination point operations*/

        /*build*/
        public Disclamer()
        {
            InitializeComponent();
        }

        /*This is the button to confirm the elimination of the selected point from the elimination point form*/
        private void ButtonYes_Click(object sender, EventArgs e)
        {
            FormBridge.retunrBoolean = true;
            this.Close();
        }
    }
}
