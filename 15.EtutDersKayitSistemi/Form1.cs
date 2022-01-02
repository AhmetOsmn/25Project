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
using System.IO;

namespace _15.EtutDersKayitSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BHGN45D\AHMETSDBSERVER;Initial Catalog=25Project-15.EtutDersKayitSistemi;Integrated Security=True");
        
        void DersListesi()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Dersler",connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            comboBoxDers.ValueMember = "DersID";
            comboBoxDers.DisplayMember = "DersAd";
            comboBoxDers.DataSource = dt;
        }

        void OgretmenDersListesi()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Dersler", connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            comboBoxOgretmenDers.ValueMember = "DersID";
            comboBoxOgretmenDers.DisplayMember = "DersAd";
            comboBoxOgretmenDers.DataSource = dt;
        }

        void EtutListesi()
        {
            SqlDataAdapter adapter3 = new SqlDataAdapter("select EtutID,DersAd, (Ogretmenler.OgretmenAd + ' ' + Ogretmenler.OgretmenSoyad) as 'Ogretmen', " +
                                                         "EtutTarih, EtutSaat, EtutDurum " +
                                                         "from Etutler " +
                                                         "inner join Dersler on Etutler.DersID = Dersler.DersID "+
                                                         "inner join Ogretmenler on Etutler.OgretmenID = Ogretmenler.OgretmenID",connection);
            DataTable dt3 = new DataTable();
            adapter3.Fill(dt3);
            dataGridView1.DataSource = dt3;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            DersListesi();
            EtutListesi();
            OgretmenDersListesi();
        }

        private void comboBoxDers_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter adapter2 = new SqlDataAdapter("Select * from Ogretmenler where OgretmenBransID="+comboBoxDers.SelectedValue,connection);
            DataTable dt2 = new DataTable();
            adapter2.Fill(dt2);
            comboBoxOgretmen.ValueMember = "OgertmenID";
            comboBoxOgretmen.DisplayMember = "OgretmenAd";
            comboBoxOgretmen.DataSource = dt2;
        }

        private void buttonEtutOlustur_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into Etutler (DersID,OgretmenID,EtutTarih,EtutSaat) values (@p1,@p2,@p3,@p4)",connection);
            var dataRowValue = (DataRowView)comboBoxDers.SelectedItem;
            var dataRowValue2 = (DataRowView)comboBoxOgretmen.SelectedItem;

            cmd.Parameters.AddWithValue("@p1", dataRowValue["DersID"].ToString());
            cmd.Parameters.AddWithValue("@p2", dataRowValue2["OgretmenID"].ToString());
            cmd.Parameters.AddWithValue("@p3",maskedTextBoxTarih.Text);
            cmd.Parameters.AddWithValue("@p4",maskedTextBoxSaat.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Etüt oluşturuldu","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            EtutListesi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBoxEtutID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void buttonEtutVer_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd2 = new SqlCommand("update Etutler set OgrenciID=@p1, EtutDurum=@p2 where EtutID=@p3",connection);
            cmd2.Parameters.AddWithValue("@p1",textBoxOgrenciID.Text);
            cmd2.Parameters.AddWithValue("@p2","True");
            cmd2.Parameters.AddWithValue("@p3",textBoxEtutID.Text);
            cmd2.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Etüt öğrenciye verildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            EtutListesi();

        }

        private void buttonFotografYukle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBoxFotograf.ImageLocation = openFileDialog1.FileName;
        }

        private void buttonOgrenciEkle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Ogrenciler (OgrenciAd, OgrenciSoyad, OgrenciFotograf, OgrenciSinif,OgrenciTelefon,OgrenciMail) values (@p1,@p2,@p3,@p4,@p5,@p6)",connection);
            command.Parameters.AddWithValue("@p1",textBoxOgrenciAd.Text);
            command.Parameters.AddWithValue("@p2",textBoxOgrenciSoyad.Text);
            command.Parameters.AddWithValue("@p3",pictureBoxFotograf.ImageLocation);
            command.Parameters.AddWithValue("@p4",textBoxOgrenciSinif.Text);
            command.Parameters.AddWithValue("@p5",maskedTextBoxOgrenciTelefon.Text);
            command.Parameters.AddWithValue("@p6",textBoxOgrenciMail.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Öğrenci sisteme kaydedildi !","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void buttonDersEkle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Dersler (DersAd) values (@p1)",connection);
            command.Parameters.AddWithValue("@p1",textBoxDersAdi.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Ders sisteme kaydedildi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DersListesi();
        }

        private void buttonOgretmenEkle_Click(object sender, EventArgs e)
        {
            connection.Open();
            var dataRowValue = (DataRowView)comboBoxOgretmenDers.SelectedItem;
            SqlCommand command = new SqlCommand("insert into Ogretmenler (OgretmenAd, OgretmenSoyad, OgretmenBransID) values (@p1,@p2,@p3)", connection);
            command.Parameters.AddWithValue("@p1", textBoxOgretmenAd.Text);
            command.Parameters.AddWithValue("@p2", textBoxOgretmenSoyad.Text);
            command.Parameters.AddWithValue("@p3", comboBoxOgretmenDers.SelectedValue);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Öğretmen sisteme kaydedildi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DersListesi();
        }
    }
}
