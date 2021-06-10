using OOSD.Enum;
using OOSD.Model;
using OOSD.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD.Controller
{
    public class LoginController
    {
        private Role currentRole;

        public LoginController(Role role)
        {
            this.currentRole = role;
        }

        public bool login(string username, string password)
        {
            switch (currentRole)
            {
                case Role.SINHVIEN:
                    SinhVienService sinhVienService = new SinhVienService();
                    DataTable dt = sinhVienService.login(username, password);
                    if(dt.Rows.Count==0)
                    {
                        //không tìm thấy
                        return false;
                    }
                    else
                    {
                        //có tìm thấy, gán vào globalSinhVien
                        SinhVien sv = new SinhVienConcentreBuilder().setdiaChi(dt.Rows[0][0].ToString()).build(); // này ví dụ chứ k đúng index
                        GlobalUser.setGlobalSinhVien(sv);
                        return true;
                    }
                case Role.GIANGVIEN:
                    GiangVienService giangVienService = new GiangVienService();
                    DataTable dt1 = giangVienService.login(username, password);
                    if (dt1.Rows.Count == 0)
                    {
                        //không tìm thấy
                        return false;
                    }
                    else
                    {
                        //có tìm thấy, gán vào globalSinhVien
                        GiangVien gv = new GiangVienConcentreBuilder().setdiaChi(dt1.Rows[0][0].ToString()).build(); // này ví dụ chứ k đúng index
                        GlobalUser.setGlobalGiangVien(gv);
                        return true;
                    }
                case Role.BANGIAMHIEU:
                    BanGiamHieuService banGiamHieuService = new BanGiamHieuService();
                    DataTable dt2 = banGiamHieuService.login(username, password);
                    if (dt2.Rows.Count == 0)
                    {
                        //không tìm thấy
                        return false;
                    }
                    else
                    {
                        //có tìm thấy, gán vào globalSinhVien
                        BanGiamHieu bgh = new BanGiamHieuConcentreBuilder().setdiaChi(dt2.Rows[0][0].ToString()).build(); // này ví dụ chứ k đúng index
                        GlobalUser.setGlobalBanGiamHieu(bgh);
                        return true;
                    }
                default:
                    break;
            }
            return false;
        }
    }
}
