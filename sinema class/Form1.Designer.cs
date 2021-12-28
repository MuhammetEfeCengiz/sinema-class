
namespace sinema_class
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.KoltukSayısı_text = new System.Windows.Forms.TextBox();
            this.Oluştur_btn = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.BiletSat_btn = new System.Windows.Forms.Button();
            this.KoltukSorgula_lbl = new System.Windows.Forms.Label();
            this.KoltukSorgula_btn = new System.Windows.Forms.Button();
            this.Biletİptal_btn = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.BakiyeSorgula_btn = new System.Windows.Forms.Button();
            this.BiletSorgula_lbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Oluştur_btn);
            this.groupBox1.Controls.Add(this.KoltukSayısı_text);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 348);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salon olustur :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BiletSat_btn);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(392, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 171);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bilet Sat";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Biletİptal_btn);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Location = new System.Drawing.Point(392, 190);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(318, 171);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bilet İptal";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.KoltukSorgula_btn);
            this.groupBox4.Controls.Add(this.KoltukSorgula_lbl);
            this.groupBox4.Location = new System.Drawing.Point(769, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(318, 171);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Böş Koltuk Ögren";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BakiyeSorgula_btn);
            this.groupBox5.Controls.Add(this.BiletSorgula_lbl);
            this.groupBox5.Location = new System.Drawing.Point(769, 190);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(318, 171);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Bakiye Oğren";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Koltuk Sayısı :";
            // 
            // KoltukSayısı_text
            // 
            this.KoltukSayısı_text.Location = new System.Drawing.Point(141, 92);
            this.KoltukSayısı_text.Name = "KoltukSayısı_text";
            this.KoltukSayısı_text.Size = new System.Drawing.Size(100, 20);
            this.KoltukSayısı_text.TabIndex = 1;
            // 
            // Oluştur_btn
            // 
            this.Oluştur_btn.Location = new System.Drawing.Point(91, 162);
            this.Oluştur_btn.Name = "Oluştur_btn";
            this.Oluştur_btn.Size = new System.Drawing.Size(75, 23);
            this.Oluştur_btn.TabIndex = 2;
            this.Oluştur_btn.Text = "Oluştur";
            this.Oluştur_btn.UseVisualStyleBackColor = true;
            this.Oluştur_btn.Click += new System.EventHandler(this.Oluştur_btn_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(57, 48);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "İndirimli";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // BiletSat_btn
            // 
            this.BiletSat_btn.Location = new System.Drawing.Point(45, 95);
            this.BiletSat_btn.Name = "BiletSat_btn";
            this.BiletSat_btn.Size = new System.Drawing.Size(143, 49);
            this.BiletSat_btn.TabIndex = 3;
            this.BiletSat_btn.Text = "Bilet Sat";
            this.BiletSat_btn.UseVisualStyleBackColor = true;
            this.BiletSat_btn.Click += new System.EventHandler(this.BiletSat_btn_Click);
            // 
            // KoltukSorgula_lbl
            // 
            this.KoltukSorgula_lbl.AutoSize = true;
            this.KoltukSorgula_lbl.Location = new System.Drawing.Point(100, 50);
            this.KoltukSorgula_lbl.Name = "KoltukSorgula_lbl";
            this.KoltukSorgula_lbl.Size = new System.Drawing.Size(70, 13);
            this.KoltukSorgula_lbl.TabIndex = 0;
            this.KoltukSorgula_lbl.Text = ". . . . . . . . . . .";
            // 
            // KoltukSorgula_btn
            // 
            this.KoltukSorgula_btn.Location = new System.Drawing.Point(66, 92);
            this.KoltukSorgula_btn.Name = "KoltukSorgula_btn";
            this.KoltukSorgula_btn.Size = new System.Drawing.Size(142, 52);
            this.KoltukSorgula_btn.TabIndex = 4;
            this.KoltukSorgula_btn.Text = "Boş koltuk Sorgula";
            this.KoltukSorgula_btn.UseVisualStyleBackColor = true;
            this.KoltukSorgula_btn.Click += new System.EventHandler(this.KoltukSorgula_btn_Click);
            // 
            // Biletİptal_btn
            // 
            this.Biletİptal_btn.Location = new System.Drawing.Point(45, 84);
            this.Biletİptal_btn.Name = "Biletİptal_btn";
            this.Biletİptal_btn.Size = new System.Drawing.Size(143, 49);
            this.Biletİptal_btn.TabIndex = 5;
            this.Biletİptal_btn.Text = "Bilet İptal";
            this.Biletİptal_btn.UseVisualStyleBackColor = true;
            this.Biletİptal_btn.Click += new System.EventHandler(this.Biletİptal_btn_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(57, 40);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "İndirimli";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // BakiyeSorgula_btn
            // 
            this.BakiyeSorgula_btn.Location = new System.Drawing.Point(66, 81);
            this.BakiyeSorgula_btn.Name = "BakiyeSorgula_btn";
            this.BakiyeSorgula_btn.Size = new System.Drawing.Size(142, 52);
            this.BakiyeSorgula_btn.TabIndex = 6;
            this.BakiyeSorgula_btn.Text = "Bakiye Sorgula";
            this.BakiyeSorgula_btn.UseVisualStyleBackColor = true;
            this.BakiyeSorgula_btn.Click += new System.EventHandler(this.BakiyeSorgula_btn_Click);
            // 
            // BiletSorgula_lbl
            // 
            this.BiletSorgula_lbl.AutoSize = true;
            this.BiletSorgula_lbl.Location = new System.Drawing.Point(100, 39);
            this.BiletSorgula_lbl.Name = "BiletSorgula_lbl";
            this.BiletSorgula_lbl.Size = new System.Drawing.Size(70, 13);
            this.BiletSorgula_lbl.TabIndex = 5;
            this.BiletSorgula_lbl.Text = ". . . . . . . . . . .";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 779);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Oluştur_btn;
        private System.Windows.Forms.TextBox KoltukSayısı_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BiletSat_btn;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Biletİptal_btn;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button KoltukSorgula_btn;
        private System.Windows.Forms.Label KoltukSorgula_lbl;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button BakiyeSorgula_btn;
        private System.Windows.Forms.Label BiletSorgula_lbl;
    }
}

