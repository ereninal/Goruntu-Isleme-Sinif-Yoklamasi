using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yüz_okuma.MODEL;
using yüz_okuma;

namespace WindowsFormsApp56
{
    public partial class KullanıcıEkleform : Form
    {
        public KullanıcıEkleform()
        {
            InitializeComponent();
        }
        KULLANICI kul;
        private void buttonekle_Click(object sender, EventArgs e)
        {
            kul = new KULLANICI();
            kul.USERNAME = textBoxkullanıcıad.Text;
            kul.SIFRE = textBoxsifre.Text;
            kul.TCK_NO = textBoxtc.Text;
            kul.AD = textBoxad.Text;
            kul.SOYAD = textBoxsoyad.Text;

            Veritabani.Connect();
            bool deger = Veritabani.KULLANICI_EKLE(kul);
            Veritabani.Disconnect();
            if (deger == true)
            {
                MessageBox.Show("Kayıt Başarılı ");
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız ");
            }




        }
    }
}
