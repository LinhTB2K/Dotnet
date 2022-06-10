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
    public partial class User_Login : Form
    {
        public string connect_text = "";
        public User_Login()
        {
            InitializeComponent();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(connect_text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connect_text;
            con.Open();

            string user = tb_user.Text;
            string password = tb_password.Text;

            string sql = "SELECT admin_role FROM tbuser WHERE user='" + user + "'AND password='" + password + "'" ;
            
            SqlCommand cmd = new SqlCommand(sql,con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login sucess!");
                var admin_role = dt.Rows[0].Field<string>("admin_role");
                if (admin_role == "y")
                {
                    MessageBox.Show("Chào mừng Bạn đang login bằng quyền admin!");
                    Form_QLNhanSu form_nhansu = new Form_QLNhanSu();
                    this.Hide();
                    form_nhansu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Chào mừng bạn đã login vào hệ thống !");
                }
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }

            con.Close();
        }
    }
}
