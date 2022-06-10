using MySql.Data.MySqlClient;

namespace Connect_MySQL_BaiTap
{
    public partial class DB_Connect : Form
    {
        public DB_Connect()
        {
            InitializeComponent();
        }

        private void lb_port_Click(object sender, EventArgs e)
        {

        }

        private void bt_connect_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                String connString = "";
                if (cb_sever.Checked == false) {
                    connString = "Server=" + tb_sever_name.Text;
                    connString += ";Database=" + tb_database.Text;
                    connString += ";integrated security=true";
                    conn.ConnectionString = connString;

                }
                else {
                    connString = "Server=" + tb_sever_name.Text;
                    connString += ";Database=" + tb_database.Text;
                    connString += ";port=" + tb_port.Text;
                    connString += ";UserId=" + tb_user.Text;
                    connString += ";password=" + tb_password.Text;
                    conn.ConnectionString = connString;
                }
                conn.Open();
                //MessageBox.Show("ket noi thanh cong");
                MessageBox.Show("Kết nối thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();

            }
            catch (Exception ex) {
                MessageBox.Show(ex);
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