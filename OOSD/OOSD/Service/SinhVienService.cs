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
    public class SinhVienService : NguoiDungService
    {
        private static SinhVienService instance;

        public static SinhVienService getInstance()
        {
            if(instance==null)
            {
                instance = new SinhVienService();
            }
            return instance;
        }

        public DataTable viewClassListByIdSinhVien(string idSinhvien)
        {
            return null;
        }

        public bool registerSubjects(string idSinhvien, string mamonhoc, string malophoc)
        {
            return false;
        }

        public DataTable viewTestCalendarByIdSinhVien(string idSinhvien)
        {
            return null;
        }

        public override DataTable viewScoreListByIdSinhVien(string idSinhvien)
        {
            return null;
        }

        public override DataTable viewDetailScoreByIdSinhVien(string idSinhvien, string MaMonHoc)
        {
            return null;
        }

        public override DataTable statisticByClassSinhVien(string maLop)
        {
            return null;
        }

        public override DataTable viewClassListSinhVienByIdClass(string idClass)
        {
            return null;
        }

        public override bool addNewClass(LopHoc lophoc)
        {
            return false;
        }

        public override bool editClass(LopHoc lophoc)
        {
            return false;
        }

        public override bool changeStatusClass(string malophoc, Status status)
        {
            return false;
        }
        public bool editInfor(SinhVien sinhVien)
        {
            return false;
        }
    }
}
