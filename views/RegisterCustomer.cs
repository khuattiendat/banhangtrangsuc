using banhangtrangsuc.handle_logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace banhangtrangsuc
{
    public partial class RegisterCustomer : Form
    {
        public Account loginAccount;
        public RegisterCustomer()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string phone = tbPhone.Text;
            var checknumber = @"^0[0-9]{9}$";
            Regex regexNumber = new Regex(checknumber);
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("hãy nhập đầy đủ thông tin !!!");
                return;
            }
            if (!regexNumber.IsMatch(phone))
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                return;
            }
            if (CustomerController.Instance.insertCustomer(name, phone))
            {
                MessageBox.Show("Đăng ký tài khoản thành công");
                Client f = new Client(loginAccount);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Đăng ký tài khoản không thành công");
            }
        }

        private void fDangkytaikhoankhachhang_Load(object sender, EventArgs e)
        {

        }
    }
}
