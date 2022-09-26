using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneOtomasyonu
{
    public partial class DoktorIslemleri : Form
    {
        //oluşturduğum nesneden bir nesne türetiyorum
        static MsSqlConnection baglantial = new MsSqlConnection();
        //baglantı nesnesine oluşturduğum baglantıgönder fonksiyonundan değeri alıyorum
        SqlConnection Baglanti = baglantial.BaglantiGonder();
        public DoktorIslemleri()
        {
            InitializeComponent(); 
        }

        public void listele()
        {
            SqlDataAdapter komut = new SqlDataAdapter("Select * From Doktorlar", Baglanti);
            Baglanti.Open();
            DataTable tablo = new DataTable();
            komut.Fill(tablo);
            dataGridDoktorlar.DataSource = tablo;
            Baglanti.Close();
        }
        private void DoktorIslemleri_Load(object sender, EventArgs e)
        {
            //veritabanından bölümler getirilip comboboxların içerisi bölümlerle dolduruluyor
            SqlCommand komut2 = new SqlCommand("Select *from Bolumler", Baglanti);
            Baglanti.Open();
            SqlDataReader Bolumoku = komut2.ExecuteReader();
            try
            {
                while (Bolumoku.Read())
                {
                    string bolumad = Bolumoku["bolumIsmi"].ToString();
                    int bolumid = Convert.ToInt32(Bolumoku["BolumID"]);
                    cmbBolum.Items.Add(bolumid.ToString());
                    cmbBolumad.Items.Add(bolumad);
                }
                Bolumoku.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());

            }
            Baglanti.Close();
        }
        //geri dönmek için formu direkt kapatmamız yeterli olur çünkü giriş formumuz hala kapanmadı ve bu formdan giriş formuna geçiş için
        //sadece kapatma işlemi yeterli olacaktır.
        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //textboxların içi dolu ise çalışacak
            if (txtDoktorAd.Text != "" && txtDoktorSoyad.Text != "" && txtDoktorTc.Text != "" && txtDoktorYas.Text != "" && txtDoktorTelefon.Text != "" && cmbBolum.Text !="")
            {
                //ado.net kullanarak ekleme işlemi yapılıyor
                Baglanti.Open();
                string KayitKomutu = "insert into Doktorlar(DoktorTC,DoktorAd,DoktorSoyad,BolumID,DoktorYas,DoktorTelefon) values (@tc,@ad,@soyad,@bolum,@yas,@telefon)";
                SqlCommand komut = new SqlCommand(KayitKomutu,Baglanti);
                komut.Parameters.AddWithValue("@tc", txtDoktorTc.Text);
                komut.Parameters.AddWithValue("@ad", txtDoktorAd.Text);
                komut.Parameters.AddWithValue("@soyad", txtDoktorSoyad.Text);
                komut.Parameters.AddWithValue("@bolum", Convert.ToInt32(cmbBolum.Text));
                komut.Parameters.AddWithValue("@yas", txtDoktorYas.Text);
                komut.Parameters.AddWithValue("@telefon", txtDoktorTelefon.Text);
                komut.ExecuteNonQuery();
                Baglanti.Close();
                MessageBox.Show("Doktor Başarılı Bir Şekilde Eklendi");
                //ekleme yapıldıktan sonra textboxlar boşaltılıyor ki kullanım açısından kolay olsun
                txtDoktorAd.Text = "";
                txtDoktorSoyad.Text = "";
                txtDoktorTc.Text = "";
                txtDoktorYas.Text = "";
                txtDoktorTelefon.Text = "";
                cmbBolum.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen Alanları Boş Bırakmayın.");
            }
            listele();
        }
        //güncelle butonu
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DoktorGuncelle doktorGuncelle = new DoktorGuncelle();
            doktorGuncelle.Show();
            this.Close();
        }

        private void dataGridDoktorlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridDoktorlar.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "")
            {
                //kullanıcıya silmek isteyip istemediği soruluyor
                DialogResult Cevap = MessageBox.Show("Silmek İstediğinizden Emin Misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                //cevap evet ise
                if (Cevap == DialogResult.Yes)
                {
                    dataGridDoktorlar.CurrentRow.Selected = true;
                    //silinecek doktor tcsi tıklanılan alandan alınıyor
                    string SilinecekDoktorTC = dataGridDoktorlar.Rows[e.RowIndex].Cells["DoktorTC"].FormattedValue.ToString();
                    Baglanti.Open();
                    //silme sql komutu
                    string SilmeKomutu = "Delete from Doktorlar where DoktorTC=" + SilinecekDoktorTC;
                    SqlCommand komut = new SqlCommand(SilmeKomutu, Baglanti);
                    komut.ExecuteNonQuery();
                    Baglanti.Close();
                    listele();
                }
            }
        }
        //seçilen bölüm ismine göre bölüm id de otomatik değişmesi için
        private void cmbBolumad_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBolum.SelectedIndex = cmbBolumad.SelectedIndex;
        }
    }
}
