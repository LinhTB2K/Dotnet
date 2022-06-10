using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_example
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }


        private void menu_nhapsanpham_Click(object sender, EventArgs e)
        {

        }

        private void menu_dangnhap_Click(object sender, EventArgs e)
        {
            DangNhap dangnhap_form = new DangNhap();
            dangnhap_form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menu_sanpham_Click(object sender, EventArgs e)
        {
            SanPham sanpham_form = new SanPham();
            sanpham_form.ShowDialog();
        }

        private void menu_timsanpham_Click(object sender, EventArgs e)
        {
            ThongKe thongke_form = new ThongKe();
            thongke_form.Show();
        }
    }
}
