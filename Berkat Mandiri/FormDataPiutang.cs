using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Berkat_Mandiri
{
    public partial class FormDataPiutang : Form
    {
        DataTable dtDetail = new DataTable();
        DataTable dtCount = new DataTable();
        public FormDataPiutang()
        {
            InitializeComponent();
        }
        string query1;

        private void FormDataPiutang_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            try
            {
                query1 = "select t.nota_id `Nota`, pelanggan_name `Nama Pelanggan`, tanggal_penjualan `Tanggal Penjualan`, if(lunas = 0, 'Belum Lunas', 'Lunas') `Status`, total_harga `Total Harga`, sum(bayar) `Terbayar`, total_harga - sum(bayar) `Kurang Bayar` from transaksi t, pelanggan pn, piutang pi where t.pelanggan_id = pn.pelanggan_id and t.nota_id = pi.nota_id and t.nota_id = '" + FormPiutangcs.selectedid + "'";
                query1 += " group by t.nota_id ";
                DbConnect.exQuery(query1, ref dtDetail);
                tbID.Text = dtDetail.Rows[0][0].ToString();
                tbPelanggan.Text = dtDetail.Rows[0][1].ToString();
                dtpTanggal.Value = Convert.ToDateTime(dtDetail.Rows[0][2].ToString());
                tbStat.Text = dtDetail.Rows[0][3].ToString();
                lbTotal.Text = dtDetail.Rows[0][4].ToString();
                lbDibayar.Text = dtDetail.Rows[0][5].ToString();
                lbKurang.Text = dtDetail.Rows[0][6].ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void btBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btTambah_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Convert.ToDateTime(dtDetail.Rows[0][2].ToString()).ToString("yyMMdd"));
            if(Convert.ToInt32(tbBayar.Text) <= 0 || tbBayar.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong!");
            }
            else
            {
                try
                {
                    if (Convert.ToInt32(tbBayar.Text) > Convert.ToInt32(dtDetail.Rows[0][6].ToString()))
                    {
                        query1 = "INSERT INTO `piutang` VALUES ('" + createID() + "','" + tbID.Text.ToString() + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + dtDetail.Rows[0][6].ToString() + "',0)";
                        int kembalian = (Convert.ToInt32(tbBayar.Text)) - Convert.ToInt32(dtDetail.Rows[0][6].ToString());
                        MessageBox.Show("Anda memiliki kembalian : " + kembalian);
                    }
                    else
                    {
                        query1 = "INSERT INTO `piutang` VALUES ('" + createID() + "','" + tbID.Text.ToString() + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + tbBayar.Text.ToString() + "',0)";
                    }
                    DbConnect.exnonQuery(query1);
                    CheckLunas();
                    this.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                    DbConnect.connection.Close();
                }
            }
        }
        
        private void CheckLunas()
        {
            loadData();
            if (dtDetail.Rows[0][6].ToString() == "0")
            {
                query1 = "UPDATE `transaksi` SET lunas = 1 WHERE nota_id = '" + tbID.Text.ToString() + "';";
                DbConnect.exnonQuery(query1);
            }
        }

        private string createID()
        {
            try
            {
                dtCount = new DataTable();
                query1 = "select t.nota_id `Nota`, pelanggan_name `Nama Pelanggan`, tanggal_penjualan `Tanggal Penjualan`, if(lunas = 0, 'Belum Lunas', 'Lunas') `Status` from transaksi t, pelanggan pn, piutang pi where t.pelanggan_id = pn.pelanggan_id and t.nota_id = pi.nota_id and pi.piutang_id LIKE '" + "PI" + DateTime.Now.ToString("yyMMdd") + "%'";
                DbConnect.exQuery(query1, ref dtCount);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            int countt = dtCount.Rows.Count + 1;
            string id = "";
            if (countt < 10)
            {
                id = "PI" + DateTime.Now.ToString("yyMMdd") + "0" + countt;
            }
            else
            {
                id = "PI" + DateTime.Now.ToString("yyMMdd") + countt;
            }
            return id;
        }
    }
}
