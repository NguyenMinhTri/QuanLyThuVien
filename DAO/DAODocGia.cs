using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class DAODocGia : DBConnection
    {
        public DAODocGia() : base() { }
        public DTODocGia ConvertToDocGia(DataRow row)
        {
            DTODocGia docgia = new DTODocGia();

            docgia.MaDG = row["MaDocGia"].ToString();
            docgia.HoTen = row["HoTen"].ToString();
            docgia.DiaChi = row["DiaChi"].ToString();
            docgia.Email = row["Email"].ToString();
            docgia.LoaiDG.MaLoaiDG = row["MaLoaiDG"].ToString();
            try
            {
                docgia.NgaySinh = DateTime.Parse(row["NgaySinh"].ToString());
            }
            catch
            { }
            try
            {
                docgia.NgayLapThe = DateTime.Parse(row["NgayLapThe"].ToString());
            }
            catch
            { }

            try
            {
                docgia.TongNo = Double.Parse(row["TongNo"].ToString());
            }
            catch
            { }

            try
            {
                docgia.NgayHetHan = DateTime.Parse(row["NgayHetHan"].ToString());
            }
            catch
            { }

            return docgia;
        }

        public int SoLuongDGTheoNam(long nam)
        {
            int dem = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spDocGia_DemDGTheoNam";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@Nam", SqlDbType.Int) { Value = nam };
                cmd.Parameters.Add(sqlParameter);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                    dem = Convert.ToInt32(rd[""]);
                rd.Close();
                return dem;

            }
            catch (Exception ex)
            {
                throw ex;
                conn.Close();
                return -1;

            }

        }
        public bool CapNhatTongNo(string madg, double tongno)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spDocGia_CapNhatTongNo";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaDocGia", SqlDbType.VarChar, 15) { Value = madg };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@TongNo", SqlDbType.Money) { Value = tongno };
                cmd.Parameters.Add(sqlParameter);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
                conn.Close();
                return false;
            }
        }
        public bool ThemDocGia(DTODocGia docgia)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spDocGia_CapNhatDG";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@ThaoTac", SqlDbType.Int) { Value = 1 };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaDocGia", SqlDbType.VarChar, 15) { Value = docgia.MaDG };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaLoaiDG", SqlDbType.VarChar, 15) { Value = docgia.MaLoaiDG };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@HoTen", SqlDbType.NVarChar, 70) { Value = docgia.HoTen };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@NgaySinh", SqlDbType.Date) { Value = docgia.NgaySinh };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@DiaChi", SqlDbType.NVarChar, 70) { Value = docgia.DiaChi };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@Email", SqlDbType.NVarChar, 70) { Value = docgia.Email };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@NgayLapThe", SqlDbType.Date) { Value = docgia.NgayLapThe };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@NgayHetHan", SqlDbType.Date) { Value = docgia.NgayHetHan };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@TongNo", SqlDbType.Money) { Value = docgia.TongNo };
                cmd.Parameters.Add(sqlParameter);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
                conn.Close();
                return false;
            }
        }
        public DataTable DanhSachDocGia()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("spDocGia_LayDanhSachDG", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception)
            {
                conn.Close();

            }
            return null;
        }
        public DataTable DanhSachDocGiaHetHan()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("spDocGia_LayDanhSachDGHetHan", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception)
            {
                conn.Close();

            }
            return null;
        }
        public bool KiemTraTonTaiMaDocGia(string madocgia)
        {
            int dem = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spDocGia_KiemTraMaDocGia";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaDocGia", SqlDbType.VarChar, 15) { Value = madocgia };
                cmd.Parameters.Add(sqlParameter);

                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                    dem = Convert.ToInt32(rd[""]);
                rd.Close();
                if (dem > 0)
                    return true;
                return false;

            }
            catch (Exception ex)
            {
                throw ex;
                conn.Close();
                return false;
            }
        }
        public bool KiemTraTonTaiMaLoaiDG(string MaLoaiDG)
        {
            int dem = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spDocGia_KiemTraMaLoaiDG";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaLoaiDG", SqlDbType.VarChar, 15) { Value = MaLoaiDG };
                cmd.Parameters.Add(sqlParameter);

                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                    dem = Convert.ToInt32(rd[""]);
                rd.Close();
                if (dem > 0)
                    return true;
                return false;

            }
            catch (Exception ex)
            {
                throw ex;
                conn.Close();
                return false;
            }
        }
        public DTODocGia LayThongTinDG(string madg)
        {

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("spDocGia_LayThongTinDG", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaDocGia", SqlDbType.VarChar, 15) { Value = madg };
                cmd.Parameters.Add(sqlParameter);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt == null || dt.Rows.Count == 0)
                    return null;
                return ConvertToDocGia(dt.Rows[0]);
            }
            catch (Exception)
            {
                conn.Close();

            }
            return null;
        }
        public bool KiemTraTonTaiPhieuMuon(string madocgia)
        {
            int dem = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spDocGia_DemSoPhieuMuon";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaDocGia", SqlDbType.VarChar, 15) { Value = madocgia };
                cmd.Parameters.Add(sqlParameter);

                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                    dem = Convert.ToInt32(rd[""]);
                rd.Close();
                if (dem > 0)
                    return true;
                return false;

            }
            catch (Exception ex)
            {
                throw ex;
                conn.Close();
                return false;
            }
        }
        public bool Xoa(DTODocGia docgia)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spDocGia_CapNhatDG";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@ThaoTac", SqlDbType.Int) { Value = 0 };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaDocGia", SqlDbType.VarChar, 15) { Value = docgia.MaDG };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaLoaiDG", SqlDbType.VarChar, 15) { Value = ""};
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@HoTen", SqlDbType.NVarChar, 70) { Value = docgia.HoTen };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@NgaySinh", SqlDbType.Date) { Value = docgia.NgaySinh };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@DiaChi", SqlDbType.NVarChar, 70) { Value = docgia.DiaChi };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@Email", SqlDbType.NVarChar, 70) { Value = docgia.Email };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@NgayLapThe", SqlDbType.Date) { Value = docgia.NgayLapThe };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@NgayHetHan", SqlDbType.Date) { Value = docgia.NgayHetHan };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@TongNo", SqlDbType.Money) { Value = docgia.TongNo };
                cmd.Parameters.Add(sqlParameter);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
                conn.Close();
                return false;
            }
        }
    }

}

