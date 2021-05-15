using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            RefreshPenjualan();
            comboboxsupplier();
            RefreshPembelian();
        }
        private void RefreshPenjualan()
        {            
            DataTable dt_transaksi = new DataTable();            
            MySqlCommand cmd = new MySqlCommand("laporan_transaksi", DbConnect.connection)
            {
                CommandType = CommandType.StoredProcedure,                
            };
            MySqlParameter[] Pam = new MySqlParameter[5];
            Pam[0] = new MySqlParameter("nnota", MySqlDbType.VarChar)
            {Value = pj_nota_id.Text};
            Pam[1] = new MySqlParameter("plnggn_name", MySqlDbType.VarChar)
            { Value = pj_pelanggan.Text };
            Pam[2] = new MySqlParameter("tgl_aw", MySqlDbType.VarChar)
            { Value = pj_dtp1.Value.ToString("yyyy-MM-dd") };
            Pam[3] = new MySqlParameter("tgl_ak", MySqlDbType.VarChar)
            { Value = pj_dtp2.Value.ToString("yyyy-MM-dd") };
            Pam[4] = new MySqlParameter("lun", MySqlDbType.VarChar)
            { Value = pj_lunas.SelectedIndex.ToString() };
            cmd.Parameters.AddRange(Pam); 
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            adap.Fill(dt_transaksi);
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
        private void PB_cari_textberubah(object sender, EventArgs e)
        {
            RefreshPembelian();
        }

        private void PJ_Next_Click(object sender, EventArgs e)
        {

        }
        private void RefreshPembelian() 
        {
            DataTable dt_pembelian = new DataTable();
            MySqlCommand cmd = new MySqlCommand("laporan_pembelian", DbConnect.connection)
            {
                CommandType = CommandType.StoredProcedure,
            };
            MySqlParameter[] Pam = new MySqlParameter[4];
            Pam[0] = new MySqlParameter("beli_id", MySqlDbType.VarChar)
            { Value = pb_nota_id.Text };
            Pam[1] = new MySqlParameter("sup_id", MySqlDbType.VarChar)
            { Value = pb_supplier.SelectedValue };
            Pam[2] = new MySqlParameter("tgl_aw", MySqlDbType.VarChar)
            { Value = pb_dtp1.Value.ToString("yyyy-MM-dd") };
            Pam[3] = new MySqlParameter("tgl_ak", MySqlDbType.VarChar)
            { Value = pb_dtp2.Value.ToString("yyyy-MM-dd") };
            cmd.Parameters.AddRange(Pam);
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            adap.Fill(dt_pembelian);
            PB_DGV.DataSource = dt_pembelian;
            foreach (DataGridViewColumn col in PB_DGV.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void comboboxsupplier()
        {
            que = "Select supplier_id, supplier_name from supplier where `delete` = 0";
            DataTable dt_sup = new DataTable();
            DbConnect.exQuery(que, ref dt_sup);
            pb_supplier.Items.Clear();
            //pb_supplier.Items.Add();
            DataRow rr = dt_sup.NewRow();
            rr["supplier_id"] = "Semua";
            rr["supplier_name"] = "Semua";
            dt_sup.Rows.InsertAt(rr,0);
            pb_supplier.DataSource = dt_sup;
            pb_supplier.DisplayMember = "supplier_name";
            pb_supplier.ValueMember = "supplier_id";
            pb_supplier.SelectedIndex = 0;

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
