using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banhangtrangsuc.handle_logic
{
    public class BillInfo
    {
        public BillInfo(int id, int idhd, int idsp, int soluong) {
            this.Id = id;
            this.Idhd = idhd;
            this.Idsp = idsp;
            this.Soluong = soluong;
        }
        public BillInfo(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Idhd = (int)row[idhd];
            this.Idsp = (int)row[idsp];
            this.Soluong = (int)row[soluong];
        }
        private int id;
        private int idhd;
        private int idsp;
        private int soluong;

        public int Id { get => id; set => id = value; }
        public int Idhd { get => idhd; set => idhd = value; }
        public int Idsp { get => idsp; set => idsp = value; }
        public int Soluong { get => soluong; set => soluong = value; }
    }
}
