using System;
using System.ComponentModel;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;
using MaterialSkin.Controls;
using static System.Net.Mime.MediaTypeNames;

namespace Market
{
    public partial class Prim : Form
    {
        public Prim()
        {
            InitializeComponent();
        }
        string kolonName = "kasiyerKullaniciAdi";

        DataBase db = new DataBase();
        public void veri(string tablo)
        {

            try
            {
                dgwKasiyer.DataSource = db.TabloGetir(tablo);
                dgwKasiyer.Columns[0].Visible = false;
                dgwKasiyer.Columns[1].HeaderText = "Kullanıcı Adı";
                dgwKasiyer.Columns[2].Visible = false;
                dgwKasiyer.Columns[3].HeaderText = "Adı";
                dgwKasiyer.Columns[4].Visible=false;
                dgwKasiyer.Columns[5].HeaderText = "Primi";


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
                    lblDeneme.Text = "Prim";
                    break;
                case "kasiyerKullaniciAdi":
                    lblDeneme.Text = "Kullanıcı Adı";
                    break;
                case "kasiyerAdSoyad":
                    lblDeneme.Text = "Ad";
                    break;
            }
            MessageBox.Show("Seçtiğiniz Kolon Adı = " + lblDeneme.Text, "KOLON BAŞLIĞI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void data(MaterialTextBox txt, DataGridView dta)
        {

            if (txt.Text == "" || txt.Text == null)
            {
                dta.DataSource = null;
                veri("tblkasiyer");

            }
            else if (kolonName == "kasiyerKullaniciAdi" || kolonName == "kasiyerAdSoyad")
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
        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                data(txtAra, dgwKasiyer);
            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex.Message);
            }
        }
        private void Prim_Load(object sender, EventArgs e)
        {
            veri("tblkasiyer");

        }

        private void dgwKasiyer_ColumnHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.dgwKasiyer.Sort(this.dgwKasiyer.Columns[e.ColumnIndex], ListSortDirection.Ascending);
            kolonName = ((DataGridView)sender).Columns[e.ColumnIndex].DataPropertyName;
            control();

        }

        private void dgwKasiyer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}