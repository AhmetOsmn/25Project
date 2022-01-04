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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BHGN45D\AHMETSDBSERVER;Initial Catalog=25Project-17.BiletRezervasyonSistemi;Integrated Security=True");

        void RezervasyonListele()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select  Seferler.SeferKalkis as 'KALKIŞ', Seferler.SeferVaris as 'VARIŞ'," +
                                                        "Seferler.SeferTarih as 'TARİH', Seferler.SeferSaat as 'SAAT', SeferDetaylar.Koltuk as 'KOLTUK NO'," +
                                                        "Yolcular.YolcuCinsiyet as 'CİNSİYET', (Yolcular.YolcuAd + ' ' + Yolcular.YolcuSoyad) as 'YOLCU', Yolcular.YolcuTC as 'TC', Yolcular.YolcuTelefon as 'TELEFON', Seferler.SeferFiyat as 'FİYAT' " +
                                                        "from Seferler " +
                                                        "inner join SeferDetaylar " +
                                                        "on SeferDetaylar.SeferNO = Seferler.SeferNO " +
                                                        "inner " +
                                                        "join Yolcular " +
                                                        "on SeferDetaylar.YolcuTC = Yolcular.YolcuTC", connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            RezervasyonListele();
        }
    }
}
