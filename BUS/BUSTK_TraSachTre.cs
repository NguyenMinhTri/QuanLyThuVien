using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class BUSTK_TraSachTre
    {
        DAOTK_TraSachTre _daoTK_TraSachTre = new DAOTK_TraSachTre();
        public int KiemTraTonTai(DateTime ngaytk)
        {
         
            return _daoTK_TraSachTre.DemPhieuTK(ngaytk);
        }

        //----------------------------------------------------------------------
        //Desc: lấy thông tin sách trả trễ
        //----------------------------------------------------------------------
        public DTOTK_TraSachTre LayTTSachTraTre(DTOCT_PhieuMuon ctpmu, DateTime ngaytk)
        {
            DAOPhieuMuon _daoPhieuMuon = new DAOPhieuMuon();

            object obj = _daoPhieuMuon.LayNgayHetHan(ctpmu.MaPhieuMuon);
            if (obj == null)
                return null;

            DateTime ngayhethan = new DateTime();
            try
            {
                ngayhethan = (DateTime)obj;
            }
            catch { return null; }

            double songaytratre = 0;
            if (ngaytk > ngayhethan)
            {
                try
                {
                    songaytratre = ngaytk.Subtract(ngayhethan).TotalDays;
                }
                catch { return null; }
            }
            if (songaytratre <= 0) { return null; }

            return (new DTOTK_TraSachTre(ngaytk, ctpmu.MaCuonSach, ngayhethan, (int)songaytratre));
        }

        //----------------------------------------------------------------------
        //Desc: cập nhật phiếu thống kê
        //----------------------------------------------------------------------
        public bool CapNhat(DTOTK_TraSachTre tktrasachtre)
        {
           
            return _daoTK_TraSachTre.CapNhat(tktrasachtre);
        }

        //----------------------------------------------------------------------
        //Desc: thêm danh sách CT_TKSachTraTre
        //----------------------------------------------------------------------
        public int InsertList(List<DTOTK_TraSachTre> dstktrasachtre)
        {
            int dem = 0;
            for (int i = 0; i < dstktrasachtre.Count; i++)
            {
                if (CapNhat(dstktrasachtre[i]))
                    dem++;
            }
            return dem;
        }

        //----------------------------------------------------------------------
        //Desc: lấy dữ liệu thống kê
        //----------------------------------------------------------------------
        public List<DTOTK_TraSachTre> LayDuLieuThongKe(DateTime ngaytk)
        {
         
            return _daoTK_TraSachTre.LayDuLieuThongKe(ngaytk);
        }
    }
}
