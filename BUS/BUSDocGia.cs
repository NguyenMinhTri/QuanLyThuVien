using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DAO;
using DTO;
namespace BUS
{
    public class BUSDocGia
    {
        DAODocGia _daoDocGia = new DAODocGia();
        public string PhatSinhMaDG(long year)
        {
            string madg;
            
            int stt= _daoDocGia.SoLuongDGTheoNam(year)+1;
            int tempSTT = stt;
            int demSo = 0;
            while ((tempSTT / 10)>=1)
            {
                demSo++;
                tempSTT = tempSTT / 10;
            }
            string nam = (year % 100).ToString("D2");// 15
            if (demSo > 4)
            {
                 madg = nam + stt.ToString("D"+demSo.ToString());
            }else
                 madg = nam + stt.ToString("D4");
            bool iCheck = _daoDocGia.KiemTraTonTaiMaDocGia(madg);
            while(iCheck)
            {
                stt++;
                 tempSTT = stt;
                 demSo = 0;
                while ((tempSTT / 10) >= 1)
                {
                    demSo++;
                    tempSTT = tempSTT / 10;
                }
                 nam = (year % 100).ToString("D2");// 15
                if (demSo > 4)
                {
                    madg = nam + stt.ToString("D" + demSo.ToString());
                }
                else
                    madg = nam + stt.ToString("D4");
                iCheck = _daoDocGia.KiemTraTonTaiMaDocGia(madg);
            }

            return madg;
        }
        public bool ThemDocGia(DTODocGia docgia)
        {
            return _daoDocGia.ThemDocGia(docgia);
        }
        public DataTable DanhSachDocGia()
        {
            return _daoDocGia.DanhSachDocGia();
        } 
        public DataTable DanhSachDocGiaHetHan()
        {
            return _daoDocGia.DanhSachDocGiaHetHan();
        }
        public bool KiemTraTonTaiMaDocGia(string madocgia)
        {
            return _daoDocGia.KiemTraTonTaiMaDocGia(madocgia);
        }
        public bool KiemTranTonTaiMaLoaiDG(string MaLoaiDG)
        {
            return _daoDocGia.KiemTraTonTaiMaLoaiDG(MaLoaiDG);
        }
        public DTODocGia LayThongTinDG(string madg)
        {
          
            DAOLoaiDocGia _daoLoaiDG = new DAOLoaiDocGia();
            DTODocGia docgia = _daoDocGia.LayThongTinDG(madg);
            if (docgia != null)
                docgia.LoaiDG.TenLoaiDG = _daoLoaiDG.LayTenLoaiDG(docgia.LoaiDG.MaLoaiDG);
            return docgia;
        }
        public bool CapNhatTongNo(string madg, double tongno)
        {
            
            return _daoDocGia.CapNhatTongNo(madg, tongno);
        }
        public bool KiemTraTonTaiPhieuMuon(string madocgia)
        {

            return _daoDocGia.KiemTraTonTaiPhieuMuon(madocgia);
        }
        public bool Xoa(DTODocGia docgia)
        {
            return _daoDocGia.Xoa(docgia);
        }
    }
}
