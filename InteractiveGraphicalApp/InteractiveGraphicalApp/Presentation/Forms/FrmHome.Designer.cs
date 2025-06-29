namespace InteractiveGraphicalApp.Presentation.Forms
{
    partial class FrmHome
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBSplines = new FontAwesome.Sharp.IconButton();
            this.btnBezier = new FontAwesome.Sharp.IconButton();
            this.btnShutherlandHodgeman = new FontAwesome.Sharp.IconButton();
            this.btnCohenShutherland = new FontAwesome.Sharp.IconButton();
            this.btnFloodBFS = new FontAwesome.Sharp.IconButton();
            this.btnFloodDFS = new FontAwesome.Sharp.IconButton();
            this.FrmEllipse = new FontAwesome.Sharp.IconButton();
            this.btnMidPoint = new FontAwesome.Sharp.IconButton();
            this.btnBresenham = new FontAwesome.Sharp.IconButton();
            this.btnDDA = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnQuit = new FontAwesome.Sharp.IconButton();
            this.btnGithub = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(112, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Interactive Graphical Algorithms App";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.btnQuit);
            this.panel1.Controls.Add(this.btnGithub);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 69);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::InteractiveGraphicalApp.Properties.Resources.wallpaperjpg;
            this.panel2.Controls.Add(this.btnBSplines);
            this.panel2.Controls.Add(this.btnBezier);
            this.panel2.Controls.Add(this.btnShutherlandHodgeman);
            this.panel2.Controls.Add(this.btnCohenShutherland);
            this.panel2.Controls.Add(this.btnFloodBFS);
            this.panel2.Controls.Add(this.btnFloodDFS);
            this.panel2.Controls.Add(this.FrmEllipse);
            this.panel2.Controls.Add(this.btnMidPoint);
            this.panel2.Controls.Add(this.btnBresenham);
            this.panel2.Controls.Add(this.btnDDA);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(-3, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 518);
            this.panel2.TabIndex = 5;
            // 
            // btnBSplines
            // 
            this.btnBSplines.BackColor = System.Drawing.Color.DarkGreen;
            this.btnBSplines.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBSplines.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBSplines.IconChar = FontAwesome.Sharp.IconChar.BezierCurve;
            this.btnBSplines.IconColor = System.Drawing.Color.White;
            this.btnBSplines.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnBSplines.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBSplines.Location = new System.Drawing.Point(623, 193);
            this.btnBSplines.Name = "btnBSplines";
            this.btnBSplines.Size = new System.Drawing.Size(172, 61);
            this.btnBSplines.TabIndex = 14;
            this.btnBSplines.Text = "B-splines";
            this.btnBSplines.UseVisualStyleBackColor = false;
            this.btnBSplines.Click += new System.EventHandler(this.btnBSplines_Click);
            // 
            // btnBezier
            // 
            this.btnBezier.BackColor = System.Drawing.Color.DarkGreen;
            this.btnBezier.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBezier.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBezier.IconChar = FontAwesome.Sharp.IconChar.BezierCurve;
            this.btnBezier.IconColor = System.Drawing.Color.White;
            this.btnBezier.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnBezier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBezier.Location = new System.Drawing.Point(623, 92);
            this.btnBezier.Name = "btnBezier";
            this.btnBezier.Size = new System.Drawing.Size(172, 61);
            this.btnBezier.TabIndex = 13;
            this.btnBezier.Text = "Bezier";
            this.btnBezier.UseVisualStyleBackColor = false;
            this.btnBezier.Click += new System.EventHandler(this.btnBezier_Click);
            // 
            // btnShutherlandHodgeman
            // 
            this.btnShutherlandHodgeman.BackColor = System.Drawing.Color.DarkGreen;
            this.btnShutherlandHodgeman.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShutherlandHodgeman.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShutherlandHodgeman.IconChar = FontAwesome.Sharp.IconChar.Cut;
            this.btnShutherlandHodgeman.IconColor = System.Drawing.Color.White;
            this.btnShutherlandHodgeman.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnShutherlandHodgeman.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShutherlandHodgeman.Location = new System.Drawing.Point(437, 193);
            this.btnShutherlandHodgeman.Name = "btnShutherlandHodgeman";
            this.btnShutherlandHodgeman.Size = new System.Drawing.Size(172, 61);
            this.btnShutherlandHodgeman.TabIndex = 12;
            this.btnShutherlandHodgeman.Text = "Sutherland–Ho...";
            this.btnShutherlandHodgeman.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShutherlandHodgeman.UseVisualStyleBackColor = false;
            this.btnShutherlandHodgeman.Click += new System.EventHandler(this.btnShutherlandHodgeman_Click);
            // 
            // btnCohenShutherland
            // 
            this.btnCohenShutherland.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCohenShutherland.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCohenShutherland.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCohenShutherland.IconChar = FontAwesome.Sharp.IconChar.Cut;
            this.btnCohenShutherland.IconColor = System.Drawing.Color.White;
            this.btnCohenShutherland.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCohenShutherland.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCohenShutherland.Location = new System.Drawing.Point(437, 92);
            this.btnCohenShutherland.Name = "btnCohenShutherland";
            this.btnCohenShutherland.Size = new System.Drawing.Size(172, 61);
            this.btnCohenShutherland.TabIndex = 11;
            this.btnCohenShutherland.Text = "Cohen-Shuther...";
            this.btnCohenShutherland.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCohenShutherland.UseVisualStyleBackColor = false;
            this.btnCohenShutherland.Click += new System.EventHandler(this.btnCohenShutherland_Click);
            // 
            // btnFloodBFS
            // 
            this.btnFloodBFS.BackColor = System.Drawing.Color.DarkGreen;
            this.btnFloodBFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFloodBFS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFloodBFS.IconChar = FontAwesome.Sharp.IconChar.FillDrip;
            this.btnFloodBFS.IconColor = System.Drawing.Color.White;
            this.btnFloodBFS.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnFloodBFS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFloodBFS.Location = new System.Drawing.Point(245, 193);
            this.btnFloodBFS.Name = "btnFloodBFS";
            this.btnFloodBFS.Size = new System.Drawing.Size(172, 61);
            this.btnFloodBFS.TabIndex = 10;
            this.btnFloodBFS.Text = "Flood BFS";
            this.btnFloodBFS.UseVisualStyleBackColor = false;
            this.btnFloodBFS.Click += new System.EventHandler(this.btnFloodBFS_Click);
            // 
            // btnFloodDFS
            // 
            this.btnFloodDFS.BackColor = System.Drawing.Color.DarkGreen;
            this.btnFloodDFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFloodDFS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFloodDFS.IconChar = FontAwesome.Sharp.IconChar.FillDrip;
            this.btnFloodDFS.IconColor = System.Drawing.Color.White;
            this.btnFloodDFS.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnFloodDFS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFloodDFS.Location = new System.Drawing.Point(245, 92);
            this.btnFloodDFS.Name = "btnFloodDFS";
            this.btnFloodDFS.Size = new System.Drawing.Size(172, 61);
            this.btnFloodDFS.TabIndex = 9;
            this.btnFloodDFS.Text = "Flood DFS";
            this.btnFloodDFS.UseVisualStyleBackColor = false;
            this.btnFloodDFS.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // FrmEllipse
            // 
            this.FrmEllipse.BackColor = System.Drawing.Color.DarkGreen;
            this.FrmEllipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrmEllipse.ForeColor = System.Drawing.SystemColors.Control;
            this.FrmEllipse.IconChar = FontAwesome.Sharp.IconChar.PencilRuler;
            this.FrmEllipse.IconColor = System.Drawing.Color.White;
            this.FrmEllipse.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.FrmEllipse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FrmEllipse.Location = new System.Drawing.Point(52, 378);
            this.FrmEllipse.Name = "FrmEllipse";
            this.FrmEllipse.Size = new System.Drawing.Size(172, 61);
            this.FrmEllipse.TabIndex = 8;
            this.FrmEllipse.Text = "Ellipse";
            this.FrmEllipse.UseVisualStyleBackColor = false;
            this.FrmEllipse.Click += new System.EventHandler(this.FrmEllipse_Click);
            // 
            // btnMidPoint
            // 
            this.btnMidPoint.BackColor = System.Drawing.Color.DarkGreen;
            this.btnMidPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMidPoint.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMidPoint.IconChar = FontAwesome.Sharp.IconChar.PencilRuler;
            this.btnMidPoint.IconColor = System.Drawing.Color.White;
            this.btnMidPoint.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMidPoint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMidPoint.Location = new System.Drawing.Point(52, 288);
            this.btnMidPoint.Name = "btnMidPoint";
            this.btnMidPoint.Size = new System.Drawing.Size(172, 61);
            this.btnMidPoint.TabIndex = 7;
            this.btnMidPoint.Text = "Mid Point";
            this.btnMidPoint.UseVisualStyleBackColor = false;
            this.btnMidPoint.Click += new System.EventHandler(this.btnMidPoint_Click);
            // 
            // btnBresenham
            // 
            this.btnBresenham.BackColor = System.Drawing.Color.DarkGreen;
            this.btnBresenham.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBresenham.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBresenham.IconChar = FontAwesome.Sharp.IconChar.PencilRuler;
            this.btnBresenham.IconColor = System.Drawing.Color.White;
            this.btnBresenham.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnBresenham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBresenham.Location = new System.Drawing.Point(52, 193);
            this.btnBresenham.Name = "btnBresenham";
            this.btnBresenham.Size = new System.Drawing.Size(172, 61);
            this.btnBresenham.TabIndex = 6;
            this.btnBresenham.Text = "Bresenham";
            this.btnBresenham.UseVisualStyleBackColor = false;
            this.btnBresenham.Click += new System.EventHandler(this.btnBresenham_Click);
            // 
            // btnDDA
            // 
            this.btnDDA.BackColor = System.Drawing.Color.DarkGreen;
            this.btnDDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDDA.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDDA.IconChar = FontAwesome.Sharp.IconChar.PencilRuler;
            this.btnDDA.IconColor = System.Drawing.Color.White;
            this.btnDDA.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnDDA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDDA.Location = new System.Drawing.Point(52, 92);
            this.btnDDA.Name = "btnDDA";
            this.btnDDA.Size = new System.Drawing.Size(172, 61);
            this.btnDDA.TabIndex = 5;
            this.btnDDA.Text = "DDA";
            this.btnDDA.UseVisualStyleBackColor = false;
            this.btnDDA.Click += new System.EventHandler(this.btnDDA_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.ForestGreen;
            this.label5.Location = new System.Drawing.Point(643, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Curves";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(295, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Filling";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(87, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rasterize";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.ForestGreen;
            this.label4.Location = new System.Drawing.Point(450, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cliping";
            // 
            // btnQuit
            // 
            this.btnQuit.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnQuit.IconColor = System.Drawing.Color.Black;
            this.btnQuit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQuit.IconSize = 12;
            this.btnQuit.Location = new System.Drawing.Point(758, 14);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(37, 32);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnGithub
            // 
            this.btnGithub.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGithub.IconChar = FontAwesome.Sharp.IconChar.Github;
            this.btnGithub.IconColor = System.Drawing.Color.White;
            this.btnGithub.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGithub.Location = new System.Drawing.Point(15, 11);
            this.btnGithub.Name = "btnGithub";
            this.btnGithub.Size = new System.Drawing.Size(56, 48);
            this.btnGithub.TabIndex = 1;
            this.btnGithub.UseVisualStyleBackColor = false;
            this.btnGithub.Click += new System.EventHandler(this.btnGithub_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 579);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHome";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnGithub;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnDDA;
        private FontAwesome.Sharp.IconButton btnBresenham;
        private FontAwesome.Sharp.IconButton btnFloodDFS;
        private FontAwesome.Sharp.IconButton FrmEllipse;
        private FontAwesome.Sharp.IconButton btnMidPoint;
        private FontAwesome.Sharp.IconButton btnBezier;
        private FontAwesome.Sharp.IconButton btnShutherlandHodgeman;
        private FontAwesome.Sharp.IconButton btnCohenShutherland;
        private FontAwesome.Sharp.IconButton btnFloodBFS;
        private FontAwesome.Sharp.IconButton btnBSplines;
        private FontAwesome.Sharp.IconButton btnQuit;
    }
}