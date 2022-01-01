using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14.BankamatikSimulasyonu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BHGN45D\AHMETSDBSERVER;Initial Catalog=25Project-14.BankamatikSimulasyonu;Integrated Security=True");
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into Kisiler (KisiAd,KisiSoyad,KisiTC,KisiTelefon,KisiHesapNo,KisiSifre) values (@p1,@p2,@p3,@p4,@p5,@p6)",connection);
            cmd.Parameters.AddWithValue("@p1", textBoxAd.Text);
            cmd.Parameters.AddWithValue("@p2", textBoxSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", maskedTextBoxTCKimlik.Text);
            cmd.Parameters.AddWithValue("@p4", maskedTextBoxTelefon.Text);
            cmd.Parameters.AddWithValue("@p5", maskedTextBoxHesapNo.Text);
            cmd.Parameters.AddWithValue("@p6", textBoxSifre.Text);
            cmd.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand("insert into Hesap (HesapNo,Bakiye) values (@p1,@p2)", connection);
            cmd2.Parameters.AddWithValue("@p1", maskedTextBoxHesapNo.Text);
            cmd2.Parameters.AddWithValue("@p2", 0);
            cmd2.ExecuteNonQuery();

            connection.Close();
            MessageBox.Show("Kullanıcı bilgileri kaydedildi !");
            textBoxAd.Text = "";
            textBoxSoyad.Text = "";
            maskedTextBoxTCKimlik.Text = "";
            maskedTextBoxTelefon.Text = "";
            maskedTextBoxHesapNo.Text = "";
            textBoxSifre.Text = "";
        }

        private void buttonHesapNo_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int sayi = random.Next(100000,1000000);
            maskedTextBoxHesapNo.Text = sayi.ToString();
        }
    }
}
