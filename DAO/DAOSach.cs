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
    public class DAOSach : DBConnection
    {
        public DAOSach() : base() { }
        public DTOSach ConvertToSach(DataRow row)
        {
            DTOSach sach = new DTOSach();
            sach.MaSach = row["MaSach"].ToString();
            sach.MaDauSach = row["MaDauSach"].ToString();
            try
            {
                sach.SoLuong = (int)row["SoLuong"];
            }
            catch { }
            try
            {
                sach.NamXB = (int)row["NamXB"];
            }
            catch { }
            sach.NhaXB = row["NhaXB"].ToString();
            try
            {
                sach.TriGia = Double.Parse(row["TriGia"].ToString());
            }
            catch { }
            try
            {
                sach.NgayNhap = (DateTime)row["NgayNhap"];
            }
            catch { }
            return sach;
        }
        public string LayMaSach(string madausach, long namxb, string nhaxb)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("spSach_LayMaSachTuDauSach", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaDauSach", SqlDbType.VarChar, 15) { Value = madausach };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@NamXB", SqlDbType.Int) { Value = namxb };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@NhaXB", SqlDbType.NVarChar, 70) { Value = nhaxb };
                cmd.Parameters.Add(sqlParameter);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                da.Fill(data);
                conn.Close();

                if (data == null)
                    return null;
                else
                {
                    return data.Rows[0]["MaSach"].ToString();
                }
            }
            catch
            {
                return null;
            }
        }
        public int SoSach(string madausach)
        {
            int dem = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spSach_DemSach";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaDauSach", SqlDbType.VarChar, 15) { Value = madausach };
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
        public bool CapNhat(DTOSach sach)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spSach_CapNhatSach";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@ThaoTac", SqlDbType.Int) { Value = 1 };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaSach", SqlDbType.VarChar, 15) { Value = sach.MaSach };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaDauSach", SqlDbType.VarChar, 15) { Value = sach.MaDauSach };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@SoLuong", SqlDbType.Int) { Value = sach.SoLuong };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@NamXB", SqlDbType.Int) { Value = sach.NamXB };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@NhaXB", SqlDbType.NVarChar, 70) { Value = sach.NhaXB };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@TriGia", SqlDbType.Money) { Value = sach.TriGia };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@NgayNhap", SqlDbType.Date) { Value = sach.NgayNhap };
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
        public bool CapNhatSoLuong(string masach, int soluongmoi)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spSach_CapNhatSoLuong";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaSach", SqlDbType.VarChar, 15) { Value = masach };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@SoLuong", SqlDbType.Int) { Value = soluongmoi };
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
        public int SoLuongSach(string masach)
        {
            int dem = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spSach_LaySoLuongSach";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaSach", SqlDbType.VarChar, 15) { Value = masach };
                cmd.Parameters.Add(sqlParameter);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                    dem = Convert.ToInt32(rd["SoLuong"]);
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

        public DataTable LayThongTinSach()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("spSach_LayDanhSachThongTinSach", conn);
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

        public DTOSach LaySach(string masach)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("spSach_LaySach", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaSach", SqlDbType.VarChar, 15) { Value = masach };
                cmd.Parameters.Add(sqlParameter);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return ConvertToSach(dt.Rows[0]);
            }
            catch (Exception)
            {
                conn.Close();

            }
            return null;
        }
        public int DemLanXuatBan(string madausach, long namxb, string nhaxb,double trigia)
        {
            int dem = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spSach_DemLanXuatBan";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaDauSach", SqlDbType.VarChar, 15) { Value = madausach };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@NamXB", SqlDbType.Int) { Value = namxb };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@NhaXB", SqlDbType.NVarChar, 70) { Value = nhaxb };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@TriGia", SqlDbType.Money) { Value = trigia };
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
        public bool Xoa(string masach )
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spSach_CapNhatSach";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@ThaoTac", SqlDbType.Int) { Value = 0 };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaSach", SqlDbType.VarChar, 15) { Value = masach };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaDauSach", SqlDbType.VarChar, 15) { Value = "" };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@SoLuong", SqlDbType.Int) { Value = 0 };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@NamXB", SqlDbType.Int) { Value =0 };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@NhaXB", SqlDbType.NVarChar, 70) { Value ="" };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@TriGia", SqlDbType.Money) { Value = 0 };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@NgayNhap", SqlDbType.Date) { Value = DateTime.Today };
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
        public bool KiemTraTonTaiDauSach(string madausach)
        {
            try
            {
                int dem = 0;
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spSach_KiemTraTonTaiDauSach";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter(@"MaDauSach", SqlDbType.VarChar, 15) { Value = madausach };
                cmd.Parameters.Add(sqlParameter);




                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                    dem = Convert.ToInt32(rd[""]);
                rd.Close();
                if (dem > 0)
                    return true;
                else return false;

            }
            catch
            {
                conn.Close();
                return false;
            }
        }
        public bool KiemTraMaSach(string masach)
        {
            int dem = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spSach_KiemTraMaSach";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaSach", SqlDbType.VarChar, 15) { Value = masach };
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
        public DataTable TraCuuSach(string masach, string tendausach, string matl, string matg,
            long namxb, string nhaxb, object NgayNhap, double trigiamin, double trigiamax)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("spSach_TraCuuSach", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaSach", SqlDbType.VarChar, 15) { Value = masach };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@TenDauSach", SqlDbType.NVarChar, 70) { Value = tendausach };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaTL", SqlDbType.VarChar, 15) { Value = matl };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaTG", SqlDbType.VarChar, 15) { Value = matg };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@NamXB", SqlDbType.Int);
                if (namxb < 0)
                    sqlParameter.Value = null;
                else
                    sqlParameter.Value = (int)namxb;
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@NhaXB", SqlDbType.NVarChar, 70) { Value = nhaxb };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@NgayNhap", SqlDbType.Date) { Value = NgayNhap };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@TriGiaMin", SqlDbType.Float) { Value = trigiamin };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@TriGiaMax", SqlDbType.Float);
                if (trigiamax > 0)
                    sqlParameter.Value = trigiamax;
                else
                    sqlParameter.Value = null;
                cmd.Parameters.Add(sqlParameter);


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
        public List<string> DSTenSach()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("spSach_LayDSTenSach", conn);
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
                        list.Add(data.Rows[i]["TenDauSach"].ToString());
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
