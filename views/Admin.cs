using banhangtrangsuc.handle_logic;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using DataTable = System.Data.DataTable;

namespace banhangtrangsuc
{
    public partial class Admin : Form
    {
        public Account loginAccount;
        BindingSource productList = new BindingSource();
        BindingSource categoryList = new BindingSource();
        BindingSource AccountList = new BindingSource();
        public Admin()
        {
            InitializeComponent();
            load();
        }
        void load()
        {
            dtgrv_sanpham.DataSource = productList;
            dtgrv_loaisp.DataSource = categoryList;
            dtgrv_taikhoan.DataSource = AccountList;
            LoadDateTimePickerBill();
            LoadListBillByDate(dt_admin_checkin.Value, dt_admin_checkout.Value);
            LoadListProduct();
            LoadListCatrgory();
            LoadAccount();
            AddProductBinding();
            AddCategoryBinding();
            AddAccountBinding();
            LoadCategoryIntoCombobox(tb_sp_loaisp);
        }
        void changelistviewBill()
        {
            dtgrv_doanhthu.Columns[0].Width = 200;
            dtgrv_doanhthu.Columns[1].Width = 180;
            dtgrv_doanhthu.Columns[2].Width = 150;
            dtgrv_doanhthu.Columns[3].Width = 180;
            dtgrv_doanhthu.Columns[3].DefaultCellStyle.Format = "#,0" + "  VND";
        }
        void changedtgrvListproduct()
        {
            dtgrv_sanpham.Columns[0].Width = 50;
            dtgrv_sanpham.Columns[1].Width = 180;
            dtgrv_sanpham.Columns[1].HeaderText = "Tên sản phẩm";
            dtgrv_sanpham.Columns[2].Width = 100;
            dtgrv_sanpham.Columns[2].HeaderText = "Còn lại";
            dtgrv_sanpham.Columns[3].Width = 100;
            dtgrv_sanpham.Columns[3].HeaderText = "Giá";
            dtgrv_sanpham.Columns[3].DefaultCellStyle.Format = "#,0" + "  VND";
            dtgrv_sanpham.Columns[4].Width = 90;
            dtgrv_sanpham.Columns[4].HeaderText = "Loại sản phẩm";
        }
        void changedtgrvListAccount()
        {
            dtgrv_taikhoan.Columns[0].Width = 50;
            dtgrv_taikhoan.Columns[1].Width = 150;
            dtgrv_taikhoan.Columns[1].HeaderText = "Tên Nhân Viên";
            dtgrv_taikhoan.Columns[2].Width = 100;
            dtgrv_taikhoan.Columns[2].HeaderText = "Số điện thoại";
            dtgrv_taikhoan.Columns[3].Width = 100;
            dtgrv_taikhoan.Columns[3].HeaderText = "Giới tính";
            dtgrv_taikhoan.Columns[4].Width = 100;
            dtgrv_taikhoan.Columns[4].HeaderText = "Ngày sinh";
            dtgrv_taikhoan.Columns[5].Width = 100;
            dtgrv_taikhoan.Columns[5].HeaderText = "Địa chỉ";
            dtgrv_taikhoan.Columns[6].Width = 200;
            dtgrv_taikhoan.Columns[6].HeaderText = "Email";
        }
        void changedtgrvListCategory()
        {
            dtgrv_loaisp.Columns[0].Width = 100;
            dtgrv_loaisp.Columns[1].Width = 400;
            dtgrv_loaisp.Columns[1].HeaderText = "Loại sản phẩm";
        }
        void AddProductBinding()
        {
            tb_sp_idsp.DataBindings.Add(new Binding("Text", dtgrv_sanpham.DataSource, "id", true, DataSourceUpdateMode.Never));
            tb_sp_tensp.DataBindings.Add(new Binding("Text", dtgrv_sanpham.DataSource, "ten", true, DataSourceUpdateMode.Never));
            tb_sp_soluong.DataBindings.Add(new Binding("Text", dtgrv_sanpham.DataSource, "tonkho", true, DataSourceUpdateMode.Never));
            tb_sp_gia.DataBindings.Add(new Binding("Text", dtgrv_sanpham.DataSource, "gia", true, DataSourceUpdateMode.Never));
            tb_sp_loaisp.DataBindings.Add(new Binding("Text", dtgrv_sanpham.DataSource, "tenloai", true, DataSourceUpdateMode.Never));
        }
        void AddAccountBinding()
        {
            tb_taikhoan_id.DataBindings.Add(new Binding("Text", dtgrv_taikhoan.DataSource, "id", true, DataSourceUpdateMode.Never));
            tb_taikhoan_ten.DataBindings.Add(new Binding("Text", dtgrv_taikhoan.DataSource, "ten", true, DataSourceUpdateMode.Never));
            tb_taikhoan_sdt.DataBindings.Add(new Binding("Text", dtgrv_taikhoan.DataSource, "sdt", true, DataSourceUpdateMode.Never));
            tb_taikhoan_gioitinh.DataBindings.Add(new Binding("Text", dtgrv_taikhoan.DataSource, "gioitinh", true, DataSourceUpdateMode.Never));
            tb_taikhoan_ngaysinh.DataBindings.Add(new Binding("Text", dtgrv_taikhoan.DataSource, "ngaysinh", true, DataSourceUpdateMode.Never));
            tb_taikhoan_diachi.DataBindings.Add(new Binding("Text", dtgrv_taikhoan.DataSource, "diachi", true, DataSourceUpdateMode.Never));
            tb_taikhoan_email.DataBindings.Add(new Binding("Text", dtgrv_taikhoan.DataSource, "email", true, DataSourceUpdateMode.Never));
            // tb_taikhoan_mk.DataBindings.Add(new Binding("Text", dtgrv_taikhoan.DataSource, "matkhau", true, DataSourceUpdateMode.Never));
        }
        void AddCategoryBinding()
        {
            tb_loaisp_idloai.DataBindings.Add(new Binding("Text", dtgrv_loaisp.DataSource, "id", true, DataSourceUpdateMode.Never));
            tb_loaisp_ten.DataBindings.Add(new Binding("Text", dtgrv_loaisp.DataSource, "tenloai", true, DataSourceUpdateMode.Never));
        }
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dt_admin_checkin.Value = new DateTime(today.Year, today.Month, 1);
            dt_admin_checkout.Value = dt_admin_checkin.Value.AddMonths(1).AddDays(-1);
        }
        void LoadListProduct()
        {
            productList.DataSource = ProductController.Instance.GetListProduct();
        }
        void LoadListCatrgory()
        {
            categoryList.DataSource = CategoryController.Instance.GetListCategory();
        }
        void LoadAccount()
        {
            AccountList.DataSource = AccountController.Instance.GetListAccount();
        }
        void LoadListBillByDate(DateTime tungay, DateTime denngay)
        {
            dtgrv_doanhthu.DataSource = BillController.Instance.GetBillListByDate(tungay, denngay);
        }
        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryController.Instance.GetListCategory();
            cb.DisplayMember = "tenloai";
        }
        private void btn_thongke_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dt_admin_checkin.Value, dt_admin_checkout.Value);
        }
        private void fAdmin_Load_1(object sender, EventArgs e)
        {
            changelistviewBill();
            changedtgrvListproduct();
            changedtgrvListCategory();
            changedtgrvListAccount();
        }
        // xuat file excel
        private void ToExcel(DataGridView dtgrv_doanhthu, string fileName)
        {
            //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                //Tạo đối tượng COM.
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //tạo mới một Workbooks bằng phương thức add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //đặt tên cho sheet
                worksheet.Name = "Quản lý bán hàng trang sức";

                // export header trong DataGridView
                for (int i = 0; i < dtgrv_doanhthu.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dtgrv_doanhthu.Columns[i].HeaderText;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dtgrv_doanhthu.RowCount; i++)
                {
                    for (int j = 0; j < dtgrv_doanhthu.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dtgrv_doanhthu.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(fileName);
                //đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }
        private void btn_exportExcell_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                ToExcel(dtgrv_doanhthu, savefile.FileName);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void tb_sp_idsp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgrv_sanpham.SelectedCells.Count > 0)
                {
                    int id = (int)dtgrv_sanpham.SelectedCells[0].OwningRow.Cells["idloaisp"].Value;

                    Category loaisp = CategoryController.Instance.GetCategoryByID(id);

                    tb_sp_loaisp.SelectedItem = loaisp;

                    int index = -1;
                    int i = 0;
                    foreach (Category item in tb_sp_loaisp.Items)
                    {
                        if (item.ID == loaisp.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }

                    tb_sp_loaisp.SelectedIndex = index;
                }
            }
            catch { }
        }
        private event EventHandler insertProduct;
        public event EventHandler InsertProduct
        {
            add { insertProduct += value; }
            remove { insertProduct -= value; }
        }
        private event EventHandler updateProduct;
        public event EventHandler UpdateProduct
        {
            add { updateProduct += value; }
            remove { updateProduct -= value; }
        }
        private event EventHandler deleteProduct;
        public event EventHandler DeleteProduct
        {
            add { deleteProduct += value; }
            remove { deleteProduct -= value; }
        }
        // category
        private event EventHandler insertCategory;
        public event EventHandler InsertCategory
        {
            add { insertCategory += value; }
            remove { insertCategory -= value; }
        }
        private event EventHandler updateCategory;
        public event EventHandler UpdateCategory
        {
            add { updateCategory += value; }
            remove { updateCategory -= value; }
        }
        private event EventHandler deleteCategory;
        public event EventHandler DeleteCategory
        {
            add { deleteCategory += value; }
            remove { deleteCategory -= value; }
        }
        public bool validateTextBox()
        {
            if (string.IsNullOrEmpty(tb_sp_loaisp.Text) || string.IsNullOrEmpty(tb_sp_tensp.Text))
            {
                return true;
            }
            return false;
        }
        private void btn_sp_add_Click(object sender, EventArgs e)
        {
            string name = tb_sp_tensp.Text;
            int number = int.Parse(tb_sp_soluong.Text);
            int categoryID = (tb_sp_loaisp.SelectedItem as Category).ID;
            float price = (float)tb_sp_gia.Value;
            if (string.IsNullOrEmpty(tb_sp_loaisp.Text) || string.IsNullOrEmpty(tb_sp_tensp.Text))
            {
                MessageBox.Show("hãy nhập đầy đủ thông tin !!!");
                return;
            }
            if (tb_sp_soluong.Value < 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0");
                return;
            }
            if (tb_sp_gia.Value < 0)
            {
                MessageBox.Show("Giá phải lớn hơn 0");
                return;
            }

            if (ProductController.Instance.InsertProduct(name, number, categoryID, price))
            {
                MessageBox.Show("Thêm sản phẩm thành công");
                LoadListProduct();
                if (insertProduct != null)
                { insertProduct(this, new EventArgs()); }

            }
        }

        private void fAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btn_sp_edit_Click(object sender, EventArgs e)
        {
            string name = tb_sp_tensp.Text;
            int number = int.Parse(tb_sp_soluong.Text);
            int categoryID = (tb_sp_loaisp.SelectedItem as Category).ID;
            float price = (float)tb_sp_gia.Value;
            int id = Convert.ToInt32(tb_sp_idsp.Text);
            if (string.IsNullOrEmpty(tb_sp_loaisp.Text) || string.IsNullOrEmpty(tb_sp_tensp.Text))
            {
                MessageBox.Show("hãy nhập đầy đủ thông tin !!!");
                return;
            }
            if (tb_sp_soluong.Value < 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0");
                return;
            }
            if (tb_sp_gia.Value < 0)
            {
                MessageBox.Show("Giá phải lớn hơn 0");
                return;
            }
            if (ProductController.Instance.UpdateProduct(id, name, categoryID, price, number))
            {

                MessageBox.Show("Sửa sản phẩm thành công");
                LoadListProduct();
                if (updateProduct != null)
                    updateProduct(this, new EventArgs());
            }
        }

        private void btn_sp_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            int id = Convert.ToInt32(tb_sp_idsp.Text);

            if (ProductController.Instance.DeleteProduct(id))
            {
                MessageBox.Show("Xóa sản phẩm thành công");
                LoadListProduct();
                if (deleteProduct != null)
                    deleteProduct(this, new EventArgs());
            }
        }

        private void btn_sp_view_Click(object sender, EventArgs e)
        {
            LoadListProduct();
        }


        private void btn_sp_timkiem_Click(object sender, EventArgs e)
        {
            DataTable data = ProductController.Instance.SearchProductByName(tb_sp_timkiem.Text.Trim());

            if (data.Rows.Count > 0)
            {
                productList.DataSource = data;
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả !!!");
                LoadListProduct();
            }
        }

        private void btn_loaisp_add_Click(object sender, EventArgs e)
        {
            string name = tb_loaisp_ten.Text;
            if (CategoryController.Instance.InsertCategory(name))
            {
                MessageBox.Show("Thêm loại sản phẩm thành công");
                LoadListCatrgory();
                LoadListProduct();
                LoadCategoryIntoCombobox(tb_sp_loaisp);
                if (insertCategory != null)
                { insertCategory(this, new EventArgs()); }
            }
        }

        private void btn_loaisp_edit_Click(object sender, EventArgs e)
        {

            string name = tb_loaisp_ten.Text;
            int id = Convert.ToInt32(tb_loaisp_idloai.Text);

            if (CategoryController.Instance.UpdateCategory(id, name))
            {
                MessageBox.Show("Sửa loại sản phẩm thành công");
                LoadListCatrgory();
                LoadListProduct();
                LoadCategoryIntoCombobox(tb_sp_loaisp);
                if (updateCategory != null)
                    updateCategory(this, new EventArgs());
            }

        }

        private void btn_loaisp_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa loại sản phẩm này không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            int id = Convert.ToInt32(tb_loaisp_idloai.Text);

            if (CategoryController.Instance.DeleteCategory(id))
            {
                MessageBox.Show("Xóa loại sản phẩm thành công");
                LoadListCatrgory();
                LoadListProduct();
                LoadCategoryIntoCombobox(tb_sp_loaisp);
                if (deleteCategory != null)
                    deleteCategory(this, new EventArgs());
            }
        }
        private void btn_loaisp_view_Click(object sender, EventArgs e)
        {
            LoadListCatrgory();
        }

        void AddAccount(string name, string phone, DateTime ngaysinh, string gender, string email, string address, string password)
        {
            if (AccountController.Instance.InsertAccount(name, phone, ngaysinh, gender, email, address, password))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }

            LoadAccount();
        }
        void UpdateAccount(int id, string name, string phone, DateTime ngaysinh, string gender, string email, string address)
        {
            if (AccountController.Instance.UpdateAccount(id, name, phone, ngaysinh, gender, email, address))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }
            LoadAccount();
        }
        void DeleteAccount(int id, string userName)
        {
            if (loginAccount.Ten.Equals(userName))
            {
                MessageBox.Show("Không thể xóa tài khoản đang đăng nhập");
                return;
            }
            if (AccountController.Instance.DeleteAccount(id))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }

            LoadAccount();
        }
        private void btn_taikhoan_add_Click(object sender, EventArgs e)
        {

            string name = tb_taikhoan_ten.Text;
            string phone = tb_taikhoan_sdt.Text;
            DateTime ngaysinh = tb_taikhoan_ngaysinh.Value;
            string gender = tb_taikhoan_gioitinh.Text;
            string email = tb_taikhoan_email.Text;
            string address = tb_taikhoan_diachi.Text;
            string password = tb_taikhoan_mk.Text;
            var checknumber = @"^0[0-9]{9}$";
            Regex regexNumber = new Regex(checknumber);
            var checkEmail = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex regexEmail = new Regex(checkEmail);
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("vui lòng nhập đầy đủ các thông tin");
                return;
            }
            if (!regexNumber.IsMatch(phone))
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                return;
            }
            if (!regexEmail.IsMatch(email))
            {
                MessageBox.Show("Email không hợp lệ");
                return;
            }
            if ((((int)DateTime.Now.Year) - ((int)ngaysinh.Year)) < 1 || (((int)DateTime.Now.Year) - ((int)ngaysinh.Year)) > 100)
            {
                MessageBox.Show("Tuổi không hợp lệ");
                return;
            }
            AddAccount(name, phone, ngaysinh, gender, email, address, password);
        }

        private void btn_taikhoan_edit_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(tb_taikhoan_id.Text);
            string name = tb_taikhoan_ten.Text;
            string phone = tb_taikhoan_sdt.Text;
            DateTime ngaysinh = tb_taikhoan_ngaysinh.Value;
            string gender = tb_taikhoan_gioitinh.Text;
            string email = tb_taikhoan_email.Text;
            string address = tb_taikhoan_diachi.Text;
            var checknumber = @"^0[0-9]{9}$";
            Regex regexNumber = new Regex(checknumber);
            var checkEmail = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex regexEmail = new Regex(checkEmail);
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("vui lòng nhập đầy đủ các thông tin");
                return;
            }
            if (!regexNumber.IsMatch(phone))
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                return;
            }
            if (!regexEmail.IsMatch(email))
            {
                MessageBox.Show("Email không hợp lệ");
                return;
            }
            if ((((int)DateTime.Now.Year) - ((int)ngaysinh.Year)) < 1 || (((int)DateTime.Now.Year) - ((int)ngaysinh.Year)) > 100)
            {
                MessageBox.Show("Tuổi không hợp lệ");
                return;
            }
            UpdateAccount(id, name, phone, ngaysinh, gender, email, address);
            tb_taikhoan_mk.Text = "";

        }

        private void btn_taikhoan_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            int id = Int32.Parse(tb_taikhoan_id.Text);
            string userName = tb_taikhoan_ten.Text;
            DeleteAccount(id, userName);
        }

        private void btn_taikhoan_resetForm_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }
    }
}
