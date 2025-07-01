using GraphExamples.Structures;
using InteractiveGraphicalApp.Core.Algorithms.Clipping;
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
    public partial class FrmCohenShutherland : FrmBase
    {
        private Rectangle clipWindow;
        private int xmin = 100, xmax = 300, ymin = 100, ymax = 200;
        private CircularBuffer2<Point> clickPoints = new CircularBuffer2<Point>();
        private bool hasTwoPoints = false;
        private CohenShutherlandClipping clipper;
        public FrmCohenShutherland() : base (Constants.CohenShutherlandGuidance, "Cohen-Shutherland Clipping")
        {
    
            
            this.Tooltip();
            canvas.Paint += canvas_Paint;

            InitializeComponent();
            txtXMin.Text = xmin.ToString();
            txtxMax.Text = xmax.ToString();
            txtYMin.Text = ymin.ToString();
            txtYMax.Text = ymax.ToString();
            this.Size = new Size(830, 644);
            canvas.MouseClick += canvas_MouseClick;
        }


        //tooltip
        private void Tooltip()
        {
            PopupNotifier popup = new PopupNotifier();
            popup.TitleText = "Information";
            popup.ContentText = "Click on the canvas to draw a line then, use the right click to clip it";
            popup.Image = SystemIcons.Information.ToBitmap();
            popup.Delay = 5000;
            popup.AnimationDuration = 1000;
            popup.ShowCloseButton = true;

            popup.Popup();
        }

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                clickPoints.Add(e.Location);
                hasTwoPoints = clickPoints.GetItems().All(p => p != Point.Empty);
                canvas.Invalidate();
                UpdateCanvasImage();
            }
            else if (e.Button == MouseButtons.Right && hasTwoPoints)
            {
                clipper = new CohenShutherlandClipping(xmin, xmax, ymin, ymax);

                Point p1 = clickPoints[0];
                Point p2 = clickPoints[1];

                bool accepted = clipper.clipLine(p1.X, p1.Y, p2.X, p2.Y);

                canvas.Invalidate();
                UpdateCanvasImage();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            RenderScene(e.Graphics);

        }


        private void txtXMin_TextChanged(object sender, EventArgs e)
        {
            UpdateClipWindow();

        }

        private void txtxMax_TextChanged(object sender, EventArgs e)
        {
            UpdateClipWindow();

        }

        private void txtYMin_TextChanged(object sender, EventArgs e)
        {
            UpdateClipWindow();

        }

        private void txtYMax_TextChanged(object sender, EventArgs e)
        {
            UpdateClipWindow();

        }

        private void UpdateClipWindow()
        {
            int newXMin, newXMax, newYMin, newYMax;

            if (int.TryParse(txtXMin.Text, out newXMin) &&
                int.TryParse(txtxMax.Text, out newXMax) &&
                int.TryParse(txtYMin.Text, out newYMin) &&
                int.TryParse(txtYMax.Text, out newYMax))
            {
                newXMin = Math.Max(0, Math.Min(canvas.Width - 1, newXMin));
                newXMax = Math.Max(0, Math.Min(canvas.Width - 1, newXMax));
                newYMin = Math.Max(0, Math.Min(canvas.Height - 1, newYMin));
                newYMax = Math.Max(0, Math.Min(canvas.Height - 1, newYMax));

                if (newXMin > newXMax) (newXMin, newXMax) = (newXMax, newXMin);
                if (newYMin > newYMax) (newYMin, newYMax) = (newYMax, newYMin);

                xmin = newXMin;
                xmax = newXMax;
                ymin = newYMin;
                ymax = newYMax;

                clipWindow = new Rectangle(xmin, ymin, xmax - xmin, ymax - ymin);

                canvas.Invalidate();
                UpdateCanvasImage();
                canvas.Refresh();
            }
        }
        private void RenderScene(Graphics g)
        {
            g.Clear(Color.White);

            using (Pen greenPen = new Pen(Config.Instance.FillColor, 2))
            {
                g.DrawRectangle(greenPen, clipWindow);
            }

            if (hasTwoPoints)
            {
                Point p1 = clickPoints[0];
                Point p2 = clickPoints[1];
                using (Pen grayPen = new Pen(Color.Gray, 1))
                {
                    g.DrawLine(grayPen, p1, p2);
                }
            }

            if (clipper != null)
            {
                var clipped = clipper.GetClippedLine();
                if (clipped != null)
                {
                    var (x1, y1, x2, y2) = clipped.Value;
                    using (Pen redPen = new Pen(Config.Instance.LineColor, 2))
                    {
                        g.DrawLine(redPen, x1, y1, x2, y2);
                    }
                }
            }
        }

        private void UpdateCanvasImage()
        {
            Bitmap bmp = new Bitmap(canvas.Width, canvas.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                RenderScene(g); // Usa tu método existente para pintar todo
            }

            canvas.Image?.Dispose(); // libera la imagen anterior
            canvas.Image = bmp;
        }

    }
}
