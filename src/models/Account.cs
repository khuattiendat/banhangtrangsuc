using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banhangtrangsuc.handle_logic
{
    public class Account
    {
        public Account(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Ten = row["ten"].ToString();
            this.Sdt = row["sdt"].ToString();
            this.LoaiTK = (int)row["loaiTK"];
            this.Matkhau = row["matkhau"].ToString();
            this.Ngaysinh = (DateTime)row["ngaysinh"];
            this.Gioitinh = row["gioitinh"].ToString();
            this.Diachi = row["diachi"].ToString();
            this.Email = row["email"].ToString();
        }
        private int id;
        private int loaiTK;
        private string ten;
        private string matkhau;
        private string sdt;
        private string gioitinh;
        private DateTime ngaysinh;
        private string diachi;
        private string email;

        public int Id { get => id; set => id = value; }
        public int LoaiTK { get => loaiTK; set => loaiTK = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Email { get => email; set => email = value; }
    }
}
