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
    public partial class frmComboBoxes : Form
    {
        public frmComboBoxes()
        {
            InitializeComponent();
        }

        private void cmbSelectImage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbSelectImage.SelectedItem.ToString()=="Image 01")
            {
                picBImage1.Visible = true;
                picBImage2.Visible = false;
                picBImage3.Visible = false;
                picBImage4.Visible = false;
                picBImage5.Visible = false;
                picBImage6.Visible = false;
            }
            else
            {
                if(cmbSelectImage.SelectedItem.ToString()=="Image 02")
                {
                    picBImage1.Visible = false;
                    picBImage2.Visible = true;
                    picBImage3.Visible = false;
                    picBImage4.Visible = false;
                    picBImage5.Visible = false;
                    picBImage6.Visible = false;
                }
                else if(cmbSelectImage.SelectedItem.ToString()=="Image 03")
                {
                    picBImage1.Visible = false;
                    picBImage2.Visible = false;
                    picBImage3.Visible = true;
                    picBImage4.Visible = false;
                    picBImage5.Visible = false;
                    picBImage6.Visible = false;
                }
                else if (cmbSelectImage.SelectedItem.ToString() == "Image 04")
                {
                    picBImage1.Visible = false;
                    picBImage2.Visible = false;
                    picBImage3.Visible = false;
                    picBImage4.Visible = true;
                    picBImage5.Visible = false;
                    picBImage6.Visible = false;
                }
                else if (cmbSelectImage.SelectedItem.ToString() == "Image 05")
                {
                    picBImage1.Visible = false;
                    picBImage2.Visible = false;
                    picBImage3.Visible = false;
                    picBImage4.Visible = false;
                    picBImage5.Visible = true;
                    picBImage6.Visible = false;
                }
                else if (cmbSelectImage.SelectedItem.ToString() == "Image 06")
                {
                    picBImage1.Visible = false;
                    picBImage2.Visible = false;
                    picBImage3.Visible = false;
                    picBImage4.Visible = false;
                    picBImage5.Visible = false;
                    picBImage6.Visible = true;
                }
                else
                {
                    picBImage1.Visible = false;
                    picBImage2.Visible = false;
                    picBImage3.Visible = false;
                    picBImage4.Visible = false;
                    picBImage5.Visible = false;
                    picBImage6.Visible = false;
                }
            }
        }
    }
}
