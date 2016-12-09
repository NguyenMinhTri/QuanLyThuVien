using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class BUSNguoiDung
    {
        DAONguoiDung _daoNguoiDung = new DAONguoiDung();
        public DTONguoiDung LayThongTinNguoiDung(string taikhoan, string matkhau)
        { 
            return _daoNguoiDung.LayThongTinNguoiDung(taikhoan, matkhau);
        }
        public int DemMaTaiKhoan(string matk)
        {
          
            return _daoNguoiDung.DemMaTaiKhoan(matk);
        }
        public bool CapNhat(DTONguoiDung nguoidung)
        {
         
            return _daoNguoiDung.CapNhat(nguoidung);
        }
    }
}
