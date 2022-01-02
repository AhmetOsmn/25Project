namespace _15.EtutDersKayitSistemi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonEtutOlustur = new System.Windows.Forms.Button();
            this.maskedTextBoxSaat = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBoxTarih = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxOgretmen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxEtutID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxOgrenciID = new System.Windows.Forms.TextBox();
            this.buttonEtutVer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxDersAdi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonDersEkle = new System.Windows.Forms.Button();
            this.buttonFotografYukle = new System.Windows.Forms.Button();
            this.buttonOgrenciEkle = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxOgrenciMail = new System.Windows.Forms.TextBox();
            this.textBoxOgrenciSinif = new System.Windows.Forms.TextBox();
            this.textBoxOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.textBoxOgrenciAd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pictureBoxFotograf = new System.Windows.Forms.PictureBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.buttonOgretmenEkle = new System.Windows.Forms.Button();
            this.textBoxOgretmenSoyad = new System.Windows.Forms.TextBox();
            this.textBoxOgretmenAd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.maskedTextBoxOgrenciTelefon = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxOgretmenDers = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotograf)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonEtutOlustur);
            this.groupBox1.Controls.Add(this.maskedTextBoxSaat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.maskedTextBoxTarih);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxOgretmen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxDers);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // buttonEtutOlustur
            // 
            this.buttonEtutOlustur.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEtutOlustur.Location = new System.Drawing.Point(99, 170);
            this.buttonEtutOlustur.Name = "buttonEtutOlustur";
            this.buttonEtutOlustur.Size = new System.Drawing.Size(213, 46);
            this.buttonEtutOlustur.TabIndex = 5;
            this.buttonEtutOlustur.Text = "Etüt Oluştur";
            this.buttonEtutOlustur.UseVisualStyleBackColor = true;
            this.buttonEtutOlustur.Click += new System.EventHandler(this.buttonEtutOlustur_Click);
            // 
            // maskedTextBoxSaat
            // 
            this.maskedTextBoxSaat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxSaat.Location = new System.Drawing.Point(261, 127);
            this.maskedTextBoxSaat.Mask = "00:00";
            this.maskedTextBoxSaat.Name = "maskedTextBoxSaat";
            this.maskedTextBoxSaat.Size = new System.Drawing.Size(52, 27);
            this.maskedTextBoxSaat.TabIndex = 4;
            this.maskedTextBoxSaat.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(202, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Saat:";
            // 
            // maskedTextBoxTarih
            // 
            this.maskedTextBoxTarih.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxTarih.Location = new System.Drawing.Point(99, 127);
            this.maskedTextBoxTarih.Mask = "00/00/0000";
            this.maskedTextBoxTarih.Name = "maskedTextBoxTarih";
            this.maskedTextBoxTarih.Size = new System.Drawing.Size(89, 27);
            this.maskedTextBoxTarih.TabIndex = 3;
            this.maskedTextBoxTarih.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(32, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tarih:";
            // 
            // comboBoxOgretmen
            // 
            this.comboBoxOgretmen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOgretmen.FormattingEnabled = true;
            this.comboBoxOgretmen.Location = new System.Drawing.Point(99, 83);
            this.comboBoxOgretmen.Name = "comboBoxOgretmen";
            this.comboBoxOgretmen.Size = new System.Drawing.Size(213, 27);
            this.comboBoxOgretmen.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(6, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Öğretmen:";
            // 
            // comboBoxDers
            // 
            this.comboBoxDers.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDers.FormattingEnabled = true;
            this.comboBoxDers.Location = new System.Drawing.Point(99, 35);
            this.comboBoxDers.Name = "comboBoxDers";
            this.comboBoxDers.Size = new System.Drawing.Size(213, 27);
            this.comboBoxDers.TabIndex = 1;
            this.comboBoxDers.SelectedIndexChanged += new System.EventHandler(this.comboBoxDers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(41, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ders:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxEtutID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxOgrenciID);
            this.groupBox2.Controls.Add(this.buttonEtutVer);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(359, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 173);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // textBoxEtutID
            // 
            this.textBoxEtutID.Enabled = false;
            this.textBoxEtutID.Location = new System.Drawing.Point(138, 38);
            this.textBoxEtutID.Name = "textBoxEtutID";
            this.textBoxEtutID.Size = new System.Drawing.Size(100, 26);
            this.textBoxEtutID.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.IndianRed;
            this.label5.Location = new System.Drawing.Point(58, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Etüt ID:";
            // 
            // textBoxOgrenciID
            // 
            this.textBoxOgrenciID.Location = new System.Drawing.Point(138, 86);
            this.textBoxOgrenciID.Name = "textBoxOgrenciID";
            this.textBoxOgrenciID.Size = new System.Drawing.Size(100, 26);
            this.textBoxOgrenciID.TabIndex = 8;
            // 
            // buttonEtutVer
            // 
            this.buttonEtutVer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEtutVer.Location = new System.Drawing.Point(62, 118);
            this.buttonEtutVer.Name = "buttonEtutVer";
            this.buttonEtutVer.Size = new System.Drawing.Size(213, 46);
            this.buttonEtutVer.TabIndex = 7;
            this.buttonEtutVer.Text = "Etüt Ver";
            this.buttonEtutVer.UseVisualStyleBackColor = true;
            this.buttonEtutVer.Click += new System.EventHandler(this.buttonEtutVer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.IndianRed;
            this.label6.Location = new System.Drawing.Point(58, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Öğrenci:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(11, 257);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(820, 233);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(814, 208);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxDersAdi);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.buttonDersEkle);
            this.groupBox4.Location = new System.Drawing.Point(359, 191);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(326, 63);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            // 
            // textBoxDersAdi
            // 
            this.textBoxDersAdi.Location = new System.Drawing.Point(90, 22);
            this.textBoxDersAdi.Name = "textBoxDersAdi";
            this.textBoxDersAdi.Size = new System.Drawing.Size(112, 26);
            this.textBoxDersAdi.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.IndianRed;
            this.label12.Location = new System.Drawing.Point(6, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 21);
            this.label12.TabIndex = 11;
            this.label12.Text = "Ders Adı:";
            // 
            // buttonDersEkle
            // 
            this.buttonDersEkle.BackColor = System.Drawing.Color.Pink;
            this.buttonDersEkle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDersEkle.Location = new System.Drawing.Point(208, 22);
            this.buttonDersEkle.Name = "buttonDersEkle";
            this.buttonDersEkle.Size = new System.Drawing.Size(95, 26);
            this.buttonDersEkle.TabIndex = 10;
            this.buttonDersEkle.Text = "Ders Ekle";
            this.buttonDersEkle.UseVisualStyleBackColor = false;
            this.buttonDersEkle.Click += new System.EventHandler(this.buttonDersEkle_Click);
            // 
            // buttonFotografYukle
            // 
            this.buttonFotografYukle.BackColor = System.Drawing.Color.Pink;
            this.buttonFotografYukle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFotografYukle.Location = new System.Drawing.Point(20, 195);
            this.buttonFotografYukle.Name = "buttonFotografYukle";
            this.buttonFotografYukle.Size = new System.Drawing.Size(176, 32);
            this.buttonFotografYukle.TabIndex = 9;
            this.buttonFotografYukle.Text = "Fotoğraf Yükle";
            this.buttonFotografYukle.UseVisualStyleBackColor = false;
            this.buttonFotografYukle.Click += new System.EventHandler(this.buttonFotografYukle_Click);
            // 
            // buttonOgrenciEkle
            // 
            this.buttonOgrenciEkle.BackColor = System.Drawing.Color.Pink;
            this.buttonOgrenciEkle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOgrenciEkle.Location = new System.Drawing.Point(53, 195);
            this.buttonOgrenciEkle.Name = "buttonOgrenciEkle";
            this.buttonOgrenciEkle.Size = new System.Drawing.Size(165, 32);
            this.buttonOgrenciEkle.TabIndex = 8;
            this.buttonOgrenciEkle.Text = "Öğrenciyi Ekle";
            this.buttonOgrenciEkle.UseVisualStyleBackColor = false;
            this.buttonOgrenciEkle.Click += new System.EventHandler(this.buttonOgrenciEkle_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.maskedTextBoxOgrenciTelefon);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.textBoxOgrenciMail);
            this.groupBox5.Controls.Add(this.buttonOgrenciEkle);
            this.groupBox5.Controls.Add(this.textBoxOgrenciSinif);
            this.groupBox5.Controls.Add(this.textBoxOgrenciSoyad);
            this.groupBox5.Controls.Add(this.textBoxOgrenciAd);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(690, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(311, 242);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.IndianRed;
            this.label11.Location = new System.Drawing.Point(6, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 21);
            this.label11.TabIndex = 11;
            this.label11.Text = "Öğrenci Mail:";
            // 
            // textBoxOgrenciMail
            // 
            this.textBoxOgrenciMail.Location = new System.Drawing.Point(156, 150);
            this.textBoxOgrenciMail.Name = "textBoxOgrenciMail";
            this.textBoxOgrenciMail.Size = new System.Drawing.Size(149, 26);
            this.textBoxOgrenciMail.TabIndex = 10;
            // 
            // textBoxOgrenciSinif
            // 
            this.textBoxOgrenciSinif.Location = new System.Drawing.Point(156, 86);
            this.textBoxOgrenciSinif.Name = "textBoxOgrenciSinif";
            this.textBoxOgrenciSinif.Size = new System.Drawing.Size(149, 26);
            this.textBoxOgrenciSinif.TabIndex = 9;
            // 
            // textBoxOgrenciSoyad
            // 
            this.textBoxOgrenciSoyad.Location = new System.Drawing.Point(156, 54);
            this.textBoxOgrenciSoyad.Name = "textBoxOgrenciSoyad";
            this.textBoxOgrenciSoyad.Size = new System.Drawing.Size(149, 26);
            this.textBoxOgrenciSoyad.TabIndex = 7;
            // 
            // textBoxOgrenciAd
            // 
            this.textBoxOgrenciAd.Location = new System.Drawing.Point(156, 22);
            this.textBoxOgrenciAd.Name = "textBoxOgrenciAd";
            this.textBoxOgrenciAd.Size = new System.Drawing.Size(149, 26);
            this.textBoxOgrenciAd.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.IndianRed;
            this.label10.Location = new System.Drawing.Point(6, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 21);
            this.label10.TabIndex = 5;
            this.label10.Text = "Öğrenci Telefon:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.IndianRed;
            this.label9.Location = new System.Drawing.Point(6, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 21);
            this.label9.TabIndex = 4;
            this.label9.Text = "Öğrenci Sınıf:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.IndianRed;
            this.label8.Location = new System.Drawing.Point(6, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "Öğrenci Soyad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.IndianRed;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Öğrenci Ad:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pictureBoxFotograf);
            this.groupBox6.Controls.Add(this.buttonFotografYukle);
            this.groupBox6.Location = new System.Drawing.Point(1007, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(213, 242);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            // 
            // pictureBoxFotograf
            // 
            this.pictureBoxFotograf.Location = new System.Drawing.Point(3, 13);
            this.pictureBoxFotograf.Name = "pictureBoxFotograf";
            this.pictureBoxFotograf.Size = new System.Drawing.Size(204, 158);
            this.pictureBoxFotograf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFotograf.TabIndex = 10;
            this.pictureBoxFotograf.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.comboBoxOgretmenDers);
            this.groupBox7.Controls.Add(this.buttonOgretmenEkle);
            this.groupBox7.Controls.Add(this.textBoxOgretmenSoyad);
            this.groupBox7.Controls.Add(this.textBoxOgretmenAd);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Location = new System.Drawing.Point(834, 257);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(386, 233);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            // 
            // buttonOgretmenEkle
            // 
            this.buttonOgretmenEkle.BackColor = System.Drawing.Color.Pink;
            this.buttonOgretmenEkle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOgretmenEkle.Location = new System.Drawing.Point(154, 135);
            this.buttonOgretmenEkle.Name = "buttonOgretmenEkle";
            this.buttonOgretmenEkle.Size = new System.Drawing.Size(157, 32);
            this.buttonOgretmenEkle.TabIndex = 16;
            this.buttonOgretmenEkle.Text = "Öğretmeni Ekle;";
            this.buttonOgretmenEkle.UseVisualStyleBackColor = false;
            this.buttonOgretmenEkle.Click += new System.EventHandler(this.buttonOgretmenEkle_Click);
            // 
            // textBoxOgretmenSoyad
            // 
            this.textBoxOgretmenSoyad.Location = new System.Drawing.Point(154, 54);
            this.textBoxOgretmenSoyad.Name = "textBoxOgretmenSoyad";
            this.textBoxOgretmenSoyad.Size = new System.Drawing.Size(157, 26);
            this.textBoxOgretmenSoyad.TabIndex = 14;
            // 
            // textBoxOgretmenAd
            // 
            this.textBoxOgretmenAd.Location = new System.Drawing.Point(154, 22);
            this.textBoxOgretmenAd.Name = "textBoxOgretmenAd";
            this.textBoxOgretmenAd.Size = new System.Drawing.Size(157, 26);
            this.textBoxOgretmenAd.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.IndianRed;
            this.label13.Location = new System.Drawing.Point(100, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 21);
            this.label13.TabIndex = 12;
            this.label13.Text = "Ders:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.IndianRed;
            this.label14.Location = new System.Drawing.Point(6, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 21);
            this.label14.TabIndex = 11;
            this.label14.Text = "Öğretmen Soyad:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.IndianRed;
            this.label15.Location = new System.Drawing.Point(32, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 21);
            this.label15.TabIndex = 10;
            this.label15.Text = "Öğretmen Ad:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // maskedTextBoxOgrenciTelefon
            // 
            this.maskedTextBoxOgrenciTelefon.Location = new System.Drawing.Point(156, 118);
            this.maskedTextBoxOgrenciTelefon.Mask = "(999) 000-0000";
            this.maskedTextBoxOgrenciTelefon.Name = "maskedTextBoxOgrenciTelefon";
            this.maskedTextBoxOgrenciTelefon.Size = new System.Drawing.Size(149, 26);
            this.maskedTextBoxOgrenciTelefon.TabIndex = 12;
            // 
            // comboBoxOgretmenDers
            // 
            this.comboBoxOgretmenDers.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOgretmenDers.FormattingEnabled = true;
            this.comboBoxOgretmenDers.Location = new System.Drawing.Point(154, 86);
            this.comboBoxOgretmenDers.Name = "comboBoxOgretmenDers";
            this.comboBoxOgretmenDers.Size = new System.Drawing.Size(157, 27);
            this.comboBoxOgretmenDers.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1295, 501);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotograf)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonEtutOlustur;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSaat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxOgretmen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonEtutVer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxEtutID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxOgrenciID;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonDersEkle;
        private System.Windows.Forms.Button buttonFotografYukle;
        private System.Windows.Forms.Button buttonOgrenciEkle;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBoxDersAdi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxOgrenciMail;
        private System.Windows.Forms.TextBox textBoxOgrenciSinif;
        private System.Windows.Forms.TextBox textBoxOgrenciSoyad;
        private System.Windows.Forms.TextBox textBoxOgrenciAd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBoxFotograf;
        private System.Windows.Forms.Button buttonOgretmenEkle;
        private System.Windows.Forms.TextBox textBoxOgretmenSoyad;
        private System.Windows.Forms.TextBox textBoxOgretmenAd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxOgrenciTelefon;
        private System.Windows.Forms.ComboBox comboBoxOgretmenDers;
    }
}

