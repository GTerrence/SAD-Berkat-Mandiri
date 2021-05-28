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
    public partial class FormTransaksi : Form
    {
        public FormTransaksi()
        {
            InitializeComponent();
        }
        static string que;
        static DataTable dt_barang_beli = new DataTable();
        static DataTable dt_barang_jual = new DataTable();
        static string barangjual = "";
        static string barangbeli = "";
        static int TotalJual = 0;
        static int TotalBeli = 0;
        static int Tinggi;
        static int TambahTinggi;
        static int batas_lebar;
        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            PJ_TranPen_1.BringToFront();
            PB_TranPem_1.BringToFront();
            comboboxsupplier();
            combobarang(ref PJ_CB_Barang, "semua", ref dt_barang_jual);
            combobarang(ref PB_CB_Barang, pb_supplier.SelectedValue.ToString(), ref dt_barang_beli);
            comboboxpelanggan(ref PJ_CB_Pelanggan);
            PJ_CB_HargaKhusus.Checked = false;
            PB_CB_HargaKhusus.Checked = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PJ_Add_Click(object sender, EventArgs e)
        {
            AddDataToGrid(ref PJ_DGV, dt_barang_jual, PJ_CB_Barang, PJ_Num_Quan, PJ_CB_HargaKhusus, PJ_TB_HargaKhusus);
        }
        private void PB_Add_Click(object sender, EventArgs e)
        {
            AddDataToGrid(ref PB_DGV, dt_barang_beli, PB_CB_Barang, PB_Num_Quan, PB_CB_HargaKhusus, PB_TB_HargaKhusus);
        }

        private void AddDataToGrid(ref DataGridView DGV, DataTable DTT, ComboBox CBB, NumericUpDown NUD, CheckBox CBox, TextBox Harsus)
        {
            Boolean SudahAda = false;

            DataGridViewRow databaris = new DataGridViewRow();
            databaris.CreateCells(DGV);
            databaris.Cells[0].Value = CBB.SelectedValue;
            databaris.Cells[1].Value = DTT.Rows[CBB.SelectedIndex]["Produk"];
            databaris.Cells[2].Value = NUD.Value;
            if (CBox.Checked == false)
            {
                databaris.Cells[3].Value = DTT.Rows[CBB.SelectedIndex]["Harga"];
            }
            else
            {
                databaris.Cells[3].Value = Harsus.Text;
            }
            databaris.Cells[4].Value = Convert.ToInt32(databaris.Cells[2].Value) * Convert.ToInt32(databaris.Cells[3].Value);
            databaris.Cells[5].Value = "Delete";
            //databaris.Cells[5] = new DataGridViewButtonCell()
            //{                

            //};

            foreach (DataGridViewRow Row in DGV.Rows)
            {
                if (Row.Cells[0].Value == databaris.Cells[0].Value)
                {
                    SudahAda = true;
                    for (int ii = 1; ii < 5; ii++)
                    {
                        Row.Cells[ii].Value = databaris.Cells[ii].Value;
                    }
                    break;
                };
            };
            if (SudahAda != true)
            {
                DGV.Rows.Add(databaris);
            }
        }
        private void PB_Back_Click(object sender, EventArgs e)
        {
            PB_TranPem_1.BringToFront();
        }

        private void PB_Next_Click(object sender, EventArgs e)
        {
            NextButton(ref barangbeli, ref TotalBeli, PB_DGV, ref PB_Tb_Total);
            PB_TranPem_2.BringToFront();
        }

        private void PJ_Back_Click(object sender, EventArgs e)
        {
            PJ_TranPen_1.BringToFront();
        }
        private void PJ_Btn_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                DbConnect.connection.Open();
                MySqlCommand Com = new MySqlCommand()
                {
                    CommandText = "tambah_penjualan",
                    CommandType = CommandType.StoredProcedure,
                    Connection = DbConnect.connection
                };
                MySqlParameter[] pam = new MySqlParameter[4];
                pam[0] = new MySqlParameter("data_barang", MySqlDbType.VarChar)
                { Value = barangjual };
                pam[1] = new MySqlParameter("ttanggal", MySqlDbType.Date)
                { Value = DateTime.Now.ToString("yyyy-MM-dd") };
                pam[2] = new MySqlParameter("pel_id", MySqlDbType.VarChar)
                { Value = PJ_CB_Pelanggan.SelectedValue.ToString() };
                pam[3] = new MySqlParameter("bay", MySqlDbType.Int32)
                { Value = Convert.ToInt32(PJ_TB_Bayar.Text) };
                Com.Parameters.AddRange(pam);
                Com.ExecuteNonQuery();
                DbConnect.connection.Close();
                int TotalPenjualan = 0;
                foreach (DataGridViewRow rrow in PJ_DGV.Rows)
                {
                    TotalPenjualan += Convert.ToInt32(rrow.Cells[4].Value);
                }
                string pesan = "Transaksi Penjualan Berhasil";
                if (TotalPenjualan <= Convert.ToInt32(PJ_TB_Bayar.Text))
                {
                    pesan += ". Kembalian Rp" + Kembalian(Convert.ToInt32(PJ_TB_Bayar.Text), TotalPenjualan);
                }
                else
                {
                    pesan += ". Transaksi Piutang";
                }
                pesan += ". Print Nota Penjualan?";
                //MessageBox Msg = new MessageBox(pesa);
                //MessageBox.Show(pesan, "Berhasil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (MessageBox.Show(pesan, "Berhasil", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    printPreviewDialog1.ShowDialog();
                }
                PJ_TranPen_1.BringToFront();
                PJ_DGV.Rows.Clear();
            }
            catch (Exception ex)
            {
                DbConnect.connection.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            pb_supplier.SelectedIndex = 0;
        }
        private void combobarang(ref ComboBox CB, string supplier_id, ref DataTable DT_Bar)
        {
            //que = "select stock_id `stock_id`, supplier_id `supplier_id`, concat(item_name,' ', ukuran , ' ', satuan) `item`, quantity `qty` from stock where `delete` = 0";
            DT_Bar = new DataTable();
            //DbConnect.exQuery(que, ref dt_barang);            
            MySqlCommand com = new MySqlCommand()
            {
                CommandText = "barang_dari_supplier",
                CommandType = CommandType.StoredProcedure,
                Connection = DbConnect.connection
            };
            MySqlParameter pam = new MySqlParameter("sup_id", MySqlDbType.VarChar);
            pam.Value = supplier_id;
            com.Parameters.Add(pam);
            MySqlDataAdapter adap = new MySqlDataAdapter(com);
            adap.Fill(DT_Bar);
            CB.DataSource = DT_Bar;
            CB.ValueMember = "ID";
            CB.DisplayMember = "Produk";
        }

        private void pb_supplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            combobarang(ref PB_CB_Barang, pb_supplier.SelectedValue.ToString(), ref dt_barang_beli);
            //PB_CB_Barang.SelectedIndex = 0;
        }
        private void textbox_harga_khusus(CheckBox cc, ref TextBox bb)
        {
            if (cc.Checked == true)
            {
                bb.Enabled = true;
            }
            else
            {
                bb.Enabled = false;
            };
        }

        private void PJ_CB_HargaKhusus_CheckedChanged(object sender, EventArgs e)
        {
            textbox_harga_khusus(PJ_CB_HargaKhusus, ref PJ_TB_HargaKhusus);
        }

        private void PB_CB_HargaKhusus_CheckedChanged(object sender, EventArgs e)
        {
            textbox_harga_khusus(PB_CB_HargaKhusus, ref PB_TB_HargaKhusus);
        }
        private void PJ_Next_Click(object sender, EventArgs e)
        {
            NextButton(ref barangjual, ref TotalJual, PJ_DGV, ref PJ_Tb_Total);
            PJ_TranPen_2.BringToFront();
        }
        private void NextButton(ref string datadetailbarang, ref int Total, DataGridView DGV, ref TextBox TB_Total)
        {
            datadetailbarang = "";
            Total = 0;
            foreach (DataGridViewRow ro in DGV.Rows)
            {
                Total += Convert.ToInt32(ro.Cells[4].Value);
                datadetailbarang += ro.Cells[0].Value.ToString() + "," + ro.Cells[2].Value.ToString() + "," + ro.Cells[3].Value.ToString();
                if (ro != DGV.Rows[DGV.Rows.Count - 1])
                {
                    datadetailbarang += ";";
                }
            }
            TB_Total.Text = Total.ToString();
        }
        private void ExProcedureNonQuery(string Query, MySqlCommand Command)
        {

        }
        private int Kembalian(int bayar, int total)
        {
            return bayar - total;
        }
        private void PB_Btn_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                DbConnect.connection.Open();
                MySqlParameter[] pam = new MySqlParameter[3];
                pam[0] = new MySqlParameter("data_barang", MySqlDbType.VarChar)
                { Value = barangbeli };
                pam[1] = new MySqlParameter("ttanggal", MySqlDbType.Date)
                { Value = DateTime.Now.ToString("yyyy-MM-dd") };
                pam[2] = new MySqlParameter("sup_id", MySqlDbType.VarChar)
                { Value = pb_supplier.SelectedValue.ToString() };
                MySqlCommand com = new MySqlCommand()
                {
                    CommandText = "tambah_pembelian",
                    CommandType = CommandType.StoredProcedure,
                    Connection = DbConnect.connection
                };
                com.Parameters.AddRange(pam);
                com.ExecuteNonQuery();
                DbConnect.connection.Close();
                MessageBox.Show("Transaksi Pembelian", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PB_TranPem_1.BringToFront();
                PB_DGV.Rows.Clear();
            }
            catch (Exception ex)
            {
                DbConnect.connection.Close();
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void DGV_Delete_Click(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView DG = (DataGridView)sender;
            if (e.ColumnIndex == 5)
            {
                DG.Rows.RemoveAt(e.RowIndex);
            }
        }
        public class MyButtonCell : DataGridViewButtonCell
        {
            protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates elementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
            {
                ButtonRenderer.DrawButton(graphics, cellBounds, formattedValue.ToString(), new Font("Comic Sans MS", 9.0f, FontStyle.Bold), true, System.Windows.Forms.VisualStyles.PushButtonState.Default);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //DokumenNotaPenjualan dokumenNotaPenjualan = new DokumenNotaPenjualan();
            //dokumenNotaPenjualan.Show();
            //dokumenNotaPenjualan.BringToFront();
            printPreviewDialog1.ShowDialog();
        }
        private void nota_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string kue;
            kue = "select count(*) From transaksi where `delete` = 0 and tanggal_penjualan = '" + DateTime.Now.ToString("yyyy-MM-dd") + "';";
            DataTable dt_tran = new DataTable();
            DbConnect.exQuery(kue, ref dt_tran);
            int hasil_count = Convert.ToInt32(dt_tran.Rows[0][0].ToString());
            string nom;
            if (hasil_count < 10)
            {
                nom = "0" + hasil_count.ToString();
            }
            else
            {
                nom = hasil_count.ToString();
            }
            string penjualan_id = "IN" + DateTime.Now.ToString("yy") + DateTime.Now.ToString("MM") + DateTime.Now.ToString("dd") + nom;
            //Detail Penjualan
            DataTable dt_penjualan_detail = new DataTable();
            kue = "select p.stock_id `stock_id`, concat_ws(' ', s.item_name, s.ukuran, s.satuan) `nama_barang`, p.harga_jual `harga`, p.qty_beli `qty`";
            kue += " from penjualan p, stock s";
            kue += "  where p.stock_id = s.stock_id and p.nota_id = '" + penjualan_id + "' and p.`delete` = 0;";
            DbConnect.exQuery(kue, ref dt_penjualan_detail);
            //Penjualan secara keseluruhan / Heading Nota
            dt_tran = new DataTable();
            MySqlCommand cmd = new MySqlCommand("laporan_transaksi", DbConnect.connection)
            {
                CommandType = CommandType.StoredProcedure,
            };
            MySqlParameter[] Pam = new MySqlParameter[5];
            Pam[0] = new MySqlParameter("nnota", MySqlDbType.VarChar)
            { Value = penjualan_id };
            Pam[1] = new MySqlParameter("plnggn_name", MySqlDbType.VarChar)
            { Value = "" };
            Pam[2] = new MySqlParameter("tgl_aw", MySqlDbType.VarChar)
            { Value = DateTime.Now.Subtract(TimeSpan.FromDays(7)).ToString("yyyy-MM-dd") };
            Pam[3] = new MySqlParameter("tgl_ak", MySqlDbType.VarChar)
            { Value = DateTime.Now.ToString("yyyy-MM-dd") };
            Pam[4] = new MySqlParameter("lun", MySqlDbType.VarChar)
            { Value = "2" };
            cmd.Parameters.AddRange(Pam);
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            adap.Fill(dt_tran);
            TambahTinggi = 20;
            Tinggi = TambahTinggi;
            batas_lebar = 50;
            string pembatas = "";
            for (int i = 0; i < batas_lebar; i++)
            {
                pembatas += "-";
            }
            Font fontprint = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            //e.Graphics.DrawString("Berkat Mandiri", fontprint, Brushes.Black, 20, Tinggi);
            printmini(ref e, fontprint, "Berkat Mandiri");
            printmini(ref e, fontprint, "");
            printmini(ref e, fontprint, "Tanggal : " + DateTime.Now.ToString("dd-MMMM-yyyy"));
            printmini(ref e, fontprint, "Nota : " + penjualan_id);
            printmini(ref e, fontprint, "Pembeli : " + dt_tran.Rows[0]["pelanggan"].ToString());
            printmini(ref e, fontprint, "");
            printmini(ref e, fontprint, pembatas);
            foreach (DataRow row in dt_penjualan_detail.Rows)
            {
                printmini(ref e, fontprint, row["nama_barang"].ToString());
                int tot_temp = Convert.ToInt32(row["qty"].ToString()) * Convert.ToInt32(row["harga"].ToString());
                printharga(ref e, fontprint, row["qty"].ToString(), row["harga"].ToString(), tot_temp.ToString());
                printmini(ref e, fontprint, "");
            };
            printmini(ref e, fontprint, pembatas);
            int totaltotal = Convert.ToInt32(dt_tran.Rows[0]["Total Harga"].ToString());
            int kembali = Kembalian(Convert.ToInt32(PJ_TB_Bayar.Text), totaltotal);
            printmini(ref e, fontprint, "Total : " + totaltotal);
            printmini(ref e, fontprint, "Bayar : " + PJ_TB_Bayar.Text);
            if (kembali < 0)
            {
                printmini(ref e, fontprint, "Kurang Bayar : " + kembali.ToString());
                printmini(ref e, fontprint, "Status : Hutang");
            }
            else
            {
                printmini(ref e, fontprint, "Kembalian : " + kembali.ToString());
            }

            printmini(ref e, fontprint, "");
            printmini(ref e, fontprint, "Terima Kasih");

        }
        private void printmini(ref System.Drawing.Printing.PrintPageEventArgs ee, Font Fo, string tex)
        {
            string textbiasa = "";
            Tinggi += TambahTinggi;
            if (tex.Length > batas_lebar)
            {
                int pp = 0;
                int kk = tex.Length;
                while (pp < tex.Length)
                {
                    if (kk > batas_lebar)
                    {
                        textbiasa += tex.Substring(pp, batas_lebar) + "\n";
                        //ee.Graphics.DrawString(tex.Substring(pp, batas_lebar), Fo, Brushes.Black, 20, Tinggi);
                        kk = kk - batas_lebar;
                        pp += batas_lebar;
                    }
                    else
                    {
                        textbiasa += tex.Substring(pp, kk);
                        //ee.Graphics.DrawString(tex.Substring(pp, kk), Fo, Brushes.Black, 20, Tinggi);
                        break;
                    }
                }
            }
            else
            {
                textbiasa = tex;
                //ee.Graphics.DrawString(tex, Fo, Brushes.Black, 20, Tinggi);
            }
            ee.Graphics.DrawString(textbiasa, Fo, Brushes.Black, 20, Tinggi);
        }
        private void printharga(ref System.Drawing.Printing.PrintPageEventArgs eee, Font Fo, string qt, string har, string tot)
        {
            string tex_nilai = qt + " X " + har;
            int coun = batas_lebar - tot.Length - tex_nilai.Length;
            for (int i = 0; i < coun; i++)
            {
                tex_nilai += " ";
            }
            tex_nilai += tot;
            printmini(ref eee, Fo, tex_nilai);
            //ee.Graphics.DrawString(tex_nilai, Fo, Brushes.Black, 20, Tinggi);
        }
        private void comboboxpelanggan(ref ComboBox cb)
        {

            que = "Select pelanggan_id, pelanggan_name from pelanggan where `delete` = 0";
            DataTable dt_pelanggan = new DataTable();
            DbConnect.exQuery(que, ref dt_pelanggan);
            cb.Items.Clear();
            DataRow rrr = dt_pelanggan.NewRow();
            rrr[0] = "";
            rrr[1] = "Pelanggan Eceran";
            dt_pelanggan.Rows.InsertAt(rrr, 0);
            cb.DataSource = dt_pelanggan;
            cb.ValueMember = "pelanggan_id";
            cb.DisplayMember = "pelanggan_name";
            cb.SelectedIndex = 0;
        }
    }
}
