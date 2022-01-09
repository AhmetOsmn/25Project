using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24.OOP_Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        KitapDb kitapDb = new KitapDb();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = kitapDb.Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kitap yeniKitap = new Kitap();

            yeniKitap.Ad = textBoxKitapAdi.Text;
            yeniKitap.Yazar = textBoxYazarAdi.Text;

            kitapDb.KitapEkle(yeniKitap);
            kitapDb.Listele();
            MessageBox.Show("Kitap eklendi");
        }
    }
}
