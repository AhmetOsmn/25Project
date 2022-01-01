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

        private void Form1_Load(object sender, EventArgs e)
        {
            DersListesi();
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
            cmd.Parameters.AddWithValue("@p1",comboBoxDers.SelectedValue);
            cmd.Parameters.AddWithValue("@p2",comboBoxOgretmen.SelectedValue);
            cmd.Parameters.AddWithValue("@p3",maskedTextBoxTarih.Text);
            cmd.Parameters.AddWithValue("@p4",maskedTextBoxSaat.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Etüt oluşturuldu","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
