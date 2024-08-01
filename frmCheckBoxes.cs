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
    public partial class frmCheckBoxes : Form
    {
        public frmCheckBoxes()
        {
            InitializeComponent();
        }

        private void picBImage1_Click(object sender, EventArgs e)
        {

        }

        private void chkImage1_CheckedChanged(object sender, EventArgs e)
        {
            if(chkImage1.Checked==true)
            {
                picBImage1.Visible = true;
            }
            else
            {
                picBImage1.Visible = false;
            }
        }

        private void chkImage2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkImage2.Checked == true)
            {
                picBImage2.Visible = true;
            }
            else
            {
                picBImage2.Visible = false;
            }
        }

        private void chkImage3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkImage3.Checked == true)
            {
                picBImage3.Visible = true;
            }
            else
            {
                picBImage3.Visible = false;
            }
        }

        private void chkImage4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkImage4.Checked == true)
            {
                picBImage4.Visible = true;
            }
            else
            {
                picBImage4.Visible = false;
            }
        }

        private void chkImage5_CheckedChanged(object sender, EventArgs e)
        {
            if (chkImage5.Checked == true)
            {
                picBImage5.Visible = true;
            }
            else
            {
                picBImage5.Visible = false;
            }
        }

        private void chkImage6_CheckedChanged(object sender, EventArgs e)
        {
            if (chkImage6.Checked == true)
            {
                picBImage6.Visible = true;
            }
            else
            {
                picBImage6.Visible = false;
            }
        }

        private void mnuCheckBoxes_Click(object sender, EventArgs e)
        {

        }
    }
}
