using System;
using System.Windows.Forms;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;



namespace Market
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }
        private void AnaMenu_Load(object sender, EventArgs e)
        {
            tmTime.Start();
            lblNickName.Text = Hesap.nickname;
            lblZaman.Text = " Saat =" + DateTime.Now.Hour.ToString();
            lblZaman.Text += "." + DateTime.Now.Minute.ToString();
            if (Hesap.nickname != "admin")
            {
                gbKasiyer.Visible = false;
                gbUrun.Visible = false;
            }
        }
        private void btnKasiyerIslem_Click(object sender, EventArgs e)
        {
            if (Hesap.nickname == "admin")
            {
                KasiyerIslemleri kasiyerIslemleri = new KasiyerIslemleri();
                kasiyerIslemleri.ShowDialog();
            }
        }
        private void btnPrimGor_Click(object sender, EventArgs e)
        {
            if (Hesap.nickname != "admin")
            {
                DataBase db = new DataBase();
                db.kullaniciAdi = Hesap.nickname;
                MessageBox.Show("primin = " +Hesap.primi);
            }
            else
            {
                Prim prim = new Prim();
                prim.ShowDialog();
            }

        }
        private void btnGunSonu_Click(object sender, EventArgs e)
        {
            Gun gunSonu = new Gun();
            gunSonu.ShowDialog();
        }
        private void btnUrunIslem_Click_1(object sender, EventArgs e)
        {
            if (Hesap.nickname == "admin")
            {
                Urun urunIslemleri = new Urun();
                urunIslemleri.ShowDialog();
            }
        }
        private void btnSatis_Click(object sender, EventArgs e)
        {
            DateTime suan = DateTime.Now;
            if (suan.Hour < 21 && suan.Hour > 9 || Hesap.nickname == "admin")
            {
                SatOrIade satOrIade = new SatOrIade();
                satOrIade.ShowDialog();
                this.Hide();
            }
            else
                MessageBox.Show("Saat 9 u geçtiği için satış yapamazsınız mesainiz bitmiştir.", "MESAİ BİTTİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnKapa_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show("Kasayı Kapatmak istiyormusunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    Application.Exit();
                }             
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); ;
            }

        }
        Random random = new Random();
        private void AnaMenu_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        int sayac = 0;
        private void tmTime_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 59)
            {
                sayac = 0;
                lblZaman.Text = " Saat =" + DateTime.Now.Hour.ToString();
                lblZaman.Text += "." + DateTime.Now.Minute.ToString();
            }
        }
    }
}
