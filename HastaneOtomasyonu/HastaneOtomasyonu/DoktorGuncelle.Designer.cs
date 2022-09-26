
namespace HastaneOtomasyonu
{
    partial class DoktorGuncelle
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
            this.dataGridDoktorlar = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBolum = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDoktorTelefon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDoktorYas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDoktorSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDoktorAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDoktorTc = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cmbbolumad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDoktorlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridDoktorlar
            // 
            this.dataGridDoktorlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDoktorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDoktorlar.Location = new System.Drawing.Point(12, 75);
            this.dataGridDoktorlar.Name = "dataGridDoktorlar";
            this.dataGridDoktorlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDoktorlar.Size = new System.Drawing.Size(636, 349);
            this.dataGridDoktorlar.TabIndex = 1;
            this.dataGridDoktorlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDoktorlar_CellClick);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(96, 12);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(206, 23);
            this.btnListele.TabIndex = 4;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(15, 12);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(75, 23);
            this.btnGeriDon.TabIndex = 3;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 46);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 23);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tc Göre Listele";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Güncellemek İstediğiniz Doktorun Üzerine Tıklayınız";
            // 
            // cmbBolum
            // 
            this.cmbBolum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBolum.FormattingEnabled = true;
            this.cmbBolum.Location = new System.Drawing.Point(655, 218);
            this.cmbBolum.Name = "cmbBolum";
            this.cmbBolum.Size = new System.Drawing.Size(43, 21);
            this.cmbBolum.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(651, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Doktor Telefon :";
            // 
            // txtDoktorTelefon
            // 
            this.txtDoktorTelefon.Location = new System.Drawing.Point(654, 303);
            this.txtDoktorTelefon.Name = "txtDoktorTelefon";
            this.txtDoktorTelefon.Size = new System.Drawing.Size(273, 20);
            this.txtDoktorTelefon.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(651, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Doktor Yaş :";
            // 
            // txtDoktorYas
            // 
            this.txtDoktorYas.Location = new System.Drawing.Point(654, 260);
            this.txtDoktorYas.Name = "txtDoktorYas";
            this.txtDoktorYas.Size = new System.Drawing.Size(273, 20);
            this.txtDoktorYas.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(651, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Doktor Bölümü :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(651, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Doktor Soyadı :";
            // 
            // txtDoktorSoyad
            // 
            this.txtDoktorSoyad.Location = new System.Drawing.Point(654, 171);
            this.txtDoktorSoyad.Name = "txtDoktorSoyad";
            this.txtDoktorSoyad.Size = new System.Drawing.Size(273, 20);
            this.txtDoktorSoyad.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(651, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Doktor Adı :";
            // 
            // txtDoktorAd
            // 
            this.txtDoktorAd.Location = new System.Drawing.Point(654, 126);
            this.txtDoktorAd.Name = "txtDoktorAd";
            this.txtDoktorAd.Size = new System.Drawing.Size(273, 20);
            this.txtDoktorAd.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(651, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Doktor TC :";
            // 
            // txtDoktorTc
            // 
            this.txtDoktorTc.Location = new System.Drawing.Point(654, 74);
            this.txtDoktorTc.Name = "txtDoktorTc";
            this.txtDoktorTc.ReadOnly = true;
            this.txtDoktorTc.Size = new System.Drawing.Size(273, 20);
            this.txtDoktorTc.TabIndex = 21;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(654, 329);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(276, 23);
            this.btnGuncelle.TabIndex = 20;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cmbbolumad
            // 
            this.cmbbolumad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbolumad.FormattingEnabled = true;
            this.cmbbolumad.Location = new System.Drawing.Point(704, 218);
            this.cmbbolumad.Name = "cmbbolumad";
            this.cmbbolumad.Size = new System.Drawing.Size(223, 21);
            this.cmbbolumad.TabIndex = 33;
            this.cmbbolumad.SelectedIndexChanged += new System.EventHandler(this.cmbbolumad_SelectedIndexChanged);
            // 
            // DoktorGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 436);
            this.Controls.Add(this.cmbbolumad);
            this.Controls.Add(this.cmbBolum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDoktorTelefon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDoktorYas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDoktorSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDoktorAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDoktorTc);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.dataGridDoktorlar);
            this.Name = "DoktorGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Guncelle";
            this.Load += new System.EventHandler(this.DoktorGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDoktorlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridDoktorlar;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBolum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDoktorTelefon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDoktorYas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDoktorSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDoktorAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDoktorTc;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ComboBox cmbbolumad;
    }
}