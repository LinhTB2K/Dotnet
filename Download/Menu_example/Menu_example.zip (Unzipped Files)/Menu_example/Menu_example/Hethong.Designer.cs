namespace Menu_example
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_dangnhap = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_sanpham = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_thongke = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_dangnhap,
            this.menu_sanpham,
            this.menu_thongke});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(742, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_dangnhap
            // 
            this.menu_dangnhap.Name = "menu_dangnhap";
            this.menu_dangnhap.Size = new System.Drawing.Size(94, 24);
            this.menu_dangnhap.Text = "Đăng nhập";
            this.menu_dangnhap.Click += new System.EventHandler(this.menu_dangnhap_Click);
            // 
            // menu_sanpham
            // 
            this.menu_sanpham.Name = "menu_sanpham";
            this.menu_sanpham.Size = new System.Drawing.Size(86, 24);
            this.menu_sanpham.Text = "Sản Phẩm";
            this.menu_sanpham.Click += new System.EventHandler(this.menu_sanpham_Click);
            // 
            // menu_thongke
            // 
            this.menu_thongke.Name = "menu_thongke";
            this.menu_thongke.Size = new System.Drawing.Size(84, 24);
            this.menu_thongke.Text = "Thống Kê";
            this.menu_thongke.Click += new System.EventHandler(this.menu_timsanpham_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 302);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_dangnhap;
        private System.Windows.Forms.ToolStripMenuItem menu_sanpham;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_thongke;
    }
}

