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
            try
            {
                MessageBox.Show(connect_text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SqlConnection con = new SqlConnection();
                con.ConnectionString = connect_text;
                con.Open();

                string user = tb_user.Text;
                string password = tb_password.Text;

                MessageBox.Show(user + password, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                DataTable dt = new DataTable();
                string sql = "SELECT admin_role FROM tbuser WHERE [user]='" + user + "'AND password='" + password + "'";

                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login sucess!");
                    var admin_role = dt.Rows[0].Field<string>("admin_role");
                    MessageBox.Show(admin_role);
                    if (true)
                    {
                        MessageBox.Show("Chào mừng Bạn đang login bằng quyền admin!");
                        Form_QLNhanSu form_nhansu = new Form_QLNhanSu();
                        this.Hide();
                        form_nhansu.ShowDialog();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Chào mừng bạn đã dang nhap vào hệ thống !");
                    }
                }
                else
                {
                    MessageBox.Show("Thong tin dang nhap khong hop le vui long kiem tra lai username va password");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            
        }

        private void User_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
