namespace Market
{
    partial class Urun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Urun));
            this.dgwListele = new System.Windows.Forms.DataGridView();
            this.tcUrun = new System.Windows.Forms.TabControl();
            this.tpEkle = new System.Windows.Forms.TabPage();
            this.tpSil = new System.Windows.Forms.TabPage();
            this.tpGuncelle = new System.Windows.Forms.TabPage();
            this.tpFilter = new System.Windows.Forms.TabPage();
            this.txtBarkod = new MaterialSkin.Controls.MaterialTextBox();
            this.nupStok = new System.Windows.Forms.NumericUpDown();
            this.cbKategori = new MaterialSkin.Controls.MaterialComboBox();
            this.cbMarka = new MaterialSkin.Controls.MaterialComboBox();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblStok = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblBarkod = new System.Windows.Forms.Label();
            this.txtFiyat = new MaterialSkin.Controls.MaterialTextBox();
            this.txtAd = new MaterialSkin.Controls.MaterialTextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.txtFilter = new MaterialSkin.Controls.MaterialTextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.btnEkleSilGuncelle = new MaterialSkin.Controls.MaterialButton();
            this.btnTemizle = new MaterialSkin.Controls.MaterialButton();
            this.rbVar = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbYok = new MaterialSkin.Controls.MaterialRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListele)).BeginInit();
            this.tcUrun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupStok)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwListele
            // 
            this.dgwListele.AllowUserToAddRows = false;
            this.dgwListele.AllowUserToDeleteRows = false;
            this.dgwListele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwListele.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgwListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListele.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgwListele.Location = new System.Drawing.Point(658, 0);
            this.dgwListele.Name = "dgwListele";
            this.dgwListele.ReadOnly = true;
            this.dgwListele.RowHeadersWidth = 51;
            this.dgwListele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwListele.Size = new System.Drawing.Size(612, 523);
            this.dgwListele.TabIndex = 0;
            this.dgwListele.TabStop = false;
            this.dgwListele.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwListele_CellContentClick);
            this.dgwListele.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwListele_CellEnter);
            this.dgwListele.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwListele_ColumnHeaderMouseClick);
            this.dgwListele.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwListele_RowHeaderMouseClick);
            // 
            // tcUrun
            // 
            this.tcUrun.Controls.Add(this.tpEkle);
            this.tcUrun.Controls.Add(this.tpSil);
            this.tcUrun.Controls.Add(this.tpGuncelle);
            this.tcUrun.Controls.Add(this.tpFilter);
            this.tcUrun.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcUrun.Location = new System.Drawing.Point(0, 0);
            this.tcUrun.Name = "tcUrun";
            this.tcUrun.SelectedIndex = 0;
            this.tcUrun.Size = new System.Drawing.Size(658, 26);
            this.tcUrun.TabIndex = 1;
            this.tcUrun.SelectedIndexChanged += new System.EventHandler(this.tcUrun_SelectedIndexChanged);
            // 
            // tpEkle
            // 
            this.tpEkle.Location = new System.Drawing.Point(4, 29);
            this.tpEkle.Name = "tpEkle";
            this.tpEkle.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpEkle.Size = new System.Drawing.Size(650, 0);
            this.tpEkle.TabIndex = 0;
            this.tpEkle.Text = "Ekle";
            this.tpEkle.UseVisualStyleBackColor = true;
            // 
            // tpSil
            // 
            this.tpSil.Location = new System.Drawing.Point(4, 29);
            this.tpSil.Name = "tpSil";
            this.tpSil.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpSil.Size = new System.Drawing.Size(650, 0);
            this.tpSil.TabIndex = 1;
            this.tpSil.Text = "Sil";
            this.tpSil.UseVisualStyleBackColor = true;
            // 
            // tpGuncelle
            // 
            this.tpGuncelle.Location = new System.Drawing.Point(4, 29);
            this.tpGuncelle.Name = "tpGuncelle";
            this.tpGuncelle.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpGuncelle.Size = new System.Drawing.Size(650, 0);
            this.tpGuncelle.TabIndex = 2;
            this.tpGuncelle.Text = "Güncelle";
            this.tpGuncelle.UseVisualStyleBackColor = true;
            // 
            // tpFilter
            // 
            this.tpFilter.Location = new System.Drawing.Point(4, 29);
            this.tpFilter.Name = "tpFilter";
            this.tpFilter.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpFilter.Size = new System.Drawing.Size(650, 0);
            this.tpFilter.TabIndex = 3;
            this.tpFilter.Text = "Arama";
            this.tpFilter.UseVisualStyleBackColor = true;
            // 
            // txtBarkod
            // 
            this.txtBarkod.AnimateReadOnly = false;
            this.txtBarkod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBarkod.Depth = 0;
            this.txtBarkod.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBarkod.LeadingIcon = null;
            this.txtBarkod.Location = new System.Drawing.Point(124, 86);
            this.txtBarkod.MaxLength = 50;
            this.txtBarkod.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBarkod.Multiline = false;
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(203, 50);
            this.txtBarkod.TabIndex = 0;
            this.txtBarkod.Text = "";
            this.txtBarkod.TrailingIcon = null;
            this.txtBarkod.TextChanged += new System.EventHandler(this.txtBarkod_TextChanged);
            // 
            // nupStok
            // 
            this.nupStok.BackColor = System.Drawing.Color.RosyBrown;
            this.nupStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nupStok.Location = new System.Drawing.Point(506, 249);
            this.nupStok.Name = "nupStok";
            this.nupStok.Size = new System.Drawing.Size(105, 40);
            this.nupStok.TabIndex = 5;
            // 
            // cbKategori
            // 
            this.cbKategori.AutoResize = false;
            this.cbKategori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbKategori.Depth = 0;
            this.cbKategori.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbKategori.DropDownHeight = 174;
            this.cbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategori.DropDownWidth = 121;
            this.cbKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbKategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.IntegralHeight = false;
            this.cbKategori.ItemHeight = 43;
            this.cbKategori.Items.AddRange(new object[] {
            " "});
            this.cbKategori.Location = new System.Drawing.Point(335, 137);
            this.cbKategori.MaxDropDownItems = 4;
            this.cbKategori.MouseState = MaterialSkin.MouseState.OUT;
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(142, 49);
            this.cbKategori.Sorted = true;
            this.cbKategori.StartIndex = 0;
            this.cbKategori.TabIndex = 3;
            this.cbKategori.Click += new System.EventHandler(this.cbKategori_Click);
            // 
            // cbMarka
            // 
            this.cbMarka.AutoResize = false;
            this.cbMarka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbMarka.Depth = 0;
            this.cbMarka.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbMarka.DropDownHeight = 174;
            this.cbMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarka.DropDownWidth = 121;
            this.cbMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbMarka.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbMarka.FormattingEnabled = true;
            this.cbMarka.IntegralHeight = false;
            this.cbMarka.ItemHeight = 43;
            this.cbMarka.Items.AddRange(new object[] {
            " "});
            this.cbMarka.Location = new System.Drawing.Point(483, 137);
            this.cbMarka.MaxDropDownItems = 4;
            this.cbMarka.MouseState = MaterialSkin.MouseState.OUT;
            this.cbMarka.Name = "cbMarka";
            this.cbMarka.Size = new System.Drawing.Size(142, 49);
            this.cbMarka.Sorted = true;
            this.cbMarka.StartIndex = 0;
            this.cbMarka.TabIndex = 4;
            this.cbMarka.Click += new System.EventHandler(this.cbMarka_Click);
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMarka.Location = new System.Drawing.Point(510, 96);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(115, 20);
            this.lblMarka.TabIndex = 6;
            this.lblMarka.Text = "Ürün Markası";
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStok.Location = new System.Drawing.Point(382, 263);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(101, 20);
            this.lblStok.TabIndex = 5;
            this.lblStok.Text = "Ürün Stoğu";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKategori.Location = new System.Drawing.Point(349, 96);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(133, 20);
            this.lblKategori.TabIndex = 6;
            this.lblKategori.Text = "Ürün Kategorisi";
            // 
            // lblBarkod
            // 
            this.lblBarkod.AutoSize = true;
            this.lblBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBarkod.Location = new System.Drawing.Point(17, 107);
            this.lblBarkod.Name = "lblBarkod";
            this.lblBarkod.Size = new System.Drawing.Size(101, 16);
            this.lblBarkod.TabIndex = 7;
            this.lblBarkod.Text = "Ürün Barkodu";
            // 
            // txtFiyat
            // 
            this.txtFiyat.AnimateReadOnly = false;
            this.txtFiyat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFiyat.Depth = 0;
            this.txtFiyat.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFiyat.LeadingIcon = null;
            this.txtFiyat.Location = new System.Drawing.Point(121, 263);
            this.txtFiyat.MaxLength = 50;
            this.txtFiyat.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFiyat.Multiline = false;
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(203, 50);
            this.txtFiyat.TabIndex = 2;
            this.txtFiyat.Text = "";
            this.txtFiyat.TrailingIcon = null;
            // 
            // txtAd
            // 
            this.txtAd.AnimateReadOnly = false;
            this.txtAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAd.Depth = 0;
            this.txtAd.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAd.LeadingIcon = null;
            this.txtAd.Location = new System.Drawing.Point(121, 183);
            this.txtAd.MaxLength = 50;
            this.txtAd.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAd.Multiline = false;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(203, 50);
            this.txtAd.TabIndex = 1;
            this.txtAd.Text = "";
            this.txtAd.TrailingIcon = null;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(15, 203);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(79, 20);
            this.lblAd.TabIndex = 8;
            this.lblAd.Text = "Ürün Adı";
            this.lblAd.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.Location = new System.Drawing.Point(11, 282);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(96, 20);
            this.lblFiyat.TabIndex = 7;
            this.lblFiyat.Text = "Ürün Fiyatı";
            // 
            // txtFilter
            // 
            this.txtFilter.AnimateReadOnly = false;
            this.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilter.Depth = 0;
            this.txtFilter.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFilter.LeadingIcon = null;
            this.txtFilter.Location = new System.Drawing.Point(417, 464);
            this.txtFilter.MaxLength = 50;
            this.txtFilter.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFilter.Multiline = false;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(203, 50);
            this.txtFilter.TabIndex = 7;
            this.txtFilter.Text = "";
            this.txtFilter.TrailingIcon = null;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFilter.Location = new System.Drawing.Point(318, 476);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(78, 20);
            this.lblFilter.TabIndex = 7;
            this.lblFilter.Text = "Filitrele :";
            // 
            // btnEkleSilGuncelle
            // 
            this.btnEkleSilGuncelle.AutoSize = false;
            this.btnEkleSilGuncelle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEkleSilGuncelle.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEkleSilGuncelle.Depth = 0;
            this.btnEkleSilGuncelle.HighEmphasis = true;
            this.btnEkleSilGuncelle.Icon = null;
            this.btnEkleSilGuncelle.Location = new System.Drawing.Point(234, 366);
            this.btnEkleSilGuncelle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEkleSilGuncelle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEkleSilGuncelle.Name = "btnEkleSilGuncelle";
            this.btnEkleSilGuncelle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEkleSilGuncelle.Size = new System.Drawing.Size(162, 73);
            this.btnEkleSilGuncelle.TabIndex = 6;
            this.btnEkleSilGuncelle.Text = "Ekle";
            this.btnEkleSilGuncelle.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEkleSilGuncelle.UseAccentColor = true;
            this.btnEkleSilGuncelle.UseVisualStyleBackColor = true;
            this.btnEkleSilGuncelle.Click += new System.EventHandler(this.btnEkleSilGuncelle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.AutoSize = false;
            this.btnTemizle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTemizle.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTemizle.Depth = 0;
            this.btnTemizle.HighEmphasis = true;
            this.btnTemizle.Icon = null;
            this.btnTemizle.Location = new System.Drawing.Point(15, 464);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTemizle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTemizle.Size = new System.Drawing.Size(156, 50);
            this.btnTemizle.TabIndex = 10;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTemizle.UseAccentColor = true;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // rbVar
            // 
            this.rbVar.AutoSize = true;
            this.rbVar.Depth = 0;
            this.rbVar.Location = new System.Drawing.Point(324, 469);
            this.rbVar.Margin = new System.Windows.Forms.Padding(0);
            this.rbVar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbVar.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbVar.Name = "rbVar";
            this.rbVar.Ripple = true;
            this.rbVar.Size = new System.Drawing.Size(96, 37);
            this.rbVar.TabIndex = 8;
            this.rbVar.TabStop = true;
            this.rbVar.Text = "Ürün Var";
            this.rbVar.UseVisualStyleBackColor = true;
            this.rbVar.Visible = false;
            this.rbVar.CheckedChanged += new System.EventHandler(this.rbVar_CheckedChanged);
            this.rbVar.Click += new System.EventHandler(this.rbVar_Click);
            // 
            // rbYok
            // 
            this.rbYok.AutoSize = true;
            this.rbYok.Depth = 0;
            this.rbYok.Location = new System.Drawing.Point(512, 469);
            this.rbYok.Margin = new System.Windows.Forms.Padding(0);
            this.rbYok.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbYok.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbYok.Name = "rbYok";
            this.rbYok.Ripple = true;
            this.rbYok.Size = new System.Drawing.Size(99, 37);
            this.rbYok.TabIndex = 9;
            this.rbYok.TabStop = true;
            this.rbYok.Text = "Ürün Yok";
            this.rbYok.UseVisualStyleBackColor = true;
            this.rbYok.Visible = false;
            this.rbYok.CheckedChanged += new System.EventHandler(this.rbYok_CheckedChanged);
            this.rbYok.Click += new System.EventHandler(this.rbYok_Click);
            // 
            // Urun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1270, 523);
            this.Controls.Add(this.rbYok);
            this.Controls.Add(this.rbVar);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnEkleSilGuncelle);
            this.Controls.Add(this.lblStok);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.lblBarkod);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.cbMarka);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.nupStok);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.tcUrun);
            this.Controls.Add(this.dgwListele);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Urun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ekle";
            this.Load += new System.EventHandler(this.Urun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwListele)).EndInit();
            this.tcUrun.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupStok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwListele;
        private System.Windows.Forms.TabControl tcUrun;
        private System.Windows.Forms.TabPage tpEkle;
        private System.Windows.Forms.TabPage tpSil;
        private System.Windows.Forms.TabPage tpGuncelle;
        private System.Windows.Forms.TabPage tpFilter;
        private MaterialSkin.Controls.MaterialTextBox txtBarkod;
        private System.Windows.Forms.NumericUpDown nupStok;
        private MaterialSkin.Controls.MaterialComboBox cbKategori;
        private MaterialSkin.Controls.MaterialComboBox cbMarka;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblBarkod;
        private MaterialSkin.Controls.MaterialTextBox txtFiyat;
        private MaterialSkin.Controls.MaterialTextBox txtAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblFiyat;
        private MaterialSkin.Controls.MaterialTextBox txtFilter;
        private System.Windows.Forms.Label lblFilter;
        private MaterialSkin.Controls.MaterialButton btnEkleSilGuncelle;
        private MaterialSkin.Controls.MaterialButton btnTemizle;
        private MaterialSkin.Controls.MaterialRadioButton rbVar;
        private MaterialSkin.Controls.MaterialRadioButton rbYok;
    }
}