using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_connection
{
    public partial class Form_QLNhanSu : Form
    {
        public string ConnectionString = "";
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd;
        SqlDataAdapter adapter;
        public int row_id;

        public Form_QLNhanSu()
        {
            InitializeComponent();
        }

        private void bt_filter_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_sort_Click(object sender, EventArgs e)
        {
            tb_Id.Text = "";
            tb_Password.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row_id = e.RowIndex;
            MessageBox.Show(row_id.ToString());
            tb_Id.Text = dataGridView1.Rows[row_id].Cells[0].Value.ToString().Trim() ;
        }

        private void bt_insert_Click(object sender, EventArgs e)
        {
            if (tb_Id.Text != "" && tb_Password.Text != "")
            {
            }
            else {
                MessageBox.Show("Vui long nhap lai tai khoan va mat khau !!!");
            }
            try {
                cmd = new SqlCommand("",conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("insert thanh cong!!!");
            }catch(Exception ex) { MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }
    }
}
