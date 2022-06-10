namespace Menu_example
{
    partial class SanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gv_sanpham = new System.Windows.Forms.DataGridView();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.tb_tenSP = new System.Windows.Forms.TextBox();
            this.bt_timkiem = new System.Windows.Forms.Button();
            this.txt_MaSP = new System.Windows.Forms.TextBox();
            this.txt_TenSP = new System.Windows.Forms.TextBox();
            this.txt_Mota = new System.Windows.Forms.TextBox();
            this.txt_TonKho = new System.Windows.Forms.TextBox();
            this.lb_MaSp = new System.Windows.Forms.Label();
            this.lb_TenSanPham = new System.Windows.Forms.Label();
            this.lb_Mota = new System.Windows.Forms.Label();
            this.lb_TonKho = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gv_sanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_sanpham
            // 
            this.gv_sanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_sanpham.Location = new System.Drawing.Point(10, 229);
            this.gv_sanpham.Margin = new System.Windows.Forms.Padding(2);
            this.gv_sanpham.Name = "gv_sanpham";
            this.gv_sanpham.RowTemplate.Height = 24;
            this.gv_sanpham.Size = new System.Drawing.Size(456, 199);
            this.gv_sanpham.TabIndex = 0;
            this.gv_sanpham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_sanpham_CellContentClick);
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(482, 269);
            this.bt_them.Margin = new System.Windows.Forms.Padding(2);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(56, 28);
            this.bt_them.TabIndex = 1;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(482, 323);
            this.bt_sua.Margin = new System.Windows.Forms.Padding(2);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(56, 28);
            this.bt_sua.TabIndex = 2;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(482, 376);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(2);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(56, 28);
            this.bt_xoa.TabIndex = 3;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // tb_tenSP
            // 
            this.tb_tenSP.Location = new System.Drawing.Point(338, 36);
            this.tb_tenSP.Margin = new System.Windows.Forms.Padding(2);
            this.tb_tenSP.Name = "tb_tenSP";
            this.tb_tenSP.Size = new System.Drawing.Size(128, 20);
            this.tb_tenSP.TabIndex = 4;
            this.tb_tenSP.TextChanged += new System.EventHandler(this.tb_tenSP_TextChanged);
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.Location = new System.Drawing.Point(482, 28);
            this.bt_timkiem.Margin = new System.Windows.Forms.Padding(2);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(56, 28);
            this.bt_timkiem.TabIndex = 5;
            this.bt_timkiem.Text = "Tìm kiếm";
            this.bt_timkiem.UseVisualStyleBackColor = true;
            this.bt_timkiem.Click += new System.EventHandler(this.bt_timkiem_Click);
            // 
            // txt_MaSP
            // 
            this.txt_MaSP.Location = new System.Drawing.Point(140, 36);
            this.txt_MaSP.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MaSP.Name = "txt_MaSP";
            this.txt_MaSP.Size = new System.Drawing.Size(128, 20);
            this.txt_MaSP.TabIndex = 6;
            // 
            // txt_TenSP
            // 
            this.txt_TenSP.Location = new System.Drawing.Point(140, 81);
            this.txt_TenSP.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TenSP.Name = "txt_TenSP";
            this.txt_TenSP.Size = new System.Drawing.Size(128, 20);
            this.txt_TenSP.TabIndex = 7;
            // 
            // txt_Mota
            // 
            this.txt_Mota.Location = new System.Drawing.Point(140, 132);
            this.txt_Mota.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Mota.Name = "txt_Mota";
            this.txt_Mota.Size = new System.Drawing.Size(128, 20);
            this.txt_Mota.TabIndex = 8;
            // 
            // txt_TonKho
            // 
            this.txt_TonKho.Location = new System.Drawing.Point(140, 182);
            this.txt_TonKho.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TonKho.Name = "txt_TonKho";
            this.txt_TonKho.Size = new System.Drawing.Size(128, 20);
            this.txt_TonKho.TabIndex = 9;
            // 
            // lb_MaSp
            // 
            this.lb_MaSp.AutoSize = true;
            this.lb_MaSp.Location = new System.Drawing.Point(23, 43);
            this.lb_MaSp.Name = "lb_MaSp";
            this.lb_MaSp.Size = new System.Drawing.Size(74, 13);
            this.lb_MaSp.TabIndex = 10;
            this.lb_MaSp.Text = "Mã Sản Phẩm";
            // 
            // lb_TenSanPham
            // 
            this.lb_TenSanPham.AutoSize = true;
            this.lb_TenSanPham.Location = new System.Drawing.Point(23, 88);
            this.lb_TenSanPham.Name = "lb_TenSanPham";
            this.lb_TenSanPham.Size = new System.Drawing.Size(78, 13);
            this.lb_TenSanPham.TabIndex = 11;
            this.lb_TenSanPham.Text = "Tên Sản Phẩm";
            // 
            // lb_Mota
            // 
            this.lb_Mota.AutoSize = true;
            this.lb_Mota.Location = new System.Drawing.Point(23, 139);
            this.lb_Mota.Name = "lb_Mota";
            this.lb_Mota.Size = new System.Drawing.Size(38, 13);
            this.lb_Mota.TabIndex = 12;
            this.lb_Mota.Text = "Mô Tả";
            // 
            // lb_TonKho
            // 
            this.lb_TonKho.AutoSize = true;
            this.lb_TonKho.Location = new System.Drawing.Point(23, 182);
            this.lb_TonKho.Name = "lb_TonKho";
            this.lb_TonKho.Size = new System.Drawing.Size(48, 13);
            this.lb_TonKho.TabIndex = 13;
            this.lb_TonKho.Text = "Tồn Kho";
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 425);
            this.Controls.Add(this.lb_TonKho);
            this.Controls.Add(this.lb_Mota);
            this.Controls.Add(this.lb_TenSanPham);
            this.Controls.Add(this.lb_MaSp);
            this.Controls.Add(this.txt_TonKho);
            this.Controls.Add(this.txt_Mota);
            this.Controls.Add(this.txt_TenSP);
            this.Controls.Add(this.txt_MaSP);
            this.Controls.Add(this.bt_timkiem);
            this.Controls.Add(this.tb_tenSP);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.gv_sanpham);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SanPham";
            this.Text = "SanPham";
            this.Load += new System.EventHandler(this.SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_sanpham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_sanpham;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.TextBox tb_tenSP;
        private System.Windows.Forms.Button bt_timkiem;
        private System.Windows.Forms.TextBox txt_MaSP;
        private System.Windows.Forms.TextBox txt_TenSP;
        private System.Windows.Forms.TextBox txt_Mota;
        private System.Windows.Forms.TextBox txt_TonKho;
        private System.Windows.Forms.Label lb_MaSp;
        private System.Windows.Forms.Label lb_TenSanPham;
        private System.Windows.Forms.Label lb_Mota;
        private System.Windows.Forms.Label lb_TonKho;
    }
}