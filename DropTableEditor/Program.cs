using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DropTableEditor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        // TODO: Add Open Folder button
        // TODO: Add dragging into program (recognizes which one was dragged in and tries to open the rest from the same directory
        // TODO: Clean up code
        // TODO: Add credits
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DropTableEditor());
        }
    }
}
