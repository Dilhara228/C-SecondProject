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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtLoginName.Text=="admin" && txtPassword.Text=="123")
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("User Name or Password Invalid\nPlease Try Again", "Login Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
