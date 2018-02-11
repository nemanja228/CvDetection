using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CvDetection
{
    public partial class RectanglesForm : Form
    {
        private MainForm parent;

        public RectanglesForm(MainForm mainForm)
        {
            InitializeComponent();

            parent = mainForm;
            ResetUI();
        }

        public void ResetUI()
        {
            panelColor.BackColor = parent.Color;
            textBoxSize.Text = parent.SearchSize.ToString();
        }

        private void buttonColorPicker_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                panelColor.BackColor = colorDialog.Color;
                parent.Color = colorDialog.Color;
            }
        }

        private void buttonContours_Click(object sender, EventArgs e)
        {
            if(double.TryParse(textBoxSize.Text, out double size) && size > 0)
            {
                parent.SearchSize = size;
                parent.FindRectangles();
            }
            else
            {
                MessageBox.Show("Size must be a valid floating point number greater than zero!");
            }
            
        }

        private void buttonResetContours_Click(object sender, EventArgs e)
        {
            parent.ResetImage();
        }
    }
}
