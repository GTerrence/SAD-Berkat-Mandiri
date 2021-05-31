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
    public partial class FormInsertMasterData : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        static string dbName = "berkat_mandiri";
        string connectString = "server=localhost;uid=root;pwd=;database=" + dbName + ";";
        DataTable dtSatuan = new DataTable();
        DataTable dtSupplier = new DataTable();
        DataTable dtAll = new DataTable();
        public FormInsertMasterData()
        {
            InitializeComponent();
        }

        private void btTambah_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apakah anda yakin?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (FormMasterData.is_edit == 1)
                {
                    if (FormBase.is_clicked == 0)
                    {
                        sqlQuery = "UPDATE `stock` SET supplier_id = '" + cbInsertSupplier.SelectedValue.ToString() + "', item_name = '" + tbInsert1.Text.ToString() + "', harga = '" + tbInsert3.Text.ToString() + "', ukuran = '" + tbInsert2.Text.ToString() + "', satuan = '" + cbInsertSatuan.Text.ToString() + "' WHERE stock_id = '" + FormMasterData.selectedid.ToString() + "';";
                    }
                    else if (FormBase.is_clicked == 1)
                    {
                        sqlQuery = "UPDATE `pelanggan` SET pelanggan_name = '" + tbInsert1.Text.ToString() + "', pelanggan_alamat = '" + tbInsert2.Text.ToString() + "', pelanggan_nohp = '" + tbInsert3.Text.ToString() + "' WHERE pelanggan_id = '" + FormMasterData.selectedid.ToString() + "';";
                    }
                    else
                    {
                        sqlQuery = "UPDATE `supplier` SET supplier_name = '" + tbInsert1.Text.ToString() + "', supplier_nohp = '" + tbInsert2.Text.ToString() + "' WHERE supplier_id = '" + FormMasterData.selectedid.ToString() + "';";
                    }
                    InsertData(sqlQuery);
                    FormMasterData.is_edit = 0;
                }
                else
                {
                    if (FormBase.is_clicked == 0)
                    {
                        sqlQuery = "INSERT INTO `stock` VALUES ('" + createID() + "', '" + cbInsertSupplier.SelectedValue.ToString() + "', '" + tbInsert1.Text.ToString() + "','" + tbInsert3.Text.ToString() + "','" + tbInsert2.Text.ToString() + "','" + cbInsertSatuan.Text.ToString() + "',0,0);";
                    }
                    else if (FormBase.is_clicked == 1)
                    {
                        sqlQuery = "INSERT INTO `pelanggan` VALUES ('" + createID() + "', '" + tbInsert1.Text.ToString() + "','" + tbInsert2.Text.ToString() + "','" + tbInsert3.Text.ToString() + "',0);";
                    }
                    else
                    {
                        sqlQuery = "INSERT INTO `supplier` VALUES ('" + createID() + "', '" + tbInsert1.Text.ToString() + "','" + tbInsert2.Text.ToString() + "',0);";
                    }
                    InsertData(sqlQuery);
                }
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
            


        }


        public void InsertData(string query)
        {
            //To run insert query
            try
            {
                sqlConnect = new MySqlConnection(connectString);
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FormInsertMasterData_Load(object sender, EventArgs e)
        {
            lbInsert.Text = "Tambahkan Data";
            btTambah.Text = "Tambah Data";
            sqlQuery = "SELECT satuan FROM stock GROUP BY satuan";
            LoadData(sqlQuery, ref dtSatuan);
            cbInsertSatuan.DataSource = dtSatuan;
            cbInsertSatuan.DisplayMember = "satuan";
            cbInsertSatuan.ValueMember = "satuan";
            sqlQuery = "SELECT * FROM supplier";
            LoadData(sqlQuery, ref dtSupplier);
            cbInsertSupplier.DataSource = dtSupplier;
            cbInsertSupplier.DisplayMember = "supplier_name";
            cbInsertSupplier.ValueMember = "supplier_id";

            //DIFFERENT TABS
            if(FormBase.is_clicked == 0)
            {
                cbInsertSatuan.Visible = true;
                cbInsertSupplier.Visible = true;
                labelCB1.Visible = true;
                labelCB2.Visible = true;
                labelUk.Top = 144;
                labelUk.Text = "Ukuran";
                tbInsert2.Top = 144;
                labelHar.Top = 248;
                labelHar.Text = "Harga";
                tbInsert3.Top = 248;
            }
            else if(FormBase.is_clicked == 1)
            {
                cbInsertSatuan.Visible = false;
                cbInsertSupplier.Visible = false;
                labelCB1.Visible = false;
                labelCB2.Visible = false;
                labelUk.Top = 92;
                labelUk.Text = "Alamat";
                tbInsert2.Top = 92;
                labelHar.Top = 144;
                labelHar.Text = "No. HP";
                tbInsert3.Top = 144;
            }
            else if (FormBase.is_clicked == 2)
            {
                cbInsertSatuan.Visible = false;
                cbInsertSupplier.Visible = false;
                labelCB1.Visible = false;
                labelCB2.Visible = false;
                labelHar.Visible = false;
                tbInsert3.Visible = false;
                labelUk.Top = 92;
                labelUk.Text = "No. HP";
                tbInsert2.Top = 92;
            }
                ///IF EDIT
            if (FormMasterData.is_edit == 1)
            {
                lbInsert.Text = "Edit Data";
                btTambah.Text = "Edit Data";
                if (FormBase.is_clicked == 0)
                {
                    //MessageBox.Show(FormMasterData.selectedid.ToString());
                    sqlQuery = "SELECT * FROM `stock` WHERE `delete` = 0 AND stock_id = '" + FormMasterData.selectedid + "'";
                    LoadData(sqlQuery, ref dtAll);
                    tbInsert1.Text = dtAll.Rows[0][2].ToString();
                    tbInsert2.Text = dtAll.Rows[0][4].ToString();
                    tbInsert3.Text = dtAll.Rows[0][3].ToString();
                    cbInsertSatuan.Text = dtAll.Rows[0][5].ToString();
                    cbInsertSupplier.SelectedValue = dtAll.Rows[0][1].ToString();
                }
                else if (FormBase.is_clicked == 1)
                {
                    sqlQuery = "SELECT * FROM `pelanggan` WHERE `delete` = 0 AND pelanggan_id = '" + FormMasterData.selectedid + "'";
                    LoadData(sqlQuery, ref dtAll);
                    tbInsert1.Text = dtAll.Rows[0][1].ToString();
                    tbInsert2.Text = dtAll.Rows[0][2].ToString();
                    tbInsert3.Text = dtAll.Rows[0][3].ToString();
                }
                else if (FormBase.is_clicked == 2)
                {
                    sqlQuery = "SELECT * FROM `supplier` WHERE `delete` = 0 AND supplier_id = '" + FormMasterData.selectedid + "'";
                    LoadData(sqlQuery, ref dtAll);
                    tbInsert1.Text = dtAll.Rows[0][1].ToString();
                    tbInsert2.Text = dtAll.Rows[0][2].ToString();
                }
            }

        }

        public string createID()
        {
            string id = "";
            string nol = "";
            if (FormMasterData.rowsCount < 100)
            {
                nol += "0";
            }
            if (FormMasterData.rowsCount < 10)
            {
                nol += "0";
            }
            if (FormBase.is_clicked == 0)
            {
                id = "ST" + nol + FormMasterData.rowsCount.ToString();
            }
            else if (FormBase.is_clicked == 1)
            {
                id = "CO" + nol + FormMasterData.rowsCount.ToString();
            }
            else
            {
                id = "SU" + nol + FormMasterData.rowsCount.ToString();
            }
            return id;
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

        private void btBatal_Click(object sender, EventArgs e)
        {
            FormMasterData.is_edit = 0;
            this.Close();
        }
    }
}
