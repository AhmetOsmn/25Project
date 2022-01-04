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

namespace _17.BiletRezervasyonSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BHGN45D\AHMETSDBSERVER;Initial Catalog=25Project-17.BiletRezervasyonSistemi;Integrated Security=True");

        void SeferListesi()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Seferler", connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void buttonYolcuKaydet_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Yolcular (YolcuAd,YolcuSoyad,YolcuTelefon,YolcuTC,YolcuCinsiyet,YolcuMail) values (@p1,@p2,@p3,@p4,@p5,@p6)", connection);
            command.Parameters.AddWithValue("@p1",textBoxYolcuAd.Text);
            command.Parameters.AddWithValue("@p2",textBoxYolcuSoyad.Text);
            command.Parameters.AddWithValue("@p3",maskedTextBoxYolcuTelefon.Text);
            command.Parameters.AddWithValue("@p4",maskedTextBoxYolcuTC.Text);
            command.Parameters.AddWithValue("@p5",comboBoxCinsiyet.Text);
            command.Parameters.AddWithValue("@p6",textBoxYolcuMail.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Yolcu sisteme kaydedildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void buttonKaptanKaydet_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Kaptanlar (KaptanNO,KaptanAdSoyad,KaptanTelefon) values (@p1,@p2,@p3)",connection);
            command.Parameters.AddWithValue("@p1",maskedTextBoxKaptanNo.Text);
            command.Parameters.AddWithValue("@p2",textBoxKaptanAdSoyad.Text);
            command.Parameters.AddWithValue("@p3",maskedTextBoxKaptanTelefon.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Yolcu sisteme kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSeferOlustur_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Seferler (SeferKalkis,SeferVaris,SeferTarih,SeferSaat,SeferKaptan,SeferFiyat) values (@p1,@p2,@p3,@p4,@p5,@p6)", connection);
            command.Parameters.AddWithValue("@p1", textBoxKalkis.Text);
            command.Parameters.AddWithValue("@p2", textBoxVaris.Text);
            command.Parameters.AddWithValue("@p3", maskedTextBoxTarih.Text);
            command.Parameters.AddWithValue("@p4", maskedTextBoxSaat.Text);
            command.Parameters.AddWithValue("@p5", maskedTextBoxKaptan.Text);
            command.Parameters.AddWithValue("@p6", textBoxFiyat.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Sefer sisteme kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SeferListesi();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            SeferListesi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            textBoxSeferNumarasi.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBoxKoltukNumarasi.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxKoltukNumarasi.Text = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxKoltukNumarasi.Text = "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxKoltukNumarasi.Text = "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxKoltukNumarasi.Text = "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxKoltukNumarasi.Text = "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxKoltukNumarasi.Text = "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxKoltukNumarasi.Text = "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxKoltukNumarasi.Text = "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxKoltukNumarasi.Text = "9";
        }

        private void buttonRezervasyonYap_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into SeferDetaylar (SeferNO,YolcuTC,Koltuk) values(@p1,@p2,@p3)",connection);
            command.Parameters.AddWithValue("@p1", textBoxSeferNumarasi.Text);
            command.Parameters.AddWithValue("@p2", maskedTextBox1.Text);
            command.Parameters.AddWithValue("@p3", textBoxKoltukNumarasi.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Rezervasyon kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
