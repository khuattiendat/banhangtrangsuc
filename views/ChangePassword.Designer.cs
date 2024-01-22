namespace banhangtrangsuc
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_oldPassword = new System.Windows.Forms.TextBox();
            this.tb_confirmNewPassword = new System.Windows.Forms.TextBox();
            this.tb_newPassword = new System.Windows.Forms.TextBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập lại MK mới";
            // 
            // tb_oldPassword
            // 
            this.tb_oldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_oldPassword.Location = new System.Drawing.Point(293, 55);
            this.tb_oldPassword.Name = "tb_oldPassword";
            this.tb_oldPassword.Size = new System.Drawing.Size(353, 39);
            this.tb_oldPassword.TabIndex = 3;
            this.tb_oldPassword.UseSystemPasswordChar = true;
            // 
            // tb_confirmNewPassword
            // 
            this.tb_confirmNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_confirmNewPassword.Location = new System.Drawing.Point(293, 211);
            this.tb_confirmNewPassword.Name = "tb_confirmNewPassword";
            this.tb_confirmNewPassword.Size = new System.Drawing.Size(353, 39);
            this.tb_confirmNewPassword.TabIndex = 4;
            this.tb_confirmNewPassword.UseSystemPasswordChar = true;
            // 
            // tb_newPassword
            // 
            this.tb_newPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_newPassword.Location = new System.Drawing.Point(293, 130);
            this.tb_newPassword.Name = "tb_newPassword";
            this.tb_newPassword.Size = new System.Drawing.Size(353, 39);
            this.tb_newPassword.TabIndex = 5;
            this.tb_newPassword.UseSystemPasswordChar = true;
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.LightBlue;
            this.btn_confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_confirm.Image = ((System.Drawing.Image)(resources.GetObject("btn_confirm.Image")));
            this.btn_confirm.Location = new System.Drawing.Point(82, 319);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(190, 77);
            this.btn_confirm.TabIndex = 9;
            this.btn_confirm.Text = "Xác nhận";
            this.btn_confirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_confirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.MistyRose;
            this.btn_thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.Image")));
            this.btn_thoat.Location = new System.Drawing.Point(485, 319);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(190, 77);
            this.btn_thoat.TabIndex = 10;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // fDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.tb_newPassword);
            this.Controls.Add(this.tb_confirmNewPassword);
            this.Controls.Add(this.tb_oldPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.fDoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_oldPassword;
        private System.Windows.Forms.TextBox tb_confirmNewPassword;
        private System.Windows.Forms.TextBox tb_newPassword;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_thoat;
    }
}