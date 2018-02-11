using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.CV.Util;

namespace CvDetection
{
    public partial class MainForm : Form
    {
        private FiltersForm filtersForm;
        private RectanglesForm rectanglesForm;

        private Bitmap originalImage;
        private Mat originalMat;

        public int Brightness { get; set; }
        public double Contrast { get; set; }

        public MainForm()
        {
            InitializeComponent();
            Brightness = 0;
            Contrast = 1.0;
            originalImage = global::CvDetection.Properties.Resources.Lena;
            originalMat = new Image<Bgr, Byte>(originalImage).Mat;
            image.Image = originalImage;
        }

        public void ApplyFilters()
        {
            try
            {
                Mat newMat = new Mat();
                originalMat.ConvertTo(newMat, DepthType.Default, Contrast, Brightness);
                image.Image = new Bitmap(newMat.Bitmap);
                newMat.Dispose();
            }
            catch(Exception exc)
            {
                Debug.Print(exc.Message);
            }
        }

        public void FindContours()
        {
            Image<Gray, byte> img = originalMat.ToImage<Bgr, byte>().Canny(127, 255);
            VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
            Mat mat = new Mat();

            CvInvoke.FindContours(img, contours, mat, RetrType.External, ChainApproxMethod.ChainApproxSimple);

            Image<Bgr, byte> imgOut = new Image<Bgr, byte>(originalImage);
            CvInvoke.DrawContours(imgOut, contours, -1, new MCvScalar(0, 0, 255));
            image.Image = new Bitmap(imgOut.Bitmap);
            imgOut.Dispose();
        }

        public void ResetImage()
        {
            image.Image = originalImage;
        }

        private void filtersButton_Click(object sender, EventArgs e)
        {
            if(filtersForm == null || filtersForm.IsDisposed)
            {
                filtersForm = new FiltersForm(this);
                filtersForm.Show();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Filter = "";

            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            string sep = string.Empty;
            codecs = codecs.Reverse().ToArray();
            foreach (var c in codecs)
            {
                string codecName = c.CodecName.Substring(8).Replace("Codec", "Files").Trim();
                fileDialog.Filter = String.Format("{0}{1}{2} ({3})|{3}", fileDialog.Filter, sep, codecName, c.FilenameExtension);
                sep = "|";
            }

            fileDialog.DefaultExt = ".png"; // Default file extension 

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Bitmap(fileDialog.FileName);
                originalMat = new Image<Bgr, Byte>(originalImage).Mat;
                image.Image = originalImage;
                if (filtersForm != null && !filtersForm.IsDisposed)
                {
                    filtersForm.ResetUI();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image.Image = originalImage;
            if (filtersForm != null && !filtersForm.IsDisposed)
            {
                filtersForm.ResetUI();
            }
            if (rectanglesForm != null && !rectanglesForm.IsDisposed)
            {
                rectanglesForm.ResetUI();
            }
        }

        private void findRectanglesButton_Click(object sender, EventArgs e)
        {
            FindRectangles(20000, Color.FromArgb(255, Color.Blue));
            //if (rectanglesForm == null || rectanglesForm.IsDisposed)
            //{
            //    rectanglesForm = new RectanglesForm(this);
            //    rectanglesForm.Show();
            //}
        }

        public void FindRectangles(double minSize, Color matchingColor)
        {
            //TOD: add blur
            Image<Gray, byte> img = originalMat.ToImage<Bgr, byte>().Canny(127, 255);

            VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
            Mat mat = new Mat();

            CvInvoke.FindContours(img, contours, mat, RetrType.External, ChainApproxMethod.ChainApproxSimple);

            VectorOfPoint contour = new VectorOfPoint();
            VectorOfVectorOfPoint squares = new VectorOfVectorOfPoint();

            for (int i = 0; i < contours.Size; i++)
            {
                CvInvoke.ApproxPolyDP(contours[i], contour, CvInvoke.ArcLength(contours[i], true) * 0.02, true);
                if (contour.Size == 4 && Math.Abs(CvInvoke.ContourArea(contour)) > minSize && CvInvoke.IsContourConvex(contour))
                {
                    Rectangle rect = CvInvoke.BoundingRectangle(contour);
                    Rectangle maskRect = new Rectangle(rect.Location, rect.Size);

                    Size inflateSize = new Size((int)(maskRect.Width * -0.1), (int)(maskRect.Height * -0.1));
                    maskRect.Inflate(inflateSize);

                    Mat shapeMat = new Mat(originalMat, maskRect);
                    
                    int[] colorScalars = CvInvoke.Mean(shapeMat).ToArray().Select(x => (int)x).ToArray();
                    Color color = Color.FromArgb(255, colorScalars[2], colorScalars[1], colorScalars[0]);

                    if(color.ToArgb() == matchingColor.ToArgb())
                    {
                        double maxCosine = 0.0;

                        for (int j = 2; j < 5; j++)
                        {
                            double cosine = Math.Abs(Angle(contour[j % 4], contour[j - 2], contour[j - 1]));
                            maxCosine = cosine > maxCosine ? cosine : maxCosine;
                        }

                        if (maxCosine < 0.3)
                            squares.Push(contour);
                    }                    
                }
            }

            Image<Bgr, byte> imgOut = new Image<Bgr, byte>(originalImage);
            CvInvoke.DrawContours(imgOut, squares, -1, new MCvScalar(0, 0, 255));
            image.Image = new Bitmap(imgOut.Bitmap);
            imgOut.Dispose();
        }

        private double Angle(Point pt1, Point pt2, Point pt0)
        {
            double dx1 = pt1.X - pt0.X;
            double dy1 = pt1.Y - pt0.Y;
            double dx2 = pt2.X - pt0.X;
            double dy2 = pt2.Y - pt0.Y;
            return (dx1 * dx2 + dy1 * dy2) / Math.Sqrt((dx1 * dx1 + dy1 * dy1) * (dx2 * dx2 + dy2 * dy2) + 1e-10);
        }
    }
}
