namespace InteractiveGraphicalApp.Presentation.Forms
{
    partial class FrmFillFloodDFS
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
            this.btnShape = new FontAwesome.Sharp.IconButton();
            this.btnStar = new FontAwesome.Sharp.IconButton();
            this.btnFill = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSide = new Guna.UI2.WinForms.Guna2TrackBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumberSides = new System.Windows.Forms.TextBox();
            this.tbNumberSides = new Guna.UI2.WinForms.Guna2TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSide = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOutter = new System.Windows.Forms.TextBox();
            this.tbOutter = new Guna.UI2.WinForms.Guna2TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInner = new System.Windows.Forms.TextBox();
            this.tbInner = new Guna.UI2.WinForms.Guna2TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTips = new System.Windows.Forms.TextBox();
            this.tbTips = new Guna.UI2.WinForms.Guna2TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShape
            // 
            this.btnShape.IconChar = FontAwesome.Sharp.IconChar.Shapes;
            this.btnShape.IconColor = System.Drawing.Color.Black;
            this.btnShape.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShape.Location = new System.Drawing.Point(24, 86);
            this.btnShape.Name = "btnShape";
            this.btnShape.Size = new System.Drawing.Size(58, 56);
            this.btnShape.TabIndex = 8;
            this.btnShape.UseVisualStyleBackColor = true;
            this.btnShape.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // btnStar
            // 
            this.btnStar.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.btnStar.IconColor = System.Drawing.Color.Black;
            this.btnStar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStar.Location = new System.Drawing.Point(88, 86);
            this.btnStar.Name = "btnStar";
            this.btnStar.Size = new System.Drawing.Size(58, 56);
            this.btnStar.TabIndex = 9;
            this.btnStar.UseVisualStyleBackColor = true;
            this.btnStar.Click += new System.EventHandler(this.btnStar_Click);
            // 
            // btnFill
            // 
            this.btnFill.IconChar = FontAwesome.Sharp.IconChar.Fill;
            this.btnFill.IconColor = System.Drawing.Color.Black;
            this.btnFill.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFill.Location = new System.Drawing.Point(152, 86);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(58, 56);
            this.btnFill.TabIndex = 10;
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shape";
            // 
            // tbSide
            // 
            this.tbSide.Location = new System.Drawing.Point(15, 51);
            this.tbSide.Name = "tbSide";
            this.tbSide.Size = new System.Drawing.Size(186, 18);
            this.tbSide.TabIndex = 1;
            this.tbSide.ThumbColor = System.Drawing.Color.ForestGreen;
            this.tbSide.Scroll += new System.Windows.Forms.ScrollEventHandler(this.tbSide_Scroll);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtNumberSides);
            this.panel4.Controls.Add(this.tbNumberSides);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtSide);
            this.panel4.Controls.Add(this.tbSide);
            this.panel4.Location = new System.Drawing.Point(12, 176);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(230, 146);
            this.panel4.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "N Sides:";
            // 
            // txtNumberSides
            // 
            this.txtNumberSides.Location = new System.Drawing.Point(110, 76);
            this.txtNumberSides.Name = "txtNumberSides";
            this.txtNumberSides.Size = new System.Drawing.Size(88, 22);
            this.txtNumberSides.TabIndex = 14;
            this.txtNumberSides.TextChanged += new System.EventHandler(this.txtNumberSides_TextChanged);
            // 
            // tbNumberSides
            // 
            this.tbNumberSides.Location = new System.Drawing.Point(15, 115);
            this.tbNumberSides.Name = "tbNumberSides";
            this.tbNumberSides.Size = new System.Drawing.Size(186, 18);
            this.tbNumberSides.TabIndex = 13;
            this.tbNumberSides.ThumbColor = System.Drawing.Color.ForestGreen;
            this.tbNumberSides.Scroll += new System.Windows.Forms.ScrollEventHandler(this.tbNumberSides_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Side (px):";
            // 
            // txtSide
            // 
            this.txtSide.Location = new System.Drawing.Point(110, 12);
            this.txtSide.Name = "txtSide";
            this.txtSide.Size = new System.Drawing.Size(88, 22);
            this.txtSide.TabIndex = 2;
            this.txtSide.TextChanged += new System.EventHandler(this.txtSide_TextChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.txtTips);
            this.panel5.Controls.Add(this.tbTips);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.txtOutter);
            this.panel5.Controls.Add(this.tbOutter);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txtInner);
            this.panel5.Controls.Add(this.tbInner);
            this.panel5.Location = new System.Drawing.Point(12, 358);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(230, 221);
            this.panel5.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Outter Radio (px):";
            // 
            // txtOutter
            // 
            this.txtOutter.Location = new System.Drawing.Point(172, 76);
            this.txtOutter.Name = "txtOutter";
            this.txtOutter.Size = new System.Drawing.Size(41, 22);
            this.txtOutter.TabIndex = 14;
            this.txtOutter.TextChanged += new System.EventHandler(this.txtOutter_TextChanged);
            // 
            // tbOutter
            // 
            this.tbOutter.Location = new System.Drawing.Point(15, 115);
            this.tbOutter.Name = "tbOutter";
            this.tbOutter.Size = new System.Drawing.Size(186, 18);
            this.tbOutter.TabIndex = 13;
            this.tbOutter.ThumbColor = System.Drawing.Color.ForestGreen;
            this.tbOutter.Scroll += new System.Windows.Forms.ScrollEventHandler(this.tbOutter_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Inner Radio (px):";
            // 
            // txtInner
            // 
            this.txtInner.Location = new System.Drawing.Point(172, 12);
            this.txtInner.Name = "txtInner";
            this.txtInner.Size = new System.Drawing.Size(41, 22);
            this.txtInner.TabIndex = 2;
            this.txtInner.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbInner
            // 
            this.tbInner.Location = new System.Drawing.Point(15, 51);
            this.tbInner.Name = "tbInner";
            this.tbInner.Size = new System.Drawing.Size(186, 18);
            this.tbInner.TabIndex = 1;
            this.tbInner.ThumbColor = System.Drawing.Color.ForestGreen;
            this.tbInner.Scroll += new System.Windows.Forms.ScrollEventHandler(this.tbInner_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Star";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 603);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Number of filled pixels:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(59, 631);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(156, 22);
            this.textBox3.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Number of tips:";
            // 
            // txtTips
            // 
            this.txtTips.Location = new System.Drawing.Point(174, 148);
            this.txtTips.Name = "txtTips";
            this.txtTips.Size = new System.Drawing.Size(41, 22);
            this.txtTips.TabIndex = 20;
            // 
            // tbTips
            // 
            this.tbTips.Location = new System.Drawing.Point(17, 187);
            this.tbTips.Name = "tbTips";
            this.tbTips.Size = new System.Drawing.Size(186, 18);
            this.tbTips.TabIndex = 19;
            this.tbTips.ThumbColor = System.Drawing.Color.ForestGreen;
            this.tbTips.Scroll += new System.Windows.Forms.ScrollEventHandler(this.tbTips_Scroll);
            // 
            // FrmFillFloodDFS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 670);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.btnStar);
            this.Controls.Add(this.btnShape);
            this.Name = "FrmFillFloodDFS";
            this.Text = "FrmFillFoodDFS";
            this.Load += new System.EventHandler(this.FrmFillFloodDFS_Load);
            this.Controls.SetChildIndex(this.btnShape, 0);
            this.Controls.SetChildIndex(this.btnStar, 0);
            this.Controls.SetChildIndex(this.btnFill, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.textBox3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnShape;
        private FontAwesome.Sharp.IconButton btnStar;
        private FontAwesome.Sharp.IconButton btnFill;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TrackBar tbSide;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSide;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumberSides;
        private Guna.UI2.WinForms.Guna2TrackBar tbNumberSides;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOutter;
        private Guna.UI2.WinForms.Guna2TrackBar tbOutter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInner;
        private Guna.UI2.WinForms.Guna2TrackBar tbInner;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTips;
        private Guna.UI2.WinForms.Guna2TrackBar tbTips;
    }
}