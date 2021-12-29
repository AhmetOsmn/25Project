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

namespace NotKayitSistemi
{
    public partial class FormOgretmenDetay : Form
    {
        public FormOgretmenDetay()
        {
            InitializeComponent();
        }

        private void FormOgretmenDetay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbNotKayitDataSet.TblDers' table. You can move, or remove it, as needed.
            this.tblDersTableAdapter.Fill(this.dbNotKayitDataSet.TblDers);

        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=4HMT;Initial Catalog=DbNotKayit;Integrated Security=True");

        private void buttonOgrenciEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TblDers (OgrenciNumara, OgrenciAd, OgrenciSoyad) values (@P1,@P2,@P3)",baglanti);
            komut.Parameters.AddWithValue("@P1", maskedTextBoxNumara.Text);
            komut.Parameters.AddWithValue("@P2", textBoxAd.Text);
            komut.Parameters.AddWithValue("@P3", textBoxSoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ogrenci Sisteme Eklendi");
            this.tblDersTableAdapter.Fill(this.dbNotKayitDataSet.TblDers);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatir = dataGridView1.SelectedCells[0].RowIndex;

            maskedTextBoxNumara.Text = dataGridView1.Rows[secilenSatir].Cells[1].Value.ToString();
            textBoxAd.Text = dataGridView1.Rows[secilenSatir].Cells[2].Value.ToString();
            textBoxSoyad.Text = dataGridView1.Rows[secilenSatir].Cells[3].Value.ToString();
            textBoxSinav1.Text = dataGridView1.Rows[secilenSatir].Cells[4].Value.ToString();
            textBoxSinav2.Text = dataGridView1.Rows[secilenSatir].Cells[5].Value.ToString();
            labelOrtalama.Text = dataGridView1.Rows[secilenSatir].Cells[6].Value.ToString();
            if (Convert.ToInt32(dataGridView1.Rows[secilenSatir].Cells[0].Value) > 0)
            {
                buttonOgrenciEkle.Enabled = false;
            }
            

        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            double ortalama, s1, s2;
            string durum;

            s1 = Convert.ToDouble(textBoxSinav1.Text);
            s2 = Convert.ToDouble(textBoxSinav2.Text);

            ortalama = ((s1*40)/100) + ((s2*60)/100);
            labelOrtalama.Text = ortalama.ToString();

            if (ortalama>=50)
            {
                durum = "True";
            }
            else
            {
                durum = "False";
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TblDers set OgrenciSinav1=@P1, OgrenciSinav2=@P2, Ortalama=@P3, Durum=@P4 WHERE OgrenciNumara=@P5",baglanti);
            komut.Parameters.AddWithValue("@P1", textBoxSinav1.Text);
            komut.Parameters.AddWithValue("@P2", textBoxSinav2.Text);
            komut.Parameters.AddWithValue("@P3", decimal.Parse(labelOrtalama.Text));
            komut.Parameters.AddWithValue("@P4", durum);
            komut.Parameters.AddWithValue("@P5", maskedTextBoxNumara.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ogrenci Notlari Guncellendi");
            this.tblDersTableAdapter.Fill(this.dbNotKayitDataSet.TblDers);

        }
    }
}
