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

namespace _11.KullanicilarArasiMesajlasmaSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BHGN45D\AHMETSDBSERVER;Initial Catalog=25Project-11.KullanicilarArasiMesajlasmaSistemi;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select * from Kisiler where KisiNumara=@P1 AND KisiSifre=@P2",connection);
            command.Parameters.AddWithValue("@P1", maskedTextBox1.Text);
            command.Parameters.AddWithValue("@P2", textBox1.Text);
            SqlDataReader dr = command.ExecuteReader();

            if (dr.Read())
            {
                Form2 form2 = new Form2();
                form2.numara = maskedTextBox1.Text;
                form2.Show();
            }
            else
            {
                MessageBox.Show("Hatalı bilgi");
            }
            connection.Close();
        }
    }
}
//Data Source=DESKTOP-BHGN45D\AHMETSDBSERVER;Initial Catalog=25Project-9.TelefonRehber;Integrated Security=True
