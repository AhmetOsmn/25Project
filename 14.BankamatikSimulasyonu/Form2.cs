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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BHGN45D\AHMETSDBSERVER;Initial Catalog=25Project-14.BankamatikSimulasyonu;Integrated Security=True");

        public string hesap;

        public void Listele()
        {
            labelHesapNo.Text = hesap;
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select * from Kisiler where KisiHesapNo=@p1", connection);
            cmd.Parameters.AddWithValue("@p1", hesap);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                labelAdSoyad.Text = dr[1] + " " + dr[2];
                labelTCKimlik.Text = dr[3].ToString();
                labelTelefon.Text = dr[4].ToString();
            }
            connection.Close();

            connection.Open();
            SqlCommand cmd2 = new SqlCommand("select Bakiye from Hesap where HesapNo=@k1", connection);
            cmd2.Parameters.AddWithValue("@k1", labelHesapNo.Text);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                labelBakiye.Text = dr2.GetValue(0).ToString();
            }

            connection.Close();
        }

        private void buttonGonder_Click(object sender, EventArgs e)
        {
            connection.Open();
            //Para artisi
            SqlCommand cmd = new SqlCommand("update Hesap set Bakiye=Bakiye+@p1 where HesapNo=@p2",connection);
            cmd.Parameters.AddWithValue("@p1",decimal.Parse(textBoxTutar.Text));
            cmd.Parameters.AddWithValue("@p2",maskedTextBoxHesapNo.Text);
            cmd.ExecuteNonQuery();

            //Para azaltimi
            SqlCommand cmd2 = new SqlCommand("update Hesap set Bakiye=Bakiye-@k1 where HesapNo=@k2",connection);
            cmd2.Parameters.AddWithValue("@k1",decimal.Parse(textBoxTutar.Text));
            cmd2.Parameters.AddWithValue("@k2",hesap);
            cmd2.ExecuteNonQuery();

            //Hareket ekleme
            SqlCommand cmd3 = new SqlCommand("insert into Hareket (Gonderen,Alici,Tutar) VALUES (@j1,@j2,@j3)", connection);
            cmd3.Parameters.AddWithValue("@j1",labelHesapNo.Text);
            cmd3.Parameters.AddWithValue("@j2",maskedTextBoxHesapNo.Text);
            cmd3.Parameters.AddWithValue("@j3",textBoxTutar.Text);
            cmd3.ExecuteNonQuery();

            MessageBox.Show("İslem gercekleşti");
            connection.Close();

            textBoxTutar.Text = "";
            maskedTextBoxHesapNo.Text = "";
            Listele();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void buttonHareketlerim_Click(object sender, EventArgs e)
        {
            
            Form4 form4 = new Form4();
            form4.hesap = labelHesapNo.Text;
            form4.Show();
        }
    }
}
