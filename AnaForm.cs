using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp56
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        ForumEkle f1 = new ForumEkle();
        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f1 = new ForumEkle();

            f1.Show();
            

        }
        OgrenciSilform ogrsil;

        private void öğrenciSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ogrsil = new OgrenciSilform();
            ogrsil.Show();
           



        }
        OgrenciGüncelleform gun;
        private void öğrenciGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gun = new OgrenciGüncelleform();
            gun.Show();

        }
        KullanıcıEkleform kefrm;
        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kefrm = new KullanıcıEkleform();

            kefrm.Show();


        }
        DersEkleForm defrm;
        private void dersEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            defrm = new DersEkleForm();
            defrm.Show();



        }
        KullanıcıSilform ksfrm;
        private void kullanıcıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ksfrm = new KullanıcıSilform();
            ksfrm.Show();
        }

        private void yoklamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYoklama f = new FormYoklama();
            f.Show();
        }
    }
}
