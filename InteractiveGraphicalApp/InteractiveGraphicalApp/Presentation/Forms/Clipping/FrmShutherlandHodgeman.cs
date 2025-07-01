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
    public partial class FrmShutherlandHodgeman : FrmBase
    {
        private List<Point> polygonPoints = new List<Point>();
        private List<Point> clippedPolygonPoints = new List<Point>();

        private Rectangle clipWindow;
        private int xmin = 100, xmax = 300, ymin = 100, ymax = 200;
        public FrmShutherlandHodgeman() : base(Constants.ShutherlandHodgmanGuidance, "Shutherland-Hodgman Clipping")
        {
            this.Tooltip();
            InitializeComponent();
            txtXMin.Text = xmin.ToString();
            txtxMax.Text = xmax.ToString();
            txtYMin.Text = ymin.ToString();
            txtYMax.Text = ymax.ToString();
            this.Size = new Size(830, 644);
            canvas.MouseClick += canvas_MouseClick;
            canvas.Paint += canvas_Paint;

        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            using (Pen greenPen = new Pen(Config.Instance.FillColor, 2))
            {
                g.DrawRectangle(greenPen, clipWindow);
            }

            if (polygonPoints.Count >= 2)
            {
                using (Pen bluePen = new Pen(Config.Instance.LineColor, 1))
                {
                    g.DrawLines(bluePen, polygonPoints.ToArray());
                }

                g.DrawLine(new Pen(Config.Instance.LineColor), polygonPoints.Last(), polygonPoints[0]);
            }

            if (clippedPolygonPoints.Count >= 3)
            {
                using (Pen pen = new Pen(Color.Red, 2))
                {
                    g.DrawPolygon(pen, clippedPolygonPoints.ToArray());
                }
            }
        }


        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                polygonPoints.Add(e.Location);
                canvas.Invalidate();
                UpdateCanvasImage(); 
            }
            else if (e.Button == MouseButtons.Right && polygonPoints.Count >= 3)
            {
                var clipper = new ShutherlandHodgemanClipping(xmin, xmax, ymin, ymax);
                clippedPolygonPoints = clipper.ClipPolygon(polygonPoints);

                canvas.Invalidate();
                UpdateCanvasImage();
            }

        }

        private void UpdateCanvasImage()
        {
            Bitmap bmp = new Bitmap(canvas.Width, canvas.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                canvas_Paint(this, new PaintEventArgs(g, canvas.ClientRectangle));
            }

            canvas.Image?.Dispose();
            canvas.Image = bmp;
        }

        private void Tooltip()
        {
            PopupNotifier popup = new PopupNotifier();
            popup.TitleText = "Information";
            popup.ContentText = "Click on the canvas to plot a polygon then, use the right click to clip it";
            popup.Image = SystemIcons.Information.ToBitmap();
            popup.Delay = 5000;
            popup.AnimationDuration = 1000;
            popup.ShowCloseButton = true;

            popup.Popup();
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


    }
}
