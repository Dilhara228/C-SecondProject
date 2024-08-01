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
    public partial class frmListBox : Form
    {
        public frmListBox()
        {
            InitializeComponent();
        }

        private void lstImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstImages.SelectedItem == null)
            {
                MessageBox.Show("Invalid Selection");
            }
            else if (lstImages.SelectedItem.ToString() == "Image 1")
            {
                picBImages.Image = Properties.Resources._1;
            }
            else if (lstImages.SelectedItem.ToString() == "Image 2")
            {
                picBImages.Image = Properties.Resources._2;
            }
            else if (lstImages.SelectedItem.ToString() == "Image 3")
            {
                picBImages.Image = Properties.Resources._3;
            }
            else if (lstImages.SelectedItem.ToString() == "Image 4")
            {
                picBImages.Image = Properties.Resources._4;
            }
            else if (lstImages.SelectedItem.ToString() == "Image 5")
            {
                picBImages.Image = Properties.Resources._5;
            }
            else if (lstImages.SelectedItem.ToString() == "Image 6")
            {
                picBImages.Image = Properties.Resources._6;
            }
            else
            {
                picBImages.Image = null;
            }
        }
    }
}
