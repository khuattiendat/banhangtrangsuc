using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banhangtrangsuc.handle_logic
{
    public class Category
    {
        public Category(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Tenloai = row["tenloai"].ToString();
        }
        private int id;
        private string tenloai;

        public int ID { get => id; set => id = value; }
        public string Tenloai { get => tenloai; set => tenloai = value; }
    }
}
