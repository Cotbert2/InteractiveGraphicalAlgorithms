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
    public partial class FrmMidPoint : FrmBase
    {
        private int radio;
        MidPointRasterizer midPointRasterizer = new MidPointRasterizer();
        public FrmMidPoint() : base(Constants.MidPointGuidance, "MidPoint Bresenham Algorithm")
        {
            InitializeComponent();
            this.Size = new Size(830, 644);
            this.radio = 10;
            //min 10 , max 100
            this.tbRadio.Minimum = 10;
            this.tbRadio.Maximum = 100;
            this.txtRadio.Text = radio.ToString();
            this.Tooltip();
            canvas.MouseClick += canvas_MouseClick;
            canvas.Paint += canvas_Paint;
        }

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (!midPointRasterizer.isDrawing)
            {
                var points = midPointRasterizer.DrawCircle(e.X, e.Y, radio);
                midPointRasterizer.DrawAsync(canvas,
                points);
                //center for the canvas
                int cartesianX = e.X - (canvas.Width / 2);
                int cartesianY = (canvas.Height / 2) - e.Y;
                txtCenter.Text = $"({cartesianX}, {cartesianY})";
                txtNumPoints.Text = $"{points.Count}";
            }
                
        }

        private void Tooltip()
        {
            PopupNotifier popup = new PopupNotifier();
            popup.TitleText = "Information";
            popup.ContentText = "Click on the canvas to plot a circle.";
            popup.Image = SystemIcons.Information.ToBitmap();
            popup.Delay = 5000;
            popup.AnimationDuration = 1000;
            popup.ShowCloseButton = true;
            popup.Popup();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtRadio.Text, out int value))
            {
                if (value < 10)
                {
                    txtRadio.Text = "10";
                    value = 10;
                }
                else if (value >= 100)
                {
                    txtRadio.Text = "100";
                    value = 100;
                }
                tbRadio.Value = value;
            }
            else
            {
                txtRadio.Text = "10";
            }

            radio = tbRadio.Value;
            txtRadio.Text = radio.ToString();
        }

        private void tbRadio_Scroll(object sender, ScrollEventArgs e)
        {
            radio = tbRadio.Value;
            txtRadio.Text = radio.ToString();
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
    }
}
