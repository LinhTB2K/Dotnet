namespace DB_connection
{
    partial class Form_DBconnection
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
            this.lb_server_name = new System.Windows.Forms.Label();
            this.tb_server_name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_database = new System.Windows.Forms.TextBox();
            this.lb_database = new System.Windows.Forms.Label();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_connect = new System.Windows.Forms.Button();
            this.cb_windows_authentication = new System.Windows.Forms.CheckBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.lb_user = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_server_name
            // 
            this.lb_server_name.AutoSize = true;
            this.lb_server_name.Location = new System.Drawing.Point(16, 27);
            this.lb_server_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_server_name.Name = "lb_server_name";
            this.lb_server_name.Size = new System.Drawing.Size(67, 13);
            this.lb_server_name.TabIndex = 0;
            this.lb_server_name.Text = "Server name";
            // 
            // tb_server_name
            // 
            this.tb_server_name.Location = new System.Drawing.Point(101, 24);
            this.tb_server_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_server_name.Name = "tb_server_name";
            this.tb_server_name.Size = new System.Drawing.Size(210, 20);
            this.tb_server_name.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_database);
            this.groupBox1.Controls.Add(this.lb_database);
            this.groupBox1.Controls.Add(this.bt_cancel);
            this.groupBox1.Controls.Add(this.bt_connect);
            this.groupBox1.Controls.Add(this.cb_windows_authentication);
            this.groupBox1.Controls.Add(this.tb_password);
            this.groupBox1.Controls.Add(this.lb_password);
            this.groupBox1.Controls.Add(this.tb_user);
            this.groupBox1.Controls.Add(this.lb_user);
            this.groupBox1.Controls.Add(this.tb_server_name);
            this.groupBox1.Controls.Add(this.lb_server_name);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(337, 271);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DB connection";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tb_database
            // 
            this.tb_database.Location = new System.Drawing.Point(101, 62);
            this.tb_database.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_database.Name = "tb_database";
            this.tb_database.Size = new System.Drawing.Size(136, 20);
            this.tb_database.TabIndex = 10;
            // 
            // lb_database
            // 
            this.lb_database.AutoSize = true;
            this.lb_database.Location = new System.Drawing.Point(16, 64);
            this.lb_database.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_database.Name = "lb_database";
            this.lb_database.Size = new System.Drawing.Size(53, 13);
            this.lb_database.TabIndex = 9;
            this.lb_database.Text = "Database";
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(195, 207);
            this.bt_cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(86, 36);
            this.bt_cancel.TabIndex = 8;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_connect
            // 
            this.bt_connect.Location = new System.Drawing.Point(57, 207);
            this.bt_connect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_connect.Name = "bt_connect";
            this.bt_connect.Size = new System.Drawing.Size(86, 36);
            this.bt_connect.TabIndex = 7;
            this.bt_connect.Text = "Connect";
            this.bt_connect.UseVisualStyleBackColor = true;
            this.bt_connect.Click += new System.EventHandler(this.bt_connect_Click);
            // 
            // cb_windows_authentication
            // 
            this.cb_windows_authentication.AutoSize = true;
            this.cb_windows_authentication.Location = new System.Drawing.Point(101, 165);
            this.cb_windows_authentication.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_windows_authentication.Name = "cb_windows_authentication";
            this.cb_windows_authentication.Size = new System.Drawing.Size(141, 17);
            this.cb_windows_authentication.TabIndex = 6;
            this.cb_windows_authentication.Text = "Windows Authentication";
            this.cb_windows_authentication.UseVisualStyleBackColor = true;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(101, 132);
            this.tb_password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(74, 20);
            this.tb_password.TabIndex = 5;
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(16, 134);
            this.lb_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(53, 13);
            this.lb_password.TabIndex = 4;
            this.lb_password.Text = "Password";
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(101, 98);
            this.tb_user.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(74, 20);
            this.tb_user.TabIndex = 3;
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Location = new System.Drawing.Point(16, 100);
            this.lb_user.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(29, 13);
            this.lb_user.TabIndex = 2;
            this.lb_user.Text = "User";
            // 
            // Form_DBconnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 290);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_DBconnection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DB connection";
            this.Load += new System.EventHandler(this.Form_DBconnection_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_server_name;
        private System.Windows.Forms.TextBox tb_server_name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_connect;
        private System.Windows.Forms.CheckBox cb_windows_authentication;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.TextBox tb_database;
        private System.Windows.Forms.Label lb_database;
    }
}

