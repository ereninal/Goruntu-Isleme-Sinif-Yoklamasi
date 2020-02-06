using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yüz_okuma;
using yüz_okuma.MODEL;

namespace WindowsFormsApp56
{
    public partial class KullanıcıSilform : Form
    {
        public KullanıcıSilform()
        {
            InitializeComponent();
        }
        KULLANICI k1 = new KULLANICI();
        bool deger;
        private void buttonsil_Click(object sender, EventArgs e)
        {
            k1.USERNAME = textBoxad.Text;
            k1.SIFRE = textBoxsifre.Text;
            Veritabani.Connect();
            
            if (textBoxad.Text != ""  && textBoxsifre.Text != "")
            {
                deger = Veritabani.KULLANICI_SIL(k1);

            }
            else
            {
                MessageBox.Show("lütfen boş alanları doldurunuz");
            }
   
            if(deger == true)
            {
                MessageBox.Show("Kullanıcı silindi");
            }
            Veritabani.Disconnect();


        }
    }
}
