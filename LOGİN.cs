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
    public partial class LOGİN : Form
    {
        public LOGİN()
        {
            InitializeComponent();
        }
        KULLANICI k1 = new KULLANICI();
        List<KULLANICI> lk1 = new List<KULLANICI>();
        AnaForm ana = new AnaForm();
        private void buttongiris_Click(object sender, EventArgs e)
        {
            
            Veritabani.Connect();
            k1.USERNAME = textBoxad.Text;
            
            k1.SIFRE = textBoxsifre.Text;

            lk1 =Veritabani.KULLANICI_GETIR(k1);

            if (lk1.Count > 0 && textBoxad.Text != "" && textBoxad.Text != "")
            {
               
                ana.Show();
                this.Hide();

            }

            Veritabani.Disconnect();


        }
    }
}
