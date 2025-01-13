namespace Market
{
    partial class KasiyerIslemleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KasiyerIslemleri));
            this.dgwListele = new System.Windows.Forms.DataGridView();
            this.tcKasiyer = new System.Windows.Forms.TabControl();
            this.tpEkle = new System.Windows.Forms.TabPage();
            this.tpSil = new System.Windows.Forms.TabPage();
            this.tpGuncelle = new System.Windows.Forms.TabPage();
            this.tpListele = new System.Windows.Forms.TabPage();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSifre = new MaterialSkin.Controls.MaterialTextBox();
            this.txtAdSoyad = new MaterialSkin.Controls.MaterialTextBox();
            this.txtMail = new MaterialSkin.Controls.MaterialTextBox();
            this.txtFilter = new MaterialSkin.Controls.MaterialTextBox();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.btnEkleSilGuncelle = new MaterialSkin.Controls.MaterialButton();
            this.txtSil = new MaterialSkin.Controls.MaterialTextBox();
            this.lblSil = new System.Windows.Forms.Label();
            this.btnTemizle = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListele)).BeginInit();
            this.tcKasiyer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwListele
            // 
            this.dgwListele.AllowUserToAddRows = false;
            this.dgwListele.AllowUserToDeleteRows = false;
            this.dgwListele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwListele.BackgroundColor = System.Drawing.Color.Salmon;
            this.dgwListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListele.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgwListele.Location = new System.Drawing.Point(504, 0);
            this.dgwListele.Name = "dgwListele";
            this.dgwListele.ReadOnly = true;
            this.dgwListele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwListele.Size = new System.Drawing.Size(458, 450);
            this.dgwListele.TabIndex = 0;
            this.dgwListele.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwListele_CellEnter);
            this.dgwListele.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwListele_ColumnHeaderMouseClick);
            // 
            // tcKasiyer
            // 
            this.tcKasiyer.Controls.Add(this.tpEkle);
            this.tcKasiyer.Controls.Add(this.tpSil);
            this.tcKasiyer.Controls.Add(this.tpGuncelle);
            this.tcKasiyer.Controls.Add(this.tpListele);
            this.tcKasiyer.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcKasiyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcKasiyer.Location = new System.Drawing.Point(0, 0);
            this.tcKasiyer.Name = "tcKasiyer";
            this.tcKasiyer.SelectedIndex = 0;
            this.tcKasiyer.Size = new System.Drawing.Size(504, 23);
            this.tcKasiyer.TabIndex = 1;
            this.tcKasiyer.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpEkle
            // 
            this.tpEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tpEkle.Location = new System.Drawing.Point(4, 25);
            this.tpEkle.Name = "tpEkle";
            this.tpEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tpEkle.Size = new System.Drawing.Size(496, 0);
            this.tpEkle.TabIndex = 0;
            this.tpEkle.Text = "Kasiyer Ekleme Sayfası";
            // 
            // tpSil
            // 
            this.tpSil.BackColor = System.Drawing.Color.Green;
            this.tpSil.Location = new System.Drawing.Point(4, 25);
            this.tpSil.Name = "tpSil";
            this.tpSil.Padding = new System.Windows.Forms.Padding(3);
            this.tpSil.Size = new System.Drawing.Size(496, 0);
            this.tpSil.TabIndex = 1;
            this.tpSil.Text = "Kasiyer Silme Sayfası";
            // 
            // tpGuncelle
            // 
            this.tpGuncelle.BackColor = System.Drawing.Color.DarkOrchid;
            this.tpGuncelle.Location = new System.Drawing.Point(4, 25);
            this.tpGuncelle.Name = "tpGuncelle";
            this.tpGuncelle.Padding = new System.Windows.Forms.Padding(3);
            this.tpGuncelle.Size = new System.Drawing.Size(496, 0);
            this.tpGuncelle.TabIndex = 2;
            this.tpGuncelle.Text = "Kasiyer Güncelleme Sayfası";
            // 
            // tpListele
            // 
            this.tpListele.BackColor = System.Drawing.Color.Brown;
            this.tpListele.Location = new System.Drawing.Point(4, 25);
            this.tpListele.Name = "tpListele";
            this.tpListele.Padding = new System.Windows.Forms.Padding(3);
            this.tpListele.Size = new System.Drawing.Size(496, 0);
            this.tpListele.TabIndex = 3;
            this.tpListele.Text = "Kasiyerleri Listele";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMail.Location = new System.Drawing.Point(58, 268);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(48, 24);
            this.lblMail.TabIndex = 1;
            this.lblMail.Text = "Mail";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.AnimateReadOnly = false;
            this.txtKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKullaniciAdi.Depth = 0;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtKullaniciAdi.LeadingIcon = null;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(190, 87);
            this.txtKullaniciAdi.MaxLength = 50;
            this.txtKullaniciAdi.MouseState = MaterialSkin.MouseState.OUT;
            this.txtKullaniciAdi.Multiline = false;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(201, 50);
            this.txtKullaniciAdi.TabIndex = 0;
            this.txtKullaniciAdi.Text = "";
            this.txtKullaniciAdi.TrailingIcon = null;
            // 
            // txtSifre
            // 
            this.txtSifre.AnimateReadOnly = false;
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifre.Depth = 0;
            this.txtSifre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSifre.LeadingIcon = null;
            this.txtSifre.Location = new System.Drawing.Point(190, 143);
            this.txtSifre.MaxLength = 50;
            this.txtSifre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSifre.Multiline = false;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(201, 50);
            this.txtSifre.TabIndex = 0;
            this.txtSifre.Text = "";
            this.txtSifre.TrailingIcon = null;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.AnimateReadOnly = false;
            this.txtAdSoyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdSoyad.Depth = 0;
            this.txtAdSoyad.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAdSoyad.LeadingIcon = null;
            this.txtAdSoyad.Location = new System.Drawing.Point(190, 199);
            this.txtAdSoyad.MaxLength = 50;
            this.txtAdSoyad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAdSoyad.Multiline = false;
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(201, 50);
            this.txtAdSoyad.TabIndex = 0;
            this.txtAdSoyad.Text = "";
            this.txtAdSoyad.TrailingIcon = null;
            // 
            // txtMail
            // 
            this.txtMail.AnimateReadOnly = false;
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMail.Depth = 0;
            this.txtMail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMail.LeadingIcon = null;
            this.txtMail.Location = new System.Drawing.Point(190, 255);
            this.txtMail.MaxLength = 50;
            this.txtMail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMail.Multiline = false;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(201, 50);
            this.txtMail.TabIndex = 0;
            this.txtMail.Text = "";
            this.txtMail.TrailingIcon = null;
            // 
            // txtFilter
            // 
            this.txtFilter.AnimateReadOnly = false;
            this.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilter.Depth = 0;
            this.txtFilter.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFilter.LeadingIcon = null;
            this.txtFilter.Location = new System.Drawing.Point(303, 400);
            this.txtFilter.MaxLength = 50;
            this.txtFilter.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFilter.Multiline = false;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(201, 50);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.Text = "";
            this.txtFilter.TrailingIcon = null;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(58, 85);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(126, 24);
            this.lblKullaniciAdi.TabIndex = 1;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(58, 143);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(52, 24);
            this.lblSifre.TabIndex = 1;
            this.lblSifre.Text = "Şifre";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(58, 212);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(100, 24);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "Ad Soyad";
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFilter.Location = new System.Drawing.Point(218, 417);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(79, 24);
            this.lblFilter.TabIndex = 1;
            this.lblFilter.Text = "Filitrele";
            // 
            // btnEkleSilGuncelle
            // 
            this.btnEkleSilGuncelle.AutoSize = false;
            this.btnEkleSilGuncelle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEkleSilGuncelle.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEkleSilGuncelle.Depth = 0;
            this.btnEkleSilGuncelle.HighEmphasis = true;
            this.btnEkleSilGuncelle.Icon = null;
            this.btnEkleSilGuncelle.Location = new System.Drawing.Point(386, 329);
            this.btnEkleSilGuncelle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEkleSilGuncelle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEkleSilGuncelle.Name = "btnEkleSilGuncelle";
            this.btnEkleSilGuncelle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEkleSilGuncelle.Size = new System.Drawing.Size(81, 36);
            this.btnEkleSilGuncelle.TabIndex = 0;
            this.btnEkleSilGuncelle.Text = "Ekle";
            this.btnEkleSilGuncelle.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEkleSilGuncelle.UseAccentColor = true;
            this.btnEkleSilGuncelle.UseVisualStyleBackColor = true;
            this.btnEkleSilGuncelle.Click += new System.EventHandler(this.btnEkleSilGuncelle_Click);
            // 
            // txtSil
            // 
            this.txtSil.AnimateReadOnly = false;
            this.txtSil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSil.Depth = 0;
            this.txtSil.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSil.LeadingIcon = null;
            this.txtSil.Location = new System.Drawing.Point(190, 172);
            this.txtSil.MaxLength = 50;
            this.txtSil.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSil.Multiline = false;
            this.txtSil.Name = "txtSil";
            this.txtSil.Size = new System.Drawing.Size(201, 50);
            this.txtSil.TabIndex = 2;
            this.txtSil.Text = "";
            this.txtSil.TrailingIcon = null;
            this.txtSil.Visible = false;
            // 
            // lblSil
            // 
            this.lblSil.AutoSize = true;
            this.lblSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSil.Location = new System.Drawing.Point(104, 188);
            this.lblSil.Name = "lblSil";
            this.lblSil.Size = new System.Drawing.Size(33, 24);
            this.lblSil.TabIndex = 1;
            this.lblSil.Text = "Sil";
            this.lblSil.Visible = false;
            // 
            // btnTemizle
            // 
            this.btnTemizle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTemizle.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTemizle.Depth = 0;
            this.btnTemizle.HighEmphasis = true;
            this.btnTemizle.Icon = null;
            this.btnTemizle.Location = new System.Drawing.Point(26, 360);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTemizle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTemizle.Size = new System.Drawing.Size(81, 36);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTemizle.UseAccentColor = true;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // KasiyerIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(962, 450);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.txtSil);
            this.Controls.Add(this.btnEkleSilGuncelle);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.tcKasiyer);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.dgwListele);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblSil);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.txtAdSoyad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KasiyerIslemleri";
            this.Text = "Ekle";
            this.Load += new System.EventHandler(this.Deneme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwListele)).EndInit();
            this.tcKasiyer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwListele;
        private System.Windows.Forms.TabControl tcKasiyer;
        private System.Windows.Forms.TabPage tpEkle;
        private System.Windows.Forms.TabPage tpSil;
        private System.Windows.Forms.TabPage tpGuncelle;
        private System.Windows.Forms.TabPage tpListele;
        private System.Windows.Forms.Label lblMail;
        private MaterialSkin.Controls.MaterialTextBox txtKullaniciAdi;
        private MaterialSkin.Controls.MaterialTextBox txtSifre;
        private MaterialSkin.Controls.MaterialTextBox txtAdSoyad;
        private MaterialSkin.Controls.MaterialTextBox txtMail;
        private MaterialSkin.Controls.MaterialTextBox txtFilter;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblFilter;
        private MaterialSkin.Controls.MaterialButton btnEkleSilGuncelle;
        private MaterialSkin.Controls.MaterialTextBox txtSil;
        private System.Windows.Forms.Label lblSil;
        private MaterialSkin.Controls.MaterialButton btnTemizle;
    }
}