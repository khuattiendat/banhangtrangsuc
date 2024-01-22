using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banhangtrangsuc.handle_logic
{
    public class BillInfoController
    {
        private static BillInfoController instance;
        public static BillInfoController Instance
        {
            get { if (instance == null) instance = new BillInfoController(); return BillInfoController.instance; }
            private set { BillInfoController.instance = value; }
        }
        private BillInfoController() { }

        public void InsertBillInfo(int idBill, int idsp, int count)// thêm chi tiết hóa đơn
        {
            
            try
            {
                Connect.Instance.ExecuteNonQuery("USP_Themchitiethoadon @idhd , @idsp , @count",
                new object[] { idBill, idsp, count });
               
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                return;
            }
        }
        public void checkTotalBill(int idBill, int idsp, int count)
        {
            try
            {
                 Connect.Instance.ExecuteNonQuery("checkTotalProduct @idhd , @idsp, @count",
                 new object[] { idBill, idsp, count});
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                return;
            }
        }
        public void upDateBillinfo(int idBill, int idsp, int count, int idkh)
        {
            string query = "select * from chitiethoadon where idhd =" + idBill + "and idsp =" + idsp +"and idkh=" + idkh;
            DataTable data = Connect.Instance.ExecuteQuery(query);

            if(data.Rows.Count>0)
            {
                Connect.Instance.ExecuteQuery("update chitiethoadon set count=" + count +"where idsp=" + idsp);
            }
            
        }
        public void DeleteBillInfoByProductID(int id)// xóa món ăn trong hóa đơn
        {
            Connect.Instance.ExecuteQuery("Delete FROM dbo.chitiethoadon where idsp=" + id);
        }
        public void DeleteBillInfoByID(int id)// xóa món ăn trong hóa đơn
        {
            Connect.Instance.ExecuteQuery("Delete FROM dbo.chitiethoadon where id=" + id);
        }
        public void DeleteBillInfoByIDsp(int idhd, int idsp)// xóa món ăn trong hóa đơn
        {
            try
            {

                Connect.Instance.ExecuteQuery("delete from chitiethoadon where chitiethoadon.idhd =" + idhd + "and chitiethoadon.idsp ="+idsp);
                BillController.Instance.UpdateTotalincreaseProduct(idsp, idhd);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                return;
            }
        }
        public void DeleteBillInfoByCategoryID(int id)
        {
        // lấy ra id của chitiethoadon có idloaisp(sanpham)=id(loaisp) and idsp(chitiethoadon)=id(sanpham)
        string query = "select bill.id from dbo.sanpham as sp, dbo.chitiethoadon as bill where bill.idsp = sp.id and sp.idloaisp = " + id;
            DataTable data = Connect.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                BillInfo product = new BillInfo(item);
                DeleteBillInfoByID(product.Id);
            }
        }
    }
}
