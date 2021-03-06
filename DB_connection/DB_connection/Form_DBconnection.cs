using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DB_connection
{
    public partial class Form_DBconnection : Form
    {
        public Form_DBconnection()
        {
            InitializeComponent();
        }

        private void bt_connect_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                string connectionstring = "";
                if (cb_windows_authentication.Checked == true)
                {
                    connectionstring = "server=" + tb_server_name.Text;
                    connectionstring += ";database=" + tb_database.Text;
                    connectionstring += ";integrated security=true";
                    conn.ConnectionString = connectionstring;
                }
                else
                {
                    connectionstring = "server=" + tb_server_name.Text;
                    connectionstring += ";database=" + tb_database.Text;
                    connectionstring += ";uid=" + tb_user.Text;
                    connectionstring += ";pwd=" + tb_password.Text;
                    conn.ConnectionString = connectionstring;
                }

                conn.Open();
                //MessageBox.Show("ket noi thanh cong");
                MessageBox.Show("Kết nối thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form_DBconnection_Load(object sender, EventArgs e)
        {

        }
    }
}
