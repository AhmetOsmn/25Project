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

namespace _13.VeriSifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BHGN45D\AHMETSDBSERVER;Initial Catalog=25Project-13.VeriSifreleme;Integrated Security=True");
        void Listele()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select Ad,Soyad,Mail,Sifre,HesapNo from Veriler",connection);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("ID");
            dt2.Columns.Add("Ad");
            dt2.Columns.Add("Soyad");
            dt2.Columns.Add("Mail");
            dt2.Columns.Add("Sifre");
            dt2.Columns.Add("HesapNo");
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                DataRow r = dt2.NewRow();
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    try
                    {
                        string cozum = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        byte[] cozumdizi = Convert.FromBase64String(cozum);
                        string cozumveri = ASCIIEncoding.ASCII.GetString(cozumdizi);
                        r[j] = cozumveri;
                    }
                    catch (Exception)
                    {
                        r[j] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                dt2.Rows.Add(r);
            }
            dataGridView2.DataSource = dt2;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBoxAd.Text;
            byte[] adDizi = ASCIIEncoding.ASCII.GetBytes(ad);
            string sifreliAd = Convert.ToBase64String(adDizi);

            string soyad = textBoxSoyad.Text;
            byte[] soyadDizi = ASCIIEncoding.ASCII.GetBytes(soyad);
            string sifreliSoyad = Convert.ToBase64String(soyadDizi);

            string mail = textBoxMail.Text;
            byte[] mailDizi = ASCIIEncoding.ASCII.GetBytes(mail);
            string sifreliMail = Convert.ToBase64String(mailDizi);

            string sifre = textBoxSifre.Text;
            byte[] sifreDizi = ASCIIEncoding.ASCII.GetBytes(sifre);
            string sifreliSifre = Convert.ToBase64String(sifreDizi);

            string hesapNo = textBoxHesapNo.Text;
            byte[] hesapNoDizi = ASCIIEncoding.ASCII.GetBytes(hesapNo);
            string sifreliHesapNo = Convert.ToBase64String(hesapNoDizi);

            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into Veriler (Ad,Soyad,Mail,Sifre,HesapNo) values (@P1,@P2,@P3,@P4,@P5)", connection);

            cmd.Parameters.AddWithValue("@P1", sifreliAd);
            cmd.Parameters.AddWithValue("@P2", sifreliSoyad);
            cmd.Parameters.AddWithValue("@P3", sifreliMail);
            cmd.Parameters.AddWithValue("@P4", sifreliSifre);
            cmd.Parameters.AddWithValue("@P5", sifreliHesapNo);

            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Veriler eklendi!");
            Listele();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }

        //Odev kısmını (dataGrid2 de, sifrelenen verileri cozup gostermeyi) (--https://www.udemy.com/course/25derste25proje/learn/lecture/10281460#questions/6150954)'de paylasan arkadastan alarak yaptım.

    }
}
