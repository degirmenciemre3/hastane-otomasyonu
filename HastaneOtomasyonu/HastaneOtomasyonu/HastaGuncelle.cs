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
    public partial class HastaGuncelle : Form
    {
        //entity freamwork nesnemi oluşturuyorum
        HastaneOtomasyonEntities he = new HastaneOtomasyonEntities();
        public HastaGuncelle()
        {
            InitializeComponent();
        }

        //listeleme fonksiyonu
        public void listele()
        {
            //entity sınıfından hastaları liste şeklinde çekip datagridview e aktarıyorum
            dataGridHastalar.DataSource = he.Hastalar.ToList();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            HastaIslemler hastaIslemler = new HastaIslemler();
            hastaIslemler.Show();
            this.Close();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        //datagridview tıklama işlemi
        private void dataGridHastalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //tıklanılan alan boş değil ise çalış
            if (dataGridHastalar.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "")
            {
                dataGridHastalar.CurrentRow.Selected = true;
                //güncellenecek tc alınıyor
                string GüncellenecekTC = dataGridHastalar.Rows[e.RowIndex].Cells["HastaTC"].FormattedValue.ToString();
                //hastalar nesnesinden bir nesne üretiliyor
                Hastalar hasta = new Hastalar();
                //veritabanında güncellenecektc ye göre hastanın verileri çekilip hasta değişkenine aktarılıyor
                hasta = he.Hastalar.Find(GüncellenecekTC);
                //textbox ların textleri gelen hastanın verileri ile dolduruluyor
                txtHastaAd.Text = hasta.HastaAd;
                txtHastaSoyad.Text = hasta.HastaSoyad;
                txthastatc.Text = hasta.HastaTC;
                txtHastaTelefon.Text = hasta.HastaTelefon;
                txtHastaYas.Text = hasta.HastaYas.ToString();
                //gelen veride hastanın cinsiyeti erkek ise comboboxın indexlerini ona göre seçeceğiz
                if (hasta.HastaCinsiyet == "Erkek")
                {
                    cmbHastaCinsiyet.SelectedIndex = 0;
                }
                else
                {
                    cmbHastaCinsiyet.SelectedIndex = 1;
                }
            }
        }

        private void HastaGuncelle_Load(object sender, EventArgs e)
        {
            //hastaları listele ve comboboxın içini erkek ve kadın olarak değerler ile doldur
            listele();
            cmbHastaCinsiyet.Items.Add("Erkek");
            cmbHastaCinsiyet.Items.Add("Kadın");
        }

        //güncelleme işlemleri
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
           //güncellenecek hastanın tc si
            string hastaTC = txthastatc.Text;
            //tcsini kullanarak hastanın bilgilerini çekiyoruz
            var guncelle = he.Hastalar.Find(hastaTC);
            //çektiğimiz bilgileri yeni bilgiler ile değiştiriyoruz
            guncelle.HastaAd = txtHastaAd.Text;
            guncelle.HastaSoyad = txtHastaSoyad.Text;
            guncelle.HastaCinsiyet = cmbHastaCinsiyet.Text;
            guncelle.HastaTelefon = txtHastaTelefon.Text;
            guncelle.HastaYas = Convert.ToInt32(txtHastaYas.Text);
            //değişiklikleri kaydediyoruz
            he.SaveChanges();
            //kullanıcıyı bilgilendiriyoruz
            MessageBox.Show("Güncelleme yapıldı");
            //yapılan değişiklikler için tekrardan listeleme yapıyoruz
            listele();
        }
    }
}
