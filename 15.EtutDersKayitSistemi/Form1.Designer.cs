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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDers = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxTarih = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxOgretmen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBoxSaat = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonEtutOlustur = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxEtutDurumu = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelOgrenciAdi = new System.Windows.Forms.Label();
            this.labelOgrenciSoyadi = new System.Windows.Forms.Label();
            this.buttonEtutDetay = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonEtutDetay);
            this.groupBox2.Controls.Add(this.labelOgrenciSoyadi);
            this.groupBox2.Controls.Add(this.labelOgrenciAdi);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.checkBoxEtutDurumu);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(359, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 242);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.IndianRed;
            this.label5.Location = new System.Drawing.Point(72, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Öğrenci Adı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.IndianRed;
            this.label6.Location = new System.Drawing.Point(45, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Öğrenci Soyadı:";
            // 
            // checkBoxEtutDurumu
            // 
            this.checkBoxEtutDurumu.AutoSize = true;
            this.checkBoxEtutDurumu.Location = new System.Drawing.Point(187, 129);
            this.checkBoxEtutDurumu.Name = "checkBoxEtutDurumu";
            this.checkBoxEtutDurumu.Size = new System.Drawing.Size(66, 20);
            this.checkBoxEtutDurumu.TabIndex = 6;
            this.checkBoxEtutDurumu.Text = "iptal";
            this.checkBoxEtutDurumu.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.IndianRed;
            this.label7.Location = new System.Drawing.Point(66, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Etüt Durumu:";
            // 
            // labelOgrenciAdi
            // 
            this.labelOgrenciAdi.AutoSize = true;
            this.labelOgrenciAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOgrenciAdi.ForeColor = System.Drawing.Color.IndianRed;
            this.labelOgrenciAdi.Location = new System.Drawing.Point(187, 38);
            this.labelOgrenciAdi.Name = "labelOgrenciAdi";
            this.labelOgrenciAdi.Size = new System.Drawing.Size(43, 21);
            this.labelOgrenciAdi.TabIndex = 6;
            this.labelOgrenciAdi.Text = "Null";
            // 
            // labelOgrenciSoyadi
            // 
            this.labelOgrenciSoyadi.AutoSize = true;
            this.labelOgrenciSoyadi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOgrenciSoyadi.ForeColor = System.Drawing.Color.IndianRed;
            this.labelOgrenciSoyadi.Location = new System.Drawing.Point(187, 86);
            this.labelOgrenciSoyadi.Name = "labelOgrenciSoyadi";
            this.labelOgrenciSoyadi.Size = new System.Drawing.Size(43, 21);
            this.labelOgrenciSoyadi.TabIndex = 7;
            this.labelOgrenciSoyadi.Text = "Null";
            // 
            // buttonEtutDetay
            // 
            this.buttonEtutDetay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEtutDetay.Location = new System.Drawing.Point(55, 170);
            this.buttonEtutDetay.Name = "buttonEtutDetay";
            this.buttonEtutDetay.Size = new System.Drawing.Size(213, 46);
            this.buttonEtutDetay.TabIndex = 7;
            this.buttonEtutDetay.Text = "Etüt Detay";
            this.buttonEtutDetay.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(11, 269);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(671, 299);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(665, 274);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(695, 580);
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
        private System.Windows.Forms.Button buttonEtutDetay;
        private System.Windows.Forms.Label labelOgrenciSoyadi;
        private System.Windows.Forms.Label labelOgrenciAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxEtutDurumu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

