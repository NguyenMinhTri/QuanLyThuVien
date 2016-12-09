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
    public class DAOQuyDinh : DBConnection
    {
        public DAOQuyDinh() : base() { }
        public DTOQuyDinh ConvertToQuyDinh(DataRow row)
        {
            DTOQuyDinh quydinh = new DTOQuyDinh();

            try { quydinh.TuoiToiThieu = Int32.Parse(row["TuoiToiThieu"].ToString()); }
            catch { }

            try { quydinh.TuoiToiDa = Int32.Parse(row["TuoiToiDa"].ToString()); }
            catch { }

            try { quydinh.ThoiHanThe = Int32.Parse(row["ThoiHanThe"].ToString()); }
            catch { }

            try { quydinh.ThoiHanXB = Int32.Parse(row["ThoiHanXB"].ToString()); }
            catch { }

            try { quydinh.SoNgayMuonTD = Int32.Parse(row["SoNgayMuonTD"].ToString()); }
            catch { }

            try { quydinh.SoSachMuonTD = Int32.Parse(row["SoSachMuonTD"].ToString()); }
            catch { }

            try { quydinh.TienPhatMoiNgay = Double.Parse(row["TienPhatMoiNgay"].ToString()); }
            catch { }

          

            return quydinh;
        }
        public int LayTuoiToiDa()
        {
            int tuoi = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spQuyDinh_LayTuoiToiDa";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                    tuoi = Convert.ToInt32(rd["TuoiToiDa"]);
                rd.Close();
                return tuoi;

            }
            catch (Exception ex)
            {
                throw ex;
                conn.Close();
                return -1;

            }
        }
        public int LayTuoiToiThieu()
        {
            int tuoi = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spQuyDinh_LayTuoiToiThieu";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                    tuoi = Convert.ToInt32(rd["TuoiToiThieu"]);
                rd.Close();
                return tuoi;

            }
            catch (Exception ex)
            {
                throw ex;
                conn.Close();
                return -1;

            }
        }
        public int SoThangHetHan()
        {
            int thang = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spQuyDinh_LayNgayHetHan";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                    thang = Convert.ToInt32(rd["ThoiHanThe"]);
                rd.Close();
                return thang;

            }
            catch (Exception ex)
            {
                throw ex;
                conn.Close();
                return -1;

            }
        }
        public int ThoiHanXB()
        {
            int count = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spQuyDinh_LayThoiHanXB";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                    count = Convert.ToInt32(rd["ThoiHanXB"]);
                rd.Close();

                return count;

            }
            catch (Exception ex)
            {
                throw ex;
                conn.Close();
                return -1;

            }
        }
        public int LaySongayMuonTD()
        {
            int count = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spQuyDinh_LaySoNgayMuonTD";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                    count = Convert.ToInt32(rd["SoNgayMuonTD"]);
                rd.Close();

                return count;

            }
            catch (Exception ex)
            {
                throw ex;
                conn.Close();
                return -1;

            }
        }
        public int LaySoSachMuonTD()
        {
            int count = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spQuyDinh_LaySoSachMuonTD";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                    count = Convert.ToInt32(rd["SoSachMuonTD"]);
                rd.Close();

                return count;

            }
            catch (Exception ex)
            {
                throw ex;
                conn.Close();
                return -1;

            }
        }

        public double LayTienPhatMoiNgay()
        {
            double count = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spQuyDinh_LayTienPhatMoiNgay";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                    count = Convert.ToDouble(rd["TienPhatMoiNgay"]);
                rd.Close();

                return count;

            }
            catch (Exception ex)
            {
                throw ex;
                conn.Close();
                return -1;

            }
        }
        public DTOQuyDinh LayQuyDinh()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("spQuyDinh_LayQD", conn);
                cmd.CommandType = CommandType.StoredProcedure;
              
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt == null || dt.Rows.Count == 0)
                    return null;
                return ConvertToQuyDinh(dt.Rows[0]);
            }
            catch (Exception)
            {
                conn.Close();

            }
            return null;
        }
        public bool CapNhat(DTOQuyDinh quydinh)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spQuyDinh_CapNhatQD";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@TuoiToiThieu", SqlDbType.Int) { Value = quydinh.TuoiToiThieu };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@TuoiToiDa", SqlDbType.Int) { Value = quydinh.TuoiToiDa };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@ThoiHanThe", SqlDbType.Int) { Value = quydinh.ThoiHanThe };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@ThoiHanXB", SqlDbType.Int) { Value = quydinh.ThoiHanXB };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@SoSachMuonTD", SqlDbType.Int) { Value = quydinh.SoSachMuonTD };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@SoNgayMuonTD", SqlDbType.Int) { Value = quydinh.SoNgayMuonTD };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@TienPhatMoiNgay", SqlDbType.Money) { Value = quydinh.TienPhatMoiNgay };
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
        public bool ThemQuyDinh(DTOQuyDinh quydinh)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spQuyDinh_Insert";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@TuoiToiThieu", SqlDbType.Int) { Value = quydinh.TuoiToiThieu };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@TuoiToiDa", SqlDbType.Int) { Value = quydinh.TuoiToiDa };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@ThoiHanThe", SqlDbType.Int) { Value = quydinh.ThoiHanThe };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@ThoiHanXB", SqlDbType.Int) { Value = quydinh.ThoiHanXB };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@SoSachMuonTD", SqlDbType.Int) { Value = quydinh.SoSachMuonTD };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@SoNgayMuonTD", SqlDbType.Int) { Value = quydinh.SoNgayMuonTD };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@TienPhatMoiNgay", SqlDbType.Money) { Value = quydinh.TienPhatMoiNgay };
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
