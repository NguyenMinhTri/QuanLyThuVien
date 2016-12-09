using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;
using System.Windows.Forms;
using DTO;
namespace BUS
{
    public class BUSPhieuMuon
    {
        DAOPhieuMuon _daoPhieuMuon = new DAOPhieuMuon();
        BUSQuyDinh _busQuyDinh = new BUSQuyDinh();

        public DataTable DanhSachPhieuMuon()
        {
            return _daoPhieuMuon.DanhSachPhieuMuon();
        }

        public int DemSoSachDangMuon(string madocgia)
        {
            return _daoPhieuMuon.DemSoSachDangMuon(madocgia);
        }

        public bool KiemTraQD(DTOPhieuMuon phieumuon)
        {
           

            int sosachmuontd = _busQuyDinh.LaySoSachMuonTD();
            if (sosachmuontd < 0)
            {
                MessageBox.Show("Không lấy được quy định sách mượn tối đa");
                return false;
            }
            List<DTOCT_PhieuMuon> list = _daoPhieuMuon.LayDSSachDangMuon(phieumuon.DocGia.MaDG);
            if (list == null)
            {
                MessageBox.Show("Không lấy được ds sách đang mượn của độc giả");
                return false;
            }

            //giới hạn số sách mượn
            if (list.Count >= sosachmuontd)
            {
                MessageBox.Show("Mỗi độc giả chỉ mượn tối đa " + sosachmuontd.ToString() + " sách");
                return false;
            }

            //không có sách mượn quá hạn
            for (int i = 0; i < list.Count; i++)
            {
                object obj = _daoPhieuMuon.LayNgayHetHan(list[i].MaPhieuMuon);
                if (obj == null)
                    return false;
                else
                {
                    DateTime ngayhethan = new DateTime();
                    try
                    {
                        ngayhethan = (DateTime)obj;
                    }
                    catch
                    {
                        MessageBox.Show("Không lấy được ngày hết hạn");
                        return false;
                    }

                    //thư viện tiếp nhận sách trả đến 18h
                    ngayhethan = ngayhethan.AddHours(18);
                    if (ngayhethan < DateTime.Now)
                    {
                        MessageBox.Show("Độc giả có sách mượn quá hạn");
                        return false;
                    }
                }
            }

            return true;
        }
        public bool TinhNgayHetHan(ref DTOPhieuMuon phieumuon)
        {
          
            int songaymuontd = _busQuyDinh.LaySoNgayMuonTD();
            if (songaymuontd < 0)
            {
                MessageBox.Show("Không lấy được quy định số ngày mượn tối đa");
                return false;
            }
            else
            {
                try
                {
                    phieumuon.NgayHetHan = phieumuon.NgayMuon.AddDays(songaymuontd);
                }
                catch
                {
                    return false;
                }

                return true;

            }
        }
        public bool PhatSinhMaPhieuMuon(ref DTOPhieuMuon phieumuon)
        {
            try
            {
                int stt = _daoPhieuMuon.DemSoPhieuMuon() + 1;
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
                    phieumuon.MaPhieuMuon = "PMU" + stt.ToString("D" + demSo.ToString());
                  
                }
                else
                {
                    phieumuon.MaPhieuMuon = "PMU" + stt.ToString("D3");

                }
                //
                bool iCheck = _daoPhieuMuon.KiemTraPhieuMuon(phieumuon.MaPhieuMuon);
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
                        phieumuon.MaPhieuMuon = "PMU" + stt.ToString("D" + demSo.ToString());

                    }
                    else
                    {
                        phieumuon.MaPhieuMuon = "PMU" + stt.ToString("D3");

                    }
                    iCheck = _daoPhieuMuon.KiemTraPhieuMuon(phieumuon.MaPhieuMuon);
                }
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool CapNhat(DTOPhieuMuon phieumuon)
        {
            return _daoPhieuMuon.CapNhat(phieumuon);
        }
        public DataTable LayDanhSachPhieuMuon()
        {
            return _daoPhieuMuon.DanhSachPhieuMuon();
        }
        public DTOPhieuMuon LayPhieuMuon(string maphieumuon)
        {
        
            DTOPhieuMuon phieumuon = _daoPhieuMuon.LayPhieuMuon(maphieumuon);
            if (phieumuon == null)
                return null;

            DAODocGia _daoDocGia = new DAODocGia();
            DTODocGia docgia = _daoDocGia.LayThongTinDG(phieumuon.DocGia.MaDG);
            if (docgia == null)
                return null;

            DAOCT_PhieuMuon _daoCT_PhieuMuon = new DAOCT_PhieuMuon();
            List<DTOCT_PhieuMuon> list = _daoCT_PhieuMuon.LayDanhSachCT_PhieuMuon(phieumuon.MaPhieuMuon);
            if (list == null)
                return null;

            phieumuon.DocGia = docgia;
            phieumuon.DSCTPhieuMuon = list;
            return phieumuon;
        }
        public List<DTOCT_PhieuMuon> LayDSSachDangMuon(string madg)
        {
            return _daoPhieuMuon.LayDSSachDangMuon(madg);
        }
        public object LayNgayMuon(string maphieumuon)
        {
          
            return _daoPhieuMuon.LayNgayMuon(maphieumuon);
        }
        public List<DTOCuonSach> LaySachMuonTrongThang(int thang, long nam)
        {
 
            return _daoPhieuMuon.LaySachMuonTrongThang(thang, nam);
        }
        public List<DTOCT_PhieuMuon> LayDSSachTraTre(DateTime ngaylay)
        {

            return _daoPhieuMuon.LayDSSachTraTre(ngaylay);
        }
    }
}
