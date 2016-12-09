using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DAOPhieuMuon:DBConnection
    {
        public DAOPhieuMuon() : base() { }

        public DTOCT_PhieuMuon ConvertToCT_PhieuMuon(DataRow row)
        {
            return new DTOCT_PhieuMuon(row["MaPhieuMuon"].ToString(), row["MaCuonSach"].ToString());
        }

        public DTOCuonSach ConvertToCuonSach(DataRow row)
        {
            DTOCuonSach cuonsach = new DTOCuonSach();
            cuonsach.MaCuonSach = row["MaCuonSach"].ToString();
            cuonsach.MaSach = row["MaSach"].ToString();
            try
            {
                cuonsach.TinhTrang = Boolean.Parse(row["TinhTrang"].ToString());
            }
            catch
            { }
            return cuonsach;
        }

        public DTOPhieuMuon ConvertToPhieuMuon(DataRow row)
        {
            DTOPhieuMuon phieumuon = new DTOPhieuMuon();
            phieumuon.MaPhieuMuon = row["MaPhieuMuon"].ToString();
            try
            {
                phieumuon.NgayMuon = DateTime.Parse(row["NgayMuon"].ToString());
            }
            catch { }
            phieumuon.DocGia.MaDG = row["MaDG"].ToString();
            try
            {
                phieumuon.NgayHetHan = DateTime.Parse(row["NgayHetHan"].ToString());
            }
            catch { }
            return phieumuon;
        }

        public DataTable DanhSachPhieuMuon()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("spPhieuMuon_LayDanhSachPhieuMuon", conn);
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

        public DTOPhieuMuon LayPhieuMuon(string maphieumuon)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("spPhieuMuon_LayPhieuMuon", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaPhieuMuon", SqlDbType.VarChar, 15) { Value = maphieumuon };
                cmd.Parameters.Add(sqlParameter);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt == null || dt.Rows.Count == 0)
                    return null;
                return ConvertToPhieuMuon(dt.Rows[0]);
            }
            catch (Exception)
            {
                conn.Close();

            }
            return null;
        }

      
        public List<DTOCT_PhieuMuon> LayDSSachDangMuon(string madg)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("spPhieuMuon_LayDanhSachSachDangMuon", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaDG", SqlDbType.VarChar, 15) { Value = madg };
                cmd.Parameters.Add(sqlParameter);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                da.Fill(data);
                conn.Close();

                if (data == null)
                    return null;
                else
                {
                    List<DTOCT_PhieuMuon> list = new List<DTOCT_PhieuMuon>();
                    foreach (DataRow row in data.Rows)
                        list.Add(ConvertToCT_PhieuMuon(row));
                    return list;
                }
            }
            catch
            {
                return null;
            }
        }

        public object LayNgayHetHan(string maphieumuon)
        {
         
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
        
                SqlCommand cmd = new SqlCommand("spPhieuMuon_LayNgayHetHan", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaPhieuMuon", SqlDbType.VarChar, 15) { Value = maphieumuon };

                cmd.Parameters.Add(sqlParameter);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                da.Fill(data);
                conn.Close();
                if (data == null || data.Rows.Count == 0)
                    return null;
                else
                {
                    DateTime dt = new DateTime();
                    try
                    {
                        dt = DateTime.Parse(data.Rows[0]["NgayHetHan"].ToString());
                    }
                    catch
                    {
                        return null;
                    }

                    return dt;
                }
            }catch
            {
                return null;
            }
        }
        public int DemSoSachDangMuon(string madocgia)
        {
            int dem = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spPhieuMuon_DemSoSachDangMuon";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaDG", SqlDbType.VarChar, 15) { Value = madocgia };
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
        public int DemSoPhieuMuon()
        {
            int dem = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spPhieuMuon_DemPhieuMuon";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
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
        public bool KiemTraPhieuMuon(string maphieumuon)
        {
            int dem = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spPhieuMuon_DemMaPhieuMuon";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaPhieuMuon", SqlDbType.VarChar, 15) { Value = maphieumuon };
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
        public bool CapNhat(DTOPhieuMuon phieumuon)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spPhieuMuon_CapNhatPhieuMuon";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@ThaoTac", SqlDbType.Int) { Value = 1 };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaPhieuMuon", SqlDbType.VarChar, 15) { Value = phieumuon.MaPhieuMuon };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@NgayMuon", SqlDbType.Date) { Value = phieumuon.NgayMuon };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaDG", SqlDbType.VarChar, 15) { Value = phieumuon.DocGia.MaDG };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@NgayHetHan", SqlDbType.Date) { Value = phieumuon.NgayHetHan };
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
        public object LayNgayMuon(string maphieumuon)
        {

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand("spPhieuMuon_LayNgayMuon", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaPhieuMuon", SqlDbType.VarChar, 15) { Value = maphieumuon };

                cmd.Parameters.Add(sqlParameter);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                da.Fill(data);
                conn.Close();
                if (data == null || data.Rows.Count == 0)
                    return null;
                else
                {
                    DateTime dt = new DateTime();
                    try
                    {
                        dt = DateTime.Parse(data.Rows[0]["NgayMuon"].ToString());
                    }
                    catch
                    {
                        return null;
                    }

                    return dt;
                }
            }
            catch
            {
                return null;
            }
        }
        public List<DTOCuonSach> LaySachMuonTrongThang(int thang, long nam)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("spPhieuMuon_LayDanhSachSachMuonTrongThang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@Thang", SqlDbType.Int) { Value = thang };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@Nam", SqlDbType.Int) { Value = nam };
                cmd.Parameters.Add(sqlParameter);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                da.Fill(data);
                conn.Close();

                if (data == null)
                    return null;
                else
                {
                    List<DTOCuonSach> list = new List<DTOCuonSach>();
                    for (int i = 0; i < data.Rows.Count; i++)
                        list.Add(ConvertToCuonSach(data.Rows[i]));

                    return list;
                }
            }
            catch
            {
                return null;
            }
        }
        public List<DTOCT_PhieuMuon> LayDSSachTraTre(DateTime ngaylay)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("spPhieuMuon_LayDanhSachSachTraTre", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@NgayTK", SqlDbType.Date) { Value = ngaylay };
                cmd.Parameters.Add(sqlParameter);
               
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                da.Fill(data);
                conn.Close();

                if (data == null)
                    return null;
                else
                {
                    List<DTOCT_PhieuMuon> list = new List<DTOCT_PhieuMuon>();
                    foreach (DataRow row in data.Rows)
                        list.Add(ConvertToCT_PhieuMuon(row));
                    return list;
                }
            }
            catch
            {
                return null;
            }
        }

    }

}
