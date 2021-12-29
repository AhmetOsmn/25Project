using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruNo = 0, dogru = 0, yanlis = 0, bos = 0;

        string[] sorular = 
        { 
            "","Ulkemizin guney kismindaki kiyi bolgesi ?", "Marmara bolgesinde dagi ile unlu, yesil ilimiz ?", "Muslumanlarin kutsal gunu ?", "Karpuzu ile unlu ilimiz ?", "Yeni kelimesinin zit anlamlisi ?", "Padisahın emirlerinin yazili hali ?", "Dunyanin isi kaynagi ?", "Iran'in unlu oldugu ev eşyasi ?" ,
            "Guluyle unlu ilimiz ?", "Mersin'in diger ismi ?", "Askeri bir topluluk ?", "Malatya'nin meshur meyvevsi ?", "Her yıl bahar aylarinda duzenlenen, cicek festivali ?", "Yilin 3. ayi ?", "Uflemeli bir muzik aleti ?", "Halk sairi ?",
            "Cocuklarin cok sevmedigi sebze yemegi ?",  "11 Ayin sultani ?", "Ingilizcede yilan ?", "Turkiye'nin megastari ?", "Ümit kelimesinin eş anlamlisi ?", "Kahvaltisi ile unlu ilimiz ?", "Simsek kelimesinin es anlamlisi ?", "Ege bolgesinde en cok bulunan agac ?"
        };

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                linkLabelBasla.Enabled = false;
        }


        string[] cevaplar =
        {
            "","akdeniz","bursa","cami","diyarbakır","eski","ferman", "güneş","halı","ısparta","içel","jandarma", "kayısı", 
            "lale", "mart", "ney", "ozan","pırasa","ramazan","snake","tarkan","umut","van","yıldırım","zeytin"

        };

        
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            Button[] butonlar =
            {
                null,buttonA, buttonB, buttonC, buttonD, buttonE, buttonF, buttonG, buttonH, buttonI, buttonIı, buttonJ, buttonK,
                buttonL, buttonM, buttonN, buttonO, buttonP, buttonR,buttonS, buttonT, buttonU, buttonV, buttonY, buttonZ

            };

            

            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == cevaplar[soruNo])
                {
                    butonlar[soruNo].BackColor = Color.Green;
                    dogru++;
                    label3.Text = dogru.ToString();
                    textBox1.Text = "";
                    linkLabelBasla.Enabled = true;
                }
                else
                {
                    if(textBox1.Text == "")
                    {
                        linkLabelBasla.Enabled = true;

                    }
                    else
                    {
                        butonlar[soruNo].BackColor = Color.Red;
                        yanlis++;
                        label4.Text = yanlis.ToString();
                        textBox1.Text = "";
                        linkLabelBasla.Enabled = true;
                    }
                
                }
            }

            
        }

        private void linkLabelBasla_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Button[] butonlar =
            {
                null,buttonA, buttonB, buttonC, buttonD, buttonE, buttonF, buttonG, buttonH, buttonI, buttonIı, buttonJ, buttonK,
                buttonL, buttonM, buttonN, buttonO, buttonP, buttonR,buttonS, buttonT, buttonU, buttonV, buttonY, buttonZ

            };

            linkLabelBasla.Text = "Sonraki";
            soruNo++;
            this.Text = soruNo.ToString();

            if (textBox1.Text == "" && soruNo > 1)
            {
                bos++;
                label6.Text = bos.ToString();
            }

            richTextBox1.Text = sorular[soruNo];
            butonlar[soruNo].BackColor = Color.Yellow;
        }
    }
}
