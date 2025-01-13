namespace Market
{
    partial class Gun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gun));
            this.dgwListele = new System.Windows.Forms.DataGridView();
            this.tcIade = new System.Windows.Forms.TabControl();
            this.tpSatis = new System.Windows.Forms.TabPage();
            this.tpIade = new System.Windows.Forms.TabPage();
            this.dtpBas = new System.Windows.Forms.DateTimePicker();
            this.lblBas = new System.Windows.Forms.Label();
            this.gbAra = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilter = new MaterialSkin.Controls.MaterialTextBox();
            this.rbNakit = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbKart = new MaterialSkin.Controls.MaterialRadioButton();
            this.dtpSon = new System.Windows.Forms.DateTimePicker();
            this.cbTarih = new MaterialSkin.Controls.MaterialCheckbox();
            this.btnList = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListele)).BeginInit();
            this.tcIade.SuspendLayout();
            this.gbAra.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwListele
            // 
            this.dgwListele.AllowUserToAddRows = false;
            this.dgwListele.AllowUserToDeleteRows = false;
            this.dgwListele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwListele.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgwListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListele.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgwListele.Location = new System.Drawing.Point(207, 0);
            this.dgwListele.Name = "dgwListele";
            this.dgwListele.ReadOnly = true;
            this.dgwListele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwListele.Size = new System.Drawing.Size(727, 450);
            this.dgwListele.TabIndex = 1;
            this.dgwListele.TabStop = false;
            this.dgwListele.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwListele_ColumnHeaderMouseClick);
            // 
            // tcIade
            // 
            this.tcIade.Controls.Add(this.tpSatis);
            this.tcIade.Controls.Add(this.tpIade);
            this.tcIade.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcIade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcIade.Location = new System.Drawing.Point(0, 0);
            this.tcIade.Name = "tcIade";
            this.tcIade.SelectedIndex = 0;
            this.tcIade.Size = new System.Drawing.Size(207, 30);
            this.tcIade.TabIndex = 4;
            this.tcIade.SelectedIndexChanged += new System.EventHandler(this.tcIade_SelectedIndexChanged);
            // 
            // tpSatis
            // 
            this.tpSatis.Location = new System.Drawing.Point(4, 29);
            this.tpSatis.Name = "tpSatis";
            this.tpSatis.Padding = new System.Windows.Forms.Padding(3);
            this.tpSatis.Size = new System.Drawing.Size(199, 0);
            this.tpSatis.TabIndex = 0;
            this.tpSatis.Text = "Satış";
            this.tpSatis.UseVisualStyleBackColor = true;
            // 
            // tpIade
            // 
            this.tpIade.Location = new System.Drawing.Point(4, 29);
            this.tpIade.Name = "tpIade";
            this.tpIade.Padding = new System.Windows.Forms.Padding(3);
            this.tpIade.Size = new System.Drawing.Size(199, 0);
            this.tpIade.TabIndex = 1;
            this.tpIade.Text = "İade";
            this.tpIade.UseVisualStyleBackColor = true;
            // 
            // dtpBas
            // 
            this.dtpBas.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpBas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBas.Location = new System.Drawing.Point(11, 277);
            this.dtpBas.Name = "dtpBas";
            this.dtpBas.Size = new System.Drawing.Size(147, 20);
            this.dtpBas.TabIndex = 1;
            this.dtpBas.ValueChanged += new System.EventHandler(this.dtpBas_ValueChanged);
            // 
            // lblBas
            // 
            this.lblBas.AutoSize = true;
            this.lblBas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBas.Location = new System.Drawing.Point(12, 254);
            this.lblBas.Name = "lblBas";
            this.lblBas.Size = new System.Drawing.Size(37, 20);
            this.lblBas.TabIndex = 2;
            this.lblBas.Text = "Ara";
            // 
            // gbAra
            // 
            this.gbAra.Controls.Add(this.label2);
            this.gbAra.Controls.Add(this.txtFilter);
            this.gbAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbAra.Location = new System.Drawing.Point(5, 111);
            this.gbAra.Name = "gbAra";
            this.gbAra.Size = new System.Drawing.Size(177, 93);
            this.gbAra.TabIndex = 4;
            this.gbAra.TabStop = false;
            this.gbAra.Text = "Kasiyer Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(2, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ara";
            // 
            // txtFilter
            // 
            this.txtFilter.AnimateReadOnly = false;
            this.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilter.Depth = 0;
            this.txtFilter.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFilter.LeadingIcon = null;
            this.txtFilter.Location = new System.Drawing.Point(1, 44);
            this.txtFilter.MaxLength = 50;
            this.txtFilter.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFilter.Multiline = false;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(176, 50);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.Text = "";
            this.txtFilter.TrailingIcon = null;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // rbNakit
            // 
            this.rbNakit.AutoSize = true;
            this.rbNakit.Depth = 0;
            this.rbNakit.Location = new System.Drawing.Point(8, 95);
            this.rbNakit.Margin = new System.Windows.Forms.Padding(0);
            this.rbNakit.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbNakit.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbNakit.Name = "rbNakit";
            this.rbNakit.Ripple = true;
            this.rbNakit.Size = new System.Drawing.Size(72, 37);
            this.rbNakit.TabIndex = 2;
            this.rbNakit.TabStop = true;
            this.rbNakit.Text = "Nakit";
            this.rbNakit.UseVisualStyleBackColor = true;
            this.rbNakit.Visible = false;
            this.rbNakit.CheckedChanged += new System.EventHandler(this.rbNakit_CheckedChanged);
            this.rbNakit.Click += new System.EventHandler(this.rbNakit_Click);
            // 
            // rbKart
            // 
            this.rbKart.AutoSize = true;
            this.rbKart.Depth = 0;
            this.rbKart.Location = new System.Drawing.Point(8, 157);
            this.rbKart.Margin = new System.Windows.Forms.Padding(0);
            this.rbKart.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbKart.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbKart.Name = "rbKart";
            this.rbKart.Ripple = true;
            this.rbKart.Size = new System.Drawing.Size(64, 37);
            this.rbKart.TabIndex = 3;
            this.rbKart.TabStop = true;
            this.rbKart.Text = "Kart";
            this.rbKart.UseVisualStyleBackColor = true;
            this.rbKart.Visible = false;
            this.rbKart.Click += new System.EventHandler(this.rbKart_Click);
            // 
            // dtpSon
            // 
            this.dtpSon.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpSon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSon.Location = new System.Drawing.Point(11, 330);
            this.dtpSon.Name = "dtpSon";
            this.dtpSon.Size = new System.Drawing.Size(147, 20);
            this.dtpSon.TabIndex = 1;
            this.dtpSon.ValueChanged += new System.EventHandler(this.dtpSon_ValueChanged);
            // 
            // cbTarih
            // 
            this.cbTarih.AutoSize = true;
            this.cbTarih.Depth = 0;
            this.cbTarih.Location = new System.Drawing.Point(4, 375);
            this.cbTarih.Margin = new System.Windows.Forms.Padding(0);
            this.cbTarih.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbTarih.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbTarih.Name = "cbTarih";
            this.cbTarih.ReadOnly = false;
            this.cbTarih.Ripple = true;
            this.cbTarih.Size = new System.Drawing.Size(199, 37);
            this.cbTarih.TabIndex = 5;
            this.cbTarih.Text = "Tek Tarih İle Filitreleme";
            this.cbTarih.UseVisualStyleBackColor = true;
            this.cbTarih.CheckedChanged += new System.EventHandler(this.cbTarih_CheckedChanged);
            // 
            // btnList
            // 
            this.btnList.AutoSize = false;
            this.btnList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnList.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnList.Depth = 0;
            this.btnList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnList.HighEmphasis = true;
            this.btnList.Icon = null;
            this.btnList.Location = new System.Drawing.Point(0, 418);
            this.btnList.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnList.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnList.Name = "btnList";
            this.btnList.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnList.Size = new System.Drawing.Size(207, 32);
            this.btnList.TabIndex = 6;
            this.btnList.Text = "Listele";
            this.btnList.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnList.UseAccentColor = true;
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // Gun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(934, 450);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.cbTarih);
            this.Controls.Add(this.rbNakit);
            this.Controls.Add(this.rbKart);
            this.Controls.Add(this.gbAra);
            this.Controls.Add(this.dtpSon);
            this.Controls.Add(this.dtpBas);
            this.Controls.Add(this.lblBas);
            this.Controls.Add(this.tcIade);
            this.Controls.Add(this.dgwListele);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gü Sonun";
            this.Load += new System.EventHandler(this.Gun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwListele)).EndInit();
            this.tcIade.ResumeLayout(false);
            this.gbAra.ResumeLayout(false);
            this.gbAra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwListele;
        private System.Windows.Forms.TabControl tcIade;
        private System.Windows.Forms.TabPage tpSatis;
        private System.Windows.Forms.TabPage tpIade;
        private System.Windows.Forms.Label lblBas;
        private System.Windows.Forms.GroupBox gbAra;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox txtFilter;
        public System.Windows.Forms.DateTimePicker dtpBas;
        private MaterialSkin.Controls.MaterialRadioButton rbNakit;
        private MaterialSkin.Controls.MaterialRadioButton rbKart;
        public System.Windows.Forms.DateTimePicker dtpSon;
        private MaterialSkin.Controls.MaterialCheckbox cbTarih;
        private MaterialSkin.Controls.MaterialButton btnList;
    }
}