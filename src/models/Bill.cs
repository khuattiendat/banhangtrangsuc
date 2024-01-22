using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banhangtrangsuc.handle_logic
{
    public class Bill
    {
        public Bill(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Trangthai = row["trangthai"].ToString();
            //this.Datecheckin = (DateTime?)row["dateCheckin"];

            var dateCheckOutTemp = row["ngaymua"];
            if (dateCheckOutTemp.ToString() != "")
                this.Ngaymua = (DateTime?)dateCheckOutTemp;
        }
        private int id;
        //private DateTime? datecheckin;
        private DateTime? ngaymua;
        private string trangthai;

        //public DateTime? Datecheckin { get => datecheckin; set => datecheckin = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
        public int Id { get => id; set => id = value; }
        public DateTime? Ngaymua { get => ngaymua; set => ngaymua = value; }
    }
}
