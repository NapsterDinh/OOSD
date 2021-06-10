using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD.Model
{
    public class BanGiamHieu : NguoiDung
    {

        private string chucVu;
        private string maBanGiamHieu;

        public BanGiamHieu(string diaChi, string dienThoai, string email, string gioiTinh,
            string maNguoiDung, string matKhau, string ngaySinh, string tenDangNhap,
            string tenNguoiDung, string trangThai, string chucVu, string maBanGiamHieu)
            : base(diaChi, dienThoai, email, gioiTinh, maNguoiDung, matKhau, ngaySinh, tenDangNhap, tenNguoiDung, trangThai)
        {
            this.chucVu = chucVu;
            this.maBanGiamHieu = maBanGiamHieu;
        }
        public BanGiamHieu()
        {

        }

        ~BanGiamHieu()
        {

        }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public string MaBanGiamHieu { get => maBanGiamHieu; set => maBanGiamHieu = value; }

    }//end GiangVien
}
