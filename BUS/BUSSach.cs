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
    public class BUSSach
    {
        DAOSach _daoSach = new DAOSach();
        public List<string> DSTenSach()
        {
            return _daoSach.DSTenSach();
        }
        public string LayMaSach(string madausach, long namxb, string nhaxb)
        {
            return _daoSach.LayMaSach(madausach, namxb, nhaxb);
        }
        public bool PhatSinhMaSach(ref DTOSach sach)
        {
            try
            {
                int stt = _daoSach.SoSach(sach.MaDauSach) + 1;
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
                    sach.MaSach =sach.MaDauSach+ stt.ToString("D" + demSo.ToString());
                }
                else
                    sach.MaSach = sach.MaDauSach + stt.ToString("D3");
                bool iCheck = _daoSach.KiemTraMaSach(sach.MaSach);
                if(iCheck)
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
                        sach.MaSach = sach.MaDauSach + stt.ToString("D" + demSo.ToString());
                    }
                    else
                        sach.MaSach = sach.MaDauSach + stt.ToString("D3");
                    iCheck = _daoSach.KiemTraMaSach(sach.MaSach);
                }
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool CapNhat(DTOSach sach)
        {
             return _daoSach.CapNhat(sach);
          
        }
        public int SoLuongSach(string masach)
        {
            return _daoSach.SoLuongSach(masach);
        }
        public void CapNhatSoLuong(string masach,int soluong)
        {
            _daoSach.CapNhatSoLuong(masach, soluong);
        }
        public DataTable LayThongTinSach()
        {
            return _daoSach.LayThongTinSach();
        }
        public DTOSach LaySach(string masach)
        {
            return _daoSach.LaySach(masach);
        }
        public bool Xoa(string masach)
        {
            return _daoSach.Xoa(masach);
        }
        public int DemLanXuatBan(string madausach, long namxb, string nhaxb, double trigia)
        {
            return _daoSach.DemLanXuatBan(madausach, namxb, nhaxb,trigia);
        }
        public bool KiemTraTonTaiDauSach(string madausach)
        {
            return _daoSach.KiemTraTonTaiDauSach(madausach);
        }
        public bool KiemTraTonTaiMaSach(string masach)
        {
            return _daoSach.KiemTraMaSach(masach);
        }
        public DataTable TraCuuSach(string masach, string tendausach, string matl, string matg,
            long namxb, string nhaxb, object NgayNhap, double trigiamin, double trigiamax)
        {
            return _daoSach.TraCuuSach(masach, tendausach, matl, matg, namxb, nhaxb, NgayNhap, trigiamin, trigiamax);
        }
    }
}
