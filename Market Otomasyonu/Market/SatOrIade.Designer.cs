namespace Market
{
    partial class SatOrIade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SatOrIade));
            this.btnİade = new MaterialSkin.Controls.MaterialButton();
            this.btnSat = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // btnİade
            // 
            this.btnİade.AutoSize = false;
            this.btnİade.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnİade.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnİade.Depth = 0;
            this.btnİade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİade.HighEmphasis = true;
            this.btnİade.Icon = null;
            this.btnİade.Location = new System.Drawing.Point(238, 53);
            this.btnİade.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnİade.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnİade.Name = "btnİade";
            this.btnİade.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnİade.Size = new System.Drawing.Size(191, 100);
            this.btnİade.TabIndex = 1;
            this.btnİade.Text = "İade";
            this.btnİade.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnİade.UseAccentColor = false;
            this.btnİade.UseVisualStyleBackColor = true;
            this.btnİade.Click += new System.EventHandler(this.btnİade_Click);
            // 
            // btnSat
            // 
            this.btnSat.AutoSize = false;
            this.btnSat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSat.Depth = 0;
            this.btnSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSat.HighEmphasis = true;
            this.btnSat.Icon = null;
            this.btnSat.Location = new System.Drawing.Point(23, 53);
            this.btnSat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSat.Name = "btnSat";
            this.btnSat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSat.Size = new System.Drawing.Size(172, 100);
            this.btnSat.TabIndex = 1;
            this.btnSat.Text = "Satış";
            this.btnSat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSat.UseAccentColor = true;
            this.btnSat.UseVisualStyleBackColor = true;
            this.btnSat.Click += new System.EventHandler(this.btnSat_Click);
            // 
            // SatOrIade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(460, 184);
            this.ControlBox = false;
            this.Controls.Add(this.btnSat);
            this.Controls.Add(this.btnİade);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SatOrIade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SatOrIade_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnİade;
        private MaterialSkin.Controls.MaterialButton btnSat;
    }
}