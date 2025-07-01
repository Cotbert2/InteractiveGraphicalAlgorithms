using FontAwesome.Sharp;
using InteractiveGraphicalApp.Infraestructure;
using InteractiveGraphicalApp.Infraestructure.Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace InteractiveGraphicalApp.Presentation.Forms.Templates
{
    public partial class FrmBase : Form 
    {
        private string filepath;
        public FrmBase()
        {
            this.ControlBox = false;
            InitializeComponent();
            //cavnas foreground color white
            canvas.BackColor = Color.White;
            
        }


        public FrmBase(string filepath, string title)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;
            //size 830; 644 no resize
            this.Size = new Size(830, 644);
            this.MaximizeBox = false;
            this.filepath = filepath;
            InitializeComponent();
            this.lblTitle.Text = title;
        }

        private void FrmBase_Load(object sender, EventArgs e)
        {

        }

        private void btnGithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = Constants.GithubUrl,
                UseShellExecute = true
            });
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            FrmSupport frmSupport = new FrmSupport(filepath);
            frmSupport.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            FrmConfig frmConfig = new FrmConfig();
            frmConfig.ShowDialog();
        }

        private void exportImage(object sender, EventArgs e)
        {
            if (canvas.Image != null)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                    saveFileDialog.Title = "Save canvas drawing";
                    saveFileDialog.FileName = "imagen.png";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        System.Drawing.Imaging.ImageFormat formato = System.Drawing.Imaging.ImageFormat.Png;
                        string extension = Path.GetExtension(saveFileDialog.FileName).ToLower();

                        switch (extension)
                        {
                            case ".jpg":
                                formato = System.Drawing.Imaging.ImageFormat.Jpeg;
                                break;
                            case ".bmp":
                                formato = System.Drawing.Imaging.ImageFormat.Bmp;
                                break;
                        }

                        canvas.Image.Save(saveFileDialog.FileName, formato);

                        PopupNotifier popup = new PopupNotifier();
                        popup.TitleText = "Done";
                        popup.ContentText = "Image saved successfully";
                        popup.TitleColor = Color.White;
                        popup.ContentColor = Color.White;
                        popup.BodyColor = Color.FromArgb(40, 167, 69);
                        popup.BorderColor = Color.DarkGreen;
                        popup.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
                        popup.ContentFont = new Font("Segoe UI", 9);
                        popup.Image = FontAwesome.Sharp.IconChar.CheckCircle.ToBitmap(Color.White, 20);
                        popup.Popup();
                    }
                }
            }
            else
            {
                MessageBox.Show("There is no image on the canvas.");
            }
        }


        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            //go to home
            FrmHome frmHome = new FrmHome();
            frmHome.Show();
            this.Close();
        }


    }

}
