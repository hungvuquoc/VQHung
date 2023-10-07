USE QuanLyWinMart
/*PROCEDURE*/
/*=== Tài Khoản ===*/
--Proc Đăng nhập
GO
CREATE OR ALTER PROCEDURE prDangNhap(@TenDangNhap VARCHAR(255), @MatKhau VARCHAR(255))
AS
BEGIN
	DECLARE @sMaNV VARCHAR(10),
		@sTenNV NVARCHAR(70),
		@sTenLoaiTK NVARCHAR(100),
		@sTenDangNhap VARCHAR(50),
		@sMatKhau VARCHAR(50)

	SELECT @sMaNV = tblNhanVien.sMaNV, @sTenNV = sTenNV, @sTenLoaiTK = sTenLoaiTK,
		   @sTenDangNhap = sTenDangNhap, @sMatKhau = sMatKhau FROM dbo.tblTaiKhoan 
	INNER JOIN dbo.tblLoaiTaiKhoan 
		ON tblLoaiTaiKhoan.sMaLoaiTK = tblTaiKhoan.sMaLoaiTK
	INNER JOIN dbo.tblNhanVien 
		ON tblNhanVien.sMaNV = tblTaiKhoan.sMaNV
	WHERE sTenDangNhap = @TenDangNhap AND
		  bTrangThai = 1

	IF (@sTenDangNhap IS NULL)
	BEGIN
		RAISERROR(N'Tài khoản không tồn tại!',16,10);
	    RETURN
	END
	IF (@sMatKhau <> @MatKhau)
	BEGIN
		RAISERROR(N'Mật khẩu không đúng!',16,10);
	    RETURN
	END
	
	SELECT @sMaNV AS sMaNV, @sTenNV AS sTenNV, @sTenLoaiTK AS sTenLoaiTK
END

-- Kiểm tra
-- Tài khoản không có trong hệ thống
GO
EXEC dbo.prDangNhap @TenDangNhap='userx', -- varchar(50)
    @MatKhau='pass1' -- varchar(50)

-- Tài khoản đúng, sai mật khẩu
GO
EXEC dbo.prDangNhap @TenDangNhap='user1', -- varchar(50)
    @MatKhau='passwordx' -- varchar(50)

-- Tài khoản có trong hệ thống nhưng nhân viên đã nghỉ làm (Trạng thái = 0)
GO
EXEC dbo.prDangNhap @TenDangNhap='user6', -- varchar(50)
    @MatKhau='password6' -- varchar(50)

-- Đăng nhập thành công
GO
EXEC dbo.prDangNhap @TenDangNhap='user1', -- varchar(50)
    @MatKhau='password1' -- varchar(50)