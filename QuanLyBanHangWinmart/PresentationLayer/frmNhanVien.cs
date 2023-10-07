using QuanLyBanHangWinmart.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangWinmart
{
    public partial class frmNhanVien : Form
    {
        NhanVienBLL nhanVienBLL = new NhanVienBLL();

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = nhanVienBLL.getALLNhanVien();

            dgvNhanVien.Columns[0].HeaderText = "Mã NV";
            dgvNhanVien.Columns[1].HeaderText = "Tên NV";
            dgvNhanVien.Columns[2].HeaderText = "Giới tính";
            dgvNhanVien.Columns[3].HeaderText = "Quê quán";
            dgvNhanVien.Columns[4].HeaderText = "Ngày sinh";
            dgvNhanVien.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvNhanVien.Columns[5].HeaderText = "Ngày vào làm";
            dgvNhanVien.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvNhanVien.Columns[6].HeaderText = "SDT";
            dgvNhanVien.Columns[7].HeaderText = "Trạng thái";

            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            txtMaNV.Enabled = false;

            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            txtMaNV.Text = dgvNhanVien.CurrentRow.Cells["sMaNV"].Value.ToString();
            txtTenNV.Text = dgvNhanVien.CurrentRow.Cells["sTenNV"].Value.ToString();
            cboGioiTinh.Text = dgvNhanVien.CurrentRow.Cells["bGioiTinh"].Value.ToString();
            txtQueQuan.Text = dgvNhanVien.CurrentRow.Cells["sQueQuan"].Value.ToString();
            dtpNgaySinh.Text = dgvNhanVien.CurrentRow.Cells["dNgaySinh"].Value.ToString();
            dtpNgayVaoLam.Text = dgvNhanVien.CurrentRow.Cells["dNgayVaoLam"].Value.ToString();
            txtSDT.Text = dgvNhanVien.CurrentRow.Cells["sSDT"].Value.ToString();
            cboTrangThai.Text = dgvNhanVien.CurrentRow.Cells["bTrangThai"].Value.ToString();
        }
    }
}
