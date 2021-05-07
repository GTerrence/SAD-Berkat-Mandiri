using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Berkat_Mandiri
{
    public partial class FormLaporanTransaksi : Form
    {
        static string que;        
        public FormLaporanTransaksi()
        {
            InitializeComponent();
        }
        
        private void FormLaporanTransaksi_Load(object sender, EventArgs e)
        {
            pj_dtp2.Value = DateTime.Now;
            pj_dtp1.Value = DateTime.Now.Subtract(TimeSpan.FromDays(7));
            pb_dtp2.Value = DateTime.Now;
            pb_dtp1.Value = DateTime.Now.Subtract(TimeSpan.FromDays(7));
            comboboxlunas(ref pj_lunas);
            comboboxlunas(ref pb_lunas);
            RefreshPenjualan();
            comboboxsupplier();
        }
        private void RefreshPenjualan()
        {
            que = "select t.nota_id `Nota`, p.pelanggan_name `Pelanggan`, t.tanggal_penjualan `Tanggal`, t.total_harga `Total Harga`, t.lunas `Status`";
            que += " from transaksi t left join pelanggan p on t.pelanggan_id = p.pelanggan_id ";
            que += " where t.nota_id like '%"+ pj_nota_id.Text + "%' and p.pelanggan_name like '%"+ pj_pelanggan.Text +"%' and t.tanggal_penjualan >= '"+ pj_dtp1.Value.ToString("yyyy-MM-dd") +"' and t.tanggal_penjualan <= '"+ pj_dtp2.Value.ToString("yyyy-MM-dd") + "' and t.lunas = if( '" + pj_lunas.SelectedIndex + "' = 2 , t.lunas, '" + pj_lunas.SelectedIndex +"') and t.`delete` = 0";
            DataTable dt_transaksi = new DataTable();
            DbConnect.exQuery(que, ref dt_transaksi);
            PJ_DGV.DataSource = dt_transaksi;
            foreach (DataGridViewColumn col in PJ_DGV.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void PJ_cari_textberubah(object sender, EventArgs e)
        {
            RefreshPenjualan();
        }

        private void PJ_Next_Click(object sender, EventArgs e)
        {

        }
        private void RefreshPembelian() 
        {
            
        }
        private void comboboxsupplier()
        {
            que = "Select * from supplier where `delete` = 0";
            DataTable dt_sup = new DataTable();
            DbConnect.exQuery(que, ref dt_sup);
            pb_supplier.DataSource = dt_sup;
            pb_supplier.DisplayMember = "supplier_name";
            pb_supplier.ValueMember = "supplier_id";
        }
        private void comboboxlunas(ref ComboBox CB)
        {
            DataTable dt_lunas = new DataTable();
            dt_lunas.Columns.Add("status_index", typeof(int));
            dt_lunas.Columns.Add("status", typeof(string));
            dt_lunas.Rows.Add(0,"Belum Lunas");
            dt_lunas.Rows.Add(1, "Lunas");
            dt_lunas.Rows.Add(2, "Semua");
            CB.DataSource = dt_lunas;
            CB.DisplayMember = "status";
            CB.ValueMember = "status_index";
            CB.SelectedValue = 2;
        }

    }
}
