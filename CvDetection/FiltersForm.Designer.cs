namespace CvDetection
{
    partial class FiltersForm
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
            this.groupBrightness = new System.Windows.Forms.GroupBox();
            this.buttonBrightness = new System.Windows.Forms.Button();
            this.trackBarBrightness = new System.Windows.Forms.TrackBar();
            this.groupdContrast = new System.Windows.Forms.GroupBox();
            this.buttonContrast = new System.Windows.Forms.Button();
            this.trackBarContrast = new System.Windows.Forms.TrackBar();
            this.groupContours = new System.Windows.Forms.GroupBox();
            this.buttonResetContours = new System.Windows.Forms.Button();
            this.buttonContours = new System.Windows.Forms.Button();
            this.groupBrightness.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
            this.groupdContrast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).BeginInit();
            this.groupContours.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBrightness
            // 
            this.groupBrightness.Controls.Add(this.buttonBrightness);
            this.groupBrightness.Controls.Add(this.trackBarBrightness);
            this.groupBrightness.Location = new System.Drawing.Point(12, 12);
            this.groupBrightness.Name = "groupBrightness";
            this.groupBrightness.Size = new System.Drawing.Size(327, 80);
            this.groupBrightness.TabIndex = 0;
            this.groupBrightness.TabStop = false;
            this.groupBrightness.Text = "Brightness";
            // 
            // buttonBrightness
            // 
            this.buttonBrightness.Location = new System.Drawing.Point(232, 29);
            this.buttonBrightness.Name = "buttonBrightness";
            this.buttonBrightness.Size = new System.Drawing.Size(75, 23);
            this.buttonBrightness.TabIndex = 1;
            this.buttonBrightness.Text = "Reset";
            this.buttonBrightness.UseVisualStyleBackColor = true;
            this.buttonBrightness.Click += new System.EventHandler(this.buttonBrightness_Click);
            // 
            // trackBarBrightness
            // 
            this.trackBarBrightness.Location = new System.Drawing.Point(19, 29);
            this.trackBarBrightness.Maximum = 100;
            this.trackBarBrightness.Name = "trackBarBrightness";
            this.trackBarBrightness.Size = new System.Drawing.Size(188, 45);
            this.trackBarBrightness.TabIndex = 0;
            this.trackBarBrightness.Value = 50;
            this.trackBarBrightness.Scroll += new System.EventHandler(this.trackBarBrightness_Scroll);
            // 
            // groupdContrast
            // 
            this.groupdContrast.Controls.Add(this.buttonContrast);
            this.groupdContrast.Controls.Add(this.trackBarContrast);
            this.groupdContrast.Location = new System.Drawing.Point(12, 98);
            this.groupdContrast.Name = "groupdContrast";
            this.groupdContrast.Size = new System.Drawing.Size(327, 80);
            this.groupdContrast.TabIndex = 1;
            this.groupdContrast.TabStop = false;
            this.groupdContrast.Text = "Contrast";
            // 
            // buttonContrast
            // 
            this.buttonContrast.Location = new System.Drawing.Point(232, 29);
            this.buttonContrast.Name = "buttonContrast";
            this.buttonContrast.Size = new System.Drawing.Size(75, 23);
            this.buttonContrast.TabIndex = 2;
            this.buttonContrast.Text = "Reset";
            this.buttonContrast.UseVisualStyleBackColor = true;
            this.buttonContrast.Click += new System.EventHandler(this.buttonContrast_Click);
            // 
            // trackBarContrast
            // 
            this.trackBarContrast.Location = new System.Drawing.Point(19, 29);
            this.trackBarContrast.Maximum = 100;
            this.trackBarContrast.Name = "trackBarContrast";
            this.trackBarContrast.Size = new System.Drawing.Size(188, 45);
            this.trackBarContrast.TabIndex = 1;
            this.trackBarContrast.Value = 50;
            this.trackBarContrast.Scroll += new System.EventHandler(this.trackBarContrast_Scroll);
            // 
            // groupContours
            // 
            this.groupContours.Controls.Add(this.buttonResetContours);
            this.groupContours.Controls.Add(this.buttonContours);
            this.groupContours.Location = new System.Drawing.Point(12, 184);
            this.groupContours.Name = "groupContours";
            this.groupContours.Size = new System.Drawing.Size(327, 80);
            this.groupContours.TabIndex = 2;
            this.groupContours.TabStop = false;
            this.groupContours.Text = "Contours";
            // 
            // buttonResetContours
            // 
            this.buttonResetContours.Location = new System.Drawing.Point(232, 39);
            this.buttonResetContours.Name = "buttonResetContours";
            this.buttonResetContours.Size = new System.Drawing.Size(75, 23);
            this.buttonResetContours.TabIndex = 3;
            this.buttonResetContours.Text = "Hide";
            this.buttonResetContours.UseVisualStyleBackColor = true;
            this.buttonResetContours.Click += new System.EventHandler(this.buttonResetContours_Click);
            // 
            // buttonContours
            // 
            this.buttonContours.Location = new System.Drawing.Point(132, 39);
            this.buttonContours.Name = "buttonContours";
            this.buttonContours.Size = new System.Drawing.Size(75, 23);
            this.buttonContours.TabIndex = 0;
            this.buttonContours.Text = "Show";
            this.buttonContours.UseVisualStyleBackColor = true;
            this.buttonContours.Click += new System.EventHandler(this.buttonContours_Click);
            // 
            // FiltersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 276);
            this.Controls.Add(this.groupContours);
            this.Controls.Add(this.groupdContrast);
            this.Controls.Add(this.groupBrightness);
            this.Name = "FiltersForm";
            this.Text = "Filters";
            this.groupBrightness.ResumeLayout(false);
            this.groupBrightness.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
            this.groupdContrast.ResumeLayout(false);
            this.groupdContrast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).EndInit();
            this.groupContours.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBrightness;
        private System.Windows.Forms.GroupBox groupdContrast;
        private System.Windows.Forms.GroupBox groupContours;
        private System.Windows.Forms.TrackBar trackBarBrightness;
        private System.Windows.Forms.TrackBar trackBarContrast;
        private System.Windows.Forms.Button buttonBrightness;
        private System.Windows.Forms.Button buttonContrast;
        private System.Windows.Forms.Button buttonContours;
        private System.Windows.Forms.Button buttonResetContours;
    }
}