using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DovizOfisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";

            var xmlDosya = new XmlDocument();
            xmlDosya.Load(bugun);

            string dolarAlis = xmlDosya.SelectSingleNode("Tarih_Date /Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            labelDolarAlis.Text = dolarAlis;

            string dolarSatis = xmlDosya.SelectSingleNode("Tarih_Date /Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            labelDolarSatis.Text = dolarSatis;

            string euroAlis = xmlDosya.SelectSingleNode("Tarih_Date /Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            labelEuroAlis.Text = euroAlis;

            string euroSatis = xmlDosya.SelectSingleNode("Tarih_Date /Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            labelEuroSatis.Text = euroSatis;
        }

        private void buttonDolarAl_Click(object sender, EventArgs e)
        {
            textBoxKur.Text = labelDolarAlis.Text;
        }

        private void buttonDolarSat_Click(object sender, EventArgs e)
        {
            textBoxKur.Text = labelDolarSatis.Text;
        }

        private void buttonEuroAl_Click(object sender, EventArgs e)
        {
            textBoxKur.Text = labelEuroAlis.Text;
        }

        private void buttonEuroSat_Click(object sender, EventArgs e)
        {
            textBoxKur.Text = labelEuroSatis.Text;
        }

        private void buttonSatisYap_Click(object sender, EventArgs e)
        {
            

            double kur, miktar, tutar;

            kur = Convert.ToDouble(textBoxKur.Text);
            miktar = Convert.ToDouble(textBoxMiktar.Text);
            tutar = kur * miktar;
            textBoxTutar.Text = tutar.ToString();
        }

        private void textBoxKur_TextChanged(object sender, EventArgs e)
        {
            textBoxKur.Text = textBoxKur.Text.Replace(".",",");
        }

        private void buttonSatisYap2_Click(object sender, EventArgs e)
        {
            double kur = Convert.ToDouble(textBoxKur.Text);
            int miktar = Convert.ToInt32(textBoxMiktar.Text);
            int tutar = Convert.ToInt32(miktar / kur);
            textBoxTutar.Text = tutar.ToString();

            double kalan;
            kalan = miktar % kur;
            textBoxKalan.Text = kalan.ToString();
        }
    }
}
