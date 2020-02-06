using System;
using System.Collections.Generic;
using System.Text;

namespace yüz_okuma.MODEL
{
    public class OGRENCI
    {
        public int OGRENCI_ID { get; set; }
        public string OGRENCI_NO { get; set; }
        public string TCK_NO { get; set; }
        public string AD { get; set; }
        public string SOYAD { get; set; }
        public DateTime? DOGUM_TARIHI { get; set; }
        public string CINSIYET { get; set; }
        public string SINIF { get; set; }
        public string DEVAM { get; set; }
        public string DOSYA_PATH { get; set; }
    }
}
