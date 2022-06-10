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

namespace Menu_example
{
    public partial class DangNhap : Form
    {
        
        public DangNhap()
        {
            InitializeComponent();
        }

        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            
            //code đăng nhập 
            string connectionstring = "server=" + @"DESKTOP-8BEG9VS"
                                    + ";database=" + "QLKho" 
                                    + ";integrated security=true";
            SqlConnection con = new SqlConnection(connectionstring);
            try
            {
                con.Open();
                string matkhau = tb_matkhau.Text;
                string taikhoan = tb_taikhoan.Text;

                string sql = "SELECT * FROM Nguoidung WHERE Taikhoan='" + taikhoan + "'AND matkhau='" + matkhau + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Kết nối thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản/Mật khẩu chưa đúng");
                }  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
            
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
