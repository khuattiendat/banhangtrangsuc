using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banhangtrangsuc.handle_logic
{
    public class BillController
    {
        private static BillController instance;
        public static BillController Instance
        {
            get { if (instance == null) instance = new BillController(); return BillController.instance; }
            private set { BillController.instance = value; }
        }
        private BillController() { }
        public void InsertBill(int id) // thêm hóa đơn
        {
            Connect.Instance.ExecuteNonQuery("exec Themhoadon @idkh", new object[] { id });
        }

        public int GetMaxIDBill()
        {
            try
            {
                return (int)Connect.Instance.ExecuteScalar("SELECT MAX(id) FROM dbo.hoadon");
            }
            catch
            {
                return 1;
            }
        }
        public int GetUncheckBillIDByCustomerID(int id)// sắp xếp hóa đơn của bàn
        {
            DataTable data = Connect.Instance.ExecuteQuery("SELECT * FROM dbo.hoadon " +
                "WHERE idkh = " + id + " AND trangthai = 0");
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.Id;
            }
            return -1;
        }
        public void CheckOut(int id, int discount, float totalPrice)// thanh toán hóa đơn
        {
            string query = "UPDATE dbo.hoadon SET ngaymua = GETDATE(), trangthai = 1, "
                + "giamgia = " + discount + ", tonggia = " + totalPrice + " WHERE id = " + id;
            Connect.Instance.ExecuteNonQuery(query);
        }
        public DataTable GetBillListByDate(DateTime tungay, DateTime denngay)//Sắp xếp hóa đơn theo thời gian
        {
            return Connect.Instance.ExecuteQuery("exec Laydanhsachhoadontheongay @tungay , @denngay", new object[] { tungay, denngay });
        }
        public DataTable UpdateTotalProduct(int idsp, int idhd)
        {
            return Connect.Instance.ExecuteQuery("exec UpdateTotalProduct @idsp , @idhd", new object[] { idsp, idhd });
        }
        public DataTable UpdateTotalincreaseProduct(int idsp, int idhd)
        {
            return Connect.Instance.ExecuteQuery("exec UpdateTotalincreaseProduct @idsp , @idhd", new object[] { idsp, idhd });
        }
    }
    }
