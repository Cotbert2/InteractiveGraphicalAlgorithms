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

namespace InteractiveGraphicalApp.Presentation.Forms
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            this.ControlBox = false;

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }

        private void btnDDA_Click(object sender, EventArgs e)
        {
            FrmDDA frmDDA = new FrmDDA();
            frmDDA.Show();
            this.Hide();

        }

        private void btnBresenham_Click(object sender, EventArgs e)
        {
            FrmBresenham frmBresenham = new FrmBresenham();
            frmBresenham.Show();
            this.Hide();
        }

        private void btnMidPoint_Click(object sender, EventArgs e)
        {
            FrmMidPoint frmMidPoint = new FrmMidPoint();
            frmMidPoint.Show();
            this.Hide();
        }

        private void FrmEllipse_Click(object sender, EventArgs e)
        {
            FrmEllipse frmEllipse = new FrmEllipse();
            frmEllipse.Show();
            this.Hide();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            FrmFillFloodDFS frmFillFoodDFS = new FrmFillFloodDFS();
            frmFillFoodDFS.Show();
            this.Hide();
        }

        private void btnFloodBFS_Click(object sender, EventArgs e)
        {
            FrmFillFloodBFS frmFloodFillBFS = new FrmFillFloodBFS();
            frmFloodFillBFS.Show();
            this.Hide();
        }

        private void btnCohenShutherland_Click(object sender, EventArgs e)
        {
            FrmCohenShutherland frmCohenShutherland = new FrmCohenShutherland();
            frmCohenShutherland.Show();
            this.Hide();
        }

        private void btnShutherlandHodgeman_Click(object sender, EventArgs e)
        {
            FrmShutherlandHodgeman frmShutherlandHodgeman = new FrmShutherlandHodgeman();
            frmShutherlandHodgeman.Show();
            this.Hide();
        }

        private void btnBezier_Click(object sender, EventArgs e)
        {
            FrmBezier frmBezier = new FrmBezier();
            frmBezier.Show();
            this.Hide();
        }

        private void btnBSplines_Click(object sender, EventArgs e)
        {
            FrmBSpline frmBSplines = new FrmBSpline();
            frmBSplines.Show();
            this.Hide();
        }
    }
}
