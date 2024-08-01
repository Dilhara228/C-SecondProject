
namespace SecondProject.Resources
{
    partial class frmListBox
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
            this.lstImages = new System.Windows.Forms.ListBox();
            this.picBImages = new System.Windows.Forms.PictureBox();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.picBImages)).BeginInit();
            this.SuspendLayout();
            // 
            // lstImages
            // 
            this.lstImages.FormattingEnabled = true;
            this.lstImages.Items.AddRange(new object[] {
            "None",
            "Image 1",
            "Image 2",
            "Image 3",
            "Image 4",
            "Image 5",
            "Image 6"});
            this.lstImages.Location = new System.Drawing.Point(12, 12);
            this.lstImages.Name = "lstImages";
            this.lstImages.Size = new System.Drawing.Size(144, 108);
            this.lstImages.TabIndex = 0;
            // 
            // picBImages
            // 
            this.picBImages.Location = new System.Drawing.Point(194, 12);
            this.picBImages.Name = "picBImages";
            this.picBImages.Size = new System.Drawing.Size(582, 394);
            this.picBImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBImages.TabIndex = 6;
            this.picBImages.TabStop = false;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(12, 138);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(144, 20);
            this.domainUpDown1.TabIndex = 7;
            this.domainUpDown1.Text = "None";
            // 
            // frmListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 426);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.picBImages);
            this.Controls.Add(this.lstImages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListBox";
            this.Text = "Use of List Boxes";
            this.Load += new System.EventHandler(this.frmListBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBImages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstImages;
        private System.Windows.Forms.PictureBox picBImages;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
    }
}