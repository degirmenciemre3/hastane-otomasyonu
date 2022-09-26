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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDoktorislemler_Click(object sender, EventArgs e)
        {
            DoktorIslemleri doktorIslemleri = new DoktorIslemleri();
            doktorIslemleri.Show();
        }

        private void btnBolumIslemler_Click(object sender, EventArgs e)
        {
            BolumIslemleri bolumIslemleri = new BolumIslemleri();
            bolumIslemleri.Show();
        }

        private void btnHastaIslemler_Click(object sender, EventArgs e)
        {
            HastaIslemler hastaIslemler = new HastaIslemler();
            hastaIslemler.Show();
        }
    }
}
