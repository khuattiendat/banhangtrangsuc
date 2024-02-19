using System;
using banhangtrangsuc.handle_logic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Principal;
using System.Data.SqlClient;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace banhangtrangsuc.handle_logic
{
    public class AccountController
    {
        private static AccountController instance;

        public static AccountController Instance
        {
            get { if (instance == null) instance = new AccountController(); return instance; }
            private set { instance = value; }
        }

        private AccountController() { }
        public bool Login(string userName, string passWord)
        {
            string query = "DangNhap @email , @passWord";

            DataTable result = Connect.Instance.ExecuteQuery(query, new object[] { userName, passWord });

            return result.Rows.Count > 0;
        }
        public Account GetAccountByUserName(string userName)
        {
            DataTable data = Connect.Instance.ExecuteQuery("Select * from taikhoan where email = '" + userName + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }

            return null;
        }
        public bool CheckEmail(string email)
        {
            string query = string.Format("SELECT * FROM dbo.taikhoan WHERE email = N'{0}'", email);
            DataTable result = Connect.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public bool checkNumber(string number)
        {
            string query = string.Format("SELECT * FROM dbo.taikhoan WHERE sdt = N'{0}'", number);
            DataTable result = Connect.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public bool Register(string userName, string password, string number, string gender, string address, string email, DateTime ngaysinh)
        {
            try
            {
                if (checkEmail(email) == true)
                {
                    MessageBox.Show("Email đã tồn tại !!!");
                    return false;
                }
                if (checkNumber(number) == true)
                {
                    MessageBox.Show("Số điện thoại đã tồn tại !!!");
                    return false;
                }
                string query = string.Format("INSERT dbo.taikhoan ( ten, sdt, gioitinh, ngaysinh, diachi, email, matkhau )VALUES ( N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}')", userName, number, gender, ngaysinh, address, email, password);
                int result = Connect.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Đã có lỗi xảy ra !!!");
            }
            return false;
        }
        public DataTable GetListAccount()
        {
            return Connect.Instance.ExecuteQuery("SELECT tk.id, tk.ten, tk.sdt, tk.gioitinh, tk.ngaysinh, tk.diachi, tk.email FROM dbo.taikhoan as tk");
        }
        public bool checkUpdateEmailAccount(string email, int Id)
        {
            string query = string.Format("SELECT * FROM dbo.taikhoan WHERE email = N'{0}' AND id != {1}", email, Id);
            DataTable result = Connect.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public bool checkUpdatePhoneAccount(string phone, int Id)
        {
            string query = string.Format("SELECT * FROM dbo.taikhoan WHERE sdt = N'{0}' AND id != {1}", phone, Id);
            DataTable result = Connect.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public bool checkEmail(string email)
        {
            string query = string.Format("SELECT * FROM dbo.taikhoan WHERE  email = N'{0}'", email);
            DataTable result = Connect.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public bool checkPhone(string phone)
        {
            string query = string.Format("SELECT * FROM dbo.taikhoan WHERE  sdt = N'{0}'", phone);
            DataTable result = Connect.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public bool InsertAccount(string name, string phone, DateTime ngaysinh, string gender, string email, string address, string password)
        {
            try
            {
                if (checkEmail(email) == true)
                {
                    MessageBox.Show("Email đã tồn tại !!!");
                    return false;
                }
                if (checkPhone(phone) == true)
                {
                    MessageBox.Show("Số điện thoại đã tồn tại !!!");
                    return false;
                }
                string query = string.Format("INSERT dbo.taikhoan ( ten, sdt, ngaysinh, gioitinh, email, diachi, matkhau ) VALUES  ( N'{0}', N'{1}', N'{2}',N'{3}',N'{4}',N'{5}',N'{6}')", name, phone, ngaysinh, gender, email, address, password);
                int result = Connect.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra !!!");
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool UpdateAccount(int id, string name, string phone, DateTime ngaysinh, string gender, string email, string address)
        {
            try
            {
                if (checkUpdateEmailAccount(email, id))
                {
                    MessageBox.Show("Email này đã tồn tại !!!");
                    return false;
                }
                if (checkUpdatePhoneAccount(phone, id))
                {
                    MessageBox.Show("Số điện thoại này đã tồn tại !!!");
                    return false;
                }
                string query = string.Format("UPDATE dbo.taikhoan SET ten = N'{1}',ngaysinh = N'{2}',gioitinh = N'{3}' ,diachi = N'{4}', sdt = N'{5}', email = N'{6}' WHERE id = N'{0}'", id, name, ngaysinh, gender, address, phone, email);
                int result = Connect.Instance.ExecuteNonQuery(query);

                return result > 0;

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra !!!");
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool DeleteAccount(int id)
        {
            try
            {
                string query = string.Format("DELETE from taikhoan where id={0}", id);
                int result = Connect.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra !!!");
                MessageBox.Show(ex.Message);
                return false;
            }

        }
        public bool checkPassword(int id, string password)
        {
            string query = string.Format("SELECT * FROM dbo.taikhoan WHERE id = N'{0}' AND matkhau = N'{1}'", id, password);
            DataTable result = Connect.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public bool changePassword(int id, string oldPassword, string newPassword)
        {
            try
            {
                if (checkPassword(id, oldPassword) == false)
                {
                    MessageBox.Show("Mật khẩu cũ không đúng !!!");
                    return false;
                }
                string query = string.Format("UPDATE dbo.taikhoan SET matkhau = N'{1}' WHERE id = N'{0}'", id, newPassword);
                int result = Connect.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra !!!");
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
