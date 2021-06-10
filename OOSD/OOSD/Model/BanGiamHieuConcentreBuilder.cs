using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD.Model
{
    public class BanGiamHieuConcentreBuilder : BanGiamHieuBuilder
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
        private string chucVu;
        private string maBanGiamHieu;

        public BanGiamHieu build()
        {
            return new BanGiamHieu(diaChi, dienThoai, email, gioiTinh, maNguoiDung, matKhau, ngaySinh, tenDangNhap, tenNguoiDung, trangThai, chucVu, maBanGiamHieu);
        }

        public BanGiamHieuBuilder setdiaChi(string diachi)
        {
            this.diaChi = diachi;
            return this;
        }

        public BanGiamHieuBuilder setdienThoai(string dienthoai)
        {
            this.dienThoai = dienthoai;
            return this;
        }

        public BanGiamHieuBuilder setemail(string email)
        {
            this.email = email;
            return this;
        }

        public BanGiamHieuBuilder setgioitinh(string gioiTinh)
        {
            this.gioiTinh = gioiTinh;
            return this;
        }

        public BanGiamHieuBuilder setmanguoidung(string maNguoiDung)
        {
            this.maNguoiDung = maNguoiDung;
            return this;
        }

        public BanGiamHieuBuilder setmatkhau(string matKhau)
        {
            this.matKhau = matKhau;
            return this;
        }

        public BanGiamHieuBuilder setngaysinh(string ngaySinh)
        {
            this.ngaySinh = ngaySinh;
            return this;
        }

        public BanGiamHieuBuilder settendangnhap(string tenDangNhap)
        {
            this.tenDangNhap = tenDangNhap;
            return this;
        }

        public BanGiamHieuBuilder settenNguoiDung(string tenNguoiDung)
        {
            this.tenNguoiDung = tenNguoiDung;
            return this;
        }

        public BanGiamHieuBuilder settrangThai(string trangThai)
        {
            this.trangThai = trangThai;
            return this;
        }

        public BanGiamHieuBuilder setchucVu(string chucVu)
        {
            this.chucVu = chucVu;
            return this;
        }

        public BanGiamHieuBuilder setmaBanGiamHieu(string maBanGiamHieu)
        {
            this.maBanGiamHieu = maBanGiamHieu;
            return this;
        }
    }
}
