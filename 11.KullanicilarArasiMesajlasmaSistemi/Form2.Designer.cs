namespace _11.KullanicilarArasiMesajlasmaSistemi
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
            this.labelNumara = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAdSoyad = new System.Windows.Forms.Label();
            this.dataGridViewGelen = new System.Windows.Forms.DataGridView();
            this.groupBoxGelen = new System.Windows.Forms.GroupBox();
            this.groupBoxGiden = new System.Windows.Forms.GroupBox();
            this.dataGridViewGiden = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGelen)).BeginInit();
            this.groupBoxGelen.SuspendLayout();
            this.groupBoxGiden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGiden)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numara:";
            // 
            // labelNumara
            // 
            this.labelNumara.AutoSize = true;
            this.labelNumara.Location = new System.Drawing.Point(98, 55);
            this.labelNumara.Name = "labelNumara";
            this.labelNumara.Size = new System.Drawing.Size(48, 18);
            this.labelNumara.TabIndex = 1;
            this.labelNumara.Text = "0000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad Soyad:";
            // 
            // labelAdSoyad
            // 
            this.labelAdSoyad.AutoSize = true;
            this.labelAdSoyad.Location = new System.Drawing.Point(318, 55);
            this.labelAdSoyad.Name = "labelAdSoyad";
            this.labelAdSoyad.Size = new System.Drawing.Size(70, 18);
            this.labelAdSoyad.TabIndex = 3;
            this.labelAdSoyad.Text = "Null Null";
            // 
            // dataGridViewGelen
            // 
            this.dataGridViewGelen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGelen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewGelen.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewGelen.Name = "dataGridViewGelen";
            this.dataGridViewGelen.Size = new System.Drawing.Size(455, 224);
            this.dataGridViewGelen.TabIndex = 4;
            // 
            // groupBoxGelen
            // 
            this.groupBoxGelen.Controls.Add(this.dataGridViewGelen);
            this.groupBoxGelen.Location = new System.Drawing.Point(24, 105);
            this.groupBoxGelen.Name = "groupBoxGelen";
            this.groupBoxGelen.Size = new System.Drawing.Size(461, 249);
            this.groupBoxGelen.TabIndex = 6;
            this.groupBoxGelen.TabStop = false;
            this.groupBoxGelen.Text = "Gelen Mesajlar";
            // 
            // groupBoxGiden
            // 
            this.groupBoxGiden.Controls.Add(this.dataGridViewGiden);
            this.groupBoxGiden.Location = new System.Drawing.Point(506, 105);
            this.groupBoxGiden.Name = "groupBoxGiden";
            this.groupBoxGiden.Size = new System.Drawing.Size(443, 249);
            this.groupBoxGiden.TabIndex = 7;
            this.groupBoxGiden.TabStop = false;
            this.groupBoxGiden.Text = "Giden Mesajlar";
            // 
            // dataGridViewGiden
            // 
            this.dataGridViewGiden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGiden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewGiden.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewGiden.Name = "dataGridViewGiden";
            this.dataGridViewGiden.Size = new System.Drawing.Size(437, 224);
            this.dataGridViewGiden.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(24, 360);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1019, 171);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mesaj Paneli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Alıcı:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(65, 42);
            this.maskedTextBox1.Mask = "0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(199, 26);
            this.maskedTextBox1.TabIndex = 10;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 26);
            this.textBox1.TabIndex = 11;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(398, 45);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(615, 105);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 32);
            this.button1.TabIndex = 13;
            this.button1.Text = "Gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Başlık:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Mesaj:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1055, 543);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxGiden);
            this.Controls.Add(this.groupBoxGelen);
            this.Controls.Add(this.labelAdSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelNumara);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "MesajTes";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGelen)).EndInit();
            this.groupBoxGelen.ResumeLayout(false);
            this.groupBoxGiden.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGiden)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNumara;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAdSoyad;
        private System.Windows.Forms.DataGridView dataGridViewGelen;
        private System.Windows.Forms.GroupBox groupBoxGelen;
        private System.Windows.Forms.GroupBox groupBoxGiden;
        private System.Windows.Forms.DataGridView dataGridViewGiden;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label2;
    }
}