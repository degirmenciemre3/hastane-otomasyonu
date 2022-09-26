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
    public partial class BolumIslemleri : Form
    {
        public BolumIslemleri()
        {
            InitializeComponent();
        }
        //geri dön butonu
        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //entity freamwork işlemlerini kullanmak için nesnemi oluşturuyorum
        HastaneOtomasyonEntities he = new HastaneOtomasyonEntities();
        
        //datagridview de listeleme yapan fonksiyon
        public void listele()
        {
            dataGridBolumler.DataSource = he.Bolumler.ToList();
        }

        //listele butonu
        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        //form yükleme fonksiyonu
        private void BolumIslemleri_Load(object sender, EventArgs e)
        {
            listele();
        }

        //ekle butonu
        private void button1_Click(object sender, EventArgs e)
        {
            //bölümler nesnesinden bir nesne türetiyorunm
            Bolumler bolumler = new Bolumler();
            //oluşturduğum nesnenin bölümismi değişkenine formda oluşturduğum textboxda yazılan bölümismini atıyorum
            bolumler.BolumIsmi = textBox1.Text;
            //oluşturduğum nesneyi veritabanına ekleme yapıyorum
            he.Bolumler.Add(bolumler);
            //değişiklikleri kayıtediyorum
            he.SaveChanges();
            //kullanıcıya eklendiğine dair bilgi veriyorum
            MessageBox.Show("Bölüm Eklendi");
            //datagridview yapılan değişikliklerden dolayı tekrardan listeleniyor
            listele();
        }

        //datagridview de tıklanma olayı
        private void dataGridBolumler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //eğer tıkladığım bölüm boş değil ise çalışacaktır
            if (dataGridBolumler.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "")
            {
                //kullanıcıya silmek isteyip istemediğini bir messagebox yardımı ile soruyorum ve cevabını bir değişkende tutuyorum
                DialogResult Cevap = MessageBox.Show("Silmek İstediğinizden Emin Misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                //kullanıcının verdiği cevap evet ise çalışacak
                if (Cevap == DialogResult.Yes)
                {
                    dataGridBolumler.CurrentRow.Selected = true;
                    //silinecek bölüm id sini tıklanan alandan alıyorum
                    int Silinecekid = Convert.ToInt32(dataGridBolumler.Rows[e.RowIndex].Cells["BolumID"].FormattedValue);
                    //silmek istediğim bölümü id'sine göre veritabanından çağırıyorum
                    var sil = he.Bolumler.Find(Silinecekid);
                    //bulunan verinin silme işlemi
                    he.Bolumler.Remove(sil);
                    //değişiklikleri kaydet
                    he.SaveChanges();
                    //kullanıcıyı bilgilendir
                    MessageBox.Show("Bölüm silinmiştir");
                    //yapılan değişiklikler yüzünden tekrardan listele
                    listele();
                }
            }
        }

        //güncelleme butonu
        private void button2_Click(object sender, EventArgs e)
        {
            //güncellenecek bölümün id sini textboxdan alıyorum
            int id = int.Parse(txtbolumid.Text);
            //güncellemek istediğim bölümü veritabanında aratıyorum
            var guncelle = he.Bolumler.Find(id);
            //nesnenin bölüm ismi alanını değiştirdiğim textbox'ın texti ile değiştiriyorum
            guncelle.BolumIsmi = txtbolumismi.Text;
            //yapılan değişiklikleri kaydediyorum
            he.SaveChanges();
            //kullanıcı bilgilendiriliyor
            MessageBox.Show("Güncelleme yapıldı");
            //yapılan değişikliklerden dolayı tekrardan listele
            listele();
        }
    }
}
