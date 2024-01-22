using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banhangtrangsuc.handle_logic
{
    public class Customer
    {
        public Customer(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Ten = row["ten"].ToString();
            this.Sodienthoai = row["sdt"].ToString();
        }

        public Customer()
        {
        }

        private int id;
        private string ten;
        private string sodienthoai;

        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Sodienthoai { get => sodienthoai; set => sodienthoai = value; }
    }
}
