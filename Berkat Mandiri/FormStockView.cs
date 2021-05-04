using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace Berkat_Mandiri
{
    public partial class FormStockView : Form
    {
        public string query1;
        public int tb = 0;
        public DataTable dtData;
        public FormStockView()
        {
            InitializeComponent();
        }

        private void refreshDgv()
        {
            query1 = "select item_name `Nama Item`, harga `Harga`, ukuran `Ukuran`, satuan `Satuan`, quantity `Kuantitas` from stock";
            if(tb == 1)
            {
                query1 += " where item_name like '%" + tbSearch.Text + "%'";
            }
            DbConnect.exQuery(query1, ref dtData);
            dgvData.DataSource = dtData;
        }

        private void FormStockView_Load(object sender, EventArgs e)
        {
            tb = 0;
            refreshDgv();
        }

        private void btnKonversi_Click(object sender, EventArgs e)
        {
            Form f1 = new FormStockKonversi();
            f1.Show();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            tb = 1;
            refreshDgv();
        }

        private void btnGanti_Click(object sender, EventArgs e)
        {
            Form f2 = new FormStockGanti();
            f2.Show();
        }
    }

    public static class DbConnect
    {
        public static string connString = "server=localhost;port=3306;user id=root; password=; database=berkat_mandiri; SslMode=none";
        public static MySqlConnection connection = new MySqlConnection(connString);
        public static MySqlCommand sqlcommand = new MySqlCommand();
        public static MySqlDataAdapter sqladapter = new MySqlDataAdapter();

        public static void exQuery(string query, ref DataTable dt)
        {
            dt = new DataTable();
            sqlcommand = new MySqlCommand(query, connection);
            sqladapter = new MySqlDataAdapter(sqlcommand);
            sqladapter.Fill(dt);
        }
        public static void exnonQuery(string queryString)
        {
            string query = queryString;
            MySqlCommand sqlCommand = new MySqlCommand(query, connection);
            MySqlDataReader sqlReader;
            connection.Open();
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }
    }
}
