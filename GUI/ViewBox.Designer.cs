
namespace GUI
{
    partial class ViewBox
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.RotateButton = new System.Windows.Forms.Button();
            this.FliphorizontalButton = new System.Windows.Forms.Button();
            this.FlipVertical = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ImageSelectButton = new System.Windows.Forms.Button();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.BackwardButton = new System.Windows.Forms.Button();
            this.BrightnessDecrease = new System.Windows.Forms.Button();
            this.BrightnessIncrease = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(465, 8);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(60, 31);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // RotateButton
            // 
            this.RotateButton.Location = new System.Drawing.Point(431, 84);
            this.RotateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RotateButton.Name = "RotateButton";
            this.RotateButton.Size = new System.Drawing.Size(94, 32);
            this.RotateButton.TabIndex = 1;
            this.RotateButton.Text = "Rotate";
            this.RotateButton.UseVisualStyleBackColor = true;
            this.RotateButton.Click += new System.EventHandler(this.RotateButton_Click);
            // 
            // FliphorizontalButton
            // 
            this.FliphorizontalButton.Location = new System.Drawing.Point(431, 120);
            this.FliphorizontalButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FliphorizontalButton.Name = "FliphorizontalButton";
            this.FliphorizontalButton.Size = new System.Drawing.Size(94, 31);
            this.FliphorizontalButton.TabIndex = 2;
            this.FliphorizontalButton.Text = "Flip Horizontal";
            this.FliphorizontalButton.UseVisualStyleBackColor = true;
            this.FliphorizontalButton.Click += new System.EventHandler(this.FliphorizontalButton_Click);
            // 
            // FlipVertical
            // 
            this.FlipVertical.Location = new System.Drawing.Point(431, 155);
            this.FlipVertical.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FlipVertical.Name = "FlipVertical";
            this.FlipVertical.Size = new System.Drawing.Size(94, 31);
            this.FlipVertical.TabIndex = 3;
            this.FlipVertical.Text = "Flip Vertical";
            this.FlipVertical.UseVisualStyleBackColor = true;
            this.FlipVertical.Click += new System.EventHandler(this.FlipVertical_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(11, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 179);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ImageSelectButton
            // 
            this.ImageSelectButton.Location = new System.Drawing.Point(113, 319);
            this.ImageSelectButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ImageSelectButton.Name = "ImageSelectButton";
            this.ImageSelectButton.Size = new System.Drawing.Size(178, 34);
            this.ImageSelectButton.TabIndex = 5;
            this.ImageSelectButton.Text = "Select Image";
            this.ImageSelectButton.UseVisualStyleBackColor = true;
            this.ImageSelectButton.Click += new System.EventHandler(this.ImageSelectButton_Click);
            // 
            // ForwardButton
            // 
            this.ForwardButton.Location = new System.Drawing.Point(113, 240);
            this.ForwardButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(94, 32);
            this.ForwardButton.TabIndex = 6;
            this.ForwardButton.Text = ">";
            this.ForwardButton.UseVisualStyleBackColor = true;
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // BackwardButton
            // 
            this.BackwardButton.Location = new System.Drawing.Point(11, 240);
            this.BackwardButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackwardButton.Name = "BackwardButton";
            this.BackwardButton.Size = new System.Drawing.Size(94, 32);
            this.BackwardButton.TabIndex = 7;
            this.BackwardButton.Text = "<";
            this.BackwardButton.UseVisualStyleBackColor = true;
            this.BackwardButton.Click += new System.EventHandler(this.BackwardButton_Click);
            // 
            // BrightnessDecrease
            // 
            this.BrightnessDecrease.Location = new System.Drawing.Point(346, 260);
            this.BrightnessDecrease.Margin = new System.Windows.Forms.Padding(2);
            this.BrightnessDecrease.Name = "BrightnessDecrease";
            this.BrightnessDecrease.Size = new System.Drawing.Size(94, 32);
            this.BrightnessDecrease.TabIndex = 9;
            this.BrightnessDecrease.Text = "-";
            this.BrightnessDecrease.UseVisualStyleBackColor = true;
            this.BrightnessDecrease.Click += new System.EventHandler(this.BrightnessDecrease_Click);
            // 
            // BrightnessIncrease
            // 
            this.BrightnessIncrease.Location = new System.Drawing.Point(513, 260);
            this.BrightnessIncrease.Margin = new System.Windows.Forms.Padding(2);
            this.BrightnessIncrease.Name = "BrightnessIncrease";
            this.BrightnessIncrease.Size = new System.Drawing.Size(94, 32);
            this.BrightnessIncrease.TabIndex = 8;
            this.BrightnessIncrease.Text = "+";
            this.BrightnessIncrease.UseVisualStyleBackColor = true;
            this.BrightnessIncrease.Click += new System.EventHandler(this.BrightnessIncrease_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Brightness";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ViewBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(902, 584);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BrightnessDecrease);
            this.Controls.Add(this.BrightnessIncrease);
            this.Controls.Add(this.BackwardButton);
            this.Controls.Add(this.ForwardButton);
            this.Controls.Add(this.ImageSelectButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FlipVertical);
            this.Controls.Add(this.FliphorizontalButton);
            this.Controls.Add(this.RotateButton);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ViewBox";
            this.Text = "ViewBox";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewBox_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewBox_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewBox_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button RotateButton;
        private System.Windows.Forms.Button FliphorizontalButton;
        private System.Windows.Forms.Button FlipVertical;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ImageSelectButton;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.Button BackwardButton;
        private System.Windows.Forms.Button BrightnessDecrease;
        private System.Windows.Forms.Button BrightnessIncrease;
        private System.Windows.Forms.Label label1;
    }
}

