CREATE DATABASE KingdomFitness;
GO

USE KingdomFitness;
GO

CREATE TABLE TaiKhoan (
    TenDangNhap VARCHAR(50) PRIMARY KEY,
    MatKhau VARCHAR(100) NOT NULL
);

CREATE TABLE HoiVien (
    MaHV INT IDENTITY(1,1) PRIMARY KEY,
    TenHV NVARCHAR(100) NOT NULL,
    SoDienThoai VARCHAR(15),
    GioiTinh NVARCHAR(10),
    NgayDangKy DATE DEFAULT GETDATE()
);

CREATE TABLE PT (
    MaPT INT IDENTITY(1,1) PRIMARY KEY,
    TenPT NVARCHAR(100) NOT NULL,
    SoDienThoai VARCHAR(15)
);

CREATE TABLE GoiTap (
    MaGoi INT IDENTITY(1,1) PRIMARY KEY,
    TenGoi NVARCHAR(100) NOT NULL,
    GiaTien DECIMAL(18,0) NOT NULL,
    SoThang INT NOT NULL
);

CREATE TABLE HoaDonThanhToan (
    MaHD INT IDENTITY(1,1) PRIMARY KEY,
    NgayLap DATE DEFAULT GETDATE(),
    MaHV INT NOT NULL,           
    MaGoi INT NOT NULL,          
    MaPT INT NULL,               
    NgayBatDau DATE NOT NULL,    
    NgayHetHan DATE NOT NULL,    
    TongTien DECIMAL(18,0) NOT NULL,
    
    FOREIGN KEY (MaHV) REFERENCES HoiVien(MaHV),
    FOREIGN KEY (MaGoi) REFERENCES GoiTap(MaGoi),
    FOREIGN KEY (MaPT) REFERENCES PT(MaPT)
);
GO

INSERT INTO TaiKhoan (TenDangNhap, MatKhau)
VALUES
('admin', '123456');

INSERT INTO HoiVien (TenHV, SoDienThoai, GioiTinh, NgayDangKy)
VALUES 
(N'Trịnh Anh Khoa', '123456789', N'Nam', GETDATE()),
(N'Lê Thị Ngọc Hân', '123456798', N'Nữ', GETDATE());

INSERT INTO PT (TenPT, SoDienThoai)
VALUES 
(N'Lý Bì Bạch', '0911222333'),
(N'Phạm Bí Đao', '0944555666');

INSERT INTO GoiTap (TenGoi, GiaTien, SoThang)
VALUES 
(N'Gói Tân Binh 1 Tháng', 500000, 1),
(N'Gói VIP Tiểu Vương Quốc 1 Năm', 5000000, 12);

INSERT INTO HoaDonThanhToan (NgayLap, MaHV, MaGoi, MaPT, NgayBatDau, NgayHetHan, TongTien)
VALUES 
(GETDATE(), 1, 2, 1, '2026-03-15', '2027-03-15', 5000000),
(GETDATE(), 2, 1, NULL, '2026-03-15', '2026-04-15', 500000);