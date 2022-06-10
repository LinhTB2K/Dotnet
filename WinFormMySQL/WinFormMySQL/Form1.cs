using MongoDB.Driver;
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

namespace WinFormMySQL
{
    public partial class db_mysql : Form
    {
        public db_mysql()
        {
            InitializeComponent();
            if (cb_windows_authentication.Checked == true)
            {
                tb_password.Enabled = true;

            }
            else
            {
                tb_password.Enabled = false;
                tb_user_name.Enabled = false;
                tb_port.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_connection_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                String strConnection ="";
                if (cb_windows_authentication.Checked == true)
                {
                    strConnection = "server= " + tb_sever_name.Text;
                    strConnection += ";database= " + tb_database.Text;
                    strConnection += ";integrated security=true";
                    strConnection += ";uid=" + tb_user_name.Text;
                    strConnection += ";pwd=" + tb_password.Text;
                    conn.ConnectionString = strConnection;
                }
                else {
                    strConnection = "datasource= " + tb_sever_name.Text;
                    strConnection += ";database= " + tb_database.Text;
                    strConnection += ";uid=" + tb_user_name.Text;
                    strConnection += ";pwd=" + tb_password.Text;
                    conn.ConnectionString = strConnection;
                }
                conn.Open();
                DataTable dt = new DataTable();
                string strSql = "Select * from tbnhanvien";
                MySqlDataAdapter adapter = new MySqlDataAdapter(strSql,conn);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                MessageBox.Show("Kết nối thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Ket noi that bai");
            }

         }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
