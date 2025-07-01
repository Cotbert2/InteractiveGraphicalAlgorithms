using InteractiveGraphicalApp.Core.Algorithms;
using InteractiveGraphicalApp.Infraestructure;
using InteractiveGraphicalApp.Presentation.Forms.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace InteractiveGraphicalApp.Presentation.Forms
{
    public partial class FrmEllipse : FrmBase
    {
        EllipseRasterizer midPointRasterizer = new EllipseRasterizer();
        public FrmEllipse() : base (Constants.EllipseGuidance, "MidPoint Ellipse Algorithm")
        {
            InitializeComponent();
            canvas.MouseClick += canvas_MouseClick;
            canvas.Paint += canvas_Paint;
            tbA.Minimum = 10;
            tbA.Maximum = 100;
            tbB.Minimum = 10;
            tbB.Maximum = 100;
            txtA.Text = "10";
            txtB.Text = "10";
            this.Tooltip();
            this.Size = new Size(830, 644);
        }

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (!midPointRasterizer.isDrawing)
            {
                var points = midPointRasterizer.DrawEllipse(e.X, e.Y,
                    int.Parse(txtA.Text), int.Parse(txtB.Text));
                midPointRasterizer.DrawAsync(canvas,
                points);
                //center for the canvas
                int cartesianX = e.X - (canvas.Width / 2);
                int cartesianY = (canvas.Height / 2) - e.Y;
                txtCenter.Text = $"({cartesianX}, {cartesianY})";
                txtNumber.Text = $"{points.Count}";
            }

        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int centerX = canvas.Width / 2;
            int centerY = canvas.Height / 2;

            Pen axisPen = new Pen(Color.Gray, 1);
            g.DrawLine(axisPen, 0, centerY, canvas.Width, centerY);
            g.DrawLine(axisPen, centerX, 0, centerX, canvas.Height);
        }

        private void Tooltip()
        {
            PopupNotifier popup = new PopupNotifier();
            popup.TitleText = "Information";
            popup.ContentText = "Click on the canvas to plot an Ellipse.";
            popup.Image = SystemIcons.Information.ToBitmap();
            popup.Delay = 5000;
            popup.AnimationDuration = 1000;
            popup.ShowCloseButton = true;
            popup.Popup();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmEllipse_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtA.Text, out int value))
            {
                if (value < 10)
                {
                    txtA.Text = "10";
                }
                else if (value > 100)
                {
                    txtA.Text = "100";
                }
            }
            else
            {
                txtA.Text = "10";
            }
            tbA.Value = int.Parse(txtA.Text);
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtB.Text, out int value))
            {
                if (value < 10)
                {
                    txtB.Text = "10";
                }
                else if (value > 100)
                {
                    txtB.Text = "100";
                }
            }
            else
            {
                txtB.Text = "10";
            }
            tbB.Value = int.Parse(txtB.Text);
        }

        private void tbA_Scroll(object sender, ScrollEventArgs e)
        {
            txtA.Text = tbA.Value.ToString();
        }

        private void tbB_Scroll(object sender, ScrollEventArgs e)
        {
            txtB.Text = tbB.Value.ToString();
        }
    }
}
