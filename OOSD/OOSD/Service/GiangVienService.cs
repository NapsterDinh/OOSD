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
    public class GiangVienService : NguoiDungService
    {
        private static GiangVienService instance;

        public static GiangVienService getInstance()
        {
            if (instance == null)
            {
                instance = new GiangVienService();
            }
            return instance;
        }

        public override bool addNewClass(LopHoc lophoc)
        {
            return false;
        }

        public bool addScoreByIdSinhVien(string idSinhvien, Score score)
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

        public bool editScoreByIdSinhVien(string idSinhvien, Score score)
        {
            return false;
        }

        public override DataTable statisticByClassSinhVien(string maLop)
        {
            Console.WriteLine("Giang vien");
            return null;
        }

        public DataTable viewClassListByIdGiangVien(string idGiangVien)
        {
            DataTable dt = new DataTable();
            return dt;
        }// xem danh sach lop cua giang vien

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

        public bool editInfor(GiangVien giangVien)
        {
            return false;
        }
    }
}
