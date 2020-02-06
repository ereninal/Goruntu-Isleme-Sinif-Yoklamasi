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
    public partial class OgrenciGüncelleform : Form
    {
        public OgrenciGüncelleform()
        {
            InitializeComponent();
        }

        private void OgrenciGüncelleform_Load(object sender, EventArgs e)
        {

        }
        OGRENCI ogr = new OGRENCI();
        private void button1_Click(object sender, EventArgs e)
        {
            Veritabani.Connect();
            ogr.OGRENCI_NO = textBoxogrnobul.Text;

            try
            {
               
                if (textBoxogrnobul.Text != "")
                {
                    ogr = Veritabani.OGRENCI_GETIR(ogr)[0];
                }
                
            }
            catch
            {
                MessageBox.Show("Böyle bir numara yok");
            }

           

            textBoxad.Text = ogr.AD;
            textBoxsoyad.Text = ogr.SOYAD;
            textBoxtc.Text = ogr.TCK_NO;
            textBoxno.Text = ogr.OGRENCI_NO;
            comboBoxcinsiyet.Text = ogr.CINSIYET == "E" ? "ERKEK" : "KADIN";
            comboBoxsınıf.Text = ogr.SINIF+".SINIF";

            Veritabani.Disconnect();



        }

        private void button_güncelle_Click(object sender, EventArgs e)
        {

            Veritabani.Connect();

            ogr.OGRENCI_NO = textBoxogrnobul.Text;
            ogr = Veritabani.OGRENCI_GETIR(ogr)[0];

        
            
            ogr.AD = textBoxad.Text;
            ogr.SOYAD = textBoxsoyad.Text;
            ogr.TCK_NO = textBoxtc.Text;
            ogr.OGRENCI_NO = textBoxno.Text;
            ogr.CINSIYET= comboBoxcinsiyet.Text == "ERKEK" ? "E" : "K";

            bool deger = Veritabani.OGRENCI_GUNCELLE(ogr);


            if (deger == true)
            {
                MessageBox.Show("günceleme başarılı");
            }

            Veritabani.Disconnect();


        }

        private void textBoxogrnobul_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
