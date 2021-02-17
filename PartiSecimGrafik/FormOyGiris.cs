using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PartiSecimGrafik
{
    public partial class FormOyGiris : Form
    {
        public FormOyGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=4HMT;Initial Catalog=DbSecim;Integrated Security=True");

        private void buttonOyGirisiYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TblIlce (IlceAd, AParti, BParti, CParti, DParti, EParti) values (@P1, @P2, @P3, @P4, @P5, @P6)", baglanti);
            komut.Parameters.AddWithValue("@P1", textBoxIlceAd.Text);
            komut.Parameters.AddWithValue("@P2", textBoxA.Text);
            komut.Parameters.AddWithValue("@P3", textBoxB.Text);
            komut.Parameters.AddWithValue("@P4", textBoxC.Text);
            komut.Parameters.AddWithValue("@P5", textBoxD.Text);
            komut.Parameters.AddWithValue("@P6", textBoxE.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oy Girisi Gerceklesti");

        }

        private void buttonGrafikler_Click(object sender, EventArgs e)
        {
            FormGrafikler formGrafikler = new FormGrafikler();
            formGrafikler.Show();
        }
    }
}
