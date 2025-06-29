using InteractiveGraphicalApp.Infraestructure;
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
    public partial class FrmConfig : Form
    {
        public FrmConfig()
        {
            InitializeComponent();
            btnFillPicker.BackColor = Config.Instance.FillColor;
            btnLinePicker.BackColor = Config.Instance.LineColor;
            tbAnimationDelay.Value = Config.Instance.AnimationDelay;
            tbAnimationDelay.Minimum = 0;
            tbAnimationDelay.Maximum = 10;
            tbLineAnchor.Value = Config.Instance.LineAnchors;
            tbLineAnchor.Minimum = 1;
            tbLineAnchor.Maximum = 5;
            txtAnchor.Text = Config.Instance.LineAnchors.ToString();
            txtAnimationDelay.Text = Config.Instance.AnimationDelay.ToString();
        }

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            Config.Instance.AnimationDelay = tbAnimationDelay.Value;
            txtAnimationDelay.Text = Config.Instance.AnimationDelay.ToString();
        }

        private void txtAnimationDelay_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbLineAnchor_Scroll(object sender, ScrollEventArgs e)
        {
            Config.Instance.LineAnchors = tbLineAnchor.Value;
            txtAnchor.Text = Config.Instance.LineAnchors.ToString();
        }

        private void btnLinePicker_Click(object sender, EventArgs e)
        {
            //open color picker
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.Color = Config.Instance.LineColor;
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Config.Instance.LineColor = colorDialog.Color;
                    btnLinePicker.BackColor = Config.Instance.LineColor;
                }
            }
        }

        private void btnFillPicker_Click(object sender, EventArgs e)
        {
            //open color picker
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.Color = Config.Instance.FillColor;
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Config.Instance.FillColor = colorDialog.Color;
                    btnFillPicker.BackColor = Config.Instance.FillColor;
                }
            }
        }
    }
}
