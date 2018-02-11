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
    public partial class FiltersForm : Form
    {
        private MainForm parent;

        public FiltersForm(MainForm mainForm)
        {
            InitializeComponent();

            parent = mainForm;
        }

        private void buttonBrightness_Click(object sender, EventArgs e)
        {
            trackBarBrightness.Value = 50;
            ApplyFilters();
        }

        private void buttonContrast_Click(object sender, EventArgs e)
        {
            trackBarContrast.Value = 50;
            ApplyFilters();
        }

        private void trackBarBrightness_Scroll(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void trackBarContrast_Scroll(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            parent.Brightness = trackBarBrightness.Value - 50;
            parent.Contrast = trackBarContrast.Value / 50.0;
            parent.ApplyFilters();
        }

        public void ResetUI()
        {
            trackBarBrightness.Value = 50;
            trackBarContrast.Value = 50;
        }

        private void buttonContours_Click(object sender, EventArgs e)
        {
            ResetUI();
            parent.FindContours();
        }

        private void buttonResetContours_Click(object sender, EventArgs e)
        {
            parent.ResetImage();
        }
    }
}
