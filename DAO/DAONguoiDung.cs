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
    public class DAONguoiDung:DBConnection
    {
        public DAONguoiDung() : base() { }

        public DTONguoiDung ConvertToNguoiDung(DataRow row)
        {
            DTONguoiDung nguoidung = new DTONguoiDung();
            nguoidung.TaiKhoan = row["TaiKhoan"].ToString();
            nguoidung.MatKhau = row["MatKhau"].ToString();
            nguoidung.MaNhom = row["MaNhom"].ToString();
            nguoidung.MaDG = row["MaDocGia"].ToString();
            if (nguoidung.MaNhom == "NH01")
                nguoidung.LoaiNguoiDung = LOAI_NGUOI_DUNG.NguoiQuanTri;
            else if (nguoidung.MaNhom == "NH02")
                nguoidung.LoaiNguoiDung = LOAI_NGUOI_DUNG.ThuThu;
            else if (nguoidung.MaNhom == "NH03")
                nguoidung.LoaiNguoiDung = LOAI_NGUOI_DUNG.DocGia;
            else
                nguoidung.LoaiNguoiDung = LOAI_NGUOI_DUNG.DocGia;
            return nguoidung;
        }
        public int DemTK_MK(string taikhoan, string matkhau)

        {
            int dem = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spNguoiDung_DemTaiKhoan_MatKhau";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@TaiKhoan", SqlDbType.VarChar, 16) { Value = taikhoan };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MatKhau", SqlDbType.VarChar, 36) { Value = matkhau };
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

        public DTONguoiDung LayThongTinNguoiDung(string taikhoan, string matkhau)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("spNguoiDung_LayThongTinNguoiDung", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@TaiKhoan", SqlDbType.VarChar, 16) { Value = taikhoan };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MatKhau", SqlDbType.VarChar, 36) { Value = matkhau };
                cmd.Parameters.Add(sqlParameter);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt == null || dt.Rows.Count == 0)
                    return null;
                return ConvertToNguoiDung(dt.Rows[0]);
            }
            catch (Exception)
            {
                conn.Close();

            }
            return null;
        }

        public int DemMaTaiKhoan(string matk)

        {
            int dem = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spNguoiDung_DemMaTaiKhoan";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@TaiKhoan", SqlDbType.VarChar, 16) { Value = matk };
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

        public bool CapNhat(DTONguoiDung nguoidung)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spNguoiDung_CapNhatNguoiDung";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@ThaoTac", SqlDbType.Int) { Value = 1 };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@TaiKhoan", SqlDbType.VarChar, 16) { Value = nguoidung.TaiKhoan };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MatKhau", SqlDbType.VarChar, 36) { Value = nguoidung.MatKhau };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaNhom", SqlDbType.VarChar, 15) { Value = nguoidung.MaNhom };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaDocGia", SqlDbType.VarChar, 15);
                if (nguoidung.LoaiNguoiDung == LOAI_NGUOI_DUNG.DocGia)
                    sqlParameter.Value = nguoidung.MaDG;
                else
                    sqlParameter.Value = null;
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
