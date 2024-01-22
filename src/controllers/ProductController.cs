using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace banhangtrangsuc.handle_logic
{
    public class ProductController
    {
        private static ProductController instance;
        public static ProductController Instance
        {
            get { if (instance == null) instance = new ProductController(); return ProductController.instance; }
            private set { ProductController.instance = value; }
        }
        private ProductController() { }
        public DataTable GetListProduct()
        {
            List<Product> list = new List<Product>();

            string query = "select sp.id, sp.ten, sp.tonkho, sp.gia, lsp.tenloai from dbo.sanpham as sp, dbo.loaisp as lsp where sp.idloaisp = lsp.id";

            DataTable data = Connect.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Product sanpham = new Product(item);
                list.Add(sanpham);
            }

            return data;
        }
        public DataTable GetListProduct1()
        {
            List<Product> list = new List<Product>();

            string query = "select * from sanpham";

            DataTable data = Connect.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Product sanpham = new Product(item);
                list.Add(sanpham);
            }

            return data;
        }
        public List<Product> GetProductByCategoryID(int id)
        {
            List<Product> list = new List<Product>();

            string query = "select * from sanpham where idloaisp = " + id;

            DataTable data = Connect.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Product product = new Product(item);
                list.Add(product);
            }

            return list;
        }
        public Product GetProductByID(int id)
        {
            Product product = null;

            string query = "select * from sanpham where id = " + id;

            DataTable data = Connect.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                product = new Product(item);
                return product;
            }

            return product;
        }
        public bool checkInsertProduct(string name)
        {
            string query = string.Format("SELECT * FROM dbo.sanpham WHERE ten = N'{0}'", name);
            DataTable result = Connect.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public bool checkUpdateProduct(string name, int Id)
        {
            string query = string.Format("SELECT * FROM dbo.sanpham WHERE ten = N'{0}' AND id = {1}", name, Id);
            DataTable result = Connect.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public bool InsertProduct(string name, int soluong, int id, float price)
        {
            try
            {
                if (checkInsertProduct(name) == true)
                {
                    MessageBox.Show("Sản phẩm này đã có !!!");
                    return false;
                }
                string query = string.Format("INSERT dbo.sanpham ( ten, tonkho, idloaisp, gia )VALUES  ( N'{0}', {1}, {2}, {3})", name, soluong, id, price);
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
        public bool UpdateProduct(int idsp, string name, int idcategory, float price, int soluong)// sửa món ăn
        {
            try
            {
                if (checkUpdateProduct(name, idsp) == true)
                {
                    string query = string.Format("UPDATE dbo.sanpham SET idloaisp = {0}, gia = {1}, tonkho = {2} WHERE id = {3}", idcategory, price, soluong, idsp);
                    int result = Connect.Instance.ExecuteNonQuery(query);
                    return result > 0;
                }
                else
                {
                    if (checkInsertProduct(name) == true)
                    {
                        MessageBox.Show("Sản phẩm này đã có !!!");
                        return false;
                    }
                    string query = string.Format("UPDATE dbo.sanpham SET ten = N'{0}', idloaisp = {1}, gia = {2}, tonkho = {3} WHERE id = {4}", name, idcategory, price, soluong, idsp);
                    int result = Connect.Instance.ExecuteNonQuery(query);
                    return result > 0;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra !!!");
                MessageBox.Show(ex.Message);
                return false;
            }


        }
        public bool DeleteProduct(int id)
        {
            try
            {
                BillInfoController.Instance.DeleteBillInfoByProductID(id);
                string query = string.Format("Delete sanpham where id = {0}", id);
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
        public DataTable SearchProductByName(string name)
        {
            List<Product> list = new List<Product>();
            //select sp.id, sp.ten, sp.gia, lsp.tenloai from dbo.sanpham as sp, dbo.loaisp as lsp where sp.idloaisp = lsp.id
            string query = string.Format("select sp.id, sp.ten, sp.tonkho, sp.gia, lsp.tenloai from dbo.sanpham as sp, dbo.loaisp as lsp where sp.idloaisp = lsp.id and (dbo.fuConvertToUnsign1(ten) LIKE '%{0}%' OR dbo.fuConvertToUnsign1(gia) LIKE '%{0}%')", name);
            DataTable data = Connect.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Product product = new Product(item);
                list.Add(product);
            }
            return data;
        }
        public void DeleteProductbyCategory(int id)
        {
            Connect.Instance.ExecuteQuery("Delete FROM dbo.sanpham where idloaisp=" + id);
        }
        public int GetMaxIDProduct()
        {
            try
            {
                return (int)Connect.Instance.ExecuteScalar("SELECT MAX(id) FROM sanpham");
            }
            catch
            {
                return 1;
            }
        }
    }
}
