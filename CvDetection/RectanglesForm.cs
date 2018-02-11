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
        }

        public void ResetUI()
        {

        }
    }
}
