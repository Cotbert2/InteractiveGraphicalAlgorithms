using InteractiveGraphicalApp.Infraestructure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace InteractiveGraphicalApp.Core.Algorithms
{
    public class MidPointRasterizer
    {
        public bool isDrawing { get; set; } = false;
        public List<Point> DrawCircle(int cx, int cy, int r)
        {
            int x = 0;
            int y = r;
            int p = 1 - r;
            List<Point> points = new List<Point>();

            while (x <= y)
            {
                points.Add(new Point(cx + x, cy + y));
                points.Add(new Point(cx - x, cy + y));
                points.Add(new Point(cx + x, cy - y));
                points.Add(new Point(cx - x, cy - y));
                points.Add(new Point(cx + y, cy + x));
                points.Add(new Point(cx - y, cy + x));
                points.Add(new Point(cx + y, cy - x));
                points.Add(new Point(cx - y, cy - x));

                x++;
                if (p < 0)
                {
                    p += 2 * x + 1;
                }
                else
                {
                    y--;
                    p += 2 * (x - y) + 1;
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
