
namespace KelimeOgren
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIngilizce = new System.Windows.Forms.TextBox();
            this.textBoxTurkce = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSüre = new System.Windows.Forms.Label();
            this.labelKelime = new System.Windows.Forms.Label();
            this.labelCevap = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "İngilizce:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(41, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Türkçe:";
            // 
            // textBoxIngilizce
            // 
            this.textBoxIngilizce.Location = new System.Drawing.Point(108, 48);
            this.textBoxIngilizce.Name = "textBoxIngilizce";
            this.textBoxIngilizce.Size = new System.Drawing.Size(198, 20);
            this.textBoxIngilizce.TabIndex = 10;
            // 
            // textBoxTurkce
            // 
            this.textBoxTurkce.Location = new System.Drawing.Point(108, 94);
            this.textBoxTurkce.Name = "textBoxTurkce";
            this.textBoxTurkce.Size = new System.Drawing.Size(198, 20);
            this.textBoxTurkce.TabIndex = 1;
            this.textBoxTurkce.TextChanged += new System.EventHandler(this.textBoxTurkce_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(502, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 13);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(398, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Süre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(385, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kelime:";
            // 
            // labelSüre
            // 
            this.labelSüre.AutoSize = true;
            this.labelSüre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSüre.Location = new System.Drawing.Point(451, 46);
            this.labelSüre.Name = "labelSüre";
            this.labelSüre.Size = new System.Drawing.Size(27, 20);
            this.labelSüre.TabIndex = 4;
            this.labelSüre.Text = "90";
            // 
            // labelKelime
            // 
            this.labelKelime.AutoSize = true;
            this.labelKelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKelime.Location = new System.Drawing.Point(460, 94);
            this.labelKelime.Name = "labelKelime";
            this.labelKelime.Size = new System.Drawing.Size(18, 20);
            this.labelKelime.TabIndex = 4;
            this.labelKelime.Text = "0";
            // 
            // labelCevap
            // 
            this.labelCevap.AutoSize = true;
            this.labelCevap.Location = new System.Drawing.Point(105, 145);
            this.labelCevap.Name = "labelCevap";
            this.labelCevap.Size = new System.Drawing.Size(35, 13);
            this.labelCevap.TabIndex = 5;
            this.labelCevap.Text = "label5";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 185);
            this.Controls.Add(this.labelCevap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelKelime);
            this.Controls.Add(this.labelSüre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxTurkce);
            this.Controls.Add(this.textBoxIngilizce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIngilizce;
        private System.Windows.Forms.TextBox textBoxTurkce;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSüre;
        private System.Windows.Forms.Label labelKelime;
        private System.Windows.Forms.Label labelCevap;
        private System.Windows.Forms.Timer timer1;
    }
}

