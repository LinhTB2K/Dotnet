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
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admin_role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user,
            this.password,
            this.admin_role});
            this.dataGridView1.Location = new System.Drawing.Point(41, 55);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(520, 188);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bt_filter
            // 
            this.bt_filter.Location = new System.Drawing.Point(32, 270);
            this.bt_filter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_filter.Name = "bt_filter";
            this.bt_filter.Size = new System.Drawing.Size(92, 30);
            this.bt_filter.TabIndex = 1;
            this.bt_filter.Text = "Filter";
            this.bt_filter.UseVisualStyleBackColor = true;
            this.bt_filter.Click += new System.EventHandler(this.bt_filter_Click);
            // 
            // bt_sort
            // 
            this.bt_sort.Location = new System.Drawing.Point(152, 270);
            this.bt_sort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_sort.Name = "bt_sort";
            this.bt_sort.Size = new System.Drawing.Size(92, 30);
            this.bt_sort.TabIndex = 2;
            this.bt_sort.Text = "Sort";
            this.bt_sort.UseVisualStyleBackColor = true;
            this.bt_sort.Click += new System.EventHandler(this.bt_sort_Click);
            // 
            // user
            // 
            this.user.HeaderText = "user";
            this.user.Name = "user";
            this.user.ReadOnly = true;
            // 
            // password
            // 
            this.password.HeaderText = "password";
            this.password.Name = "password";
            // 
            // admin_role
            // 
            this.admin_role.HeaderText = "admin_role";
            this.admin_role.Name = "admin_role";
            this.admin_role.ReadOnly = true;
            // 
            // Form_QLNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 317);
            this.Controls.Add(this.bt_sort);
            this.Controls.Add(this.bt_filter);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn admin_role;
    }
}