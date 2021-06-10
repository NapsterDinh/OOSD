using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD.Model
{
    public class GiangVienConcentreBuilder : GiangVienBuilder
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
        private string loaiGiaoVien;
        private string maGiaoVien;

        public GiangVien build()
        {
            return new GiangVien(diaChi, dienThoai, email, gioiTinh, maNguoiDung, matKhau, ngaySinh, tenDangNhap, tenNguoiDung, trangThai, loaiGiaoVien,maGiaoVien);
        }

        public GiangVienBuilder setdiaChi(string diachi)
        {
            this.diaChi = diachi;
            return this;
        }

        public GiangVienBuilder setdienThoai(string dienthoai)
        {
            this.dienThoai = dienthoai;
            return this;
        }

        public GiangVienBuilder setemail(string email)
        {
            this.email = email;
            return this;
        }

        public GiangVienBuilder setgioitinh(string gioiTinh)
        {
            this.gioiTinh = gioiTinh;
            return this;
        }

        public GiangVienBuilder setmanguoidung(string maNguoiDung)
        {
            this.maNguoiDung = maNguoiDung;
            return this;
        }

        public GiangVienBuilder setmatkhau(string matKhau)
        {
            this.matKhau = matKhau;
            return this;
        }

        public GiangVienBuilder setngaysinh(string ngaySinh)
        {
            this.ngaySinh = ngaySinh;
            return this;
        }

        public GiangVienBuilder settendangnhap(string tenDangNhap)
        {
            this.tenDangNhap = tenDangNhap;
            return this;
        }

        public GiangVienBuilder settenNguoiDung(string tenNguoiDung)
        {
            this.tenNguoiDung = tenNguoiDung;
            return this;
        }

        public GiangVienBuilder settrangThai(string trangThai)
        {
            this.trangThai = trangThai;
            return this;
        }

        public GiangVienBuilder setloaiGiaoVien(string loaiGiaoVien)
        {
            this.loaiGiaoVien = loaiGiaoVien;
            return this;
        }

        public GiangVienBuilder setmaGiaoVien(string maGiaoVien)
        {
            this.maGiaoVien = maGiaoVien;
            return this;
        }
    }
}
