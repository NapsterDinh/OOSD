using OOSD.Enum;
using OOSD.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD.Service
{
    public class BanGiamHieuService : NguoiDungService
    {
        private static BanGiamHieuService instance;

        public static BanGiamHieuService getInstance()
        {
            if (instance == null)
            {
                instance = new BanGiamHieuService();
            }
            return instance;
        }

        public override bool addNewClass(LopHoc lophoc)
        {
            return false;
        }

        public override bool changeStatusClass(string malophoc, Status status)
        {
            return false;
        }

        public override bool editClass(LopHoc lophoc)
        {
            return false;
        }

        public override DataTable statisticByClassSinhVien(string maLop)
        {
            Console.WriteLine("ban giam hieu");
            return null;
        }

        public override DataTable viewClassListSinhVienByIdClass(string idClass)
        {
            return null;
        }

        public override DataTable viewDetailScoreByIdSinhVien(string idSinhvien, string MaMonHoc)
        {
            return null;
        }

        public override DataTable viewScoreListByIdSinhVien(string idSinhvien)
        {
            return null;
        }
        //quản lý sinh viên
        public bool addNewSinhVien(SinhVien sinhvien)
        {
            return false;
        }

        public bool ediSinhVien(SinhVien sinhvien)
        {
            return false;
        }

        public bool changeStatusSinhVien(string masinhvien, StatusSinhVien status)
        {
            switch (status)
            {
                case StatusSinhVien.DATOTNGHIEP:
                    break;
                case StatusSinhVien.CONHOC:
                    break;
                case StatusSinhVien.THOIHOC:
                    break;
                default:
                    break;
            }
            return false;
        }
        //quản lý giáo viên
        public bool addNewGiangVien(GiangVien giangVien)
        {
            return false;
        }

        public bool editGiangVien(GiangVien gianvien)
        {
            return false;
        }

        public bool changeStatusGiangVien(string magiangvien, StatusGiangVien status)
        {
            switch (status)
            {
                case StatusGiangVien.CONDAY:
                    break;
                case StatusGiangVien.NGHIPHEP:
                    break;
                case StatusGiangVien.NGUNGDAY:
                    break;
                default:
                    break;
            }
            return false;
        }
        public bool enrollGiangVienInClass(string magianvien, string malophoc)
        {
            return false;
        }
        //quản lý môn học
        public bool addNewMonHoc(MonHoc monHoc)
        {
            return false;
        }

        public bool editMonHoc(MonHoc monhoc)
        {
            return false;
        }

        public bool changeStatusMonHoc(string maMonHoc, Status status)
        {
            switch (status)
            {
                case Status.CONHOATDONG:
                    break;
                case Status.DAXOA:
                    break;
                default:
                    break;
            }
            return false;
        }
        public DataTable getAllMonhocByMaKhoa(string Makhoa)
        {
            return null;
        }
        //quản lý khoa đào tạo
        public bool addNewKhoa(KhoaDaoTao khoaDaotao)
        {
            return false;
        }

        public bool editKhoaDaotao(KhoaDaoTao khoaDaotao)
        {
            return false;
        }

        public bool changeStatusKhoaDaotao(string maKhoa, Status status)
        {
            switch (status)
            {
                case Status.CONHOATDONG:
                    break;
                case Status.DAXOA:
                    break;
                default:
                    break;
            }
            return false;
        }
        public DataTable getKhoaList()
        {
            return null;
        }
        //quản lý Lịch Thi
        public bool addNewLichThi(LichThi lichThi)
        {
            return false;
        }

        public bool editLichThi(LichThi lichThi)
        {
            return false;
        }

        public bool changeStatusLichThi(LichThi lichThi, Status status)
        {
            switch (status)
            {
                case Status.CONHOATDONG:
                    break;
                case Status.DAXOA:
                    break;
                default:
                    break;
            }
            return false;
        }
        public DataTable getLichThiBySubject(string mamonhoc)
        {
            return null;
        }
    }
}
