using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InteractiveGraphicalApp.Presentation.Forms.Templates
{
    public partial class FrmSupport : Form
    {
        public FrmSupport()
        {
            InitializeComponent();

        }

        public FrmSupport(string filepath)
        {
            InitializeComponent();
            wVSupport = new Microsoft.Web.WebView2.WinForms.WebView2();
            wVSupport.Dock = DockStyle.Fill;
            this.Controls.Add(wVSupport);
            this.Load += async (sender, e) =>
            {
                await wVSupport.EnsureCoreWebView2Async();
                wVSupport.Source = new Uri(filepath);
            };

        }
    }
}
