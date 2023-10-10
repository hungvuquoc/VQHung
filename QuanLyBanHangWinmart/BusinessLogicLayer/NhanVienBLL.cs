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

        public void themNhanVien(string sMaNV, string sTenNV, bool bGioiTinh, string sQueQuan, DateTime dNgaySinh, DateTime dNgayVaoLam, string sSDT, bool bTrangThai)
        {
            nhanVienDAL.themNhanVien(sMaNV, sTenNV, bGioiTinh, sQueQuan, dNgaySinh, dNgayVaoLam, sSDT, bTrangThai);
        }

        public void suaNhanVien(string sMaNV, string sTenNV, bool bGioiTinh, string sQueQuan, DateTime dNgaySinh, DateTime dNgayVaoLam, string sSDT, bool bTrangThai)
        {
            nhanVienDAL.suaNhanVien(sMaNV, sTenNV, bGioiTinh, sQueQuan, dNgaySinh, dNgayVaoLam, sSDT, bTrangThai);
        }

        public void xoaNhanVien(string sMaNV)
        {
            nhanVienDAL.xoaNhanVien(sMaNV);
        }

        public string taoMaNhanVien()
        {
            try
            {
                return nhanVienDAL.taoMaNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể tạo mã nhân viên mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        public DataTable timKiemNhanVien(string condition)
        {
            try
            {
                return nhanVienDAL.timkiemNhanVien(condition);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra! {ex}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
