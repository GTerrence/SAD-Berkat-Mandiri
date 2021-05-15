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
                query1 = "select nota_id from transaksi where lunas = 0;";
                DbConnect.exQuery(query1, ref dtPiutang);
                lblJumlah.Text = dtPiutang.Rows.Count.ToString();
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
    }
}
