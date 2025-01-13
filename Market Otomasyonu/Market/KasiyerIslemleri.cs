using Google.Protobuf.WellKnownTypes;
using MaterialSkin.Controls;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Market
{
    public partial class KasiyerIslemleri : Form
    {
        public KasiyerIslemleri()
        {
            InitializeComponent();
        }
        string kolonName = "kasiyerKullaniciAdi";
        DataBase db = new DataBase();
        public void veri( )
        {
            try
            {
                dgwListele.DataSource = db.TabloGetir("tblkasiyer");
                dgwListele.Columns[0].Visible = false;
                dgwListele.Columns[1].HeaderText = "Kullanıcı Adı";
                dgwListele.Columns[2].HeaderText = "Şifresi";
                dgwListele.Columns[3].HeaderText = "Adı Soyadı";
                dgwListele.Columns[4].HeaderText = "Maili";
                dgwListele.Columns[5].HeaderText = "Primi";


            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex.Message);
            }

        }
        private void control()
        {
            switch (kolonName)
            {
                case "kasiyerPrim":
                    this.Text = "Prim";
                    break;
                case "kasiyerSifre":
                    this.Text = "Şifre";
                    break;
                case "kasiyerKullaniciAdi":
                    this.Text = "Kullanıcı Adı";
                    break;
                case "kasiyerAd":
                    this.Text = "Ad";
                    break;
                case "kasiyerSoyad":
                    this.Text = "Soyadı";
                    break;
                case "kasiyerMail":
                    this.Text = "Mail";
                    break;
            }
            MessageBox.Show("Seçtiğiniz Kolon Adı = " + this.Text, "KOLON BAŞLIĞI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        string selected = "ekle";
        private void data(MaterialTextBox txt, DataGridView dta)
        {

            if (txt.Text == "" || txt.Text == null)
            {
                veri();

            }
            else if (kolonName == "kasiyerKullaniciAdi" || kolonName == "kasiyerSifre" || kolonName == "kasiyerAd" || kolonName == "kasiyerSoyad" || kolonName == "kasiyerMail")
            {
                string filter = txt.Text;

                if (dta.DataSource is DataTable dataTable)
                {
                    dataTable.DefaultView.RowFilter = $"CONVERT([{kolonName}], 'System.String') LIKE '%{filter}%'";
                }

            }
            else
            {
                string filter = txt.Text;

                if (dta.DataSource is DataTable dataTable)
                {
                    dataTable.DefaultView.RowFilter = $"CONVERT([{kolonName}], 'System.String') LIKE '%{filter}%'";
                }

            }
        }
        private void donusturucu(bool don)
        {
            txtKullaniciAdi.Visible = don;
            txtAdSoyad.Visible = don;
            txtMail.Visible = don;
            txtSifre.Visible = don;
            btnEkleSilGuncelle.Visible = don;
            lblAd.Visible = don;
            lblKullaniciAdi.Visible = don;
            lblMail.Visible = don;
            lblSifre.Visible = don;
            btnTemizle.Visible = don;
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri();
            if (tcKasiyer.SelectedTab == tpEkle)
            {
                txtFilter.Location = new Point(303, 400);
                selected = "ekle";
                btnEkleSilGuncelle.Text = this.Text = "Ekle";
                lblSil.Visible = false;
                txtSil.Visible = false;
                donusturucu(true);
            }

            else if (tcKasiyer.SelectedTab == tpSil)
            {
                txtFilter.Location = new Point(303, 400);
                selected = "sil";
                btnEkleSilGuncelle.Text = this.Text = "Sil";
                txtSil.Visible = true;
                lblSil.Visible = true;
                donusturucu(false);
                btnEkleSilGuncelle.Visible = true;
            }
            else if (tcKasiyer.SelectedTab == tpGuncelle)
            {
                txtFilter.Location = new Point(303, 400);
                selected = "güncelle";
                btnEkleSilGuncelle.Text = this.Text = "Güncelle";
                lblSil.Visible = false;
                txtSil.Visible = false;
                donusturucu(true);
            }

            else
            {
                this.Text = "Sil";
                donusturucu(false);
                lblSil.Visible = false;
                txtSil.Visible = false;
                lblFilter.Location = new Point(85,195);
                txtFilter.Location = new Point(164, 184);
            }
            temizle();
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Deneme_Load(object sender, EventArgs e)
        {
            veri();
        }

        private void btnEkleSilGuncelle_Click(object sender, EventArgs e)
        {
            if (selected == "ekle")
            {
                if (txtKullaniciAdi.Text != "" && txtSifre.Text != "" && txtAdSoyad.Text != "" && txtMail.Text != "")
                {
                    if (db.kasiyerEkleGuncelle(txtKullaniciAdi.Text,ID,"ekle"))
                    {
                        db.kullaniciAdi = txtKullaniciAdi.Text;
                        db.Sifre = txtSifre.Text;
                        db.ad = txtAdSoyad.Text;
                        db.mail = txtMail.Text;
                        db.EkleSilGuncelle("ekle", "kasiyer");
                    }
                    else
                    {
                        MessageBox.Show("Zaten Böyle Biri Var Kör","Olmaz",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                    temizle();
                }
                else
                {
                    MessageBox.Show("lütfen boşluk bırakmyaınız");
                }
            }

            else if (selected == "sil")
            {
                if (txtSil.Text != "")
                {
                    if (txtSil.Text == "admin")
                        MessageBox.Show("Sen Kimsin Lan Admini Siliceksin Olum Kimsin Sen Adminsin Sen Admin Kal Vur Kırbacı İşçiye", "Admin Baba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        db.kullaniciAdi = txtKullaniciAdi.Text ;
                        db.Reader("kasiyerSil");
                        db.kullaniciAdi = txtSil.Text;
                        db.EkleSilGuncelle("sil", "kasiyer");
                        temizle();
                    }


                }
                else
                {
                    MessageBox.Show("lütfen boşluk bırakmyaınız");
                }

            }
            else
            {

                if (txtKullaniciAdi.Text != "" && txtSifre.Text != "" && txtAdSoyad.Text != "" && txtMail.Text != "")
                {

                    if (txtKullaniciAdi.Text != "admin")
                    {
                        if (db.kasiyerEkleGuncelle(txtKullaniciAdi.Text,ID,"güncelle"))
                        {
                            db.kullaniciAdi = txtKullaniciAdi.Text;
                            db.Sifre = txtSifre.Text;
                            db.ad = txtAdSoyad.Text;
                            db.mail = txtMail.Text;
                            db.EkleSilGuncelle("güncelle", "kasiyer");
                        }
                        else
                        {
                            MessageBox.Show("Başkasının Rolünü Çalmaya Utanmıyomusun Lan He?", "Olmaz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        temizle();
                    }
                    else
                        MessageBox.Show("Admin Dğeiştirilmez Değiştirilemez Değiştirilmesi dahi Teklif Bile Edilemez Ne Mutlu Adminim Diyene", "Admin Baba", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show("lütfen boşluk bırakmyaınız");
                }

            }

            veri();

        }
        private void temizle()
        {
            txtAdSoyad.Text = "";
            txtFilter.Text = "";
            txtKullaniciAdi.Text = "";
            txtMail.Text = "";
            txtSifre.Text = "";
            txtSil.Text = "";
            ID =0;
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
        int ID;
        private void dgwListele_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (selected != "ekle")
            {
                txtSil.Text = dgwListele.CurrentRow.Cells["kasiyerKullaniciAdi"].Value.ToString();
                txtKullaniciAdi.Text = dgwListele.CurrentRow.Cells["kasiyerKullaniciAdi"].Value.ToString();
                txtAdSoyad.Text = dgwListele.CurrentRow.Cells["kasiyerAdSoyad"].Value.ToString();
                txtMail.Text = dgwListele.CurrentRow.Cells["kasiyerMail"].Value.ToString();
                txtSifre.Text = dgwListele.CurrentRow.Cells["kasiyerSifre"].Value.ToString();
                ID = (int)dgwListele.CurrentRow.Cells["kasiyerID"].Value;
            }

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            data(txtFilter, dgwListele);
        }

        private void dgwListele_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgwListele.Sort(dgwListele.Columns[e.ColumnIndex], ListSortDirection.Ascending);
            kolonName = ((DataGridView)sender).Columns[e.ColumnIndex].DataPropertyName;
            control();
        }
    }
}
