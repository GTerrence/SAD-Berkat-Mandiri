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

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            PJ_TranPen_1.BringToFront();
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
    }
}
