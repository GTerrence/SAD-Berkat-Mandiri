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
    public partial class FormPiutangH : Form
    {
        public FormPiutangH()
        {
            InitializeComponent();

        }
        public string query1;
        DataTable dtPiutang = new DataTable();
        private void FormPiutangH_Load(object sender, EventArgs e)
        {
            try
            {
                //query1 = "call call_piutang_av()";
                refreshDgv();
                DbConnect.exQuery(query1, ref dtPiutang);
                dgvPiutang.DataSource = dtPiutang;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void refreshDgv()
        {
            try
            {
                query1 = "select t.nota_id `Nota`, pelanggan_name `Nama Pelanggan`, tanggal `Tanggal Bayar`, bayar `Bayar` from transaksi t, pelanggan pn, piutang pi where t.pelanggan_id = pn.pelanggan_id and t.nota_id = pi.nota_id";
                if (tbNota.Text != "")
                {
                    query1 += " and t.nota_id like '%" + tbNota.Text + "%'";
                }
                if (tbPelanggan.Text != "")
                {
                    query1 += " and pelanggan_name like '%" + tbPelanggan.Text + "%'";
                }
                if (chTanggal.Checked == true)
                {
                    query1 += " and tanggal_penjualan >= str_to_date('" + dtpPiutang.Value.ToString("yyyy-MM-dd") + "', '%Y-%m-%d') and tanggal_penjualan <= str_to_date('" + dtpPiutang2.Value.ToString("yyyy-MM-dd") + "', '%Y-%m-%d')";
                }
                query1 += " group by t.nota_id ";
                DbConnect.exQuery(query1, ref dtPiutang);
                dgvPiutang.DataSource = dtPiutang;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void chTanggal_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (((CheckBox)sender).Checked == true)
                {
                    dtpPiutang.Enabled = true;
                }
                else if (((CheckBox)sender).Checked == false)
                {
                    dtpPiutang.Enabled = false;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void dtpPiutang_ValueChanged(object sender, EventArgs e)
        {
            refreshDgv();
        }

        private void dtpPiutang2_ValueChanged(object sender, EventArgs e)
        {
            refreshDgv();
        }
    }
}
