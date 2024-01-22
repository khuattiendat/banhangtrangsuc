using banhangtrangsuc.handle_logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace banhangtrangsuc
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public string getUserName()
        {
            return tbName.Text;
        }
        private void login_btn_Click(object sender, EventArgs e)
        {
            string email = tbName.Text;
            string password = tbPassword.Text;
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("vui lòng nhập đầu đủ thông tin!!");
                return;
            }
            else
            {

                if (AccountController.Instance.Login(email, password))
                {
                    Account loginAccount = AccountController.Instance.GetAccountByUserName(email);
                    MessageBox.Show("Đăng nhập hệ thống thành công!");
                    Client f = new Client(loginAccount);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("email hoặc mật khẩu không đúng!");
                }
            }

        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            Register f = new Register();
            this.Hide();
            f.ShowDialog();

        }
    }
}
