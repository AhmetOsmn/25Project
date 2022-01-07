namespace _19.ResimUzerineYaziYazmak
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
            this.buttonRenkSec = new System.Windows.Forms.Button();
            this.buttonResimSec = new System.Windows.Forms.Button();
            this.buttonYazdir = new System.Windows.Forms.Button();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMetin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBoyut = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRenkSec
            // 
            this.buttonRenkSec.Location = new System.Drawing.Point(70, 72);
            this.buttonRenkSec.Name = "buttonRenkSec";
            this.buttonRenkSec.Size = new System.Drawing.Size(152, 54);
            this.buttonRenkSec.TabIndex = 2;
            this.buttonRenkSec.Text = "Renk Seç";
            this.buttonRenkSec.UseVisualStyleBackColor = true;
            this.buttonRenkSec.Click += new System.EventHandler(this.buttonRenkSec_Click);
            // 
            // buttonResimSec
            // 
            this.buttonResimSec.Location = new System.Drawing.Point(70, 12);
            this.buttonResimSec.Name = "buttonResimSec";
            this.buttonResimSec.Size = new System.Drawing.Size(152, 54);
            this.buttonResimSec.TabIndex = 1;
            this.buttonResimSec.Text = "Resim Seç";
            this.buttonResimSec.UseVisualStyleBackColor = true;
            this.buttonResimSec.Click += new System.EventHandler(this.buttonResimSec_Click);
            // 
            // buttonYazdir
            // 
            this.buttonYazdir.Location = new System.Drawing.Point(70, 132);
            this.buttonYazdir.Name = "buttonYazdir";
            this.buttonYazdir.Size = new System.Drawing.Size(152, 54);
            this.buttonYazdir.TabIndex = 3;
            this.buttonYazdir.Text = "Yazdır";
            this.buttonYazdir.UseVisualStyleBackColor = true;
            this.buttonYazdir.Click += new System.EventHandler(this.buttonYazdir_Click);
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(70, 192);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(152, 54);
            this.buttonKaydet.TabIndex = 4;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Metin:";
            // 
            // textBoxMetin
            // 
            this.textBoxMetin.Location = new System.Drawing.Point(70, 262);
            this.textBoxMetin.Name = "textBoxMetin";
            this.textBoxMetin.Size = new System.Drawing.Size(148, 26);
            this.textBoxMetin.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Boyut:";
            // 
            // textBoxBoyut
            // 
            this.textBoxBoyut.Location = new System.Drawing.Point(70, 292);
            this.textBoxBoyut.Name = "textBoxBoyut";
            this.textBoxBoyut.Size = new System.Drawing.Size(148, 26);
            this.textBoxBoyut.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(258, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(540, 306);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 531);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxBoyut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMetin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.buttonYazdir);
            this.Controls.Add(this.buttonResimSec);
            this.Controls.Add(this.buttonRenkSec);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRenkSec;
        private System.Windows.Forms.Button buttonResimSec;
        private System.Windows.Forms.Button buttonYazdir;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMetin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBoyut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

