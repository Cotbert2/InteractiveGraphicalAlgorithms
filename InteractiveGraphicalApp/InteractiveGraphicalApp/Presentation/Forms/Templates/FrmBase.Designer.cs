using InteractiveGraphicalApp.Infraestructure.Graphics;

namespace InteractiveGraphicalApp.Presentation.Forms.Templates
{
    partial class FrmBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.configButton = new FontAwesome.Sharp.IconButton();
            this.btnQuit = new FontAwesome.Sharp.IconButton();
            this.btnGithub = new FontAwesome.Sharp.IconButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.iconButton4);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.configButton);
            this.panel1.Controls.Add(this.btnQuit);
            this.panel1.Controls.Add(this.btnGithub);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 69);
            this.panel1.TabIndex = 2;
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.ForestGreen;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.BackwardStep;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 28;
            this.iconButton4.Location = new System.Drawing.Point(14, 8);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(48, 50);
            this.iconButton4.TabIndex = 5;
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.ForestGreen;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 28;
            this.iconButton2.Location = new System.Drawing.Point(641, 8);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(48, 45);
            this.iconButton2.TabIndex = 4;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // configButton
            // 
            this.configButton.BackColor = System.Drawing.Color.ForestGreen;
            this.configButton.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.configButton.IconColor = System.Drawing.Color.White;
            this.configButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.configButton.IconSize = 30;
            this.configButton.Location = new System.Drawing.Point(695, 8);
            this.configButton.Name = "configButton";
            this.configButton.Size = new System.Drawing.Size(54, 45);
            this.configButton.TabIndex = 3;
            this.configButton.UseVisualStyleBackColor = false;
            this.configButton.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnQuit.Cursor = System.Windows.Forms.Cursors.PanSW;
            this.btnQuit.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnQuit.IconColor = System.Drawing.Color.White;
            this.btnQuit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQuit.IconSize = 12;
            this.btnQuit.Location = new System.Drawing.Point(755, 8);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(47, 45);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnGithub
            // 
            this.btnGithub.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGithub.IconChar = FontAwesome.Sharp.IconChar.Github;
            this.btnGithub.IconColor = System.Drawing.Color.White;
            this.btnGithub.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGithub.Location = new System.Drawing.Point(68, 10);
            this.btnGithub.Name = "btnGithub";
            this.btnGithub.Size = new System.Drawing.Size(56, 48);
            this.btnGithub.TabIndex = 1;
            this.btnGithub.UseVisualStyleBackColor = false;
            this.btnGithub.Click += new System.EventHandler(this.btnGithub_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(180, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(74, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::InteractiveGraphicalApp.Properties.Resources.wallpaperjpg;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(260, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(551, 522);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.ForestGreen;
            this.panel3.Controls.Add(this.iconButton3);
            this.panel3.Controls.Add(this.iconButton1);
            this.panel3.Controls.Add(this.canvas);
            this.panel3.Location = new System.Drawing.Point(13, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(527, 477);
            this.panel3.TabIndex = 1;
            // 
            // iconButton3
            // 
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.RotateForward;
            this.iconButton3.IconColor = System.Drawing.Color.ForestGreen;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(411, 3);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(49, 44);
            this.iconButton3.TabIndex = 2;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.iconButton1.IconColor = System.Drawing.Color.ForestGreen;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(466, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(49, 44);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.exportImage);
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.Control;
            this.canvas.Location = new System.Drawing.Point(13, 53);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(502, 412);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            // 
            // FrmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 597);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBase";
            this.Text = "FrmBase";
            this.Load += new System.EventHandler(this.FrmBase_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnQuit;
        private FontAwesome.Sharp.IconButton btnGithub;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton configButton;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton1;
        public System.Windows.Forms.PictureBox canvas;
        private FontAwesome.Sharp.IconButton iconButton4;
    }
}