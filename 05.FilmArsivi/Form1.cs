using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace MovieArchive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source = 4HMT; Initial Catalog = MovieArchive; Integrated Security = True");
        
        void filmler()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TblMoviess", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            filmler();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TblMoviess (Name,Category,Link) values (@P1,@P2,@P3)", baglanti);
            komut.Parameters.AddWithValue("@P1", textBoxFilmAdi.Text);
            komut.Parameters.AddWithValue("@P2", textBoxKategori.Text);
            komut.Parameters.AddWithValue("@P3", textBoxLink.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Film listenize eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            filmler();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            webBrowser1.Navigate(link);
        }

        private void buttonHakkımızda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Ahmet Osman Sezgin tarafindan 14 Mart 2021'de kodlandi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void buttonRenkDegistir_Click(object sender, EventArgs e)
        {
            
        }
    }
}
