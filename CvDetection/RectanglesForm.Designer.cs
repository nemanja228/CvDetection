namespace CvDetection
{
    partial class RectanglesForm
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
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.buttonColorPicker = new System.Windows.Forms.Button();
            this.panelColor = new System.Windows.Forms.Panel();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonResetContours = new System.Windows.Forms.Button();
            this.buttonContours = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonColorPicker
            // 
            this.buttonColorPicker.Location = new System.Drawing.Point(6, 19);
            this.buttonColorPicker.Name = "buttonColorPicker";
            this.buttonColorPicker.Size = new System.Drawing.Size(119, 33);
            this.buttonColorPicker.TabIndex = 0;
            this.buttonColorPicker.Text = "Choose Color";
            this.buttonColorPicker.UseVisualStyleBackColor = true;
            this.buttonColorPicker.Click += new System.EventHandler(this.buttonColorPicker_Click);
            // 
            // panelColor
            // 
            this.panelColor.Location = new System.Drawing.Point(158, 19);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(119, 33);
            this.panelColor.TabIndex = 1;
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(158, 69);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(119, 20);
            this.textBoxSize.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Minimum Rectangle Size:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonColorPicker);
            this.groupBox1.Controls.Add(this.panelColor);
            this.groupBox1.Controls.Add(this.textBoxSize);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 103);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters:";
            // 
            // buttonResetContours
            // 
            this.buttonResetContours.Location = new System.Drawing.Point(170, 134);
            this.buttonResetContours.Name = "buttonResetContours";
            this.buttonResetContours.Size = new System.Drawing.Size(75, 23);
            this.buttonResetContours.TabIndex = 11;
            this.buttonResetContours.Text = "Hide";
            this.buttonResetContours.UseVisualStyleBackColor = true;
            this.buttonResetContours.Click += new System.EventHandler(this.buttonResetContours_Click);
            // 
            // buttonContours
            // 
            this.buttonContours.Location = new System.Drawing.Point(62, 134);
            this.buttonContours.Name = "buttonContours";
            this.buttonContours.Size = new System.Drawing.Size(75, 23);
            this.buttonContours.TabIndex = 10;
            this.buttonContours.Text = "Show";
            this.buttonContours.UseVisualStyleBackColor = true;
            this.buttonContours.Click += new System.EventHandler(this.buttonContours_Click);
            // 
            // RectanglesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 168);
            this.Controls.Add(this.buttonResetContours);
            this.Controls.Add(this.buttonContours);
            this.Controls.Add(this.groupBox1);
            this.Name = "RectanglesForm";
            this.Text = "Detect Rectangles";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button buttonColorPicker;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonResetContours;
        private System.Windows.Forms.Button buttonContours;
    }
}