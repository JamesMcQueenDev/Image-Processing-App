
namespace GUI
{
    partial class ImageView
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
            System.Windows.Forms.Button RotateRight;
            System.Windows.Forms.Button RotateLeft;
            this.MyImage = new System.Windows.Forms.PictureBox();
            this.LoadImage = new System.Windows.Forms.Button();
            this.BrightnessBar = new System.Windows.Forms.TrackBar();
            this.ContrastBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PixelateBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.SaturationAdjustBar = new System.Windows.Forms.TrackBar();
            this.SaturationBar = new System.Windows.Forms.Label();
            this.OpacityBar = new System.Windows.Forms.Label();
            this.GaussianBlurBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HueBar = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.OpacityAdjustBar = new System.Windows.Forms.TrackBar();
            RotateRight = new System.Windows.Forms.Button();
            RotateLeft = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MyImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixelateBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaturationAdjustBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GaussianBlurBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HueBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpacityAdjustBar)).BeginInit();
            this.SuspendLayout();
            // 
            // RotateRight
            // 
            RotateRight.Location = new System.Drawing.Point(60, 25);
            RotateRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            RotateRight.Name = "RotateRight";
            RotateRight.Size = new System.Drawing.Size(148, 95);
            RotateRight.TabIndex = 2;
            RotateRight.Text = "Rotate Image";
            RotateRight.UseVisualStyleBackColor = true;
            RotateRight.Click += new System.EventHandler(this.Rotate_Click);
            // 
            // RotateLeft
            // 
            RotateLeft.Location = new System.Drawing.Point(60, 139);
            RotateLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            RotateLeft.Name = "RotateLeft";
            RotateLeft.Size = new System.Drawing.Size(148, 95);
            RotateLeft.TabIndex = 3;
            RotateLeft.Text = "Flip Image";
            RotateLeft.UseVisualStyleBackColor = true;
            RotateLeft.Click += new System.EventHandler(this.Flip_Click);
            // 
            // MyImage
            // 
            this.MyImage.Location = new System.Drawing.Point(276, 14);
            this.MyImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MyImage.Name = "MyImage";
            this.MyImage.Size = new System.Drawing.Size(919, 576);
            this.MyImage.TabIndex = 0;
            this.MyImage.TabStop = false;
            // 
            // LoadImage
            // 
            this.LoadImage.Location = new System.Drawing.Point(655, 600);
            this.LoadImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoadImage.Name = "LoadImage";
            this.LoadImage.Size = new System.Drawing.Size(180, 71);
            this.LoadImage.TabIndex = 1;
            this.LoadImage.Text = "Load a New Image";
            this.LoadImage.UseVisualStyleBackColor = true;
            this.LoadImage.Click += new System.EventHandler(this.LoadImage_Click);
            // 
            // BrightnessBar
            // 
            this.BrightnessBar.Location = new System.Drawing.Point(1203, 25);
            this.BrightnessBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BrightnessBar.Maximum = 100;
            this.BrightnessBar.Minimum = -100;
            this.BrightnessBar.Name = "BrightnessBar";
            this.BrightnessBar.Size = new System.Drawing.Size(156, 69);
            this.BrightnessBar.TabIndex = 4;
            this.BrightnessBar.Value = 5;
            this.BrightnessBar.Scroll += new System.EventHandler(this.BrightnessBar_Scroll);
            // 
            // ContrastBar
            // 
            this.ContrastBar.Location = new System.Drawing.Point(1203, 104);
            this.ContrastBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ContrastBar.Maximum = 100;
            this.ContrastBar.Minimum = -100;
            this.ContrastBar.Name = "ContrastBar";
            this.ContrastBar.Size = new System.Drawing.Size(156, 69);
            this.ContrastBar.TabIndex = 5;
            this.ContrastBar.Value = 5;
            this.ContrastBar.Scroll += new System.EventHandler(this.ContrastBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1239, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Brightness";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1239, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contrast";
            // 
            // PixelateBar
            // 
            this.PixelateBar.Location = new System.Drawing.Point(1203, 488);
            this.PixelateBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PixelateBar.Name = "PixelateBar";
            this.PixelateBar.Size = new System.Drawing.Size(156, 69);
            this.PixelateBar.TabIndex = 8;
            this.PixelateBar.Scroll += new System.EventHandler(this.PixelateBar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1255, 551);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pixelate";
            // 
            // SaturationAdjustBar
            // 
            this.SaturationAdjustBar.Location = new System.Drawing.Point(1203, 183);
            this.SaturationAdjustBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaturationAdjustBar.Maximum = 100;
            this.SaturationAdjustBar.Minimum = -100;
            this.SaturationAdjustBar.Name = "SaturationAdjustBar";
            this.SaturationAdjustBar.Size = new System.Drawing.Size(156, 69);
            this.SaturationAdjustBar.TabIndex = 10;
            this.SaturationAdjustBar.Value = 5;
            this.SaturationAdjustBar.Scroll += new System.EventHandler(this.SaturationAdjustBar_Scroll);
            // 
            // SaturationBar
            // 
            this.SaturationBar.AutoSize = true;
            this.SaturationBar.Location = new System.Drawing.Point(1245, 232);
            this.SaturationBar.Name = "SaturationBar";
            this.SaturationBar.Size = new System.Drawing.Size(83, 20);
            this.SaturationBar.TabIndex = 11;
            this.SaturationBar.Text = "Saturation";
            // 
            // OpacityBar
            // 
            this.OpacityBar.AutoSize = true;
            this.OpacityBar.Location = new System.Drawing.Point(1247, 458);
            this.OpacityBar.Name = "OpacityBar";
            this.OpacityBar.Size = new System.Drawing.Size(62, 20);
            this.OpacityBar.TabIndex = 13;
            this.OpacityBar.Text = "Opacity";
            // 
            // GaussianBlurBar
            // 
            this.GaussianBlurBar.Location = new System.Drawing.Point(1203, 576);
            this.GaussianBlurBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GaussianBlurBar.Name = "GaussianBlurBar";
            this.GaussianBlurBar.Size = new System.Drawing.Size(156, 69);
            this.GaussianBlurBar.TabIndex = 14;
            this.GaussianBlurBar.Scroll += new System.EventHandler(this.GaussianBlurBar_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1230, 625);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Gaussian Blur";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            // 
            // HueBar
            // 
            this.HueBar.Location = new System.Drawing.Point(1203, 330);
            this.HueBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HueBar.Maximum = 360;
            this.HueBar.Name = "HueBar";
            this.HueBar.Size = new System.Drawing.Size(156, 69);
            this.HueBar.TabIndex = 17;
            this.HueBar.Scroll += new System.EventHandler(this.HueBar_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1255, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Hue";
            // 
            // OpacityAdjustBar
            // 
            this.OpacityAdjustBar.Location = new System.Drawing.Point(1203, 409);
            this.OpacityAdjustBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OpacityAdjustBar.Maximum = 100;
            this.OpacityAdjustBar.Name = "OpacityAdjustBar";
            this.OpacityAdjustBar.Size = new System.Drawing.Size(156, 69);
            this.OpacityAdjustBar.TabIndex = 21;
            this.OpacityAdjustBar.Value = 100;
            this.OpacityAdjustBar.Scroll += new System.EventHandler(this.OpacityAdjustBar_Scroll);
            // 
            // ImageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 694);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.HueBar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GaussianBlurBar);
            this.Controls.Add(this.OpacityBar);
            this.Controls.Add(this.SaturationBar);
            this.Controls.Add(this.SaturationAdjustBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PixelateBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContrastBar);
            this.Controls.Add(this.BrightnessBar);
            this.Controls.Add(RotateLeft);
            this.Controls.Add(RotateRight);
            this.Controls.Add(this.LoadImage);
            this.Controls.Add(this.MyImage);
            this.Controls.Add(this.OpacityAdjustBar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ImageView";
            this.Text = "ImageView";
            ((System.ComponentModel.ISupportInitialize)(this.MyImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixelateBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaturationAdjustBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GaussianBlurBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HueBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpacityAdjustBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MyImage;
        private System.Windows.Forms.Button LoadImage;
        private System.Windows.Forms.TrackBar BrightnessBar;
        private System.Windows.Forms.TrackBar ContrastBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar PixelateBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar SaturationAdjustBar;
        private System.Windows.Forms.Label SaturationBar;
        private System.Windows.Forms.Label OpacityBar;
        private System.Windows.Forms.TrackBar GaussianBlurBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar HueBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar OpacityAdjustBar;
    }
}