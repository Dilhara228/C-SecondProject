
namespace SecondProject
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
            this.dmnImages = new System.Windows.Forms.DomainUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.picBImages)).BeginInit();
            this.SuspendLayout();
            // 
            // lstImages
            // 
            this.lstImages.FormattingEnabled = true;
            this.lstImages.Items.AddRange(new object[] {
            "None ",
            "Image 1",
            "Image 2",
            "Image 3",
            "Image 4",
            "Image 5",
            "Image 6"});
            this.lstImages.Location = new System.Drawing.Point(12, 12);
            this.lstImages.Name = "lstImages";
            this.lstImages.Size = new System.Drawing.Size(140, 134);
            this.lstImages.TabIndex = 0;
            this.lstImages.SelectedIndexChanged += new System.EventHandler(this.lstImages_SelectedIndexChanged);
            // 
            // picBImages
            // 
            this.picBImages.Location = new System.Drawing.Point(168, 12);
            this.picBImages.Name = "picBImages";
            this.picBImages.Size = new System.Drawing.Size(612, 417);
            this.picBImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBImages.TabIndex = 1;
            this.picBImages.TabStop = false;
            // 
            // dmnImages
            // 
            this.dmnImages.Items.Add("None");
            this.dmnImages.Items.Add("Image 1");
            this.dmnImages.Items.Add("Image 2");
            this.dmnImages.Items.Add("Image 3");
            this.dmnImages.Items.Add("Image 4");
            this.dmnImages.Items.Add("Image 5");
            this.dmnImages.Items.Add("Image 6");
            this.dmnImages.Location = new System.Drawing.Point(12, 152);
            this.dmnImages.Name = "dmnImages";
            this.dmnImages.Size = new System.Drawing.Size(140, 20);
            this.dmnImages.TabIndex = 2;
            this.dmnImages.Text = "None";
            // 
            // frmListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 442);
            this.Controls.Add(this.dmnImages);
            this.Controls.Add(this.picBImages);
            this.Controls.Add(this.lstImages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Use of List Boxes";
            ((System.ComponentModel.ISupportInitialize)(this.picBImages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstImages;
        private System.Windows.Forms.PictureBox picBImages;
        private System.Windows.Forms.DomainUpDown dmnImages;
    }
}