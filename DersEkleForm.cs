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
    public partial class DersEkleForm : Form
    {
        public DersEkleForm()
        {
            InitializeComponent();
        }
        DERS d1;
        private void buttonekle_Click(object sender, EventArgs e)
        {
            d1 = new DERS();
            d1.DERS_AD = textBoxders.Text;
            d1.ACIKLAMA = richTextBoxacıklama.Text;
            Veritabani.Connect();

            bool deger =Veritabani.DERS_EKLE(d1);

            if (deger) {
                MessageBox.Show("Ders Eklendi");
            }

            Veritabani.Disconnect();




        }
    }
}
