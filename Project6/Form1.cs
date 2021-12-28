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

namespace Project6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=4HMT;Initial Catalog=Proje6;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

            SqlDataAdapter da = new SqlDataAdapter("Execute P6",baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
