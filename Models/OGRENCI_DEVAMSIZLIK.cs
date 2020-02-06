using System;
using System.Collections.Generic;
using System.Text;

namespace yüz_okuma.MODEL
{
    public class OGRENCI_DEVAMSIZLIK
    {
        public int ID { get; set; }
        public int? OGRENCI_ID { get; set; }
        public int? DERS_ID { get; set; }
        public DateTime? TARIH { get; set; }
    }
}
