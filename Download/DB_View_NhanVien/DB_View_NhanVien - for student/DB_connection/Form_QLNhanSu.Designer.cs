namespace DB_connection
{
    partial class Form_QLNhanSu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_filter = new System.Windows.Forms.Button();
            this.bt_sort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(694, 231);
            this.dataGridView1.TabIndex = 0;
            // 
            // bt_filter
            // 
            this.bt_filter.Location = new System.Drawing.Point(43, 332);
            this.bt_filter.Name = "bt_filter";
            this.bt_filter.Size = new System.Drawing.Size(122, 37);
            this.bt_filter.TabIndex = 1;
            this.bt_filter.Text = "Filter";
            this.bt_filter.UseVisualStyleBackColor = true;
            // 
            // bt_sort
            // 
            this.bt_sort.Location = new System.Drawing.Point(203, 332);
            this.bt_sort.Name = "bt_sort";
            this.bt_sort.Size = new System.Drawing.Size(122, 37);
            this.bt_sort.TabIndex = 2;
            this.bt_sort.Text = "Sort";
            this.bt_sort.UseVisualStyleBackColor = true;
            // 
            // Form_QLNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 390);
            this.Controls.Add(this.bt_sort);
            this.Controls.Add(this.bt_filter);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_QLNhanSu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_QLNhanSu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_filter;
        private System.Windows.Forms.Button bt_sort;
    }
}