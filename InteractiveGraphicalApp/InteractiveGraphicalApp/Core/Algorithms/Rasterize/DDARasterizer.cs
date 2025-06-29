using InteractiveGraphicalApp.Core.Ports;
using InteractiveGraphicalApp.Infraestructure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InteractiveGraphicalApp.Core.Algorithms
{
    public class DDARasterizer : ILineRasterizer
    {
        public bool isDrawing = false;
        public List<Point> DrawLine(int x0, int y0, int x1, int y1)
        {
            List<Point> points = new List<Point>();
            int dx = x1 - x0;
            int dy = y1 - y0;
            int steps = Math.Max(Math.Abs(dx), Math.Abs(dy));
            float xIncrement = (float)dx / steps;
            float yIncrement = (float)dy / steps;
            float x = x0;
            float y = y0;
            for (int i = 0; i <= steps; i++)
            {
                points.Add(new Point((int)Math.Round(x), (int)Math.Round(y)));
                x += xIncrement;
                y += yIncrement;
            }
            return points;
        }

        public async Task DrawAsync(PictureBox canvas, List<Point> points)
        {
            if (isDrawing)
                return;
            isDrawing = true;
            Bitmap bmp = new Bitmap(canvas.Width, canvas.Height);

            if (points.Count >= 1)
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(Color.White);

                    int centerX = canvas.Width / 2;
                    int centerY = canvas.Height / 2;

                    Pen axisPen = new Pen(Color.Black, 1);
                    g.DrawLine(axisPen, 0, centerY, canvas.Width, centerY);
                    g.DrawLine(axisPen, centerX, 0, centerX, canvas.Height);

                    g.FillRectangle(
                        new SolidBrush(Config.Instance.FillColor),
                        centerX + points[0].X,
                        centerY - points[0].Y,
                        Config.Instance.LineAnchors * 5,
                        Config.Instance.LineAnchors * 5
                    );

                    g.FillRectangle(
                        new SolidBrush(Config.Instance.FillColor),
                        centerX + points[points.Count - 1].X,
                        centerY - points[points.Count - 1].Y,
                        Config.Instance.LineAnchors * 5,
                        Config.Instance.LineAnchors * 5
                    );

                    foreach (var p in points)
                    {
                        int screenX = centerX + p.X;
                        int screenY = centerY - p.Y;

                        g.FillRectangle(
                            new SolidBrush(Config.Instance.LineColor),
                            screenX,
                            screenY,
                            Config.Instance.LineAnchors,
                            Config.Instance.LineAnchors
                        );
                        canvas.Image = bmp;

                        await Task.Delay(Config.Instance.AnimationDelay);
                    }
                }

                canvas.Image = bmp;
            }
            isDrawing = false;

        }
    }
}
