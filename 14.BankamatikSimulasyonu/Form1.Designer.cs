namespace _14.BankamatikSimulasyonu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBoxHesapNo = new System.Windows.Forms.MaskedTextBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.buttonGirisYap = new System.Windows.Forms.Button();
            this.linkLabelKayitOl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hesap No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // maskedTextBoxHesapNo
            // 
            this.maskedTextBoxHesapNo.Location = new System.Drawing.Point(107, 27);
            this.maskedTextBoxHesapNo.Mask = "000000";
            this.maskedTextBoxHesapNo.Name = "maskedTextBoxHesapNo";
            this.maskedTextBoxHesapNo.Size = new System.Drawing.Size(71, 26);
            this.maskedTextBoxHesapNo.TabIndex = 1;
            this.maskedTextBoxHesapNo.ValidatingType = typeof(int);
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(107, 70);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(153, 26);
            this.textBoxSifre.TabIndex = 2;
            this.textBoxSifre.UseSystemPasswordChar = true;
            // 
            // buttonGirisYap
            // 
            this.buttonGirisYap.Location = new System.Drawing.Point(107, 118);
            this.buttonGirisYap.Name = "buttonGirisYap";
            this.buttonGirisYap.Size = new System.Drawing.Size(153, 29);
            this.buttonGirisYap.TabIndex = 3;
            this.buttonGirisYap.Text = "Giriş Yap";
            this.buttonGirisYap.UseVisualStyleBackColor = true;
            this.buttonGirisYap.Click += new System.EventHandler(this.buttonGirisYap_Click);
            // 
            // linkLabelKayitOl
            // 
            this.linkLabelKayitOl.AutoSize = true;
            this.linkLabelKayitOl.Location = new System.Drawing.Point(152, 162);
            this.linkLabelKayitOl.Name = "linkLabelKayitOl";
            this.linkLabelKayitOl.Size = new System.Drawing.Size(66, 18);
            this.linkLabelKayitOl.TabIndex = 4;
            this.linkLabelKayitOl.TabStop = true;
            this.linkLabelKayitOl.Text = "Kayıt Ol";
            this.linkLabelKayitOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelKayitOl_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(333, 226);
            this.Controls.Add(this.linkLabelKayitOl);
            this.Controls.Add(this.buttonGirisYap);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.maskedTextBoxHesapNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHesapNo;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.Button buttonGirisYap;
        private System.Windows.Forms.LinkLabel linkLabelKayitOl;
    }
}

