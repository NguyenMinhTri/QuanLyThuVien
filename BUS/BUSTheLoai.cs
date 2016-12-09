using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using DTO;
namespace BUS
{
    public class BUSTheLoai
    {
        DAOTheLoai _daoTheloai = new DAOTheLoai();
        public int SoLuongTheLoai()
        {
           return _daoTheloai.SoLuongTheLoai();
        }
        public bool CapNhat(DTOTheLoai theloai)
        {
            return _daoTheloai.CapNhat(theloai);
        }
        public bool Xoa(string matheloai)
        {
            return _daoTheloai.Xoa(matheloai);
        }
        public bool PhatSinhMaTheLoai(ref DTOTheLoai theloai)
        {
            try {
                int stt = _daoTheloai.SoLuongTheLoai() + 1;
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
                    theloai.MaTheLoai = "TL" + stt.ToString("D" + demSo.ToString());
                }
                else
                    theloai.MaTheLoai = "TL" + stt.ToString("D3");
                bool iCheck = _daoTheloai.KiemTraMaTheLoai(theloai.MaTheLoai);
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
                        theloai.MaTheLoai = "TL" + stt.ToString("D" + demSo.ToString());
                    }
                    else
                        theloai.MaTheLoai = "TL" + stt.ToString("D3");
                    iCheck = _daoTheloai.KiemTraMaTheLoai(theloai.MaTheLoai);
                }

                return true;
            }catch
            {
                return false;
            }
           
        }
        public DataTable LayDanhSachTheLoai()
        {
           return _daoTheloai.LayDS();
        }
        public List<DTOTheLoai> ListTheLoai()
        {
            return _daoTheloai.ListTheLoai();
        }
        public string LayTenTheLoai(string matheloai)
        {
            return _daoTheloai.LayTenTheLoai(matheloai);
        }
    }
}
