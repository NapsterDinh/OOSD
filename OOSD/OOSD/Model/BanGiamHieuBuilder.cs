using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD.Model
{
    public interface BanGiamHieuBuilder
    {
        BanGiamHieuBuilder setdiaChi(string diachi);

        BanGiamHieuBuilder setdienThoai(string dienthoai);

        BanGiamHieuBuilder setemail(string email);

        BanGiamHieuBuilder setgioitinh(string gioiTinh);

        BanGiamHieuBuilder setmanguoidung(string maNguoiDung);

        BanGiamHieuBuilder setmatkhau(string matKhau);

        BanGiamHieuBuilder setngaysinh(string ngaySinh);

        BanGiamHieuBuilder settendangnhap(string tenDangNhap);

        BanGiamHieuBuilder settenNguoiDung(string tenNguoiDung);

        BanGiamHieuBuilder settrangThai(string trangThai);

        BanGiamHieuBuilder setchucVu(string chucVu);

        BanGiamHieuBuilder setmaBanGiamHieu(string maBanGiamHieu);

        BanGiamHieu build();
    }
}
