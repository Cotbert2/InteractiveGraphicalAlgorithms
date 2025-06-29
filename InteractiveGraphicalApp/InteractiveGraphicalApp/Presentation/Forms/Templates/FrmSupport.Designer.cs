namespace InteractiveGraphicalApp.Presentation.Forms.Templates
{
    partial class FrmSupport
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
            this.wVSupport = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.wVSupport)).BeginInit();
            this.SuspendLayout();
            // 
            // wVSupport
            // 
            this.wVSupport.AllowExternalDrop = true;
            this.wVSupport.CreationProperties = null;
            this.wVSupport.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wVSupport.Location = new System.Drawing.Point(269, 82);
            this.wVSupport.Name = "wVSupport";
            this.wVSupport.Size = new System.Drawing.Size(182, 137);
            this.wVSupport.TabIndex = 1;
            this.wVSupport.ZoomFactor = 1D;
            // 
            // FrmSupport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 633);
            this.Controls.Add(this.wVSupport);
            this.Name = "FrmSupport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSupport";
            ((System.ComponentModel.ISupportInitialize)(this.wVSupport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Web.WebView2.WinForms.WebView2 wVSupport;
    }
}