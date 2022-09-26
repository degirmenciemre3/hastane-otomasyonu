
namespace HastaneOtomasyonu
{
    partial class DoktorIslemleri
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
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtDoktorTc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDoktorAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDoktorSoyad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDoktorYas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDoktorTelefon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBolum = new System.Windows.Forms.ComboBox();
            this.cmbBolumad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDoktorlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridDoktorlar
            // 
            this.dataGridDoktorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDoktorlar.Location = new System.Drawing.Point(12, 77);
            this.dataGridDoktorlar.Name = "dataGridDoktorlar";
            this.dataGridDoktorlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDoktorlar.Size = new System.Drawing.Size(636, 349);
            this.dataGridDoktorlar.TabIndex = 0;
            this.dataGridDoktorlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDoktorlar_CellClick);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(12, 12);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(75, 23);
            this.btnGeriDon.TabIndex = 1;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(93, 12);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(206, 23);
            this.btnListele.TabIndex = 2;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(654, 373);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(276, 23);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Silmek İstediğiniz Doktorun Üzerine Çift Tıklayınız";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(654, 402);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(276, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtDoktorTc
            // 
            this.txtDoktorTc.Location = new System.Drawing.Point(654, 77);
            this.txtDoktorTc.Name = "txtDoktorTc";
            this.txtDoktorTc.Size = new System.Drawing.Size(273, 20);
            this.txtDoktorTc.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(651, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Doktor TC :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(651, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Doktor Adı :";
            // 
            // txtDoktorAd
            // 
            this.txtDoktorAd.Location = new System.Drawing.Point(654, 129);
            this.txtDoktorAd.Name = "txtDoktorAd";
            this.txtDoktorAd.Size = new System.Drawing.Size(273, 20);
            this.txtDoktorAd.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(651, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Doktor Soyadı :";
            // 
            // txtDoktorSoyad
            // 
            this.txtDoktorSoyad.Location = new System.Drawing.Point(654, 174);
            this.txtDoktorSoyad.Name = "txtDoktorSoyad";
            this.txtDoktorSoyad.Size = new System.Drawing.Size(273, 20);
            this.txtDoktorSoyad.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(651, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Doktor Yaş :";
            // 
            // txtDoktorYas
            // 
            this.txtDoktorYas.Location = new System.Drawing.Point(654, 263);
            this.txtDoktorYas.Name = "txtDoktorYas";
            this.txtDoktorYas.Size = new System.Drawing.Size(273, 20);
            this.txtDoktorYas.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(651, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Doktor Telefon :";
            // 
            // txtDoktorTelefon
            // 
            this.txtDoktorTelefon.Location = new System.Drawing.Point(654, 306);
            this.txtDoktorTelefon.Name = "txtDoktorTelefon";
            this.txtDoktorTelefon.Size = new System.Drawing.Size(273, 20);
            this.txtDoktorTelefon.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(651, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Doktor Bölümü :";
            // 
            // cmbBolum
            // 
            this.cmbBolum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBolum.FormattingEnabled = true;
            this.cmbBolum.Location = new System.Drawing.Point(655, 221);
            this.cmbBolum.Name = "cmbBolum";
            this.cmbBolum.Size = new System.Drawing.Size(43, 21);
            this.cmbBolum.TabIndex = 19;
            // 
            // cmbBolumad
            // 
            this.cmbBolumad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBolumad.FormattingEnabled = true;
            this.cmbBolumad.Location = new System.Drawing.Point(704, 221);
            this.cmbBolumad.Name = "cmbBolumad";
            this.cmbBolumad.Size = new System.Drawing.Size(223, 21);
            this.cmbBolumad.TabIndex = 20;
            this.cmbBolumad.SelectedIndexChanged += new System.EventHandler(this.cmbBolumad_SelectedIndexChanged);
            // 
            // DoktorIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 436);
            this.Controls.Add(this.cmbBolumad);
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
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.dataGridDoktorlar);
            this.Name = "DoktorIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Islemleri";
            this.Load += new System.EventHandler(this.DoktorIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDoktorlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridDoktorlar;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtDoktorTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDoktorAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDoktorSoyad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDoktorYas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDoktorTelefon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBolum;
        private System.Windows.Forms.ComboBox cmbBolumad;
    }
}