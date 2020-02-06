using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Data.SqlClient;
using yüz_okuma.MODEL;
using yüz_okuma;

namespace WindowsFormsApp56
{
    public partial class FormYoklama : Form
    {
        public FormYoklama()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        
        BusinessRecognition recognition = new BusinessRecognition("D:\\", "Faces", "yuz.xml");
        Classifier_Train train = new Classifier_Train("D:\\", "Faces", "yuz.xml");
        private void FormYoklama_Load(object sender, EventArgs e)
        {
             string name;
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
                    
                    if (train != null)
                        if (train.IsTrained)
                        {
                            name = train.Recognise(sadeyuz,-1,this);
                            int match_value = (int)train.Get_Eigen_Distance;
                            image.Draw(name + " ", ref font, new Point(yuz.rect.X - 2, yuz.rect.Y - 2), new Bgr(Color.LightGreen));
                           
                           
                        }
                    image.Draw(yuz.rect, new Bgr(Color.Red), 2);
                    
                }
                
                pictureBox1.Image = image.ToBitmap();
            };
        }
        private void btnYoklama_Click(object sender, EventArgs e)
        {
            OGRENCI_DEVAMSIZLIK ogr = new OGRENCI_DEVAMSIZLIK();
            foreach (DataGridViewRow item in dgYoklama.Rows)
            {

                ogr.OGRENCI_ID = Convert.ToInt32(item.Cells[0].Value.ToString().Substring(3, 1));
                ogr.DERS_ID = 1;
                ogr.TARIH = DateTime.Now.Date;
                Veritabani.OGRENCI_DEVAMSIZLIK_EKLE(ogr);
            }
        }
    }
}
