
namespace HastaneOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDoktorislemler = new System.Windows.Forms.Button();
            this.btnBolumIslemler = new System.Windows.Forms.Button();
            this.btnHastaIslemler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDoktorislemler
            // 
            this.btnDoktorislemler.Location = new System.Drawing.Point(12, 12);
            this.btnDoktorislemler.Name = "btnDoktorislemler";
            this.btnDoktorislemler.Size = new System.Drawing.Size(199, 184);
            this.btnDoktorislemler.TabIndex = 0;
            this.btnDoktorislemler.Text = "Doktor İşlemleri";
            this.btnDoktorislemler.UseVisualStyleBackColor = true;
            this.btnDoktorislemler.Click += new System.EventHandler(this.btnDoktorislemler_Click);
            // 
            // btnBolumIslemler
            // 
            this.btnBolumIslemler.Location = new System.Drawing.Point(230, 12);
            this.btnBolumIslemler.Name = "btnBolumIslemler";
            this.btnBolumIslemler.Size = new System.Drawing.Size(199, 184);
            this.btnBolumIslemler.TabIndex = 1;
            this.btnBolumIslemler.Text = "Bölüm İşlemleri";
            this.btnBolumIslemler.UseVisualStyleBackColor = true;
            this.btnBolumIslemler.Click += new System.EventHandler(this.btnBolumIslemler_Click);
            // 
            // btnHastaIslemler
            // 
            this.btnHastaIslemler.Location = new System.Drawing.Point(121, 205);
            this.btnHastaIslemler.Name = "btnHastaIslemler";
            this.btnHastaIslemler.Size = new System.Drawing.Size(199, 184);
            this.btnHastaIslemler.TabIndex = 2;
            this.btnHastaIslemler.Text = "Hasta İşlemleri";
            this.btnHastaIslemler.UseVisualStyleBackColor = true;
            this.btnHastaIslemler.Click += new System.EventHandler(this.btnHastaIslemler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 401);
            this.Controls.Add(this.btnHastaIslemler);
            this.Controls.Add(this.btnBolumIslemler);
            this.Controls.Add(this.btnDoktorislemler);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDoktorislemler;
        private System.Windows.Forms.Button btnBolumIslemler;
        private System.Windows.Forms.Button btnHastaIslemler;
    }
}

