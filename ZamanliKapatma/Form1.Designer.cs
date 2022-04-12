namespace ZamanliKapatma
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
            this.nmrSaat = new System.Windows.Forms.NumericUpDown();
            this.nmrDakika = new System.Windows.Forms.NumericUpDown();
            this.nmrSaniye = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnZamanla = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSaat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDakika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSaniye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nmrSaat
            // 
            this.nmrSaat.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.nmrSaat.ForeColor = System.Drawing.SystemColors.Info;
            this.nmrSaat.Location = new System.Drawing.Point(147, 210);
            this.nmrSaat.Name = "nmrSaat";
            this.nmrSaat.Size = new System.Drawing.Size(66, 30);
            this.nmrSaat.TabIndex = 0;
            // 
            // nmrDakika
            // 
            this.nmrDakika.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.nmrDakika.ForeColor = System.Drawing.SystemColors.Info;
            this.nmrDakika.Location = new System.Drawing.Point(318, 210);
            this.nmrDakika.Name = "nmrDakika";
            this.nmrDakika.Size = new System.Drawing.Size(66, 30);
            this.nmrDakika.TabIndex = 0;
            // 
            // nmrSaniye
            // 
            this.nmrSaniye.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.nmrSaniye.ForeColor = System.Drawing.SystemColors.Info;
            this.nmrSaniye.Location = new System.Drawing.Point(487, 210);
            this.nmrSaniye.Name = "nmrSaniye";
            this.nmrSaniye.Size = new System.Drawing.Size(66, 30);
            this.nmrSaniye.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Saat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dakika:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Saniye:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(499, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnZamanla
            // 
            this.btnZamanla.Location = new System.Drawing.Point(87, 263);
            this.btnZamanla.Name = "btnZamanla";
            this.btnZamanla.Size = new System.Drawing.Size(206, 31);
            this.btnZamanla.TabIndex = 3;
            this.btnZamanla.Text = "Kapatmayı Zamanla";
            this.btnZamanla.UseVisualStyleBackColor = true;
            this.btnZamanla.Click += new System.EventHandler(this.btnZamanla_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tüm Zamanlayıcıları İptal Et";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(357, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kapatma Zamanlayıcısına Hoşgeldiniz...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(581, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Aşağıdan bilgisayarınızın ne kadar süre sonra kapanacağını seçin.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(657, 319);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnZamanla);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmrSaniye);
            this.Controls.Add(this.nmrDakika);
            this.Controls.Add(this.nmrSaat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Kapatmayı Zamanla";
            ((System.ComponentModel.ISupportInitialize)(this.nmrSaat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDakika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSaniye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmrSaat;
        private System.Windows.Forms.NumericUpDown nmrDakika;
        private System.Windows.Forms.NumericUpDown nmrSaniye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnZamanla;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

