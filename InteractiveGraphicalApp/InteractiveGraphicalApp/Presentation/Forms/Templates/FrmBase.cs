using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InteractiveGraphicalApp.Presentation.Forms.Templates
{
    public partial class FrmBase : Form
    {
        private string filepath;
        public FrmBase()
        {
            this.ControlBox = false;
            InitializeComponent();
        }


        public FrmBase(string filepath)
        {
            this.filepath = filepath;
            InitializeComponent();
        }

        private void FrmBase_Load(object sender, EventArgs e)
        {

        }

        private void btnGithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/Cotbert2/InteractiveGraphicalAlgorithms",
                UseShellExecute = true
            });
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            FrmSupport frmSupport = new FrmSupport(filepath);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            FrmConfig frmConfig = new FrmConfig();
            frmConfig.ShowDialog();
        }
    }
}
