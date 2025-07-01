using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveGraphicalApp.Core.Algorithms.Curve
{
    public static class BSplineCurve
    {
        public static List<Point> GenerateCurvePoints(List<Point> controlPoints, int steps = 1000)
        {
            List<Point> result = new List<Point>();
            int n = controlPoints.Count - 1;
            int k = 3; // grado cúbico

            if (n < k) return result;

            int m = n + k + 1;
            float[] knots = new float[m + 1];

            // Generar vector de nudos uniforme
            for (int i = 0; i <= m; i++)
                knots[i] = i;

            float t_min = knots[k];
            float t_max = knots[m - k - 1]; // = knots[n + 1]

            for (int i = 0; i <= steps; i++)
            {
                float t = t_min + (i / (float)steps) * (t_max - t_min);
                PointF p = DeBoor(controlPoints, k, t, knots);
                result.Add(Point.Round(p));
            }

            return result;
        }

        private static PointF DeBoor(List<Point> ctrlPts, int degree, float t, float[] knots)
        {
            int n = ctrlPts.Count - 1;
            int k = degree;

            int s = k;
            while (s < knots.Length - k - 1 && !(t >= knots[s] && t < knots[s + 1]))
                s++;

            // Construir d[] con protección
            List<PointF> d = new List<PointF>();
            for (int j = 0; j <= k; j++)
            {
                int idx = s - k + j;
                if (idx < 0 || idx >= ctrlPts.Count)
                    d.Add(new PointF(0, 0)); // valor neutro para evitar excepciones
                else
                    d.Add(new PointF(ctrlPts[idx].X, ctrlPts[idx].Y));
            }

            // Algoritmo de De Boor
            for (int r = 1; r <= k; r++)
            {
                for (int j = k; j >= r; j--)
                {
                    int i = s - k + j;
                    float denom = knots[i + k - r + 1] - knots[i];
                    if (denom == 0) continue; // evitar división por cero

                    float alpha = (t - knots[i]) / denom;

                    PointF pj = d[j];
                    PointF pjPrev = d[j - 1];

                    pj.X = (1 - alpha) * pjPrev.X + alpha * pj.X;
                    pj.Y = (1 - alpha) * pjPrev.Y + alpha * pj.Y;

                    d[j] = pj;
                }
            }

            return d[k];
        }
    }

}
