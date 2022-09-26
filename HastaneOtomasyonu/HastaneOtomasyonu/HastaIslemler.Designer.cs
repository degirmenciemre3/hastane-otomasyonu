
namespace HastaneOtomasyonu
{
    partial class HastaIslemler
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
            this.dataGridHastalar = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHastaSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHastaAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txthastatc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHastaYas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHastaTelefon = new System.Windows.Forms.TextBox();
            this.cmbHastaCinsiyet = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHastalar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridHastalar
            // 
            this.dataGridHastalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHastalar.Location = new System.Drawing.Point(3, 75);
            this.dataGridHastalar.Name = "dataGridHastalar";
            this.dataGridHastalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridHastalar.Size = new System.Drawing.Size(636, 349);
            this.dataGridHastalar.TabIndex = 1;
            this.dataGridHastalar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridHastalar_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(642, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Hasta Soyadı :";
            // 
            // txtHastaSoyad
            // 
            this.txtHastaSoyad.Location = new System.Drawing.Point(645, 172);
            this.txtHastaSoyad.Name = "txtHastaSoyad";
            this.txtHastaSoyad.Size = new System.Drawing.Size(273, 20);
            this.txtHastaSoyad.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(642, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Hasta Adı :";
            // 
            // txtHastaAd
            // 
            this.txtHastaAd.Location = new System.Drawing.Point(645, 127);
            this.txtHastaAd.Name = "txtHastaAd";
            this.txtHastaAd.Size = new System.Drawing.Size(273, 20);
            this.txtHastaAd.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(642, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Hasta TC :,";
            // 
            // txthastatc
            // 
            this.txthastatc.Location = new System.Drawing.Point(645, 75);
            this.txthastatc.Name = "txthastatc";
            this.txthastatc.Size = new System.Drawing.Size(273, 20);
            this.txthastatc.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(642, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Hasta Yaş :";
            // 
            // txtHastaYas
            // 
            this.txtHastaYas.Location = new System.Drawing.Point(645, 217);
            this.txtHastaYas.Name = "txtHastaYas";
            this.txtHastaYas.Size = new System.Drawing.Size(273, 20);
            this.txtHastaYas.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(642, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Hasta Cinsiyeti :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(642, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Hasta Telefon :";
            // 
            // txtHastaTelefon
            // 
            this.txtHastaTelefon.Location = new System.Drawing.Point(645, 311);
            this.txtHastaTelefon.Name = "txtHastaTelefon";
            this.txtHastaTelefon.Size = new System.Drawing.Size(273, 20);
            this.txtHastaTelefon.TabIndex = 23;
            // 
            // cmbHastaCinsiyet
            // 
            this.cmbHastaCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHastaCinsiyet.FormattingEnabled = true;
            this.cmbHastaCinsiyet.Location = new System.Drawing.Point(646, 264);
            this.cmbHastaCinsiyet.Name = "cmbHastaCinsiyet";
            this.cmbHastaCinsiyet.Size = new System.Drawing.Size(272, 21);
            this.cmbHastaCinsiyet.TabIndex = 25;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(642, 372);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(276, 23);
            this.btnEkle.TabIndex = 27;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(642, 401);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(276, 23);
            this.btnGuncelle.TabIndex = 26;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Silmek İstediğiniz Hastanın Üzerine Çift Tıklayınız";
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(93, 12);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(206, 23);
            this.btnListele.TabIndex = 29;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(12, 12);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(75, 23);
            this.btnGeriDon.TabIndex = 28;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // HastaIslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 436);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.cmbHastaCinsiyet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHastaTelefon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHastaYas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHastaSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHastaAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txthastatc);
            this.Controls.Add(this.dataGridHastalar);
            this.Name = "HastaIslemler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HastaIslemler";
            this.Load += new System.EventHandler(this.HastaIslemler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHastalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridHastalar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHastaSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHastaAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txthastatc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHastaYas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHastaTelefon;
        private System.Windows.Forms.ComboBox cmbHastaCinsiyet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnGeriDon;
    }
}