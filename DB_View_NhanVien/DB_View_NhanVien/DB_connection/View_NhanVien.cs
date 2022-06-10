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
    public partial class View_NhanVien : Form
    {
        public string conect_string = "";
        SqlConnection con = new SqlConnection();
        SqlCommand cmd;
        SqlDataAdapter adapter;
        int row_id = 0;

        public View_NhanVien()
        {
            InitializeComponent();
        }

        private void View_NhanVien_Load(object sender, EventArgs e)
        {
            con.ConnectionString = conect_string;
            Dislay_NhanVien();

        }
        private void Dislay_NhanVien()
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                adapter = new SqlDataAdapter("SELECT * FROM NhanVien", con);
                adapter.Fill(dt);
                gv_nhanvien.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void Clear_NhanVien()
        {
            tb_id.Text = "";
            tb_hoten.Text = "";
            tb_chucvu.Text = "";
        }

        private void gv_nhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row_id = e.RowIndex;
            //MessageBox.Show(row_id.ToString());
            tb_id.Text = gv_nhanvien.Rows[row_id].Cells[0].Value.ToString().Trim();
            tb_hoten.Text = gv_nhanvien.Rows[row_id].Cells[1].Value.ToString().Trim();
            tb_chucvu.Text = gv_nhanvien.Rows[row_id].Cells[2].Value.ToString().Trim();
        }

        private void bt_insert_Click(object sender, EventArgs e)
        {
            if (tb_id.Text != "" && tb_hoten.Text != "" && tb_chucvu.Text != "")
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO NhanVien(ID,HoTen,ChucVu) VALUES(@id,@hoten,@chucvu)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", tb_id.Text);
                    cmd.Parameters.AddWithValue("@hoten", tb_hoten.Text);
                    cmd.Parameters.AddWithValue("@chucvu", tb_chucvu.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Insert thành công vào bảng Nhân viên");
                    Dislay_NhanVien();
                    Clear_NhanVien();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            if (tb_id.Text != "" && tb_hoten.Text != "" && tb_chucvu.Text != "")
            {
                try
                {
                    cmd = new SqlCommand("UPDATE NhanVien SET HoTen=@hoten,ChucVu=@chucvu WHERE ID=@id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", tb_id.Text);
                    cmd.Parameters.AddWithValue("@hoten", tb_hoten.Text);
                    cmd.Parameters.AddWithValue("@chucvu", tb_chucvu.Text);
                    //cmd.ExecuteNonQuery();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    //MessageBox.Show(rowsAffected.ToString());
                    if (rowsAffected == 1)
                    {
                        MessageBox.Show("Update thành công vào bảng Nhân viên");
                    }
                    con.Close();
                    Dislay_NhanVien();
                    Clear_NhanVien();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (tb_id.Text != "" && tb_hoten.Text != "" && tb_chucvu.Text != "")
            {
                try
                {
                    cmd = new SqlCommand("DELETE NhanVien WHERE ID=@id and Hoten=@hoten and Chucvu=@chucvu", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", tb_id.Text);
                    cmd.Parameters.AddWithValue("@hoten", tb_hoten.Text);
                    cmd.Parameters.AddWithValue("@chucvu", tb_chucvu.Text);
                    //cmd.ExecuteNonQuery();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    //MessageBox.Show(rowsAffected.ToString());
                    if (rowsAffected == 1)
                    {
                        MessageBox.Show("Delete thành công vào bảng Nhân viên");
                    }
                    else
                    {
                        MessageBox.Show("Không có nhân viên bị xóa");
                    }
                    con.Close();
                    Dislay_NhanVien();
                    Clear_NhanVien();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa");
            }
        }
    }
}
