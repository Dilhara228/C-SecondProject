using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondProject
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Hide();
            frmSplashScreen splashScreen = new frmSplashScreen();
            if(splashScreen.ShowDialog()==DialogResult.OK)
            {
                WindowState = FormWindowState.Maximized;
                Show();
                frmLogin login = new frmLogin();
                if (login.ShowDialog() == DialogResult.OK)
                {
                    mnuLogin.Enabled = false;
                    mnuLogOut.Enabled = true;
                    mnuNewStudents.Enabled = true;
                    mnuEditStudents.Enabled = true;
                    mnuRemoveStudents.Enabled = true;
                    mnuCheckBoxes.Enabled = true;
                    mnuRadioButtons.Enabled = true;
                    mnuComboBoxes.Enabled = true;
                    mnuOFD.Enabled = true;
                    mnuListBox.Enabled = true;
                }
            }
        }

        private void mnuLogin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                mnuLogin.Enabled = false;
                mnuLogOut.Enabled = true;
                mnuNewStudents.Enabled = true;
                mnuEditStudents.Enabled = true;
                mnuRemoveStudents.Enabled = true;
                mnuCheckBoxes.Enabled = true;
                mnuRadioButtons.Enabled = true;
                mnuComboBoxes.Enabled = true;
                mnuOFD.Enabled = true;
                mnuListBox.Enabled = true;
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to LogOut?", "Confirm LogOut",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mnuLogOut.Enabled = false;
                mnuLogin.Enabled = true;
                mnuNewStudents.Enabled = false;
                mnuEditStudents.Enabled = false;
                mnuRemoveStudents.Enabled = false;
                mnuCheckBoxes.Enabled = false;
                mnuRadioButtons.Enabled = false;
                mnuComboBoxes.Enabled = false;
                mnuOFD.Enabled = false;
                mnuListBox.Enabled = false;
            }
        }

        private void mnuCheckBoxes_Click(object sender, EventArgs e)
        {

        }

        private void mnuRadioButtons_Click(object sender, EventArgs e)
        {
             frmRadioButtons radioButtons = new frmRadioButtons();
             radioButtons.ShowDialog();

        }

        private void mnuCheckBoxes_Click_1(object sender, EventArgs e)
        {
           
            frmCheckBoxes checkBoxes = new frmCheckBoxes();
            checkBoxes.ShowDialog();
        }

        private void mnuComboBoxes_Click(object sender, EventArgs e)
        {
            frmComboBoxes comboBoxes = new frmComboBoxes();
            comboBoxes.ShowDialog();
        }

        private void mnuOFD_Click(object sender, EventArgs e)
        {
            frmOfd ofd = new frmOfd();
            ofd.ShowDialog();
        }

        private void mnuListBox_Click(object sender, EventArgs e)
        {
            frmListBox listBox = new frmListBox();
            listBox.ShowDialog();
        }
    }
}
