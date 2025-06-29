using InteractiveGraphicalApp.Presentation.Forms;
using InteractiveGraphicalApp.Presentation.Forms.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InteractiveGraphicalApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            //using(var splashScreen = new FrmSplashScreen())
            //{
            //    splashScreen.Show();
            //    // Simulate some loading time
            //    System.Threading.Thread.Sleep(3000); // 3 seconds
            //    splashScreen.Close();
            //}
            Application.Run(new FrmBase());
        }
    }
}
