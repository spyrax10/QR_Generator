using QR_Generator.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_Generator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnEmailClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGen_MouseHover(object sender, EventArgs e)
        {
            btnGen.BackColor = Color.Lime;
            btnGen.ForeColor = Color.Black;
        }

        private void btnGen_MouseLeave(object sender, EventArgs e)
        {
            btnGen.BackColor = Color.Black;
            btnGen.ForeColor = Color.Lime;
        }

        private void btnDown_MouseHover(object sender, EventArgs e)
        {
            btnDown.BackColor = Color.DodgerBlue;
            btnDown.ForeColor = Color.Black;
        }

        private void btnDown_MouseLeave(object sender, EventArgs e)
        {
            btnDown.BackColor = Color.Black;
            btnDown.ForeColor = Color.DodgerBlue;
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            if (tBQR.Texts != "")
            {
                misc.QRgen(pBQR, tBQR);
            }
            else
            {
                MessageBox.Show("Please Enter Value");
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (pBQR.Image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PNG Image(*.png)|*.png|JPG Image(*.jpg)|*.jpg|BMP Image(*.bmp)|*.bmp";
              
                ImageFormat format = ImageFormat.Png;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    pBQR.Image.Save(sfd.FileName, format);
                    MessageBox.Show("Image Saved!", " Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tBQR.Texts = "";
                    pBQR.Image = null;
                    tBQR.Focus();
                }
            }
            else
            {
                MessageBox.Show("Image Null");
            }
        }
    }
}
