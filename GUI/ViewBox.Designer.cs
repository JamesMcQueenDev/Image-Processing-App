
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(698, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(90, 48);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // RotateButton
            // 
            this.RotateButton.Location = new System.Drawing.Point(647, 129);
            this.RotateButton.Name = "RotateButton";
            this.RotateButton.Size = new System.Drawing.Size(141, 50);
            this.RotateButton.TabIndex = 1;
            this.RotateButton.Text = "Rotate";
            this.RotateButton.UseVisualStyleBackColor = true;
            this.RotateButton.Click += new System.EventHandler(this.RotateButton_Click);
            // 
            // FliphorizontalButton
            // 
            this.FliphorizontalButton.Location = new System.Drawing.Point(647, 185);
            this.FliphorizontalButton.Name = "FliphorizontalButton";
            this.FliphorizontalButton.Size = new System.Drawing.Size(141, 48);
            this.FliphorizontalButton.TabIndex = 2;
            this.FliphorizontalButton.Text = "Flip Horizontal";
            this.FliphorizontalButton.UseVisualStyleBackColor = true;
            this.FliphorizontalButton.Click += new System.EventHandler(this.FliphorizontalButton_Click);
            // 
            // FlipVertical
            // 
            this.FlipVertical.Location = new System.Drawing.Point(647, 239);
            this.FlipVertical.Name = "FlipVertical";
            this.FlipVertical.Size = new System.Drawing.Size(141, 48);
            this.FlipVertical.TabIndex = 3;
            this.FlipVertical.Text = "Flip Vertical";
            this.FlipVertical.UseVisualStyleBackColor = true;
            this.FlipVertical.Click += new System.EventHandler(this.FlipVertical_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(163, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 275);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ImageSelectButton
            // 
            this.ImageSelectButton.Location = new System.Drawing.Point(171, 369);
            this.ImageSelectButton.Name = "ImageSelectButton";
            this.ImageSelectButton.Size = new System.Drawing.Size(267, 52);
            this.ImageSelectButton.TabIndex = 5;
            this.ImageSelectButton.Text = "Select Image";
            this.ImageSelectButton.UseVisualStyleBackColor = true;
            this.ImageSelectButton.Click += new System.EventHandler(this.ImageSelectButton_Click);
            // 
            // ForwardButton
            // 
            this.ForwardButton.Location = new System.Drawing.Point(444, 129);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(141, 50);
            this.ForwardButton.TabIndex = 6;
            this.ForwardButton.Text = "Forward";
            this.ForwardButton.UseVisualStyleBackColor = true;
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // BackwardButton
            // 
            this.BackwardButton.Location = new System.Drawing.Point(12, 129);
            this.BackwardButton.Name = "BackwardButton";
            this.BackwardButton.Size = new System.Drawing.Size(141, 50);
            this.BackwardButton.TabIndex = 7;
            this.BackwardButton.Text = "Backward";
            this.BackwardButton.UseVisualStyleBackColor = true;
            this.BackwardButton.Click += new System.EventHandler(this.BackwardButton_Click);
            // 
            // ViewBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackwardButton);
            this.Controls.Add(this.ForwardButton);
            this.Controls.Add(this.ImageSelectButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FlipVertical);
            this.Controls.Add(this.FliphorizontalButton);
            this.Controls.Add(this.RotateButton);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewBox";
            this.Text = "ViewBox";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewBox_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewBox_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewBox_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
    }
}

