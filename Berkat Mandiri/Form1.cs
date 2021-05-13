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
        private Button prevButton;
        private Form activeForm;
        public FormBase()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnMaster.Image = new Bitmap(Berkat_Mandiri.Properties.Resources.panah_down, new Size(24, 20));
            btnTransaksi.Image = new Bitmap(Berkat_Mandiri.Properties.Resources.panah_down, new Size(24, 20));
            btnStock.Image = new Bitmap(Berkat_Mandiri.Properties.Resources.panah_down, new Size(24, 20));
            btnReceivable.Image = new Bitmap(Berkat_Mandiri.Properties.Resources.panah_down, new Size(24, 20));
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            dropDown(sender);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            dropDown(sender);
        }

        private void activate_button(Button btnSender)
        {
            if (btnSender != null)
            {
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
            this.panMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnMaster_Click(object sender, EventArgs e)
        {
            dropDown(sender);
        }

        private void dropDown (object sender)
        {
            if(prevButton != null && prevButton != ((Button)sender))
            {
                prevButton.Image = new Bitmap(Berkat_Mandiri.Properties.Resources.panah_down, new Size(24, 20));
            }
            prevButton = ((Button)sender);
            foreach (Panel pan in panMenu.Controls.OfType<Panel>())
            {
                if(pan.Name == ((Button)sender).Tag.ToString())
                {
                    if (pan.Size == pan.MaximumSize)
                    {
                        ((Button)sender).Image = new Bitmap(Berkat_Mandiri.Properties.Resources.panah_down, new Size(24, 20));
                        pan.Size = pan.MinimumSize;
                    }
                    else if (pan.Size == pan.MinimumSize)
                    {
                        ((Button)sender).Image = new Bitmap(Berkat_Mandiri.Properties.Resources.panah_up, new Size(24, 20));
                        pan.Size = pan.MaximumSize;
                    }
                } else
                {
                    if (pan.Size == pan.MaximumSize)
                    {
                        pan.Size = pan.MinimumSize;
                    }
                }
            }
        }
        private void btnReceivable_Click(object sender, EventArgs e)
        {
            dropDown(sender);
        }

        private void btnStView_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormStockView(), sender);
        }

        private void btnStGanti_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormStockGanti(), sender);
        }

        private void btnStKonversi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormStockKonversi(), sender);
        }
    }
}
