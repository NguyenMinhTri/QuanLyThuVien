using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class BUSDuLieu
    {
        DAODuLieu _daoDulieu = new DAODuLieu();
        public bool SaoLuuDuLieu(string duongdan, string namedatabase)
        {
            return _daoDulieu.SaoLuuDuLieu(duongdan, namedatabase);
        }
        public bool PhucHoiDuLieu(string duongdan, string namedatabase)
        {
            return _daoDulieu.PhucHoi(duongdan, namedatabase);
        }
        public bool KhoiTaoChuoiKetNoi(string server, string namedatabase)
        {
            return _daoDulieu.KhoiTaoChuoiKetNoi(server, namedatabase);
        }
        public List<string> DanhSachCoSoDuLieu(string server)
        {
            return _daoDulieu.DanhSachCoSoDuLieu(server);
        }
    }
}
