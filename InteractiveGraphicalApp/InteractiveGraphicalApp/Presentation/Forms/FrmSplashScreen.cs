using InteractiveGraphicalApp.Infraestructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InteractiveGraphicalApp.Presentation.Forms
{
    public partial class FrmSplashScreen : Form
    {
        public FrmSplashScreen()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;
            this.TopMost = true;
            this.BringToFront();
            Config.Instance.SplashScreenShowed = true;
        }

        //close after 3 secons
      
        private async  void FrmSplashScreen_Load_1(object sender, EventArgs e)
        {
            await Task.Delay(3000); // Wait for 3 seconds
            this.Close(); // Close the splash screen
        }
    }
}
