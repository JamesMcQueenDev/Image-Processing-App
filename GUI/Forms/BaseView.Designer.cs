﻿
namespace GUI
{
    partial class BaseView
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
            this.AddImageHandler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddImageHandler
            // 
            this.AddImageHandler.Location = new System.Drawing.Point(83, 53);
            this.AddImageHandler.Name = "AddImageHandler";
            this.AddImageHandler.Size = new System.Drawing.Size(310, 249);
            this.AddImageHandler.TabIndex = 0;
            this.AddImageHandler.Text = "Add New Image Handler";
            this.AddImageHandler.UseVisualStyleBackColor = true;
            this.AddImageHandler.Click += new System.EventHandler(this.AddImageHandler_Click);
            // 
            // BaseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 365);
            this.Controls.Add(this.AddImageHandler);
            this.Name = "BaseView";
            this.Text = "BaseView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddImageHandler;
    }
}