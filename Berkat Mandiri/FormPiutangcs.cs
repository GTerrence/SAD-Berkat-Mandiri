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

        private void FormPiutangcs_Load(object sender, EventArgs e)
        {
        }

        private void chTanggal_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void tbNota_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbPelanggan_TextChanged(object sender, EventArgs e)
        {
        }

        private void dtpPiutang_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dgvPiutang_CellClick(object sender, DataGridViewCellEventArgs e)
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
