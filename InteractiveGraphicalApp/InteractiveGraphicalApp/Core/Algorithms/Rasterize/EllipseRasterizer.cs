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
    public class EllipseRasterizer
    {

        public bool isDrawing { get; set; } = false;
        public List<Point> DrawEllipse(int cx, int cy, int a, int b)
        {
            List<Point> points = new List<Point>();
            int x = 0;
            int y = b;

            int a2 = a * a;
            int b2 = b * b;

            double d1 = b2 - (a2 * b) + (0.25 * a2);
            int dx = 2 * b2 * x;
            int dy = 2 * a2 * y;

            while (dx < dy)
            {
                points.Add(new Point(cx + x, cy + y));
                points.Add(new Point(cx - x, cy + y));
                points.Add(new Point(cx + x, cy - y));
                points.Add(new Point(cx - x, cy - y));

                if (d1 < 0)
                {
                    x++;
                    dx = dx + (2 * b2);
                    d1 = d1 + dx + b2;
                }
                else
                {
                    x++;
                    y--;
                    dx = dx + (2 * b2);
                    dy = dy - (2 * a2);
                    d1 = d1 + dx - dy + b2;
                }
            }

            double d2 = (b2 * Math.Pow((x + 0.5), 2)) + (a2 * Math.Pow((y - 1), 2)) - (a2 * b2);

            while (y >= 0)
            {
                points.Add(new Point(cx + x, cy + y));
                points.Add(new Point(cx - x, cy + y));
                points.Add(new Point(cx + x, cy - y));
                points.Add(new Point(cx - x, cy - y));

                if (d2 > 0)
                {
                    y--;
                    dy = dy - (2 * a2);
                    d2 = d2 + a2 - dy;
                }
                else
                {
                    y--;
                    x++;
                    dx = dx + (2 * b2);
                    dy = dy - (2 * a2);
                    d2 = d2 + dx - dy + a2;
                }
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


                    foreach (var p in points)
                    {

                        g.FillRectangle(
                            new SolidBrush(Config.Instance.LineColor),
                            p.X,
                            p.Y,
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
