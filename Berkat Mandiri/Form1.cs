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
    public partial class FormBase : Form
    {
        private Button currentButton;
        private Form activeForm;
        public FormBase()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDashboard.Image = new Bitmap(Berkat_Mandiri.Properties.Resources.home11, new Size(66, 62));
            btnMaster.Image = new Bitmap(Berkat_Mandiri.Properties.Resources.master, new Size(66, 62));
            btnTransaksi.Image = new Bitmap(Berkat_Mandiri.Properties.Resources.transaction, new Size(66, 62));
            btnStock.Image = new Bitmap(Berkat_Mandiri.Properties.Resources.stock, new Size(66, 62));
            btnReceivable.Image = new Bitmap(Berkat_Mandiri.Properties.Resources.receivable, new Size(66, 62));
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            var myForm = new FormDashboard();
            myForm.Show();
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            FormTransaksi FormTransaksi = new FormTransaksi();
            FormTransaksi.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormStockView(), sender);
        }

        private void activate_button(Button btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != btnSender)
                {

                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panMain.Controls.Add(childForm);
            //this.panMain.Controls.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
