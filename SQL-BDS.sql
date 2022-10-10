﻿--TẠO CSDL
CREATE DATABASE data_BDS
GO
USE data_BDS
GO
--Tạo Bảng
CREATE TABLE CHUCVU
(
	MaCV	VARCHAR(5) PRIMARY KEY,
	TenCV	NVARCHAR(20)
)
GO
CREATE TABLE NHANVIEN
(
	MaTK	 VARCHAR(5) PRIMARY KEY,
	MK		 VARCHAR(34) NOT NULL CONSTRAINT CK_MK CHECK (LEN(MK)>9),
	HoTenNV  NVARCHAR(36) NOT NULL,
	MaCV	 VARCHAR(5) CONSTRAINT FK_NV_CV  FOREIGN KEY (MaCV) REFERENCES CHUCVU(MaCV),
	GioiTinh NVARCHAR(4),
	NgaySinh DATE,
	SDT      VARCHAR(15),
	DiaChi   NVARCHAR(50),
	Email    VARCHAR(35)
)
GO
CREATE TABLE KHACHHANG
(
	MaKH	VARCHAR(5) PRIMARY KEY,
	HoTenKH	NVARCHAR(36) NOT NULL,
	SDT		VARCHAR(15) NOT NULL CONSTRAINT UNI_SDTKH UNIQUE,
	DiaChi  NVARCHAR(50),
	Emaill	VARCHAR(35) NOT NULL CONSTRAINT UNI_EMAILKH UNIQUE
)
GO
CREATE TABLE NHUCAU			
(
	MaNC	VARCHAR(5) PRIMARY KEY,
	TenNC	NVARCHAR(15) NOT NULL
)
GO
CREATE TABLE LOAIBDS		
(
	MaLoai	VARCHAR(5) PRIMARY KEY,
	TenLoai	NVARCHAR(20) NOT NULL
)
GO
CREATE TABLE TINHTRANG
(
	MaTT	VARCHAR(5) PRIMARY KEY,
	TenTT	NVARCHAR(20) NOT NULL
)
GO
CREATE TABLE BATDONGSAN
(
    MaBDS  VARCHAR(5) PRIMARY KEY,
	TenBDS NVARCHAR(50),
	MaKH   VARCHAR(5) CONSTRAINT FK_BDS_KH  FOREIGN KEY (MaKH) REFERENCES KHACHHANG(MaKH),
	MaLoai VARCHAR(5) CONSTRAINT FK_BDS_Loai  FOREIGN KEY (MaLoai) REFERENCES LOAIBDS(MaLoai),
	MaTT   VARCHAR(5) CONSTRAINT FK_BDS_TT  FOREIGN KEY (MaTT) REFERENCES TINHTRANG(MaTT),
	DiaChi NVARCHAR(50),
	DienTich BIGINT,
	GioiThieu NVARCHAR(1000),
	HinhAnh VARBINARY(MAX)
)
GO
CREATE TABLE CHITIETNHUCAU
(
	MaNC	VARCHAR(5) CONSTRAINT FK_CT_NC FOREIGN KEY (MaNC) REFERENCES NHUCAU(MaNC),
	MaBDS	VARCHAR(5) CONSTRAINT FK_CT_BDS FOREIGN KEY (MaBDS) REFERENCES BATDONGSAN(MaBDS),
	PRIMARY KEY (MaNC,MaBDS),
	DinhGia BIGINT
)
GO

CREATE TABLE HOPDONG
(
	MaHD	VARCHAR(5) PRIMARY KEY,
	MaNC	VARCHAR(5) CONSTRAINT FK_KD_NC FOREIGN KEY (MaNC) REFERENCES NHUCAU(MaNC),
	MaBDS	VARCHAR(5) CONSTRAINT FK_KD_BDS FOREIGN KEY (MaBDS) REFERENCES BATDONGSAN(MaBDS),
	MaKH	VARCHAR(5) CONSTRAINT FK_KD_KH FOREIGN KEY (MaKH) REFERENCES KHACHHANG(MaKH),
	MaTK	VARCHAR(5) CONSTRAINT FK_KD_TK FOREIGN KEY (MaTK) REFERENCES NHANVIEN(MaTK),
	Phi BIGINT,
	NgayLap DATE,
	ChiTiet NVARCHAR(1000),
	NgayBD	DATE,
	NgayKT	DATE
)
CREATE TABLE THANHTOAN
(
	MATT	VARCHAR(5) PRIMARY KEY,
	MaHD	VARCHAR(5) CONSTRAINT FK_TT_HD FOREIGN KEY (MaHD) REFERENCES HOPDONG(MaHD),
	TongTien	BIGINT CONSTRAINT CK_ST CHECK (TongTien>0),
	NgayTT DATE,
	NoiDung NVARCHAR(255)
)
GO
CREATE PROC P_MACV
AS
BEGIN
DECLARE @MA_NEXT VARCHAR(5)
DECLARE @MAX INT
SELECT @MAX = COUNT(MaCV) FROM CHUCVU WHERE MaCV LIKE 'CV'
SET @MA_NEXT = 'CV' + RIGHT('0'+CAST(@MAX AS VARCHAR(3)),3)
WHILE(EXISTS (SELECT MaCV FROM CHUCVU WHERE MaCV=@MA_NEXT))
BEGIN
	SET @MAX = @MAX+1
	SET @MA_NEXT = 'CV' + RIGHT('0'+CAST(@MAX AS VARCHAR(3)),3)
END
	SELECT @MA_NEXT
END

