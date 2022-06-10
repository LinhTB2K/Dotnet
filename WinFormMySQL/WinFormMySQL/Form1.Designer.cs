namespace WinFormMySQL
{
    partial class db_mysql
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
            this.gb_my_sql = new System.Windows.Forms.GroupBox();
            this.lb_port = new System.Windows.Forms.Label();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_connection = new System.Windows.Forms.Button();
            this.cb_windows_authentication = new System.Windows.Forms.CheckBox();
            this.tb_database = new System.Windows.Forms.TextBox();
            this.tb_user_name = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_sever_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gb_my_sql.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_my_sql
            // 
            this.gb_my_sql.Controls.Add(this.dataGridView1);
            this.gb_my_sql.Controls.Add(this.lb_port);
            this.gb_my_sql.Controls.Add(this.tb_port);
            this.gb_my_sql.Controls.Add(this.bt_cancel);
            this.gb_my_sql.Controls.Add(this.bt_connection);
            this.gb_my_sql.Controls.Add(this.cb_windows_authentication);
            this.gb_my_sql.Controls.Add(this.tb_database);
            this.gb_my_sql.Controls.Add(this.tb_user_name);
            this.gb_my_sql.Controls.Add(this.tb_password);
            this.gb_my_sql.Controls.Add(this.tb_sever_name);
            this.gb_my_sql.Controls.Add(this.label4);
            this.gb_my_sql.Controls.Add(this.label3);
            this.gb_my_sql.Controls.Add(this.label2);
            this.gb_my_sql.Controls.Add(this.label1);
            this.gb_my_sql.Location = new System.Drawing.Point(13, 13);
            this.gb_my_sql.Name = "gb_my_sql";
            this.gb_my_sql.Size = new System.Drawing.Size(564, 385);
            this.gb_my_sql.TabIndex = 0;
            this.gb_my_sql.TabStop = false;
            this.gb_my_sql.Text = "DB My SQL";
            // 
            // lb_port
            // 
            this.lb_port.AutoSize = true;
            this.lb_port.Location = new System.Drawing.Point(10, 187);
            this.lb_port.Name = "lb_port";
            this.lb_port.Size = new System.Drawing.Size(26, 13);
            this.lb_port.TabIndex = 8;
            this.lb_port.Text = "Port";
            // 
            // tb_port
            // 
            this.tb_port.Location = new System.Drawing.Point(70, 181);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(138, 20);
            this.tb_port.TabIndex = 7;
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(342, 297);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 40);
            this.bt_cancel.TabIndex = 6;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_connection
            // 
            this.bt_connection.Location = new System.Drawing.Point(70, 297);
            this.bt_connection.Name = "bt_connection";
            this.bt_connection.Size = new System.Drawing.Size(75, 40);
            this.bt_connection.TabIndex = 5;
            this.bt_connection.Text = "Connection";
            this.bt_connection.UseVisualStyleBackColor = true;
            this.bt_connection.Click += new System.EventHandler(this.bt_connection_Click);
            // 
            // cb_windows_authentication
            // 
            this.cb_windows_authentication.AutoSize = true;
            this.cb_windows_authentication.Location = new System.Drawing.Point(185, 249);
            this.cb_windows_authentication.Name = "cb_windows_authentication";
            this.cb_windows_authentication.Size = new System.Drawing.Size(80, 17);
            this.cb_windows_authentication.TabIndex = 4;
            this.cb_windows_authentication.Text = "checkBox1";
            this.cb_windows_authentication.UseVisualStyleBackColor = true;
            // 
            // tb_database
            // 
            this.tb_database.Location = new System.Drawing.Point(70, 63);
            this.tb_database.Name = "tb_database";
            this.tb_database.Size = new System.Drawing.Size(138, 20);
            this.tb_database.TabIndex = 1;
            // 
            // tb_user_name
            // 
            this.tb_user_name.Location = new System.Drawing.Point(70, 106);
            this.tb_user_name.Name = "tb_user_name";
            this.tb_user_name.Size = new System.Drawing.Size(138, 20);
            this.tb_user_name.TabIndex = 2;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(70, 143);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(138, 20);
            this.tb_password.TabIndex = 3;
            // 
            // tb_sever_name
            // 
            this.tb_sever_name.Location = new System.Drawing.Point(70, 26);
            this.tb_sever_name.Name = "tb_sever_name";
            this.tb_sever_name.Size = new System.Drawing.Size(230, 20);
            this.tb_sever_name.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Base";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sever Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(233, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(316, 138);
            this.dataGridView1.TabIndex = 9;
            // 
            // db_mysql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 410);
            this.Controls.Add(this.gb_my_sql);
            this.Name = "db_mysql";
            this.Text = "DB My SQL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_my_sql.ResumeLayout(false);
            this.gb_my_sql.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_my_sql;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_connection;
        private System.Windows.Forms.CheckBox cb_windows_authentication;
        private System.Windows.Forms.TextBox tb_database;
        private System.Windows.Forms.TextBox tb_user_name;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_sever_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_port;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

