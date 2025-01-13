using System;
using System.Windows.Forms;

namespace Market
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        DataBase db=new DataBase();
        private void btnGir_Click(object sender, EventArgs e)
        {
            


            db.mail=txtAd.Text;
            db.Sifre=txtSifre.Text;
            db.Reader("Giriş");
            if (Hesap.nickname != null)
            {
                MessageBox.Show("Giriş Başarılı","BAŞARILI",MessageBoxButtons.OK,MessageBoxIcon.Information);
                AnaMenu anaMenu = new AnaMenu();
                anaMenu.Show();
                this.Hide();
            }
            else { MessageBox.Show("Giriş Başarısız", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void lblSifre_Click(object sender, EventArgs e)
        {
            Sifre sifre = new Sifre();
            sifre.ShowDialog();
        }
    }
}
