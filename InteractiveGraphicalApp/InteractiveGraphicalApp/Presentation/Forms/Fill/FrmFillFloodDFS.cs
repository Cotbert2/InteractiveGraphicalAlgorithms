using GraphExamples.Graphers.Utils;
using InteractiveGraphicalApp.Core.Algorithms;
using InteractiveGraphicalApp.Core.Algorithms.Fill;
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
using System.Web;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace InteractiveGraphicalApp.Presentation.Forms
{
    public partial class FrmFillFloodDFS : FrmBase
    {
        private string currentAction = "";
        Bitmap bitmap;

        public FrmFillFloodDFS() : base(Constants.FillFloodDFSGuidance, "Fill Flood DFS Algorithm")
        {
            InitializeComponent();
            this.Size = new Size(830, 644);
            tbSide.Minimum = 10; // Minimum side length
            tbSide.Maximum = 100; // Maximum side length
            tbNumberSides.Minimum = 3; // Minimum number of sides
            tbNumberSides.Maximum = 30; // Maximum number of sides
            txtSide.Text = tbSide.Value.ToString();
            txtNumberSides.Text = tbNumberSides.Value.ToString();
            tbInner.Minimum = 10; // Minimum inner radius
            tbInner.Maximum = 200; // Maximum inner radius
            txtInner.Text = tbInner.Value.ToString();
            tbOutter.Minimum = 10; // Minimum outer radius
            tbOutter.Maximum = 200; // Maximum outer radius
            this.Tooltip();
            //canvas.Paint += canvas_Paint;
            txtOutter.Text = tbOutter.Value.ToString();
            canvas.MouseClick += canvas_MouseClick;
            tbTips.Minimum = 5; // Minimum tips length
            tbTips.Maximum = 20; // Maximum tips length
            txtTips.Text = tbTips.Value.ToString();

            bitmap = new Bitmap(canvas.Width, canvas.Height);


        }

        private void FrmFillFloodDFS_Load(object sender, EventArgs e)
        {

        }

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (currentAction == "")
            {
                PopupNotifier popup = new PopupNotifier();
                popup.TitleText = "Error";
                popup.ContentText = "Please select a shape to draw.";
                popup.Image = SystemIcons.Error.ToBitmap();
                popup.Delay = 3000;
                popup.AnimationDuration = 1000;
                popup.ShowCloseButton = true;
                popup.Popup();
                return;
            }

            if (currentAction == "shape")
            {

                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    int size = tbSide.Value > 0 ? tbSide.Value : 50;

                    Pen pen = new Pen(Config.Instance.LineColor, Config.Instance.LineAnchors);
                    g.DrawPolygon(
                        pen,
                        PolygonUtils.centerPolygonByPoints(
                        PolygonUtils.buildPolygon(
                            int.Parse(txtNumberSides.Text),
                            int.Parse(txtSide.Text)
                            ), new PointF(e.X, e.Y)).ToArray()
                        );
                }

                canvas.Image = bitmap;
            }
            else if (currentAction == "star")
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {

                    Pen pen = new Pen(Config.Instance.LineColor, Config.Instance.LineAnchors);
                    g.DrawPolygon(
                        pen,
                        PolygonUtils.centerPolygonByPoints(
                        PolygonUtils.computeStar(
                            int.Parse(txtInner.Text),
                            int.Parse(txtOutter.Text),
                            int.Parse(txtTips.Text), 1, canvas
                            )
                        , new PointF(e.X, e.Y))
                        .ToArray()
                        );

                }

                canvas.Image = bitmap;
            }
            else if (currentAction == "fill")
            {
                FloodFillDFS.floodFill(canvas, e.X, e.Y, bitmap);
                canvas.Image = bitmap;
            }
        }



        private void Tooltip()
        {
            PopupNotifier popup = new PopupNotifier();
            popup.TitleText = "Information";
            popup.ContentText = "Pick a shape and start to Paint";
            popup.Image = SystemIcons.Information.ToBitmap();
            popup.Delay = 5000;
            popup.AnimationDuration = 1000;
            popup.ShowCloseButton = true;
            popup.Popup();
        }
        private void txtSide_TextChanged(object sender, EventArgs e)
        {
            //move track and validate >= 10 && <=100    
            if (int.TryParse(txtSide.Text, out int side))
            {
                if (side < 10)
                {
                    txtSide.Text = "10";
                    tbSide.Value = 10;
                }
                else if (side > 100)
                {
                    txtSide.Text = "100";
                    tbSide.Value = 100;
                }
                else
                {
                    tbSide.Value = side;
                }
            }
            else
            {
                txtSide.Text = "10"; 
                tbSide.Value = 10; 
            }
        }

        private void txtNumberSides_TextChanged(object sender, EventArgs e)
        {
            //validate >= 3 && <= 30

            if (int.TryParse(txtNumberSides.Text, out int numberSides))
            {
                if (numberSides < 3)
                {
                    txtNumberSides.Text = "3";
                    tbNumberSides.Value = 3;
                }
                else if (numberSides > 30)
                {
                    txtNumberSides.Text = "30";
                    tbNumberSides.Value = 30;
                }
                else
                {
                    tbNumberSides.Value = numberSides;
                }
            }
            else
            {
                txtNumberSides.Text = "3";
                tbNumberSides.Value = 3;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //validate >= 10 && <= 200 for tb
            if (int.TryParse(txtInner.Text, out int inner))
            {
                if (inner < 10)
                {
                    txtInner.Text = "10";
                    tbInner.Value = 10;
                }
                else if (inner > 200)
                {
                    txtInner.Text = "200";
                    tbInner.Value = 200;
                } else
                {
                    tbInner.Value = inner;
                }
            }
            else
            {
                txtInner.Text = "10";
                tbInner.Value = 10;
            }

        }

        private void tbSide_Scroll(object sender, ScrollEventArgs e)
        {
            txtSide.Text = tbSide.Value.ToString();
        }

        private void tbNumberSides_Scroll(object sender, ScrollEventArgs e)
        {
            txtNumberSides.Text = tbNumberSides.Value.ToString();
        }

        private void txtOutter_TextChanged(object sender, EventArgs e)
        {
            //validate >= 10 && <= 200 for tb
            if (int.TryParse(txtOutter.Text, out int outter))
            {
                if (outter < 10)
                {
                    txtOutter.Text = "10";
                    tbOutter.Value = 10;
                }
                else if (outter > 200)
                {
                    txtOutter.Text = "200";
                    tbOutter.Value = 200;
                }else
                {
                    tbOutter.Value = outter;
                }
            }
            else
            {
                txtOutter.Text = "10";
                tbOutter.Value = 10;
            }
        }

        private void tbOutter_Scroll(object sender, ScrollEventArgs e)
        {
            txtOutter.Text = tbOutter.Value.ToString();
        }

        private void tbInner_Scroll(object sender, ScrollEventArgs e)
        {
            txtInner.Text = tbInner.Value.ToString();
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

        private void btnShape_Click(object sender, EventArgs e)
        {
            this.currentAction = "shape";
            btnFill.BackColor = Color.FromArgb(64, 64, 64);
            btnStar.BackColor = Color.FromArgb(64, 64, 64);
            btnShape.BackColor = Color.FromArgb(0, 192, 0); 
        }

        private void btnStar_Click(object sender, EventArgs e)
        {
            this.currentAction = "star";
            btnFill.BackColor = Color.FromArgb(64, 64, 64);
            btnShape.BackColor = Color.FromArgb(64, 64, 64);
            btnStar.BackColor = Color.FromArgb(0, 192, 0);
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            this.currentAction = "fill";
            btnShape.BackColor = Color.FromArgb(64, 64, 64);
            btnStar.BackColor = Color.FromArgb(64, 64, 64);
            btnFill.BackColor = Color.FromArgb(0, 192, 0);
        }

        private void tbTips_Scroll(object sender, ScrollEventArgs e)
        {
            txtTips.Text = tbTips.Value.ToString();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            FrmFillFloodDFS newFrm = new FrmFillFloodDFS();
            newFrm.Show();
            this.Close();
        }
    }
}
