
namespace SecondProject
{
    partial class frmOfd
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
            this.lblImageName = new System.Windows.Forms.Label();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.picBImage = new System.Windows.Forms.PictureBox();
            this.ofdBrowseImages = new System.Windows.Forms.OpenFileDialog();
            this.cmbImage = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblImageName
            // 
            this.lblImageName.AutoSize = true;
            this.lblImageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageName.Location = new System.Drawing.Point(12, 28);
            this.lblImageName.Name = "lblImageName";
            this.lblImageName.Size = new System.Drawing.Size(79, 15);
            this.lblImageName.TabIndex = 0;
            this.lblImageName.Text = "Image Name";
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Location = new System.Drawing.Point(572, 30);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseImage.TabIndex = 2;
            this.btnBrowseImage.Text = "Browse Image";
            this.btnBrowseImage.UseVisualStyleBackColor = true;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // picBImage
            // 
            this.picBImage.Location = new System.Drawing.Point(12, 75);
            this.picBImage.Name = "picBImage";
            this.picBImage.Size = new System.Drawing.Size(635, 343);
            this.picBImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBImage.TabIndex = 3;
            this.picBImage.TabStop = false;
            // 
            // ofdBrowseImages
            // 
            this.ofdBrowseImages.FileName = "openFileDialog1";
            this.ofdBrowseImages.Filter = "JPEG Images|*.jpeg|JPG Images|*.jpg|All Image Types|*.jpeg;*.jpg;*.gif,*.bmp;*.pn" +
    "g|All Files|*.*";
            // 
            // cmbImage
            // 
            this.cmbImage.FormattingEnabled = true;
            this.cmbImage.Location = new System.Drawing.Point(127, 28);
            this.cmbImage.Name = "cmbImage";
            this.cmbImage.Size = new System.Drawing.Size(422, 21);
            this.cmbImage.TabIndex = 4;
            this.cmbImage.SelectedIndexChanged += new System.EventHandler(this.cmbImage_SelectedIndexChanged);
            // 
            // frmOfd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 428);
            this.Controls.Add(this.cmbImage);
            this.Controls.Add(this.picBImage);
            this.Controls.Add(this.btnBrowseImage);
            this.Controls.Add(this.lblImageName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmOfd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Use of Open File Dialog";
            ((System.ComponentModel.ISupportInitialize)(this.picBImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImageName;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.PictureBox picBImage;
        private System.Windows.Forms.OpenFileDialog ofdBrowseImages;
        private System.Windows.Forms.ComboBox cmbImage;
    }
}