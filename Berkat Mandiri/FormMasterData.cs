using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MySql.Data.MySqlClient;

namespace Berkat_Mandiri
{
    public partial class FormMasterData : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        public static int rowsCount = 0;
        public static int is_edit = 0;
        static string dbName = "berkat_mandiri";
        string connectString = "server=localhost;uid=root;pwd=;database=" + dbName + ";";
        DataTable dtView = new DataTable();
        public static string table = "";
        DataTable dtAll = new DataTable();
        public static string selectedid = "";

        DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
        DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();


        public FormMasterData()
        {
            InitializeComponent();
        }

        private void FormMasterData_Load(object sender, EventArgs e)
        {
            dgvMasterData.GridColor = Color.White;
            dgvMasterData.Font = new Font("Nirmala UI", 10);
            DGVLoad(FormBase.is_clicked);

            
        }
        
        private void btnMaster_Click(object sender, EventArgs e)
        {

        }

        


        private void tbSproduk_TextChanged(object sender, EventArgs e)
        {
            string sqlSearch;
            if(FormBase.is_clicked == 0)
            {
                sqlSearch = sqlQuery + " AND item_name LIKE '%" + tbSproduk.Text.ToString() + "%'";
            }
            else if (FormBase.is_clicked == 1)
            {
                sqlSearch = sqlQuery + " AND pelanggan_name LIKE '%" + tbSproduk.Text.ToString() + "%'";
            }
            else
            {
                sqlSearch = sqlQuery + " AND supplier_name LIKE '%" + tbSproduk.Text.ToString() + "%'";
            }
            LoadData(sqlSearch, ref dtView);
            dgvMasterData.Columns.Clear();
            dgvMasterData.DataSource = null;
            dgvMasterData.DataSource = dtView;
            //BUTTON DEL/EDIT
            btnDelete = new DataGridViewButtonColumn();
            btnEdit = new DataGridViewButtonColumn();

            btnEdit.HeaderText = "Edit";
            btnEdit.Text = "Edit";
            btnEdit.Name = "btnEdit";
            btnEdit.UseColumnTextForButtonValue = true;

            btnDelete.HeaderText = "Delete";
            btnDelete.Text = "Delete";
            btnDelete.Name = "btnDel";
            btnDelete.UseColumnTextForButtonValue = true;

            //ADD BUTTON
            dgvMasterData.Columns.Add(btnEdit);

            dgvMasterData.Columns.Add(btnDelete);
        }





        public void DGVLoad(int is_clicked)
        {
            if (is_clicked == 0)
            {
                dgvMasterData.Columns.Clear();
                is_clicked = 0;
                table = "stock";
                lbNsearch.Text = "Nama Produk";
                sqlQuery = "SELECT item_name `Nama Produk`, ukuran `Ukuran`, satuan `Satuan`, harga `Harga`, supplier_name `Supplier` FROM `stock` st, supplier su WHERE st.supplier_id = su.supplier_id AND st.`delete` = 0";
                LoadData(sqlQuery, ref dtView);
                dgvMasterData.DataSource = null;
                dgvMasterData.DataSource = dtView;
                sqlQuery = "SELECT stock_id `ID`, item_name `Nama Produk`, ukuran `Ukuran`, satuan `Satuan`, harga `Harga`, supplier_name `Supplier` FROM `stock` st, supplier su WHERE st.supplier_id = su.supplier_id AND st.`delete` = 0";
                LoadData(sqlQuery, ref dtAll);

                //BUTTON DEL/EDIT
                btnDelete = new DataGridViewButtonColumn();
                btnEdit = new DataGridViewButtonColumn();

                btnEdit.HeaderText = "Edit";
                btnEdit.Text = "Edit";
                btnEdit.Name = "btnEdit";
                btnEdit.UseColumnTextForButtonValue = true;

                btnDelete.HeaderText = "Delete";
                btnDelete.Text = "Delete";
                btnDelete.Name = "btnDel";
                btnDelete.UseColumnTextForButtonValue = true;

                //ADD BUTTON
                dgvMasterData.Columns.Add(btnEdit);

                dgvMasterData.Columns.Add(btnDelete);
            }
            else if (is_clicked == 1)
            {
                dgvMasterData.Columns.Clear();
                is_clicked = 1;
                table = "pelanggan";
                lbNsearch.Text = "Nama Pelanggan";
                sqlQuery = "SELECT pelanggan_name `Nama`, pelanggan_alamat `Alamat`, pelanggan_nohp `No. HP` FROM `pelanggan` WHERE `delete` = 0";
                LoadData(sqlQuery, ref dtView);
                dgvMasterData.DataSource = null;
                dgvMasterData.DataSource = dtView;
                sqlQuery = "SELECT pelanggan_id `ID`, pelanggan_name `Nama`, pelanggan_alamat `Alamat`, pelanggan_nohp `No. HP` FROM `pelanggan` WHERE `delete` = 0";
                LoadData(sqlQuery, ref dtAll);

                //BUTTON DEL/EDIT
                btnDelete = new DataGridViewButtonColumn();
                btnEdit = new DataGridViewButtonColumn();

                btnEdit.HeaderText = "Edit";
                btnEdit.Text = "Edit";
                btnEdit.Name = "btnEdit";
                btnEdit.UseColumnTextForButtonValue = true;

                btnDelete.HeaderText = "Delete";
                btnDelete.Text = "Delete";
                btnDelete.Name = "btnDel";
                btnDelete.UseColumnTextForButtonValue = true;

                dgvMasterData.Columns.Add(btnEdit);

                dgvMasterData.Columns.Add(btnDelete);
            }
            else if (is_clicked == 2)
            {
                dgvMasterData.Columns.Clear();
                is_clicked = 2;
                table = "supplier";
                lbNsearch.Text = "Nama Supplier";
                sqlQuery = "SELECT supplier_name `Nama Supplier`, supplier_nohp `No. HP` FROM `supplier` WHERE `delete` = 0";
                LoadData(sqlQuery, ref dtView);
                dgvMasterData.DataSource = null;
                dgvMasterData.DataSource = dtView;
                sqlQuery = "SELECT supplier_id `ID`, supplier_name `Nama Supplier`, supplier_nohp `No. HP` FROM `supplier` WHERE `delete` = 0";
                LoadData(sqlQuery, ref dtAll);

                //BUTTON DEL/EDIT
                btnDelete = new DataGridViewButtonColumn();
                btnEdit = new DataGridViewButtonColumn();

                btnEdit.HeaderText = "Edit";
                btnEdit.Text = "Edit";
                btnEdit.Name = "btnEdit";
                btnEdit.UseColumnTextForButtonValue = true;

                btnDelete.HeaderText = "Delete";
                btnDelete.Text = "Delete";
                btnDelete.Name = "btnDel";
                btnDelete.UseColumnTextForButtonValue = true;

                dgvMasterData.Columns.Add(btnEdit);

                dgvMasterData.Columns.Add(btnDelete);
            }
        }




