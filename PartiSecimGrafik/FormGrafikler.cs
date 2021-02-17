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
    public partial class FormGrafikler : Form
    {
        public FormGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=4HMT;Initial Catalog=DbSecim;Integrated Security=True");


        private void FormGrafikler_Load(object sender, EventArgs e)
        {
            //Ilce adlarini comboBox'a cekme
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select IlceAd from TblIlce", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            baglanti.Close();


            //Grafige toplam sonuclari getirme
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select SUM(AParti),SUM(BParti),SUM(CParti),SUM(DParti),SUM(EParti) from TblIlce", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("A Parti", dr2[0]);
                chart1.Series["Partiler"].Points.AddXY("B Parti", dr2[1]);
                chart1.Series["Partiler"].Points.AddXY("C Parti", dr2[2]);
                chart1.Series["Partiler"].Points.AddXY("D Parti", dr2[3]);
                chart1.Series["Partiler"].Points.AddXY("E Parti", dr2[4]);
            }
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from TblIlce where IlceAd=@P1",baglanti);
            komut.Parameters.AddWithValue("@P1", comboBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                progressBar1.Value = int.Parse(dr[2].ToString());
                progressBar2.Value = int.Parse(dr[3].ToString());
                progressBar3.Value = int.Parse(dr[4].ToString());
                progressBar4.Value = int.Parse(dr[5].ToString());
                progressBar5.Value = int.Parse(dr[6].ToString());

                labelA.Text = dr[2].ToString();
                labelB.Text = dr[3].ToString();
                labelC.Text = dr[4].ToString();
                labelD.Text = dr[5].ToString();
                labelE.Text = dr[6].ToString();
            }
            baglanti.Close();
        }
    }
}
