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
    public partial class FormSetting : Form
    {
        public FormSetting()
        {
            InitializeComponent();
        }

        string query1;
        DataTable dtUser;

        private void btGantiPass_Click(object sender, EventArgs e)
        {
            panelGantiPass.Visible = true;
            btGantiPass.Visible = false;
        }

        private void tbNo_Click(object sender, EventArgs e)
        {
            panelGantiPass.Visible = false;
            btGantiPass.Visible = true;
        }

        private void tbYes_Click(object sender, EventArgs e)
        {
            if (tbOld.Text != "" || tbNew.Text != "" || tbRepeat.Text != "")
            {
                if (tbOld.Text == dtUser.Rows[0][1].ToString())
                {
                    if (tbNew.Text == tbRepeat.Text)
                    {
                        DialogResult dialogResult = MessageBox.Show("Apakah anda yakin?", "Delete", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            query1 = "UPDATE `user` SET `password`='" + tbNew.Text + "' WHERE `username`='" + tbUser.Text + "'";
                            DbConnect.exnonQuery(query1);
                            panelGantiPass.Visible = false;
                            btGantiPass.Visible = true;
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            //do something else
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password ulang tidak sama");
                    }
                }
                else
                {
                    MessageBox.Show("Password lama tidak sesuai");
                }
            }
            else
            {
                MessageBox.Show("Tolong isi form terlebih dahulu");
            }
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            tbUser.Text = FormLogin.user.ToString();
            try
            {
                query1 = "SELECT * FROM user WHERE username = '" + tbUser.Text + "'";
                DbConnect.exQuery(query1, ref dtUser);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
    
}
