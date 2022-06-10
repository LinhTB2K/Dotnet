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
    public partial class ThongKe : Form
    {
        string connectionstring = "server=" + @"DESKTOP-8BEG9VS"
                                    + ";database=" + "QLKho"
                                    + ";integrated security=true";
        SqlConnection con = new SqlConnection();
        SqlDataAdapter adapter;
        public ThongKe()
        {
            InitializeComponent();
        }

        private void bt_timsp_Click(object sender, EventArgs e)
        {
            con.ConnectionString = connectionstring;
            Dislay_SanPham_thongke();
        }

        private void Dislay_SanPham_thongke()
        {
            try
            {
                string makho = tb_makho.Text;

                con.Open();
                DataTable dt = new DataTable();
                adapter = new SqlDataAdapter("SELECT pn.MaPhieuNhap, pn.MaKho, sp.TenSP "+ 
                    "FROM SanPham sp, CTPhieuNhap ct, PhieuNhap pn " +
                    "WHERE pn.MaPhieuNhap = ct.MaPhieuNhap AND ct.MaSP = sp.MaSP "+
                    "AND pn.MaKho = '" + makho + "'", con);
                adapter.Fill(dt);
                gv_thongke.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }

        }

        private void ThongKe_Load(object sender, EventArgs e)
        {

        }

        private void gv_thongke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
