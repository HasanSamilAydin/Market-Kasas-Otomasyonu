namespace Market
{
    partial class Prim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prim));
            this.txtAra = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwKasiyer = new System.Windows.Forms.DataGridView();
            this.lblDeneme = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKasiyer)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAra
            // 
            this.txtAra.AnimateReadOnly = false;
            this.txtAra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAra.Depth = 0;
            this.txtAra.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAra.LeadingIcon = null;
            this.txtAra.Location = new System.Drawing.Point(95, 357);
            this.txtAra.MaxLength = 50;
            this.txtAra.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAra.Multiline = false;
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(223, 50);
            this.txtAra.TabIndex = 0;
            this.txtAra.Text = "";
            this.txtAra.TrailingIcon = null;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "ARA";
            // 
            // dgwKasiyer
            // 
            this.dgwKasiyer.AllowUserToAddRows = false;
            this.dgwKasiyer.AllowUserToDeleteRows = false;
            this.dgwKasiyer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwKasiyer.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgwKasiyer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKasiyer.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgwKasiyer.Location = new System.Drawing.Point(0, 0);
            this.dgwKasiyer.Name = "dgwKasiyer";
            this.dgwKasiyer.ReadOnly = true;
            this.dgwKasiyer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgwKasiyer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwKasiyer.Size = new System.Drawing.Size(800, 309);
            this.dgwKasiyer.TabIndex = 3;
            this.dgwKasiyer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwKasiyer_CellContentClick);
            this.dgwKasiyer.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwKasiyer_ColumnHeaderMouseClick_1);
            // 
            // lblDeneme
            // 
            this.lblDeneme.AutoSize = true;
            this.lblDeneme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDeneme.Location = new System.Drawing.Point(528, 340);
            this.lblDeneme.Name = "lblDeneme";
            this.lblDeneme.Size = new System.Drawing.Size(143, 25);
            this.lblDeneme.TabIndex = 2;
            this.lblDeneme.Text = "Kullanıcı Adı";
            // 
            // Prim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.dgwKasiyer);
            this.Controls.Add(this.lblDeneme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Prim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prim";
            this.Load += new System.EventHandler(this.Prim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKasiyer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txtAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwKasiyer;
        private System.Windows.Forms.Label lblDeneme;
    }
}