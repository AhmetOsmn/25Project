
namespace NotKayitSistemi
{
    partial class FormOgretmenDetay
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonOgrenciEkle = new System.Windows.Forms.Button();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBoxNumara = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.textBoxSinav2 = new System.Windows.Forms.TextBox();
            this.textBoxSinav1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelKalanSayisi = new System.Windows.Forms.Label();
            this.labelGecenSayisi = new System.Windows.Forms.Label();
            this.labelOrtalama = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrenciIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciNumaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciSinav1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciSinav2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ortalamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblDersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbNotKayitDataSet = new NotKayitSistemi.DbNotKayitDataSet();
            this.tblDersTableAdapter = new NotKayitSistemi.DbNotKayitDataSetTableAdapters.TblDersTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonOgrenciEkle);
            this.groupBox1.Controls.Add(this.textBoxSoyad);
            this.groupBox1.Controls.Add(this.textBoxAd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.maskedTextBoxNumara);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ogrenci Ekle";
            // 
            // buttonOgrenciEkle
            // 
            this.buttonOgrenciEkle.Location = new System.Drawing.Point(86, 142);
            this.buttonOgrenciEkle.Name = "buttonOgrenciEkle";
            this.buttonOgrenciEkle.Size = new System.Drawing.Size(141, 41);
            this.buttonOgrenciEkle.TabIndex = 3;
            this.buttonOgrenciEkle.Text = "Ogrenci Kaydet";
            this.buttonOgrenciEkle.UseVisualStyleBackColor = true;
            this.buttonOgrenciEkle.Click += new System.EventHandler(this.buttonOgrenciEkle_Click);
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Location = new System.Drawing.Point(86, 110);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(141, 26);
            this.textBoxSoyad.TabIndex = 2;
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(86, 78);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(141, 26);
            this.textBoxAd.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyad:";
            // 
            // maskedTextBoxNumara
            // 
            this.maskedTextBoxNumara.Location = new System.Drawing.Point(86, 46);
            this.maskedTextBoxNumara.Mask = "0000";
            this.maskedTextBoxNumara.Name = "maskedTextBoxNumara";
            this.maskedTextBoxNumara.Size = new System.Drawing.Size(52, 26);
            this.maskedTextBoxNumara.TabIndex = 1;
            this.maskedTextBoxNumara.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numara:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonGuncelle);
            this.groupBox2.Controls.Add(this.textBoxSinav2);
            this.groupBox2.Controls.Add(this.textBoxSinav1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.labelOrtalama);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(321, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 194);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sinav Notlari";
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Location = new System.Drawing.Point(86, 142);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(124, 41);
            this.buttonGuncelle.TabIndex = 3;
            this.buttonGuncelle.Text = "Guncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // textBoxSinav2
            // 
            this.textBoxSinav2.Location = new System.Drawing.Point(86, 78);
            this.textBoxSinav2.Name = "textBoxSinav2";
            this.textBoxSinav2.Size = new System.Drawing.Size(124, 26);
            this.textBoxSinav2.TabIndex = 2;
            // 
            // textBoxSinav1
            // 
            this.textBoxSinav1.Location = new System.Drawing.Point(86, 46);
            this.textBoxSinav1.Name = "textBoxSinav1";
            this.textBoxSinav1.Size = new System.Drawing.Size(124, 26);
            this.textBoxSinav1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sinav 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sinav 1:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.labelKalanSayisi);
            this.groupBox3.Controls.Add(this.labelGecenSayisi);
            this.groupBox3.Location = new System.Drawing.Point(624, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(216, 194);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sinif İstatikleri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Gecen Sayisi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Kalan Sayisi:";
            // 
            // labelKalanSayisi
            // 
            this.labelKalanSayisi.AutoSize = true;
            this.labelKalanSayisi.Location = new System.Drawing.Point(129, 86);
            this.labelKalanSayisi.Name = "labelKalanSayisi";
            this.labelKalanSayisi.Size = new System.Drawing.Size(28, 18);
            this.labelKalanSayisi.TabIndex = 0;
            this.labelKalanSayisi.Text = "00";
            // 
            // labelGecenSayisi
            // 
            this.labelGecenSayisi.AutoSize = true;
            this.labelGecenSayisi.Location = new System.Drawing.Point(129, 54);
            this.labelGecenSayisi.Name = "labelGecenSayisi";
            this.labelGecenSayisi.Size = new System.Drawing.Size(28, 18);
            this.labelGecenSayisi.TabIndex = 0;
            this.labelGecenSayisi.Text = "00";
            // 
            // labelOrtalama
            // 
            this.labelOrtalama.AutoSize = true;
            this.labelOrtalama.Location = new System.Drawing.Point(95, 118);
            this.labelOrtalama.Name = "labelOrtalama";
            this.labelOrtalama.Size = new System.Drawing.Size(28, 18);
            this.labelOrtalama.TabIndex = 0;
            this.labelOrtalama.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ortalama:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(12, 212);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1023, 404);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sinav Notlari";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrenciIdDataGridViewTextBoxColumn,
            this.ogrenciNumaraDataGridViewTextBoxColumn,
            this.ogrenciAdDataGridViewTextBoxColumn,
            this.ogrenciSoyadDataGridViewTextBoxColumn,
            this.ogrenciSinav1DataGridViewTextBoxColumn,
            this.ogrenciSinav2DataGridViewTextBoxColumn,
            this.ortalamaDataGridViewTextBoxColumn,
            this.durumDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tblDersBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1017, 379);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ogrenciIdDataGridViewTextBoxColumn
            // 
            this.ogrenciIdDataGridViewTextBoxColumn.DataPropertyName = "OgrenciId";
            this.ogrenciIdDataGridViewTextBoxColumn.HeaderText = "OgrenciId";
            this.ogrenciIdDataGridViewTextBoxColumn.Name = "ogrenciIdDataGridViewTextBoxColumn";
            this.ogrenciIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrenciNumaraDataGridViewTextBoxColumn
            // 
            this.ogrenciNumaraDataGridViewTextBoxColumn.DataPropertyName = "OgrenciNumara";
            this.ogrenciNumaraDataGridViewTextBoxColumn.HeaderText = "OgrenciNumara";
            this.ogrenciNumaraDataGridViewTextBoxColumn.Name = "ogrenciNumaraDataGridViewTextBoxColumn";
            // 
            // ogrenciAdDataGridViewTextBoxColumn
            // 
            this.ogrenciAdDataGridViewTextBoxColumn.DataPropertyName = "OgrenciAd";
            this.ogrenciAdDataGridViewTextBoxColumn.HeaderText = "OgrenciAd";
            this.ogrenciAdDataGridViewTextBoxColumn.Name = "ogrenciAdDataGridViewTextBoxColumn";
            // 
            // ogrenciSoyadDataGridViewTextBoxColumn
            // 
            this.ogrenciSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrenciSoyad";
            this.ogrenciSoyadDataGridViewTextBoxColumn.HeaderText = "OgrenciSoyad";
            this.ogrenciSoyadDataGridViewTextBoxColumn.Name = "ogrenciSoyadDataGridViewTextBoxColumn";
            // 
            // ogrenciSinav1DataGridViewTextBoxColumn
            // 
            this.ogrenciSinav1DataGridViewTextBoxColumn.DataPropertyName = "OgrenciSinav1";
            this.ogrenciSinav1DataGridViewTextBoxColumn.HeaderText = "OgrenciSinav1";
            this.ogrenciSinav1DataGridViewTextBoxColumn.Name = "ogrenciSinav1DataGridViewTextBoxColumn";
            // 
            // ogrenciSinav2DataGridViewTextBoxColumn
            // 
            this.ogrenciSinav2DataGridViewTextBoxColumn.DataPropertyName = "OgrenciSinav2";
            this.ogrenciSinav2DataGridViewTextBoxColumn.HeaderText = "OgrenciSinav2";
            this.ogrenciSinav2DataGridViewTextBoxColumn.Name = "ogrenciSinav2DataGridViewTextBoxColumn";
            // 
            // ortalamaDataGridViewTextBoxColumn
            // 
            this.ortalamaDataGridViewTextBoxColumn.DataPropertyName = "Ortalama";
            this.ortalamaDataGridViewTextBoxColumn.HeaderText = "Ortalama";
            this.ortalamaDataGridViewTextBoxColumn.Name = "ortalamaDataGridViewTextBoxColumn";
            // 
            // durumDataGridViewCheckBoxColumn
            // 
            this.durumDataGridViewCheckBoxColumn.DataPropertyName = "Durum";
            this.durumDataGridViewCheckBoxColumn.HeaderText = "Durum";
            this.durumDataGridViewCheckBoxColumn.Name = "durumDataGridViewCheckBoxColumn";
            // 
            // tblDersBindingSource
            // 
            this.tblDersBindingSource.DataMember = "TblDers";
            this.tblDersBindingSource.DataSource = this.dbNotKayitDataSet;
            // 
            // dbNotKayitDataSet
            // 
            this.dbNotKayitDataSet.DataSetName = "DbNotKayitDataSet";
            this.dbNotKayitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDersTableAdapter
            // 
            this.tblDersTableAdapter.ClearBeforeFill = true;
            // 
            // FormOgretmenDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1051, 628);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormOgretmenDetay";
            this.Text = "FormOgretmenDetay";
            this.Load += new System.EventHandler(this.FormOgretmenDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonOgrenciEkle;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.TextBox textBoxSinav2;
        private System.Windows.Forms.TextBox textBoxSinav1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelKalanSayisi;
        private System.Windows.Forms.Label labelGecenSayisi;
        private System.Windows.Forms.Label labelOrtalama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DbNotKayitDataSet dbNotKayitDataSet;
        private System.Windows.Forms.BindingSource tblDersBindingSource;
        private DbNotKayitDataSetTableAdapters.TblDersTableAdapter tblDersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciNumaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciSinav1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciSinav2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ortalamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn durumDataGridViewCheckBoxColumn;
    }
}