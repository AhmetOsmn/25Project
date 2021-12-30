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

namespace _12.MiniSQLDerleyicisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        
        SqlConnection connection = new SqlConnection();
        
        int flag = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = richTextBox1.Text;

            try
            {
                if (flag != 0)
                {

                    SqlDataAdapter adapter = new SqlDataAdapter(sorgu, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                }
                else
                {
                    MessageBox.Show("Lütfen ilk önce database'i seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Sorgunuzu kontrol edin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = richTextBox1.Text;

            try
            {
                if (flag != 0)
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sorgu, connection);
                    command.ExecuteNonQuery();
                    connection.Close();

                    SqlDataAdapter adapter = new SqlDataAdapter("select * from Kisiler", connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Lütfen ilk önce database'i seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Sorgunuzu kontrol edin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                string newDb = richTextBox1.Text;

                connection.ConnectionString = @"Data Source=DESKTOP-BHGN45D\AHMETSDBSERVER;Initial Catalog=" + newDb + ";Integrated Security=True";
                flag = 1;
                label3.Text = flag.ToString();
                label2.Text = @"Data Source=DESKTOP-BHGN45D\AHMETSDBSERVER;Initial Catalog=" + newDb + ";Integrated Security=True";
                richTextBox1.Text = "";

            }
            else
            {
                MessageBox.Show("Seçmek istediğiniz database'in adını girin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }
    }
}
