using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class BUSCT_PhieuNhap
    {
        DAOCT_PhieuNhap daoCT_PhieuNhap = new DAOCT_PhieuNhap();
        public bool CapNhat(DTOCT_PhieuNhap ctpn)
        {
            return daoCT_PhieuNhap.CapNhat(ctpn);
        }
        public double TongTien(string mapn)
        {
            return daoCT_PhieuNhap.TongTien(mapn);
        }
        public DataTable LayDanhSoLuongSach(string masach)
        {
            return daoCT_PhieuNhap.LaySoLuongSach(masach);
        }
        public bool Xoa(string mapn,string masach)
        {
            return daoCT_PhieuNhap.XoaCTPN(mapn, masach);
        }
        public bool KiemTraCTPN(string mapn)
        {
            return daoCT_PhieuNhap.KiemTraTonTaiPhieuNhap(mapn);
        }
        public bool CapNhatSoLuong(string mapn,int soluongsachbitru,string masach)
        {
            return daoCT_PhieuNhap.CapNhatSoLuong(soluongsachbitru, mapn, masach);
        }
        public bool CapNhatTriGia(string masach,double trigia)
        {
            return daoCT_PhieuNhap.CapNhatTriGia(masach, trigia);
        }
    }
}
