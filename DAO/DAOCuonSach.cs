using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAOCuonSach:DBConnection
    {
        public DAOCuonSach() : base() { }

        public int DemCuonSach(string masach)
        {
            int dem = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spCuonSach_DemCuonSach";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaSach", SqlDbType.VarChar, 15) { Value = masach };
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
        public int DemCuonSachMuon(string masach)
        {
            int dem = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spSach_DemSoSachDangMuon";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaSach", SqlDbType.VarChar, 15) { Value = masach };
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
        public bool CapNhat(DTOCuonSach cuonsach)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spCuonSach_CapNhatCuonSach";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@ThaoTac", SqlDbType.Int) { Value = 1 };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaCuonSach", SqlDbType.VarChar, 15) { Value = cuonsach.MaCuonSach };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaSach", SqlDbType.VarChar, 15) { Value = cuonsach.MaSach };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@TinhTrang", SqlDbType.Bit) { Value = cuonsach.TinhTrang };
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
        public bool Xoa(string macuonsach)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spCuonSach_CapNhatCuonSach";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@ThaoTac", SqlDbType.Int) { Value = 0 };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaCuonSach", SqlDbType.VarChar, 15) { Value = macuonsach };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaSach", SqlDbType.VarChar, 15) { Value =  " " };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@TinhTrang", SqlDbType.Bit) { Value = true };
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
        public List<string> MaCuonSachXoaDuoc(string masach)
        {
            string macs ="";
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spCuonSach_XOA";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaSach", SqlDbType.VarChar, 15) { Value = masach };
                cmd.Parameters.Add(sqlParameter);
                 sqlParameter = new SqlParameter("@TinhTrang", SqlDbType.Bit) { Value = true };
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
                        list.Add(data.Rows[i]["MaCuonSach"].ToString());
                    return list;
                }

            }
            catch (Exception ex)
            {
                throw ex;
                conn.Close();
                return null;

            }
        }
        public bool KiemTraMaCuonSach(string macuonsach)
        {
            int dem = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spCuonSach_KiemTraMaCuonSach";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaCuonSach", SqlDbType.VarChar, 15) { Value = macuonsach };
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

        public bool CapNhatTinhTrang(string macuonsach,bool tinhtrang)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spCuonSach_CapNhatTinhTrang";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaCuonSach", SqlDbType.VarChar, 15) { Value = macuonsach };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@TinhTrang", SqlDbType.Bit) { Value = tinhtrang };
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
        // tìm trong bản cuốn sách, đếm số dòng có mã sách truyền vào, và tình trang 1 (true) là chưa có ai mượn
        public string MaCuonSachCoTheMuon(string masach)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spCuonSach_KiemTraSachCoTheMuon";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaSach", SqlDbType.VarChar, 15) { Value = masach };
                cmd.Parameters.Add(sqlParameter);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                da.Fill(data);
                conn.Close();

                if (data == null || data.Rows.Count == 0)
                    return null;
                else
                {
                
                       return data.Rows[0]["MaCuonSach"].ToString();
                 
                }

            }
            catch (Exception ex)
            {
                throw ex;
                conn.Close();
                return null;

            }
        }
        public string TenDauSach(string macuonsach)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spCuonSach_LayTenDauSach";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaCuonSach", SqlDbType.VarChar, 15) { Value = macuonsach };
                cmd.Parameters.Add(sqlParameter);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                da.Fill(data);
                conn.Close();

                if (data == null || data.Rows.Count == 0)
                    return null;
                else
                {

                    return data.Rows[0][0].ToString();

                }

            }
            catch (Exception ex)
            {
                throw ex;
                conn.Close();
                return null;

            }
        }
        public string LayMaTL(string macuonsach)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spCuonSach_LayMaTL";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaCuonSach", SqlDbType.VarChar, 15) { Value = macuonsach };
                cmd.Parameters.Add(sqlParameter);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                da.Fill(data);
                conn.Close();

                if (data == null || data.Rows.Count == 0)
                    return null;
                else
                {

                    return data.Rows[0][0].ToString();

                }

            }
            catch (Exception ex)
            {
                throw ex;
                conn.Close();
                return null;

            }
        }
        public List<DTOTacGia> LayDSTacGia(string macuonsach)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spCuonSach_LayDanhSachTacGia";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaCuonSach", SqlDbType.VarChar, 15) { Value = macuonsach };
                cmd.Parameters.Add(sqlParameter);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                da.Fill(data);
                conn.Close();

                if (data == null || data.Rows.Count == 0)
                    return null;
                else
                {

                    List<DTOTacGia> list = new List<DTOTacGia>();
                    for (int i = 0; i < data.Rows.Count; i++)
                        list.Add(new DTOTacGia(data.Rows[i]["MaTacGia"].ToString(), data.Rows[i]["TenTacGia"].ToString()));

                    return list;

                }

            }
            catch (Exception ex)
            {
                throw ex;
                conn.Close();
                return null;

            }
        }
        public string LayTenTL(string macuonsach)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spCuonSach_LayTenTL";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaCuonSach", SqlDbType.VarChar, 15) { Value = macuonsach };
                cmd.Parameters.Add(sqlParameter);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                da.Fill(data);
                conn.Close();

                if (data == null || data.Rows.Count == 0)
                    return null;
                else
                {

                    return data.Rows[0][0].ToString();

                }

            }
            catch (Exception ex)
            {
                throw ex;
                conn.Close();
                return null;

            }
        }
        public DTOCuonSach LayThongTinCuonSach(string macuonsach)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spCuonSach_LayThongTinCuonSach";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaCuonSach", SqlDbType.VarChar, 15) { Value = macuonsach };
                cmd.Parameters.Add(sqlParameter);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                da.Fill(data);
                conn.Close();

                if (data == null || data.Rows.Count == 0)
                    return null;
                else
                {

                    DTOCuonSach cuonsach = new DTOCuonSach();
                    cuonsach.MaCuonSach = data.Rows[0]["MaCuonSach"].ToString();
                    cuonsach.MaSach = data.Rows[0]["MaSach"].ToString();
                    try
                    {
                        cuonsach.TinhTrang = (bool)data.Rows[0]["TinhTrang"];
                    }
                    catch { }

                    return cuonsach;

                }

            }
            catch (Exception ex)
            {
                throw ex;
                conn.Close();
                return null;

            }
        }
    }
}
