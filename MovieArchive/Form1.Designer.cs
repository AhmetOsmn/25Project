
namespace MovieArchive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFilmAdi = new System.Windows.Forms.TextBox();
            this.textBoxKategori = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonTamEkran = new System.Windows.Forms.Button();
            this.buttonHakkımızda = new System.Windows.Forms.Button();
            this.buttonRenkDegistir = new System.Windows.Forms.Button();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 158);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(911, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(254, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 477);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Film Listesi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.webBrowser1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(505, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(587, 477);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ekran";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 18);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(581, 456);
            this.webBrowser1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.buttonKaydet);
            this.groupBox3.Controls.Add(this.textBoxLink);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBoxKategori);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBoxFilmAdi);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(12, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 475);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yeni Film";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Film Ad:";
            // 
            // textBoxFilmAdi
            // 
            this.textBoxFilmAdi.Location = new System.Drawing.Point(81, 27);
            this.textBoxFilmAdi.Name = "textBoxFilmAdi";
            this.textBoxFilmAdi.Size = new System.Drawing.Size(149, 22);
            this.textBoxFilmAdi.TabIndex = 4;
            // 
            // textBoxKategori
            // 
            this.textBoxKategori.Location = new System.Drawing.Point(82, 53);
            this.textBoxKategori.Name = "textBoxKategori";
            this.textBoxKategori.Size = new System.Drawing.Size(148, 22);
            this.textBoxKategori.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kategori:";
            // 
            // textBoxLink
            // 
            this.textBoxLink.Location = new System.Drawing.Point(81, 79);
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(149, 22);
            this.textBoxLink.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(35, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Link:";
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(82, 105);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(145, 46);
            this.buttonKaydet.TabIndex = 9;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonCikis);
            this.groupBox4.Controls.Add(this.buttonRenkDegistir);
            this.groupBox4.Controls.Add(this.buttonHakkımızda);
            this.groupBox4.Controls.Add(this.buttonTamEkran);
            this.groupBox4.Location = new System.Drawing.Point(9, 269);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(221, 197);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "İşlemler";
            // 
            // buttonTamEkran
            // 
            this.buttonTamEkran.Location = new System.Drawing.Point(6, 19);
            this.buttonTamEkran.Name = "buttonTamEkran";
            this.buttonTamEkran.Size = new System.Drawing.Size(212, 38);
            this.buttonTamEkran.TabIndex = 10;
            this.buttonTamEkran.Text = "Tam Ekran";
            this.buttonTamEkran.UseVisualStyleBackColor = true;
            // 
            // buttonHakkımızda
            // 
            this.buttonHakkımızda.Location = new System.Drawing.Point(6, 63);
            this.buttonHakkımızda.Name = "buttonHakkımızda";
            this.buttonHakkımızda.Size = new System.Drawing.Size(212, 38);
            this.buttonHakkımızda.TabIndex = 11;
            this.buttonHakkımızda.Text = "Hakkımızda";
            this.buttonHakkımızda.UseVisualStyleBackColor = true;
            this.buttonHakkımızda.Click += new System.EventHandler(this.buttonHakkımızda_Click);
            // 
            // buttonRenkDegistir
            // 
            this.buttonRenkDegistir.Location = new System.Drawing.Point(6, 107);
            this.buttonRenkDegistir.Name = "buttonRenkDegistir";
            this.buttonRenkDegistir.Size = new System.Drawing.Size(212, 38);
            this.buttonRenkDegistir.TabIndex = 12;
            this.buttonRenkDegistir.Text = "Renk Değiştir";
            this.buttonRenkDegistir.UseVisualStyleBackColor = true;
            this.buttonRenkDegistir.Click += new System.EventHandler(this.buttonRenkDegistir_Click);
            // 
            // buttonCikis
            // 
            this.buttonCikis.Location = new System.Drawing.Point(6, 151);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(212, 38);
            this.buttonCikis.TabIndex = 13;
            this.buttonCikis.Text = "Çıkış";
            this.buttonCikis.UseVisualStyleBackColor = true;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(239, 456);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(18, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(863, 117);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sinema Koltuk Yazılım";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1097, 666);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.Button buttonRenkDegistir;
        private System.Windows.Forms.Button buttonHakkımızda;
        private System.Windows.Forms.Button buttonTamEkran;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.TextBox textBoxLink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxKategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFilmAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

