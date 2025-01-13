namespace Market
{
    partial class Iade
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Iade));
            this.tcSatis = new MaterialSkin.Controls.MaterialTabControl();
            this.pSat = new System.Windows.Forms.TabPage();
            this.rbEkle = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbSil = new MaterialSkin.Controls.MaterialRadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbFis = new System.Windows.Forms.ListBox();
            this.cbEkle = new System.Windows.Forms.ComboBox();
            this.btnBitir = new MaterialSkin.Controls.MaterialButton();
            this.btnEkle = new MaterialSkin.Controls.MaterialButton();
            this.txtAded = new System.Windows.Forms.TextBox();
            this.txtUrunBarkodu = new System.Windows.Forms.TextBox();
            this.pbCamEkle = new System.Windows.Forms.PictureBox();
            this.tpFis = new System.Windows.Forms.TabPage();
            this.btnBitti = new MaterialSkin.Controls.MaterialButton();
            this.gbNakit = new System.Windows.Forms.GroupBox();
            this.btnHesapla = new MaterialSkin.Controls.MaterialButton();
            this.lblVerilecek = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiyat = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPara = new System.Windows.Forms.Label();
            this.gbKart = new System.Windows.Forms.GroupBox();
            this.rbTemazzıs = new System.Windows.Forms.RadioButton();
            this.rbTemaslı = new System.Windows.Forms.RadioButton();
            this.rbKart = new System.Windows.Forms.RadioButton();
            this.rbNakit = new System.Windows.Forms.RadioButton();
            this.timerCam = new System.Windows.Forms.Timer(this.components);
            this.tcSatis.SuspendLayout();
            this.pSat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamEkle)).BeginInit();
            this.tpFis.SuspendLayout();
            this.gbNakit.SuspendLayout();
            this.gbKart.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcSatis
            // 
            this.tcSatis.Controls.Add(this.pSat);
            this.tcSatis.Controls.Add(this.tpFis);
            this.tcSatis.Depth = 0;
            this.tcSatis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcSatis.Location = new System.Drawing.Point(0, 0);
            this.tcSatis.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcSatis.Multiline = true;
            this.tcSatis.Name = "tcSatis";
            this.tcSatis.SelectedIndex = 0;
            this.tcSatis.Size = new System.Drawing.Size(1002, 552);
            this.tcSatis.TabIndex = 1;
            // 
            // pSat
            // 
            this.pSat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pSat.BackgroundImage = global::Market.Properties.Resources.zyro_image__6_;
            this.pSat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pSat.Controls.Add(this.rbEkle);
            this.pSat.Controls.Add(this.rbSil);
            this.pSat.Controls.Add(this.label6);
            this.pSat.Controls.Add(this.label5);
            this.pSat.Controls.Add(this.label4);
            this.pSat.Controls.Add(this.label3);
            this.pSat.Controls.Add(this.lbFis);
            this.pSat.Controls.Add(this.cbEkle);
            this.pSat.Controls.Add(this.btnBitir);
            this.pSat.Controls.Add(this.btnEkle);
            this.pSat.Controls.Add(this.txtAded);
            this.pSat.Controls.Add(this.txtUrunBarkodu);
            this.pSat.Controls.Add(this.pbCamEkle);
            this.pSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pSat.Location = new System.Drawing.Point(4, 22);
            this.pSat.Name = "pSat";
            this.pSat.Padding = new System.Windows.Forms.Padding(3);
            this.pSat.Size = new System.Drawing.Size(994, 526);
            this.pSat.TabIndex = 0;
            this.pSat.Text = "tabPage1";
            this.pSat.Click += new System.EventHandler(this.pSat_Click);
            // 
            // rbEkle
            // 
            this.rbEkle.AutoSize = true;
            this.rbEkle.Checked = true;
            this.rbEkle.Depth = 0;
            this.rbEkle.Location = new System.Drawing.Point(299, 52);
            this.rbEkle.Margin = new System.Windows.Forms.Padding(0);
            this.rbEkle.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbEkle.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbEkle.Name = "rbEkle";
            this.rbEkle.Ripple = true;
            this.rbEkle.Size = new System.Drawing.Size(35, 37);
            this.rbEkle.TabIndex = 16;
            this.rbEkle.TabStop = true;
            this.rbEkle.UseVisualStyleBackColor = true;
            this.rbEkle.CheckedChanged += new System.EventHandler(this.rbEkle_CheckedChanged);
            // 
            // rbSil
            // 
            this.rbSil.AutoSize = true;
            this.rbSil.Depth = 0;
            this.rbSil.Location = new System.Drawing.Point(479, 52);
            this.rbSil.Margin = new System.Windows.Forms.Padding(0);
            this.rbSil.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbSil.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbSil.Name = "rbSil";
            this.rbSil.Ripple = true;
            this.rbSil.Size = new System.Drawing.Size(35, 37);
            this.rbSil.TabIndex = 16;
            this.rbSil.TabStop = true;
            this.rbSil.UseVisualStyleBackColor = true;
            this.rbSil.CheckedChanged += new System.EventHandler(this.rbEkle_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(534, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Sil";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(349, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ekle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(661, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Barkod Numarasını Giriniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(661, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ürünün adedini giriniz";
            // 
            // lbFis
            // 
            this.lbFis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbFis.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbFis.ForeColor = System.Drawing.Color.White;
            this.lbFis.FormattingEnabled = true;
            this.lbFis.ItemHeight = 24;
            this.lbFis.Location = new System.Drawing.Point(3, 3);
            this.lbFis.Name = "lbFis";
            this.lbFis.Size = new System.Drawing.Size(279, 520);
            this.lbFis.TabIndex = 14;
            // 
            // cbEkle
            // 
            this.cbEkle.FormattingEnabled = true;
            this.cbEkle.Location = new System.Drawing.Point(435, 494);
            this.cbEkle.Name = "cbEkle";
            this.cbEkle.Size = new System.Drawing.Size(121, 32);
            this.cbEkle.TabIndex = 1;
            this.cbEkle.Visible = false;
            // 
            // btnBitir
            // 
            this.btnBitir.AutoSize = false;
            this.btnBitir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBitir.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBitir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBitir.Depth = 0;
            this.btnBitir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBitir.HighEmphasis = true;
            this.btnBitir.Icon = null;
            this.btnBitir.Location = new System.Drawing.Point(423, 439);
            this.btnBitir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBitir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBitir.Name = "btnBitir";
            this.btnBitir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBitir.Size = new System.Drawing.Size(177, 36);
            this.btnBitir.TabIndex = 12;
            this.btnBitir.Text = "Bitir";
            this.btnBitir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBitir.UseAccentColor = true;
            this.btnBitir.UseVisualStyleBackColor = true;
            this.btnBitir.Click += new System.EventHandler(this.btnBitir_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEkle.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEkle.Depth = 0;
            this.btnEkle.HighEmphasis = true;
            this.btnEkle.Icon = null;
            this.btnEkle.Location = new System.Drawing.Point(759, 396);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEkle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEkle.Size = new System.Drawing.Size(64, 36);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEkle.UseAccentColor = false;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtAded
            // 
            this.txtAded.Location = new System.Drawing.Point(843, 299);
            this.txtAded.Name = "txtAded";
            this.txtAded.Size = new System.Drawing.Size(143, 29);
            this.txtAded.TabIndex = 9;
            this.txtAded.Text = "1";
            // 
            // txtUrunBarkodu
            // 
            this.txtUrunBarkodu.Location = new System.Drawing.Point(843, 263);
            this.txtUrunBarkodu.Name = "txtUrunBarkodu";
            this.txtUrunBarkodu.Size = new System.Drawing.Size(143, 29);
            this.txtUrunBarkodu.TabIndex = 9;
            // 
            // pbCamEkle
            // 
            this.pbCamEkle.BackColor = System.Drawing.Color.Transparent;
            this.pbCamEkle.Location = new System.Drawing.Point(637, 0);
            this.pbCamEkle.Margin = new System.Windows.Forms.Padding(5);
            this.pbCamEkle.Name = "pbCamEkle";
            this.pbCamEkle.Size = new System.Drawing.Size(361, 228);
            this.pbCamEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCamEkle.TabIndex = 8;
            this.pbCamEkle.TabStop = false;
            // 
            // tpFis
            // 
            this.tpFis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tpFis.BackgroundImage = global::Market.Properties.Resources.zyro_image__6_;
            this.tpFis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpFis.Controls.Add(this.btnBitti);
            this.tpFis.Controls.Add(this.gbNakit);
            this.tpFis.Controls.Add(this.lblPara);
            this.tpFis.Controls.Add(this.gbKart);
            this.tpFis.Controls.Add(this.rbKart);
            this.tpFis.Controls.Add(this.rbNakit);
            this.tpFis.Location = new System.Drawing.Point(4, 22);
            this.tpFis.Name = "tpFis";
            this.tpFis.Padding = new System.Windows.Forms.Padding(3);
            this.tpFis.Size = new System.Drawing.Size(994, 526);
            this.tpFis.TabIndex = 1;
            this.tpFis.Text = "tabPage2";
            // 
            // btnBitti
            // 
            this.btnBitti.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBitti.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBitti.Depth = 0;
            this.btnBitti.HighEmphasis = true;
            this.btnBitti.Icon = null;
            this.btnBitti.Location = new System.Drawing.Point(438, 440);
            this.btnBitti.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBitti.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBitti.Name = "btnBitti";
            this.btnBitti.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBitti.Size = new System.Drawing.Size(64, 36);
            this.btnBitti.TabIndex = 2;
            this.btnBitti.Text = "Bitir";
            this.btnBitti.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBitti.UseAccentColor = false;
            this.btnBitti.UseVisualStyleBackColor = true;
            this.btnBitti.Click += new System.EventHandler(this.btnBitti_Click);
            // 
            // gbNakit
            // 
            this.gbNakit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbNakit.Controls.Add(this.btnHesapla);
            this.gbNakit.Controls.Add(this.lblVerilecek);
            this.gbNakit.Controls.Add(this.label2);
            this.gbNakit.Controls.Add(this.txtFiyat);
            this.gbNakit.Controls.Add(this.label1);
            this.gbNakit.ForeColor = System.Drawing.Color.Black;
            this.gbNakit.Location = new System.Drawing.Point(641, 93);
            this.gbNakit.Name = "gbNakit";
            this.gbNakit.Size = new System.Drawing.Size(331, 263);
            this.gbNakit.TabIndex = 1;
            this.gbNakit.TabStop = false;
            this.gbNakit.Text = "Nakit";
            // 
            // btnHesapla
            // 
            this.btnHesapla.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHesapla.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHesapla.Depth = 0;
            this.btnHesapla.HighEmphasis = true;
            this.btnHesapla.Icon = null;
            this.btnHesapla.Location = new System.Drawing.Point(179, 97);
            this.btnHesapla.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHesapla.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHesapla.Size = new System.Drawing.Size(86, 36);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHesapla.UseAccentColor = false;
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblVerilecek
            // 
            this.lblVerilecek.AutoSize = true;
            this.lblVerilecek.ForeColor = System.Drawing.Color.White;
            this.lblVerilecek.Location = new System.Drawing.Point(175, 228);
            this.lblVerilecek.Name = "lblVerilecek";
            this.lblVerilecek.Size = new System.Drawing.Size(0, 13);
            this.lblVerilecek.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Verilecek Fiyat:";
            // 
            // txtFiyat
            // 
            this.txtFiyat.AnimateReadOnly = true;
            this.txtFiyat.BackColor = System.Drawing.SystemColors.Menu;
            this.txtFiyat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFiyat.Depth = 0;
            this.txtFiyat.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFiyat.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtFiyat.LeadingIcon = null;
            this.txtFiyat.LeaveOnEnterKey = true;
            this.txtFiyat.Location = new System.Drawing.Point(128, 25);
            this.txtFiyat.MaxLength = 50;
            this.txtFiyat.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFiyat.Multiline = false;
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(180, 36);
            this.txtFiyat.TabIndex = 0;
            this.txtFiyat.Text = "";
            this.txtFiyat.TrailingIcon = null;
            this.txtFiyat.UseTallSize = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alınan Para";
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.ForeColor = System.Drawing.Color.White;
            this.lblPara.Location = new System.Drawing.Point(462, 45);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(35, 13);
            this.lblPara.TabIndex = 1;
            this.lblPara.Text = "Tutar ";
            // 
            // gbKart
            // 
            this.gbKart.BackColor = System.Drawing.Color.Transparent;
            this.gbKart.Controls.Add(this.rbTemazzıs);
            this.gbKart.Controls.Add(this.rbTemaslı);
            this.gbKart.Location = new System.Drawing.Point(8, 72);
            this.gbKart.Name = "gbKart";
            this.gbKart.Size = new System.Drawing.Size(331, 263);
            this.gbKart.TabIndex = 1;
            this.gbKart.TabStop = false;
            this.gbKart.Text = "Kart";
            this.gbKart.Visible = false;
            // 
            // rbTemazzıs
            // 
            this.rbTemazzıs.AutoSize = true;
            this.rbTemazzıs.Checked = true;
            this.rbTemazzıs.ForeColor = System.Drawing.Color.White;
            this.rbTemazzıs.Location = new System.Drawing.Point(29, 226);
            this.rbTemazzıs.Name = "rbTemazzıs";
            this.rbTemazzıs.Size = new System.Drawing.Size(69, 17);
            this.rbTemazzıs.TabIndex = 2;
            this.rbTemazzıs.TabStop = true;
            this.rbTemazzıs.Text = "Temazsız";
            this.rbTemazzıs.UseVisualStyleBackColor = true;
            // 
            // rbTemaslı
            // 
            this.rbTemaslı.AutoSize = true;
            this.rbTemaslı.ForeColor = System.Drawing.Color.White;
            this.rbTemaslı.Location = new System.Drawing.Point(206, 226);
            this.rbTemaslı.Name = "rbTemaslı";
            this.rbTemaslı.Size = new System.Drawing.Size(61, 17);
            this.rbTemaslı.TabIndex = 2;
            this.rbTemaslı.Text = "Temaslı";
            this.rbTemaslı.UseVisualStyleBackColor = true;
            // 
            // rbKart
            // 
            this.rbKart.AutoSize = true;
            this.rbKart.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rbKart.Location = new System.Drawing.Point(8, 25);
            this.rbKart.Name = "rbKart";
            this.rbKart.Size = new System.Drawing.Size(44, 17);
            this.rbKart.TabIndex = 0;
            this.rbKart.Text = "Kart";
            this.rbKart.UseVisualStyleBackColor = true;
            // 
            // rbNakit
            // 
            this.rbNakit.AutoSize = true;
            this.rbNakit.Checked = true;
            this.rbNakit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rbNakit.Location = new System.Drawing.Point(641, 25);
            this.rbNakit.Name = "rbNakit";
            this.rbNakit.Size = new System.Drawing.Size(50, 17);
            this.rbNakit.TabIndex = 0;
            this.rbNakit.TabStop = true;
            this.rbNakit.Text = "Nakit";
            this.rbNakit.UseVisualStyleBackColor = true;
            this.rbNakit.CheckedChanged += new System.EventHandler(this.rbNakit_CheckedChanged);
            // 
            // timerCam
            // 
            this.timerCam.Tick += new System.EventHandler(this.timerCam_Tick);
            // 
            // Iade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1002, 552);
            this.Controls.Add(this.tcSatis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Iade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iade";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Iade_FormClosing);
            this.Load += new System.EventHandler(this.Iade_Load);
            this.tcSatis.ResumeLayout(false);
            this.pSat.ResumeLayout(false);
            this.pSat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamEkle)).EndInit();
            this.tpFis.ResumeLayout(false);
            this.tpFis.PerformLayout();
            this.gbNakit.ResumeLayout(false);
            this.gbNakit.PerformLayout();
            this.gbKart.ResumeLayout(false);
            this.gbKart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tcSatis;
        private System.Windows.Forms.TabPage tpFis;
        private System.Windows.Forms.Label lblPara;
        private System.Windows.Forms.GroupBox gbKart;
        private System.Windows.Forms.RadioButton rbTemazzıs;
        private System.Windows.Forms.RadioButton rbTemaslı;
        private System.Windows.Forms.RadioButton rbKart;
        private System.Windows.Forms.RadioButton rbNakit;
        private System.Windows.Forms.TabPage pSat;
        private MaterialSkin.Controls.MaterialRadioButton rbEkle;
        private MaterialSkin.Controls.MaterialRadioButton rbSil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbFis;
        private System.Windows.Forms.ComboBox cbEkle;
        private MaterialSkin.Controls.MaterialButton btnBitir;
        private MaterialSkin.Controls.MaterialButton btnEkle;
        private System.Windows.Forms.TextBox txtAded;
        private System.Windows.Forms.TextBox txtUrunBarkodu;
        private System.Windows.Forms.PictureBox pbCamEkle;
        private MaterialSkin.Controls.MaterialButton btnBitti;
        private System.Windows.Forms.GroupBox gbNakit;
        private MaterialSkin.Controls.MaterialButton btnHesapla;
        private System.Windows.Forms.Label lblVerilecek;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox txtFiyat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerCam;
    }
}