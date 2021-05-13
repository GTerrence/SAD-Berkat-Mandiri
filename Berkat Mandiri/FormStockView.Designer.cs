namespace Berkat_Mandiri
{
    partial class FormStockView
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
            this.label4 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnKonversi = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnGanti = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nama Produk";
            // 
            // tbSearch
            // 
            this.tbSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.tbSearch.Location = new System.Drawing.Point(273, 112);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(395, 20);
            this.tbSearch.TabIndex = 10;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // btnKonversi
            // 
            this.btnKonversi.Location = new System.Drawing.Point(29, 41);
            this.btnKonversi.Name = "btnKonversi";
            this.btnKonversi.Size = new System.Drawing.Size(75, 23);
            this.btnKonversi.TabIndex = 20;
            this.btnKonversi.Text = "Konversi";
            this.btnKonversi.UseVisualStyleBackColor = true;
            this.btnKonversi.Click += new System.EventHandler(this.btnKonversi_Click);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(49, 172);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(863, 252);
            this.dgvData.TabIndex = 21;
            // 
            // btnGanti
            // 
            this.btnGanti.Location = new System.Drawing.Point(29, 12);
            this.btnGanti.Name = "btnGanti";
            this.btnGanti.Size = new System.Drawing.Size(75, 23);
            this.btnGanti.TabIndex = 22;
            this.btnGanti.Text = "Ganti";
            this.btnGanti.UseVisualStyleBackColor = true;
            this.btnGanti.Click += new System.EventHandler(this.btnGanti_Click);
            // 
            // FormStockView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(972, 479);
            this.Controls.Add(this.btnGanti);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnKonversi);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label4);
            this.Name = "FormStockView";
            this.Text = "FormStockView";
            this.Load += new System.EventHandler(this.FormStockView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnKonversi;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnGanti;
    }
}