namespace _14.BankamatikSimulasyonu
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.maskedTextBoxTCKimlik = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTelefon = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxHesapNo = new System.Windows.Forms.MaskedTextBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.buttonHesapNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC Kimlik:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hesap No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Şifre:";
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(103, 25);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(147, 26);
            this.textBoxAd.TabIndex = 1;
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Location = new System.Drawing.Point(103, 57);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(147, 26);
            this.textBoxSoyad.TabIndex = 2;
            // 
            // maskedTextBoxTCKimlik
            // 
            this.maskedTextBoxTCKimlik.Location = new System.Drawing.Point(103, 89);
            this.maskedTextBoxTCKimlik.Mask = "00000000000";
            this.maskedTextBoxTCKimlik.Name = "maskedTextBoxTCKimlik";
            this.maskedTextBoxTCKimlik.Size = new System.Drawing.Size(147, 26);
            this.maskedTextBoxTCKimlik.TabIndex = 3;
            this.maskedTextBoxTCKimlik.ValidatingType = typeof(int);
            // 
            // maskedTextBoxTelefon
            // 
            this.maskedTextBoxTelefon.Location = new System.Drawing.Point(103, 121);
            this.maskedTextBoxTelefon.Mask = "(999) 000-0000";
            this.maskedTextBoxTelefon.Name = "maskedTextBoxTelefon";
            this.maskedTextBoxTelefon.Size = new System.Drawing.Size(147, 26);
            this.maskedTextBoxTelefon.TabIndex = 4;
            // 
            // maskedTextBoxHesapNo
            // 
            this.maskedTextBoxHesapNo.Enabled = false;
            this.maskedTextBoxHesapNo.Location = new System.Drawing.Point(103, 153);
            this.maskedTextBoxHesapNo.Mask = "000000";
            this.maskedTextBoxHesapNo.Name = "maskedTextBoxHesapNo";
            this.maskedTextBoxHesapNo.Size = new System.Drawing.Size(103, 26);
            this.maskedTextBoxHesapNo.TabIndex = 10;
            this.maskedTextBoxHesapNo.ValidatingType = typeof(int);
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(103, 185);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(147, 26);
            this.textBoxSifre.TabIndex = 6;
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(103, 217);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(147, 34);
            this.buttonKaydet.TabIndex = 7;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // buttonHesapNo
            // 
            this.buttonHesapNo.Location = new System.Drawing.Point(212, 151);
            this.buttonHesapNo.Name = "buttonHesapNo";
            this.buttonHesapNo.Size = new System.Drawing.Size(38, 29);
            this.buttonHesapNo.TabIndex = 5;
            this.buttonHesapNo.Text = "...";
            this.buttonHesapNo.UseVisualStyleBackColor = true;
            this.buttonHesapNo.Click += new System.EventHandler(this.buttonHesapNo_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(311, 294);
            this.Controls.Add(this.buttonHesapNo);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.maskedTextBoxHesapNo);
            this.Controls.Add(this.maskedTextBoxTelefon);
            this.Controls.Add(this.maskedTextBoxTCKimlik);
            this.Controls.Add(this.textBoxSoyad);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTCKimlik;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefon;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHesapNo;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Button buttonHesapNo;
    }
}