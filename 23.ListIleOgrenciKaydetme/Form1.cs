using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23.ListIleOgrenciKaydetme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> sayilar = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            List<string> kisiler = new List<string>();
            kisiler.Add("Mazhar");
            kisiler.Add("Ruhsar");
            kisiler.Add("Menkıbe");
            kisiler.Add("Müfit");
            kisiler.Add("Reyhan");
            kisiler.Add("Firdevs");

            kisiler.Remove("Mazhar");

            foreach (var item in kisiler)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            sayilar.Add(45);
            sayilar.Add(22);
            sayilar.Add(78);
            sayilar.Add(35);
            sayilar.Add(96);
            sayilar.Add(11);
            foreach (var item in sayilar)
            {
                listBox2.Items.Add(item);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (sayilar.Contains(Convert.ToInt32(textBoxAranacak.Text)))
            {
                MessageBox.Show("Sayı listede var");
            }
            else
            {
                MessageBox.Show("Sayı listede yok");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Kisiler> kisiListesi =  new List<Kisiler>();

            kisiListesi.Add(new Kisiler()
            {
                Ad = "Ahmet",
                Soyad = "Sezgin",
                Meslek = "Öğrenci"
            });

            kisiListesi.Add(new Kisiler()
            {
                Ad = "Mert",
                Soyad = "Altın",
                Meslek = "Öğrenci"
            });

            kisiListesi.Add(new Kisiler()
            {
                Ad = "Ulaş",
                Soyad = "Avil",
                Meslek = "Öğrenci"
            });

            kisiListesi.Add(new Kisiler()
            {
                Ad = "Emre",
                Soyad = "Doran",
                Meslek = "Öğrenci"
            });

            foreach (var kisi in kisiListesi)
            {
                listBox3.Items.Add(kisi.Ad + " " + kisi.Soyad + " - " + kisi.Meslek);
            }



        }
    }
}
