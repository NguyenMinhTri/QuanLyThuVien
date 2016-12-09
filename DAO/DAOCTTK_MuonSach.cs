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
    public class DAOCTTK_MuonSach:DBConnection
    {
        public DAOCTTK_MuonSach() : base() { }
        public DTOCTTK_MuonSach ConvertToCTTKMuonSach(DataRow row)
        {
            DTOCTTK_MuonSach cttkMuonSach = new DTOCTTK_MuonSach();
            try
            {
                cttkMuonSach.ThangTK = (int)row["ThangTK"];
            }
            catch { }
            try
            {
                cttkMuonSach.NamTK = (int)row["NamTK"];
            }
            catch { }
            cttkMuonSach.TheLoai.MaTheLoai = row["MaTL"].ToString();
            try
            {
                cttkMuonSach.SoLuotMuon = long.Parse(row["SoLuotMuon"].ToString());
            }
            catch { }
            try
            {
                cttkMuonSach.TiLe = float.Parse(row["TiLe"].ToString());
            }
            catch { }


            return cttkMuonSach;
        }

        public List<DTOCTTK_MuonSach> LayCTTKMuonSach(int thang, long nam)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spCTTK_MuonSach_LayDanhSachCTTK";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@ThangTK", SqlDbType.Int) { Value = thang };
                cmd.Parameters.Add(sqlParameter);
                 sqlParameter = new SqlParameter("@NamTK", SqlDbType.Int) { Value = nam };
                cmd.Parameters.Add(sqlParameter);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                da.Fill(data);
                conn.Close();

                if (data == null || data.Rows.Count == 0)
                    return null;
                else
                {
                    List<DTOCTTK_MuonSach> list = new List<DTOCTTK_MuonSach>();
                    foreach (DataRow row in data.Rows)
                        list.Add(ConvertToCTTKMuonSach(row));

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

        public bool CapNhat(DTOCTTK_MuonSach cttkMuonSach)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spCTTK_MuonSach_CapNhatCTTK";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@ThaoTac", SqlDbType.Int) { Value = 1 };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@ThangTK", SqlDbType.Int) { Value = cttkMuonSach.ThangTK };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@NamTK", SqlDbType.Int) { Value = cttkMuonSach.NamTK };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaTL", SqlDbType.VarChar, 15) { Value = cttkMuonSach.TheLoai.MaTheLoai };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@SoLuotMuon", SqlDbType.Int) { Value = cttkMuonSach.SoLuotMuon };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@TiLe", SqlDbType.Float) { Value = cttkMuonSach.TiLe };
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
