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

namespace _21.PastahaneUrunMaliyetlendirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BHGN45D\AHMETSDBSERVER;Initial Catalog=25Project-21.PastahaneUrunMaliyetlendirme;Integrated Security=True");

        void MalzemeListe()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Malzemeler",connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void UrunListe()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Urunler", connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void Kasa()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Kasa", connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void Urunler()
        {
            connection.Open();
            SqlDataAdapter da= new SqlDataAdapter("select * from Urunler",connection);
            DataTable dt= new DataTable();
            da.Fill(dt);
            comboBoxUrun.ValueMember = "UrunID";
            comboBoxUrun.DisplayMember = "UrunAd";
            comboBoxUrun.DataSource = dt;
            connection.Close();
        }

        void Malzemeler()
        {
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Malzemeler", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBoxMalzeme.ValueMember = "MalzemeID";
            comboBoxMalzeme.DisplayMember = "MalzemeAd";
            comboBoxMalzeme.DataSource = dt;
            connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UrunListe();
            Urunler();
            Malzemeler();
        }

        private void buttonUrunListesi_Click(object sender, EventArgs e)
        {
            UrunListe();
        }

        private void buttonMalzemeListesi_Click(object sender, EventArgs e)
        {
            MalzemeListe();
        }

        private void buttonKasa_Click(object sender, EventArgs e)
        {
            Kasa();
        }

        private void buttonMalzemeEkle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into Malzemeler (MalzemeAd,MalzemeStok,MalzemeFiyat,MalzemeNotlar,MalzemeBirim) values(@p1,@p2,@p3,@p4,@p5)",connection);
            cmd.Parameters.AddWithValue("@p1",textBoxMalzemeAd.Text);
            cmd.Parameters.AddWithValue("@p2",decimal.Parse(textBoxMalzemeStok.Text));
            cmd.Parameters.AddWithValue("@p3",decimal.Parse(textBoxMalzemeFiyat.Text));
            cmd.Parameters.AddWithValue("@p4",textBoxMalzemeNot.Text);
            cmd.Parameters.AddWithValue("@p5",comboBoxBirim.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Malzeme sisteme eklendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            MalzemeListe();
        }

        private void buttonUrunEkle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into Urunler (UrunAd) values(@p1)", connection);
            cmd.Parameters.AddWithValue("@p1", textBoxUrunAd.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Ürun sisteme eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UrunListe();
        }

        private void buttonUrunOlustur_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Firin (UrunID,MalzemeID,Miktar,Maliyet) values(@p1,@p2,@p3,@p4)",connection);
            command.Parameters.AddWithValue("@p1",comboBoxUrun.SelectedValue);
            command.Parameters.AddWithValue("@p2",comboBoxMalzeme.SelectedValue);
            command.Parameters.AddWithValue("@p3",decimal.Parse(textBoxUrunMiktar.Text));
            command.Parameters.AddWithValue("@p4",decimal.Parse(textBoxUrunMaliyet.Text));
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Ürun oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            listBox1.Items.Add(comboBoxMalzeme.Text + " - " + textBoxUrunMiktar.Text+"(adet/gram)" + " - " + textBoxUrunMaliyet.Text+" TL");
        }

        private void textBoxUrunMiktar_TextChanged(object sender, EventArgs e)
        {
            double maliyet;
            if (textBoxUrunMiktar.Text == "")
            {
                textBoxUrunMiktar.Text = "0";
            }
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from Malzemeler where MalzemeID=@p1", connection);
            cmd.Parameters.AddWithValue("@p1", comboBoxMalzeme.SelectedValue);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBoxUrunMaliyet.Text = dr[3].ToString();
            }
            connection.Close();
            maliyet = Convert.ToDouble(textBoxUrunMaliyet.Text)/1000 * Convert.ToDouble(textBoxUrunMiktar.Text);
            textBoxUrunMaliyet.Text = maliyet.ToString();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBoxUrunID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBoxUrunAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            connection.Open();
            SqlCommand cmd = new SqlCommand("select sum(Maliyet) from Firin where UrunID=@p1",connection);
            cmd.Parameters.AddWithValue("@p1",textBoxUrunID.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBoxUrunMF.Text = dr[0].ToString();
            }
            connection.Close();

        }

    }
}
