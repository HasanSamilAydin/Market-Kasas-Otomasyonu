namespace Market
{
    partial class ardinuoIade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ardinuoIade));
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.cbBantHizi = new System.Windows.Forms.ComboBox();
            this.spArdunio = new System.IO.Ports.SerialPort(this.components);
            this.tmOkuyucu = new System.Windows.Forms.Timer(this.components);
            this.btnBaglan = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // cbPorts
            // 
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(26, 23);
            this.cbPorts.Margin = new System.Windows.Forms.Padding(6);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(150, 33);
            this.cbPorts.TabIndex = 0;
            // 
            // cbBantHizi
            // 
            this.cbBantHizi.BackColor = System.Drawing.Color.Snow;
            this.cbBantHizi.FormattingEnabled = true;
            this.cbBantHizi.Location = new System.Drawing.Point(204, 23);
            this.cbBantHizi.Margin = new System.Windows.Forms.Padding(6);
            this.cbBantHizi.Name = "cbBantHizi";
            this.cbBantHizi.Size = new System.Drawing.Size(141, 33);
            this.cbBantHizi.TabIndex = 0;
            // 
            // tmOkuyucu
            // 
            this.tmOkuyucu.Tick += new System.EventHandler(this.tmOkuyucu_Tick);
            // 
            // btnBaglan
            // 
            this.btnBaglan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBaglan.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBaglan.Depth = 0;
            this.btnBaglan.HighEmphasis = true;
            this.btnBaglan.Icon = null;
            this.btnBaglan.Location = new System.Drawing.Point(366, 23);
            this.btnBaglan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBaglan.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBaglan.Size = new System.Drawing.Size(79, 36);
            this.btnBaglan.TabIndex = 2;
            this.btnBaglan.Text = "Bağlan";
            this.btnBaglan.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBaglan.UseAccentColor = true;
            this.btnBaglan.UseVisualStyleBackColor = true;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // ardinuoIade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(466, 86);
            this.ControlBox = false;
            this.Controls.Add(this.btnBaglan);
            this.Controls.Add(this.cbBantHizi);
            this.Controls.Add(this.cbPorts);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ardinuoIade";
            this.Text = "ardinuoIade";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ardinuoIade_FormClosing);
            this.Load += new System.EventHandler(this.ardinuoIade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.ComboBox cbBantHizi;
        private System.IO.Ports.SerialPort spArdunio;
        private System.Windows.Forms.Timer tmOkuyucu;
        private MaterialSkin.Controls.MaterialButton btnBaglan;
    }
}