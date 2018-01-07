using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timetabling
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
            AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            Core.Session.StartSession();
            Application.Run(new F_Splash());
        }
    }
}
