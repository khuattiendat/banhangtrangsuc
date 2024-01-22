namespace banhangtrangsuc
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.txtName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_number = new System.Windows.Forms.TextBox();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.dt_date = new System.Windows.Forms.DateTimePicker();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_typeAcc = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(19, 82);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(53, 27);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Tên";
            this.txtName.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số DT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(553, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(560, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(554, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 27);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mật khẩu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(554, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 27);
            this.label8.TabIndex = 7;
            this.label8.Text = "Loại TK";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(169, 75);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(272, 35);
            this.tb_name.TabIndex = 8;
            // 
            // tb_number
            // 
            this.tb_number.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_number.Location = new System.Drawing.Point(169, 158);
            this.tb_number.Name = "tb_number";
            this.tb_number.Size = new System.Drawing.Size(272, 35);
            this.tb_number.TabIndex = 9;
            this.tb_number.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cb_gender
            // 
            this.cb_gender.AutoCompleteCustomSource.AddRange(new string[] {
            "nam",
            "nữ"});
            this.cb_gender.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Items.AddRange(new object[] {
            "nam",
            "nữ"});
            this.cb_gender.Location = new System.Drawing.Point(171, 252);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(270, 35);
            this.cb_gender.TabIndex = 10;
            this.cb_gender.Text = "nam";
            this.cb_gender.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dt_date
            // 
            this.dt_date.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_date.Location = new System.Drawing.Point(171, 337);
            this.dt_date.Name = "dt_date";
            this.dt_date.Size = new System.Drawing.Size(270, 35);
            this.dt_date.TabIndex = 11;
            // 
            // tb_address
            // 
            this.tb_address.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_address.Location = new System.Drawing.Point(687, 71);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(265, 35);
            this.tb_address.TabIndex = 12;
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(687, 146);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(265, 35);
            this.tb_email.TabIndex = 13;
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(687, 244);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(265, 35);
            this.tb_password.TabIndex = 14;
            this.tb_password.UseSystemPasswordChar = true;
            // 
            // tb_typeAcc
            // 
            this.tb_typeAcc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_typeAcc.Location = new System.Drawing.Point(687, 346);
            this.tb_typeAcc.Name = "tb_typeAcc";
            this.tb_typeAcc.ReadOnly = true;
            this.tb_typeAcc.Size = new System.Drawing.Size(265, 35);
            this.tb_typeAcc.TabIndex = 15;
            this.tb_typeAcc.Text = "Nhân Viên";
            this.tb_typeAcc.TextChanged += new System.EventHandler(this.tb_typeAcc_TextChanged);
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.LightBlue;
            this.btn_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_register.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.Image = ((System.Drawing.Image)(resources.GetObject("btn_register.Image")));
            this.btn_register.Location = new System.Drawing.Point(229, 444);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(190, 73);
            this.btn_register.TabIndex = 16;
            this.btn_register.Text = "Đăng ký";
            this.btn_register.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_register.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.LightBlue;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Image = ((System.Drawing.Image)(resources.GetObject("btn_login.Image")));
            this.btn_login.Location = new System.Drawing.Point(616, 444);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(202, 73);
            this.btn_login.TabIndex = 18;
            this.btn_login.Text = "Đăng nhập";
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // fDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 590);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.tb_typeAcc);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.dt_date);
            this.Controls.Add(this.cb_gender);
            this.Controls.Add(this.tb_number);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Name = "fDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fDangKy_FormClosing);
            this.Load += new System.EventHandler(this.fDangKy_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_number;
        private System.Windows.Forms.ComboBox cb_gender;
        private System.Windows.Forms.DateTimePicker dt_date;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_typeAcc;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_login;
    }
}