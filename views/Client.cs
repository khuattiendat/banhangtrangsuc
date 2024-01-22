using System;
using banhangtrangsuc.handle_logic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;
using Microsoft.Office.Interop.Excel;
using System.Globalization;

namespace banhangtrangsuc
{
    public partial class Client : Form
    {
        BindingSource danhsachsanpham = new BindingSource();
        BindingSource danhsachkhachang = new BindingSource();
        public Client(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            dtgrv_listSp.DataSource = danhsachsanpham;
            dtgrv_khachhang.DataSource = danhsachkhachang;
            LoadListCustomer();
            loadDanhsachsanpham();
            LoadCategory();
            AddCustomerBinding();
            AddCategoryBinding();
            LoadCustomerCombox(cbCustomer);
        }

        public Client()
        {
        }
        void loadDanhsachsanpham()
        {
            danhsachsanpham.DataSource = ProductController.Instance.GetListProduct();
        }
        void LoadListCustomer()
        {
            danhsachkhachang.DataSource = CustomerController.Instance.GetListCustomer();
        }
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.LoaiTK); }
        }
        void ChangeAccount(int type)
        {
            aDMINToolStripMenuItem.Enabled = type == 1;
            nhânViênToolStripMenuItem.Text = "Tên nhân viên: " + LoginAccount.Ten.ToUpper() + "";
        }
        void changeDatagritview()
        {
            dtgrv_listSp.Columns[0].Width = 50;
            dtgrv_listSp.Columns[0].HeaderText = "id";
            dtgrv_listSp.Columns[1].Width = 200;
            dtgrv_listSp.Columns[1].HeaderText = "Tên sản phẩm";
            dtgrv_listSp.Columns[2].Width = 100;
            dtgrv_listSp.Columns[2].HeaderText = "Còn lại";
            dtgrv_listSp.Columns[3].Width = 120;
            dtgrv_listSp.Columns[3].HeaderText = "Giá";
            dtgrv_listSp.Columns[3].DefaultCellStyle.Format = "#,0" + "  VND";
            dtgrv_listSp.Columns[4].Width = 130;
            dtgrv_listSp.Columns[4].HeaderText = "loại sản phẩm";
        }
        void changeDatagritviewCustomer()
        {
            dtgrv_khachhang.Columns[0].Width = 50;
            dtgrv_khachhang.Columns[1].Width = 300;
            dtgrv_khachhang.Columns[1].HeaderText = "Tên khách hàng";
            dtgrv_khachhang.Columns[2].Width = 270;
            dtgrv_khachhang.Columns[2].HeaderText = "Số điện thoại";
        }
        void changeListViewgiohang()
        {
            listViewgiohang.Columns[0].Width = 80;
            listViewgiohang.Columns[1].Width = 250;
            listViewgiohang.Columns[2].Width = 100;
            listViewgiohang.Columns[3].Width = 150;
            listViewgiohang.Columns[4].Width = 200;
        }

        private void fquanlycuahang_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Login f = new Login();
            f.ShowDialog();
        }


        void ShowBill(int id)
        {
            changeListViewgiohang();
            listViewgiohang.Items.Clear();
            List<banhangtrangsuc.handle_logic.Menu> listBillInfo = MenuController.Instance.GetListMenuByCustomer(id);
            Double totalPrice = 0;
            foreach (handle_logic.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.Idsp.ToString());
                lsvItem.SubItems.Add(item.Name.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString("#,##0"));
                lsvItem.SubItems.Add(item.TotalPrice.ToString("#,##0"));
                totalPrice += item.TotalPrice;
                listViewgiohang.Items.Add(lsvItem);
            }
            //CultureInfo culture = new CultureInfo("vi-VN");

            tb_tongtien.Text = totalPrice.ToString("#,##0");

        }
        private void aDMINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin f = new Admin();
            f.loginAccount = LoginAccount;
            f.InsertProduct += f_InsertProduct;
            f.UpdateProduct += f_updateProduct;
            f.DeleteProduct += f_deleteProduct;
            //
            f.InsertCategory += f_InsertCategory;
            f.UpdateCategory += f_UpdateCategory;
            f.DeleteCategory += f_DeleteCategory;
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        void f_InsertProduct(object sender, EventArgs e)
        {
            loadDanhsachsanpham();
            LoadFoodListByCategoryID((cbcategory.SelectedItem as Category).ID);
            if (listViewgiohang.Tag != null)
                ShowBill((listViewgiohang.Tag as Customer).Id);
        }
        void f_InsertCategory(object sender, EventArgs e)
        {
            loadDanhsachsanpham();
            LoadCategory();
            if (listViewgiohang.Tag != null)
                ShowBill((listViewgiohang.Tag as Customer).Id);
        }
        void f_UpdateCategory(object sender, EventArgs e)
        {
            loadDanhsachsanpham();
            LoadCategory();
            if (listViewgiohang.Tag != null)
                ShowBill((listViewgiohang.Tag as Customer).Id);
        }
        void f_DeleteCategory(object sender, EventArgs e)
        {
            loadDanhsachsanpham();
            LoadCategory();
            if (listViewgiohang.Tag != null)
                ShowBill((listViewgiohang.Tag as Customer).Id);
        }
        void f_updateProduct(object sender, EventArgs e)
        {
            loadDanhsachsanpham();
            LoadFoodListByCategoryID((cbcategory.SelectedItem as Category).ID);
            if (listViewgiohang.Tag != null)
                ShowBill((listViewgiohang.Tag as Customer).Id);
        }
        void f_deleteProduct(object sender, EventArgs e)
        {
            loadDanhsachsanpham();
            LoadFoodListByCategoryID((cbcategory.SelectedItem as Category).ID);
            if (listViewgiohang.Tag != null)
                ShowBill((listViewgiohang.Tag as Customer).Id);
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }



        private void btn_themgiohang_Click(object sender, EventArgs e)
        {
            Customer customer = listViewgiohang.Tag as Customer;
            int productId = (cbProduct.SelectedItem as Product).Id;
            int count = (int)tb_soluong.Value;
            if (count <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0");
                return;
            }

            int idBill = BillController.Instance.GetUncheckBillIDByCustomerID(customer.Id);
            if (idBill == -1)
            {
                BillController.Instance.InsertBill(customer.Id);
                BillInfoController.Instance.InsertBillInfo(BillController.Instance.GetMaxIDBill(), productId, count);
                // QLChitiethoadon.Instance.checkTotalBill(QLhoadon.Instance.GetMaxIDBill(), productId);
            }
            else
            {
                BillInfoController.Instance.InsertBillInfo(idBill, productId, count);
                // QLChitiethoadon.Instance.checkTotalBill(idBill, productId);
            }
            ShowBill(customer.Id);
            tb_soluong.Value = 1;
            loadDanhsachsanpham();

        }
        private void btn_xoagiohang_Click(object sender, EventArgs e)
        {
            Customer customer = listViewgiohang.Tag as Customer;
            int idBill = BillController.Instance.GetUncheckBillIDByCustomerID(customer.Id);
            // int productId = (cbProduct.SelectedItem as getSanpham).Id;
            int productId1 = productId;
            if (listViewgiohang.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa");
                return;
            }
            if (productId1 == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa");
                return;
            }
            BillInfoController.Instance.DeleteBillInfoByIDsp(idBill, productId1);
            ShowBill(customer.Id);
            loadDanhsachsanpham();



        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            Customer customer = listViewgiohang.Tag as Customer;
            List<banhangtrangsuc.handle_logic.Menu> listBillInfo = MenuController.Instance.GetListMenuByCustomer(customer.Id);
            if (listBillInfo.Count == 0)
            {
                MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng!!!");
                return;
            }
            int idBill = BillController.Instance.GetUncheckBillIDByCustomerID(customer.Id);
            int discount = (int)tb_discount.Value;
            int productId = (cbProduct.SelectedItem as Product).Id;
            Double totalPrice = float.Parse(tb_tongtien.Text);
            Double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;

            if (idBill != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho khách hàng" +
                    "\n {0} (Tổng tiền {1}đ - giảm giá {2}%) => Tổng thanh toán: {3}đ  ", customer.Ten, double.Parse(totalPrice.ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat), discount, double.Parse(finalTotalPrice.ToString()).ToString("#,###", CultureInfo.GetCultureInfo("vi-VN").NumberFormat)), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillController.Instance.CheckOut(idBill, discount, (float)finalTotalPrice);
                    foreach (handle_logic.Menu item in listBillInfo)
                    {
                        int conlai = item.Tonkho - item.Count;
                        string query = "UPDATE sanpham SET tonkho= '" + conlai + "' where id = '" + item.Idsp + "'";
                        Connect.Instance.ExecuteQuery(query);
                    }
                    ShowBill(customer.Id);
                    loadDanhsachsanpham();
                    MessageBox.Show("Thanh toán thành công!");
                }
            }
            tb_soluong.Value = 1;
            tb_discount.Value = 0;
        }


        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f = new Login();
            f.ShowDialog();
            this.Show();
        }


        void f_UpdateFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbcategory.SelectedItem as Category).ID);
            if (dtgrv_listSp.Tag != null)
                ShowBill((dtgrv_listSp.Tag as Customer).Id);
        }


        void LoadCategory()
        {
            List<Category> listCategory = CategoryController.Instance.GetListCategory();
            cbcategory.DataSource = listCategory;
            cbcategory.DisplayMember = "tenloai";
        }


        void LoadFoodListByCategoryID(int id)
        {
            List<Product> listProduct = ProductController.Instance.GetProductByCategoryID(id);
            cbProduct.DataSource = listProduct;
            cbProduct.DisplayMember = "ten";
        }
        void loadPriceByProduct(int id)
        {
            Product sanpham = ProductController.Instance.GetProductByID(id);
            tb_gia.Text = sanpham.Gia.ToString("#,##0");
        }
        private void cbcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.ID;
            LoadFoodListByCategoryID(id);
        }
        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Product selected = cb.SelectedItem as Product;
            id = selected.Id;

            loadPriceByProduct(id);
        }

        private void đăngKýTàiKhoảnChoKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterCustomer f = new RegisterCustomer();
            f.loginAccount = LoginAccount;
            this.Hide();
            f.ShowDialog();
            this.Show();

        }
        void LoadCustomerCombox(ComboBox cb)
        {
            //List<getKhachhang> listCategory = QLkhachhang.Instance.GetListCustomer();
            cb.DataSource = CustomerController.Instance.GetListCustomer();
            cb.DisplayMember = "ten";
        }
        void AddCustomerBinding()
        {
            cbCustomer.DataBindings.Add(new Binding("Text", dtgrv_khachhang.DataSource, "ten", true, DataSourceUpdateMode.Never));
        }
        void AddCategoryBinding()
        {
            cbcategory.DataBindings.Add(new Binding("Text", dtgrv_listSp.DataSource, "tenloai", true, DataSourceUpdateMode.Never));
            cbProduct.DataBindings.Add(new Binding("Text", dtgrv_listSp.DataSource, "ten", true, DataSourceUpdateMode.Never));
            tb_gia.DataBindings.Add(new Binding("Text", dtgrv_listSp.DataSource, "gia", true, DataSourceUpdateMode.Never));
            tb_gia.DataBindings[0].FormattingEnabled = true;
            tb_gia.DataBindings[0].FormatString = "#,##0";
        }
        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
            {
                return;
            }

            Customer selected = cb.SelectedItem as Customer;
            id = selected.Id;
            ShowBill(id);
            listViewgiohang.Tag = selected;
        }



        private void fquanlycuahang_Load_2(object sender, EventArgs e)
        {
            changeDatagritviewCustomer();
            changeDatagritview();
            changeListViewgiohang();
        }

        public int productId = 0;
        private void listViewgiohang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewgiohang.SelectedItems.Count > 0)
            {
                string colunmVal1 = listViewgiohang.SelectedItems[0].SubItems[0].Text;
                productId = Int32.Parse(colunmVal1);
            }
        }
        private void search_kh_Click(object sender, EventArgs e)
        {
            List<Customer> test = CustomerController.Instance.SearchCustomerbyUsernameOrPhone(tb_search.Text.Trim());
            if (test.Count > 0)
            {
                danhsachkhachang.DataSource = test;
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả !!!");
                tb_search.Text = "";
                LoadListCustomer();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgrv_khachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword f = new ChangePassword();
            f.loginAccount = LoginAccount;
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
