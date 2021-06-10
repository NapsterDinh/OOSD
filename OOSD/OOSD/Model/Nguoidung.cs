using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD.Model
{
    public class NguoiDung
    {
        private string diaChi;
        private string dienThoai;
        private string email;
        private string gioiTinh;
        private string maNguoiDung;
        private string matKhau;
        private string ngaySinh;
        private string tenDangNhap;
        private string tenNguoiDung;
        private string trangThai;

        public NguoiDung()
        {

        }

        public NguoiDung(string diaChi, string dienThoai, string email, string gioiTinh, 
            string maNguoiDung, string matKhau, string ngaySinh, string tenDangNhap, 
            string tenNguoiDung, string trangThai)
        {
            this.DiaChi = diaChi;
            this.DienThoai = dienThoai;
            this.Email = email;
            this.GioiTinh = gioiTinh;
            this.MaNguoiDung = maNguoiDung;
            this.MatKhau = matKhau;
            this.NgaySinh = ngaySinh;
            this.TenDangNhap = tenDangNhap;
            this.TenNguoiDung = tenNguoiDung;
            this.TrangThai = trangThai;
        }

        ~NguoiDung()
        {

        }

        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public string Email { get => email; set => email = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string MaNguoiDung { get => maNguoiDung; set => maNguoiDung = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string TenNguoiDung { get => tenNguoiDung; set => tenNguoiDung = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}
