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
    public partial class SanPham : Form
    {
        string connectionstring = "server=" + @"DESKTOP-8BEG9VS"
                                    + ";database=" + "QLKho"
                                    + ";integrated security=true";
        SqlConnection con = new SqlConnection();
        SqlCommand cmd;
        SqlDataAdapter adapter;
        int row_id = 0;

        public SanPham()
        {
            InitializeComponent();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            if (tb_tenSP.Text != "")
            {
                try
                {
                    cmd = new SqlCommand("DELETE SanPham WHERE TenSP=@TenSP", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", tb_tenSP.Text);
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
                    Dislay_SanPham();
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

        private void bt_sua_Click(object sender, EventArgs e)
        {

        }

        private void bt_them_Click(object sender, EventArgs e)
        {

        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            con.ConnectionString = connectionstring;
            Dislay_SanPham();
        }

        private void Dislay_SanPham()
        {
            try
            {
                
                con.Open();
                DataTable dt = new DataTable();
                adapter = new SqlDataAdapter("SELECT * FROM SanPham", con);
                adapter.Fill(dt);
                gv_sanpham.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }

        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
           
            Dislay_SanPham_timkiem();
           
        }

        private void Dislay_SanPham_timkiem()
        {
            try
            {
                string tenSP = tb_tenSP.Text;
                con.Open();
                DataTable dt = new DataTable();
                adapter = new SqlDataAdapter("SELECT * FROM SanPham WHERE TenSP = '" + tenSP + "'", con);
                adapter.Fill(dt);
                gv_sanpham.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }

        }
    }
}
