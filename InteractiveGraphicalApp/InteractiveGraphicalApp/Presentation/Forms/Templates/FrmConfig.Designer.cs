namespace InteractiveGraphicalApp.Presentation.Forms.Templates
{
    partial class FrmConfig
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
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLinePicker = new FontAwesome.Sharp.IconButton();
            this.btnFillPicker = new FontAwesome.Sharp.IconButton();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.tbAnimationDelay = new Guna.UI2.WinForms.Guna2TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbLineAnchor = new Guna.UI2.WinForms.Guna2TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAnimationDelay = new System.Windows.Forms.TextBox();
            this.txtAnchor = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 69);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(163, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Settings";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.ForestGreen;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Ivory;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Ivory;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 69;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(445, 69);
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Line Color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(240, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fill Color:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Animation Delay(ms):";
            // 
            // btnLinePicker
            // 
            this.btnLinePicker.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            this.btnLinePicker.IconColor = System.Drawing.Color.White;
            this.btnLinePicker.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLinePicker.Location = new System.Drawing.Point(156, 82);
            this.btnLinePicker.Name = "btnLinePicker";
            this.btnLinePicker.Size = new System.Drawing.Size(61, 54);
            this.btnLinePicker.TabIndex = 4;
            this.btnLinePicker.UseVisualStyleBackColor = true;
            this.btnLinePicker.Click += new System.EventHandler(this.btnLinePicker_Click);
            // 
            // btnFillPicker
            // 
            this.btnFillPicker.IconChar = FontAwesome.Sharp.IconChar.Fill;
            this.btnFillPicker.IconColor = System.Drawing.Color.White;
            this.btnFillPicker.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFillPicker.Location = new System.Drawing.Point(350, 82);
            this.btnFillPicker.Name = "btnFillPicker";
            this.btnFillPicker.Size = new System.Drawing.Size(60, 54);
            this.btnFillPicker.TabIndex = 5;
            this.btnFillPicker.UseVisualStyleBackColor = true;
            this.btnFillPicker.Click += new System.EventHandler(this.btnFillPicker_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(129, 235);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(8, 8);
            this.hScrollBar1.TabIndex = 7;
            // 
            // tbAnimationDelay
            // 
            this.tbAnimationDelay.Location = new System.Drawing.Point(37, 235);
            this.tbAnimationDelay.Name = "tbAnimationDelay";
            this.tbAnimationDelay.Size = new System.Drawing.Size(180, 23);
            this.tbAnimationDelay.TabIndex = 8;
            this.tbAnimationDelay.ThumbColor = System.Drawing.Color.ForestGreen;
            this.tbAnimationDelay.Scroll += new System.Windows.Forms.ScrollEventHandler(this.guna2TrackBar1_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(240, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Line Anchor (px):";
            // 
            // tbLineAnchor
            // 
            this.tbLineAnchor.Location = new System.Drawing.Point(244, 235);
            this.tbLineAnchor.Name = "tbLineAnchor";
            this.tbLineAnchor.Size = new System.Drawing.Size(180, 23);
            this.tbLineAnchor.TabIndex = 12;
            this.tbLineAnchor.ThumbColor = System.Drawing.Color.ForestGreen;
            this.tbLineAnchor.Scroll += new System.Windows.Forms.ScrollEventHandler(this.tbLineAnchor_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(241, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(410, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "5";
            // 
            // txtAnimationDelay
            // 
            this.txtAnimationDelay.Location = new System.Drawing.Point(93, 195);
            this.txtAnimationDelay.Name = "txtAnimationDelay";
            this.txtAnimationDelay.ReadOnly = true;
            this.txtAnimationDelay.Size = new System.Drawing.Size(64, 22);
            this.txtAnimationDelay.TabIndex = 15;
            this.txtAnimationDelay.TextChanged += new System.EventHandler(this.txtAnimationDelay_TextChanged);
            // 
            // txtAnchor
            // 
            this.txtAnchor.Location = new System.Drawing.Point(299, 195);
            this.txtAnchor.Name = "txtAnchor";
            this.txtAnchor.ReadOnly = true;
            this.txtAnchor.Size = new System.Drawing.Size(64, 22);
            this.txtAnchor.TabIndex = 16;
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 319);
            this.Controls.Add(this.txtAnchor);
            this.Controls.Add(this.txtAnimationDelay);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbLineAnchor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbAnimationDelay);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.btnFillPicker);
            this.Controls.Add(this.btnLinePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConfig";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnLinePicker;
        private FontAwesome.Sharp.IconButton btnFillPicker;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private Guna.UI2.WinForms.Guna2TrackBar tbAnimationDelay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TrackBar tbLineAnchor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAnimationDelay;
        private System.Windows.Forms.TextBox txtAnchor;
    }
}