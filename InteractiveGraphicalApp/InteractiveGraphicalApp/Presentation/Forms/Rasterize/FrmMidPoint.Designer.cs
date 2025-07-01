namespace InteractiveGraphicalApp.Presentation.Forms
{
    partial class FrmMidPoint
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
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumPoints = new System.Windows.Forms.TextBox();
            this.tbRadio = new Guna.UI2.WinForms.Guna2TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCenter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // iconButton3
            // 
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Radio (px):";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(66, 152);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(86, 22);
            this.txtRadio.TabIndex = 8;
            this.txtRadio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Number of Points:";
            // 
            // txtNumPoints
            // 
            this.txtNumPoints.Location = new System.Drawing.Point(66, 455);
            this.txtNumPoints.Name = "txtNumPoints";
            this.txtNumPoints.ReadOnly = true;
            this.txtNumPoints.Size = new System.Drawing.Size(86, 22);
            this.txtNumPoints.TabIndex = 10;
            // 
            // tbRadio
            // 
            this.tbRadio.Location = new System.Drawing.Point(50, 198);
            this.tbRadio.Name = "tbRadio";
            this.tbRadio.Size = new System.Drawing.Size(183, 29);
            this.tbRadio.TabIndex = 11;
            this.tbRadio.ThumbColor = System.Drawing.Color.ForestGreen;
            this.tbRadio.Scroll += new System.Windows.Forms.ScrollEventHandler(this.tbRadio_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "100";
            // 
            // txtCenter
            // 
            this.txtCenter.Location = new System.Drawing.Point(73, 343);
            this.txtCenter.Name = "txtCenter";
            this.txtCenter.ReadOnly = true;
            this.txtCenter.Size = new System.Drawing.Size(86, 22);
            this.txtCenter.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Center Point:";
            // 
            // FrmMidPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 606);
            this.Controls.Add(this.txtCenter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbRadio);
            this.Controls.Add(this.txtNumPoints);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.label1);
            this.Name = "FrmMidPoint";
            this.Text = "FrmMidPoint";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtRadio, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtNumPoints, 0);
            this.Controls.SetChildIndex(this.tbRadio, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtCenter, 0);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumPoints;
        private Guna.UI2.WinForms.Guna2TrackBar tbRadio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCenter;
        private System.Windows.Forms.Label label5;
    }
}