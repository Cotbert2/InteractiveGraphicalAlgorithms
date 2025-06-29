using InteractiveGraphicalApp.Core.Ports;
using InteractiveGraphicalApp.Infraestructure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace InteractiveGraphicalApp.Core.Algorithms
{
    public class BresenhamRasterizer : ILineRasterizer
    {
        public bool isHorizontal { get; set; } = true;
        public bool isDrawing = false;

        public List<Point> DrawLine(int x0, int y0, int x1, int y1)
        {
            return (Math.Abs(x1 - x0) > Math.Abs(y1 - y0)) ?
                BresenhamH(x0, y0, x1, y1) :
                BresenhamV(x0, y0, x1, y1) ;
        }


        public  List<Point> BresenhamH(int x0, int y0, int x1, int y1)
        {
            this.isHorizontal = true;
            List<Point> points = new List<Point>();

            if (x0 > x1)
            {
                int temp = x0;
                x0 = x1;
                x1 = temp;
                temp = y0;
                y0 = y1;
                y1 = temp;
            }

            int dy = y1 - y0;
            int dx = x1 - x0;

            int dir = (dy > 0) ? 1 : -1;

            dy *= dir;

            if (dx != 0)
            {
                int y = y0;
                int p = 2 * dy - dx;
                for (int i = 0; i < dx + 1; i++)
                {
                    points.Add(new Point(x0 + i, y));
                    if (p >= 0)
                    {
                        y += dir;
                        p -= 2 * dx;
                    }
                    p += 2 * dy;

                }
            }
            return points;
        }


        public List<Point> BresenhamV(int x0, int y0, int x1, int y1)
        {
            this.isHorizontal = false;
            List<Point> points = new List<Point>();

            if (y0 > y1)
            {
                int temp = x0;
                x0 = x1;
                x1 = temp;
                temp = y0;
                y0 = y1;
                y1 = temp;
            }

            int dy = y1 - y0;
            int dx = x1 - x0;

            int dir = (dx > 0) ? 1 : -1;

            dx *= dir;

            if (dy != 0)
            {
                int x = x0;
                int p = 2 * dx - dy;
                for (int i = 0; i < dy + 1; i++)
                {
                    points.Add(new Point(x, y0 + i));
                    if (p >= 0)
                    {
                        x += dir;
                        p -= 2 * dy;
                    }
                    p += 2 * dx;

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
                    g.Clear(System.Drawing.Color.White);

                    int centerX = canvas.Width / 2;
                    int centerY = canvas.Height / 2;

                    System.Drawing.Pen axisPen = new System.Drawing.Pen(System.Drawing.Color.Black, 1);
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