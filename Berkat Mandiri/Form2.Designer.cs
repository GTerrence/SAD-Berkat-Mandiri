namespace Berkat_Mandiri
{
    partial class FormDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelPiutang = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPiutang = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKasir = new System.Windows.Forms.Button();
            this.btnStok = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.chartSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelPiutang.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPiutang
            // 
            this.panelPiutang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.panelPiutang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPiutang.Controls.Add(this.label3);
            this.panelPiutang.Controls.Add(this.lbPiutang);
            this.panelPiutang.Controls.Add(this.label1);
            this.panelPiutang.Location = new System.Drawing.Point(57, 61);
            this.panelPiutang.Name = "panelPiutang";
            this.panelPiutang.Size = new System.Drawing.Size(284, 134);
            this.panelPiutang.TabIndex = 0;
            this.panelPiutang.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPiutang_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Piutang";
            // 
            // lbPiutang
            // 
            this.lbPiutang.AutoSize = true;
            this.lbPiutang.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPiutang.ForeColor = System.Drawing.Color.Red;
            this.lbPiutang.Location = new System.Drawing.Point(67, 70);
            this.lbPiutang.Name = "lbPiutang";
            this.lbPiutang.Size = new System.Drawing.Size(102, 37);
            this.lbPiutang.TabIndex = 1;
            this.lbPiutang.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.panel1.Controls.Add(this.btnStok);
            this.panel1.Controls.Add(this.btnKasir);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(467, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 134);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quick Access";
            // 
            // btnKasir
            // 
            this.btnKasir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKasir.Location = new System.Drawing.Point(23, 63);
            this.btnKasir.Name = "btnKasir";
            this.btnKasir.Size = new System.Drawing.Size(174, 60);
            this.btnKasir.TabIndex = 4;
            this.btnKasir.Text = "   Kasir";
            this.btnKasir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKasir.UseVisualStyleBackColor = true;
            // 
            // btnStok
            // 
            this.btnStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStok.Location = new System.Drawing.Point(218, 63);
            this.btnStok.Name = "btnStok";
            this.btnStok.Size = new System.Drawing.Size(174, 60);
            this.btnStok.TabIndex = 5;
            this.btnStok.Text = "   Stok";
            this.btnStok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStok.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.chartSales);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(57, 241);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(814, 380);
            this.panel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Penjualan 7 Hari Terakhir";
            // 
            // chartSales
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSales.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSales.Legends.Add(legend1);
            this.chartSales.Location = new System.Drawing.Point(20, 59);
            this.chartSales.Name = "chartSales";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartSales.Series.Add(series1);
            this.chartSales.Size = new System.Drawing.Size(695, 300);
            this.chartSales.TabIndex = 4;
            this.chartSales.Text = "chart1";
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 685);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelPiutang);
            this.Name = "FormDashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.panelPiutang.ResumeLayout(false);
            this.panelPiutang.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPiutang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPiutang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStok;
        private System.Windows.Forms.Button btnKasir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSales;
        private System.Windows.Forms.Label label4;
    }
}