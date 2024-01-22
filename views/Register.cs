using banhangtrangsuc.handle_logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace banhangtrangsuc
{
    public partial class Register : Form
    {

        public Register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string userName = tb_name.Text; ;
            string password = tb_password.Text;
            string number = tb_number.Text;
            string gender = cb_gender.Text;
            string address = tb_address.Text;
            string email = tb_email.Text;
            DateTime ngaysinh = DateTime.Parse(dt_date.Text);
            var checknumber = @"^0[0-9]{9}$";
            Regex regexNumber = new Regex(checknumber);
            var checkEmail = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex regexEmail = new Regex(checkEmail);

            //MessageBox.Show(DateTime.Now.Year.ToString(), ngaysinh.Year.ToString());


            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(number) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("vui lòng nhập đúng các thông tin");
                return;
            }
            if (!regexNumber.IsMatch(number))
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

            if (AccountController.Instance.Register(userName, password, number, gender, address, email, ngaysinh))
            {
                MessageBox.Show("Đăng ký tài khoản thành công");
                Login f = new Login();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }

        }
        private void tb_typeAcc_TextChanged(object sender, EventArgs e)
        {

        }

        private void fDangKy_Load_1(object sender, EventArgs e)
        {

        }

        private void fDangKy_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
