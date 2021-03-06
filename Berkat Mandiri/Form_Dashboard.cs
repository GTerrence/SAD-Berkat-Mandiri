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
    public partial class Form_Dashboard : Form
    {
        public Form_Dashboard()
        {
            InitializeComponent();
        }

        private string query1;
        private DataTable dtPiutang;

        private void Form_Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                btnKasir.Image = new Bitmap(Properties.Resources.cashier, new Size(24, 20));
                btnStockV.Image = new Bitmap(Properties.Resources.stock1, new Size(24, 20));
                query1 = "select nota_id from transaksi where lunas = 0;";
                DbConnect.exQuery(query1, ref dtPiutang);
                lblJumlah.Text = dtPiutang.Rows.Count.ToString();
                lbTanggal.Text = DateTime.Now.ToString("dd MMMM yyyy");
                lbJam.Text = DateTime.Now.ToString("H:mm:ss");
            } catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        private void btnStockV_Click(object sender, EventArgs e)
        {
            try
            {
                FormBase.TForm = 1;
                this.Close();
            } catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void timerDate_Tick(object sender, EventArgs e)
        {
            lbTanggal.Text = DateTime.Now.ToString("dd MMMM yyyy");
            lbJam.Text = DateTime.Now.ToString("H:mm:ss");
        }

        private void btnKasir_Click(object sender, EventArgs e)
        {
            try
            {
                FormBase.TForm = 2;
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
