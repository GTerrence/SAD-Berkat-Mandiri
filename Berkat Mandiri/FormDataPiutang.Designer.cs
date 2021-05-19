namespace Berkat_Mandiri
{
    partial class FormDataPiutang
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
            this.bar = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelNama = new System.Windows.Forms.Label();
            this.tbPelanggan = new System.Windows.Forms.TextBox();
            this.tbBayar = new System.Windows.Forms.TextBox();
            this.btBatal = new System.Windows.Forms.Button();
            this.btTambah = new System.Windows.Forms.Button();
            this.labelStat = new System.Windows.Forms.Label();
            this.labelTanggal = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.tbStat = new System.Windows.Forms.TextBox();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbDibayar = new System.Windows.Forms.Label();
            this.lbKurang = new System.Windows.Forms.Label();
            this.bar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.bar.Controls.Add(this.lbTitle);
            this.bar.Location = new System.Drawing.Point(0, 0);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(640, 48);
            this.bar.TabIndex = 2;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(15, 7);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(180, 32);
            this.lbTitle.TabIndex = 24;
            this.lbTitle.Text = "Data Transaksi";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbKurang);
            this.panel2.Controls.Add(this.lbDibayar);
            this.panel2.Controls.Add(this.lbTotal);
            this.panel2.Controls.Add(this.tbID);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dtpTanggal);
            this.panel2.Controls.Add(this.tbStat);
            this.panel2.Controls.Add(this.labelNama);
            this.panel2.Controls.Add(this.tbPelanggan);
            this.panel2.Controls.Add(this.tbBayar);
            this.panel2.Controls.Add(this.btBatal);
            this.panel2.Controls.Add(this.btTambah);
            this.panel2.Controls.Add(this.labelStat);
            this.panel2.Controls.Add(this.labelTanggal);
            this.panel2.Controls.Add(this.labelID);
            this.panel2.Location = new System.Drawing.Point(12, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(616, 420);
            this.panel2.TabIndex = 3;
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.Location = new System.Drawing.Point(31, 49);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(110, 30);
            this.labelNama.TabIndex = 34;
            this.labelNama.Text = "Pelanggan";
            // 
            // tbPelanggan
            // 
            this.tbPelanggan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.tbPelanggan.Location = new System.Drawing.Point(204, 50);
            this.tbPelanggan.Name = "tbPelanggan";
            this.tbPelanggan.Size = new System.Drawing.Size(346, 31);
            this.tbPelanggan.TabIndex = 31;
            // 
            // tbBayar
            // 
            this.tbBayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.tbBayar.Location = new System.Drawing.Point(204, 287);
            this.tbBayar.Name = "tbBayar";
            this.tbBayar.Size = new System.Drawing.Size(346, 31);
            this.tbBayar.TabIndex = 30;
            // 
            // btBatal
            // 
            this.btBatal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btBatal.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBatal.Font = new System.Drawing.Font("Nirmala UI", 15F);
            this.btBatal.ForeColor = System.Drawing.Color.Black;
            this.btBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBatal.Location = new System.Drawing.Point(119, 355);
            this.btBatal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btBatal.Name = "btBatal";
            this.btBatal.Size = new System.Drawing.Size(136, 49);
            this.btBatal.TabIndex = 29;
            this.btBatal.Text = "Batal";
            this.btBatal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btBatal.UseVisualStyleBackColor = false;
            this.btBatal.Click += new System.EventHandler(this.btBatal_Click);
            // 
            // btTambah
            // 
            this.btTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btTambah.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTambah.Font = new System.Drawing.Font("Nirmala UI", 15F);
            this.btTambah.ForeColor = System.Drawing.Color.Black;
            this.btTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTambah.Location = new System.Drawing.Point(377, 355);
            this.btTambah.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btTambah.Name = "btTambah";
            this.btTambah.Size = new System.Drawing.Size(136, 49);
            this.btTambah.TabIndex = 28;
            this.btTambah.Text = "Bayar";
            this.btTambah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTambah.UseVisualStyleBackColor = false;
            this.btTambah.Click += new System.EventHandler(this.btTambah_Click);
            // 
            // labelStat
            // 
            this.labelStat.AutoSize = true;
            this.labelStat.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStat.Location = new System.Drawing.Point(31, 127);
            this.labelStat.Name = "labelStat";
            this.labelStat.Size = new System.Drawing.Size(69, 30);
            this.labelStat.TabIndex = 26;
            this.labelStat.Text = "Status";
            // 
            // labelTanggal
            // 
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTanggal.Location = new System.Drawing.Point(31, 91);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(85, 30);
            this.labelTanggal.TabIndex = 25;
            this.labelTanggal.Text = "Tanggal";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(31, 14);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(86, 30);
            this.labelID.TabIndex = 24;
            this.labelID.Text = "ID Nota";
            // 
            // tbStat
            // 
            this.tbStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.tbStat.Location = new System.Drawing.Point(204, 128);
            this.tbStat.Name = "tbStat";
            this.tbStat.Size = new System.Drawing.Size(346, 31);
            this.tbStat.TabIndex = 35;
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.CustomFormat = "";
            this.dtpTanggal.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTanggal.Location = new System.Drawing.Point(204, 87);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(346, 35);
            this.dtpTanggal.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 30);
            this.label1.TabIndex = 37;
            this.label1.Text = "Total Penjualan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 30);
            this.label2.TabIndex = 38;
            this.label2.Text = "Telah Dibayar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 30);
            this.label3.TabIndex = 39;
            this.label3.Text = "Kurang Bayar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 30);
            this.label4.TabIndex = 40;
            this.label4.Text = "Bayar";
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.tbID.Location = new System.Drawing.Point(204, 15);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(346, 31);
            this.tbID.TabIndex = 41;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(199, 192);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(153, 30);
            this.lbTotal.TabIndex = 42;
            this.lbTotal.Text = "Total Penjualan";
            // 
            // lbDibayar
            // 
            this.lbDibayar.AutoSize = true;
            this.lbDibayar.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDibayar.Location = new System.Drawing.Point(199, 222);
            this.lbDibayar.Name = "lbDibayar";
            this.lbDibayar.Size = new System.Drawing.Size(153, 30);
            this.lbDibayar.TabIndex = 43;
            this.lbDibayar.Text = "Total Penjualan";
            // 
            // lbKurang
            // 
            this.lbKurang.AutoSize = true;
            this.lbKurang.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKurang.Location = new System.Drawing.Point(199, 252);
            this.lbKurang.Name = "lbKurang";
            this.lbKurang.Size = new System.Drawing.Size(153, 30);
            this.lbKurang.TabIndex = 44;
            this.lbKurang.Text = "Total Penjualan";
            // 
            // FormDataPiutang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDataPiutang";
            this.Text = "FormDataPiutang";
            this.Load += new System.EventHandler(this.FormDataPiutang_Load);
            this.bar.ResumeLayout(false);
            this.bar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bar;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.TextBox tbPelanggan;
        private System.Windows.Forms.TextBox tbBayar;
        private System.Windows.Forms.Button btBatal;
        private System.Windows.Forms.Button btTambah;
        private System.Windows.Forms.Label labelStat;
        private System.Windows.Forms.Label labelTanggal;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label lbKurang;
        private System.Windows.Forms.Label lbDibayar;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.TextBox tbStat;
    }
}