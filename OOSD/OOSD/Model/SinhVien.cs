using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD.Model
{
    public class SinhVien : NguoiDung
    {
        private string hocLuc;
        private string maKhoaDaoTao;
        private string maLop;
        private string maSinhVien;
        private int soTCTL;
        private double GPI;


        public SinhVien()
        {

        }

        public SinhVien(string diaChi, string dienThoai, string email, string gioiTinh,
            string maNguoiDung, string matKhau, string ngaySinh, string tenDangNhap,
            string tenNguoiDung, string trangThai, string hocLuc, string maKhoaDaoTao, 
            string maLop, string maSinhVien, int soTCTL, double GPI)
            :base(diaChi,dienThoai,email,gioiTinh,maNguoiDung,matKhau,ngaySinh,tenDangNhap,tenNguoiDung,trangThai)
        {
            this.HocLuc = hocLuc;
            this.MaKhoaDaoTao = maKhoaDaoTao;
            this.MaLop = maLop;
            this.MaSinhVien = maSinhVien;
            this.SoTCTL = soTCTL;
            this.GPI = GPI;
        }

        ~SinhVien()
        {

        }

        public string HocLuc { get => hocLuc; set => hocLuc = value; }
        public string MaKhoaDaoTao { get => maKhoaDaoTao; set => maKhoaDaoTao = value; }
        public string MaLop { get => maLop; set => maLop = value; }
        public string MaSinhVien { get => maSinhVien; set => maSinhVien = value; }
        public int SoTCTL { get => soTCTL; set => soTCTL = value; }
    }//end SinhVien
}
