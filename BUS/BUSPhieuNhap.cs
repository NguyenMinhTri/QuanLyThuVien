using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSPhieuNhap
    {
        DAOPhieuNhap _daoPhieuNhap = new DAOPhieuNhap();
      

        public DataTable DanhSachPhieuNhap()
        {
            return _daoPhieuNhap.DanhSachPhieuNhap();
        }

        public bool CapNhat(DTOPhieuNhap phieunhap)
        {
            return _daoPhieuNhap.CapNhatPhieuNhap(phieunhap);
        }
        public bool CapNhatTriGia(double sotienbitru,string mapn)
        {
            return _daoPhieuNhap.CapNhatTriGia(sotienbitru, mapn);
        }
        public bool CapNhatTongTriGia(string mapn,double sotien)
        {
            return _daoPhieuNhap.CapNhatTongTriGia(mapn, sotien);
        }
        public bool Xoa(string mapn)
        {
            return _daoPhieuNhap.Xoa(mapn);
        }
        public bool PhatSinhPhieuNhap(ref DTOPhieuNhap phieunhap)
        {
            try
            {
                int stt = _daoPhieuNhap.SoLuongPhieuNhap() + 1;
                if (stt < 0)
                    return false;
                int tempSTT = stt;
                int demSo = 0;
                while ((tempSTT / 10) >= 1)
                {
                    demSo++;
                    tempSTT = tempSTT / 10;
                }
                if (demSo > 3)
                {
                    phieunhap.MaPhieuNhap = "PNH" + stt.ToString("D" + demSo.ToString());
                    for (int i = 0; i < phieunhap.DSCTPhieuNhap.Count; i++)
                        phieunhap.DSCTPhieuNhap[i].MaPhieuNhap = phieunhap.MaPhieuNhap;
                }
                else
                {
                    phieunhap.MaPhieuNhap = "PNH" + stt.ToString("D3");
                    for (int i = 0; i < phieunhap.DSCTPhieuNhap.Count; i++)
                        phieunhap.DSCTPhieuNhap[i].MaPhieuNhap = phieunhap.MaPhieuNhap;
                }
                //dùng trong trường hợp xóa
                bool iCheck = _daoPhieuNhap.KiemTraTonTaiMaPN(phieunhap.MaPhieuNhap);
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
                    if (demSo > 3)
                    {
                        phieunhap.MaPhieuNhap = "PNH" + stt.ToString("D" + demSo.ToString());
                        for (int i = 0; i < phieunhap.DSCTPhieuNhap.Count; i++)
                            phieunhap.DSCTPhieuNhap[i].MaPhieuNhap = phieunhap.MaPhieuNhap;
                    }
                    else
                    {
                        phieunhap.MaPhieuNhap = "PNH" + stt.ToString("D3");
                        for (int i = 0; i < phieunhap.DSCTPhieuNhap.Count; i++)
                            phieunhap.DSCTPhieuNhap[i].MaPhieuNhap = phieunhap.MaPhieuNhap;
                    }
                    iCheck = _daoPhieuNhap.KiemTraTonTaiMaPN(phieunhap.MaPhieuNhap);
                }
                return true;
            }
            catch
            {
                return false;
            }

        }
        public DTOPhieuNhap LayPhieuNhap(string maphieunhap)
        {
           
            DTOPhieuNhap phieunhap = _daoPhieuNhap.LayPhieuNhap(maphieunhap);
            if (phieunhap == null)
                return null;

            DAOCT_PhieuNhap _daoCT_PhieuNhap = new DAOCT_PhieuNhap();
            List<DTOCT_PhieuNhap> dsct_pn = _daoCT_PhieuNhap.LayDSCT_PhieuNhap(maphieunhap);
            if (dsct_pn == null)
                return null;
            else
                phieunhap.DSCTPhieuNhap = dsct_pn;

            DAOSach _daoSach = new DAOSach();
            for (int i = 0; i < phieunhap.DSCTPhieuNhap.Count; i++)
            {
                DTOSach sach = _daoSach.LaySach(phieunhap.DSCTPhieuNhap[i].Sach.MaSach);
                if (sach != null)
                    phieunhap.DSCTPhieuNhap[i].Sach = sach;
            }
            return phieunhap;
        }

    }
}
