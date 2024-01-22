using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banhangtrangsuc.handle_logic
{
    public class CustomerController
    {
        private static CustomerController instance;

        public static CustomerController Instance
        {
            get { if (instance == null) instance = new CustomerController(); return CustomerController.instance; }
            private set { CustomerController.instance = value; }
        }
        public DataTable GetListCustomer1()
        {
            return Connect.Instance.ExecuteQuery("select * from khachhang");
        }
        public List<Customer> GetListCustomer()//danh sách danh mục sanpham
        {
            List<Customer> list = new List<Customer>();

            string query = "select * from khachhang";

            DataTable data = Connect.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Customer customer = new Customer(item);
                list.Add(customer);
            }

            return list;
        }
        public bool insertCustomer(string userName, string phone)
        {
            string query = string.Format("INSERT dbo.khachhang (ten, sdt )VALUES ( N'{0}', N'{1}')", userName, phone);
            int result = Connect.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        //public bool checkSearch(string name)
        //{
        //    string query = string.Format("SELECT * FROM dbo.khachhang WHERE dbo.fuConvertToUnsign1(ten) LIKE '%{0}%' OR dbo.fuConvertToUnsign1(sdt) LIKE '%{0}%'", name);
        //    DataTable data = KetNoi.Instance.ExecuteQuery(query);
        //    return data.Rows.Count > 0;

        //}
        public List<Customer> SearchCustomerbyUsernameOrPhone(string value)//tìm khach hang
        {
            List<Customer> list = new List<Customer>();
            string query = string.Format("SELECT * FROM dbo.khachhang WHERE dbo.fuConvertToUnsign1(ten) LIKE '%{0}%' OR dbo.fuConvertToUnsign1(sdt) LIKE '%{0}%'", value);
            DataTable data = Connect.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Customer customer = new Customer(item);
                list.Add(customer);
            }

            return list;
        }

    }
}
