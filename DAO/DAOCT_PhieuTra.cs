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
    public class DAOCT_PhieuTra:DBConnection
    {
        public DAOCT_PhieuTra() : base() { }

        public DTOCT_PhieuTra ConvertToCT_PhieuTra(DataRow row)
        {
            DTOCT_PhieuTra ctptr = new DTOCT_PhieuTra();
            ctptr.MaPhieuTra = row["MaPhieuTra"].ToString();
            ctptr.CTPhieuMuon.MaCuonSach = row["MaCuonSach"].ToString();
            ctptr.CTPhieuMuon.MaPhieuMuon = row["MaPhieuMuon"].ToString();
            try
            {
                ctptr.SoNgayMuon = Int32.Parse(row["SoNgayMuon"].ToString());
            }
            catch { }
            try
            {
                ctptr.TienPhat = Double.Parse(row["TienPhat"].ToString());
            }
            catch { }

            return ctptr;
        }
        public bool CapNhat(DTOCT_PhieuTra ctphieutra)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spCT_PhieuTra_CapNhatCTPT";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@ThaoTac", SqlDbType.Int) { Value = 1 };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaPhieuTra", SqlDbType.VarChar, 15) { Value = ctphieutra.MaPhieuTra };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaCuonSach", SqlDbType.VarChar, 15) { Value = ctphieutra.CTPhieuMuon.MaCuonSach };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaPhieuMuon", SqlDbType.VarChar, 15) { Value = ctphieutra.CTPhieuMuon.MaPhieuMuon };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@SoNgayMuon", SqlDbType.Int) { Value = ctphieutra.SoNgayMuon };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@TienPhat", SqlDbType.Money) { Value = ctphieutra.TienPhat };
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
        public List<DTOCT_PhieuTra> LayDanhSachCT_PhieuTra(string maphieutra)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spPhieuTra_LayDanhSachCTPT";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaPhieuTra", SqlDbType.VarChar, 15) { Value = maphieutra };
                cmd.Parameters.Add(sqlParameter);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                da.Fill(data);
                conn.Close();

                if (data == null || data.Rows.Count == 0)
                    return null;
                else
                {

                    List<DTOCT_PhieuTra> list = new List<DTOCT_PhieuTra>();
                    foreach (DataRow row in data.Rows)
                        list.Add(ConvertToCT_PhieuTra(row));
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

    }
}
