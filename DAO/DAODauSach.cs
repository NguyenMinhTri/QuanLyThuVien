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
    public class DAODauSach : DBConnection
    {
        public DAODauSach() : base() { }
        public DTODauSach ConvertToDauSach(DataRow row)
        {
            DTODauSach dausach = new DTODauSach();
            dausach.MaDauSach = row["MaDauSach"].ToString();
            dausach.TenDauSach = row["TenDauSach"].ToString();
            dausach.TheLoai.MaTheLoai = row["MaTL"].ToString();
            return dausach;
        }
        public int SoLuongDauSach()
        {
            int dem = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spDauSach_DemDauSach";
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
        public bool CapNhat(DTODauSach dausach)
        {

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spDauSach_CapNhatDauSach";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@ThaoTac", SqlDbType.Int) { Value = 1 };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaDauSach", SqlDbType.VarChar, 15) { Value = dausach.MaDauSach };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@TenDauSach", SqlDbType.NVarChar, 70) { Value = dausach.TenDauSach };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaTL", SqlDbType.VarChar, 15) { Value = dausach.TheLoai.MaTheLoai };
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
        public bool Xoa(string madausach)
        {

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spDauSach_CapNhatDauSach";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@ThaoTac", SqlDbType.Int) { Value = 0 };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaDauSach", SqlDbType.VarChar, 15) { Value = madausach };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@TenDauSach", SqlDbType.NVarChar, 70) { Value = "" };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaTL", SqlDbType.VarChar, 15) { Value = "" };
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
        public DataTable LayDuLieuBangDauSach()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("spDauSach_LayDanhSachDauSach", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                da.Fill(data);
                conn.Close();

                if (data == null)
                    return null;
               
                    return data;
                
            }
            catch
            {
                return null;
            }
        }
        public List<DTODauSach> LayDSDauSach()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("spDauSach_LayDanhSachDauSach", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                da.Fill(data);
                conn.Close();

                if (data == null)
                    return null;
                else
                {
                    List<DTODauSach> list = new List<DTODauSach>();
                    for (int i = 0; i < data.Rows.Count; i++)
                        list.Add(ConvertToDauSach(data.Rows[i]));
                    return list;
                }
            }
            catch
            {
                return null;
            }
        }
        public string LayTenTheLoai(string madausach)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("spDauSach_LayTenTL", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaDauSach", SqlDbType.VarChar, 15) { Value = madausach };
                cmd.Parameters.Add(sqlParameter);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                da.Fill(data);
                conn.Close();

                if (data == null)
                    return null;
                else
                {
                    return data.Rows[0]["TenTheLoai"].ToString();
                }
            }
            catch
            {
                return null;
            }
        }
        public List<string> LayDSTenTG(string madausach)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("spDauSach_LayDanhSachTenTG", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaDauSach", SqlDbType.VarChar, 15) { Value = madausach };
                cmd.Parameters.Add(sqlParameter);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                da.Fill(data);
                conn.Close();

                if (data == null)
                    return null;
                else
                {
                    List<string> list = new List<string>();
                    for (int i = 0; i < data.Rows.Count; i++)
                        list.Add(data.Rows[i]["TenTacGia"].ToString());
                    return list;
                }
            }
            catch
            {
                return null;
            }
        }
        public DTODauSach LayDauSach(string madausach)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("spDauSach_LayDauSach", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaDauSach", SqlDbType.VarChar, 15) { Value = madausach };
                cmd.Parameters.Add(sqlParameter);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return ConvertToDauSach(dt.Rows[0]);
            }
            catch (Exception)
            {
                conn.Close();

            }
            return null;
        }
        public bool KiemTraTonTai(DTODauSach dausach)
        {
            int dem = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spDauSach_KiemTraTonTai";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaDauSach", SqlDbType.VarChar, 15) { Value = dausach.MaDauSach };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@TenDauSach", SqlDbType.NVarChar,70) { Value = dausach.TenDauSach };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaTL", SqlDbType.VarChar, 15) { Value = dausach.TheLoai.MaTheLoai };
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
        public bool KiemTraTonTaiMaDauSach(string madausach)
        {
            int dem = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spDauSach_KiemTraMaDauSach";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaDauSach", SqlDbType.VarChar, 15) { Value = madausach };
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
        public bool KiemTraTonTaiMaTheLoai(string matheloai)
        {
            int dem = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spDauSach_KiemTraMaTL";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaTL", SqlDbType.VarChar, 15) { Value = matheloai };
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

    }
}
