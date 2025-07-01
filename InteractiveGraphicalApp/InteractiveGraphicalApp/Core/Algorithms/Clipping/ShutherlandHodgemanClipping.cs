using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveGraphicalApp.Core.Algorithms.Clipping
{
    internal class ShutherlandHodgemanClipping
    {

            private Rectangle clipWindow;

            public ShutherlandHodgemanClipping(int xMin, int xMax, int yMin, int yMax)
            {
                int xmin = Math.Min(xMin, xMax);
                int xmax = Math.Max(xMin, xMax);
                int ymin = Math.Min(yMin, yMax);
                int ymax = Math.Max(yMin, yMax);

                clipWindow = new Rectangle(xmin, ymin, xmax - xmin, ymax - ymin);
            }

            public List<Point> ClipPolygon(List<Point> polygon)
            {
                if (polygon == null || polygon.Count < 3)
                    return new List<Point>();

                List<Point> output = polygon;

                output = ClipAgainstEdge(output, p => p.X >= clipWindow.Left, (p1, p2) =>
                    new Point(clipWindow.Left, p1.Y + (p2.Y - p1.Y) * (clipWindow.Left - p1.X) / (p2.X - p1.X)));

                output = ClipAgainstEdge(output, p => p.X <= clipWindow.Right, (p1, p2) =>
                    new Point(clipWindow.Right, p1.Y + (p2.Y - p1.Y) * (clipWindow.Right - p1.X) / (p2.X - p1.X)));

                output = ClipAgainstEdge(output, p => p.Y >= clipWindow.Top, (p1, p2) =>
                    new Point(p1.X + (p2.X - p1.X) * (clipWindow.Top - p1.Y) / (p2.Y - p1.Y), clipWindow.Top));

                output = ClipAgainstEdge(output, p => p.Y <= clipWindow.Bottom, (p1, p2) =>
                    new Point(p1.X + (p2.X - p1.X) * (clipWindow.Bottom - p1.Y) / (p2.Y - p1.Y), clipWindow.Bottom));

                return output;
            }

            private List<Point> ClipAgainstEdge(List<Point> input, Func<Point, bool> isInside, Func<Point, Point, Point> intersect)
            {
                List<Point> output = new List<Point>();
                if (input.Count == 0) return output;

            Point prev = input[input.Count - 1];
            foreach (Point curr in input)
                {
                    bool currIn = isInside(curr);
                    bool prevIn = isInside(prev);

                    if (currIn)
                    {
                        if (!prevIn)
                            output.Add(intersect(prev, curr));
                        output.Add(curr);
                    }
                    else if (prevIn)
                    {
                        output.Add(intersect(prev, curr));
                    }

                    prev = curr;
                }

                return output;
            }
        
    }
}
