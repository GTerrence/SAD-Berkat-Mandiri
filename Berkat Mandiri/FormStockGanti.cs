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
        public static int TBarang;

        private void bg_Click(object sender, EventArgs e)
        {

        }

        private void FormStockGanti_Load(object sender, EventArgs e)
        {
            try
            {
                query2 = "select stock_id, concat(item_name, ' (', ukuran, ' ', satuan, ')') `stock_name`, harga from stock order by item_name, ukuran";
                DbConnect.exQuery(query2, ref dtCbBarang2);
                cbBarang.DataSource = dtCbBarang2;
                cbBarang.DisplayMember = "stock_name";
                cbBarang.ValueMember = "stock_id";
                cbBarang.SelectedIndex = -1;
                TBarang = 1;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void cbBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (TBarang == 1)
                {
                    tbBefore.Text = separator(dtCbBarang2.Rows[cbBarang.SelectedIndex][2].ToString());
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        public static string separator(string source)
        {
            try
            {
                string hasil = "";
                for (int i = 0; i < source.Length; i++)
                {
                    if (i % 3 == 0 && i != 0)
                    {
                        hasil = "." + hasil;
                    }
                    hasil = source[source.Length - (i+1)] + hasil;
                }
                hasil = "Rp " + hasil;
                return hasil;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                return "";
            }
        }

        private void FormStockGanti_FormClosed(object sender, FormClosedEventArgs e)
        {
            TBarang = 0;
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            try
            {
                if(cbBarang.SelectedItem is null || tbAfter.Text == "" || tbBefore.Text == "")
                {
                    MessageBox.Show("Masih ada data yang kosong");
                } else
                {
                    query2 = "update stock set harga = '" + tbAfter.Text + "' where stock_id = '" + cbBarang.SelectedValue.ToString() + "'";
                    MessageBox.Show(query2);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void tbAfter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
