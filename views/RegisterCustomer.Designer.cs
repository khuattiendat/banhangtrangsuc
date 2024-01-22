namespace banhangtrangsuc
{
    partial class RegisterCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterCustomer));
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.register_btn = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(52, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Số điện thoại";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(318, 88);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(390, 39);
            this.tbName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(34, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên khách hàng";
            // 
            // register_btn
            // 
            this.register_btn.BackColor = System.Drawing.Color.LightBlue;
            this.register_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_btn.Image = ((System.Drawing.Image)(resources.GetObject("register_btn.Image")));
            this.register_btn.Location = new System.Drawing.Point(117, 336);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(190, 77);
            this.register_btn.TabIndex = 8;
            this.register_btn.Text = "Đăng ký";
            this.register_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.register_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.MistyRose;
            this.btn_thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.Image")));
            this.btn_thoat.Location = new System.Drawing.Point(518, 336);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(190, 77);
            this.btn_thoat.TabIndex = 9;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(318, 229);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(390, 39);
            this.tbPhone.TabIndex = 10;
            // 
            // fDangkytaikhoankhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Name = "fDangkytaikhoankhachhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký tài khoản khách hàng";
            this.Load += new System.EventHandler(this.fDangkytaikhoankhachhang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.TextBox tbPhone;
    }
}