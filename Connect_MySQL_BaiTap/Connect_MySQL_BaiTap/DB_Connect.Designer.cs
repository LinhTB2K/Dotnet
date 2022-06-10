namespace Connect_MySQL_BaiTap
{
    partial class DB_Connect
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_sever_name = new System.Windows.Forms.TextBox();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.tb_database = new System.Windows.Forms.TextBox();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lb_sever_name = new System.Windows.Forms.Label();
            this.lb_database = new System.Windows.Forms.Label();
            this.lb_port = new System.Windows.Forms.Label();
            this.lb_user = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.bt_connect = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.cb_sever = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tb_sever_name
            // 
            this.tb_sever_name.Location = new System.Drawing.Point(169, 30);
            this.tb_sever_name.Name = "tb_sever_name";
            this.tb_sever_name.Size = new System.Drawing.Size(331, 23);
            this.tb_sever_name.TabIndex = 0;
            // 
            // tb_port
            // 
            this.tb_port.Location = new System.Drawing.Point(169, 130);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(175, 23);
            this.tb_port.TabIndex = 2;
            // 
            // tb_database
            // 
            this.tb_database.Location = new System.Drawing.Point(169, 78);
            this.tb_database.Name = "tb_database";
            this.tb_database.Size = new System.Drawing.Size(175, 23);
            this.tb_database.TabIndex = 1;
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(169, 184);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(175, 23);
            this.tb_user.TabIndex = 3;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(169, 232);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(175, 23);
            this.tb_password.TabIndex = 4;
            // 
            // lb_sever_name
            // 
            this.lb_sever_name.AutoSize = true;
            this.lb_sever_name.Location = new System.Drawing.Point(66, 38);
            this.lb_sever_name.Name = "lb_sever_name";
            this.lb_sever_name.Size = new System.Drawing.Size(70, 15);
            this.lb_sever_name.TabIndex = 5;
            this.lb_sever_name.Text = "Sever Name";
            // 
            // lb_database
            // 
            this.lb_database.AutoSize = true;
            this.lb_database.Location = new System.Drawing.Point(66, 86);
            this.lb_database.Name = "lb_database";
            this.lb_database.Size = new System.Drawing.Size(58, 15);
            this.lb_database.TabIndex = 6;
            this.lb_database.Text = "Data Base";
            // 
            // lb_port
            // 
            this.lb_port.AutoSize = true;
            this.lb_port.Location = new System.Drawing.Point(66, 138);
            this.lb_port.Name = "lb_port";
            this.lb_port.Size = new System.Drawing.Size(29, 15);
            this.lb_port.TabIndex = 7;
            this.lb_port.Text = "Port";
            this.lb_port.Click += new System.EventHandler(this.lb_port_Click);
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Location = new System.Drawing.Point(66, 192);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(44, 15);
            this.lb_user.TabIndex = 8;
            this.lb_user.Text = "User ID";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(66, 240);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(57, 15);
            this.lb_password.TabIndex = 9;
            this.lb_password.Text = "Password";
            // 
            // bt_connect
            // 
            this.bt_connect.Location = new System.Drawing.Point(108, 340);
            this.bt_connect.Name = "bt_connect";
            this.bt_connect.Size = new System.Drawing.Size(75, 23);
            this.bt_connect.TabIndex = 6;
            this.bt_connect.Text = "Connect";
            this.bt_connect.UseVisualStyleBackColor = true;
            this.bt_connect.Click += new System.EventHandler(this.bt_connect_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(346, 340);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 7;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // cb_sever
            // 
            this.cb_sever.AutoSize = true;
            this.cb_sever.Location = new System.Drawing.Point(191, 290);
            this.cb_sever.Name = "cb_sever";
            this.cb_sever.Size = new System.Drawing.Size(83, 19);
            this.cb_sever.TabIndex = 5;
            this.cb_sever.Text = "checkBox1";
            this.cb_sever.UseVisualStyleBackColor = true;
            // 
            // DB_Connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 381);
            this.Controls.Add(this.cb_sever);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_connect);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.lb_port);
            this.Controls.Add(this.lb_database);
            this.Controls.Add(this.lb_sever_name);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.tb_database);
            this.Controls.Add(this.tb_port);
            this.Controls.Add(this.tb_sever_name);
            this.Name = "DB_Connect";
            this.Text = "Db_Connect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_sever_name;
        private TextBox tb_port;
        private TextBox tb_database;
        private TextBox tb_user;
        private TextBox tb_password;
        private Label lb_sever_name;
        private Label lb_database;
        private Label lb_port;
        private Label lb_user;
        private Label lb_password;
        private Button bt_connect;
        private Button bt_cancel;
        private CheckBox cb_sever;
    }
}