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
    public class DAOCT_PhieuNhap:DBConnection
    {
        public DAOCT_PhieuNhap() : base() { }
        public DTOCT_PhieuNhap ConvertToCT_PhieuNhap(DataRow row)
        {
            DTOCT_PhieuNhap ctpn = new DTOCT_PhieuNhap();
            ctpn.MaPhieuNhap = row["MaPhieuNhap"].ToString();
            ctpn.Sach.MaSach = row["MaSach"].ToString();
            try
            {
                ctpn.SoLuong = Int32.Parse(row["SoLuong"].ToString());
            }
            catch { }
            try
            {
                ctpn.TriGia = Double.Parse(row["TriGia"].ToString());
            }
            catch { }
            try
            {
                ctpn.ThanhTien = Double.Parse(row["ThanhTien"].ToString());
            }
            catch { }

            return ctpn;
        }

        public bool XoaCTPN(string MaPN, string masach)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spCT_PhieuNhap_CapNhatCTPN";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@ThaoTac", SqlDbType.Int) { Value = 0 };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter(@"MaPhieuNhap", SqlDbType.VarChar, 15) { Value =MaPN };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaSach", SqlDbType.VarChar, 15) { Value = masach };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@SoLuong", SqlDbType.Int) { Value = 0 };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@TriGia", SqlDbType.Money) { Value = 0 };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@ThanhTien", SqlDbType.Money) { Value = 0 };
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
        public bool CapNhat(DTOCT_PhieuNhap ctpn)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spCT_PhieuNhap_CapNhatCTPN";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@ThaoTac", SqlDbType.Int) { Value = 1 };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter(@"MaPhieuNhap", SqlDbType.VarChar, 15) { Value = ctpn.MaPhieuNhap };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaSach", SqlDbType.VarChar, 15) { Value = ctpn.Sach.MaSach };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@SoLuong", SqlDbType.Int) { Value = ctpn.SoLuong };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@TriGia", SqlDbType.Money) { Value = ctpn.TriGia };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@ThanhTien", SqlDbType.Money) { Value = ctpn.ThanhTien };
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

        public DataTable LaySoLuongSach(string masach)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("spCT_PhieuNhap_LaySoLuongSach", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaSach", SqlDbType.VarChar, 15) { Value = masach };
                cmd.Parameters.Add(sqlParameter);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                conn.Close();

            }
            return null;
        }
        public bool KiemTraTonTaiPhieuNhap(string mapn)
        {
            try
            {
                int dem = 0;
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spCT_PhieuNhap_KiemTraTonTaiPhieuNhap";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter(@"MaPhieuNhap", SqlDbType.VarChar, 15) { Value = mapn };
                cmd.Parameters.Add(sqlParameter);




                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                    dem = Convert.ToInt32(rd[""]);
                rd.Close();
                if (dem > 0)
                    return true;
                else return false;

            }
            catch (Exception ex)
            {
                throw ex;
                conn.Close();
                return false;
            }
        }
        public bool CapNhatSoLuong(double soluongsachbitru, string mapn,string masach)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "[spCT_PhieuNhap_CapNhatSoLuong]";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter sqlParameter = new SqlParameter("@MaPhieuNhap", SqlDbType.VarChar, 15) { Value = mapn };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaSach", SqlDbType.VarChar,15) { Value = masach };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@SoLuong", SqlDbType.Int) { Value = soluongsachbitru };
                cmd.Parameters.Add(sqlParameter);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;

            }
            catch (Exception ex)
            {
                conn.Close();
                throw ex;

                return false;
            }
        }
        public bool CapNhatTriGia(string masach,double trigia)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "[spCT_PhieuNhap_CapNhatTriGia]";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter sqlParameter = new SqlParameter("@MaSach", SqlDbType.VarChar, 15) { Value = masach };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@TriGia", SqlDbType.Money) { Value = trigia };
                cmd.Parameters.Add(sqlParameter);
               
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;

            }
            catch (Exception ex)
            {
                conn.Close();
                throw ex;

                return false;
            }
        }
        public double TongTien(string mapn)
        {
            double dem = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "[spCT_PhieuNhap_SumThanhTien]";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaPhieuNhap", SqlDbType.VarChar,15) { Value = mapn };
                cmd.Parameters.Add(sqlParameter);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                    dem = Convert.ToDouble(rd[""]);
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
        public List<DTOCT_PhieuNhap> LayDSCT_PhieuNhap(string maphieunhap)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("spCT_PhieuNhap_LayDSCT_PhieuNhap", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaPhieuNhap", SqlDbType.VarChar, 15) { Value = maphieunhap };
                cmd.Parameters.Add(sqlParameter);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                da.Fill(data);
                conn.Close();

                if (data == null)
                    return null;
                else
                {
                    List<DTOCT_PhieuNhap> list = new List<DTOCT_PhieuNhap>();
                    foreach (DataRow row in data.Rows)
                    {
                        DTOCT_PhieuNhap ctpn = ConvertToCT_PhieuNhap(row);
                        if (ctpn != null)
                            list.Add(ctpn);
                    }
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
