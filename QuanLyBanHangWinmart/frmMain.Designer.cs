namespace QuanLyBanHangWinmart
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHoaDonBan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHoaDonNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHeThong,
            this.tsmiDanhMuc,
            this.tsmiHoaDon,
            this.tsmiThongKe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiHeThong
            // 
            this.tsmiHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem});
            this.tsmiHeThong.Name = "tsmiHeThong";
            this.tsmiHeThong.Size = new System.Drawing.Size(85, 24);
            this.tsmiHeThong.Text = "Hệ thống";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // tsmiDanhMuc
            // 
            this.tsmiDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhânViênToolStripMenuItem,
            this.nhàCungCấpToolStripMenuItem});
            this.tsmiDanhMuc.Name = "tsmiDanhMuc";
            this.tsmiDanhMuc.Size = new System.Drawing.Size(90, 24);
            this.tsmiDanhMuc.Text = "Danh mục";
            // 
            // tsmiHoaDon
            // 
            this.tsmiHoaDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHoaDonBan,
            this.tsmiHoaDonNhap});
            this.tsmiHoaDon.Name = "tsmiHoaDon";
            this.tsmiHoaDon.Size = new System.Drawing.Size(81, 24);
            this.tsmiHoaDon.Text = "Hóa đơn";
            // 
            // tsmiHoaDonBan
            // 
            this.tsmiHoaDonBan.Name = "tsmiHoaDonBan";
            this.tsmiHoaDonBan.Size = new System.Drawing.Size(224, 26);
            this.tsmiHoaDonBan.Text = "Hóa đơn bán";
            // 
            // tsmiHoaDonNhap
            // 
            this.tsmiHoaDonNhap.Name = "tsmiHoaDonNhap";
            this.tsmiHoaDonNhap.Size = new System.Drawing.Size(224, 26);
            this.tsmiHoaDonNhap.Text = "Hóa đơn nhập";
            // 
            // tsmiThongKe
            // 
            this.tsmiThongKe.Name = "tsmiThongKe";
            this.tsmiThongKe.Size = new System.Drawing.Size(84, 24);
            this.tsmiThongKe.Text = "Thống kê";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            // 
            // nhàCungCấpToolStripMenuItem
            // 
            this.nhàCungCấpToolStripMenuItem.Name = "nhàCungCấpToolStripMenuItem";
            this.nhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nhàCungCấpToolStripMenuItem.Text = "Nhà cung cấp";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiHeThong;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem tsmiHoaDon;
        private System.Windows.Forms.ToolStripMenuItem tsmiThongKe;
        private System.Windows.Forms.ToolStripMenuItem tsmiHoaDonBan;
        private System.Windows.Forms.ToolStripMenuItem tsmiHoaDonNhap;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhàCungCấpToolStripMenuItem;
    }
}