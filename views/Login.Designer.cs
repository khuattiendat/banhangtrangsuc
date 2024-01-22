namespace banhangtrangsuc
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.register_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(54, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đăng Nhập";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(310, 81);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(390, 39);
            this.tbName.TabIndex = 1;
            this.tbName.Text = "khuattiendat2002@gmail.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(77, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật Khẩu";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbPassword.Location = new System.Drawing.Point(310, 189);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(390, 40);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.Text = "1";
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.LightBlue;
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.Image = ((System.Drawing.Image)(resources.GetObject("login_btn.Image")));
            this.login_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.login_btn.Location = new System.Drawing.Point(299, 325);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(202, 77);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "Đăng nhập";
            this.login_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.MistyRose;
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn.Image = ((System.Drawing.Image)(resources.GetObject("close_btn.Image")));
            this.close_btn.Location = new System.Drawing.Point(60, 325);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(186, 77);
            this.close_btn.TabIndex = 5;
            this.close_btn.Text = "Thoát";
            this.close_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.close_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // register_btn
            // 
            this.register_btn.BackColor = System.Drawing.Color.LightBlue;
            this.register_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_btn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_btn.Image = ((System.Drawing.Image)(resources.GetObject("register_btn.Image")));
            this.register_btn.Location = new System.Drawing.Point(561, 322);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(202, 77);
            this.register_btn.TabIndex = 6;
            this.register_btn.Text = "Đăng ký";
            this.register_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.register_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // fdangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Name = "fdangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button register_btn;
    }
}

