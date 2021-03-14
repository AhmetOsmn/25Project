using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace KelimeOgren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\OneDrive\Masaüstü\dbSozluk.accdb");
        Random rast = new Random();
        int sure = 90;
        int kelime = 0;

        void getir()
        {
            int sayi;
            sayi = rast.Next(1, 2490);

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * from sozluk where id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", sayi);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textBoxIngilizce.Text = dr[1].ToString();
                labelCevap.Text = dr[2].ToString();
                labelCevap.Text = labelCevap.Text.ToLower();
            }
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            getir();
            textBoxTurkce.Focus();
            timer1.Start();
        }

        private void textBoxTurkce_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTurkce.Text == labelCevap.Text)
            {
                kelime++;
                labelKelime.Text = kelime.ToString();
                getir();
                textBoxTurkce.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            labelSüre.Text = sure.ToString();
            if(sure == 0)
            {
                textBoxTurkce.Enabled = false;
                textBoxIngilizce.Enabled = false;
            }
        }
    }
}
