namespace Berkat_Mandiri
{
    partial class FormBase
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
            this.panMenu = new System.Windows.Forms.Panel();
            this.panReceivable = new System.Windows.Forms.Panel();
            this.btnReHist = new System.Windows.Forms.Button();
            this.btnReOn = new System.Windows.Forms.Button();
            this.btnReceivable = new System.Windows.Forms.Button();
            this.panTransaksi = new System.Windows.Forms.Panel();
            this.btnTrLaporan = new System.Windows.Forms.Button();
            this.btnTrInput = new System.Windows.Forms.Button();
            this.btnTransaksi = new System.Windows.Forms.Button();
            this.panStock = new System.Windows.Forms.Panel();
            this.btnStKonversi = new System.Windows.Forms.Button();
            this.btnStGanti = new System.Windows.Forms.Button();
            this.btnStView = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.panMaster = new System.Windows.Forms.Panel();
            this.btnMaSupp = new System.Windows.Forms.Button();
            this.btnMaCust = new System.Windows.Forms.Button();
            this.btnMaProd = new System.Windows.Forms.Button();
            this.btnMaster = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panMain = new System.Windows.Forms.Panel();
            this.panMenu.SuspendLayout();
            this.panReceivable.SuspendLayout();
            this.panTransaksi.SuspendLayout();
            this.panStock.SuspendLayout();
            this.panMaster.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMenu
            // 
            this.panMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
            this.panMenu.Controls.Add(this.panReceivable);
            this.panMenu.Controls.Add(this.panTransaksi);
            this.panMenu.Controls.Add(this.panStock);
            this.panMenu.Controls.Add(this.panMaster);
            this.panMenu.Controls.Add(this.btnDashboard);
            this.panMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panMenu.Location = new System.Drawing.Point(0, 0);
            this.panMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(341, 720);
            this.panMenu.TabIndex = 0;
            // 
            // panReceivable
            // 
            this.panReceivable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panReceivable.Controls.Add(this.btnReHist);
            this.panReceivable.Controls.Add(this.btnReOn);
            this.panReceivable.Controls.Add(this.btnReceivable);
            this.panReceivable.Dock = System.Windows.Forms.DockStyle.Top;
            this.panReceivable.Location = new System.Drawing.Point(0, 282);
            this.panReceivable.MaximumSize = new System.Drawing.Size(341, 172);
            this.panReceivable.MinimumSize = new System.Drawing.Size(341, 72);
            this.panReceivable.Name = "panReceivable";
            this.panReceivable.Size = new System.Drawing.Size(341, 72);
            this.panReceivable.TabIndex = 6;
            this.panReceivable.Tag = "btnReceivable";
            // 
            // btnReHist
            // 
            this.btnReHist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReHist.FlatAppearance.BorderSize = 0;
            this.btnReHist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReHist.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReHist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(84)))), ((int)(((byte)(191)))));
            this.btnReHist.Location = new System.Drawing.Point(0, 110);
            this.btnReHist.Name = "btnReHist";
            this.btnReHist.Size = new System.Drawing.Size(339, 44);
            this.btnReHist.TabIndex = 4;
            this.btnReHist.Text = "History";
            this.btnReHist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReHist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReHist.UseVisualStyleBackColor = true;
            // 
            // btnReOn
            // 
            this.btnReOn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReOn.FlatAppearance.BorderSize = 0;
            this.btnReOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReOn.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReOn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(84)))), ((int)(((byte)(191)))));
            this.btnReOn.Location = new System.Drawing.Point(0, 66);
            this.btnReOn.Name = "btnReOn";
            this.btnReOn.Size = new System.Drawing.Size(339, 44);
            this.btnReOn.TabIndex = 3;
            this.btnReOn.Text = "Ongoing Receivable";
            this.btnReOn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReOn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReOn.UseVisualStyleBackColor = true;
            // 
            // btnReceivable
            // 
            this.btnReceivable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReceivable.FlatAppearance.BorderSize = 0;
            this.btnReceivable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceivable.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceivable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(84)))), ((int)(((byte)(191)))));
            this.btnReceivable.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReceivable.Location = new System.Drawing.Point(0, 0);
            this.btnReceivable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReceivable.Name = "btnReceivable";
            this.btnReceivable.Size = new System.Drawing.Size(339, 66);
            this.btnReceivable.TabIndex = 2;
            this.btnReceivable.Tag = "panReceivable";
            this.btnReceivable.Text = "Receivable";
            this.btnReceivable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceivable.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReceivable.UseVisualStyleBackColor = true;
            this.btnReceivable.Click += new System.EventHandler(this.btnReceivable_Click);
            // 
            // panTransaksi
            // 
            this.panTransaksi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panTransaksi.Controls.Add(this.btnTrLaporan);
            this.panTransaksi.Controls.Add(this.btnTrInput);
            this.panTransaksi.Controls.Add(this.btnTransaksi);
            this.panTransaksi.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTransaksi.Location = new System.Drawing.Point(0, 210);
            this.panTransaksi.MaximumSize = new System.Drawing.Size(341, 172);
            this.panTransaksi.MinimumSize = new System.Drawing.Size(341, 72);
            this.panTransaksi.Name = "panTransaksi";
            this.panTransaksi.Size = new System.Drawing.Size(341, 72);
            this.panTransaksi.TabIndex = 6;
            this.panTransaksi.Tag = "btnTransaksi";
            // 
            // btnTrLaporan
            // 
            this.btnTrLaporan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrLaporan.FlatAppearance.BorderSize = 0;
            this.btnTrLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrLaporan.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrLaporan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(84)))), ((int)(((byte)(191)))));
            this.btnTrLaporan.Location = new System.Drawing.Point(0, 110);
            this.btnTrLaporan.Name = "btnTrLaporan";
            this.btnTrLaporan.Size = new System.Drawing.Size(339, 44);
            this.btnTrLaporan.TabIndex = 4;
            this.btnTrLaporan.Text = "Laporan";
            this.btnTrLaporan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrLaporan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrLaporan.UseVisualStyleBackColor = true;
            // 
            // btnTrInput
            // 
            this.btnTrInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrInput.FlatAppearance.BorderSize = 0;
            this.btnTrInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrInput.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(84)))), ((int)(((byte)(191)))));
            this.btnTrInput.Location = new System.Drawing.Point(0, 66);
            this.btnTrInput.Name = "btnTrInput";
            this.btnTrInput.Size = new System.Drawing.Size(339, 44);
            this.btnTrInput.TabIndex = 3;
            this.btnTrInput.Text = "Input Data";
            this.btnTrInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrInput.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrInput.UseVisualStyleBackColor = true;
            // 
            // btnTransaksi
            // 
            this.btnTransaksi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransaksi.FlatAppearance.BorderSize = 0;
            this.btnTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaksi.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaksi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(84)))), ((int)(((byte)(191)))));
            this.btnTransaksi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTransaksi.Location = new System.Drawing.Point(0, 0);
            this.btnTransaksi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTransaksi.Name = "btnTransaksi";
            this.btnTransaksi.Size = new System.Drawing.Size(339, 66);
            this.btnTransaksi.TabIndex = 2;
            this.btnTransaksi.Tag = "panTransaksi";
            this.btnTransaksi.Text = "Transaksi";
            this.btnTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaksi.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTransaksi.UseVisualStyleBackColor = true;
            this.btnTransaksi.Click += new System.EventHandler(this.btnTransaksi_Click);
            // 
            // panStock
            // 
            this.panStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panStock.Controls.Add(this.btnStKonversi);
            this.panStock.Controls.Add(this.btnStGanti);
            this.panStock.Controls.Add(this.btnStView);
            this.panStock.Controls.Add(this.btnStock);
            this.panStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.panStock.Location = new System.Drawing.Point(0, 138);
            this.panStock.MaximumSize = new System.Drawing.Size(341, 205);
            this.panStock.MinimumSize = new System.Drawing.Size(341, 72);
            this.panStock.Name = "panStock";
            this.panStock.Size = new System.Drawing.Size(341, 72);
            this.panStock.TabIndex = 5;
            this.panStock.Tag = "btnStock";
            // 
            // btnStKonversi
            // 
            this.btnStKonversi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStKonversi.FlatAppearance.BorderSize = 0;
            this.btnStKonversi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStKonversi.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStKonversi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(84)))), ((int)(((byte)(191)))));
            this.btnStKonversi.Location = new System.Drawing.Point(0, 154);
            this.btnStKonversi.Name = "btnStKonversi";
            this.btnStKonversi.Size = new System.Drawing.Size(339, 44);
            this.btnStKonversi.TabIndex = 5;
            this.btnStKonversi.Text = "Konversi Stock";
            this.btnStKonversi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStKonversi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStKonversi.UseVisualStyleBackColor = true;
            this.btnStKonversi.Click += new System.EventHandler(this.btnStKonversi_Click);
            // 
            // btnStGanti
            // 
            this.btnStGanti.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStGanti.FlatAppearance.BorderSize = 0;
            this.btnStGanti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStGanti.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStGanti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(84)))), ((int)(((byte)(191)))));
            this.btnStGanti.Location = new System.Drawing.Point(0, 110);
            this.btnStGanti.Name = "btnStGanti";
            this.btnStGanti.Size = new System.Drawing.Size(339, 44);
            this.btnStGanti.TabIndex = 4;
            this.btnStGanti.Text = "Ganti Harga";
            this.btnStGanti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStGanti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStGanti.UseVisualStyleBackColor = true;
            this.btnStGanti.Click += new System.EventHandler(this.btnStGanti_Click);
            // 
            // btnStView
            // 
            this.btnStView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStView.FlatAppearance.BorderSize = 0;
            this.btnStView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStView.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(84)))), ((int)(((byte)(191)))));
            this.btnStView.Location = new System.Drawing.Point(0, 66);
            this.btnStView.Name = "btnStView";
            this.btnStView.Size = new System.Drawing.Size(339, 44);
            this.btnStView.TabIndex = 3;
            this.btnStView.Text = "View Stock";
            this.btnStView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStView.UseVisualStyleBackColor = true;
            this.btnStView.Click += new System.EventHandler(this.btnStView_Click);
            // 
            // btnStock
            // 
            this.btnStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(84)))), ((int)(((byte)(191)))));
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStock.Location = new System.Drawing.Point(0, 0);
            this.btnStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(339, 66);
            this.btnStock.TabIndex = 2;
            this.btnStock.Tag = "panStock";
            this.btnStock.Text = " Stock";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // panMaster
            // 
            this.panMaster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panMaster.Controls.Add(this.btnMaSupp);
            this.panMaster.Controls.Add(this.btnMaCust);
            this.panMaster.Controls.Add(this.btnMaProd);
            this.panMaster.Controls.Add(this.btnMaster);
            this.panMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.panMaster.Location = new System.Drawing.Point(0, 66);
            this.panMaster.MaximumSize = new System.Drawing.Size(341, 205);
            this.panMaster.MinimumSize = new System.Drawing.Size(341, 72);
            this.panMaster.Name = "panMaster";
            this.panMaster.Size = new System.Drawing.Size(341, 72);
            this.panMaster.TabIndex = 6;
            this.panMaster.Tag = "btnMaster";
            // 
            // btnMaSupp
            // 
            this.btnMaSupp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaSupp.FlatAppearance.BorderSize = 0;
            this.btnMaSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaSupp.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaSupp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(84)))), ((int)(((byte)(191)))));
            this.btnMaSupp.Location = new System.Drawing.Point(0, 154);
            this.btnMaSupp.Name = "btnMaSupp";
            this.btnMaSupp.Size = new System.Drawing.Size(339, 44);
            this.btnMaSupp.TabIndex = 5;
            this.btnMaSupp.Text = "Supplier";
            this.btnMaSupp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaSupp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaSupp.UseVisualStyleBackColor = true;
            // 
            // btnMaCust
            // 
            this.btnMaCust.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaCust.FlatAppearance.BorderSize = 0;
            this.btnMaCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaCust.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaCust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(84)))), ((int)(((byte)(191)))));
            this.btnMaCust.Location = new System.Drawing.Point(0, 110);
            this.btnMaCust.Name = "btnMaCust";
            this.btnMaCust.Size = new System.Drawing.Size(339, 44);
            this.btnMaCust.TabIndex = 4;
            this.btnMaCust.Text = "Pelanggan";
            this.btnMaCust.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaCust.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaCust.UseVisualStyleBackColor = true;
            // 
            // btnMaProd
            // 
            this.btnMaProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaProd.FlatAppearance.BorderSize = 0;
            this.btnMaProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaProd.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(84)))), ((int)(((byte)(191)))));
            this.btnMaProd.Location = new System.Drawing.Point(0, 66);
            this.btnMaProd.Name = "btnMaProd";
            this.btnMaProd.Size = new System.Drawing.Size(339, 44);
            this.btnMaProd.TabIndex = 3;
            this.btnMaProd.Text = "Produk";
            this.btnMaProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaProd.UseVisualStyleBackColor = true;
            // 
            // btnMaster
            // 
            this.btnMaster.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaster.FlatAppearance.BorderSize = 0;
            this.btnMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaster.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaster.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(84)))), ((int)(((byte)(191)))));
            this.btnMaster.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMaster.Location = new System.Drawing.Point(0, 0);
            this.btnMaster.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMaster.Name = "btnMaster";
            this.btnMaster.Size = new System.Drawing.Size(339, 66);
            this.btnMaster.TabIndex = 2;
            this.btnMaster.Tag = "panMaster";
            this.btnMaster.Text = "Master Data";
            this.btnMaster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaster.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMaster.UseVisualStyleBackColor = true;
            this.btnMaster.Click += new System.EventHandler(this.btnMaster_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(84)))), ((int)(((byte)(191)))));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(341, 66);
            this.btnDashboard.TabIndex = 4;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.lbTitle.Location = new System.Drawing.Point(437, 32);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(161, 45);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "PIUTANG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.label3.Location = new System.Drawing.Point(835, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(433, 65);
            this.label3.TabIndex = 3;
            this.label3.Text = "BERKAT MANDIRI";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panMain
            // 
            this.panMain.Location = new System.Drawing.Point(347, 159);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(928, 549);
            this.panMain.TabIndex = 4;
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panMain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.panMenu);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panMenu.ResumeLayout(false);
            this.panReceivable.ResumeLayout(false);
            this.panTransaksi.ResumeLayout(false);
            this.panStock.ResumeLayout(false);
            this.panMaster.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panMenu;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.Panel panStock;
        private System.Windows.Forms.Button btnStKonversi;
        private System.Windows.Forms.Button btnStGanti;
        private System.Windows.Forms.Button btnStView;
        private System.Windows.Forms.Panel panMaster;
        private System.Windows.Forms.Button btnMaSupp;
        private System.Windows.Forms.Button btnMaCust;
        private System.Windows.Forms.Button btnMaProd;
        private System.Windows.Forms.Button btnMaster;
        private System.Windows.Forms.Panel panReceivable;
        private System.Windows.Forms.Button btnReHist;
        private System.Windows.Forms.Button btnReOn;
        private System.Windows.Forms.Button btnReceivable;
        private System.Windows.Forms.Panel panTransaksi;
        private System.Windows.Forms.Button btnTrLaporan;
        private System.Windows.Forms.Button btnTrInput;
        private System.Windows.Forms.Button btnTransaksi;
    }
}

