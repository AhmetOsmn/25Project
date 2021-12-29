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

namespace _11.KullanicilarArasiMesajlasmaSistemi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string numara;

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BHGN45D\AHMETSDBSERVER;Initial Catalog=25Project-11.KullanicilarArasiMesajlasmaSistemi;Integrated Security=True");

        void gelenKutusu()
        {
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter("select MesajID, (KisiAd+ ' ' +KisiSoyad) as GONDEREN,MesajBaslik as BASLIK,MesajIcerik as ICERIK from Mesajlar inner join Kisiler on Mesajlar.MesajGonderen=Kisiler.KisiNumara where MesajAlici =" + numara, connection);
            DataTable dataTable1 = new DataTable();
            sqlDataAdapter1.Fill(dataTable1);
            dataGridViewGelen.DataSource = dataTable1;
        }

        void gidenKutusu()
        {
            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter("select MesajID, (KisiAd+ ' ' +KisiSoyad) as ALICI,MesajBaslik as BASLIK,MesajIcerik as ICERIK from Mesajlar inner join Kisiler on Mesajlar.MesajAlici=Kisiler.KisiNumara where MesajGonderen=" + numara, connection);
            DataTable dataTable2 = new DataTable();
            sqlDataAdapter2.Fill(dataTable2);
            dataGridViewGiden.DataSource = dataTable2;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            labelNumara.Text = numara;
            gelenKutusu();
            gidenKutusu();

            connection.Open();
            SqlCommand command = new SqlCommand("Select KisiAd, KisiSoyad From Kisiler where KisiNumara=" + numara, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                labelAdSoyad.Text = dataReader[0] + " " + dataReader[1]; 
            }
            connection.Close();
        }

        void temizle()
        {
            textBox1.Text = "";
            maskedTextBox1.Text = "";
            richTextBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into mesajlar (MesajGonderen,MesajAlici,MesajBaslik,MesajIcerik) values (@P1, @P2, @P3, @P4)", connection);

            command.Parameters.AddWithValue("@P1", numara);
            command.Parameters.AddWithValue("@P2", maskedTextBox1.Text);
            command.Parameters.AddWithValue("@P3", textBox1.Text);
            command.Parameters.AddWithValue("@P4", richTextBox1.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Mesaj iletildi");
            gidenKutusu();
            temizle();
        }
    }
}
