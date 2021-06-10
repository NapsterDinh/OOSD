using OOSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD
{
    public class GlobalUser
    {
        private static SinhVien global_sinhvien;
        private static GiangVien global_giangvien;
        private static BanGiamHieu global_bangiamhieu;

        public static SinhVien setGlobalSinhVien(SinhVien sinhVien)
        {
            if(sinhVien == null)
            {
                global_sinhvien = sinhVien;
            }
            return global_sinhvien;
        }

        public static GiangVien setGlobalGiangVien(GiangVien giangvien)
        {
            if (giangvien == null)
            {
                global_giangvien = giangvien;
            }
            return global_giangvien;
        }

        public static BanGiamHieu setGlobalBanGiamHieu(BanGiamHieu banGiamHieu)
        {
            if (banGiamHieu == null)
            {
                global_bangiamhieu = banGiamHieu;
            }
            return global_bangiamhieu;
        }
    }
}
