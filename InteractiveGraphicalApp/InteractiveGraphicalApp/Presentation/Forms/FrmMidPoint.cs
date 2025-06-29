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
using System.Windows.Forms;

namespace InteractiveGraphicalApp.Presentation.Forms
{
    public partial class FrmMidPoint : FrmBase
    {
        public FrmMidPoint() : base(Constants.MidPointGuidance, "MidPoint Bresenham Algorithm")
        {
            InitializeComponent();
            this.Size = new Size(830, 644);
        }
    }
}
