using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Bcpg;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Collections;

namespace Market
{
    public class DataBase
    {
        //kasiyer----------------------------------//
        public int ID { get; set; }
        public int satisID { get; set; }
        public string kullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string mail { get; set; }
        public double prim { get; set; }
        //kasiyer--------------------------------//

        //iade--------------------------------//
        public double tutar { get; set; }
        public bool kart { get; set; }

        public string aciklama { get; set; }
        //iaade-----------------------------//

        //ürün-----------------------------//
        public int kalanStok { get; set; }
        public int Aded { get; set; }
        public string barkod { get; set; }
        public string urunAd { get; set; }
        public int stok { get; set; }
        public string Kategori { get; set; }
        public int kategoriID { get; set; }
        public string Marka { get; set; }
        public int MarkaID { get; set; }
        public double fiyat { get; set; }
        public string sorgu;
        bool durum = false;
        ArrayList array = new ArrayList();
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
        string conn = "Server = DESKTOP-MNHUR28;Database=kasa;Trusted_Connection=True;";
        private void sifirla()
        {
            Aded = 0;
            barkod = null;
            urunAd = null;
            stok = 0;
            fiyat = 0;
            Marka = null;
            ID = 0;
            kullaniciAdi = null;
            Sifre = null;
            ad = null;
            soyad = null;
            mail = null;
            prim = 0;
            tutar = 0;
            kart = true;
            aciklama = null;
        }
        private SqlConnection Baglan()
        {
            SqlConnection cnn = new SqlConnection(conn);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            return cnn;

        }
        public bool kasiyerEkleGuncelle(string kullanici, int ID, string ekle)
        {
            bool duru = true;
            if (ekle == "ekle")
            {
                sorgu = "select * from tblkasiyer where kasiyerKullaniciAdi=@ad";
                cmd = new SqlCommand(sorgu, Baglan());
                cmd.Parameters.AddWithValue("@ad", kullanici);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    duru = false;
                }
            }
            else
            {
                sorgu = "select * from tblkasiyer where kasiyerKullaniciAdi=@ad";
                cmd = new SqlCommand(sorgu, Baglan());
                cmd.Parameters.AddWithValue("@ad", kullanici);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (ID != (int)dr[0])
                    {
                        duru = false;
                    }
                }
            }
            sifirla();
            dr.Close();
            Baglan().Close();
            return duru;
        }
        public ArrayList kategori(string tablo)
        {
            sorgu = "select * from " + tablo;
            cmd = new SqlCommand(sorgu, Baglan());
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                array.Add(dr[1].ToString());
            }
            sifirla();
            Baglan().Close();
            return array;
        }
        public void kassil(string secilen)
        {
            if (secilen == "kasiyerSilSat")
            {
                sorgu = "select * from tblsatis where satisKim=@Kim";
                cmd = new SqlCommand(sorgu, Baglan());
                cmd.Parameters.AddWithValue("@Kim", ID);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    satisID = (int)dr[0];
                    EkleSilGuncelle("güncelle", "kasiyerSatisSil");
                }
            }
            else if (secilen == "kasiyerSilİade")
            {
                sorgu = "select * from tblsatis where satisKim=@Kim";
                cmd = new SqlCommand(sorgu, Baglan());
                cmd.Parameters.AddWithValue("@Kim", ID);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    satisID = (int)dr[0];
                    EkleSilGuncelle("güncelle", "kasiyerİadeSil");
                }
            }
        }
        public bool Reader(string secilen)
        {
            durum = false;
            if (secilen == "Giriş")
            {
                sorgu = "Select * from tblkasiyer where kasiyerKullaniciAdi=@mail AND kasiyerSifre=@parola";
                cmd = new SqlCommand(sorgu, Baglan());
                cmd.Parameters.AddWithValue("@mail", mail);
                cmd.Parameters.AddWithValue("@parola", Sifre);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Hesap.ID =(int)dr[0];
                    Hesap.nickname = dr[1].ToString();
                    Hesap.sifre = dr[2].ToString();
                    Hesap.ad = dr[3].ToString();
                    Hesap.primi = double.Parse(dr[5].ToString());
                }
            }
            else if (secilen == "kasiyerSil")
            {
                sorgu = "select * from tblkasiyer where kasiyerKullaniciAdi=@Kim";
                cmd = new SqlCommand(sorgu, Baglan());
                cmd.Parameters.AddWithValue("@Kim", kullaniciAdi);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ID = (int)dr[0];
                    kassil("kasiyerSilSat");
                    kassil("kasiyerSilİade");
                }
            }

            else if (secilen == "prim")
            {
                sorgu = "select * from tblkasiyer where kasiyerKullaniciAdi=@ad";
                cmd = new SqlCommand(sorgu, Baglan());
                cmd.Parameters.AddWithValue("@ad", kullaniciAdi);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Hesap.primi = (double)dr["kaiyerPrim"];
                }
            }
            else if (secilen == "Şifre")
            {
                sorgu = "Select * from tblkasiyer where kasiyerKullaniciAdi=@mail";
                cmd = new SqlCommand(sorgu, Baglan());
                cmd.Parameters.AddWithValue("@mail", mail);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Hesap.nickname = dr[1].ToString();
                    Hesap.sifre = dr[2].ToString();
                    Hesap.ad = dr[3].ToString();
                    Hesap.mail = dr[4].ToString();
                }
            }
            else if (secilen == "Prim")
            {
                sorgu = "SELECT * FROM tblkasiyer WHERE kasiyerKullaniciAdi=@ad";
                cmd = new SqlCommand(sorgu, Baglan());
                cmd.Parameters.AddWithValue("@ad", Hesap.nickname);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    prim += double.Parse(dr[5].ToString());
                }
                EkleSilGuncelle("güncelle", "kasiyerPrim");

            }
            else if (secilen == "İade")
            {
                sorgu = "SELECT * FROM tbluruns WHERE urunBarkod=@barkod";
                cmd = new SqlCommand(sorgu, Baglan());
                cmd.Parameters.AddWithValue("@barkod", barkod);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MarkaID = (int)dr["urunMarka"];
                    kategoriID = (int)dr["urrunKategori"];
                    SatisIade.isim = dr["urunAd"].ToString();
                    SatisIade.UrunFiyat = double.Parse(dr["urunFiyat"].ToString());
                    SatisIade.UrunStok = int.Parse(dr["urunStok"].ToString());

                    durum = true;
                }
            }
            if (!dr.IsClosed)
            {
                dr.Close();
            }
            Baglan().Close();
            if (durum)
            {
                bulucuString("Kategori");
                bulucuString("Marka");
            }
            sifirla();
            return durum;
        }
        private string bulucuString(string ad)
        {
            string bulucu = "";
            if (ad == "Kategori")
            {
                sorgu = "select * from tblkategori where kategoriID=@Adi";
                cmd = new SqlCommand(sorgu, Baglan());
                cmd.Parameters.AddWithValue("@Adi", kategoriID);

            }
            else
            {
                sorgu = "select * from tblmarka where markaID=@Adi";
                cmd = new SqlCommand(sorgu, Baglan());
                cmd.Parameters.AddWithValue("@Adi", MarkaID);
            }
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (ad == "Kategori")
                    SatisIade.Kategori = dr[1].ToString();
                else
                    SatisIade.umarka = dr[1].ToString();
                dr.Close();
            }
            if (!dr.IsClosed)
            {
                dr.Close();
            }
            return bulucu;
        }
        private int bulucuInt(string ad)
        {
            int bulucu = 0;
            if (ad == "Kategori")
            {
                sorgu = "select * from tblkategori where kategoriAd=@Adi";
                cmd = new SqlCommand(sorgu, Baglan());
                cmd.Parameters.AddWithValue("@Adi", Kategori);

            }
            else
            {
                sorgu = "select * from tblmarka where markaAd=@Adi";
                cmd = new SqlCommand(sorgu, Baglan());
                cmd.Parameters.AddWithValue("@Adi", Marka);
            }
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                bulucu = (int)dr[0];
                dr.Close();
            }
            if (!dr.IsClosed)
            {
                dr.Close();
            }
            return bulucu;
        }
        public DataTable TabloGetir(string secilen)
        {
            if (secilen == "iade")
            {
                sorgu = @"
                SELECT 
                    tbliade.iadeID, 
                    tblkasiyer.kasiyerKullaniciAdi,
                    tbliade.iadeNeKadar, 
                    tbliade.iadeTarih, 
                    tbliade.iadeAciklamasi, 
                    tblnakitorkart.KartNakit,
                    tbliade.iadeNakit, 
                    tbliade.iadeKim
                    
                FROM 
                    tbliade
                JOIN 
                    tblkasiyer ON tbliade.iadeKim = tblkasiyer.kasiyerID
                JOIN 
                    tblnakitorkart ON tbliade.iadeNakit = tblnakitorkart.ID;";
            }
            else if (secilen == "satis")
            {

                sorgu = @"
                SELECT 
                    tblsatis.satisID, 
                    tblkasiyer.kasiyerKullaniciAdi,
                    tblsatis.satisNeKadar, 
                    tblsatis.satisTarih, 
                    tblsatis.satisAciklamasi, 
                    tblnakitorkart.KartNakit,
                    tblsatis.satisNakit, 
                    tblsatis.satisKim
                    
                FROM 
                    tblsatis
                JOIN 
                    tblkasiyer ON tblsatis.satisKim = tblkasiyer.kasiyerID
                JOIN 
                    tblnakitorkart ON tblsatis.satisNakit = tblnakitorkart.ID;";
            }
            else if (secilen == "urun")
            {
                sorgu = @"
                SELECT 
                    tbluruns.urunID, 
                    tbluruns.urunBarkod, 
                    tblkategori.kategoriAd,
                    tblmarka.markaAd,
                    tbluruns.urrunKategori, 
                    tbluruns.urunMarka, 
                    tbluruns.urunAd, 
                    tbluruns.urunFiyat,
                    tbluruns.urunStok,
                    tbluruns.urunSorgusu
                    
                FROM 
                    tbluruns
                JOIN 
                    tblkategori ON tbluruns.urrunKategori = tblkategori.kategoriID
                JOIN 
                    tblmarka ON tbluruns.urunMarka = tblmarka.markaID;";
            }
            else
            {
                sorgu = "SELECT * from " + secilen;
            }



            dt = new DataTable();
            da = new SqlDataAdapter(sorgu, Baglan());
            da.Fill(dt);
            Baglan().Close();
            sifirla();
            return dt;

        }
        
        public bool EkleSilGuncelle(string EGS, string KUSI)
        {

            if (EGS == "ekle")
            {
                if (KUSI == "kasiyer")
                {
                    sorgu = "INSERT INTO tblKasiyer(kasiyerKullaniciAdi,kasiyerSifre,kasiyerAdSoyad,kasiyerMail)" + "VALUES(@kullaniciAd,@sifre,@adi,@tel)";
                    cmd = new SqlCommand(sorgu, Baglan());
                    cmd.Parameters.AddWithValue("@kullaniciAd", kullaniciAdi);
                    cmd.Parameters.AddWithValue("@sifre", Sifre);
                    cmd.Parameters.AddWithValue("@adi", ad);
                    cmd.Parameters.AddWithValue("@tel", mail);
                }
                else if (KUSI == "ürün")
                {
                    Kategori = bulucuInt("Kategori").ToString();
                    Marka = bulucuInt("marka").ToString();
                    sorgu = "INSERT INTO tbluruns(urunBarkod,urrunKategori,urunMarka,urunAd,urunFiyat,urunStok,urunSorgusu)" + "Values(@barkod,@kategori,@marka,@ad,@fiyat,@stok,@sorgu)";
                    cmd = new SqlCommand(sorgu, Baglan());
                    cmd.Parameters.AddWithValue("@barkod", barkod);
                    cmd.Parameters.AddWithValue("@kategori", int.Parse(Kategori));
                    cmd.Parameters.AddWithValue("@marka", int.Parse(Marka));
                    cmd.Parameters.AddWithValue("@ad", urunAd);
                    cmd.Parameters.AddWithValue("@fiyat", fiyat);
                    cmd.Parameters.AddWithValue("@stok", stok);
                    if (stok > 0)
                        cmd.Parameters.AddWithValue("@sorgu", "1");
                    else
                        cmd.Parameters.AddWithValue("@sorgu", "0");
                }
                else if (KUSI == "iade")
                {
                    sorgu = "INSERT INTO tbliade(iadeNeKadar,iadeTarih,iadeKim,iadeAciklamasi,iadeNakit)" + "VALUES(@nakit,@tarih,@kim,@acikla,@durum)";
                    cmd = new SqlCommand(sorgu, Baglan());
                    cmd.Parameters.AddWithValue("@nakit", tutar);
                    cmd.Parameters.AddWithValue("@tarih", DateTime.Now);
                    cmd.Parameters.AddWithValue("@kim", Hesap.ID);
                    cmd.Parameters.AddWithValue("@acikla", aciklama);
                    if (kart)
                        cmd.Parameters.AddWithValue("@durum", 1);
                    else
                        cmd.Parameters.AddWithValue("@durum", 2);
                }
                else if (KUSI == "sat")
                {
                    sorgu = "INSERT INTO tblsatis(satisNeKadar,satisTarih,satisKim,satisAciklamasi,satisNakit)" + "VALUES(@nakit,@tarih,@kim,@acikla,@durum)";
                    cmd = new SqlCommand(sorgu, Baglan());
                    cmd.Parameters.AddWithValue("nakit", tutar);
                    cmd.Parameters.AddWithValue("tarih", DateTime.Now);
                    cmd.Parameters.AddWithValue("kim", Hesap.ID);
                    cmd.Parameters.AddWithValue("acikla", aciklama);
                    if (kart)
                        cmd.Parameters.AddWithValue("durum", 1);
                    else
                        cmd.Parameters.AddWithValue("durum", 2);
                }
            }
            else if (EGS == "güncelle")
            {
                if (KUSI == "kasiyer")
                {

                    sorgu = "UPDATE tblKasiyer SET kasiyerKullaniciAdi=@kullanici , kasiyerSifre=@sifre , kasiyerAdSoyad=@ad ,kasiyerMail=@tel " + "WHERE kasiyerID=@ıd";
                    cmd = new SqlCommand(sorgu, Baglan());
                    cmd.Parameters.AddWithValue("@ıd", ID);
                    cmd.Parameters.AddWithValue("@kullanici", kullaniciAdi);
                    cmd.Parameters.AddWithValue("@sifre", Sifre);
                    cmd.Parameters.AddWithValue("@ad", ad);
                    cmd.Parameters.AddWithValue("@tel", mail);



                }
                else if (KUSI == "kasiyerPrim")
                {
                    sorgu = "update tblkasiyer set kasiyerPrim=@prim where kasiyerKullaniciAdi=@ad";
                    cmd = new SqlCommand(sorgu, Baglan());
                    cmd.Parameters.AddWithValue("@ad", Hesap.nickname);
                    cmd.Parameters.AddWithValue("@prim", prim);
                }
                else if (KUSI == "kasiyerŞifre")
                {
                    sorgu = "UPDATE tblKasiyer SET  kasiyerSifre=@sifre  " + "WHERE  kasiyerKullaniciAdi=@kullanici";
                    cmd = new SqlCommand(sorgu, Baglan());
                    cmd.Parameters.AddWithValue("@kullanici", Hesap.nickname);
                    cmd.Parameters.AddWithValue("@sifre", Sifre);
                }
                else if (KUSI == "ürün")
                {
                    Kategori = bulucuInt("Kategori").ToString();
                    Marka = bulucuInt("marka").ToString();
                    sorgu = "update tbluruns set urunBarkod=@barkod,urrunKategori=@kategori,urunMarka=@marka,urunAd=@ad,urunFiyat=@fiyat,urunStok=@stok,urunSorgusu=@sorgu where urunID=@ID";
                    cmd = new SqlCommand(sorgu, Baglan());
                    cmd.Parameters.AddWithValue("@ID",ID);
                    cmd.Parameters.AddWithValue("@barkod", barkod);
                    cmd.Parameters.AddWithValue("@kategori", Kategori);
                    cmd.Parameters.AddWithValue("@marka", Marka);
                    cmd.Parameters.AddWithValue("@ad", urunAd);
                    cmd.Parameters.AddWithValue("@fiyat", fiyat);
                    cmd.Parameters.AddWithValue("@stok", stok);
                    if (stok > 0)
                        cmd.Parameters.AddWithValue("@sorgu", 1);
                    else
                        cmd.Parameters.AddWithValue("@sorgu", 0);
                }
                else if (KUSI == "SAT")
                {
                    sorgu = "UPDATE tbluruns SET urunStok=@stok , urunSorgusu=@sorgu " + "WHERE urunBarkod=@barkod";
                    cmd = new SqlCommand(sorgu, Baglan());
                    cmd.Parameters.AddWithValue("barkod", barkod);
                    if (kalanStok > 0)
                    {
                        cmd.Parameters.AddWithValue("sorgu", "1");
                        cmd.Parameters.AddWithValue("stok", kalanStok);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("sorgu", "0");
                        cmd.Parameters.AddWithValue("stok", 0);
                    }
                }

                else if (KUSI == "ürünIade")
                {
                    sorgu = "UPDATE tbluruns SET urunBarkod=@barkod , urunStok=@stok , urunSorgusu=@sorgu " + "WHERE urunBarkod=@barkod";
                    cmd = new SqlCommand(sorgu, Baglan());
                    cmd.Parameters.AddWithValue("@barkod", barkod);
                    cmd.Parameters.AddWithValue("@stok", Aded);
                    cmd.Parameters.AddWithValue("@sorgu", 1);
                }
                else if (KUSI == "kasiyerSatisSil")
                {
                    sorgu = "UPDATE tblsatis SET satisKim=@satis WHERE satisID=@ıd";
                    cmd = new SqlCommand(sorgu, Baglan());
                    cmd.Parameters.AddWithValue("ıd", satisID);
                    cmd.Parameters.AddWithValue("@satis", 1);

                }
                else if (KUSI == "kasiyerİadeSil")
                {
                    sorgu = "UPDATE tbliade SET satisKim=@satis WHERE satisID=@ıd";
                    cmd = new SqlCommand(sorgu, Baglan());
                    cmd.Parameters.AddWithValue("ıd", satisID);
                    cmd.Parameters.AddWithValue("@satis", 1);
                }
            }
            else if (EGS == "sil")
            {
                if (KUSI == "kasiyer")
                {
                    sorgu = "DELETE FROM tblKasiyer WHERE kasiyerKullaniciAdi=@ad";
                    cmd = new SqlCommand(sorgu, Baglan());
                    cmd.Parameters.AddWithValue("@ad", kullaniciAdi);
                }
                else if (KUSI == "ürün")
                {
                    sorgu = "delete from tbluruns where urunBarkod=@barkod";
                    cmd = new SqlCommand(sorgu, Baglan());
                    cmd.Parameters.AddWithValue("@barkod", barkod);
                }
            }

            if (cmd.ExecuteNonQuery() > 0)
            {
                durum = true;
            }
            Baglan().Close();
            sifirla();
            return durum;
        }
    }
}