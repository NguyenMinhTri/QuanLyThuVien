using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;
using DTO;
namespace BUS
{
    public class BUSPhieuTra
    {
        DAOPhieuTra _daoPhieuTra = new DAOPhieuTra();
        public DataTable LayDanhSachPhieuTra()
        {
            return _daoPhieuTra.LayDanhSachPhieuTra();
        }
        public bool CapNhat(DTOPhieuTra phieutra)
        {
            return _daoPhieuTra.CapNhat(phieutra);
        }
        public bool PhatSinhMaPhieuTra(ref DTOPhieuTra phieutra)
        {
            try
            {
                int stt = _daoPhieuTra.DemSoPhieuTra() + 1;
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
                    phieutra.MaPhieuTra = "PTR" + stt.ToString("D" + demSo.ToString());
                    for (int i = 0; i < phieutra.DSCTPhieuTra.Count; i++)
                        phieutra.DSCTPhieuTra[i].MaPhieuTra = phieutra.MaPhieuTra;

                }
                else
                {
                    phieutra.MaPhieuTra = "PTR" + stt.ToString("D3");
                    for (int i = 0; i < phieutra.DSCTPhieuTra.Count; i++)
                        phieutra.DSCTPhieuTra[i].MaPhieuTra = phieutra.MaPhieuTra;

                }

                bool iCheck = _daoPhieuTra.KiemTraTonTaiMaPhieuTra(phieutra.MaPhieuTra);
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
                        phieutra.MaPhieuTra = "PTR" + stt.ToString("D" + demSo.ToString());
                        for (int i = 0; i < phieutra.DSCTPhieuTra.Count; i++)
                            phieutra.DSCTPhieuTra[i].MaPhieuTra = phieutra.MaPhieuTra;

                    }
                    else
                    {
                        phieutra.MaPhieuTra = "PTR" + stt.ToString("D3");
                        for (int i = 0; i < phieutra.DSCTPhieuTra.Count; i++)
                            phieutra.DSCTPhieuTra[i].MaPhieuTra = phieutra.MaPhieuTra;

                    }
                    iCheck = _daoPhieuTra.KiemTraTonTaiMaPhieuTra(phieutra.MaPhieuTra);
                }
                return true;
            }
            catch
            {
                return false;
            }

        }
        public DTOPhieuTra LayPhieuTra(string maphieutra)
        {
           
            DTOPhieuTra phieutra = _daoPhieuTra.LayPhieuTra(maphieutra);
            if (phieutra == null)
                return null;

            DAODocGia _daoDocGia = new DAODocGia();
            DTODocGia docgia = _daoDocGia.LayThongTinDG(phieutra.DocGia.MaDG);
            if (docgia == null)
                return null;

            DAOCT_PhieuTra _daoCT_PhieuTra = new DAOCT_PhieuTra();
            List<DTOCT_PhieuTra> list = _daoCT_PhieuTra.LayDanhSachCT_PhieuTra(phieutra.MaPhieuTra);
            if (list == null)
                return null;

            phieutra.DocGia = docgia;
            phieutra.DSCTPhieuTra = list;
            return phieutra;
        }
    }
}
