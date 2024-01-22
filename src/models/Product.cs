using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banhangtrangsuc.handle_logic
{
    public class Product
    {
        public Product(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Ten = row["ten"].ToString();
            this.Gia = (float)Convert.ToDouble(row["gia"].ToString());
           /// this.Idloaisp = (int)row["idloaisp"];
        }
        int id;
       //int idloaisp;
        string ten;
        float gia;

    //    public int Idloaisp { get => idloaisp; set => idloaisp = value; }
        public string Ten { get => ten; set => ten = value; }

        public float Gia { get => gia; set => gia = value; }
        public int Id { get => id; set => id = value; }
    }
}
