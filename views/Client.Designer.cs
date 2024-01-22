namespace banhangtrangsuc
{
    partial class Client
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgrv_listSp = new System.Windows.Forms.DataGridView();
            this.Tên = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_themgiohang = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aDMINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKýTàiKhoảnChoKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_tongtien = new System.Windows.Forms.TextBox();
            this.btn_thanhtoan = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewgiohang = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.cbcategory = new System.Windows.Forms.ComboBox();
            this.tb_soluong = new System.Windows.Forms.NumericUpDown();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_discount = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgrv_khachhang = new System.Windows.Forms.DataGridView();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.search_kh = new System.Windows.Forms.Button();
            this.tb_gia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_xoagiohang = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv_listSp)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_soluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_discount)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv_khachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgrv_listSp);
            this.groupBox1.Location = new System.Drawing.Point(22, 348);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1034, 331);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm";
            // 
            // dtgrv_listSp
            // 
            this.dtgrv_listSp.AllowUserToAddRows = false;
            this.dtgrv_listSp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrv_listSp.Location = new System.Drawing.Point(6, 23);
            this.dtgrv_listSp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgrv_listSp.Name = "dtgrv_listSp";
            this.dtgrv_listSp.ReadOnly = true;
            this.dtgrv_listSp.RowHeadersWidth = 62;
            this.dtgrv_listSp.RowTemplate.Height = 28;
            this.dtgrv_listSp.Size = new System.Drawing.Size(1022, 303);
            this.dtgrv_listSp.TabIndex = 0;
            // 
            // Tên
            // 
            this.Tên.AutoSize = true;
            this.Tên.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tên.Location = new System.Drawing.Point(1250, 322);
            this.Tên.Name = "Tên";
            this.Tên.Size = new System.Drawing.Size(92, 27);
            this.Tên.TabIndex = 2;
            this.Tên.Text = "Tên SP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1245, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Loại SP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1250, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số lượng";
            // 
            // btn_themgiohang
            // 
            this.btn_themgiohang.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_themgiohang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_themgiohang.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themgiohang.Location = new System.Drawing.Point(1126, 548);
            this.btn_themgiohang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_themgiohang.Name = "btn_themgiohang";
            this.btn_themgiohang.Size = new System.Drawing.Size(250, 72);
            this.btn_themgiohang.TabIndex = 8;
            this.btn_themgiohang.Text = "Thêm vào giỏ hàng";
            this.btn_themgiohang.UseVisualStyleBackColor = false;
            this.btn_themgiohang.Click += new System.EventHandler(this.btn_themgiohang_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDMINToolStripMenuItem,
            this.nhânViênToolStripMenuItem,
            this.đăngKýTàiKhoảnChoKháchHàngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1284, 35);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // aDMINToolStripMenuItem
            // 
            this.aDMINToolStripMenuItem.Name = "aDMINToolStripMenuItem";
            this.aDMINToolStripMenuItem.Size = new System.Drawing.Size(102, 31);
            this.aDMINToolStripMenuItem.Text = "ADMIN";
            this.aDMINToolStripMenuItem.Click += new System.EventHandler(this.aDMINToolStripMenuItem_Click);
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem});
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(143, 31);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên:";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // đăngKýTàiKhoảnChoKháchHàngToolStripMenuItem
            // 
            this.đăngKýTàiKhoảnChoKháchHàngToolStripMenuItem.Name = "đăngKýTàiKhoảnChoKháchHàngToolStripMenuItem";
            this.đăngKýTàiKhoảnChoKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(402, 31);
            this.đăngKýTàiKhoảnChoKháchHàngToolStripMenuItem.Text = "Đăng ký tài khoản cho khách hàng";
            this.đăngKýTàiKhoảnChoKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.đăngKýTàiKhoảnChoKháchHàngToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1264, 685);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 27);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tổng tiền";
            // 
            // tb_tongtien
            // 
            this.tb_tongtien.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tongtien.Location = new System.Drawing.Point(1448, 682);
            this.tb_tongtien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_tongtien.MaxLength = 999999999;
            this.tb_tongtien.Name = "tb_tongtien";
            this.tb_tongtien.ReadOnly = true;
            this.tb_tongtien.Size = new System.Drawing.Size(278, 35);
            this.tb_tongtien.TabIndex = 15;
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_thanhtoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_thanhtoan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thanhtoan.Location = new System.Drawing.Point(1492, 834);
            this.btn_thanhtoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(214, 92);
            this.btn_thanhtoan.TabIndex = 16;
            this.btn_thanhtoan.Text = "Thanh Toán";
            this.btn_thanhtoan.UseVisualStyleBackColor = false;
            this.btn_thanhtoan.Click += new System.EventHandler(this.btn_thanhtoan_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewgiohang);
            this.groupBox2.Location = new System.Drawing.Point(22, 698);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1035, 262);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm đã thêm vào giỏ hàng";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // listViewgiohang
            // 
            this.listViewgiohang.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listViewgiohang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewgiohang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewgiohang.FullRowSelect = true;
            this.listViewgiohang.GridLines = true;
            this.listViewgiohang.HideSelection = false;
            this.listViewgiohang.Location = new System.Drawing.Point(8, 31);
            this.listViewgiohang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewgiohang.Name = "listViewgiohang";
            this.listViewgiohang.Size = new System.Drawing.Size(1021, 227);
            this.listViewgiohang.TabIndex = 99;
            this.listViewgiohang.UseCompatibleStateImageBehavior = false;
            this.listViewgiohang.View = System.Windows.Forms.View.Details;
            this.listViewgiohang.SelectedIndexChanged += new System.EventHandler(this.listViewgiohang_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "idsp";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên sản phẩm";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn giá";
            this.columnHeader4.Width = 250;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Thành tiền";
            this.columnHeader5.Width = 250;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1200, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 27);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tên khách hàng";
            // 
            // cbProduct
            // 
            this.cbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(1432, 318);
            this.cbProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(278, 35);
            this.cbProduct.TabIndex = 22;
            this.cbProduct.SelectedIndexChanged += new System.EventHandler(this.cbProduct_SelectedIndexChanged);
            // 
            // cbcategory
            // 
            this.cbcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcategory.FormattingEnabled = true;
            this.cbcategory.Location = new System.Drawing.Point(1430, 248);
            this.cbcategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbcategory.Name = "cbcategory";
            this.cbcategory.Size = new System.Drawing.Size(278, 35);
            this.cbcategory.TabIndex = 23;
            this.cbcategory.SelectedIndexChanged += new System.EventHandler(this.cbcategory_SelectedIndexChanged);
            // 
            // tb_soluong
            // 
            this.tb_soluong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_soluong.Location = new System.Drawing.Point(1432, 460);
            this.tb_soluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_soluong.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tb_soluong.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.tb_soluong.Name = "tb_soluong";
            this.tb_soluong.Size = new System.Drawing.Size(278, 35);
            this.tb_soluong.TabIndex = 24;
            this.tb_soluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbCustomer
            // 
            this.cbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(1432, 162);
            this.cbCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(278, 35);
            this.cbCustomer.TabIndex = 25;
            this.cbCustomer.SelectedIndexChanged += new System.EventHandler(this.cbCustomer_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1264, 762);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 27);
            this.label5.TabIndex = 26;
            this.label5.Text = "Giảm giá (%)";
            // 
            // tb_discount
            // 
            this.tb_discount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_discount.Location = new System.Drawing.Point(1448, 752);
            this.tb_discount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_discount.Name = "tb_discount";
            this.tb_discount.Size = new System.Drawing.Size(278, 35);
            this.tb_discount.TabIndex = 27;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgrv_khachhang);
            this.groupBox3.Location = new System.Drawing.Point(22, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1035, 265);
            this.groupBox3.TabIndex = 100;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách khách hàng";
            // 
            // dtgrv_khachhang
            // 
            this.dtgrv_khachhang.AllowUserToAddRows = false;
            this.dtgrv_khachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrv_khachhang.Location = new System.Drawing.Point(8, 25);
            this.dtgrv_khachhang.Name = "dtgrv_khachhang";
            this.dtgrv_khachhang.ReadOnly = true;
            this.dtgrv_khachhang.RowHeadersWidth = 62;
            this.dtgrv_khachhang.RowTemplate.Height = 28;
            this.dtgrv_khachhang.Size = new System.Drawing.Size(1022, 235);
            this.dtgrv_khachhang.TabIndex = 0;
            this.dtgrv_khachhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrv_khachhang_CellContentClick);
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(1252, 75);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(224, 35);
            this.tb_search.TabIndex = 102;
            // 
            // search_kh
            // 
            this.search_kh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_kh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_kh.Location = new System.Drawing.Point(1510, 63);
            this.search_kh.Name = "search_kh";
            this.search_kh.Size = new System.Drawing.Size(200, 58);
            this.search_kh.TabIndex = 103;
            this.search_kh.Text = "Tìm Khách hàng";
            this.search_kh.UseVisualStyleBackColor = true;
            this.search_kh.Click += new System.EventHandler(this.search_kh_Click);
            // 
            // tb_gia
            // 
            this.tb_gia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_gia.Location = new System.Drawing.Point(1432, 388);
            this.tb_gia.Name = "tb_gia";
            this.tb_gia.ReadOnly = true;
            this.tb_gia.Size = new System.Drawing.Size(278, 35);
            this.tb_gia.TabIndex = 104;
            this.tb_gia.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1250, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 27);
            this.label6.TabIndex = 105;
            this.label6.Text = "Đơn giá";
            // 
            // btn_xoagiohang
            // 
            this.btn_xoagiohang.BackColor = System.Drawing.Color.LightCoral;
            this.btn_xoagiohang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xoagiohang.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoagiohang.Location = new System.Drawing.Point(1430, 548);
            this.btn_xoagiohang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoagiohang.Name = "btn_xoagiohang";
            this.btn_xoagiohang.Size = new System.Drawing.Size(344, 72);
            this.btn_xoagiohang.TabIndex = 106;
            this.btn_xoagiohang.Text = "xóa sản phẩm trong giỏ hàng";
            this.btn_xoagiohang.UseVisualStyleBackColor = false;
            this.btn_xoagiohang.Click += new System.EventHandler(this.btn_xoagiohang_Click);
            // 
            // fquanlycuahang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 702);
            this.Controls.Add(this.btn_xoagiohang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_gia);
            this.Controls.Add(this.search_kh);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tb_discount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.tb_soluong);
            this.Controls.Add(this.cbcategory);
            this.Controls.Add(this.cbProduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_thanhtoan);
            this.Controls.Add(this.tb_tongtien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_themgiohang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tên);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fquanlycuahang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Quản lý của hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fquanlycuahang_Load_2);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv_listSp)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tb_soluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_discount)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv_khachhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgrv_listSp;
        private System.Windows.Forms.Label Tên;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_themgiohang;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aDMINToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_tongtien;
        private System.Windows.Forms.Button btn_thanhtoan;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ListView listViewgiohang;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.ComboBox cbcategory;
        private System.Windows.Forms.NumericUpDown tb_soluong;
        private System.Windows.Forms.ToolStripMenuItem đăngKýTàiKhoảnChoKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown tb_discount;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgrv_khachhang;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button search_kh;
        private System.Windows.Forms.TextBox tb_gia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_xoagiohang;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
    }
}