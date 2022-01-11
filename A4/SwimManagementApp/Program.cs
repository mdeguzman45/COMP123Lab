/**
 * Simire, Amanda
 * Mahi, Muksud Hussain (301155894)
 * De Guzman, Marc Louis Gene (301171014)
**/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwimManagementApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SwimManagementApp());
        }
    }
}