CREATE PROC P_MAKH
AS
BEGIN
DECLARE @MA_NEXT VARCHAR(5)
DECLARE @MAX INT
SELECT @MAX = COUNT(MaKH) FROM KHACHHANG WHERE MaKH LIKE 'KH'
SET @MA_NEXT = 'KH' + RIGHT('0'+CAST(@MAX AS VARCHAR(3)),3)
WHILE(EXISTS (SELECT MaKH FROM KHACHHANG WHERE MaKH=@MA_NEXT))
BEGIN
	SET @MAX = @MAX+1
	SET @MA_NEXT = 'KH' + RIGHT('0'+CAST(@MAX AS VARCHAR(3)),3)
END
	SELECT @MA_NEXT
END

CREATE PROC P_MATK
AS
BEGIN
DECLARE @MA_NEXT VARCHAR(5)
DECLARE @MAX INT
SELECT @MAX = COUNT(MaTK) FROM NHANVIEN WHERE MaTK LIKE 'TK'
SET @MA_NEXT = 'TK' + RIGHT('0'+CAST(@MAX AS VARCHAR(3)),3)
WHILE(EXISTS (SELECT MaTK FROM NHANVIEN WHERE MaTK=@MA_NEXT))
BEGIN
	SET @MAX = @MAX+1
	SET @MA_NEXT = 'TK' + RIGHT('0'+CAST(@MAX AS VARCHAR(3)),3)
END
	SELECT @MA_NEXT
END

CREATE PROC P_MaNC
AS
BEGIN
DECLARE @MA_NEXT VARCHAR(5)
DECLARE @MAX INT
SELECT @MAX = COUNT(MaNC) FROM NHUCAU WHERE MaNC LIKE 'NC'
SET @MA_NEXT = 'NC' + RIGHT('0'+CAST(@MAX AS VARCHAR(3)),3)
WHILE(EXISTS (SELECT MaNC FROM NHUCAU WHERE MaNC=@MA_NEXT))
BEGIN
	SET @MAX = @MAX+1
	SET @MA_NEXT = 'NC' + RIGHT('0'+CAST(@MAX AS VARCHAR(3)),3)
END
	SELECT @MA_NEXT
END


CREATE PROC P_MaLoai
AS
BEGIN
DECLARE @MA_NEXT VARCHAR(5)
DECLARE @MAX INT
SELECT @MAX = COUNT(MaLoai) FROM LOAIBDS WHERE MaLoai LIKE 'ML'
SET @MA_NEXT = 'ML' + RIGHT('0'+CAST(@MAX AS VARCHAR(3)),3)
WHILE(EXISTS (SELECT MaLoai FROM LOAIBDS WHERE MaLoai=@MA_NEXT))
BEGIN
	SET @MAX = @MAX+1
	SET @MA_NEXT = 'ML' + RIGHT('0'+CAST(@MAX AS VARCHAR(3)),3)
END
	SELECT @MA_NEXT
END

CREATE PROC P_MaTT
AS
BEGIN
DECLARE @MA_NEXT VARCHAR(5)
DECLARE @MAX INT
SELECT @MAX = COUNT(MaTT) FROM TINHTRANG WHERE MaTT LIKE 'TT'
SET @MA_NEXT = 'TT' + RIGHT('0'+CAST(@MAX AS VARCHAR(3)),3)
WHILE(EXISTS (SELECT MaTT FROM TINHTRANG WHERE MaTT=@MA_NEXT))
BEGIN
	SET @MAX = @MAX+1
	SET @MA_NEXT = 'TT' + RIGHT('0'+CAST(@MAX AS VARCHAR(3)),3)
END
	SELECT @MA_NEXT
END

CREATE PROC P_MaBDS 
AS
BEGIN
DECLARE @MA_NEXT VARCHAR(5)
DECLARE @MAX INT
SELECT @MAX = COUNT(MaBDS ) FROM BATDONGSAN WHERE MaBDS  LIKE 'BDS'
SET @MA_NEXT = 'BDS' + RIGHT('0'+CAST(@MAX AS VARCHAR(3)),3)
WHILE(EXISTS (SELECT MaBDS  FROM BATDONGSAN WHERE MaBDS =@MA_NEXT))
BEGIN
	SET @MAX = @MAX+1
	SET @MA_NEXT = 'BDS' + RIGHT('0'+CAST(@MAX AS VARCHAR(3)),3)
END
	SELECT @MA_NEXT
END

CREATE PROC P_MaHD
AS
BEGIN
DECLARE @MA_NEXT VARCHAR(5)
DECLARE @MAX INT
SELECT @MAX = COUNT(MaHD ) FROM HOPDONG WHERE MaHD  LIKE 'HD'
SET @MA_NEXT = 'HD' + RIGHT('0'+CAST(@MAX AS VARCHAR(3)),3)
WHILE(EXISTS (SELECT MaHD  FROM HOPDONG WHERE MaHD =@MA_NEXT))
BEGIN
	SET @MAX = @MAX+1
	SET @MA_NEXT = 'HD' + RIGHT('0'+CAST(@MAX AS VARCHAR(3)),3)
END
	SELECT @MA_NEXT
END

CREATE PROC P_MATToan
AS
BEGIN
DECLARE @MA_NEXT VARCHAR(5)
DECLARE @MAX INT
SELECT @MAX = COUNT(MATT ) FROM THANHTOAN WHERE MATT  LIKE 'THT'
SET @MA_NEXT = 'THT' + RIGHT('0'+CAST(@MAX AS VARCHAR(3)),3)
WHILE(EXISTS (SELECT MATT  FROM THANHTOAN WHERE MATT =@MA_NEXT))
BEGIN
	SET @MAX = @MAX+1
	SET @MA_NEXT = 'THT' + RIGHT('0'+CAST(@MAX AS VARCHAR(3)),3)
END
	SELECT @MA_NEXT
END