using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class DoktorGuncelle : Form
    {
        //oluşturduğum classdan bir nesne oluşturuyorum
        static MsSqlConnection baglantial = new MsSqlConnection();
        //ado.net kullanarak bir bağlantı nesnesi oluşturup baglantıgönder fonksiyonundan gelen nesneye eşitliyorum
        SqlConnection Baglanti = baglantial.BaglantiGonder();
        public DoktorGuncelle()
        {
            InitializeComponent();
        }

        //geri don butonu
        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            DoktorIslemleri doktorIslemleri = new DoktorIslemleri();
            doktorIslemleri.Show();
            this.Close();
        }

        //listele
        private void btnListele_Click(object sender, EventArgs e)
        {
            //yapılacak işlemi sql sorgusu kullanarak oluşturuyorum
            SqlDataAdapter komut = new SqlDataAdapter("Select * From Doktorlar", Baglanti);
            //bağlantıyı aç
            Baglanti.Open();
            //bir tablo nesnesi oluştur
            DataTable tablo = new DataTable();
            //verileri tablo şeklinde getir
            komut.Fill(tablo);
            //getirilen verileri datagridviewde göster
            dataGridDoktorlar.DataSource = tablo;
            //bağlantı kapat
            Baglanti.Close();
        }

        //doktor tc sine göre arama işlemi
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //sql komutu kullanarak tc ye göre arama yapıyorum like komutu doktortc ile başlayan tc lere göre arama yapıyor
            SqlDataAdapter komut = new SqlDataAdapter("Select * From Doktorlar where DoktorTC LIKE '" + textBox1.Text + "%'", Baglanti);
            Baglanti.Open();
            DataTable tablo = new DataTable();
            komut.Fill(tablo);
            dataGridDoktorlar.DataSource = tablo;
            Baglanti.Close();
        }

        private void dataGridDoktorlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagridview de tıklanılan alan boş değil ise çalışacak
            if (dataGridDoktorlar.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "")
            {
                    dataGridDoktorlar.CurrentRow.Selected = true;
                    //tıklanılan alandan doktorun tc si alınıyor
                    string TC = dataGridDoktorlar.Rows[e.RowIndex].Cells["DoktorTC"].FormattedValue.ToString();
                    Baglanti.Open();
                    //tc ye göre listeleme sql sorgusu
                    string Listele = "Select * from Doktorlar where DoktorTC="+TC;
                    SqlCommand komut = new SqlCommand(Listele, Baglanti);
                    //verileri teker teker okumak için oku nesnesi oluşturuyorum
                    SqlDataReader Oku = komut.ExecuteReader();
                    if (Oku.Read())
                    {
                    //okunulan her bir değişkeni seçip textboxlara atıyorum
                    txtDoktorTc.Text = Oku["DoktorTC"].ToString();
                    txtDoktorAd.Text = Oku["DoktorAd"].ToString();
                    txtDoktorSoyad.Text = Oku["DoktorSoyad"].ToString();
                    cmbBolum.Text = Oku["BolumID"].ToString();
                    txtDoktorTelefon.Text = Oku["DoktorTelefon"].ToString();
                    txtDoktorYas.Text = Oku["DoktorYas"].ToString();
                    }
                    Baglanti.Close();
            }
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

        //form açılırken datagridviewi veriler ile doldur ve ayrıca bölümleri listeleyecek combobox değişkeninin içini
        //veritabanındaki bölümler ile doldur
        private void DoktorGuncelle_Load(object sender, EventArgs e)
        {
            listele();
            SqlCommand komut2 = new SqlCommand("Select *from Bolumler", Baglanti);
            Baglanti.Open();
            SqlDataReader Bolumoku = komut2.ExecuteReader();
            try
            {
                while (Bolumoku.Read())
                {
                    string bolumad = Bolumoku["BolumIsmi"].ToString();
                    int bolumid = Convert.ToInt32(Bolumoku["BolumID"]);
                    cmbBolum.Items.Add(bolumid.ToString());
                    cmbbolumad.Items.Add(bolumad);
                }
                Bolumoku.Close();
            }
            //bir hata ile karşılaşılırsa kullanıcı hata mesajı ile bilgilendirilecek
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());

            }
            Baglanti.Close();
        }
        //güncelle butonu
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //textbox ve comboboxların boş ise kullanıcı alanları boş bırakmaması için bilgilendiriliyor
            if (txtDoktorAd.Text == "" || txtDoktorSoyad.Text == "" || txtDoktorTc.Text == "" || txtDoktorTelefon.Text == "" || txtDoktorYas.Text == "" || cmbBolum.Text == "")
            {
                MessageBox.Show("Lütfen Alanları Boş Bırakmayın");
            }
            else
            {
                //kullanıcıya güncellemek isteyip istemediğini soruyoruz
                DialogResult Cevap = MessageBox.Show("Güncellemek İstediğinizden Emin Misiniz?", "Güncelle", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                //cevap evet ise
                if (Cevap == DialogResult.Yes)
                {
                    //sql sorgusu kullanarak textboxdaki verilere göre update işlemi yapılıyor
                    string sorgu = "Update Doktorlar SET DoktorAd= @p1,DoktorSoyad= @p2, DoktorYas= @p4, BolumID= @p5,DoktorTelefon= @p6 where DoktorTC='"+ txtDoktorTc.Text+"'";
                    SqlCommand komut = new SqlCommand(sorgu, Baglanti);
                    komut.Parameters.AddWithValue("@p1", txtDoktorAd.Text);
                    komut.Parameters.AddWithValue("@p2", txtDoktorSoyad.Text);
                    komut.Parameters.AddWithValue("@p4", txtDoktorYas.Text);
                    int bolumid = Convert.ToInt32(cmbBolum.Text);
                    komut.Parameters.AddWithValue("@p5", bolumid);
                    komut.Parameters.AddWithValue("@p6", txtDoktorTelefon.Text);
                    Baglanti.Open();
                    komut.ExecuteNonQuery();
                    Baglanti.Close();
                    MessageBox.Show("Güncelleme İşlemi Başarılı");
                    listele();
                }

            }
        }
        //combobox da bölüm isimleri seçilince yanında bulundan bölüm id kısmı da otomatik olarak seçiliyor
        //bunun nedeni bölümid kısmını güncelleme esnasında kullanıyor olmamız ve bu şekilde bölümid değişkenine kolaylıkla ulaşabiliyoruz.
        private void cmbbolumad_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBolum.SelectedIndex = cmbbolumad.SelectedIndex;
        }
    }
}
