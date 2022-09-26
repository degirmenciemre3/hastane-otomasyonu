using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class HastaIslemler : Form
    {
        //entity nesnemden bir nesne türetiyorum
        HastaneOtomasyonEntities he = new HastaneOtomasyonEntities();
        public HastaIslemler()
        {
            InitializeComponent();
        }
        //geri dön butonu
        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void listele()
        {
            //listeleme işlemi yapmak için entity nesnemi kullanarak tüm hastaları listeleyip datagridview e aktarıyorum
            dataGridHastalar.DataSource = he.Hastalar.ToList();
        }
        //form açılırken
        private void HastaIslemler_Load(object sender, EventArgs e)
        {
            //comboboxların içini erkek ve kadın değişkenleri ile doldur
            cmbHastaCinsiyet.Items.Add("Erkek");
            cmbHastaCinsiyet.Items.Add("Kadın");
            //datagridview e listele
            listele();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridHastalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //tıklanılan alan boş değil ise çalışacak
            if (dataGridHastalar.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "")
            {
                //kullanıcıya silmek isteyip istemediği soruluyor
                DialogResult Cevap = MessageBox.Show("Silmek İstediğinizden Emin Misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                //cevap evet ise
                if (Cevap == DialogResult.Yes)
                {
                    dataGridHastalar.CurrentRow.Selected = true;
                    //tıklanılan alandan hastanın tc si alınıyor
                    string SilinecekTC = dataGridHastalar.Rows[e.RowIndex].Cells["HastaTC"].FormattedValue.ToString();
                    //silinecek hasta bulunuyor
                    var sil = he.Hastalar.Find(SilinecekTC);
                    //silme işlemi yapılıyor
                    he.Hastalar.Remove(sil);
                    //değişiklikleri kaydet
                    he.SaveChanges();
                    //kullanıcıyı bilgilendir
                    MessageBox.Show("Hasta silinmiştir");
                    //değişiklikler yüzünden tekrardan listele
                    listele();

                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //hastalar nesnemden bir nesne türetiyorum
            Hastalar Hasta = new Hastalar();
            //türettiğim nesnenin içerisini kullanıcının girdiği veriler ile dolduruyorum
            Hasta.HastaAd = txtHastaAd.Text;
            Hasta.HastaCinsiyet = cmbHastaCinsiyet.Text;
            Hasta.HastaSoyad = txtHastaSoyad.Text;
            Hasta.HastaTC = txthastatc.Text;
            Hasta.HastaTelefon = txtHastaTelefon.Text;
            Hasta.HastaYas = Convert.ToInt32(txtHastaYas.Text);
            //entity sınıfını kullanarak ekleme işlemi yapıyorum
            he.Hastalar.Add(Hasta);
            //değişiklikleri kaydet
            he.SaveChanges();
            //kullanıcıyı bilgilendir
            MessageBox.Show("Hasta Eklendi");
            //değişiklikler yüzünden tekrardan listele
            listele();
        }
        //güncelleme formuna geçiş
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            HastaGuncelle hastaguncelle = new HastaGuncelle();
            hastaguncelle.Show();
            this.Close();
        }
    }
}
