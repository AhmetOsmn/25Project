using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19.ResimUzerineYaziYazmak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string resim = "";
        private void buttonResimSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            resim = openFileDialog1.FileName;
        }

        Color renk;
        private void buttonRenkSec_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            renk = colorDialog1.Color;
        }

        Bitmap bmp;
        private void buttonYazdir_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(resim);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawString(textBoxMetin.Text, new Font("Segoe UI",Convert.ToInt16(textBoxBoyut.Text),FontStyle.Bold),new SolidBrush(renk),20,250);
            pictureBox1.Image = bmp;
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Resim|.jpg";
            saveFileDialog1.ShowDialog();
            bmp.Save(saveFileDialog1.FileName);
        }
    }
}
