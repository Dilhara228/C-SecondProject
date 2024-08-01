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
    public partial class frmRadioButtons : Form
    {
        public frmRadioButtons()
        {
            InitializeComponent();
        }

        private void rdoImage1_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoImage1.Checked==true)
            {
                picBImage1.Visible = true;
            }
            else
            {
                picBImage1.Visible = false;
            }
        }

        private void rdoImage2_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoImage2.Checked==true)
            {
                picBImage2.Visible = true;
            }
            else
            {
                picBImage2.Visible = false;
            }
        }

        private void rdoImage3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoImage3.Checked == true)
            {
                picBImage3.Visible = true;
            }
            else
            {
                picBImage3.Visible = false;
            }
        }

        private void rdoImage4_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoImage4.Checked == true)
            {
                picBImage4.Visible = true;
            }
            else
            {
                picBImage4.Visible = false;
            }
        }

        private void rdoImage5_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoImage5.Checked == true)
            {
                picBImage5.Visible = true;
            }
            else
            {
                picBImage5.Visible = false;
            }
        }

        private void rdoImage6_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoImage6.Checked == true)
            {
                picBImage6.Visible = true;
            }
            else
            {
                picBImage6.Visible = false;
            }
        }
    }
}
