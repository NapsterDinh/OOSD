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
    public abstract class NguoiDungService 
    {

        public void logout()
        {
            
        }

        public void forgotpass(string username, string phone)
        {
            
        }

        public DataTable login(string username, string password)
        {
            return null;
        }

        // quản lý điểm
        public abstract DataTable viewScoreListByIdSinhVien(string idSinhvien); // xem danh sach diem cua sinh vien

        public abstract DataTable viewDetailScoreByIdSinhVien(string idSinhvien, string MaMonHoc);  // xem chi tiet diem cua sinh vien 1 mon

        // thống kê
        public abstract DataTable statisticByClassSinhVien(string maLop); // thong ke theo lop

        //quản lý class
        public abstract DataTable viewClassListSinhVienByIdClass(string idClass); // xem danh sach sinh vien trong lop

        public abstract bool addNewClass(LopHoc lophoc); // thêm mới class

        public abstract bool editClass(LopHoc lophoc); // sửa class

        public abstract bool changeStatusClass(string malophoc, Status status); // xóa class

    }
}
