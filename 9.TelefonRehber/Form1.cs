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

namespace _9.TelefonRehber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-BHGN45D\\AHMETSDBSERVER;Initial Catalog=25Project-9.TelefonRehber;Integrated Security=True");
        
        void ListData()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Kisiler",connection);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void ClearData()
        {
            textBoxAd.Text = "";
            textBoxSoyad.Text = "";
            textBoxID.Text = "";
            textBoxMail.Text = "";
            maskedTextBoxTel.Text = "";
            textBoxAd.Focus();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            ListData();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Kisiler (Ad, Soyad, Telefon, Mail) values (@P1, @P2, @P3, @P4)",connection);
            command.Parameters.AddWithValue("@P1", textBoxAd.Text);
            command.Parameters.AddWithValue("@P2", textBoxSoyad.Text);
            command.Parameters.AddWithValue("@P3", maskedTextBoxTel.Text);
            command.Parameters.AddWithValue("@P4", textBoxMail.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kişi sisteme kaydedildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            ListData();
            ClearData();
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = dataGridView1.SelectedCells[0].RowIndex;

            textBoxID.Text = dataGridView1.Rows[selectedRow].Cells[0].Value.ToString();
            textBoxAd.Text = dataGridView1.Rows[selectedRow].Cells[1].Value.ToString();
            textBoxSoyad.Text = dataGridView1.Rows[selectedRow].Cells[2].Value.ToString();
            maskedTextBoxTel.Text = dataGridView1.Rows[selectedRow].Cells[3].Value.ToString();
            textBoxMail.Text = dataGridView1.Rows[selectedRow].Cells[4].Value.ToString();

        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Delete from Kisiler where ID=" + textBoxID.Text, connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kisi rehberden silindi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Stop);
            ListData();
            ClearData();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Update Kisiler set Ad=@P1, Soyad=@P2, Telefon=@P3, Mail=@P4   where ID=@P5", connection);
            command.Parameters.AddWithValue("@P1",textBoxAd.Text);
            command.Parameters.AddWithValue("@P2",textBoxSoyad.Text);
            command.Parameters.AddWithValue("@P3",maskedTextBoxTel.Text);
            command.Parameters.AddWithValue("@P4",textBoxMail.Text);
            command.Parameters.AddWithValue("@P5",textBoxID.Text);
            command.ExecuteNonQuery();
            connection.Close ();
            MessageBox.Show("Kişi bilgileri güncellendi","Uyarı", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            ListData();
            ClearData();

        }
    }
}
//
