-- full
go
CREATE DATABASE QuanLyNhaXe
go
USE QuanLyNhaXe
go
-- Tạo bảng tài xế
CREATE TABLE TaiXe (
    MaTaiXe INT,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE,
    GioiTinh NVARCHAR(10) ,
    DiaChi NVARCHAR(255) ,
    SoDienThoai NVARCHAR(20) NOT NULL,
    TrangThai NVARCHAR(50) ,
    CONSTRAINT PK_TaiXe PRIMARY KEY (MaTaiXe)
);
go
-- Tạo bảng xe
CREATE TABLE Xe (
    MaXe INT,
    BienSoXe NVARCHAR(20) NOT NULL,
    LoaiXe NVARCHAR(50) NOT NULL,
    TrangThai NVARCHAR(50) NOT NULL,
    DoTai FLOAT NOT NULL, 
    KhongGianHamChua NVARCHAR(30) NOT NULL,
    SoGhe INT NOT NULL,
    CONSTRAINT PK_Xe PRIMARY KEY (MaXe)
);
go
-- Tạo bảng lộ trình
CREATE TABLE LoTrinh (
    MaLoTrinh INT,
    TenLoTrinh NVARCHAR(100) NOT NULL,
    DiemXuatPhat NVARCHAR(255) NOT NULL,
    DiemKetThuc NVARCHAR(255) NOT NULL,
    Mota NVARCHAR(MAX),
    TrangThai NVARCHAR(50) NOT NULL,
    CONSTRAINT PK_LoTrinh PRIMARY KEY (MaLoTrinh)
);
go
-- Tạo bảng chuyến đi
CREATE TABLE ChuyenDi (
    MaChuyenDi INT,
    MaLoTrinh INT,
    ThoiDiemXuatPhat DATETIME NOT NULL,
    ThoiDiemKetThuc DATETIME NOT NULL,
    SoGheTrong INT NOT NULL,
    TrangThai NVARCHAR(30),
    CONSTRAINT PK_ChuyenDi PRIMARY KEY (MaChuyenDi),
    CONSTRAINT FK_ChuyenDi_LoTrinh FOREIGN KEY (MaLoTrinh) REFERENCES LoTrinh(MaLoTrinh)
);
go
-- Tạo bảng khách hàng
CREATE TABLE KhachHang (
    MaKhachHang INT,
    HoTen NVARCHAR(100) NOT NULL,
    SoDienThoai NVARCHAR(20) NOT NULL,
    DiaChi NVARCHAR(255),
    CONSTRAINT PK_KhachHang PRIMARY KEY (MaKhachHang)
);
go
-- Tạo bảng hàng hoá gửi
CREATE TABLE HangHoaGui (
    MaHangHoa INT,
    MaKhachHang INT,
    TenHangHoa NVARCHAR(100) NOT NULL,
    LoaiHang NVARCHAR(100) NOT NULL,
    KichThuoc FLOAT NOT NULL,
    KhoiLuong FLOAT NOT NULL,
    TrangThai NVARCHAR(50) NOT NULL,
    MaChuyenDi INT,
    CONSTRAINT PK_HangHoaGui PRIMARY KEY (MaHangHoa),
    CONSTRAINT FK_HangHoaGui_KhachHang FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang),
	CONSTRAINT FK_HangHoaGui_ChuyenDi FOREIGN KEY (MaChuyenDi) REFERENCES ChuyenDi(MaChuyenDi)
);
go
-- Tạo bảng tham gia
CREATE TABLE ThamGia (
    MaKhachHang INT,
    MaChuyenDi INT,
    ChiPhi FLOAT NOT NULL,
	SoGheMua INT,
    CONSTRAINT PK_ThamGia PRIMARY KEY (MaKhachHang, MaChuyenDi),
    CONSTRAINT FK_ThamGia_KhachHang FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang),
    CONSTRAINT FK_ThamGia_ChuyenDi FOREIGN KEY (MaChuyenDi) REFERENCES ChuyenDi(MaChuyenDi)
);
go
-- Tạo bảng khởi hành
CREATE TABLE KhoiHanh (
    MaTaiXe INT,
    MaChuyenDi INT,
    MaXe INT,
    CONSTRAINT PK_KhoiHanh PRIMARY KEY (MaTaiXe, MaChuyenDi, MaXe),
    CONSTRAINT FK_KhoiHanh_TaiXe FOREIGN KEY (MaTaiXe) REFERENCES TaiXe(MaTaiXe),
    CONSTRAINT FK_KhoiHanh_ChuyenDi FOREIGN KEY (MaChuyenDi) REFERENCES ChuyenDi(MaChuyenDi),
    CONSTRAINT FK_KhoiHanh_Xe FOREIGN KEY (MaXe) REFERENCES Xe(MaXe)
);
go
-- Khách hàng
ALTER TABLE KhachHang ADD CONSTRAINT check_SoDienThoai CHECK (SoDienThoai LIKE '0[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]');
-- Chuyến đi
ALTER TABLE ChuyenDi ADD CONSTRAINT CHK_ThoiDiemXuatPhat CHECK (ThoiDiemXuatPhat > GETDATE())
ALTER TABLE ChuyenDi ADD CONSTRAINT CHK_ThoiKiemKetThuc CHECK (ThoiDiemKetThuc > ThoiDiemXuatPhat)
ALTER TABLE ChuyenDi ADD CONSTRAINT CHK_SoGheTrong CHECK (SoGheTrong >= 0 and SoGheTrong <= 40)
ALTER TABLE ChuyenDi ADD CONSTRAINT CHK_TrangThaiChuyenDi CHECK (TrangThai IN (N'Chưa thực hiện', N'Đã thực hiện', N'Đang thực hiện'));
--Hàng hoá gửi
ALTER TABLE HangHoaGui ADD  CONSTRAINT CHK_LoaiHang CHECK (LoaiHang IN (N'Khô', N'Dung dịch', N'Dễ vỡ', N'Cồng kềnh', N'Trái cây', N'Mĩ phẩm', N'Dụng cụ đồ gia dụng', N'Hàng sắt thép, inox', N'Đông lạnh'));
ALTER TABLE HangHoaGui ADD CONSTRAINT CHK_KhoiLuongHang CHECK (KhoiLuong > 0);
ALTER TABLE HangHoaGui ADD CONSTRAINT CHK_KichThuoc CHECk (KichThuoc >0);
ALTER TABLE HangHoaGui ADD CONSTRAINT CHK_TrangThaiHangHoa CHECK (TrangThai IN (N'Chưa gửi', N'Đã gửi', N'Đang gửi'));
--- Check ThamGia
ALTER TABLE ThamGia ADD CONSTRAINT CHK_ChiPhi CHECK (ChiPhi > 0);
ALTER TABLE ThamGia ADD CONSTRAINT CHK_SoGheMua CHECK (SoGheMua >=0);
--LỘ TRÌNH
ALTER TABLE LoTrinh ADD CONSTRAINT CK_TrangThaiLoTinh CHECK (TrangThai IN (N'Chưa kiểm duyệt', N'Đã kiểm duyệt'));
--TABLE TÀI XẾ
ALTER TABLE TaiXe ADD CONSTRAINT CK_Tuoi CHECK (DATEDIFF(YEAR, NgaySinh, GETDATE()) > 18);
ALTER TABLE TaiXe ADD CONSTRAINT CK_GioiTinh CHECK (GioiTinh = N'Nam');
ALTER TABLE TaiXe ADD CONSTRAINT CK_SoDienThoai CHECK (SoDienThoai LIKE '0[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]');
ALTER TABLE TaiXe ADD CONSTRAINT CK_TrangThaiTaiXe CHECK (TrangThai IN (N'Đang chạy', N'Đang nghỉ phép', N'Đã tham gia', N'Chưa tham gia'));
-- Xe
ALTER TABLE Xe ADD CONSTRAINT Check_DoTai CHECK (DoTai > 0 AND DoTai <= 1500) --kg
ALTER TABLE Xe ADD CONSTRAINT Check_SoGhe CHECK (SoGhe > 0 AND SoGhe <= 40)
ALTER TABLE Xe ADD CONSTRAINT Check_KhongGianHamChua CHECK (KhongGianHamChua > 0 AND KhongGianHamChua <= 6.5) --m^3
ALTER TABLE Xe ADD CONSTRAINT CK_TrangThaiXe CHECK (TrangThai IN (N'Đang chạy', N'Đang bảo dưỡng', N'Đã tham gia', N'Chưa tham gia'));



