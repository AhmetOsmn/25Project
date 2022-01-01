namespace _14.BankamatikSimulasyonu
{
    partial class Form2
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
            this.labelAdSoyad = new System.Windows.Forms.Label();
            this.labelHesapNo = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelTCKimlik = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonGonder = new System.Windows.Forms.Button();
            this.textBoxTutar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBoxHesapNo = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelBakiye = new System.Windows.Forms.Label();
            this.buttonHareketlerim = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hesap No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "TC Kimlik:";
            // 
            // labelAdSoyad
            // 
            this.labelAdSoyad.AutoSize = true;
            this.labelAdSoyad.Location = new System.Drawing.Point(98, 37);
            this.labelAdSoyad.Name = "labelAdSoyad";
            this.labelAdSoyad.Size = new System.Drawing.Size(37, 18);
            this.labelAdSoyad.TabIndex = 4;
            this.labelAdSoyad.Text = "Null";
            // 
            // labelHesapNo
            // 
            this.labelHesapNo.AutoSize = true;
            this.labelHesapNo.Location = new System.Drawing.Point(98, 90);
            this.labelHesapNo.Name = "labelHesapNo";
            this.labelHesapNo.Size = new System.Drawing.Size(37, 18);
            this.labelHesapNo.TabIndex = 5;
            this.labelHesapNo.Text = "Null";
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Location = new System.Drawing.Point(98, 140);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(37, 18);
            this.labelTelefon.TabIndex = 6;
            this.labelTelefon.Text = "Null";
            // 
            // labelTCKimlik
            // 
            this.labelTCKimlik.AutoSize = true;
            this.labelTCKimlik.Location = new System.Drawing.Point(98, 186);
            this.labelTCKimlik.Name = "labelTCKimlik";
            this.labelTCKimlik.Size = new System.Drawing.Size(37, 18);
            this.labelTCKimlik.TabIndex = 7;
            this.labelTCKimlik.Text = "Null";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonHareketlerim);
            this.groupBox1.Controls.Add(this.buttonGonder);
            this.groupBox1.Controls.Add(this.textBoxTutar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.maskedTextBoxHesapNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(11, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 215);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Havale";
            // 
            // buttonGonder
            // 
            this.buttonGonder.Location = new System.Drawing.Point(93, 136);
            this.buttonGonder.Name = "buttonGonder";
            this.buttonGonder.Size = new System.Drawing.Size(106, 34);
            this.buttonGonder.TabIndex = 6;
            this.buttonGonder.Text = "Gönder";
            this.buttonGonder.UseVisualStyleBackColor = true;
            this.buttonGonder.Click += new System.EventHandler(this.buttonGonder_Click);
            // 
            // textBoxTutar
            // 
            this.textBoxTutar.Location = new System.Drawing.Point(93, 87);
            this.textBoxTutar.Name = "textBoxTutar";
            this.textBoxTutar.Size = new System.Drawing.Size(106, 26);
            this.textBoxTutar.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tutar:";
            // 
            // maskedTextBoxHesapNo
            // 
            this.maskedTextBoxHesapNo.Location = new System.Drawing.Point(93, 37);
            this.maskedTextBoxHesapNo.Mask = "000000";
            this.maskedTextBoxHesapNo.Name = "maskedTextBoxHesapNo";
            this.maskedTextBoxHesapNo.Size = new System.Drawing.Size(71, 26);
            this.maskedTextBoxHesapNo.TabIndex = 3;
            this.maskedTextBoxHesapNo.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hesap No:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Bakiye:";
            // 
            // labelBakiye
            // 
            this.labelBakiye.AutoSize = true;
            this.labelBakiye.Location = new System.Drawing.Point(98, 225);
            this.labelBakiye.Name = "labelBakiye";
            this.labelBakiye.Size = new System.Drawing.Size(15, 18);
            this.labelBakiye.TabIndex = 8;
            this.labelBakiye.Text = "-";
            // 
            // buttonHareketlerim
            // 
            this.buttonHareketlerim.Location = new System.Drawing.Point(234, 136);
            this.buttonHareketlerim.Name = "buttonHareketlerim";
            this.buttonHareketlerim.Size = new System.Drawing.Size(173, 34);
            this.buttonHareketlerim.TabIndex = 9;
            this.buttonHareketlerim.Text = "Hareketlerim";
            this.buttonHareketlerim.UseVisualStyleBackColor = true;
            this.buttonHareketlerim.Click += new System.EventHandler(this.buttonHareketlerim_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(527, 555);
            this.Controls.Add(this.labelBakiye);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelTCKimlik);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.labelHesapNo);
            this.Controls.Add(this.labelAdSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelAdSoyad;
        private System.Windows.Forms.Label labelHesapNo;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.Label labelTCKimlik;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHesapNo;
        private System.Windows.Forms.Button buttonGonder;
        private System.Windows.Forms.TextBox textBoxTutar;
        private System.Windows.Forms.Label labelBakiye;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonHareketlerim;
    }
}