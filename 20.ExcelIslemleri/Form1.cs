using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _20.ExcelIslemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //‪C:\Projects\25Project\20.ExcelIslemleri\20.proje.xlsx

        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Projects\25Project\20.ExcelIslemleri\20.proje.xlsx;Extended Properties='Excel 12.0 Xml; HDR=YES;'");

        void Listele()
        {
            connection.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from [Sayfa1$]", connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listele();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand("insert into [Sayfa1$] (Saat, Ders) values(@p1,@p2)",connection);
            command.Parameters.AddWithValue("@p1",textBoxSaat.Text);
            command.Parameters.AddWithValue("@p2",textBoxDersAdi.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Yeni ders bilgisi eklendi.");
            Listele();
        }
    }
}
