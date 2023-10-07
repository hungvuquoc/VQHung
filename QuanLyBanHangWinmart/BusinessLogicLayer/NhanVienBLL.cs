using QuanLyBanHangWinmart.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangWinmart.BusinessLogicLayer
{
    public class NhanVienBLL
    {
        NhanVienDAL nhanVienDAL = new NhanVienDAL();

        public DataTable getALLNhanVien()
        {
            try
            {
                return nhanVienDAL.getALLNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra! {ex}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
