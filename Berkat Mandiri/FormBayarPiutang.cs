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
    public partial class FormBayarPiutang : Form
    {
        public string query1;
        public FormBayarPiutang()
        {
            InitializeComponent();
        }

        private void FormBayarPiutang_Load(object sender, EventArgs e)
        {
            try
            {
                tbID.Text = FormPiutangcs.data[0];
                tbPelanggan.Text = FormPiutangcs.data[1];
                dtpTanggal.Value = Convert.ToDateTime(FormPiutangcs.data[2]);
                tbStatus.Text = FormPiutangcs.data[5];
                lbPenjualan.Text = FormPiutangcs.data[3];
                lbDibayar.Text = (Convert.ToInt32(FormPiutangcs.data[3]) - Convert.ToInt32(FormPiutangcs.data[4])).ToString();
                lbKurang.Text = FormPiutangcs.data[4];

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKonfirm_Click(object sender, EventArgs e)
        {
            try
            {
                query1 = "insert into piutang values('{0}', '{1}', '{2}', {3}, 0)";
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
