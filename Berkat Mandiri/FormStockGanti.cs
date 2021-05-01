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
    public partial class FormStockGanti : Form
    {
        public FormStockGanti()
        {
            InitializeComponent();
        }

        public static DataTable dtCbBarang2;
        public static string query2;

        private void bg_Click(object sender, EventArgs e)
        {

        }

        private void FormStockGanti_Load(object sender, EventArgs e)
        {
            query2 = "call call_CbStock()";
            DbConnect.exQuery(query2, ref dtCbBarang2);
            cbBarang.DataSource = dtCbBarang2;
            cbBarang.DisplayMember = "stock_name";
            cbBarang.ValueMember = "stock_id";
            cbBarang.SelectedIndex = -1;
        }

        private void cbBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbBefore.Text = dtCbBarang2.Rows[cbBarang.SelectedIndex][4].ToString();
        }
    }
}
