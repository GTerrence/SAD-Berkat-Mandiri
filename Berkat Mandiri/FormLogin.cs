using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Berkat_Mandiri
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        public static int admin = 0;
        private void Btn_LoginAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                DbConnect.connection.Open();
                MySqlCommand Com = new MySqlCommand()
                {
                    CommandText = "login_admin",
                    CommandType = CommandType.StoredProcedure,
                    Connection = DbConnect.connection
                };
                DataTable dt = new DataTable();
                MySqlParameter[] pam = new MySqlParameter[2];
                pam[0] = new MySqlParameter("nam", MySqlDbType.VarChar) {Value = Tb_User.Text };
                pam[1] = new MySqlParameter("pas", MySqlDbType.VarChar) { Value = Tb_User.Text };
                Com.Parameters.AddRange(pam);
                MySqlDataAdapter adap = new MySqlDataAdapter(Com);
                adap.Fill(dt);
                int HasilNilai = Convert.ToInt32(dt.Rows[0][0].ToString());
                if (HasilNilai == 1)
                {
                    //Untuk Procedure / funtion masuk ke dashboard sebagai ADMIN
                    Masuk_Sebagai_Admin();
                }
                else
                {
                    MessageBox.Show("Username atau Password yang dimasukkan salah. Silahkan mencoba lagi.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                DbConnect.connection.Close();
            }
            catch (Exception ex)
            {
                DbConnect.connection.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_LoginUser_Click(object sender, EventArgs e)
        {
            Masuk_Sebagai_User_Biasa();
        }
        private void Masuk_Sebagai_Admin()
        {
            //Untuk Procedure / funtion masuk ke dashboard sebagai ADMIN
            MessageBox.Show("Masuk Sebagai Admin Berhasil", "Admin Login", MessageBoxButtons.OK, MessageBoxIcon.Information); // Ini Boleh Dihapus / dicomment
            admin = 1;
            closeForm();
        }
        private void Masuk_Sebagai_User_Biasa()
        {
            //Untuk Procedure / funtion masuk ke dashboard sebagai User biasa yang bisa melihat stok dan memasukan kasir penjualan
            MessageBox.Show("Masuk Sebagai User Biasa Berhasil", "User Biasa Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            admin = 0;
            closeForm();
        }

        private void closeForm()
        {
            FormBase fb = new FormBase();
            fb.FormClosed += thisClose;
            fb.Show();
            this.Hide();
        }

        private void thisClose(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
