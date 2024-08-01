
namespace SecondProject
{
    partial class frmSplashScreen
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
            this.components = new System.ComponentModel.Container();
            this.tmrSplashScreen = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tmrSplashScreen
            // 
            this.tmrSplashScreen.Enabled = true;
            this.tmrSplashScreen.Interval = 5000;
            this.tmrSplashScreen.Tick += new System.EventHandler(this.tmrSplashScreen_Tick);
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SecondProject.Properties.Resources.images__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(406, 272);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSplashScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrSplashScreen;
    }
}