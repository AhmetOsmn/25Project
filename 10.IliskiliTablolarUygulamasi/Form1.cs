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

namespace _10.IliskiliTablolarUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-BHGN45D\\AHMETSDBSERVER;Initial Catalog=25Project-10.IliskiliTablolarUygulamasi;Integrated Security=True");
        
        void ListData()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT h.HareketID, u.UrunAd as 'Ürün adı', (m.MusteriAd + ' '+ m.MusteriSoyad) as 'Müşteri', (p.PersonelAd + ' ' + p.PersonelSoyad) as 'Personel', h.Fiyat " + 
                                                        "From Hareketler h "+
                                                        "inner join Urunler u "+
                                                        "on h.Urun = u.UrunID "+
                                                        "inner join Musteriler m "+
                                                        "on h.Musteri = m.MusteriID "+
                                                        "inner join Personeller p "+
                                                        "on h.Personel = p.PersonelID",connection);

            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListData();
        }

    }
}
