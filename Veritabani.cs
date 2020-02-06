using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using yüz_okuma.MODEL;

namespace yüz_okuma
{
    public static class Veritabani
    {
        static SqlConnection conn;
        static SqlCommand cmd;
        static string conn_string = @"Data Source=EREN-LAPTOP\SQLEXPRESS;Initial Catalog=YOKLAMA;Integrated Security=True";
        static object dbnull = DBNull.Value;

        public static object ToDBNull(object value)
        {
            if (value == "" || value == null)
            {
                return DBNull.Value;
            }
            else
            {
                return value;
            }
        }
        public static void Connect()
        {
            conn = new SqlConnection(conn_string);
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public static void Disconnect()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public static bool KULLANICI_EKLE(KULLANICI param)
        {
            Connect();
            cmd = new SqlCommand("SP_KULLANICI", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PROCESS_TYPE", "EKLE");
            cmd.Parameters.AddWithValue("@KULLANICI_ID", dbnull);
            cmd.Parameters.AddWithValue("@USERNAME", ToDBNull(param.USERNAME));
            cmd.Parameters.AddWithValue("@SIFRE", ToDBNull(param.SIFRE));
            cmd.Parameters.AddWithValue("@UNVAN", ToDBNull(param.UNVAN));
            cmd.Parameters.AddWithValue("@YETKI", ToDBNull(param.YETKI));
            cmd.Parameters.AddWithValue("@TCK_NO", ToDBNull(param.TCK_NO));
            cmd.Parameters.AddWithValue("@AD", ToDBNull(param.AD));
            cmd.Parameters.AddWithValue("@SOYAD", ToDBNull(param.SOYAD));

            if (cmd.ExecuteNonQuery() >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool KULLANICI_SIL(KULLANICI param)
        {
            Connect();
            cmd = new SqlCommand("SP_KULLANICI", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PROCESS_TYPE", "SIL");
            cmd.Parameters.AddWithValue("@KULLANICI_ID", param.KULLANICI_ID);
            cmd.Parameters.AddWithValue("@USERNAME", ToDBNull(param.USERNAME));
            cmd.Parameters.AddWithValue("@SIFRE", ToDBNull(param.SIFRE));
            cmd.Parameters.AddWithValue("@UNVAN", ToDBNull(param.UNVAN));
            cmd.Parameters.AddWithValue("@YETKI", ToDBNull(param.YETKI));
            cmd.Parameters.AddWithValue("@TCK_NO", ToDBNull(param.TCK_NO));
            cmd.Parameters.AddWithValue("@AD", ToDBNull(param.AD));
            cmd.Parameters.AddWithValue("@SOYAD", ToDBNull(param.SOYAD));

            if (cmd.ExecuteNonQuery() >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool KULLANICI_GUNCELLE(KULLANICI param)
        {
            Connect();
            cmd = new SqlCommand("SP_KULLANICI", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PROCESS_TYPE", "GUNCELLE");
            cmd.Parameters.AddWithValue("@KULLANICI_ID", param.KULLANICI_ID);
            cmd.Parameters.AddWithValue("@USERNAME", ToDBNull(param.USERNAME));
            cmd.Parameters.AddWithValue("@SIFRE", ToDBNull(param.SIFRE));
            cmd.Parameters.AddWithValue("@UNVAN", ToDBNull(param.UNVAN));
            cmd.Parameters.AddWithValue("@YETKI", ToDBNull(param.YETKI));
            cmd.Parameters.AddWithValue("@TCK_NO", ToDBNull(param.TCK_NO));
            cmd.Parameters.AddWithValue("@AD", ToDBNull(param.AD));
            cmd.Parameters.AddWithValue("@SOYAD", ToDBNull(param.SOYAD));

            if (cmd.ExecuteNonQuery() >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static List<KULLANICI> KULLANICI_GETIR(KULLANICI param)
        {
            Connect();
            cmd = new SqlCommand("SP_KULLANICI", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PROCESS_TYPE", "GETIR");
            cmd.Parameters.AddWithValue("@KULLANICI_ID", dbnull);
            cmd.Parameters.AddWithValue("@USERNAME", ToDBNull(param.USERNAME));
            cmd.Parameters.AddWithValue("@SIFRE", ToDBNull(param.SIFRE));
            cmd.Parameters.AddWithValue("@UNVAN", ToDBNull(param.UNVAN));
            cmd.Parameters.AddWithValue("@YETKI", ToDBNull(param.YETKI));
            cmd.Parameters.AddWithValue("@TCK_NO", ToDBNull(param.TCK_NO));
            cmd.Parameters.AddWithValue("@AD", ToDBNull(param.AD));
            cmd.Parameters.AddWithValue("@SOYAD", ToDBNull(param.SOYAD));

            SqlDataReader dr = cmd.ExecuteReader();
            List<KULLANICI> list = new List<KULLANICI>();

            while (dr.Read())
            {
                KULLANICI kullanici = new KULLANICI();
                kullanici.KULLANICI_ID = (int)dr["KULLANICI_ID"];
                kullanici.USERNAME = dr["USERNAME"].ToString();
                kullanici.SIFRE = dr["SIFRE"].ToString();
                kullanici.UNVAN = dr["UNVAN"].ToString();
                kullanici.YETKI = dr["YETKI"].ToString();
                kullanici.TCK_NO = dr["TCK_NO"].ToString();
                kullanici.AD = dr["AD"].ToString();
                kullanici.SOYAD = dr["SOYAD"].ToString();

                list.Add(kullanici);
            }
            return list;
        }

        public static bool OGRENCI_EKLE(OGRENCI param)
        {
            Connect();
            cmd = new SqlCommand("SP_OGRENCI", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PROCESS_TYPE", "EKLE");
            cmd.Parameters.AddWithValue("@OGRENCI_ID", dbnull);
            cmd.Parameters.AddWithValue("@OGRENCI_NO", dbnull);
            cmd.Parameters.AddWithValue("@TCK_NO", ToDBNull(param.TCK_NO));
            cmd.Parameters.AddWithValue("@AD", ToDBNull(param.AD));
            cmd.Parameters.AddWithValue("@SOYAD", ToDBNull(param.SOYAD));
            cmd.Parameters.AddWithValue("@DOGUM_TARIHI", ToDBNull(param.DOGUM_TARIHI));
            cmd.Parameters.AddWithValue("@CINSIYET", ToDBNull(param.CINSIYET));
            cmd.Parameters.AddWithValue("@SINIF", ToDBNull(param.SINIF));
            cmd.Parameters.AddWithValue("@DEVAM", ToDBNull(param.DEVAM));
            cmd.Parameters.AddWithValue("@DOSYA_PATH", ToDBNull(param.DOSYA_PATH));

            if (cmd.ExecuteNonQuery() >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool OGRENCI_SIL(OGRENCI param)
        {
            Connect();
            cmd = new SqlCommand("SP_OGRENCI", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PROCESS_TYPE", "SIL");
            cmd.Parameters.AddWithValue("@OGRENCI_ID", dbnull);
            cmd.Parameters.AddWithValue("@OGRENCI_NO", ToDBNull(param.OGRENCI_NO));
            cmd.Parameters.AddWithValue("@TCK_NO", ToDBNull(param.TCK_NO));
            cmd.Parameters.AddWithValue("@AD", ToDBNull(param.AD));
            cmd.Parameters.AddWithValue("@SOYAD", ToDBNull(param.SOYAD));
            cmd.Parameters.AddWithValue("@DOGUM_TARIHI", ToDBNull(param.DOGUM_TARIHI));
            cmd.Parameters.AddWithValue("@CINSIYET", ToDBNull(param.CINSIYET));
            cmd.Parameters.AddWithValue("@SINIF", ToDBNull(param.SINIF));
            cmd.Parameters.AddWithValue("@DEVAM", ToDBNull(param.DEVAM));
            cmd.Parameters.AddWithValue("@DOSYA_PATH", ToDBNull(param.DOSYA_PATH));

            if (cmd.ExecuteNonQuery() >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool OGRENCI_GUNCELLE(OGRENCI param)
        {
            Connect();
            cmd = new SqlCommand("SP_OGRENCI", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PROCESS_TYPE", "GUNCELLE");
            cmd.Parameters.AddWithValue("@OGRENCI_ID", dbnull);
            cmd.Parameters.AddWithValue("@OGRENCI_NO", ToDBNull(param.OGRENCI_NO));
            cmd.Parameters.AddWithValue("@TCK_NO", ToDBNull(param.TCK_NO));
            cmd.Parameters.AddWithValue("@AD", ToDBNull(param.AD));
            cmd.Parameters.AddWithValue("@SOYAD", ToDBNull(param.SOYAD));
            cmd.Parameters.AddWithValue("@DOGUM_TARIHI", ToDBNull(param.DOGUM_TARIHI));
            cmd.Parameters.AddWithValue("@CINSIYET", ToDBNull(param.CINSIYET));
            cmd.Parameters.AddWithValue("@SINIF", ToDBNull(param.SINIF));
            cmd.Parameters.AddWithValue("@DEVAM", ToDBNull(param.DEVAM));
            cmd.Parameters.AddWithValue("@DOSYA_PATH", ToDBNull(param.DOSYA_PATH));

            if (cmd.ExecuteNonQuery() >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static List<OGRENCI> OGRENCI_GETIR(OGRENCI param)
        {
            Connect();
            cmd = new SqlCommand("SP_OGRENCI", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PROCESS_TYPE", "GETIR");
            cmd.Parameters.AddWithValue("@OGRENCI_ID", dbnull);
            cmd.Parameters.AddWithValue("@OGRENCI_NO", ToDBNull(param.OGRENCI_NO));
            cmd.Parameters.AddWithValue("@TCK_NO", ToDBNull(param.TCK_NO));
            cmd.Parameters.AddWithValue("@AD", ToDBNull(param.AD));
            cmd.Parameters.AddWithValue("@SOYAD", ToDBNull(param.SOYAD));
            cmd.Parameters.AddWithValue("@DOGUM_TARIHI", ToDBNull(param.DOGUM_TARIHI));
            cmd.Parameters.AddWithValue("@CINSIYET", ToDBNull(param.CINSIYET));
            cmd.Parameters.AddWithValue("@SINIF", ToDBNull(param.SINIF));
            cmd.Parameters.AddWithValue("@DEVAM", ToDBNull(param.DEVAM));
            cmd.Parameters.AddWithValue("@DOSYA_PATH", ToDBNull(param.DOSYA_PATH));

            SqlDataReader dr = cmd.ExecuteReader();
            List<OGRENCI> list = new List<OGRENCI>();

            while (dr.Read())
            {
                OGRENCI ogrenci = new OGRENCI();

                ogrenci.OGRENCI_ID = (int)dr["OGRENCI_ID"];
                ogrenci.OGRENCI_NO = dr["OGRENCI_NO"].ToString();
                ogrenci.TCK_NO = dr["TCK_NO"].ToString();
                ogrenci.AD = dr["AD"].ToString();
                ogrenci.SOYAD = dr["SOYAD"].ToString();
                ogrenci.DOGUM_TARIHI = Convert.ToDateTime(dr["DOGUM_TARIHI"].ToString()).Date;
                ogrenci.CINSIYET = dr["CINSIYET"].ToString();
                ogrenci.SINIF = dr["SINIF"].ToString();
                ogrenci.DEVAM= dr["DEVAM"].ToString();
                ogrenci.DOSYA_PATH = dr["DOSYA_PATH"].ToString();

                list.Add(ogrenci);
            }
            return list;
        }

        public static bool OGRENCI_DEVAMSIZLIK_EKLE(OGRENCI_DEVAMSIZLIK param)
        {
            Connect();
            cmd = new SqlCommand("SP_OGRENCI_DEVAMSIZLIK", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PROCESS_TYPE", "EKLE");
            cmd.Parameters.AddWithValue("@ID", dbnull);
            cmd.Parameters.AddWithValue("@OGRENCI_ID", param.OGRENCI_ID);
            cmd.Parameters.AddWithValue("@DERS_ID", param.DERS_ID);
            cmd.Parameters.AddWithValue("@TARIH", param.TARIH);

            if (cmd.ExecuteNonQuery() >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool OGRENCI_DEVAMSIZLIK_SIL(OGRENCI_DEVAMSIZLIK param)
        {
            Connect();
            cmd = new SqlCommand("SP_OGRENCI_DEVAMSIZLIK", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PROCESS_TYPE", "SIL");
            cmd.Parameters.AddWithValue("@ID", dbnull);
            cmd.Parameters.AddWithValue("@OGRENCI_ID", param.OGRENCI_ID);
            cmd.Parameters.AddWithValue("@DERS_ID", param.DERS_ID);
            cmd.Parameters.AddWithValue("@TARIH", param.TARIH);

            if (cmd.ExecuteNonQuery() >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static List<OGRENCI_DEVAMSIZLIK> OGRENCI_DEVAMSIZLIK_GETIR(OGRENCI_DEVAMSIZLIK param)
        {
            Connect();
            cmd = new SqlCommand("SP_OGRENCI_DEVAMSIZLIK", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PROCESS_TYPE", "GETIR");
            cmd.Parameters.AddWithValue("@ID", dbnull);
            cmd.Parameters.AddWithValue("@OGRENCI_ID", param.OGRENCI_ID);
            cmd.Parameters.AddWithValue("@DERS_ID", param.DERS_ID);
            cmd.Parameters.AddWithValue("@TARIH", param.TARIH);

            SqlDataReader dr = cmd.ExecuteReader();
            List<OGRENCI_DEVAMSIZLIK> list = new List<OGRENCI_DEVAMSIZLIK>();

            while (dr.Read())
            {
                OGRENCI_DEVAMSIZLIK devamsizlik = new OGRENCI_DEVAMSIZLIK();

                devamsizlik.ID = (int)dr["ID"];
                devamsizlik.OGRENCI_ID = (int)dr["OGRENCI_ID"];
                devamsizlik.DERS_ID = (int)dr["DERS_ID"];
                devamsizlik.TARIH = Convert.ToDateTime(dr["DERS_ID"].ToString()).Date;

                list.Add(devamsizlik);
            }
            return list;
        }

        public static bool DERS_EKLE(DERS param)
        {
            Connect();
            cmd = new SqlCommand("SP_DERS", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PROCESS_TYPE", "EKLE");
            cmd.Parameters.AddWithValue("@DERS_ID", dbnull);
            cmd.Parameters.AddWithValue("@DERS_AD", ToDBNull(param.DERS_AD));
            cmd.Parameters.AddWithValue("@ACIKLAMA", ToDBNull(param.ACIKLAMA));

            if (cmd.ExecuteNonQuery() >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool DERS_SIL(DERS param)
        {
            Connect();
            cmd = new SqlCommand("SP_DERS", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PROCESS_TYPE", "SIL");
            cmd.Parameters.AddWithValue("@DERS_ID", dbnull);
            cmd.Parameters.AddWithValue("@DERS_AD", ToDBNull(param.DERS_AD));
            cmd.Parameters.AddWithValue("@ACIKLAMA", ToDBNull(param.ACIKLAMA));

            if (cmd.ExecuteNonQuery() >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool DERS_GUNCELLE(DERS param)
        {
            Connect();
            cmd = new SqlCommand("SP_DERS", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PROCESS_TYPE", "GUNCELLE");
            cmd.Parameters.AddWithValue("@DERS_ID", param.DERS_ID);
            cmd.Parameters.AddWithValue("@DERS_AD", dbnull);
            cmd.Parameters.AddWithValue("@ACIKLAMA", dbnull);

            if (cmd.ExecuteNonQuery() >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static List<DERS> DERS_GETIR(DERS param)
        {
            Connect();
            cmd = new SqlCommand("SP_DERS", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PROCESS_TYPE", "GETIR");
            cmd.Parameters.AddWithValue("@DERS_ID", dbnull);
            cmd.Parameters.AddWithValue("@DERS_AD", ToDBNull(param.DERS_AD));
            cmd.Parameters.AddWithValue("@ACIKLAMA", ToDBNull(param.ACIKLAMA));

            SqlDataReader dr = cmd.ExecuteReader();
            List<DERS> list = new List<DERS>();

            while (dr.Read())
            {
                DERS ders = new DERS();

                ders.DERS_ID = (int)dr["DERS_ID"];
                ders.DERS_AD = dr["DERS_AD"].ToString();
                ders.ACIKLAMA = dr["ACIKLAMA"].ToString();

                list.Add(ders);
            }
            return list;
        }

        public static string ogrNoGetir()
        {
            Connect();
            cmd = new SqlCommand("SP_OGRENCI", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PROCESS_TYPE", "OGRENCI_NO");
            cmd.Parameters.AddWithValue("@OGRENCI_ID", dbnull);
            cmd.Parameters.AddWithValue("@OGRENCI_NO", dbnull);
            cmd.Parameters.AddWithValue("@TCK_NO", dbnull);
            cmd.Parameters.AddWithValue("@AD", dbnull);
            cmd.Parameters.AddWithValue("@SOYAD", dbnull);
            cmd.Parameters.AddWithValue("@DOGUM_TARIHI", dbnull);
            cmd.Parameters.AddWithValue("@CINSIYET", dbnull);
            cmd.Parameters.AddWithValue("@SINIF", dbnull);
            cmd.Parameters.AddWithValue("@DEVAM", dbnull);
            cmd.Parameters.AddWithValue("@DOSYA_PATH", dbnull);

            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            string ogr_no = string.Format("{0}", Convert.ToInt32(dr["OGRENCI_NO"]).ToString("D4")); ;


            return ogr_no;
        }
    }
}
