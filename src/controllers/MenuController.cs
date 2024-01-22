using System;
using banhangtrangsuc.handle_logic;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banhangtrangsuc.handle_logic
{
    public class MenuController 
    {
        private static MenuController instance;

        public static MenuController Instance
        {
            get { if (instance == null) instance = new MenuController(); return MenuController.instance; }
            private set { MenuController.instance = value; }
        }

        private MenuController() { }
        public List<Menu> GetListMenuByCustomer(int id) // nội dung của hóa đơn theo khach hang
        {
            List<Menu> listMenu = new List<Menu>();

            string query = "SELECT f.id, f.ten, f.tonkho, bi.count, f.gia, f.gia*bi.count AS totalPrice " +
                           "FROM dbo.chitiethoadon AS bi, dbo.hoadon AS b, dbo.sanpham AS f" +
                           " WHERE bi.idhd = b.id AND bi.idsp = f.id AND b.trangthai =0 AND b.idkh = " + id;
            DataTable data = Connect.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}
