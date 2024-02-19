using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banhangtrangsuc.handle_logic
{
    public class CategoryController
    {
        private static CategoryController instance;

        public static CategoryController Instance
        {
            get { if (instance == null) instance = new CategoryController(); return CategoryController.instance; }
            private set { CategoryController.instance = value; }
        }
        public List<Category> GetListCategory()//danh sách danh mục sanpham
        {
            List<Category> list = new List<Category>();

            string query = "select * from loaisp";

            DataTable data = Connect.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }

            return list;
        }
        public Category GetCategoryByID(int id)// 
        {
            Category category = null;

            string query = "select * from loaisp where id = " + id;

            DataTable data = Connect.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                category = new Category(item);
                return category;
            }

            return category;
        }
        public bool checkUpdateCategory(string name, int Id)
        {
            string query = string.Format("SELECT * FROM dbo.loaisp WHERE tenloai = N'{0}' AND id != {1}", name, Id);
            DataTable result = Connect.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public bool checkInsertCategory(string name)
        {
            string query = string.Format("SELECT * FROM dbo.loaisp WHERE tenloai = N'{0}'", name);
            DataTable result = Connect.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;

        }
        public bool InsertCategory(string name)
        {
            try
            {
                if (checkInsertCategory(name) == true)
                {
                    MessageBox.Show("Loại sản phẩm này đã có !!!");
                    return false;
                }
                string query = string.Format("INSERT dbo.loaisp ( tenloai ) VALUES  ( N'{0}')", name);
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
        public bool UpdateCategory(int id, string name)// 
        {
            if (checkUpdateCategory(name, id))
            {
                MessageBox.Show("Loại sản phẩm này đã tồn tại !!!");
                return false;
            }
            string query = string.Format("UPDATE dbo.loaisp SET tenloai = N'{0}' WHERE id = {1}", name, id);
            int result = Connect.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteCategory(int id)
        {
            try
            {
                BillInfoController.Instance.DeleteBillInfoByCategoryID(id);
                ProductController.Instance.DeleteProductbyCategory(id);
                string query = string.Format("DELETE dbo.loaisp WHERE id = {0}", id);
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
