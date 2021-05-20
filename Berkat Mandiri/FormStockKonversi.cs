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
        public static int TBarang ,TSatuan, sumBarang, pembagi, hasil, sisa, TData;

        private void FormStockKonversi_FormClosed(object sender, FormClosedEventArgs e)
        {
            TBarang = 0;
            TSatuan = 0;
            TData = 0;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                if (sisa > 0 && dtCbBarang.Rows[0][2].ToString() != "1")
                {
                    MessageBox.Show("Maaf barang ukuran 1kg tidak ada");
                }
                else if(hasil != 0 || (hasil == 0 && sisa > 0))
                {
                    query1 = string.Format("call convert_barang({0}, '{1}')", Convert.ToInt32(dtCbBarang.Rows[cbBarang.SelectedIndex][5]) - Convert.ToInt32(numQty.Value), dtCbBarang.Rows[cbBarang.SelectedIndex][0]);
                    
                    DbConnect.exnonQuery(query1);
                    query1 = string.Format("call convert_barang({0}, '{1}')", Convert.ToInt32(dtCbSat.Rows[cbSatuan.SelectedIndex][4]) + hasil, dtCbSat.Rows[cbSatuan.SelectedIndex][0]);
                    DbConnect.exnonQuery(query1);
                    if (sisa > 0)
                    {
                        query1 = string.Format("call convert_barang({0}, '{1}')", Convert.ToInt32(dtCbSat.Rows[0][4]) + sisa, dtCbSat.Rows[0][0]);
                        DbConnect.exnonQuery(query1);
                    }
                    form_clear();
                } else if(TData == 0)
                {
                    MessageBox.Show("Data yang dimasukan belum lengkap", "Error");
                }
                else
                {
                    MessageBox.Show("Jumlah barang belum dimasukan", "Error");
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void FormStockKonversi_Load(object sender, EventArgs e)
        {
            try
            {
                query1 = "call call_CbStock()";
                DbConnect.exQuery(query1, ref dtCbBarang);
                cbBarang.DataSource = dtCbBarang;
                cbBarang.DisplayMember = "stock_name";
                cbBarang.ValueMember = "stock_id";
                cbBarang.SelectedIndex = -1;
                TBarang = 1;
                form_clear();
            } catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void cbSatuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (TSatuan == 1)
                {
                    lbBarang2.Text = dtCbSat.Rows[cbSatuan.SelectedIndex][3].ToString();
                    cek_konversi();
                }
            } catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void numQty_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbBarang.SelectedIndex >= 0)
                {
                    if(numQty.Value > Convert.ToInt32(dtCbBarang.Rows[cbBarang.SelectedIndex][5]))
                    {
                        MessageBox.Show("Maaf jumlah barang tidak mencukupi", "Error");
                    } else
                    {
                        lbQty1.Text = numQty.Value.ToString() + " Karung";
                        cek_konversi();
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            
        }

        private void cek_konversi()
        {
            try
            {
                if (cbBarang.SelectedIndex > -1 && cbSatuan.SelectedIndex > -1)
                {
                    sumBarang = Convert.ToInt32(dtCbBarang.Rows[cbBarang.SelectedIndex][3]) * Convert.ToInt32(numQty.Value);
                    pembagi = Convert.ToInt32(dtCbSat.Rows[cbSatuan.SelectedIndex][2]);
                    hasil = sumBarang / pembagi;
                    sisa = sumBarang % pembagi;
                    if (sisa == 0)
                    {
                        lbQty2.Text = hasil + " Karung";
                    } else if (sisa != 0)
                    {
                        lbQty2.Text = hasil + " Karung + " + sisa + " kg";
                    }
                    TData = 1;
                } else
                {
                    lbQty1.Text = numQty.Value.ToString() + " Karung";
                    lbQty2.Text = "0 Karung";
                }
            } catch(Exception x) {
                MessageBox.Show(x.Message);
            }

        }

        private void form_clear()
        {
            lbBarang1.Text = "";
            lbBarang2.Text = "";
            TBarang = 0;
            cbBarang.SelectedIndex = -1;
            TBarang = 1;
            TSatuan = 0;
            cbSatuan.DataSource = null;
            lbQty1.Text = "0 Karung";
            lbQty2.Text = "0 Karung";
            tbStID.Text = "";
            numQty.Value = 0;
        }
        private void cbBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (TBarang == 1)
                {
                    TSatuan = 0;
                    tbStID.Text = cbBarang.SelectedValue.ToString();
                    query1 = string.Format("call call_CbSatuan('{0}', '{1}')", dtCbBarang.Rows[cbBarang.SelectedIndex][2], dtCbBarang.Rows[cbBarang.SelectedIndex][3].ToString());
                    DbConnect.exQuery(query1, ref dtCbSat);
                    cbSatuan.DataSource = dtCbSat;
                    cbSatuan.DisplayMember = "barang";
                    cbSatuan.ValueMember = "stock_id";
                    cbSatuan.SelectedIndex = -1;
                    TSatuan = 1;
                    lbBarang1.Text = cbBarang.GetItemText(cbBarang.SelectedItem);
                    cek_konversi();
                }
            } catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
