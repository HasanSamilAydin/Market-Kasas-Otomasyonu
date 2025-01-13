namespace Market
{
    partial class Sifre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sifre));
            this.tabl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbGiris = new System.Windows.Forms.GroupBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOnay = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPosta = new MaterialSkin.Controls.MaterialTextBox();
            this.btnOnay = new MaterialSkin.Controls.MaterialButton();
            this.btnMail = new MaterialSkin.Controls.MaterialButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.btnSifre = new MaterialSkin.Controls.MaterialButton();
            this.txtSifre = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSifreTekrar = new MaterialSkin.Controls.MaterialTextBox();
            this.tmOnayKodu = new System.Windows.Forms.Timer(this.components);
            this.tabl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbGiris.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabl
            // 
            this.tabl.Controls.Add(this.tabPage1);
            this.tabl.Controls.Add(this.tabPage2);
            this.tabl.Depth = 0;
            this.tabl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabl.Location = new System.Drawing.Point(0, 0);
            this.tabl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabl.Multiline = true;
            this.tabl.Name = "tabl";
            this.tabl.SelectedIndex = 0;
            this.tabl.Size = new System.Drawing.Size(432, 391);
            this.tabl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.gbGiris);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(424, 365);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // gbGiris
            // 
            this.gbGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gbGiris.Controls.Add(this.lblTimer);
            this.gbGiris.Controls.Add(this.label1);
            this.gbGiris.Controls.Add(this.txtOnay);
            this.gbGiris.Controls.Add(this.txtPosta);
            this.gbGiris.Controls.Add(this.btnOnay);
            this.gbGiris.Controls.Add(this.btnMail);
            this.gbGiris.Location = new System.Drawing.Point(81, 26);
            this.gbGiris.Name = "gbGiris";
            this.gbGiris.Size = new System.Drawing.Size(247, 285);
            this.gbGiris.TabIndex = 1;
            this.gbGiris.TabStop = false;
            this.gbGiris.Text = "Onay Kodu";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTimer.Location = new System.Drawing.Point(171, 106);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 16);
            this.lblTimer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı\r\n   Adı";
            // 
            // txtOnay
            // 
            this.txtOnay.AnimateReadOnly = false;
            this.txtOnay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOnay.Depth = 0;
            this.txtOnay.Enabled = false;
            this.txtOnay.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtOnay.LeadingIcon = null;
            this.txtOnay.Location = new System.Drawing.Point(25, 177);
            this.txtOnay.MaxLength = 50;
            this.txtOnay.MouseState = MaterialSkin.MouseState.OUT;
            this.txtOnay.Multiline = false;
            this.txtOnay.Name = "txtOnay";
            this.txtOnay.Size = new System.Drawing.Size(100, 50);
            this.txtOnay.TabIndex = 1;
            this.txtOnay.Text = "";
            this.txtOnay.TrailingIcon = null;
            // 
            // txtPosta
            // 
            this.txtPosta.AnimateReadOnly = false;
            this.txtPosta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPosta.Depth = 0;
            this.txtPosta.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPosta.LeadingIcon = null;
            this.txtPosta.Location = new System.Drawing.Point(77, 34);
            this.txtPosta.MaxLength = 50;
            this.txtPosta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPosta.Multiline = false;
            this.txtPosta.Name = "txtPosta";
            this.txtPosta.Size = new System.Drawing.Size(149, 50);
            this.txtPosta.TabIndex = 1;
            this.txtPosta.Text = "";
            this.txtPosta.TrailingIcon = null;
            // 
            // btnOnay
            // 
            this.btnOnay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOnay.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOnay.Depth = 0;
            this.btnOnay.Enabled = false;
            this.btnOnay.HighEmphasis = true;
            this.btnOnay.Icon = null;
            this.btnOnay.Location = new System.Drawing.Point(43, 236);
            this.btnOnay.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOnay.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOnay.Size = new System.Drawing.Size(121, 36);
            this.btnOnay.TabIndex = 0;
            this.btnOnay.Text = "Kodu Onayla";
            this.btnOnay.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOnay.UseAccentColor = true;
            this.btnOnay.UseVisualStyleBackColor = true;
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // btnMail
            // 
            this.btnMail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMail.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMail.Depth = 0;
            this.btnMail.HighEmphasis = true;
            this.btnMail.Icon = null;
            this.btnMail.Location = new System.Drawing.Point(9, 93);
            this.btnMail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMail.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMail.Name = "btnMail";
            this.btnMail.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnMail.Size = new System.Drawing.Size(118, 36);
            this.btnMail.TabIndex = 0;
            this.btnMail.Text = "Mail Gönder";
            this.btnMail.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMail.UseAccentColor = true;
            this.btnMail.UseVisualStyleBackColor = true;
            this.btnMail.Click += new System.EventHandler(this.btnMail_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(424, 365);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblSifre);
            this.groupBox1.Controls.Add(this.btnSifre);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.txtSifreTekrar);
            this.groupBox1.Location = new System.Drawing.Point(58, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 222);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şifre Değiştir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yeni Şifreyi Girin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yeni Şifreyi Girin";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(7, 137);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(0, 13);
            this.lblSifre.TabIndex = 2;
            // 
            // btnSifre
            // 
            this.btnSifre.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSifre.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSifre.Depth = 0;
            this.btnSifre.HighEmphasis = true;
            this.btnSifre.Icon = null;
            this.btnSifre.Location = new System.Drawing.Point(56, 161);
            this.btnSifre.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSifre.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSifre.Name = "btnSifre";
            this.btnSifre.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSifre.Size = new System.Drawing.Size(85, 36);
            this.btnSifre.TabIndex = 1;
            this.btnSifre.Text = "Değiştir";
            this.btnSifre.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSifre.UseAccentColor = false;
            this.btnSifre.UseVisualStyleBackColor = true;
            this.btnSifre.Click += new System.EventHandler(this.materialButton1_Click_1);
            // 
            // txtSifre
            // 
            this.txtSifre.AnimateReadOnly = false;
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifre.Depth = 0;
            this.txtSifre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSifre.LeadingIcon = null;
            this.txtSifre.Location = new System.Drawing.Point(126, 19);
            this.txtSifre.MaxLength = 50;
            this.txtSifre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSifre.Multiline = false;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(140, 50);
            this.txtSifre.TabIndex = 0;
            this.txtSifre.Text = "";
            this.txtSifre.TrailingIcon = null;
            this.txtSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            // 
            // txtSifreTekrar
            // 
            this.txtSifreTekrar.AnimateReadOnly = false;
            this.txtSifreTekrar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifreTekrar.Depth = 0;
            this.txtSifreTekrar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSifreTekrar.LeadingIcon = null;
            this.txtSifreTekrar.Location = new System.Drawing.Point(126, 75);
            this.txtSifreTekrar.MaxLength = 50;
            this.txtSifreTekrar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSifreTekrar.Multiline = false;
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.Size = new System.Drawing.Size(140, 50);
            this.txtSifreTekrar.TabIndex = 0;
            this.txtSifreTekrar.Text = "";
            this.txtSifreTekrar.TrailingIcon = null;
            this.txtSifreTekrar.TextChanged += new System.EventHandler(this.txtSifreTekrar_TextChanged);
            // 
            // tmOnayKodu
            // 
            this.tmOnayKodu.Tick += new System.EventHandler(this.tmOnayKodu_Tick);
            // 
            // Sifre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(432, 391);
            this.Controls.Add(this.tabl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sifre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sifre";
            this.Load += new System.EventHandler(this.Sifre_Load);
            this.tabl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbGiris.ResumeLayout(false);
            this.gbGiris.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbGiris;
        private MaterialSkin.Controls.MaterialButton btnMail;
        private MaterialSkin.Controls.MaterialTextBox txtPosta;
        private MaterialSkin.Controls.MaterialTextBox txtOnay;
        private MaterialSkin.Controls.MaterialButton btnOnay;
        private MaterialSkin.Controls.MaterialTextBox txtSifre;
        private MaterialSkin.Controls.MaterialTextBox txtSifreTekrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton btnSifre;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tmOnayKodu;
        private System.Windows.Forms.Label lblTimer;
    }
}