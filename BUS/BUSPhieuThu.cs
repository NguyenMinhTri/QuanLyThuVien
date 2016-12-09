using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class BUSPhieuThu
    {
        DAOPhieuThu _daoPhieuThu = new DAOPhieuThu();
        public DataTable LayDanhSachPhieuThu()
        {
       
            return _daoPhieuThu.LayDanhSachPhieuThu();
        }
        public bool PhatSinhMaPhieuThu(ref DTOPhieuThu phieuthu)
        {
            try
            {
                int stt = _daoPhieuThu.DemSoPhieuThu() + 1;
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
                    phieuthu.MaPhieuThu = "PTH" + stt.ToString("D" + demSo.ToString());
                   

                }
                else
                {
                    phieuthu.MaPhieuThu = "PTH" + stt.ToString("D3");
                 
                }

                bool iCheck = _daoPhieuThu.KiemTraTonTaiMaPThu(phieuthu.MaPhieuThu);
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
                        phieuthu.MaPhieuThu = "PTH" + stt.ToString("D" + demSo.ToString());


                    }
                    else
                    {
                        phieuthu.MaPhieuThu = "PTH" + stt.ToString("D3");

                    }

                    iCheck = _daoPhieuThu.KiemTraTonTaiMaPThu(phieuthu.MaPhieuThu);
                }
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool CapNhat(DTOPhieuThu phieuthu)
        {
            return _daoPhieuThu.CapNhat(phieuthu);
        }

        public DTOPhieuThu LayPhieuThu(string maphieuthu)
        {
          
            DTOPhieuThu phieuthu = _daoPhieuThu.LayPhieuThu(maphieuthu);
            if (phieuthu == null)
                return null;
            DAODocGia _daoDocGia = new DAODocGia();
            DTODocGia docgia = _daoDocGia.LayThongTinDG(phieuthu.DocGia.MaDG);
            if (docgia == null)
                return null;
            phieuthu.DocGia = docgia;
            return phieuthu;
        }
    }
}
