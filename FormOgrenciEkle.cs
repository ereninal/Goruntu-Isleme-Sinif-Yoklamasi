using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using yüz_okuma;
using yüz_okuma.MODEL;

namespace WindowsFormsApp56
{
    public partial class ForumEkle : Form
    {
        public ForumEkle()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private async void btnEgit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yüzünüzü Sağ Sola Çevirin.");
            await Task.Run(() =>
            {
                for (int i = 0; i < 250; i++)
                {
                    if (!recognition.SaveTrainingData(pictureBox2.Image, txtOgrenciNumara.Text)) 
                        MessageBox.Show("Hata", "Profil alınırken beklenmeyen bir hata oluştu.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Thread.Sleep(50);
                    //lblEgitilenAdet.Text = (i + 1) + " adet profil.";
                }


                recognition = null;
                train = null;

                recognition = new BusinessRecognition("D:\\", "Faces", "yuz.xml");
                train = new Classifier_Train("D:\\", "Faces", "yuz.xml");
            });

        }
        BusinessRecognition recognition = new BusinessRecognition("D:\\", "Faces", "yuz.xml");
        Classifier_Train train = new Classifier_Train("D:\\", "Faces", "yuz.xml");
        private void Form1_Load(object sender, EventArgs e)
        {
            txtOgrenciNumara.Text = Veritabani.ogrNoGetir();


            Capture capture = new Capture();
            capture.Start();
            capture.ImageGrabbed += (a, b) =>
            {
                var image = capture.RetrieveBgrFrame();
                var grayimage = image.Convert<Gray, byte>();
                HaarCascade haaryuz = new HaarCascade("haarcascade_frontalface_alt2.xml");
                MCvAvgComp[][] Yuzler = grayimage.DetectHaarCascade(haaryuz, 1.2, 5, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(15, 15));
                MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_COMPLEX, 0.5, 0.5);
                foreach (MCvAvgComp yuz in Yuzler[0])
                {
                    var sadeyuz = grayimage.Copy(yuz.rect).Convert<Gray, byte>().Resize(100, 100, INTER.CV_INTER_CUBIC);
                    //Resimler aynı boyutta olmalıdır. O yüzden Resize ile yeniden boyutlandırma yapılmıştır. Aksi taktirde Classifier_Train sınıfının 245. satırında hata alınacaktır.
                    pictureBox2.Image = sadeyuz.ToBitmap();
                    if (train != null)
                        if (train.IsTrained)
                        {
                            string name = train.Recognise(sadeyuz);
                            int match_value = (int)train.Get_Eigen_Distance;
                            image.Draw(name + " ", ref font, new Point(yuz.rect.X - 2, yuz.rect.Y - 2), new Bgr(Color.LightGreen));
                        }
                    image.Draw(yuz.rect, new Bgr(Color.Red), 2);
                }
                pictureBox1.Image = image.ToBitmap();
            };
        }
        OGRENCI ogr = new OGRENCI();
        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
           
            ogr.TCK_NO = txtkimlik.Text;
            ogr.AD = txtAd.Text;
            ogr.SOYAD = txtSoyad.Text;
            //ogr.OGRENCI_NO= txtOgrenciNumara.Text;
            ogr.DOGUM_TARIHI = dtDogumTarihi.Value;
            ogr.CINSIYET = cmbCinsiyet.Text == "ERKEK" ? "E" : "K";
            ogr.SINIF = cmbSınıf.Text.Split('.')[0];

            Veritabani.Connect();
            bool deger =Veritabani.OGRENCI_EKLE(ogr);
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
