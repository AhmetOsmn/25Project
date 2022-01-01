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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BHGN45D\AHMETSDBSERVER;Initial Catalog=25Project-14.BankamatikSimulasyonu;Integrated Security=True");
        private void linkLabelKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select * from Kisiler where KisiHesapNo=@p1 and KisiSifre=@p2", connection);
            cmd.Parameters.AddWithValue("@p1", maskedTextBoxHesapNo.Text);
            cmd.Parameters.AddWithValue("@p2", textBoxSifre.Text);
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.Read())
            {
                Form2 form2 = new Form2();
                form2.hesap = maskedTextBoxHesapNo.Text;
                form2.Show();
            }
            else
            {
                MessageBox.Show("Hatalı bilgi!");
            }
            connection.Close();
        }
    }
}
