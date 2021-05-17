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
    public partial class FormPiutangcs : Form
    {
        public FormPiutangcs()
        {
            InitializeComponent();
        }

        public string query1;
        public DataTable dtPiutang;
        private void FormPiutangcs_Load(object sender, EventArgs e)
        {
            try
            {
                query1 = "call call_piutang_av()";
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
                query1 = "select t.nota_id `Nota`, pelanggan_name `Nama Pelanggan`, tanggal_penjualan `Tanggal Penjualan`, total_harga `Total Harga`, total_harga - sum(bayar) `Kurang Bayar`, if(lunas = 0, 'Belum Lunas', 'Lunas') `Status` from transaksi t, pelanggan pn, piutang pi where t.pelanggan_id = pn.pelanggan_id and t.nota_id = pi.nota_id and lunas = 0";
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
                    query1 += " and tanggal_penjualan = str_to_date('" + dtpPiutang.Value.ToString("yyyy-MM-dd") + "', '%Y-%m-%d')";
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
                if(((CheckBox)sender).Checked == true)
                {
                    dtpPiutang.Enabled = true;
                } else if(((CheckBox)sender).Checked == true)
                {
                    dtpPiutang.Enabled = false;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void tbNota_TextChanged(object sender, EventArgs e)
        {
            refreshDgv();
        }

        private void tbPelanggan_TextChanged(object sender, EventArgs e)
        {
            refreshDgv();
        }

        private void dtpPiutang_ValueChanged(object sender, EventArgs e)
        {
            refreshDgv();
        }
    }
}
