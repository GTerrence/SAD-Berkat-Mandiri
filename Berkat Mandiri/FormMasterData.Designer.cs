namespace Berkat_Mandiri
{
    partial class FormMasterData
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
            this.panel8 = new System.Windows.Forms.Panel();
            this.btInsert = new System.Windows.Forms.Button();
            this.dgvMasterData = new System.Windows.Forms.DataGridView();
            this.lbNsearch = new System.Windows.Forms.Label();
            this.tbSproduk = new System.Windows.Forms.TextBox();
            this.lbTsearch = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasterData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Silver;
            this.panel8.Controls.Add(this.btInsert);
            this.panel8.Controls.Add(this.dgvMasterData);
            this.panel8.Controls.Add(this.lbNsearch);
            this.panel8.Controls.Add(this.tbSproduk);
            this.panel8.Controls.Add(this.lbTsearch);
            this.panel8.Location = new System.Drawing.Point(12, 12);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(773, 385);
            this.panel8.TabIndex = 21;
            // 
            // btInsert
            // 
            this.btInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btInsert.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInsert.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.btInsert.ForeColor = System.Drawing.Color.Black;
            this.btInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btInsert.Location = new System.Drawing.Point(637, 342);
            this.btInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(133, 39);
            this.btInsert.TabIndex = 24;
            this.btInsert.Text = "Tambah Data";
            this.btInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btInsert.UseVisualStyleBackColor = false;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // dgvMasterData
            // 
            this.dgvMasterData.AllowUserToOrderColumns = true;
            this.dgvMasterData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMasterData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMasterData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasterData.Location = new System.Drawing.Point(3, 71);
            this.dgvMasterData.Name = "dgvMasterData";
            this.dgvMasterData.Size = new System.Drawing.Size(767, 264);
            this.dgvMasterData.TabIndex = 24;
            this.dgvMasterData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMasterData_CellClick);
            // 
            // lbNsearch
            // 
            this.lbNsearch.AutoSize = true;
            this.lbNsearch.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbNsearch.Location = new System.Drawing.Point(14, 34);
            this.lbNsearch.Name = "lbNsearch";
            this.lbNsearch.Size = new System.Drawing.Size(136, 25);
            this.lbNsearch.TabIndex = 23;
            this.lbNsearch.Text = "Nama Produk";
            // 
            // tbSproduk
            // 
            this.tbSproduk.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.tbSproduk.Location = new System.Drawing.Point(179, 31);
            this.tbSproduk.Name = "tbSproduk";
            this.tbSproduk.Size = new System.Drawing.Size(427, 32);
            this.tbSproduk.TabIndex = 22;
            this.tbSproduk.TextChanged += new System.EventHandler(this.tbSproduk_TextChanged);
            // 
            // lbTsearch
            // 
            this.lbTsearch.AutoSize = true;
            this.lbTsearch.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbTsearch.Location = new System.Drawing.Point(319, 3);
            this.lbTsearch.Name = "lbTsearch";
            this.lbTsearch.Size = new System.Drawing.Size(99, 25);
            this.lbTsearch.TabIndex = 21;
            this.lbTsearch.Text = "Pencarian";
            // 
            // FormMasterData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(797, 409);
            this.Controls.Add(this.panel8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMasterData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Master Data";
            this.Load += new System.EventHandler(this.FormMasterData_Load);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasterData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lbNsearch;
        private System.Windows.Forms.TextBox tbSproduk;
        private System.Windows.Forms.Label lbTsearch;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.DataGridView dgvMasterData;
    }
}