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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BHGN45D\AHMETSDBSERVER;Initial Catalog=25Project-14.BankamatikSimulasyonu;Integrated Security=True");
        public string hesap;
        private void Form4_Load(object sender, EventArgs e)
        {
            connection.Open();
            //SqlCommand cmd = new SqlCommand("select (g.kisiAd + ' '+g.kisiSoyad) as 'Gonderen',  (a.kisiAd + ' '+a.kisiSoyad) as 'Alici', h.Tutar " +
            //                                "From Hareket h " +
            //                                "inner join Kisiler g " +
            //                                "on h.Gonderen = g.KisiHesapNo " +
            //                                "inner join Kisiler a " +
            //                                "on h.Alici = a.KisiHesapNo " +
            //                                "where g.KisiHesapNo = @p1 or a.KisiHesapNo=@p1");

            SqlDataAdapter adapter = new SqlDataAdapter("select (g.kisiAd + ' '+g.kisiSoyad) as 'Gonderen',  (a.kisiAd + ' '+a.kisiSoyad) as 'Alici', h.Tutar " +
                                            "From Hareket h " +
                                            "inner join Kisiler g " +
                                            "on h.Gonderen = g.KisiHesapNo " +
                                            "inner join Kisiler a " +
                                            "on h.Alici = a.KisiHesapNo " +
                                            "where g.KisiHesapNo =" +hesap+ " or a.KisiHesapNo=" + hesap , connection);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
