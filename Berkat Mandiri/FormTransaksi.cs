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
    public partial class FormTransaksi : Form
    {
        public FormTransaksi()
        {
            InitializeComponent();
        }
        static string que;

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            PJ_TranPen_1.BringToFront();
            comboboxsupplier();
            combobarang(ref PB_CB_Barang);
            combobarang(ref PJ_CB_Barang);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PJ_Add_Click(object sender, EventArgs e)
        {
            //Untuk Menambah Data Ke DataGridView
            DataGridViewRow databaris = new DataGridViewRow();
            foreach (DataGridViewCell dc in PJ_DGV.Columns)
            {
                databaris.Cells.Add(dc);
            }
            databaris.Cells["PJ_BarangID"].Value = PJ_CB_Barang.SelectedIndex;
            databaris.Cells["PJ_Barang"].Value = PJ_CB_Barang.SelectedItem;
            databaris.Cells["PJ_Quan"].Value = PJ_Num_Quan.Value;
            databaris.Cells["PJ_Harga"].Value = "10000";
            databaris.Cells["PJ_Total"].Value = PJ_Num_Quan.Value * Convert.ToInt32(databaris.Cells["PJ_Harga"].Value);
            databaris.Cells["PJ_DeleteData"].Value = "Delete";
            PJ_DGV.Rows.Add(databaris);
        }

        private void PJ_Next_Click(object sender, EventArgs e)
        {
            PJ_TranPen_2.BringToFront();            
        }

        private void PJ_Btn_Insert_Click(object sender, EventArgs e)
        {
            PJ_TranPen_1.BringToFront();
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
        private void combobarang(ref ComboBox CB)
        {
            que = "select stock_id `stock_id`, supplier_id `supplier_id`, concat(item_name,' ', ukuran , ' ', satuan) `item`, quantity `qty` from stock where `delete` = 0";
            DataTable dt_barang = new DataTable();
            DbConnect.exQuery(que, ref dt_barang);
            CB.DataSource = dt_barang;
            CB.ValueMember = "stock_id";
            CB.DisplayMember = "item";
        }
    }
}
