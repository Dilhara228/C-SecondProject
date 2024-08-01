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
    public partial class frmOfd : Form
    {
        public frmOfd()
        {
            InitializeComponent();
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            if(ofdBrowseImages.ShowDialog()!=DialogResult.Cancel)
            {
                cmbImage.Items.Add(ofdBrowseImages.FileName);
                picBImage.Image = Image.FromFile(ofdBrowseImages.FileName);
            }
        }

        private void cmbImage_SelectedIndexChanged(object sender, EventArgs e)
        {
            picBImage.Image = Image.FromFile(cmbImage.SelectedItem.ToString());
        }
    }
}
