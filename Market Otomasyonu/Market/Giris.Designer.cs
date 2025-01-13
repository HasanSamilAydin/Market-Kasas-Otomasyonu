using System.Windows.Forms;

namespace Market
{
    partial class Giris
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
            else
                Application.Exit();

        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.btnGir = new MaterialSkin.Controls.MaterialButton();
            this.txtAd = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSifre = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            // 
            // lblSifre
            // 
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(-2, 137);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(109, 38);
            this.lblSifre.TabIndex = 4;
            this.lblSifre.Text = "Şifremi Unuttum";
            this.lblSifre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSifre.Click += new System.EventHandler(this.lblSifre_Click);
            // 
            // btnGir
            // 
            this.btnGir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGir.Depth = 0;
            this.btnGir.HighEmphasis = true;
            this.btnGir.Icon = null;
            this.btnGir.Location = new System.Drawing.Point(103, 139);
            this.btnGir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGir.Name = "btnGir";
            this.btnGir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGir.Size = new System.Drawing.Size(64, 36);
            this.btnGir.TabIndex = 2;
            this.btnGir.Text = "Giriş";
            this.btnGir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGir.UseAccentColor = false;
            this.btnGir.UseVisualStyleBackColor = true;
            this.btnGir.Click += new System.EventHandler(this.btnGir_Click);
            // 
            // txtAd
            // 
            this.txtAd.AnimateReadOnly = true;
            this.txtAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAd.Depth = 0;
            this.txtAd.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAd.LeadingIcon = null;
            this.txtAd.LeaveOnEnterKey = true;
            this.txtAd.Location = new System.Drawing.Point(85, 12);
            this.txtAd.MaxLength = 50;
            this.txtAd.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAd.Multiline = false;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(109, 36);
            this.txtAd.TabIndex = 0;
            this.txtAd.Text = "";
            this.txtAd.TrailingIcon = null;
            this.txtAd.UseTallSize = false;
            // 
            // txtSifre
            // 
            this.txtSifre.AnimateReadOnly = false;
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifre.Depth = 0;
            this.txtSifre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSifre.LeadingIcon = null;
            this.txtSifre.Location = new System.Drawing.Point(85, 82);
            this.txtSifre.MaxLength = 50;
            this.txtSifre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSifre.Multiline = false;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Password = true;
            this.txtSifre.Size = new System.Drawing.Size(109, 36);
            this.txtSifre.TabIndex = 1;
            this.txtSifre.Text = "";
            this.txtSifre.TrailingIcon = null;
            this.txtSifre.UseTallSize = false;
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(215, 206);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.btnGir);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSifre;
        private MaterialSkin.Controls.MaterialButton btnGir;
        private MaterialSkin.Controls.MaterialTextBox txtAd;
        private MaterialSkin.Controls.MaterialTextBox txtSifre;
    }
}