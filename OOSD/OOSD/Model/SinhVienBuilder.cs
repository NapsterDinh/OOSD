using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD.Model
{
    public interface SinhVienBuilder
    {
        SinhVienBuilder setdiaChi(string diachi);

        SinhVienBuilder setdienThoai(string dienthoai);

        SinhVienBuilder setemail(string email);

        SinhVienBuilder setgioitinh(string gioiTinh);

        SinhVienBuilder setmanguoidung(string maNguoiDung);

        SinhVienBuilder setmatkhau(string matKhau);

        SinhVienBuilder setngaysinh(string ngaySinh);

        SinhVienBuilder settendangnhap(string tenDangNhap);

        SinhVienBuilder settenNguoiDung(string tenNguoiDung);

        SinhVienBuilder settrangThai(string trangThai);

        SinhVienBuilder sethocLuc(string hocLuc);

        SinhVienBuilder setmaKhoaDaoTao(string maKhoaDaoTao);

        SinhVienBuilder setmaLop(string maLop);

        SinhVienBuilder setmaSinhVien(string maSinhVien);

        SinhVienBuilder setsoTCTL(int soTCTL);

        SinhVienBuilder setGPI(double GPI);

        SinhVien build();
    }
}
