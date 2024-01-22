using banhangtrangsuc.handle_logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banhangtrangsuc
{
    public partial class ChangePassword : Form
    {
        public Account loginAccount;
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            string oldPassword = tb_oldPassword.Text;
            string newPassword = tb_newPassword.Text;
            string confirmNewPassword = tb_confirmNewPassword.Text;
            int id = loginAccount.Id;
            if (string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmNewPassword))
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin !!!");
                return;
            }
            if (newPassword != confirmNewPassword)
            {
                MessageBox.Show("Mật khẩu mới không trùng khớp");
                return;
            }
            if (AccountController.Instance.changePassword(id, oldPassword, newPassword))
            {
                MessageBox.Show("Đổi mật khẩu thành công");
                Client f = new Client(loginAccount);
                this.Hide();
                f.ShowDialog();
                this.Show();

            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fDoiMatKhau_Load(object sender, EventArgs e)
        {

        }
    }
}
