namespace Market
{
    partial class Satis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Satis));
            this.timerCam = new System.Windows.Forms.Timer(this.components);
            this.tpFis = new System.Windows.Forms.TabPage();
            this.btnBitti = new MaterialSkin.Controls.MaterialButton();
            this.gbNakit = new System.Windows.Forms.GroupBox();
            this.btnHesapla = new MaterialSkin.Controls.MaterialButton();
            this.lblVerilecek = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiyat = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPara = new System.Windows.Forms.Label();
            this.rbKart = new System.Windows.Forms.RadioButton();
            this.rbNakit = new System.Windows.Forms.RadioButton();
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
            this.tcSatis = new MaterialSkin.Controls.MaterialTabControl();
            this.tpFis.SuspendLayout();
            this.gbNakit.SuspendLayout();
            this.pSat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamEkle)).BeginInit();
            this.tcSatis.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerCam
            // 
            this.timerCam.Interval = 10;
            this.timerCam.Tick += new System.EventHandler(this.timerCam_Tick);
            // 
            // tpFis
            // 
            this.tpFis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tpFis.BackgroundImage = global::Market.Properties.Resources.zyro_image__6_;
            this.tpFis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpFis.Controls.Add(this.btnBitti);
            this.tpFis.Controls.Add(this.gbNakit);
            this.tpFis.Controls.Add(this.lblPara);
            this.tpFis.Controls.Add(this.rbKart);
            this.tpFis.Controls.Add(this.rbNakit);
            this.tpFis.Location = new System.Drawing.Point(4, 29);
            this.tpFis.Name = "tpFis";
            this.tpFis.Padding = new System.Windows.Forms.Padding(3);
            this.tpFis.Size = new System.Drawing.Size(961, 534);
            this.tpFis.TabIndex = 1;
            this.tpFis.Text = "tabPage2";
            this.tpFis.Click += new System.EventHandler(this.tpFis_Click);
            // 
            // btnBitti
            // 
            this.btnBitti.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBitti.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBitti.Depth = 0;
            this.btnBitti.HighEmphasis = true;
            this.btnBitti.Icon = null;
            this.btnBitti.Location = new System.Drawing.Point(404, 438);
            this.btnBitti.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBitti.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBitti.Name = "btnBitti";
            this.btnBitti.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBitti.Size = new System.Drawing.Size(64, 36);
            this.btnBitti.TabIndex = 3;
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
            this.gbNakit.Location = new System.Drawing.Point(616, 94);
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
            this.lblVerilecek.Size = new System.Drawing.Size(0, 20);
            this.lblVerilecek.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
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
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alınan Para";
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.ForeColor = System.Drawing.Color.White;
            this.lblPara.Location = new System.Drawing.Point(424, 49);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(56, 20);
            this.lblPara.TabIndex = 1;
            this.lblPara.Text = "Tutar ";
            // 
            // rbKart
            // 
            this.rbKart.AutoSize = true;
            this.rbKart.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rbKart.Location = new System.Drawing.Point(48, 203);
            this.rbKart.Name = "rbKart";
            this.rbKart.Size = new System.Drawing.Size(60, 24);
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
            this.rbNakit.Size = new System.Drawing.Size(68, 24);
            this.rbNakit.TabIndex = 0;
            this.rbNakit.TabStop = true;
            this.rbNakit.Text = "Nakit";
            this.rbNakit.UseVisualStyleBackColor = true;
            this.rbNakit.CheckedChanged += new System.EventHandler(this.rbNakit_CheckedChanged);
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
            this.pSat.Location = new System.Drawing.Point(4, 29);
            this.pSat.Name = "pSat";
            this.pSat.Padding = new System.Windows.Forms.Padding(3);
            this.pSat.Size = new System.Drawing.Size(961, 534);
            this.pSat.TabIndex = 0;
            this.pSat.Text = "tabPage1";
            this.pSat.Click += new System.EventHandler(this.pSat_Click);
            // 
            // rbEkle
            // 
            this.rbEkle.AutoSize = true;
            this.rbEkle.Checked = true;
            this.rbEkle.Depth = 0;
            this.rbEkle.Location = new System.Drawing.Point(311, 61);
            this.rbEkle.Margin = new System.Windows.Forms.Padding(0);
            this.rbEkle.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbEkle.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbEkle.Name = "rbEkle";
            this.rbEkle.Ripple = true;
            this.rbEkle.Size = new System.Drawing.Size(35, 37);
            this.rbEkle.TabIndex = 16;
            this.rbEkle.TabStop = true;
            this.rbEkle.UseVisualStyleBackColor = true;
            this.rbEkle.CheckedChanged += new System.EventHandler(this.rbSil_CheckedChanged);
            // 
            // rbSil
            // 
            this.rbSil.AutoSize = true;
            this.rbSil.Depth = 0;
            this.rbSil.Location = new System.Drawing.Point(460, 61);
            this.rbSil.Margin = new System.Windows.Forms.Padding(0);
            this.rbSil.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbSil.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbSil.Name = "rbSil";
            this.rbSil.Ripple = true;
            this.rbSil.Size = new System.Drawing.Size(35, 37);
            this.rbSil.TabIndex = 16;
            this.rbSil.TabStop = true;
            this.rbSil.UseVisualStyleBackColor = true;
            this.rbSil.CheckedChanged += new System.EventHandler(this.rbSil_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(498, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Sil";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(349, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ekle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(619, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Barkod Numarasını Giriniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(619, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ürünün adedini giriniz";
            // 
            // lbFis
            // 
            this.lbFis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbFis.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbFis.ForeColor = System.Drawing.Color.White;
            this.lbFis.FormattingEnabled = true;
            this.lbFis.ItemHeight = 20;
            this.lbFis.Location = new System.Drawing.Point(3, 3);
            this.lbFis.Name = "lbFis";
            this.lbFis.Size = new System.Drawing.Size(279, 528);
            this.lbFis.TabIndex = 14;
            this.lbFis.SelectedIndexChanged += new System.EventHandler(this.lbFis_SelectedIndexChanged);
            // 
            // cbEkle
            // 
            this.cbEkle.FormattingEnabled = true;
            this.cbEkle.Location = new System.Drawing.Point(479, 444);
            this.cbEkle.Name = "cbEkle";
            this.cbEkle.Size = new System.Drawing.Size(121, 28);
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
            this.btnBitir.Location = new System.Drawing.Point(697, 444);
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
            this.btnBitir.Click += new System.EventHandler(this.btnBitir_Click_1);
            // 
            // btnEkle
            // 
            this.btnEkle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEkle.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEkle.Depth = 0;
            this.btnEkle.HighEmphasis = true;
            this.btnEkle.Icon = null;
            this.btnEkle.Location = new System.Drawing.Point(888, 322);
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
            this.txtAded.Location = new System.Drawing.Point(623, 358);
            this.txtAded.Name = "txtAded";
            this.txtAded.Size = new System.Drawing.Size(143, 26);
            this.txtAded.TabIndex = 9;
            this.txtAded.Text = "1";
            // 
            // txtUrunBarkodu
            // 
            this.txtUrunBarkodu.Location = new System.Drawing.Point(637, 267);
            this.txtUrunBarkodu.Name = "txtUrunBarkodu";
            this.txtUrunBarkodu.Size = new System.Drawing.Size(143, 26);
            this.txtUrunBarkodu.TabIndex = 9;
            // 
            // pbCamEkle
            // 
            this.pbCamEkle.BackColor = System.Drawing.Color.Transparent;
            this.pbCamEkle.Location = new System.Drawing.Point(637, 34);
            this.pbCamEkle.Margin = new System.Windows.Forms.Padding(5);
            this.pbCamEkle.Name = "pbCamEkle";
            this.pbCamEkle.Size = new System.Drawing.Size(319, 216);
            this.pbCamEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCamEkle.TabIndex = 8;
            this.pbCamEkle.TabStop = false;
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
            this.tcSatis.Size = new System.Drawing.Size(969, 567);
            this.tcSatis.TabIndex = 0;
            // 
            // Satis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::Market.Properties.Resources.zyro_image__6_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(969, 567);
            this.Controls.Add(this.tcSatis);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Satis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satis";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Satis_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Satis_FormClosed);
            this.Load += new System.EventHandler(this.Satis_Load);
            this.tpFis.ResumeLayout(false);
            this.tpFis.PerformLayout();
            this.gbNakit.ResumeLayout(false);
            this.gbNakit.PerformLayout();
            this.pSat.ResumeLayout(false);
            this.pSat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamEkle)).EndInit();
            this.tcSatis.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Timer timerCam;
        private System.Windows.Forms.TabPage tpFis;
        private System.Windows.Forms.GroupBox gbNakit;
        private MaterialSkin.Controls.MaterialButton btnHesapla;
        private System.Windows.Forms.Label lblVerilecek;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox txtFiyat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPara;
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
        private MaterialSkin.Controls.MaterialTabControl tcSatis;
        private MaterialSkin.Controls.MaterialButton btnBitti;
    }
}