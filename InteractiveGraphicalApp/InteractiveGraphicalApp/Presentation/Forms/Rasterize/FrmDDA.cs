﻿using GraphExamples.Structures;
using InteractiveGraphicalApp.Core.Algorithms;
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
using System.Windows.Controls;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace InteractiveGraphicalApp.Presentation.Forms
{
    public partial class FrmDDA : FrmBase
    {
        private CircularBuffer2<Point> points = new CircularBuffer2<Point>();
        private DDARasterizer ddaGrapher = new DDARasterizer();


        public FrmDDA() : base(Constants.DDAGuidance, "DDA Line Rasterization") 
        {
            InitializeComponent();
            this.Tooltip();
            canvas.MouseClick += canvas_MouseClick;
            canvas.Paint += canvas_Paint;
        }

        private void updatePointFields()
        {
            if (!ddaGrapher.isDrawing)
            {
                if (points[0] != null)
                {
                    txtX0.Text = points[0].X.ToString();
                    txtY0.Text = points[0].Y.ToString();
                }

                if (points[1] != null)
                {
                    txtX1.Text = points[1].X.ToString();
                    txtY1.Text = points[1].Y.ToString();
                }
            }
        }

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
            int centerX = canvas.Width / 2;
            int centerY = canvas.Height / 2;

            int cartesianX = e.X - centerX;
            int cartesianY = -(e.Y - centerY);

            points.Add(new Point(cartesianX, cartesianY));
            updatePointFields();

            if (points.GetItems().Count() == 2)
            {
                plot();
            }
            else if (points.GetItems().Count() > 2)
            {
                points = new CircularBuffer2<Point>();
                canvas.Invalidate();
                updatePointFields();
            }
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int centerX = canvas.Width / 2;
            int centerY = canvas.Height / 2;

            Pen axisPen = new Pen(Color.Gray, 1);
            g.DrawLine(axisPen, 0, centerY, canvas.Width, centerY);
            g.DrawLine(axisPen, centerX, 0, centerX, canvas.Height);
        }

        private void plot()
        {
            if (!ddaGrapher.isDrawing)
            {
                txtDeltaX.Text = 
                    Math.Abs(points[1].X - points[0].X).ToString();
                txtDeltaY.Text =
                    Math.Abs(points[1].Y - points[0].Y).ToString();
                txtSteps.Text = 
                    Math.Max(Math.Abs(points[1].X - points[0].X), Math.Abs(points[1].Y - points[0].Y)).ToString();
            }
            ddaGrapher.DrawAsync(canvas, ddaGrapher.DrawLine(points[0].X, points[0].Y, points[1].X, points[1].Y));
        }

        private void Tooltip()
        {
            PopupNotifier popup = new PopupNotifier();
            popup.TitleText = "Information";
            popup.ContentText = "Click on the canvas to draw a line.";
            popup.Image = SystemIcons.Information.ToBitmap();
            popup.Delay = 5000; 
            popup.AnimationDuration = 1000;
            popup.ShowCloseButton = true;
            popup.Popup();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            FrmDDA newFrm = new FrmDDA();
            newFrm.Show();
            this.Close();
        }
    }
}
