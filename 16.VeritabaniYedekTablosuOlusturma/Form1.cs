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

namespace _16.VeritabaniYedekTablosuOlusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BHGN45D\AHMETSDBSERVER;Initial Catalog=25-Project-16.VeritabaniYedekTablosuOlusturma;Integrated Security=True");
        
        void Listele()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Kitaplar",connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        
        void Sayac()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select * from Sayac",connection);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                labelKitapAdet.Text = dr[0].ToString();
            }
            connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
            Sayac();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Kitaplar (KitapAd,KitapYazar,KitapSayfa,KitapYayinEvi,KitapTur) values (@p1,@p2,@p3,@p4,@p5)",connection);
            command.Parameters.AddWithValue("@p1",textBoxKitapAd.Text);
            command.Parameters.AddWithValue("@p2",textBoxKitapYazar.Text);
            command.Parameters.AddWithValue("@p3",textBoxKitapSayfa.Text);
            command.Parameters.AddWithValue("@p4",textBoxKitapYayinEvi.Text);
            command.Parameters.AddWithValue("@p5",textBoxKitapTur.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kitap sisteme yüklendi !","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Listele();
            Sayac();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            textBoxKitapID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBoxKitapAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBoxKitapYazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBoxKitapSayfa.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBoxKitapYayinEvi.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBoxKitapTur.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("delete from Kitaplar where KitapID=@p1",connection);
            command.Parameters.AddWithValue("@p1", textBoxKitapID.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kitap sistemden silindi !","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            Listele();
            Sayac();
        }
    }
}
