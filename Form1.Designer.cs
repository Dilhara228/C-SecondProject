
namespace SecondProject
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuObjects = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCheckBoxes = new System.Windows.Forms.ToolStripMenuItem();
            this.goToToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.goToAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRadioButtons = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuComboBoxes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOFD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListBox = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mnuObjects,
            this.studentsToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(726, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            this.mnuMain.Click += new System.EventHandler(this.mnuCheckBoxes_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogin,
            this.mnuLogOut,
            this.mnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuLogin
            // 
            this.mnuLogin.Image = global::SecondProject.Properties.Resources.IMG_20210902_WA0011;
            this.mnuLogin.Name = "mnuLogin";
            this.mnuLogin.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.mnuLogin.Size = new System.Drawing.Size(194, 22);
            this.mnuLogin.Text = "Login";
            this.mnuLogin.Click += new System.EventHandler(this.mnuLogin_Click);
            // 
            // mnuLogOut
            // 
            this.mnuLogOut.Enabled = false;
            this.mnuLogOut.Image = global::SecondProject.Properties.Resources.IMG_20210902_WA0013;
            this.mnuLogOut.Name = "mnuLogOut";
            this.mnuLogOut.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Left)));
            this.mnuLogOut.Size = new System.Drawing.Size(194, 22);
            this.mnuLogOut.Text = "Log Out";
            this.mnuLogOut.Click += new System.EventHandler(this.mnuLogOut_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Image = global::SecondProject.Properties.Resources.IMG_20210902_WA0014;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuExit.Size = new System.Drawing.Size(194, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuObjects
            // 
            this.mnuObjects.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCheckBoxes,
            this.mnuRadioButtons,
            this.mnuComboBoxes,
            this.mnuOFD,
            this.mnuListBox});
            this.mnuObjects.Name = "mnuObjects";
            this.mnuObjects.Size = new System.Drawing.Size(59, 20);
            this.mnuObjects.Text = "Objects";
            // 
            // mnuCheckBoxes
            // 
            this.mnuCheckBoxes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToToolStripMenuItem1,
            this.goToAllToolStripMenuItem});
            this.mnuCheckBoxes.Enabled = false;
            this.mnuCheckBoxes.Name = "mnuCheckBoxes";
            this.mnuCheckBoxes.Size = new System.Drawing.Size(180, 22);
            this.mnuCheckBoxes.Text = "CheckBoxes";
            this.mnuCheckBoxes.Click += new System.EventHandler(this.mnuCheckBoxes_Click_1);
            // 
            // goToToolStripMenuItem1
            // 
            this.goToToolStripMenuItem1.Name = "goToToolStripMenuItem1";
            this.goToToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.goToToolStripMenuItem1.Text = "Go To";
            // 
            // goToAllToolStripMenuItem
            // 
            this.goToAllToolStripMenuItem.Name = "goToAllToolStripMenuItem";
            this.goToAllToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.goToAllToolStripMenuItem.Text = "Go to All";
            // 
            // mnuRadioButtons
            // 
            this.mnuRadioButtons.Enabled = false;
            this.mnuRadioButtons.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.mnuRadioButtons.Name = "mnuRadioButtons";
            this.mnuRadioButtons.Size = new System.Drawing.Size(180, 22);
            this.mnuRadioButtons.Text = "Radio Buttons";
            this.mnuRadioButtons.Click += new System.EventHandler(this.mnuRadioButtons_Click);
            // 
            // mnuComboBoxes
            // 
            this.mnuComboBoxes.Enabled = false;
            this.mnuComboBoxes.Name = "mnuComboBoxes";
            this.mnuComboBoxes.Size = new System.Drawing.Size(180, 22);
            this.mnuComboBoxes.Text = "Combo Boxes";
            this.mnuComboBoxes.Click += new System.EventHandler(this.mnuComboBoxes_Click);
            // 
            // mnuOFD
            // 
            this.mnuOFD.Enabled = false;
            this.mnuOFD.Name = "mnuOFD";
            this.mnuOFD.Size = new System.Drawing.Size(180, 22);
            this.mnuOFD.Text = "Open File Dialog";
            this.mnuOFD.Click += new System.EventHandler(this.mnuOFD_Click);
            // 
            // mnuListBox
            // 
            this.mnuListBox.Enabled = false;
            this.mnuListBox.Name = "mnuListBox";
            this.mnuListBox.Size = new System.Drawing.Size(180, 22);
            this.mnuListBox.Text = "List Box";
            this.mnuListBox.Click += new System.EventHandler(this.mnuListBox_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewStudents,
            this.mnuEditStudents,
            this.mnuRemoveStudents});
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.studentsToolStripMenuItem.Text = "Students";
            // 
            // mnuNewStudents
            // 
            this.mnuNewStudents.Image = global::SecondProject.Properties.Resources.IMG_20210902_WA0012;
            this.mnuNewStudents.Name = "mnuNewStudents";
            this.mnuNewStudents.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuNewStudents.Size = new System.Drawing.Size(220, 22);
            this.mnuNewStudents.Text = "New Students";
            // 
            // mnuEditStudents
            // 
            this.mnuEditStudents.Image = global::SecondProject.Properties.Resources.IMG_20210902_WA0012;
            this.mnuEditStudents.Name = "mnuEditStudents";
            this.mnuEditStudents.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.End)));
            this.mnuEditStudents.Size = new System.Drawing.Size(220, 22);
            this.mnuEditStudents.Text = "Edit Students";
            // 
            // mnuRemoveStudents
            // 
            this.mnuRemoveStudents.Image = global::SecondProject.Properties.Resources.IMG_20210902_WA0015;
            this.mnuRemoveStudents.Name = "mnuRemoveStudents";
            this.mnuRemoveStudents.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.mnuRemoveStudents.Size = new System.Drawing.Size(220, 22);
            this.mnuRemoveStudents.Text = "Remove Students";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 343);
            this.Controls.Add(this.mnuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.Text = "Second Project";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuLogin;
        private System.Windows.Forms.ToolStripMenuItem mnuLogOut;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuObjects;
        private System.Windows.Forms.ToolStripMenuItem mnuCheckBoxes;
        private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem goToAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNewStudents;
        private System.Windows.Forms.ToolStripMenuItem mnuEditStudents;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveStudents;
        private System.Windows.Forms.ToolStripMenuItem mnuRadioButtons;
        private System.Windows.Forms.ToolStripMenuItem mnuComboBoxes;
        private System.Windows.Forms.ToolStripMenuItem mnuOFD;
        private System.Windows.Forms.ToolStripMenuItem mnuListBox;
    }
}

