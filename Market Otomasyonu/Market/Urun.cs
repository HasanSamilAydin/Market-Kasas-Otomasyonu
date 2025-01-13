using MaterialSkin.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ZXing.QrCode.Internal;
using System.Windows.Forms;

namespace Market
{
    public partial class Urun : Form
    {
        public Urun()
        {
            InitializeComponent();
        }
        DataBase db = new DataBase();
        ArrayList array = new ArrayList();
        public void veri()
        {
            try
            {
                TemizleRadio();
                dgwListele.DataSource = db.TabloGetir("urun");
                dgwListele.Columns[0].Visible = false;
                dgwListele.Columns[1].HeaderText = "Ürünün Barkot Numarası";
                dgwListele.Columns[2].HeaderText = "Ürünün Kategorisi";
                dgwListele.Columns[3].HeaderText = "Ürünün Markası";
                dgwListele.Columns[4].Visible = false; dgwListele.Columns[5].Visible = false;
                dgwListele.Columns[6].HeaderText = "Ürünün Adı";
                dgwListele.Columns[7].HeaderText = "Ürünün Fiyatı";
                dgwListele.Columns[8].HeaderText = " Ürünün Stoğu";
                dgwListele.Columns[9].HeaderText = "Ürünün Stok Drumu";
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
                case "urunBarkod":
                    this.Text = "Barkod";
                    break;
                case "kategoriAd":
                    this.Text = "Kategori";
                    break;
                case "MarkaAd":
                    this.Text = "Marka";
                    break;
                case "urunAd":
                    this.Text = "Ad";
                    break;
                case "urunFiyat":
                    this.Text = "Fiyat";
                    break;
                case "urunStok":
                    this.Text = "Stok";
                    break;
                case "urunSorgusu":
                    this.Text = "Stok Sorgusu";
                    break;
            }
            if (kolonName == "urunSorgusu")
            {
                rbVar.Visible = rbYok.Visible = true;
                txtFilter.Visible = lblFilter.Visible = false;
            }
            else
            {
                rbYok.Visible = rbVar.Visible = false;
                txtFilter.Visible = lblFilter.Visible = true;
            }
            MessageBox.Show("Seçtiğiniz Kolon Adı = " + this.Text, "KOLON BAŞLIĞI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            veri();
        }
        private void donusturucu(bool don)
        {
            //button
            btnEkleSilGuncelle.Visible = don;
            btnTemizle.Visible = don;
            //combo
            cbKategori.Visible = don;
            cbMarka.Visible = don;
            //text
            txtAd.Visible = don;
            txtBarkod.Visible = don;
            txtFiyat.Visible = don;
            //lable
            lblAd.Visible = don;
            lblFiyat.Visible = don;
            lblBarkod.Visible = don;
            lblKategori.Visible = don;
            lblMarka.Visible = don;
            lblStok.Visible = don;
            //sayi
            nupStok.Visible = don;
            //PictureBox
        }
        private void size(string ek)
        {
            if (ek == "ekle" || ek == "güncelle")
            {
                dgwListele.Size = new Size(612, 523);
                txtBarkod.Location = new Point(124, 84);
                txtFilter.Location = new Point(417, 464);
                lblBarkod.Location = new Point(17, 107);
                btnEkleSilGuncelle.Location = new Point(234, 366);
                rbVar.Location = new Point(324, 469);
                rbYok.Location = new Point(512, 469);
                lblFilter.Location = new Point(318, 476);

            }
            else if (ek == "sil")
            {
                txtBarkod.Visible = true;
                lblBarkod.Visible = true;
                btnEkleSilGuncelle.Visible = true;
                dgwListele.Size = new Size(1000, 585);
                txtBarkod.Location = new Point(4, 73);
                txtFilter.Location = new Point(12, 464);
                lblBarkod.Location = new Point(4, 59);
                rbVar.Location = new Point(4, 137);
                rbYok.Location = new Point(4, 196);
                lblFilter.Location = new Point(4, 422);
                btnEkleSilGuncelle.Location = new Point(9, 308);
            }
            else
            {
                dgwListele.Size = new Size(1000, 585);
                txtFilter.Location = new Point(4, 229);
                lblFilter.Location = new Point(4, 175);
                rbVar.Location = new Point(10, 200);
                rbYok.Location = new Point(10, 300);
            }
        }
        string kolonName = "urunBarkod";
        private void data(MaterialTextBox txt, DataGridView dta)
        {
            if (kolonName == "urunBarkod" || kolonName == "kategoriAd" || kolonName == "markaAd")
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
        private void Temizle()
        {
            veri();
            txtAd.Text = "";
            txtBarkod.Text = "";
            txtFilter.Text = "";
            txtFiyat.Text = "";
            nupStok.Value = 0;
            TemizleRadio();
            cbKategori.SelectedItem = " ";
            cbMarka.SelectedItem = " ";
        }
        private void TemizleRadio()
        {
            rbVar.Checked = false;
            rbYok.Checked = false;
            if (cbKategori.Items.Contains(" "))
                cbKategori.SelectedItem = " ";
            else
            {
                cbKategori.Items.Add(" ");
                cbKategori.SelectedItem = " ";
            }
            if (cbMarka.Items.Contains(" "))
                cbMarka.SelectedItem = " ";
            else
            {
                cbMarka.Items.Add(" ");
                cbKategori.SelectedItem = " ";
            }
        }

        private void Urun_Load(object sender, EventArgs e)
        {
            veri();
            array = db.kategori("tblkategori");
            foreach (var i in array)
            {
                cbKategori.Items.Add(i);
            }
            array.Clear();
            array = db.kategori("tblmarka");
            foreach (var i in array)
            {
                cbMarka.Items.Add(i);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnEkleSilGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (selected == "ekle")
                {
                    db.urunAd = txtAd.Text;
                    db.barkod = txtBarkod.Text;
                    db.Marka = cbMarka.SelectedItem.ToString();
                    db.Kategori = cbKategori.SelectedItem.ToString();
                    db.stok = (int)nupStok.Value;
                    db.fiyat = double.Parse(txtFiyat.Text);
                    if (db.EkleSilGuncelle("ekle", "ürün"))
                        MessageBox.Show("Ürün Ekleniyor");
                }
                else if (selected == "sil")
                {
                    db.barkod = txtBarkod.Text;
                    if (db.EkleSilGuncelle("sil", "ürün"))
                    {
                        MessageBox.Show("Ürün Siliniyor");
                    }
                }
                else
                {
                    db.ID = ID;
                    db.urunAd = txtAd.Text;
                    db.barkod = txtBarkod.Text;
                    db.Marka = cbMarka.SelectedItem.ToString();
                    db.Kategori = cbKategori.SelectedItem.ToString();
                    db.stok = (int)nupStok.Value;
                    db.fiyat = double.Parse(txtFiyat.Text);
                    if (db.EkleSilGuncelle("güncelle", "ürün"))
                        MessageBox.Show("Ürün Güncelleniyor");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik Bir Hata İle Karşılaştık", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Temizle();
            veri();
        }
        private void dgwListele_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }
        string selected = "ekle";
        private void tcUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            veri();
            if (tcUrun.SelectedTab == tpEkle)
            {

                selected = "ekle";
                btnEkleSilGuncelle.Text = this.Text = "Ekle";
                donusturucu(true);
            }

            else if (tcUrun.SelectedTab == tpSil)
            {
                selected = "sil";
                btnEkleSilGuncelle.Text = this.Text = "Sil";
                donusturucu(false);


            }
            else if (tcUrun.SelectedTab == tpGuncelle)
            {
                selected = "güncelle";
                btnEkleSilGuncelle.Text = this.Text = "Güncelle";
                donusturucu(true);
            }

            else
            {
                this.Text = "Filitrele";
                selected = "";
                donusturucu(false);


            }

            size(selected);
            Temizle();
            control();
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
        private void rbVar_Click(object sender, EventArgs e)
        {
            if (dgwListele.DataSource is DataTable dataTable)
            {
                dataTable.DefaultView.RowFilter = $"CONVERT([{kolonName}], 'System.String') LIKE '%t%'";
            }
        }

        private void rbYok_Click(object sender, EventArgs e)
        {
            if (dgwListele.DataSource is DataTable dataTable)
            {
                dataTable.DefaultView.RowFilter = $"CONVERT([{kolonName}], 'System.String') LIKE '%f%'";
            }
        }
        int ID = 0;
        private void dgwListele_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (selected == "güncelle")
            {
                ID = (int)dgwListele.CurrentRow.Cells[0].Value;
                txtAd.Text = dgwListele.CurrentRow.Cells["urunAd"].Value.ToString();
                txtBarkod.Text = dgwListele.CurrentRow.Cells["urunBarkod"].Value.ToString();
                txtFiyat.Text = dgwListele.CurrentRow.Cells["urunFiyat"].Value.ToString();
                nupStok.Value = int.Parse(dgwListele.CurrentRow.Cells["urunStok"].Value.ToString());
                cbKategori.SelectedItem = dgwListele.CurrentRow.Cells["kategoriAd"].Value.ToString();
                cbMarka.SelectedItem = dgwListele.CurrentRow.Cells["markaAd"].Value.ToString();
            }
        }

        private void cbKategori_Click(object sender, EventArgs e)
        {
            cbKategori.Items.Remove(" ");
        }

        private void cbMarka_Click(object sender, EventArgs e)
        {
            cbMarka.Items.Remove(" ");
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dgwListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbVar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbYok_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
