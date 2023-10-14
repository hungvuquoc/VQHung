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
    public class LoaiHangHoaDAL
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QuanLyWinMart"].ConnectionString;

        public DataTable layMaLoaiHang()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cm = new SqlCommand("prLayMaLoaiHang", con))
                {
                    con.Open();
                    cm.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cm))
                    {
                        DataTable dt = new DataTable("MaLoaiHang");
                        sda.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
}