        public void LoadData(string query, ref DataTable dt)
        {
            //To run select query
            dt = new DataTable();
            sqlConnect = new MySqlConnection(connectString);
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dt);
            //dgvMasterData.DataSource = dt;
        }
        public void DMLProc()
        {
            //To run Data Manipulation Language query
            sqlConnect = new MySqlConnection(connectString);
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlConnect.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
        }

        public void DeleteData(string query)
        {
            //To run select query
            sqlConnect = new MySqlConnection(connectString);
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlConnect.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            rowsCount = dtAll.Rows.Count + 1;
            FormInsertMasterData formInsert = new FormInsertMasterData();
            formInsert.ShowDialog();
            FormMasterData_Load(sender, e);
        }

        private void dgvMasterData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (FormBase.is_clicked == 0)
            {
                if(e.ColumnIndex == 0)
                {
                    is_edit = 1;
                    selectedid = dtAll.Rows[Convert.ToInt32(e.RowIndex.ToString())][0].ToString();
                    FormInsertMasterData formInsert = new FormInsertMasterData();
                    formInsert.ShowDialog();
                }
                else if(e.ColumnIndex == 1)
                {
                    selectedid = dtAll.Rows[Convert.ToInt32(e.RowIndex.ToString())][0].ToString();
                    sqlQuery = "UPDATE `stock` SET `delete` = 1 WHERE stock_id = '" + selectedid + "';";
                    DeleteData(sqlQuery);
                }
            }
            else if(FormBase.is_clicked == 1)
            {
                if (e.ColumnIndex == 0)
                {
                    is_edit = 1;
                    selectedid = dtAll.Rows[Convert.ToInt32(e.RowIndex.ToString())][0].ToString();
                    FormInsertMasterData formInsert = new FormInsertMasterData();
                    formInsert.ShowDialog();
                }
                else if (e.ColumnIndex == 1)
                {
                    selectedid = dtAll.Rows[Convert.ToInt32(e.RowIndex.ToString())][0].ToString();
                    sqlQuery = "UPDATE `pelanggan` SET `delete` = 1 WHERE pelanggan_id = '" + selectedid + "';";
                    DeleteData(sqlQuery);
                }
            }
            else if(FormBase.is_clicked == 2)
            {
                if (e.ColumnIndex == 0)
                {
                    is_edit = 1;
                    selectedid = dtAll.Rows[Convert.ToInt32(e.RowIndex.ToString())][0].ToString();
                    FormInsertMasterData formInsert = new FormInsertMasterData();
                    formInsert.ShowDialog();
                }
                else if (e.ColumnIndex == 1)
                {
                    selectedid = dtAll.Rows[Convert.ToInt32(e.RowIndex.ToString())][0].ToString();
                    sqlQuery = "UPDATE `supplier` SET `delete` = 1 WHERE supplier_id = '" + selectedid + "';";
                    DeleteData(sqlQuery);
                }
            }
        }
    }
}
