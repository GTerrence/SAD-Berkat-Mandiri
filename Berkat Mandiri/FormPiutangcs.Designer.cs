namespace Berkat_Mandiri
{
    partial class FormPiutangcs
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
            this.panSearch = new System.Windows.Forms.Panel();
            this.chTanggal = new System.Windows.Forms.CheckBox();
            this.dtpPiutang = new System.Windows.Forms.DateTimePicker();
            this.tbPelanggan = new System.Windows.Forms.TextBox();
            this.tbNota = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPiutang = new System.Windows.Forms.DataGridView();
            this.panSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPiutang)).BeginInit();
            this.SuspendLayout();
            // 
            // panSearch
            // 
            this.panSearch.BackColor = System.Drawing.Color.Transparent;
            this.panSearch.Controls.Add(this.chTanggal);
            this.panSearch.Controls.Add(this.dtpPiutang);
            this.panSearch.Controls.Add(this.tbPelanggan);
            this.panSearch.Controls.Add(this.tbNota);
            this.panSearch.Controls.Add(this.label4);
            this.panSearch.Controls.Add(this.label3);
            this.panSearch.Controls.Add(this.label2);
            this.panSearch.Controls.Add(this.label1);
            this.panSearch.Location = new System.Drawing.Point(22, 12);
            this.panSearch.Name = "panSearch";
            this.panSearch.Size = new System.Drawing.Size(756, 150);
            this.panSearch.TabIndex = 7;
            // 
            // chTanggal
            // 
            this.chTanggal.AutoSize = true;
            this.chTanggal.Location = new System.Drawing.Point(359, 112);
            this.chTanggal.Name = "chTanggal";
            this.chTanggal.Size = new System.Drawing.Size(112, 17);
            this.chTanggal.TabIndex = 7;
            this.chTanggal.Text = "Masukan Tanggal";
            this.chTanggal.UseVisualStyleBackColor = true;
            this.chTanggal.CheckedChanged += new System.EventHandler(this.chTanggal_CheckedChanged);
            // 
            // dtpPiutang
            // 
            this.dtpPiutang.Enabled = false;
            this.dtpPiutang.Location = new System.Drawing.Point(157, 110);
            this.dtpPiutang.Name = "dtpPiutang";
            this.dtpPiutang.Size = new System.Drawing.Size(168, 20);
            this.dtpPiutang.TabIndex = 6;
            this.dtpPiutang.ValueChanged += new System.EventHandler(this.dtpPiutang_ValueChanged);
            // 
            // tbPelanggan
            // 
            this.tbPelanggan.Location = new System.Drawing.Point(157, 80);
            this.tbPelanggan.Name = "tbPelanggan";
            this.tbPelanggan.Size = new System.Drawing.Size(168, 20);
            this.tbPelanggan.TabIndex = 5;
            this.tbPelanggan.TextChanged += new System.EventHandler(this.tbPelanggan_TextChanged);
            // 
            // tbNota
            // 
            this.tbNota.Location = new System.Drawing.Point(157, 53);
            this.tbNota.Name = "tbNota";
            this.tbNota.Size = new System.Drawing.Size(168, 20);
            this.tbNota.TabIndex = 4;
            this.tbNota.TextChanged += new System.EventHandler(this.tbNota_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tanggal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pelanggan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pencarian";
            // 
            // dgvPiutang
            // 
            this.dgvPiutang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPiutang.Location = new System.Drawing.Point(22, 168);
            this.dgvPiutang.Name = "dgvPiutang";
            this.dgvPiutang.Size = new System.Drawing.Size(756, 269);
            this.dgvPiutang.TabIndex = 8;
            this.dgvPiutang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPiutang_CellClick);
            // 
            // FormPiutangcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 449);
            this.Controls.Add(this.dgvPiutang);
            this.Controls.Add(this.panSearch);
            this.Name = "FormPiutangcs";
            this.Text = "FormPiutangcs";
            this.Load += new System.EventHandler(this.FormPiutangcs_Load);
            this.panSearch.ResumeLayout(false);
            this.panSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPiutang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panSearch;
        private System.Windows.Forms.TextBox tbPelanggan;
        private System.Windows.Forms.TextBox tbNota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPiutang;
        private System.Windows.Forms.DateTimePicker dtpPiutang;
        private System.Windows.Forms.CheckBox chTanggal;
    }
}