using InteractiveGraphicalApp.Infraestructure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InteractiveGraphicalApp.Core.Algorithms.Fill
{
    public class FloodFillBFS
    {
        public static List<Point> floodFill(PictureBox canvas, int x0, int y0, Bitmap bmp)
        {
            List<Point> points = new List<Point>();

            Color oldColor = bmp.GetPixel(x0, y0);
            Queue<Point> queue = new Queue<Point>();
            queue.Enqueue(new Point(x0, y0));

            while (queue.Count != 0)
            {
                Point currentPoint = queue.Dequeue();
                if (!(currentPoint.X >= bmp.Width || currentPoint.Y >= bmp.Height ||
                    currentPoint.X < 0 || currentPoint.Y < 0 ||
                    bmp.GetPixel(currentPoint.X, currentPoint.Y) != oldColor))
                {
                    bmp.SetPixel(currentPoint.X, currentPoint.Y, Config.Instance.FillColor);
                    points.Add(currentPoint);
                    if (Config.Instance.AnimationDelay != 0)
                    {
                        canvas.Image = bmp;
                        canvas.Refresh();
                        Task.Delay(Config.Instance.AnimationDelay);
                    }
                  
                    queue.Enqueue(new Point(currentPoint.X + 1, currentPoint.Y));
                    queue.Enqueue(new Point(currentPoint.X - 1, currentPoint.Y));
                    queue.Enqueue(new Point(currentPoint.X, currentPoint.Y + 1));
                    queue.Enqueue(new Point(currentPoint.X, currentPoint.Y - 1));
                }
            }
            return points;

        }
    }
}
