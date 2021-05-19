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
                //dtpTanggal.Value = ;
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
    }
}
