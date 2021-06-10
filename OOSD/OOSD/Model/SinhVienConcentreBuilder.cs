using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD.Model
{
    public class SinhVienConcentreBuilder : SinhVienBuilder
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
        private string hocLuc;
        private string maKhoaDaoTao;
        private string maLop;
        private string maSinhVien;
        private int soTCTL;
        private double GPI;

        public SinhVien build()
        {
            return new SinhVien(diaChi, dienThoai, email, 
                gioiTinh, maNguoiDung, matKhau, ngaySinh, 
                tenDangNhap, tenNguoiDung, trangThai, 
                hocLuc, maKhoaDaoTao,
                maLop, maLop, soTCTL, GPI);
        }

        public SinhVienBuilder setdiaChi(string diachi)
        {
            this.diaChi = diachi;
            return this;
        }

        public SinhVienBuilder setdienThoai(string dienthoai)
        {
            this.dienThoai = dienthoai;
            return this;
        }

        public SinhVienBuilder setemail(string email)
        {
            this.email = email;
            return this;
        }

        public SinhVienBuilder setgioitinh(string gioiTinh)
        {
            this.gioiTinh = gioiTinh;
            return this;
        }

        
        public SinhVienBuilder setmanguoidung(string maNguoiDung)
        {
            this.maNguoiDung = maNguoiDung;
            return this;
        }


        public SinhVienBuilder setmatkhau(string matKhau)
        {
            this.matKhau = matKhau;
            return this;
        }

        public SinhVienBuilder setngaysinh(string ngaySinh)
        {
            this.ngaySinh = ngaySinh;
            return this;
        }

        public SinhVienBuilder settendangnhap(string tenDangNhap)
        {
            this.tenDangNhap = tenDangNhap;
            return this;
        }

        public SinhVienBuilder settenNguoiDung(string tenNguoiDung)
        {
            this.tenNguoiDung = tenNguoiDung;
            return this;
        }

        public SinhVienBuilder settrangThai(string trangThai)
        {
            this.trangThai = trangThai;
            return this;
        }

        public SinhVienBuilder setGPI(double GPI)
        {
            this.GPI = GPI;
            return this;
        }

        public SinhVienBuilder sethocLuc(string hocLuc)
        {
            this.hocLuc = hocLuc;
            return this;
        }

        public SinhVienBuilder setmaKhoaDaoTao(string maKhoaDaoTao)
        {
            this.maKhoaDaoTao = maKhoaDaoTao;
            return this;
        }

        public SinhVienBuilder setmaLop(string maLop)
        {
            this.maLop = maLop;
            return this;
        }
        public SinhVienBuilder setsoTCTL(int soTCTL)
        {
            this.soTCTL = soTCTL;
            return this;
        }

        public SinhVienBuilder setmaSinhVien(string maSinhVien)
        {
            this.maSinhVien = maSinhVien;
            return this;
        }
    }
}