go
-- View Khách hàng
CREATE VIEW view_XemKhach
AS
	SELECT ThamGia.MaChuyenDi, ThamGia.MaKhachHang, KhachHang.HoTen, KhachHang.SoDienThoai,  ThamGia.SoGheMua, ThamGia.ChiPhi
	FROM ThamGia JOIN KhachHang  ON ThamGia.MaKhachHang =	KhachHang.MaKhachHang;
go
-- View chuyến đi 
CREATE VIEW View_ChuyenDi AS
SELECT 
    cd.MaChuyenDi,
    cd.MaLoTrinh,
	kh.MaTaiXe,
	xe.MaXe,
    cd.ThoiDiemXuatPhat,
    cd.ThoiDiemKetThuc,
    cd.SoGheTrong,
    cd.TrangThai,
    tx.HoTen AS TenTaiXe,
    lt.TenLoTrinh,
    xe.BienSoXe
FROM 
    ChuyenDi cd
LEFT JOIN 
    KhoiHanh kh ON cd.MaChuyenDi = kh.MaChuyenDi
LEFT JOIN 
    Xe xe ON kh.MaXe = xe.MaXe
LEFT JOIN 
    TaiXe tx ON kh.MaTaiXe = tx.MaTaiXe
LEFT JOIN 
    LoTrinh lt ON cd.MaLoTrinh = lt.MaLoTrinh;
