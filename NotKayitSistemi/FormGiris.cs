using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotKayitSistemi
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormOgrenciDetay formOgrenciDetay = new FormOgrenciDetay();
            formOgrenciDetay.numara = maskedTextBox1.Text;
            formOgrenciDetay.Show();
            
        }


        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "1111")
            {
                FormOgretmenDetay formOgretmenDetay = new FormOgretmenDetay();
                formOgretmenDetay.Show();
            }
        }

        private void FormGiris_Load(object sender, EventArgs e)
        {


        }
    }
}
