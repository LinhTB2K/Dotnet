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
                    cmd.Parameters.AddWithValue("@TenSP", tb_tenSP.Text);
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
            if (txt_MaSP.Text != "") { 
            try
            {
                cmd = new SqlCommand("UPDATE SanPham SET TenSp=@TenSp,Mota=@Mota,TonKho=@TonKho WHERE MaSP=@MaSP", con);
                con.Open();
                cmd.Parameters.AddWithValue("@MaSP", txt_MaSP.Text);
                cmd.Parameters.AddWithValue("@TenSp", txt_TenSP.Text);
                cmd.Parameters.AddWithValue("@Mota", txt_Mota.Text);
                cmd.Parameters.AddWithValue("@TonKho", txt_TonKho.Text);
                //cmd.ExecuteNonQuery();
                int rowsAffected = cmd.ExecuteNonQuery();
                //MessageBox.Show(rowsAffected.ToString());
                if (rowsAffected == 1)
                {
                    MessageBox.Show("Update thành công vào bảng Nhân viên");
                }
                con.Close();
                Dislay_SanPham();
                Clear_SanPham();
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

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (txt_MaSP.Text != "" && txt_TenSP.Text != "" && txt_Mota.Text != "" && txt_TonKho.Text != "")
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO SanPham(MaSP,TenSp,MoTa,TonKho) VALUES(@MaSP,@TenSp,@MoTa,@TonKho)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@MaSP", txt_MaSP.Text);
                    cmd.Parameters.AddWithValue("@TenSp", txt_TenSP.Text);
                    cmd.Parameters.AddWithValue("@MoTa", txt_Mota.Text);
                    cmd.Parameters.AddWithValue("@TonKho", txt_TonKho.Text);

                    //cmd.ExecuteNonQuery();
                    con.Close();
                    //MessageBox.Show("Insert thành công vào bảng Nhân viên");
                    Dislay_SanPham();
                    Clear_SanPham();
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
        private void Clear_SanPham()
        {
            txt_MaSP.Text = "";
            txt_Mota.Text = "";
            txt_TenSP.Text = "";
            txt_TonKho.Text = "";
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

        private void gv_sanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row_id = e.RowIndex;
            MessageBox.Show(row_id.ToString());
            txt_MaSP.Text = gv_sanpham.Rows[row_id].Cells[0].Value.ToString().Trim();
            txt_TenSP.Text = gv_sanpham.Rows[row_id].Cells[1].Value.ToString().Trim();
            txt_Mota.Text = gv_sanpham.Rows[row_id].Cells[2].Value.ToString().Trim();
            txt_TonKho.Text = gv_sanpham.Rows[row_id].Cells[3].Value.ToString().Trim();

        }

        private void tb_tenSP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
