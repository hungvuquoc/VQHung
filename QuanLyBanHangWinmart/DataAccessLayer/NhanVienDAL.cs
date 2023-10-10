using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangWinmart.DataAccessLayer
{
    public class NhanVienDAL
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QuanLyWinMart"].ConnectionString;

        public DataTable getALLNhanVien()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cm = new SqlCommand("prGetAllNhanVien", con))
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cm))
                    {
                        DataTable dt = new DataTable("DangNhap");
                        sda.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public void themNhanVien(string sMaNV, string sTenNV, bool bGioiTinh, string sQueQuan, DateTime dNgaySinh, DateTime dNgayVaoLam, string sSDT, bool bTrangThai)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cm = new SqlCommand("prThemNhanVien", con))
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.Parameters.AddWithValue("@MaNV", sMaNV);
                    cm.Parameters.AddWithValue("@TenNV", sTenNV);
                    cm.Parameters.AddWithValue("@GioiTinh", bGioiTinh);
                    cm.Parameters.AddWithValue("@QueQuan", sQueQuan);
                    cm.Parameters.AddWithValue("@NgaySinh", dNgaySinh);
                    cm.Parameters.AddWithValue("@NgayVaoLam",dNgayVaoLam);
                    cm.Parameters.AddWithValue("@SDT", sSDT);
                    cm.Parameters.AddWithValue("@TrangThai", bTrangThai);
                    con.Open();
                    cm.ExecuteNonQuery();
                }
            }
        }

        public void suaNhanVien(string sMaNV, string sTenNV, bool bGioiTinh, string sQueQuan, DateTime dNgaySinh, DateTime dNgayVaoLam, string sSDT, bool bTrangThai)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cm = new SqlCommand("prSuaNhanVien", con))
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.Parameters.AddWithValue("@MaNV", sMaNV);
                    cm.Parameters.AddWithValue("@TenNV", sTenNV);
                    cm.Parameters.AddWithValue("@GioiTinh", bGioiTinh);
                    cm.Parameters.AddWithValue("@QueQuan", sQueQuan);
                    cm.Parameters.AddWithValue("@NgaySinh", dNgaySinh);
                    cm.Parameters.AddWithValue("@NgayVaoLam", dNgayVaoLam);
                    cm.Parameters.AddWithValue("@SDT", sSDT);
                    cm.Parameters.AddWithValue("@TrangThai", bTrangThai);
                    con.Open();
                    cm.ExecuteNonQuery();
                }
            }
        }

        public string taoMaNhanVien()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cm = new SqlCommand("prTaoMaNhanVien", con))
                {
                    con.Open();
                    cm.CommandType = CommandType.StoredProcedure;
                    string maMoi = (string)cm.ExecuteScalar();
                    return maMoi;
                }
            }
        }
    }
}
