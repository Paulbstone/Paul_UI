using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace howto_shaped_button
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
            Application.Run(new intro_form());
            // old line from above Application.Run(new inputform());
        }
    }
}
