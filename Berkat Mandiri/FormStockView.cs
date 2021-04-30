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
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public FormStockView()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void bg_Click(object sender, EventArgs e)
        {

        }

        private void FormStockView_Load(object sender, EventArgs e)
        {

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
