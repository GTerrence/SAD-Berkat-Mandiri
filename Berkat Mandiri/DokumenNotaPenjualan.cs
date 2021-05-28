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
    public partial class DokumenNotaPenjualan : Form
    {
        public DokumenNotaPenjualan()
        {
            InitializeComponent();
        }
        Bitmap bmp;

        private void DokumenNotaPenjualan_Load(object sender, EventArgs e)
        {
            this.Show();
            this.BringToFront();
            printprint();
        }
        private void printprint()
        {
            //DokumenNotaPenjualan dokumenNotaPenjualan = new DokumenNotaPenjualan();
            //dokumenNotaPenjualan.Show();
            //dokumenNotaPenjualan.BringToFront();
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
