using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveGraphicalApp.Core.Algorithms.Curve
{
    public static class BezierCurve
    {
        public static List<Point> GenerateCurvePoints(List<Point> controlPoints, int steps = 100)
        {
            if (controlPoints == null || controlPoints.Count < 2)
                throw new ArgumentException("Se necesitan al menos 2 puntos de control para generar una curva de Bézier.");

            List<Point> curvePoints = new List<Point>();

            for (int i = 0; i <= steps; i++)
            {
                float t = i / (float)steps;
                PointF bezierPoint = DeCasteljau(controlPoints, t);
                curvePoints.Add(Point.Round(bezierPoint));
            }

            return curvePoints;
        }

      
        private static PointF DeCasteljau(List<Point> points, float t)
        {
            List<PointF> currentPoints = new List<PointF>();
            foreach (Point p in points)
            {
                currentPoints.Add(new PointF(p.X, p.Y));
            }

            while (currentPoints.Count > 1)
            {
                List<PointF> nextPoints = new List<PointF>();
                for (int i = 0; i < currentPoints.Count - 1; i++)
                {
                    float x = (1 - t) * currentPoints[i].X + t * currentPoints[i + 1].X;
                    float y = (1 - t) * currentPoints[i].Y + t * currentPoints[i + 1].Y;
                    nextPoints.Add(new PointF(x, y));
                }
                currentPoints = nextPoints;
            }

            return currentPoints[0];
        }
    }

}
