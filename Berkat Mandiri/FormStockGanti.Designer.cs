namespace Berkat_Mandiri
{
    partial class FormStockGanti
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
            this.panHarga = new System.Windows.Forms.Panel();
            this.btnUbah = new System.Windows.Forms.Button();
            this.tbAfter = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbBarang = new System.Windows.Forms.ComboBox();
            this.tbBefore = new System.Windows.Forms.TextBox();
            this.panHarga.SuspendLayout();
            this.SuspendLayout();
            // 
            // panHarga
            // 
            this.panHarga.BackColor = System.Drawing.Color.Gainsboro;
            this.panHarga.Controls.Add(this.btnUbah);
            this.panHarga.Controls.Add(this.tbAfter);
            this.panHarga.Controls.Add(this.label12);
            this.panHarga.Controls.Add(this.label11);
            this.panHarga.Controls.Add(this.label10);
            this.panHarga.Controls.Add(this.cbBarang);
            this.panHarga.Controls.Add(this.tbBefore);
            this.panHarga.Location = new System.Drawing.Point(12, 12);
            this.panHarga.Name = "panHarga";
            this.panHarga.Size = new System.Drawing.Size(773, 367);
            this.panHarga.TabIndex = 24;
            // 
            // btnUbah
            // 
            this.btnUbah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUbah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUbah.Font = new System.Drawing.Font("News706 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbah.Location = new System.Drawing.Point(328, 225);
            this.btnUbah.Margin = new System.Windows.Forms.Padding(1);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(114, 35);
            this.btnUbah.TabIndex = 45;
            this.btnUbah.Text = "Ubah Harga";
            this.btnUbah.UseVisualStyleBackColor = false;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // tbAfter
            // 
            this.tbAfter.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.tbAfter.Location = new System.Drawing.Point(223, 128);
            this.tbAfter.Name = "tbAfter";
            this.tbAfter.Size = new System.Drawing.Size(219, 20);
            this.tbAfter.TabIndex = 44;
            this.tbAfter.TextChanged += new System.EventHandler(this.tbAfter_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Gainsboro;
            this.label12.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(58, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 23);
            this.label12.TabIndex = 43;
            this.label12.Text = "Harga Sesudah";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Gainsboro;
            this.label11.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(58, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 23);
            this.label11.TabIndex = 42;
            this.label11.Text = "Harga Sebelum";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Gainsboro;
            this.label10.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(58, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 23);
            this.label10.TabIndex = 41;
            this.label10.Text = "Barang";
            // 
            // cbBarang
            // 
            this.cbBarang.FormattingEnabled = true;
            this.cbBarang.Location = new System.Drawing.Point(223, 45);
            this.cbBarang.Name = "cbBarang";
            this.cbBarang.Size = new System.Drawing.Size(219, 21);
            this.cbBarang.TabIndex = 40;
            this.cbBarang.SelectedIndexChanged += new System.EventHandler(this.cbBarang_SelectedIndexChanged);
            // 
            // tbBefore
            // 
            this.tbBefore.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.tbBefore.Enabled = false;
            this.tbBefore.Location = new System.Drawing.Point(223, 87);
            this.tbBefore.Name = "tbBefore";
            this.tbBefore.Size = new System.Drawing.Size(219, 20);
            this.tbBefore.TabIndex = 39;
            // 
            // FormStockGanti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(797, 409);
            this.Controls.Add(this.panHarga);
            this.Name = "FormStockGanti";
            this.Text = "Ganti Harga";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormStockGanti_FormClosed);
            this.Load += new System.EventHandler(this.FormStockGanti_Load);
            this.panHarga.ResumeLayout(false);
            this.panHarga.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panHarga;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.TextBox tbAfter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbBarang;
        private System.Windows.Forms.TextBox tbBefore;
    }
}