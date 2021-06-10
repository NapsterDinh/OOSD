using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD.Model
{
    public interface GiangVienBuilder
    {
        GiangVienBuilder setdiaChi(string diachi);

        GiangVienBuilder setdienThoai(string dienthoai);

        GiangVienBuilder setemail(string email);

        GiangVienBuilder setgioitinh(string gioiTinh);

        GiangVienBuilder setmanguoidung(string maNguoiDung);

        GiangVienBuilder setmatkhau(string matKhau);

        GiangVienBuilder setngaysinh(string ngaySinh);

        GiangVienBuilder settendangnhap(string tenDangNhap);

        GiangVienBuilder settenNguoiDung(string tenNguoiDung);

        GiangVienBuilder settrangThai(string trangThai);

        GiangVienBuilder setloaiGiaoVien(string loaiGiaoVien);

        GiangVienBuilder setmaGiaoVien(string maGiaoVien);

        GiangVien build();
    }
}
