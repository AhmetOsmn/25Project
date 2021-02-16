using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotKayitSistemi
{
    public partial class FormOgrenciDetay : Form
    {
        public FormOgrenciDetay()
        {
            InitializeComponent();
        }

        public string numara;

        SqlConnection baglanti = new SqlConnection(@"Data Source=4HMT;Initial Catalog=DbNotKayit;Integrated Security=True");

        
        private void FormOgrenciDetay_Load(object sender, EventArgs e)
        {
            labelNumara.Text = numara;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TblDers where OgrenciNumara=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1",numara);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                labelAdSoyad.Text = dr[2].ToString() + " " + dr[3].ToString();
                labelSinav1.Text = dr[4].ToString();
                labelSinav2.Text = dr[5].ToString();
                labelOrtalama.Text = dr[6].ToString();
                labelDurum.Text = dr[7].ToString();
            }
            baglanti.Close();
        }
    }
}
