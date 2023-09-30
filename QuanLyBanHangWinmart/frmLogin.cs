using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangWinmart
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (KiemTraDangNhap())
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["QuanLyWinMart"].ConnectionString))
                {
                    using (SqlCommand cm = new SqlCommand("prDangNhap", con))
                    {
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@TenDangNhap", txtTenDangNhap.Text.Trim());
                        cm.Parameters.AddWithValue("@MatKhau", mtxtMatKhau.Text.Trim());
                        con.Open();
                        using (SqlDataReader reader = cm.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while(reader.Read())
                                {

                                    Program.nhanvien = new NhanVien(
                                        (string)reader["sMaNV"],
                                        (string)reader["sTenNV"],
                                        (string)reader["sTenLoaiTK"]
                                    );
                                };
                                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                frmMain frm = new frmMain();
                                frm.ShowDialog();
                                Close();
                            }
                                else
                                {
                                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                    }
                }
            }
            }
            catch (SqlException ex)
            {
                foreach (SqlError error in ex.Errors)
                {
                    lblLoi.Text = error.Message;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool KiemTraDangNhap()
        {
            lblLoi.Text = ""; 

            if (txtTenDangNhap.Text.Trim() == "")
            {
                lblLoi.Text = "Vui lòng nhập tài khoản.";
                txtTenDangNhap.Focus();
                return false;
            }

            if (mtxtMatKhau.Text.Trim() == "")
            {
                lblLoi.Text = "Vui lòng nhập mật khẩu.";
                mtxtMatKhau.Focus();
                return false;
            } 
            else if (mtxtMatKhau.Text.Length < 6 || mtxtMatKhau.Text.Length > 50)
            {
                lblLoi.Text = "Mật khẩu phải từ 6 đên 50 ký tự!";
                mtxtMatKhau.Focus();
                return false;
            }

            return true;
        }
    }
}
