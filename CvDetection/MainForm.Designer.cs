using Emgu.CV;
using Emgu.CV.CvEnum;

namespace CvDetection
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuToolStrip = new System.Windows.Forms.ToolStrip();
            this.fileDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersButton = new System.Windows.Forms.ToolStripButton();
            this.findRectanglesButton = new System.Windows.Forms.ToolStripButton();
            this.image = new System.Windows.Forms.PictureBox();
            this.menuToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // menuToolStrip
            // 
            this.menuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileDropDown,
            this.filtersButton,
            this.findRectanglesButton});
            this.menuToolStrip.Location = new System.Drawing.Point(0, 0);
            this.menuToolStrip.Name = "menuToolStrip";
            this.menuToolStrip.Size = new System.Drawing.Size(512, 25);
            this.menuToolStrip.TabIndex = 0;
            // 
            // fileDropDown
            // 
            this.fileDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileDropDown.Image = ((System.Drawing.Image)(resources.GetObject("fileDropDown.Image")));
            this.fileDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileDropDown.Name = "fileDropDown";
            this.fileDropDown.Size = new System.Drawing.Size(38, 22);
            this.fileDropDown.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.resetToolStripMenuItem.Text = "Reset all filters";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // filtersButton
            // 
            this.filtersButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.filtersButton.Image = ((System.Drawing.Image)(resources.GetObject("filtersButton.Image")));
            this.filtersButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.filtersButton.Name = "filtersButton";
            this.filtersButton.Size = new System.Drawing.Size(42, 22);
            this.filtersButton.Text = "Filters";
            this.filtersButton.Click += new System.EventHandler(this.filtersButton_Click);
            // 
            // findRectanglesButton
            // 
            this.findRectanglesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.findRectanglesButton.Image = ((System.Drawing.Image)(resources.GetObject("findRectanglesButton.Image")));
            this.findRectanglesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.findRectanglesButton.Name = "findRectanglesButton";
            this.findRectanglesButton.Size = new System.Drawing.Size(94, 22);
            this.findRectanglesButton.Text = "Find Rectangles";
            this.findRectanglesButton.Click += new System.EventHandler(this.findRectanglesButton_Click);
            // 
            // image
            // 
            this.image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.image.InitialImage = global::CvDetection.Properties.Resources.Lena;
            this.image.Location = new System.Drawing.Point(0, 25);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(512, 501);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.image.TabIndex = 1;
            this.image.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(512, 526);
            this.Controls.Add(this.image);
            this.Controls.Add(this.menuToolStrip);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CvDetection";
            this.menuToolStrip.ResumeLayout(false);
            this.menuToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip menuToolStrip;
        private System.Windows.Forms.ToolStripDropDownButton fileDropDown;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton filtersButton;
        private System.Windows.Forms.ToolStripButton findRectanglesButton;
        private System.Windows.Forms.PictureBox image;
    }
}

