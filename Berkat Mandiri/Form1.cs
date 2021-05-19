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
        private Button prevButton, activeButton;
        public Form activeForm;
        public static int TForm;
        public FormBase()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Panel pan in panMenu.Controls.OfType<Panel>())
            {
                foreach (Button btn in pan.Controls.OfType<Button>())
                {
                    if (btn.Name == pan.Tag.ToString())
                    {
                        btn.Image = new Bitmap(Berkat_Mandiri.Properties.Resources.panah_down, new Size(24, 20));
                    }
                    else
                    {
                        btn.Image = new Bitmap(Berkat_Mandiri.Properties.Resources.panah_right, new Size(20, 24));
                    }
                    btn.ImageAlign = ContentAlignment.MiddleLeft;
                }
            }
            closePanel();
            OpenChildForm(new Form_Dashboard(), btnDashboard);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            closeDropdown(sender);
            OpenChildForm(new Form_Dashboard(), sender);
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

        private void activate_button(Object btnSender)
        {
            if (activeButton != null)
            {
                if(activeButton != ((Button)btnSender))
                {
                    activeButton.BackColor = Color.FromArgb(19, 32, 51);
                    activeButton.ForeColor = Color.FromArgb(42, 84, 191);
                    if (activeButton.Name != "btnDashboard")
                    {
                        activeButton.Image = new Bitmap(Properties.Resources.panah_right, new Size(20, 24));
                    }
                    ((Button)btnSender).BackColor = Color.FromArgb(42, 84, 191);
                    ((Button)btnSender).ForeColor = Color.FromArgb(19, 32, 51);
                    if (((Button)btnSender).Name != "btnDashboard")
                    {
                        ((Button)btnSender).Image = new Bitmap(Properties.Resources.panah_right2, new Size(20, 24));
                    }
                    activeButton = (Button)btnSender;
                }
            } else
            {
                ((Button)btnSender).BackColor = Color.FromArgb(42, 84, 191);
                ((Button)btnSender).ForeColor = Color.FromArgb(19, 32, 51);
                if (((Button)btnSender).Name != "btnDashboard")
                {
                    ((Button)btnSender).Image = new Bitmap(Properties.Resources.panah_right2, new Size(20, 24));
                }
                activeButton = (Button)btnSender;
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(childForm.Name == "Form_Dashboard")
            {
                childForm.FormClosed += callView;
            }
            if (TForm == 1)
            {
                activeForm = null;
                dropDown(btnStock);
            }
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activate_button(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panMain.Controls.Add(childForm);
            this.panMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbTitle.Text = childForm.Text;
        }

        private void btnMaster_Click(object sender, EventArgs e)
        {
            dropDown(sender);
        }

        private void dropDown (object sender)
        {
            if(prevButton != null && prevButton != ((Button)sender) && prevButton.Name != "btnDashboard")
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

        private void closeDropdown(object sender)
        {
            if (prevButton != null && prevButton != ((Button)sender))
            {
                prevButton.Image = new Bitmap(Berkat_Mandiri.Properties.Resources.panah_down, new Size(24, 20));
            }
            prevButton = ((Button)sender);
            foreach (Panel pan in panMenu.Controls.OfType<Panel>())
            {
                if (pan.Size == pan.MaximumSize)
                {
                    pan.Size = pan.MinimumSize;
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

        private void btnTrInput_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTransaksi(), sender);
        }

        private void btnTrLaporan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormLaporanTransaksi(), sender);
        }

        private void btnReOn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormPiutangcs(), sender);
        }

        private void btnReHist_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormLaporanPiutang(), sender);
        }

        private void callView(object sender, FormClosedEventArgs e)
        {
            if (TForm == 1)
            {
                OpenChildForm(new FormStockView(), btnStView);
                TForm = 0;
            }
        }

        private void closePanel()
        {
            foreach(Panel pan in panMenu.Controls.OfType<Panel>())
            {
                pan.Size = pan.MinimumSize;
            }
        }
    }
}
