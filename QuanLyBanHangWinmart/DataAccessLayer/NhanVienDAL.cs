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
        public DataTable getALLNhanVien()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["QuanLyWinMart"].ConnectionString))
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
    }
}