go
-- Trigger check null
CREATE TRIGGER CheckNullValues ON KhachHang AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM inserted
        WHERE MaKhachHang = '' OR HoTen = '' OR SoDienThoai = '' OR DiaChi = ''
    )
    BEGIN
        RAISERROR ('Không được phép thêm hoặc cập nhật dữ liệu với các giá trị null.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;
go
-- Kiểm tra bắt lỗi thêm, sửa tài xế
CREATE TRIGGER trg_CheckTaiXe ON TaiXe FOR INSERT, UPDATE
AS
BEGIN
	IF EXISTS (SELECT * FROM inserted WHERE TRIM(HoTen) = '')
	BEGIN
		RAISERROR (N'Không được để họ tên trống.',16,1);
		ROLLBACK TRANSACTION;
		RETURN;
	END
	IF EXISTS (SELECT * FROM inserted WHERE TRIM(SoDienThoai) = '')
	BEGIN
		RAISERROR (N'Không được để trống số điện thoại tài xế.',16,1);
		ROLLBACK TRANSACTION;
		RETURN;
	END
	IF EXISTS (SELECT * FROM inserted WHERE TRIM(DiaChi) = '')
	BEGIN
		RAISERROR (N'Không được để trống địa chỉ tài xế.',16,1);
		ROLLBACK TRANSACTION;
		RETURN;
	END
END
go
--trigger trùng số điện thoại khách hàng
CREATE TRIGGER trg_TrungSoDienThoaiKhachHang ON dbo.KhachHang AFTER insert,update
AS
BEGIN
	IF EXISTS (
		SELECT * 
		FROM inserted i 
		WHERE EXISTS ( 
			SELECT * 
			FROM KhachHang WHERE KhachHang.SoDienThoai = i.SoDienThoai AND KhachHang.MaKhachHang <> i.MaKhachHang
			)
	)
	BEGIN 
		ROLLBACK
		PRINT N'Số điện thoại này đã tồn tại.'
	END
END;
go
--trigger kiểm tra xe

go
--kiểm tra trùng số diện thoại tài xế
CREATE TRIGGER trg_TrungSoDienThoaiTaiXe ON dbo.TaiXe AFTER insert,update
AS
BEGIN
	IF EXISTS (
		SELECT * 
		FROM inserted i 
		WHERE EXISTS ( 
			SELECT * 
			FROM TaiXe WHERE TaiXe.SoDienThoai = i.SoDienThoai AND TaiXe.MaTaiXe <> i.MaTaiXe
			)
	)
	BEGIN 
		ROLLBACK
		PRINT N'Số điện thoại này đã tồn tại.'
	END
END;
go
-- Kiểm tra bắt lỗi số ghế trống tính bị âm
CREATE TRIGGER trg_CheckSoGheTrongAm
ON ChuyenDi
FOR INSERT, UPDATE
AS
BEGIN
	IF EXISTS (SELECT * FROM inserted WHERE SoGheTrong < 0)
	BEGIN
		RAISERROR (N'Không được để số ghế trống bị âm.',16,1)
		ROLLBACK TRANSACTION
		RETURN
	END
END
go
-- Kiểm tra khởi hành
CREATE TRIGGER trg_KiemTraKhoiHanh 
ON KhoiHanh
AFTER INSERT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        IF EXISTS (
            SELECT 1
            FROM inserted i
            INNER JOIN TaiXe ON i.MaTaiXe = TaiXe.MaTaiXe
            INNER JOIN Xe ON i.MaXe = Xe.MaXe
            WHERE TaiXe.TrangThai <> N'Chưa tham gia' OR Xe.TrangThai <> N'Chưa tham gia'
        )
        BEGIN
            RAISERROR(N'Không thể thêm tài xế và xe.', 16, 1);
            ROLLBACK TRANSACTION;
        END

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        THROW;
    END CATCH;
END
go
-- Cập nhật tình trạng tài xế và xe theo chuyến đi
CREATE TRIGGER CapNhatTaiXeVaXe
ON ChuyenDi
AFTER UPDATE
AS
BEGIN
    -- Kiểm tra xem trường TrangThai đã được cập nhật
    IF UPDATE(TrangThai)
    BEGIN
        -- Lấy các giá trị mới của trường TrangThai và các giá trị cũ của bảng ChuyenDi
        DECLARE @NewTrangThai NVARCHAR(30), @OldTrangThai NVARCHAR(30);
        SELECT @NewTrangThai = i.TrangThai, @OldTrangThai = d.TrangThai
        FROM inserted i
        INNER JOIN deleted d ON i.MaChuyenDi = d.MaChuyenDi;

        IF @NewTrangThai = N'Đang thực hiện' AND @OldTrangThai != N'Đang thực hiện'
        BEGIN
            -- Trạng thái chuyến đi đã được thay đổi thành 'Đang thực hiện'
            -- Cập nhật trạng thái của tài xế và xe là 'Đang chạy'
            UPDATE TaiXe
            SET TrangThai = N'Đang chạy'
            WHERE MaTaiXe IN (SELECT MaTaiXe FROM KhoiHanh WHERE MaChuyenDi = (SELECT MaChuyenDi FROM inserted));

            UPDATE Xe
            SET TrangThai = N'Đang chạy'
            WHERE MaXe IN (SELECT MaXe FROM KhoiHanh WHERE MaChuyenDi = (SELECT MaChuyenDi FROM inserted));
        END
        ELSE IF @NewTrangThai = N'Đã thực hiện' AND @OldTrangThai != N'Đã thực hiện'
        BEGIN
            -- Trạng thái chuyến đi đã được thay đổi thành 'Đã thực hiện'
            -- Cập nhật trạng thái của tài xế và xe là 'Chưa tham gia'
            UPDATE TaiXe
            SET TrangThai = N'Chưa tham gia'
            WHERE MaTaiXe IN (SELECT MaTaiXe FROM KhoiHanh WHERE MaChuyenDi = (SELECT MaChuyenDi FROM inserted));

            UPDATE Xe
            SET TrangThai = N'Chưa tham gia'
            WHERE MaXe IN (SELECT MaXe FROM KhoiHanh WHERE MaChuyenDi = (SELECT MaChuyenDi FROM inserted));
        END
		 ELSE IF @NewTrangThai = N'Chưa thực hiện' AND @OldTrangThai != N'Chưa thực hiện'
        BEGIN
            -- Trạng thái chuyến đi đã được thay đổi thành 'Chưa thực hiện'
            -- Cập nhật trạng thái của tài xế và xe là 'Đã tham gia'
            UPDATE TaiXe
            SET TrangThai = N'Đã tham gia'
            WHERE MaTaiXe IN (SELECT MaTaiXe FROM KhoiHanh WHERE MaChuyenDi = (SELECT MaChuyenDi FROM inserted));

            UPDATE Xe
            SET TrangThai = N'Đã tham gia'
            WHERE MaXe IN (SELECT MaXe FROM KhoiHanh WHERE MaChuyenDi = (SELECT MaChuyenDi FROM inserted));
        END
    END
END;
go
-- không cho cập nhật trạng thái chuyến đi
CREATE TRIGGER trg_KhongSuaChuyenDi ON ChuyenDi AFTER UPDATE
AS
BEGIN
	IF UPDATE(TrangThai)
	BEGIN
		IF EXISTS (
			SELECT 1
			FROM inserted i
			INNER JOiN deleted d ON i.MaChuyenDi = d.MaChuyenDi
			INNER JOIN ChuyenDi ON ChuyenDi.MaChuyenDi = i.MaChuyenDi
			WHERE i.TrangThai = N'Đang thực hiện' OR i.TrangThai = N'Đã thực hiện'
			AND i.ThoiDiemXuatPhat > GETDATE()
		)
		BEGIN
			RAISERROR(N'Không thể cập nhật trạng thái chuyến đi khi chưa tới ngày.', 16,1);
		END
	END
END
go
-- function tính chi phí
create function tinhChiPhi
(
	@SoGheMua INT, 
	@LoaiHang NVARCHAR(100),
   	@KichThuoc FLOAT,
   	@KhoiLuong FLOAT
)
returns FLOAT
as
begin
	DECLARE @GiaVe FLOAT;
	DECLARE @HeSo FLOAT;
	DECLARE @GiaHang FLOAT;

	SET @GiaVe = @SoGheMua * 1000;
	IF @LoaiHang = N'Khô'
        	SET @HeSo = 1;
	ELSE IF @LoaiHang = N'Ướt'
		SET @HeSo = 2;
	ELSE IF @LoaiHang = N'Dễ vỡ'
		SET @HeSo = 3;
	ELSE SET @HeSo = 4;
	SET @GiaHang = @HeSo *15 + @KhoiLuong *10 + @KichThuoc *10;
	return @GiaVe + @GiaHang  
end
go
--Them tài xế
CREATE PROCEDURE ThemTaiXe
	@MaTaiXe INT,
    @HoTen NVARCHAR(100),
    @NgaySinh DATE,
    @GioiTinh NVARCHAR(10),
    @DiaChi NVARCHAR(255),
    @SoDienThoai NVARCHAR(20),
    @TrangThai NVARCHAR(50)
AS
BEGIN
	IF EXISTS (SELECT 1 FROM TaiXe WHERE TaiXe.MaTaiXe = @MaTaiXe)
	BEGIN
		PRINT N'Tài xế đã tồn tại.'
		RETURN;
	END
	
	INSERT INTO TaiXe(MaTaiXe,HoTen,NgaySinh,GioiTinh,DiaChi,SoDienThoai,TrangThai)
	VALUES(@MaTaiXe,@HoTen,@NgaySinh,@GioiTinh,@DiaChi,@SoDienThoai,@TrangThai);
END;
go
-- Xóa tài xế
CREATE PROCEDURE XoaTaiXe
@MaTaiXe INT
AS
BEGIN
		DELETE FROM TaiXe WHERE MaTaiXe = @MaTaiXe
END
go
-- Sửa tài xế
CREATE PROCEDURE SuaTaiXe (@MaTaiXe INT, @HoTen NVARCHAR(100), @NgaySinh date, @GioiTinh NVARCHAR(10), @DiaChi NVARCHAR(255), @SoDienThoai NVARCHAR(20), @TrangThai NVARCHAR(50))
AS
BEGIN
		UPDATE TaiXe
		SET HoTen = @HoTen,
			NgaySinh = @NgaySinh,
			GioiTinh = @GioiTinh,
			DiaChi = @DiaChi,
			SoDienThoai = @SoDienThoai,
			TrangThai = @TrangThai
		WHERE MaTaiXe = @MaTaiXe
END
go
-- Thêm Lộ trình 
CREATE PROCEDURE ThemLoTrinh
	@MaLoTrinh INT,
    @TenLoTrinh NVARCHAR(100),
    @DiemXuatPhat NVARCHAR(255),
    @DiemKetThuc NVARCHAR(255),
    @Mota NVARCHAR(MAX),
	@TrangThai NVARCHAR(50)
AS
BEGIN
	IF EXISTS (SELECT 1 FROM LoTrinh WHERE LoTrinh.MaLoTrinh = @MaLoTrinh)
	BEGIN
		PRINT N'Lộ trình đã tồn tại.'
		RETURN;
	END
	
	INSERT INTO LoTrinh(MaLoTrinh,TenLoTrinh,DiemXuatPhat,DiemKetThuc,Mota,TrangThai)
	VALUES(@MaLoTrinh,@TenLoTrinh,@DiemXuatPhat,@DiemKetThuc,@Mota,@TrangThai);
		
END;
go
-- Xoá lộ trình
CREATE PROCEDURE XoaLoTrinh
    @MaLoTrinh INT
AS
BEGIN
    DELETE FROM LoTrinh
    WHERE MaLoTrinh = @MaLoTrinh
END;
go
-- Sửa lộ trình
CREATE PROCEDURE SuaLoTrinh @MaLoTrinh INT, @TenLoTrinh NVARCHAR(100), @DiemXuatPhat NVARCHAR(255), @DiemKetThuc NVARCHAR(255), @Mota NVARCHAR(MAX),@TrangThai NVARCHAR(50)
AS
BEGIN
    UPDATE LoTrinh
    SET TenLoTrinh = @TenLoTrinh,
        DiemXuatPhat = @DiemXuatPhat,
        DiemKetThuc = @DiemKetThuc,
        Mota = @Mota,
		TrangThai = @TrangThai
    WHERE MaLoTrinh = @MaLoTrinh
END;
go
-- lấy hàng hóa
CREATE PROCEDURE LayHangHoa
AS
BEGIN
    SELECT * FROM HangHoaGui;
END
go
-- xóa hàng hóa
CREATE PROCEDURE XoaHangHoa
    @MaHangHoa INT
AS
BEGIN
    DELETE FROM HangHoaGui WHERE MaHangHoa = @MaHangHoa;
END
go
-- cập nhật hàng hóa
CREATE PROCEDURE SuaHangHoa
    @MaHangHoa INT,
    @LoaiHang NVARCHAR(50),
    @KichThuoc FLOAT,
    @KhoiLuong FLOAT,
	@TenMatHang NVARCHAR(100),
	@TrangThai NVARCHAR(100)
AS
BEGIN
    UPDATE HangHoaGui 
    SET LoaiHang = @LoaiHang, KichThuoc = @KichThuoc, KhoiLuong = @KhoiLuong, TenHangHoa = @TenMatHang, TrangThai = @TrangThai
    WHERE MaHangHoa = @MaHangHoa;
END
go
-- Thêm khách hàng
CREATE PROCEDURE ThemKhachHang
    @MaKhachHang INT,
    @HoTen NVARCHAR(100),
    @SoDienThoai NVARCHAR(20),
    @DiaChi NVARCHAR(255)
AS
BEGIN
    INSERT INTO KhachHang (MaKhachHang, HoTen, SoDienThoai, DiaChi)
    VALUES (@MaKhachHang, @HoTen, @SoDienThoai, @DiaChi);
END;
go
-- Sửa khách hàng
CREATE PROCEDURE SuaKhachHang
    @MaKhachHang INT,
    @MaKhachHangMoi INT,
    @HoTen NVARCHAR(100),
    @SoDienThoai NVARCHAR(20),
    @DiaChi NVARCHAR(255)
AS
BEGIN
    UPDATE KhachHang
    SET MaKhachHang = @MaKhachHangMoi,
        HoTen = @HoTen,
        SoDienThoai = @SoDienThoai,
        DiaChi = @DiaChi
    WHERE MaKhachHang = @MaKhachHang;
END;
go
-- Xoá khách hàng
CREATE PROCEDURE XoaKhachHang
    @MaKhachHang INT
AS
BEGIN
    DELETE FROM KhachHang
    WHERE MaKhachHang = @MaKhachHang;
END;
go
-- Đặt vé
CREATE PROCEDURE TinhTongChiPhiCoHang
    @MaChuyenDi INT,
    @MaKhachHang INT,
    @SoGheMua INT,
    @TenHangHoa NVARCHAR(100),
    @LoaiHang NVARCHAR(100),
    @KichThuoc FLOAT,
    @KhoiLuong FLOAT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @TongChiPhi FLOAT;
    DECLARE @MaHangHoa INT;

    -- Tính tổng chi phí
    SET @TongChiPhi = dbo.tinhChiPhi(@SoGheMua, @LoaiHang, @KichThuoc, @KhoiLuong);

    -- Lấy mã hàng hóa tiếp theo
    SELECT @MaHangHoa = ISNULL(MAX(MaHangHoa), 0) + 1 FROM HangHoaGui;

    -- Bắt đầu transaction
    BEGIN TRANSACTION;

    -- Thêm thông tin đặt vé vào bảng ThamGia
    INSERT INTO ThamGia (MaKhachHang, MaChuyenDi, ChiPhi, SoGheMua)
    VALUES (@MaKhachHang, @MaChuyenDi, @TongChiPhi, @SoGheMua);

    -- Kiểm tra xem INSERT đã thành công hay không
    IF @@ERROR <> 0
    BEGIN
        ROLLBACK TRANSACTION;
        PRINT 'Xảy ra lỗi khi thêm thông tin đặt vé. Transaction đã được rollback.';
        RETURN;
    END;

    -- Cập nhật số ghế trống trong bảng ChuyenDi
    UPDATE ChuyenDi
    SET SoGheTrong = SoGheTrong - @SoGheMua
    WHERE MaChuyenDi = @MaChuyenDi;

    -- Kiểm tra xem UPDATE đã thành công hay không
    IF @@ERROR <> 0
    BEGIN
        ROLLBACK TRANSACTION;
        PRINT 'Xảy ra lỗi khi cập nhật số ghế trống. Transaction đã được rollback.';
        RETURN;
    END;

    -- Thêm thông tin hàng hóa vào bảng HangHoa
    INSERT INTO HangHoaGui (MaHangHoa, MaKhachHang, LoaiHang, TenHangHoa, KichThuoc, KhoiLuong, MaChuyenDi, TrangThai)
    VALUES (@MaHangHoa, @MaKhachHang, @LoaiHang, @TenHangHoa, @KichThuoc, @KhoiLuong, @MaChuyenDi, N'Chưa gửi');

    -- Kiểm tra xem INSERT đã thành công hay không
    IF @@ERROR <> 0
    BEGIN
        ROLLBACK TRANSACTION;
        PRINT 'Xảy ra lỗi khi thêm thông tin hàng hóa. Transaction đã được rollback.';
        RETURN;
    END;

    -- Nếu không có lỗi, commit transaction
    COMMIT TRANSACTION;
    PRINT 'Tính tổng chi phí và đặt vé thành công!';
END;
go
CREATE PROCEDURE TinhTongChiPhiKhongHang
    @MaChuyenDi INT,
    @MaKhachHang INT,
    @SoGheMua INT
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @GiaVe FLOAT;
    DECLARE @TongChiPhi FLOAT;
    -- Tính chi phí vé
    SET @GiaVe = @SoGheMua * 1000; -- Giá vé mỗi ghế là 2000k
    -- Tính tổng chi phí
    SET @TongChiPhi = @GiaVe;
    -- Thêm thông tin đặt vé vào bảng ThamGia
    INSERT INTO ThamGia (MaKhachHang, MaChuyenDi, ChiPhi, SoGheMua)
    VALUES (@MaKhachHang, @MaChuyenDi, @TongChiPhi, @SoGheMua);
    -- Cập nhật số ghế trống trong bảng ChuyenDi
    UPDATE ChuyenDi
    SET SoGheTrong = SoGheTrong - @SoGheMua
    WHERE MaChuyenDi = @MaChuyenDi;
    PRINT 'Tính tổng chi phí và đặt vé thành công!';
END
go
-- xóa vé
go
CREATE PROCEDURE XoaThongTinDatVe
    @MaChuyenDi INT,
    @MaKhachHang INT
AS
BEGIN
    DELETE FROM ThamGia
    WHERE MaChuyenDi = @MaChuyenDi AND MaKhachHang = @MaKhachHang;
END
go
-- thêm chuyến đi
CREATE PROCEDURE ThemChuyenDi
    @MaChuyenDi INT,
    @MaLoTrinh INT,
    @ThoiDiemXuatPhat DATETIME,
    @ThoiDiemKetThuc DATETIME,
    @SoGheTrong INT,
    @TrangThai NVARCHAR(30),
    @MaXe INT,
    @MaTaiXe INT
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Kiểm tra xem lộ trình có ở trạng thái đã kiểm duyệt không
        DECLARE @TrangThaiLoTrinh NVARCHAR(50);
        SELECT @TrangThaiLoTrinh = TrangThai FROM LoTrinh WHERE MaLoTrinh = @MaLoTrinh;
        
        IF @TrangThaiLoTrinh = N'Đã kiểm duyệt'
        BEGIN
             --Thêm chuyến đi vào bảng ChuyenDi
            INSERT INTO ChuyenDi (MaChuyenDi, MaLoTrinh, ThoiDiemXuatPhat, ThoiDiemKetThuc, SoGheTrong, TrangThai)
            VALUES (@MaChuyenDi, @MaLoTrinh, @ThoiDiemXuatPhat, @ThoiDiemKetThuc, @SoGheTrong, @TrangThai);
            --Thêm thông tin vào bảng KhoiHanh
            INSERT INTO KhoiHanh (MaTaiXe, MaChuyenDi, MaXe)
            VALUES (@MaTaiXe, @MaChuyenDi, @MaXe);
			--Cập nhật trạng thái của tài xế
            UPDATE TaiXe SET TrangThai = N'Đã tham gia' WHERE MaTaiXe = @MaTaiXe;
            --Cập nhật trạng thái của xe
            UPDATE Xe SET TrangThai = N'Đã tham gia' WHERE MaXe = @MaXe;
            COMMIT TRANSACTION;
        END
        ELSE
        BEGIN
            -- Lộ trình chưa kiểm duyệt, không thể thêm chuyến đi
            ROLLBACK TRANSACTION;
            THROW 51000, 'Không thể thêm chuyến đi vì lộ trình chưa được kiểm duyệt.', 1;
        END;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END;
go
-- Xoá chuyến đi 
CREATE PROCEDURE XoaChuyenDi
    @MaChuyenDi INT
AS
BEGIN
    DELETE FROM ThamGia WHERE MaChuyenDi = @MaChuyenDi;
    DELETE FROM HangHoaGui WHERE MaChuyenDi = @MaChuyenDi;
    DELETE FROM KhoiHanh WHERE MaChuyenDi = @MaChuyenDi;
    DELETE FROM ChuyenDi WHERE MaChuyenDi = @MaChuyenDi;
END;
go
-- Sửa chuyến đi
CREATE PROCEDURE SuaChuyenDi
    @MaChuyenDi INT,
    @MaLoTrinh INT,
    @ThoiDiemXuatPhat DATETIME,
    @ThoiDiemKetThuc DATETIME,
    @SoGheTrong INT,
    @TrangThai NVARCHAR(30),
    @MaXe INT,
    @MaTaiXe INT
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Kiểm tra xem chuyến đi tồn tại hay không
        IF EXISTS (SELECT 1 FROM ChuyenDi WHERE MaChuyenDi = @MaChuyenDi)
        BEGIN
            -- Kiểm tra xem lộ trình có ở trạng thái đã kiểm duyệt không
            DECLARE @TrangThaiLoTrinh NVARCHAR(50);
            SELECT @TrangThaiLoTrinh = TrangThai FROM LoTrinh WHERE MaLoTrinh = @MaLoTrinh;

            IF @TrangThaiLoTrinh = N'Đã kiểm duyệt'
            BEGIN
                -- Lộ trình đã kiểm duyệt, có thể cập nhật chuyến đi
                UPDATE ChuyenDi
                SET MaLoTrinh = @MaLoTrinh,
                    ThoiDiemXuatPhat = @ThoiDiemXuatPhat,
                    ThoiDiemKetThuc = @ThoiDiemKetThuc,
                    SoGheTrong = @SoGheTrong,
                    TrangThai = @TrangThai
                WHERE MaChuyenDi = @MaChuyenDi;

                -- Cập nhật thông tin trong bảng KhoiHanh
                UPDATE KhoiHanh
                SET MaTaiXe = @MaTaiXe,
                    MaXe = @MaXe
                WHERE MaChuyenDi = @MaChuyenDi;

                COMMIT TRANSACTION;
            END
            ELSE
            BEGIN
                -- Lộ trình chưa kiểm duyệt, không thể cập nhật chuyến đi
                ROLLBACK TRANSACTION;
                THROW 51000, 'Không thể cập nhật chuyến đi vì lộ trình chưa được kiểm duyệt.', 1;
            END;
        END
        ELSE
        BEGIN
            -- Chuyến đi không tồn tại
            ROLLBACK TRANSACTION;
            THROW 50000, 'Chuyến đi không tồn tại.', 1;
        END;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END;


go
--Thêm Xe
CREATE PROCEDURE ThemXe
	@MaXe INT,
    @BienSoXe NVARCHAR(20),
    @LoaiXe NVARCHAR(50) ,
    @TrangThai NVARCHAR(50) ,
	@DoTai FLOAT, 
	@KhongGianHamChua NVARCHAR(30) ,
	@SoGhe INT 
AS
BEGIN
	INSERT INTO Xe(MaXe,BienSoXe,LoaiXe,TrangThai,DoTai,KhongGianHamChua,SoGhe)
	VALUES(@MaXe,@BienSoXe,@LoaiXe,@TrangThai,@DoTai,@KhongGianHamChua,@SoGhe);
END;
go
--Xoa Xe
CREATE PROCEDURE XoaXe
	@MaXe INT
AS
BEGIN
	DELETE FROM Xe WHERE MaXe = @MaXe;
END;
go
-- Sua Xe
CREATE PROCEDURE SuaXe (@MaXe INT, @BienSoXe NVARCHAR(20), @LoaiXe NVARCHAR(50), @TrangThai NVARCHAR(50), @DoTai FLOAT, @KhongGianHamChua NVARCHAR(30), @SoGhe INT)
AS
BEGIN
		UPDATE Xe
		SET BienSoXe = @BienSoXe,
			LoaiXe = @LoaiXe,
			TrangThai = @TrangThai,
			DoTai = @DoTai,
			KhongGianHamChua = @KhongGianHamChua,
			SoGhe = @SoGhe
		WHERE MaXe = @MaXe
END

CREATE TRIGGER trg_CheckXe ON Xe FOR INSERT, UPDATE
AS
BEGIN
	IF EXISTS ( SELECT * FROM inserted WHERE TRIM(LoaiXe) = '')
	BEGIN
		RAISERROR(N'Loại xe không được để trống.',16,1)
		ROLLBACK TRANSACTION
		RETURN
	END

	IF EXISTS ( SELECT * FROM inserted WHERE TRIM(BienSoXe) = '')
	BEGIN
		RAISERROR(N'Biển số xe không được để trống.',16,1)
		ROLLBACK TRANSACTION
		RETURN
	END

	IF EXISTS ( SELECT * FROM inserted WHERE TRIM(KhongGianHamChua) <= 0 )
	BEGIN
		RAISERROR(N'Không gian hầm chứa của xe không được bé hơn 0',16,1)
		ROLLBACK TRANSACTION
		RETURN
	END
END

CREATE TRIGGER trg_TrungMaXe ON Xe FOR INSERT, UPDATE
AS
BEGIN
	IF EXISTS (
		SELECT 1
		FROM Xe
		INNER JOIN inserted i ON i.MaXe = Xe.MaXe
		GROUP BY i.MaXe
		HAVING COUNT(*) > 1
		)
	BEGIN
		RAISERROR (N'Mã xe đã tồn tại.',16,1);
		ROLLBACK
	END
END


CREATE TRIGGER trg_TrungBienSoXe ON Xe FOR INSERT, UPDATE
AS
BEGIN
	SELECT 1
	FROM Xe
	INNER JOIN inserted i ON i.BienSoXe = Xe.BienSoXe
	GROUP BY i.BienSoXe
END