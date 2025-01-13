using System;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;


namespace Market
{
    public partial class Sifre : Form
    {
        public Sifre()
        {
            InitializeComponent();
        }
        bool sifre = false;
        string harfler = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZQW0123456789", kod = "";
        char[] Harfler;

        Random random = new Random();
        DataBase db = new DataBase();
        int onay;
        private void Sifre_Load(object sender, EventArgs e)
        {
            Harfler = harfler.ToCharArray();
            for (int i = 0; i < 6; i++)
            {
                kod += Harfler[random.Next(0, Harfler.Length)];
            }
        }
        private void btnMail_Click(object sender, EventArgs e)
        {
            db.mail = txtPosta.Text;
            db.Reader("Şifre");           
            MailMessage mesajım = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new NetworkCredential("hasan.samil.2009@gmail.com", "Hasansio12345..");
            istemci.Port = 587;
            istemci.Host = "pro.turbo-smtp.com";
            istemci.EnableSsl = true;
            onay = random.Next(18622, 98743);
            mesajım.From = new MailAddress("hasan.samil.2009@gmail.com");
            mesajım.To.Add(Hesap.mail);
            mesajım.Subject = "Şifre";
            mesajım.IsBodyHtml = true;

            mesajım.Body = "Sayın " +Hesap.ad + " şifrenizi değiştirmek için kodunuz = " + kod;
            try
            {
                istemci.Send(mesajım);
                MessageBox.Show("Şifre sıfırlamaak için E-postanız gönderilmiştir.","GÖNDERİLDİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                btnOnay.Enabled = true;
                txtOnay.Enabled = true;
                btnMail.Enabled = false;
                txtPosta.Enabled = false;
                tmOnayKodu.Start();
            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex.Message);
            }


        }
        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            if (control())
            {
                db.Sifre = txtSifreTekrar.Text;
                db.EkleSilGuncelle("güncelle", "kasiyerŞifre");
                MessageBox.Show("Şifreniz Başarıyla Güncellenmiştir","BAŞARILI",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("şifreler uyuşmuyor", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            control();
        }
        private void txtSifreTekrar_TextChanged(object sender, EventArgs e)
        {
            control();
        }
        private bool control()
        {
            if (txtSifre.Text != txtSifreTekrar.Text)
            {
                lblSifre.Text = "sifreler aynı değil";
                sifre = false;
            }
            else
            {
                sifre = true;
                lblSifre.Text = "";
            }
            return sifre;
        }
        int saniye=60;
        private void tmOnayKodu_Tick(object sender, EventArgs e)
        {
            
            saniye--;
            lblTimer.Text = saniye.ToString();
            if (saniye==0)
            {
                saniye = 60;
                btnMail.Visible =txtPosta.Visible= true;
                tmOnayKodu.Stop();
            }
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            if (txtOnay.Text == kod)
                tabl.SelectTab(tabPage2);
            else
            {               
                MessageBox.Show("onay kodunuz yanlış", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
    }
}
