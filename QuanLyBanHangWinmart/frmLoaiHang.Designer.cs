namespace QuanLyBanHangWinmart
{
    partial class frmLoaiHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabContainer = new System.Windows.Forms.TabControl();
            this.tpChinhSua = new System.Windows.Forms.TabPage();
            this.txtTenLoaiHang = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtMaLoaiHang = new System.Windows.Forms.TextBox();
            this.lblMa = new System.Windows.Forms.Label();
            this.tpTimKiem = new System.Windows.Forms.TabPage();
            this.cboMaS = new System.Windows.Forms.ComboBox();
            this.btnHienTatCa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtSDTS = new System.Windows.Forms.TextBox();
            this.lblSDTS = new System.Windows.Forms.Label();
            this.txtDiaChiS = new System.Windows.Forms.TextBox();
            this.lblDiaChiS = new System.Windows.Forms.Label();
            this.txtTenS = new System.Windows.Forms.TextBox();
            this.lblTenS = new System.Windows.Forms.Label();
            this.lblMaS = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvSP = new System.Windows.Forms.DataGridView();
            this.tabContainer.SuspendLayout();
            this.tpChinhSua.SuspendLayout();
            this.tpTimKiem.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).BeginInit();
            this.SuspendLayout();
            // 
            // tabContainer
            // 
            this.tabContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabContainer.Controls.Add(this.tpChinhSua);
            this.tabContainer.Controls.Add(this.tpTimKiem);
            this.tabContainer.Location = new System.Drawing.Point(13, 13);
            this.tabContainer.Margin = new System.Windows.Forms.Padding(4);
            this.tabContainer.Name = "tabContainer";
            this.tabContainer.SelectedIndex = 0;
            this.tabContainer.Size = new System.Drawing.Size(700, 245);
            this.tabContainer.TabIndex = 12;
            // 
            // tpChinhSua
            // 
            this.tpChinhSua.Controls.Add(this.txtTenLoaiHang);
            this.tpChinhSua.Controls.Add(this.lblTen);
            this.tpChinhSua.Controls.Add(this.txtMaLoaiHang);
            this.tpChinhSua.Controls.Add(this.lblMa);
            this.tpChinhSua.Location = new System.Drawing.Point(4, 25);
            this.tpChinhSua.Margin = new System.Windows.Forms.Padding(4);
            this.tpChinhSua.Name = "tpChinhSua";
            this.tpChinhSua.Padding = new System.Windows.Forms.Padding(4);
            this.tpChinhSua.Size = new System.Drawing.Size(692, 216);
            this.tpChinhSua.TabIndex = 0;
            this.tpChinhSua.Text = "Chỉnh sửa";
            this.tpChinhSua.UseVisualStyleBackColor = true;
            // 
            // txtTenLoaiHang
            // 
            this.txtTenLoaiHang.Location = new System.Drawing.Point(146, 72);
            this.txtTenLoaiHang.Margin = new System.Windows.Forms.Padding(0);
            this.txtTenLoaiHang.Name = "txtTenLoaiHang";
            this.txtTenLoaiHang.Size = new System.Drawing.Size(441, 22);
            this.txtTenLoaiHang.TabIndex = 13;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(16, 75);
            this.lblTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(99, 16);
            this.lblTen.TabIndex = 12;
            this.lblTen.Text = "Tên Loại Hàng ";
            // 
            // txtMaLoaiHang
            // 
            this.txtMaLoaiHang.Location = new System.Drawing.Point(146, 24);
            this.txtMaLoaiHang.Margin = new System.Windows.Forms.Padding(0);
            this.txtMaLoaiHang.Name = "txtMaLoaiHang";
            this.txtMaLoaiHang.Size = new System.Drawing.Size(441, 22);
            this.txtMaLoaiHang.TabIndex = 11;
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(16, 27);
            this.lblMa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(91, 16);
            this.lblMa.TabIndex = 10;
            this.lblMa.Text = "Mã Loại hàng ";
            // 
            // tpTimKiem
            // 
            this.tpTimKiem.Controls.Add(this.cboMaS);
            this.tpTimKiem.Controls.Add(this.btnHienTatCa);
            this.tpTimKiem.Controls.Add(this.btnTimKiem);
            this.tpTimKiem.Controls.Add(this.txtSDTS);
            this.tpTimKiem.Controls.Add(this.lblSDTS);
            this.tpTimKiem.Controls.Add(this.txtDiaChiS);
            this.tpTimKiem.Controls.Add(this.lblDiaChiS);
            this.tpTimKiem.Controls.Add(this.txtTenS);
            this.tpTimKiem.Controls.Add(this.lblTenS);
            this.tpTimKiem.Controls.Add(this.lblMaS);
            this.tpTimKiem.Location = new System.Drawing.Point(4, 25);
            this.tpTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.tpTimKiem.Name = "tpTimKiem";
            this.tpTimKiem.Padding = new System.Windows.Forms.Padding(4);
            this.tpTimKiem.Size = new System.Drawing.Size(710, 216);
            this.tpTimKiem.TabIndex = 1;
            this.tpTimKiem.Text = "Tìm kiếm";
            this.tpTimKiem.UseVisualStyleBackColor = true;
            // 
            // cboMaS
            // 
            this.cboMaS.FormattingEnabled = true;
            this.cboMaS.Location = new System.Drawing.Point(107, 23);
            this.cboMaS.Margin = new System.Windows.Forms.Padding(4);
            this.cboMaS.Name = "cboMaS";
            this.cboMaS.Size = new System.Drawing.Size(203, 24);
            this.cboMaS.TabIndex = 32;
            // 
            // btnHienTatCa
            // 
            this.btnHienTatCa.Location = new System.Drawing.Point(469, 171);
            this.btnHienTatCa.Margin = new System.Windows.Forms.Padding(0);
            this.btnHienTatCa.Name = "btnHienTatCa";
            this.btnHienTatCa.Size = new System.Drawing.Size(92, 32);
            this.btnHienTatCa.TabIndex = 31;
            this.btnHienTatCa.Text = "Hiện Tất Cả";
            this.btnHienTatCa.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(605, 171);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(0);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(92, 32);
            this.btnTimKiem.TabIndex = 9;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtSDTS
            // 
            this.txtSDTS.Location = new System.Drawing.Point(475, 23);
            this.txtSDTS.Margin = new System.Windows.Forms.Padding(0);
            this.txtSDTS.Name = "txtSDTS";
            this.txtSDTS.Size = new System.Drawing.Size(223, 22);
            this.txtSDTS.TabIndex = 27;
            // 
            // lblSDTS
            // 
            this.lblSDTS.AutoSize = true;
            this.lblSDTS.Location = new System.Drawing.Point(404, 27);
            this.lblSDTS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSDTS.Name = "lblSDTS";
            this.lblSDTS.Size = new System.Drawing.Size(35, 16);
            this.lblSDTS.TabIndex = 26;
            this.lblSDTS.Text = "SDT";
            // 
            // txtDiaChiS
            // 
            this.txtDiaChiS.Location = new System.Drawing.Point(107, 127);
            this.txtDiaChiS.Margin = new System.Windows.Forms.Padding(0);
            this.txtDiaChiS.Name = "txtDiaChiS";
            this.txtDiaChiS.Size = new System.Drawing.Size(591, 22);
            this.txtDiaChiS.TabIndex = 25;
            // 
            // lblDiaChiS
            // 
            this.lblDiaChiS.AutoSize = true;
            this.lblDiaChiS.Location = new System.Drawing.Point(16, 130);
            this.lblDiaChiS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiaChiS.Name = "lblDiaChiS";
            this.lblDiaChiS.Size = new System.Drawing.Size(47, 16);
            this.lblDiaChiS.TabIndex = 24;
            this.lblDiaChiS.Text = "Địa chỉ";
            // 
            // txtTenS
            // 
            this.txtTenS.Location = new System.Drawing.Point(107, 71);
            this.txtTenS.Margin = new System.Windows.Forms.Padding(0);
            this.txtTenS.Name = "txtTenS";
            this.txtTenS.Size = new System.Drawing.Size(203, 22);
            this.txtTenS.TabIndex = 23;
            // 
            // lblTenS
            // 
            this.lblTenS.AutoSize = true;
            this.lblTenS.Location = new System.Drawing.Point(16, 75);
            this.lblTenS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenS.Name = "lblTenS";
            this.lblTenS.Size = new System.Drawing.Size(62, 16);
            this.lblTenS.TabIndex = 22;
            this.lblTenS.Text = "Tên NCC";
            // 
            // lblMaS
            // 
            this.lblMaS.AutoSize = true;
            this.lblMaS.Location = new System.Drawing.Point(16, 27);
            this.lblMaS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaS.Name = "lblMaS";
            this.lblMaS.Size = new System.Drawing.Size(57, 16);
            this.lblMaS.TabIndex = 20;
            this.lblMaS.Text = "Mã NCC";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.Location = new System.Drawing.Point(742, 52);
            this.btnThem.Margin = new System.Windows.Forms.Padding(0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 32);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLuu.Location = new System.Drawing.Point(742, 128);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(0);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(89, 32);
            this.btnLuu.TabIndex = 17;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.Location = new System.Drawing.Point(742, 205);
            this.btnSua.Margin = new System.Windows.Forms.Padding(0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(89, 32);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.Location = new System.Drawing.Point(866, 170);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(89, 32);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHuy.Location = new System.Drawing.Point(866, 97);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(0);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(89, 32);
            this.btnHuy.TabIndex = 20;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDanhSach.Controls.Add(this.dgvSP);
            this.grpDanhSach.Location = new System.Drawing.Point(13, 283);
            this.grpDanhSach.Margin = new System.Windows.Forms.Padding(4);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Padding = new System.Windows.Forms.Padding(4);
            this.grpDanhSach.Size = new System.Drawing.Size(989, 221);
            this.grpDanhSach.TabIndex = 21;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách loại hàng ";
            // 
            // dgvSP
            // 
            this.dgvSP.AllowUserToAddRows = false;
            this.dgvSP.AllowUserToDeleteRows = false;
            this.dgvSP.AllowUserToResizeRows = false;
            this.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSP.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSP.Location = new System.Drawing.Point(4, 19);
            this.dgvSP.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSP.Name = "dgvSP";
            this.dgvSP.RowHeadersVisible = false;
            this.dgvSP.RowHeadersWidth = 51;
            this.dgvSP.RowTemplate.Height = 25;
            this.dgvSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSP.Size = new System.Drawing.Size(981, 198);
            this.dgvSP.TabIndex = 0;
            // 
            // frmLoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 517);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tabContainer);
            this.Name = "frmLoaiHang";
            this.Text = "frmLoaiHang";
            this.tabContainer.ResumeLayout(false);
            this.tpChinhSua.ResumeLayout(false);
            this.tpChinhSua.PerformLayout();
            this.tpTimKiem.ResumeLayout(false);
            this.tpTimKiem.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabContainer;
        private System.Windows.Forms.TabPage tpChinhSua;
        private System.Windows.Forms.TextBox txtTenLoaiHang;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtMaLoaiHang;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TabPage tpTimKiem;
        private System.Windows.Forms.ComboBox cboMaS;
        private System.Windows.Forms.Button btnHienTatCa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtSDTS;
        private System.Windows.Forms.Label lblSDTS;
        private System.Windows.Forms.TextBox txtDiaChiS;
        private System.Windows.Forms.Label lblDiaChiS;
        private System.Windows.Forms.TextBox txtTenS;
        private System.Windows.Forms.Label lblTenS;
        private System.Windows.Forms.Label lblMaS;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvSP;
    }
}