﻿using InteractiveGraphicalApp.Infraestructure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphExamples.Graphers.Utils
{
    public class PolygonUtils
    {
        public static List<PointF> buildPolygon(float numberOfPoints, float sideLarge)
        {
            float currentAngle = 0f;
            List<PointF> points = new List<PointF>();
            float angleSteps = (float)(360f / numberOfPoints);
            for (float i = 0; i < 360; i += angleSteps)
            {
                float x = (float)(Math.Cos(currentAngle * Math.PI / 180f) * sideLarge);
                float y = (float)(Math.Sin(currentAngle * Math.PI / 180f) * sideLarge);
                points.Add(new PointF(x, y));
                currentAngle += angleSteps;
            }

            return points;

        }



        public static List<PointF> centerPolygon(List<PointF> points, PictureBox canvas)
        {
            List<PointF> centeredPoints = new List<PointF>();
            float centerX = (float)(canvas.Width / 2);
            float centerY = (float)(canvas.Height / 2);
            foreach (PointF point in points)
            {
                centeredPoints.Add(new PointF(point.X + centerX, point.Y + centerY));
            }
            return centeredPoints;
        }

        public static List<PointF> scaleFromCenter(List<PointF> points, float scale)
        {
            List<PointF> scaledPoints = new List<PointF>();
            float centerX = points.Average(p => p.X);
            float centerY = points.Average(p => p.Y);

            foreach (PointF point in points)
            {
                float scaledX = centerX + (point.X - centerX) * scale;
                float scaledY = centerY + (point.Y - centerY) * scale;
                scaledPoints.Add(new PointF(scaledX, scaledY));
            }

            return scaledPoints;
        }

        public static List<PointF> computeStar(float innerRadius, float outerRadius, int tips, int SF, PictureBox canvas)
        {
            float steps = (float)(Math.PI / tips);
            PointF canvasCenter = new PointF(
                canvas.Width / 2f,
                canvas.Height / 2f
            );

            List<PointF> points = new List<PointF>();

            for (int i = 0; i < 2 * tips; i++)
            {
                float angle = i * steps;
                float radius = (i % 2 == 0) ? outerRadius : innerRadius;

                float x = (float)(radius * Math.Cos(angle));
                float y = (float)(radius * Math.Sin(angle));

                points.Add(new PointF(x, y));
            }

            List<PointF> scaledPoints = new List<PointF>();
            foreach (var point in points)
            {
                scaledPoints.Add(new PointF(
                    point.X * SF + canvasCenter.X,
                    point.Y * SF + canvasCenter.Y
                ));
            }

            return scaledPoints;
        }

        public static System.Drawing.RectangleF circleBound(int SF, PictureBox canvas, float radius)
        {
            float centerX = canvas.Width / 2f;
            float centerY = canvas.Height / 2f;
            float scaledRadius = radius * SF;

            return new System.Drawing.RectangleF(
                (centerX - scaledRadius),
                (centerY - scaledRadius),
                scaledRadius * 2,
                scaledRadius * 2
            );
        }

        public static List<PointF> rotate(List<PointF> points, float degrees)
        {
            List<PointF> rotatedPoints = new List<PointF>();
            double radians = degrees * Math.PI / 180.0;

            float centerX = points.Average(p => p.X);
            float centerY = points.Average(p => p.Y);

            foreach (PointF point in points)
            {
                float translatedX = point.X - centerX;
                float translatedY = point.Y - centerY;

                float rotatedX = (float)(translatedX * Math.Cos(radians) - translatedY * Math.Sin(radians));
                float rotatedY = (float)(translatedX * Math.Sin(radians) + translatedY * Math.Cos(radians));

                rotatedPoints.Add(new PointF(rotatedX + centerX, rotatedY + centerY));
            }

            return rotatedPoints;
        }

        public static List<PointF> traslation(List<PointF> points, float moveX, float moveY)
        {
            List<PointF> translatedPoints = new List<PointF>();
            foreach (PointF point in points)
            {
                translatedPoints.Add(new PointF(point.X + moveX, point.Y + moveY));
            }
            return translatedPoints;

        }

        public static void drawPolygon(Graphics g, List<PointF> points)
        {
            
            using (Pen pen = new Pen(Config.Instance.LineColor, Config.Instance.LineAnchors))
            {
                for (int i = 0; i < points.Count; i++)
                {
                    PointF startPoint = points[i];
                    PointF endPoint = points[(i + 1) % points.Count];
                    g.DrawLine(pen, startPoint, endPoint);
                }
            }
        }

        public static List<PointF> centerPolygonByPoints(List<PointF> points, PointF center)
        {
            if (points == null || points.Count == 0)
                return new List<PointF>();

            float sumX = 0, sumY = 0;
            foreach (var point in points)
            {
                sumX += point.X;
                sumY += point.Y;
            }

            float centroidX = sumX / points.Count;
            float centroidY = sumY / points.Count;

            float dx = center.X - centroidX;
            float dy = center.Y - centroidY;

            List<PointF> centered = new List<PointF>();
            foreach (var point in points)
            {
                centered.Add(new PointF(point.X + dx, point.Y + dy));
            }

            return centered;
        }

    }
}
