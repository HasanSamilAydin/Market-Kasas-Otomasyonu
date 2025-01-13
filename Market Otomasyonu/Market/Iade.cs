using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using ZXing;
namespace Market
{
    public partial class Iade : Form
    {
        public Iade()
        {
            InitializeComponent();
        }

        double tutar;
        bool denemee;
        DataBase db = new DataBase();


        FilterInfoCollection fico;
        VideoCaptureDevice vcd;

        List<ClssIade> list = new List<ClssIade>();
        ArrayList array = new ArrayList();
        Dictionary<string, int> deneme = new Dictionary<string, int>();
        private void pSat_Click(object sender, EventArgs e)
        {
        }
        public void sil(string barkod)
        {
            try
            {
                foreach (var item in list)
                {
                    if (item.barkod == barkod)
                    {
                        item.cikAdet -= int.Parse(txtAded.Text);
                        item.fiyat -= int.Parse(txtAded.Text) * item.urunFiyat;
                        tutar -= int.Parse(txtAded.Text)*item.urunFiyat;
                        if (item.cikAdet <= 0)
                        {
                            list.Remove(item);
                        }
                        UpdateListBox();
                        break;
                    }
                }
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
            bool durum;
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
                        sat1.aded -= cikAded;
                        sat1.cikAdet += cikAded;
                        sat1.fiyat += cikAded * sat1.urunFiyat;
                        tutar += cikAded*sat1.urunFiyat;
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
                    ToplamFiyat = ToplamFiyat + (UrunFiyat * cikAded);
                    UrunStok = SatisIade.UrunStok;
                    if (durum)
                    {
                        if (UrunStok - cikAded >= 0)
                        {
                            ClssIade sat = new ClssIade
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

        private void UpdateListBox()
        {
            lbFis.Items.Clear();
            foreach (var item in list)
            {
                lbFis.Items.Add(item.kategori + "  " + item.marka + " " + item.ad + " Adet=" + item.cikAdet + " " + item.fiyat + "TL");
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
                    sil(txtUrunBarkodu.Text);
                }
                txtUrunBarkodu.Text = "";


            }
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            lblPara.Text = "" + tutar;
            tcSatis.SelectTab(tpFis);
        }

        private void rbEkle_CheckedChanged(object sender, EventArgs e)
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



        private void Iade_FormClosing(object sender, FormClosingEventArgs e)
        {
            vcd.Stop();
            timerCam.Stop();
            AnaMenu menu = new AnaMenu();
            menu.Show();

        }

        private void Iade_Load(object sender, EventArgs e)
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

        private void Vcd_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
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
                        MessageBox.Show(barkod);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex.Message);
            }
        }

        private void rbNakit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKart.Checked)
            {
                gbNakit.Visible = false;
                gbKart.Visible = true;
            }
            else
            {
                gbNakit.Visible = true; gbKart.Visible = false;
            }
        }

        private void btnBitti_Click(object sender, EventArgs e)
        {
            string aciklama = "";
            foreach (var item in list)
            {
                aciklama = aciklama + item.kategori + " " + item.marka + " " + item.ad + " Adet=" + item.cikAdet + " " + item.fiyat;
            }

            if (!rbKart.Checked)
                db.kart = false;
            else
                db.kart = true;

            for (int i = 0; i < list.Count; i++)
            {
                ClssIade sat = (ClssIade)list[i];
                try
                {
                    db.barkod = sat.barkod;
                    db.Aded = sat.aded + sat.cikAdet;
                    db.EkleSilGuncelle("güncelle", "ürünIade");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.Message);
                }
            }
            db.tutar = tutar;
            db.aciklama = aciklama;

            db.EkleSilGuncelle("ekle", "iade");


        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                double sonuc = tutar- double.Parse(txtFiyat.Text) ;
                if (sonuc < 0)
                {
                    MessageBox.Show("Bu Para Yetmez Daha Fazla Ver Lan", (sonuc * -1).ToString() + "TL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    lblVerilecek.Text = sonuc.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
