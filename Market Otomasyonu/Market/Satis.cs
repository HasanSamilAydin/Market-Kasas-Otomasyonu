using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using System.Collections;
using System.Media;
using System.Threading;
using Org.BouncyCastle.Crypto.Generators;

namespace Market
{
    public partial class Satis : Form
    {
        public Satis()
        {
            InitializeComponent();
        }
        double tutar;

        FilterInfoCollection fico;
        VideoCaptureDevice vcd;

        List<Sat> list = new List<Sat>();

        private void Satis_FormClosed(object sender, FormClosedEventArgs e)
        {
            AnaMenu anaMenu = new AnaMenu();
            anaMenu.Show();
        }
        private void tpFis_Click(object sender, EventArgs e)
        {

        }

        private void rbNakit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKart.Checked)
            {
                gbNakit.Visible = false;
            }
            else
            {
                gbNakit.Visible = true;
            }
        }

        private void Satis_Load(object sender, EventArgs e)
        {
            fico = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo item in fico)
            {
                cbEkle.Items.Add(item.Name);
            }
            cbEkle.SelectedIndex = 0;
            vcd = new VideoCaptureDevice(fico[cbEkle.SelectedIndex].MonikerString);
            vcd.NewFrame += Vcd_NewFrame;
            vcd.Start();
            timerCam.Start();
        }


        private void timerCam_Tick(object sender, EventArgs e)
        {
            try
            {
                if (pbCamEkle.Image != null)
                {
                    BarcodeReader brd = new BarcodeReader();
                    Result sonuc = brd.Decode((Bitmap)pbCamEkle.Image);
                    if (sonuc != null)
                    {
                        SoundPlayer ses = new SoundPlayer();
                        ses.SoundLocation = "bep.wav";
                        ses.Play();
                        Thread.Sleep(1000);
                        string barkod = sonuc.ToString();
                        if (rbEkle.Checked)
                            ekle(barkod);
                        else
                            sil(barkod);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex.Message);
            }

        }
        private void btnBitir_Click_1(object sender, EventArgs e)
        {
            lblPara.Text = "" + tutar;
            tcSatis.SelectTab(tpFis);
        }

        private void pSat_Click(object sender, EventArgs e)
        {
        }
        private void Vcd_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                pbCamEkle.Image = (Bitmap)eventArgs.Frame.Clone();
            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex.Message);
            }

        }
        DataBase db = new DataBase();
        private void btnBitti_Click(object sender, EventArgs e)
        {
            string aciklama = "";
            foreach (var item in list)
            {
                aciklama = aciklama + item.kategori + " " + item.marka + " " + item.ad + " Adet=" + item.cikAdet + "      " + item.fiyat;
            }
            try
            {
                foreach (var sat in list)
                {
                    db.barkod = sat.barkod;
                    db.kalanStok = sat.aded;
                    db.EkleSilGuncelle("güncelle", "SAT");
                }
                db.prim = tutar / 100;
                db.Reader("Prim");

                db.aciklama = aciklama;
                db.kart = rbKart.Checked;
                db.tutar = tutar;
                db.EkleSilGuncelle("ekle", "sat");
                MessageBox.Show("Satıldı", "OLDU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                AnaMenu menu = new AnaMenu();
                menu.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }





        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {

            lblVerilecek.Text = (tutar - double.Parse(txtFiyat.Text)).ToString();
        }
        private void UpdateListBox()
        {
            lbFis.Items.Clear();
            foreach (var item in list)
            {
                if (item.cikAdet > 0)
                {
                    lbFis.Items.Add(item.kategori + " " + item.marka + " " + item.ad + " Adet=" + item.cikAdet + "  " + item.fiyat + "TL");
                }

            }
        }
        public void sil(string barkod)
        {
            try
            {
                foreach (var item in list)
                {
                    if (item.barkod == barkod)
                    {

                        if (item.cikAdet <= 0)
                        {
                            MessageBox.Show("olmaaaz");
                        }
                        else
                        {
                            item.cikAdet = item.cikAdet - int.Parse(txtAded.Text);
                            item.fiyat -= item.urunFiyat * int.Parse(txtAded.Text);
                            item.aded += int.Parse(txtAded.Text);
                            tutar -= item.urunFiyat * int.Parse(txtAded.Text);
                            if (item.fiyat <= 0)
                            {
                                list.Remove(item);
                            }


                        }

                        break;
                    }
                }
                UpdateListBox();
            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex.Message);
            }

        }

        public void ekle(string barko)
        {
            double ToplamFiyat = 0;
            double UrunFiyat;
            int UrunStok;
            string isim;
            string Umarka;
            string kategori;
            bool durum = false;
            bool varmi = false;
            try
            {

                int cikAded = int.Parse(txtAded.Text);
                foreach (var sat1 in list)
                {
                    if (sat1.barkod == barko)
                    {
                        varmi = true;
                        double den = sat1.fiyat;
                        if (sat1.aded - cikAded >= 0)
                        {
                            sat1.aded -= cikAded;
                            sat1.cikAdet += cikAded;
                            sat1.fiyat += sat1.urunFiyat * cikAded;
                            tutar += sat1.urunFiyat * cikAded;
                        }
                        else
                        {
                            MessageBox.Show("Bu Ürünün Bu Kadar Fazla Stoğu Yok", "YOK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                if (varmi == false)
                {
                    db.Aded = cikAded;
                    db.barkod = barko;
                    durum = db.Reader("İade");


                    kategori = SatisIade.Kategori;
                    Umarka = SatisIade.umarka;
                    isim = SatisIade.isim;
                    UrunFiyat = SatisIade.UrunFiyat;
                    ToplamFiyat = UrunFiyat * cikAded;
                    UrunStok = SatisIade.UrunStok;
                    if (durum)
                    {
                        if (UrunStok - cikAded >= 0)
                        {
                            Sat sat = new Sat
                            {
                                urunFiyat = UrunFiyat,
                                kategori = kategori,
                                cikAdet = int.Parse(txtAded.Text),
                                barkod = barko,
                                marka = Umarka,
                                ad = isim,
                                fiyat = ToplamFiyat,
                                aded = UrunStok - cikAded

                            };
                            tutar += ToplamFiyat;
                            list.Add(sat);

                        }

                    }
                    else
                    {
                        MessageBox.Show("böyle Bir Ürün Yok");
                    }

                }
                UpdateListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtUrunBarkodu.Text != "")
            {
                if (rbEkle.Checked)
                {
                    ekle(txtUrunBarkodu.Text);
                }
                else
                {
                    if (txtAded.Text != null)
                    {
                        if (int.Parse(txtAded.Text) != 0)
                        {
                            sil(txtUrunBarkodu.Text);
                        }
                        else
                        {
                            MessageBox.Show("Üründen 0 Tane Almak Nedir Cimri", "Cimri", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Bak Şu Adet Kısmını Boş Bırakma Ağızının Şalağına Bi Tane Koyarım Ha!", "Mal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                txtUrunBarkodu.Text = "";


            }



        }


        private void rbKart_Click(object sender, EventArgs e)
        {
        }
        private void Satis_FormClosing(object sender, FormClosingEventArgs e)
        {
            vcd.Stop();
            timerCam.Stop();

        }

        private void rbSil_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEkle.Checked)
            {
                btnEkle.Text = "Ekle";
            }
            else
            {
                btnEkle.Text = "Sil";
            }
        }

        private void lbFis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
