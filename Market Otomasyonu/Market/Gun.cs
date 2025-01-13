using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using ZstdSharp.Unsafe;

namespace Market
{
    public partial class Gun : Form
    {
        public Gun()
        {
            InitializeComponent();
        }
        DataBase db = new DataBase();
        DataTable dt = new DataTable();
        public void veri(string tablo)
        {
            try
            {
                dgwListele.DataSource=dt = db.TabloGetir(tablo);
                dgwListele.Columns[0].Visible = false;
                if (tablo == "tbliade")
                {
                    dgwListele.Columns[1].HeaderText = "İadeyi Kimin Yaptığı";
                    dgwListele.Columns[2].HeaderText = "İadenin Ne Kadar Olduğu";
                    dgwListele.Columns[3].HeaderText = "İade Tarihi";
                    dgwListele.Columns[4].HeaderText = "İadenin Açıklaması";
                    dgwListele.Columns[5].HeaderText = "İade Nakit/Kart";
                }
                else
                {
                    dgwListele.Columns[1].HeaderText = "Satışı Kimin Yaptığı";
                    dgwListele.Columns[2].HeaderText = "Satışın Ne Kadar Olduğu";
                    dgwListele.Columns[3].HeaderText = "Satış Tarihi";
                    dgwListele.Columns[4].HeaderText = "Satışın Açıklaması";
                    dgwListele.Columns[5].HeaderText = "Satış Nakit/Kart";
                }
                dgwListele.Columns[6].Visible = false;
                dgwListele.Columns[7].Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex.Message);
            }

        }
        
        private void control()
        {
            bool durum = false;
            if (kolonName == selected + "NeKadar")
                gbAra.Text = "Ne Kadar Olduğu";
            else if (kolonName == "kasiyerKullaniciAdi")
                gbAra.Text = "Kimin Yaptığı";
            else if (kolonName == selected + "Tarih")
                gbAra.Text = "Tarihi";
            else if (kolonName == selected + "Aciklamasi")
                gbAra.Text = "Açıklaması";   
            else
            {
                gbAra.Visible = durum;
                durum = true;
                rbKart.Visible = rbNakit.Visible = durum;              
            }
            if (durum==false)
            {
                rbNakit.Visible = rbKart.Visible = durum;
                gbAra.Visible = true;
            }
            MessageBox.Show("Seçtiğiniz Kolon Adı = " + gbAra.Text, "KOLON BAŞLIĞI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        string kolonName="satisTarih";
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (txtFilter.Text == null || txtFilter.Text == "")
            {
                veri(selected);
            }
            else if (kolonName =="kasiyerKullaniciAdi" || kolonName == selected+"Aciklamasi"||kolonName=="KartNakit")
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = kolonName + " LIKE '" + txtFilter.Text + "%'";
                dgwListele.DataSource = dv;
            }
            else if ( kolonName == selected+"NeKadar" || kolonName == selected+"Tarih")
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("convert({0},'System.String') Like '%{1}%' ", kolonName, txtFilter.Text);
                dgwListele.DataSource = dv;

            }
        }

        private void Gun_Load(object sender, EventArgs e)
        {
            veri("satis");
        }
        
        private void dtpBas_ValueChanged(object sender, EventArgs e)
        {
            if (cbTarih.Checked)
            {
                try
                {
                    DataView dv = dt.DefaultView;
                    dv.RowFilter = string.Format("convert({0},'System.String') Like '%{1}%' ", selected + "Tarih", dtpBas.Value.ToString("dd.MM.yyyy"));
                    dgwListele.DataSource = dv;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                FilterDataGridView();
            }
        }

        private void dgwListele_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgwListele.Sort(dgwListele.Columns[e.ColumnIndex], ListSortDirection.Ascending);
            kolonName = ((DataGridView)sender).Columns[e.ColumnIndex].DataPropertyName;
            control();
        }
        string selected = "satis";
        private void tcIade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcIade.SelectedIndex == 1)
            {
                selected = "iade";
                veri(selected);

            }
            else
            {
                selected = "satis";
                veri(selected);
            }
        }

        private void rbNakit_Click(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = kolonName + " LIKE '" + "Nakit" + "%'";
            dgwListele.DataSource = dv;
        }

        private void rbKart_Click(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = kolonName + " LIKE '" + "Kart" + "%'";
            dgwListele.DataSource = dv;
        }

        private void dtpSon_ValueChanged(object sender, EventArgs e)
        {
            FilterDataGridView();
        }
        private void FilterDataGridView()
        {
            try
            {
                DateTime baslangicTarih = dtpBas.Value;
                DateTime bitisTarih = dtpSon.Value;
                if (baslangicTarih>bitisTarih)
                {
                    MessageBox.Show("Başlangıç Tarihi Bitiş Tarihinden Büyük Olamaz","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    DataView dv = dt.DefaultView;
                    dv.RowFilter = string.Format(selected + "Tarih >= '{0}' AND " + selected + "Tarih <= '{1}'", dtpBas.Value, dtpSon.Value);
                    dgwListele.DataSource = dv;
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cbTarih_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTarih.Checked)
            {
                dtpSon.Visible = false;
            }
            else
            {
                dtpSon.Visible=true;
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            veri(selected);
            txtFilter.Text = "";
        }

        private void rbNakit_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
