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

namespace _18.AkaryakitStokTakipSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BHGN45D\AHMETSDBSERVER;Initial Catalog=25Project-18.AkaryakitStokTakipSistemi;Integrated Security=True");

        public string fiyatOgren(string yakitTuru,ProgressBar progresBar,Label label)
        {
            string fiyat = "";
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select * from Yakitlar where YakitTur='"+yakitTuru+"'", connection);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                fiyat = sqlDataReader[3].ToString();
                progresBar.Value = int.Parse(sqlDataReader[4].ToString());
                label.Text = sqlDataReader[4].ToString();
            }
            connection.Close();
            return fiyat;
        }


        void FiyatListesi()
        {
            label95.Text = fiyatOgren("Kurşunsuz95",progressBar1,label16);
            label97.Text = fiyatOgren("Kurşunsuz97",progressBar2,label17);
            labelED.Text = fiyatOgren("EuroDizel10",progressBar3,label18);
            labelYPD.Text = fiyatOgren("YeniProDizel10",progressBar4,label19);
            labelGaz.Text = fiyatOgren("Gaz",progressBar5,label20);

            connection.Open();
            SqlCommand command = new SqlCommand("Select * from Kasa",connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                labelKasa.Text = reader[0].ToString();
            }
            connection.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FiyatListesi();
        }
        void satisYap(string yakitTur, NumericUpDown numericUpDown, TextBox textBox)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into Hareketler (Plaka,YakitTur,Litre,Fiyat) values (@p1,@p2,@p3,@p4)", connection);
            cmd.Parameters.AddWithValue("@p1", textBoxPlaka.Text);
            cmd.Parameters.AddWithValue("@p2", yakitTur);
            cmd.Parameters.AddWithValue("@p3", numericUpDown.Value);
            cmd.Parameters.AddWithValue("@p4", decimal.Parse(textBox.Text));
            cmd.ExecuteNonQuery();
            connection.Close();

            connection.Open();
            SqlCommand cmd2 = new SqlCommand("update Kasa set Miktar=Miktar+@y1", connection);
            cmd2.Parameters.AddWithValue("@y1", decimal.Parse(textBox.Text));
            cmd2.ExecuteNonQuery();
            connection.Close();

            connection.Open();
            SqlCommand cmd3 = new SqlCommand("update Yakitlar set Stok=Stok-@q1 where YakitTur='"+yakitTur+"'", connection);
            cmd3.Parameters.AddWithValue("@q1", numericUpDown.Value);
            cmd3.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Satış yapıldı !");
            FiyatListesi();
        }

        void tutarHesapla(NumericUpDown numericUpDown,Label label,TextBox textBox)
        {
            double yakit, litre, tutar;
            yakit = Convert.ToDouble(label.Text);
            litre = Convert.ToDouble(numericUpDown.Value);
            tutar = yakit * litre;
            textBox.Text = tutar.ToString();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            tutarHesapla(numericUpDown1,label95,textBoxTutar95);

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            tutarHesapla(numericUpDown2, label97, textBoxTutar97);

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            tutarHesapla(numericUpDown3, labelED, textBoxTutarED);

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            tutarHesapla(numericUpDown4, labelYPD, textBoxTutarYPD);

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            tutarHesapla(numericUpDown5, labelGaz, textBoxTutarGaz);

        }



        private void buttonDoldur_Click(object sender, EventArgs e)
        {
            if(numericUpDown1.Value != 0)
            {
                satisYap("Kurşunsuz95",numericUpDown1, textBoxTutar95);
            }
            else if (numericUpDown2.Value != 0)
            {
                satisYap("Kurşunsuz97", numericUpDown2, textBoxTutar97);
            }
            else if (numericUpDown3.Value != 0)
            {
                satisYap("EuroDizel10", numericUpDown3, textBoxTutarED);
            }
            else if (numericUpDown4.Value != 0)
            {
                satisYap("YeniProDizel10", numericUpDown4, textBoxTutarYPD);
            }
            else if (numericUpDown5.Value != 0)
            {
                satisYap("Gaz", numericUpDown5, textBoxTutarGaz);
            }
            else
            {
                MessageBox.Show("Lütfen miktar giriniz");
            }

        }
    }
}
