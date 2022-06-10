namespace Menu_example
{
    partial class ThongKe
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
            this.tb_makho = new System.Windows.Forms.TextBox();
            this.bt_timsp = new System.Windows.Forms.Button();
            this.gv_thongke = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gv_thongke)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_makho
            // 
            this.tb_makho.Location = new System.Drawing.Point(261, 35);
            this.tb_makho.Name = "tb_makho";
            this.tb_makho.Size = new System.Drawing.Size(136, 22);
            this.tb_makho.TabIndex = 0;
            // 
            // bt_timsp
            // 
            this.bt_timsp.Location = new System.Drawing.Point(424, 35);
            this.bt_timsp.Name = "bt_timsp";
            this.bt_timsp.Size = new System.Drawing.Size(126, 34);
            this.bt_timsp.TabIndex = 2;
            this.bt_timsp.Text = "Tìm sản phẩm";
            this.bt_timsp.UseVisualStyleBackColor = true;
            this.bt_timsp.Click += new System.EventHandler(this.bt_timsp_Click);
            // 
            // gv_thongke
            // 
            this.gv_thongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_thongke.Location = new System.Drawing.Point(24, 109);
            this.gv_thongke.Name = "gv_thongke";
            this.gv_thongke.RowTemplate.Height = 24;
            this.gv_thongke.Size = new System.Drawing.Size(566, 269);
            this.gv_thongke.TabIndex = 3;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 415);
            this.Controls.Add(this.gv_thongke);
            this.Controls.Add(this.bt_timsp);
            this.Controls.Add(this.tb_makho);
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_thongke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_makho;
        private System.Windows.Forms.Button bt_timsp;
        private System.Windows.Forms.DataGridView gv_thongke;
    }
}