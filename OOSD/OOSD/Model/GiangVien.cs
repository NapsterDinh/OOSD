using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD.Model
{
    public class GiangVien : NguoiDung
    {

        private string loaiGiaoVien;
        private string maGiaoVien;

        public GiangVien(string diaChi, string dienThoai, string email, string gioiTinh,
            string maNguoiDung, string matKhau, string ngaySinh, string tenDangNhap,
            string tenNguoiDung, string trangThai, string loaiGiaoVien, string maGiaoVien)
            : base(diaChi, dienThoai, email, gioiTinh, maNguoiDung, matKhau, ngaySinh, tenDangNhap, tenNguoiDung, trangThai)
        {
            this.loaiGiaoVien = loaiGiaoVien;
            this.maGiaoVien = maGiaoVien;
        }
        public GiangVien()
        {

        }

        ~GiangVien()
        {

        }

        public string LoaiGiaoVien { get => loaiGiaoVien; set => loaiGiaoVien = value; }
        public string MaGiaoVien { get => maGiaoVien; set => maGiaoVien = value; }

    }//end GiangVien
}
