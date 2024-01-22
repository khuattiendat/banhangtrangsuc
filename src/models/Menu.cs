using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banhangtrangsuc.handle_logic
{
    public class Menu
    {
        public Menu(DataRow row)
        {  
            this.Idsp = (int)row["id"];
            this.Name = row["ten"].ToString();
            this.Tonkho = (int)row["tonkho"];
            this.Count = (int)row["count"];
            this.Price = Double.Parse(row["gia"].ToString());
            this.TotalPrice = Double.Parse(row["totalPrice"].ToString());
        }
        private int idsp;
        private int tonkho;
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        private double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        private double totalPrice;
        public double TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }

        public int Idsp { get => idsp; set => idsp = value; }
        public int Tonkho { get => tonkho; set => tonkho = value; }
    }
}

