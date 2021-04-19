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
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void panelPiutang_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelPiutang.ClientRectangle,
               Color.Black, 1, ButtonBorderStyle.Solid, // left
               Color.Black, 1, ButtonBorderStyle.Solid, // top
               Color.Black, 1, ButtonBorderStyle.Solid, // right
               Color.Black, 1, ButtonBorderStyle.Solid);// bottom
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            btnStok.Image = new Bitmap(Berkat_Mandiri.Properties.Resources.stock1, new Size(38, 38));
            btnKasir.Image = new Bitmap(Berkat_Mandiri.Properties.Resources.cashier, new Size(38, 38));
        }
    }
}
