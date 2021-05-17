namespace Berkat_Mandiri
{
    partial class FormStockKonversi
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
            this.panStock = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbQty2 = new System.Windows.Forms.Label();
            this.lbBarang2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbSatuan = new System.Windows.Forms.ComboBox();
            this.cbBarang = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbQty1 = new System.Windows.Forms.Label();
            this.lbBarang1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbStID = new System.Windows.Forms.TextBox();
            this.panStock.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panStock
            // 
            this.panStock.BackColor = System.Drawing.Color.Gainsboro;
            this.panStock.Controls.Add(this.panel2);
            this.panStock.Controls.Add(this.numQty);
            this.panStock.Controls.Add(this.label15);
            this.panStock.Controls.Add(this.label13);
            this.panStock.Controls.Add(this.cbSatuan);
            this.panStock.Controls.Add(this.cbBarang);
            this.panStock.Controls.Add(this.label9);
            this.panStock.Controls.Add(this.btnConvert);
            this.panStock.Controls.Add(this.label12);
            this.panStock.Controls.Add(this.label11);
            this.panStock.Controls.Add(this.label10);
            this.panStock.Controls.Add(this.panel5);
            this.panStock.Controls.Add(this.tbStID);
            this.panStock.Location = new System.Drawing.Point(1, 12);
            this.panStock.Name = "panStock";
            this.panStock.Size = new System.Drawing.Size(773, 425);
            this.panStock.TabIndex = 60;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbQty2);
            this.panel2.Controls.Add(this.lbBarang2);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Location = new System.Drawing.Point(477, 195);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 114);
            this.panel2.TabIndex = 64;
            // 
            // lbQty2
            // 
            this.lbQty2.AutoSize = true;
            this.lbQty2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQty2.Location = new System.Drawing.Point(110, 58);
            this.lbQty2.Name = "lbQty2";
            this.lbQty2.Size = new System.Drawing.Size(61, 17);
            this.lbQty2.TabIndex = 4;
            this.lbQty2.Text = "0 Karung";
            // 
            // lbBarang2
            // 
            this.lbBarang2.AutoSize = true;
            this.lbBarang2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBarang2.Location = new System.Drawing.Point(110, 17);
            this.lbBarang2.Name = "lbBarang2";
            this.lbBarang2.Size = new System.Drawing.Size(51, 17);
            this.lbBarang2.TabIndex = 3;
            this.lbBarang2.Text = "Nama  ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(14, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 17);
            this.label14.TabIndex = 2;
            this.label14.Text = "Kuantitas : ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(15, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 17);
            this.label16.TabIndex = 1;
            this.label16.Text = "Nama Barang : ";
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(202, 147);
            this.numQty.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(187, 20);
            this.numQty.TabIndex = 72;
            this.numQty.ValueChanged += new System.EventHandler(this.numQty_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(341, 242);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 43);
            this.label15.TabIndex = 61;
            this.label15.Text = "_____";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(341, 195);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 43);
            this.label13.TabIndex = 60;
            this.label13.Text = "_____";
            // 
            // cbSatuan
            // 
            this.cbSatuan.FormattingEnabled = true;
            this.cbSatuan.Location = new System.Drawing.Point(202, 99);
            this.cbSatuan.Name = "cbSatuan";
            this.cbSatuan.Size = new System.Drawing.Size(187, 21);
            this.cbSatuan.TabIndex = 71;
            this.cbSatuan.SelectedIndexChanged += new System.EventHandler(this.cbSatuan_SelectedIndexChanged);
            // 
            // cbBarang
            // 
            this.cbBarang.FormattingEnabled = true;
            this.cbBarang.Location = new System.Drawing.Point(202, 56);
            this.cbBarang.Name = "cbBarang";
            this.cbBarang.Size = new System.Drawing.Size(187, 21);
            this.cbBarang.TabIndex = 70;
            this.cbBarang.SelectedIndexChanged += new System.EventHandler(this.cbBarang_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Gainsboro;
            this.label9.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 23);
            this.label9.TabIndex = 69;
            this.label9.Text = "Quantity Barang";
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConvert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConvert.Font = new System.Drawing.Font("News706 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(629, 342);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(1);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(106, 35);
            this.btnConvert.TabIndex = 68;
            this.btnConvert.Text = "Konversi";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Gainsboro;
            this.label12.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(37, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 23);
            this.label12.TabIndex = 67;
            this.label12.Text = "Konversi ke";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Gainsboro;
            this.label11.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(37, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 23);
            this.label11.TabIndex = 66;
            this.label11.Text = "Barang";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Gainsboro;
            this.label10.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 23);
            this.label10.TabIndex = 65;
            this.label10.Text = "Stock ID";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.lbQty1);
            this.panel5.Controls.Add(this.lbBarang1);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(41, 195);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(258, 114);
            this.panel5.TabIndex = 63;
            // 
            // lbQty1
            // 
            this.lbQty1.AutoSize = true;
            this.lbQty1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQty1.Location = new System.Drawing.Point(106, 58);
            this.lbQty1.Name = "lbQty1";
            this.lbQty1.Size = new System.Drawing.Size(61, 17);
            this.lbQty1.TabIndex = 4;
            this.lbQty1.Text = "0 Karung";
            // 
            // lbBarang1
            // 
            this.lbBarang1.AutoSize = true;
            this.lbBarang1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBarang1.Location = new System.Drawing.Point(106, 17);
            this.lbBarang1.Name = "lbBarang1";
            this.lbBarang1.Size = new System.Drawing.Size(51, 17);
            this.lbBarang1.TabIndex = 3;
            this.lbBarang1.Text = "Nama  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Kuantitas : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nama Barang : ";
            // 
            // tbStID
            // 
            this.tbStID.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.tbStID.Enabled = false;
            this.tbStID.Location = new System.Drawing.Point(202, 16);
            this.tbStID.Name = "tbStID";
            this.tbStID.Size = new System.Drawing.Size(187, 20);
            this.tbStID.TabIndex = 62;
            // 
            // FormStockKonversi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(797, 449);
            this.Controls.Add(this.panStock);
            this.Name = "FormStockKonversi";
            this.Text = "Konversi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormStockKonversi_FormClosed);
            this.Load += new System.EventHandler(this.FormStockKonversi_Load);
            this.panStock.ResumeLayout(false);
            this.panStock.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panStock;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbQty2;
        private System.Windows.Forms.Label lbBarang2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbSatuan;
        private System.Windows.Forms.ComboBox cbBarang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbQty1;
        private System.Windows.Forms.Label lbBarang1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbStID;
    }
}