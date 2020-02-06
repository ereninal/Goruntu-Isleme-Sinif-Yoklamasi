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
    public partial class OgrenciSilform : Form
    {
        public OgrenciSilform()
        {
            InitializeComponent();
        }

        OGRENCI ogr = new OGRENCI();
        private void buttonsil_Click(object sender, EventArgs e)
        {
            Veritabani.Connect();
            ogr.OGRENCI_NO = textBox_Numara.Text;
            bool deger =Veritabani.OGRENCI_SIL(ogr);
            Veritabani.Disconnect();

            if (deger == true)
            {
                MessageBox.Show("Giriş Başarılı");
            }
            else
            {
                MessageBox.Show("Giriş Başarısız");
            }



        }
    }
}
