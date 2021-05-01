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
    public partial class FormStockKonversi : Form
    {
        public FormStockKonversi()
        {
            InitializeComponent();
        }

        public static DataTable dtCbBarang, dtCbSat;
        public static string query1;
        public static int barang;

        private void FormStockKonversi_Load(object sender, EventArgs e)
        {
            query1 = "call call_CbStock()";
            DbConnect.exQuery(query1, ref dtCbBarang);
            cbBarang.DataSource = dtCbBarang;
            cbBarang.DisplayMember = "stock_name";
            cbBarang.ValueMember = "stock_id";
            cbBarang.SelectedIndex = -1;
            barang = 1;
        }

        private void cbSatuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lbBarang2.Text = cbSatuan.GetItemText(cbSatuan.SelectedItem);
            lbBarang2.Text = dtCbSat.Rows[cbSatuan.SelectedIndex][3].ToString();
        }

        private void cbBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (barang == 1)
            {
                tbStID.Text = cbBarang.SelectedValue.ToString();
                query1 = string.Format("call call_CbSatuan('{0}', '{1}')", dtCbBarang.Rows[cbBarang.SelectedIndex][2], dtCbBarang.Rows[cbBarang.SelectedIndex][3].ToString());
                DbConnect.exQuery(query1, ref dtCbSat);
                cbSatuan.DataSource = dtCbSat;
                cbSatuan.DisplayMember = "barang";
                cbSatuan.ValueMember = "stock_id";
            }
        }
    }
}
