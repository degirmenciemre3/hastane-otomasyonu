using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HastaneOtomasyonu
{
    class MsSqlConnection
    {
        //bağlantı işlemlerini kolaylıkla ve tek bir yerden yapabilmemiz için bağlantı gönder methodu oluşturdum
        public SqlConnection BaglantiGonder()
        {
            //bilgisayarımızda bulunan MsSql veritabanına bağlanmak için gerekli bağlantı cümlesi
            string BaglantiAdresi = "Server=DESKTOP-BG434BD\\EMRE;Database=HastaneOtomasyon;User Id=sa;Password=123;";
            //Ado.net kullanarak sql bağlantı nesnemizi üretiyorum
            SqlConnection Baglanti = new SqlConnection(BaglantiAdresi);
            //oluşturduğum bağlantı nesnemi kullanmak istediğim yere göndermek için return ediyorum.
            return Baglanti;
        }
        
    }
}
