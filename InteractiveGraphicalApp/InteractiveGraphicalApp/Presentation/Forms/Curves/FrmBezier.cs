using InteractiveGraphicalApp.Core.Algorithms.Curve;
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
    public partial class FrmBezier : FrmBase
    {
        List<Point> points = new List<Point>();
        private List<Point> bezierCurvePoints = new List<Point>();
        private Point? currentPositionOnCurve = null;
        public FrmBezier() : base(Constants.BezierGuidance, "Bezier Curves")
        {
            InitializeComponent();
            this.Size = new Size(830, 644);
            canvas.MouseClick += canvas_MouseClick;
            canvas.Paint += canvas_Paint;
            tbCurve.Minimum = 0;
            tbCurve.Maximum = 1000;
            Tooltip();
            tbCurve.Scroll += tbCurve_Scroll;
        }

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
    
       
            if (e.Button == MouseButtons.Left)
            {
                if (points.Count < 1)
                {
                    this.txtGrade.Text = "Invalid";
                }
                else
                {
                    this.txtGrade.Text = (points.Count).ToString();
                }
                points.Add(e.Location);
                RenderToCanvasImage();
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (points.Count >= 2)
                {
                    bezierCurvePoints = BezierCurve.GenerateCurvePoints(points, 1000);
                    tbCurve.Value = 0;
                    currentPositionOnCurve = bezierCurvePoints[0];
                    RenderToCanvasImage();
                }
            }
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
         
            if (bezierCurvePoints.Count > 1)
            {
                using (Pen pen = new Pen(Config.Instance.LineColor, 2))
                {
                    for (int i = 0; i < bezierCurvePoints.Count - 1; i++)
                    {
                        g.DrawLine(pen, bezierCurvePoints[i], bezierCurvePoints[i + 1]);
                    }
                }
            }
            
            foreach (var point in points)
            {
                g.FillEllipse(Brushes.Blue, point.X - 3, point.Y - 3, 6, 6);
            }
            if (points.Count > 1)
            {
                using (Pen pen = new Pen(Color.LightGray, 1))
                {
                    for (int i = 0; i < points.Count - 1; i++)
                    {
                        g.DrawLine(pen, points[i], points[i + 1]);
                    }
                }
            }

            if (currentPositionOnCurve.HasValue)
            {
                Point p = currentPositionOnCurve.Value;
                g.FillEllipse(Brushes.Green, p.X - 4, p.Y - 4, 8, 8);
            }

        }

        private void Tooltip()
        {
            PopupNotifier popup = new PopupNotifier();
            popup.TitleText = "Information";
            popup.ContentText = "Click to plot curves";
            popup.Image = SystemIcons.Information.ToBitmap();
            popup.Delay = 5000;
            popup.AnimationDuration = 1000;
            popup.ShowCloseButton = true;
            popup.Popup();
        }

        private void tbCurve_Scroll(object sender, EventArgs e)
        {
            if (bezierCurvePoints.Count > 0)
            {
                int index = tbCurve.Value;
                if (index >= 0 && index < bezierCurvePoints.Count)
                {
                    currentPositionOnCurve = bezierCurvePoints[index];
                    RenderToCanvasImage();
                }
            }
        }



        private void RenderToCanvasImage()
        {
            Bitmap bmp = new Bitmap(canvas.Width, canvas.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                if (bezierCurvePoints.Count > 1)
                {
                    using (Pen pen = new Pen(Config.Instance.LineColor, 2))
                    {
                        for (int i = 0; i < bezierCurvePoints.Count - 1; i++)
                        {
                            g.DrawLine(pen, bezierCurvePoints[i], bezierCurvePoints[i + 1]);
                        }
                    }
                }

                
                foreach (var point in points)
                {
                    g.FillEllipse(Brushes.Blue, point.X - 3, point.Y - 3, 6, 6);
                }

                
                if (points.Count > 1)
                {
                    using (Pen pen = new Pen(Color.LightGray, 1))
                    {
                        for (int i = 0; i < points.Count - 1; i++)
                        {
                            g.DrawLine(pen, points[i], points[i + 1]);
                        }
                    }
                }

                
                if (currentPositionOnCurve.HasValue)
                {
                    Point p = currentPositionOnCurve.Value;
                    g.FillEllipse(Brushes.Green, p.X - 4, p.Y - 4, 8, 8);
                }
            }

            canvas.Image = bmp;
            canvas.Invalidate();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            FrmBezier newFrm = new FrmBezier();
            newFrm.Show();
            this.Close();
        }
    }

}
