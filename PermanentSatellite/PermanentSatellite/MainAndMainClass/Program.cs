using PermanentSatellite.LogicAndMath;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PermanentSatellite
{
    static class Program
    {
        
        /*  The main entry point for the application.*/
        [STAThread]
        static void Main()
        {
            /*automatically generated*/
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());

        }
    }
}
