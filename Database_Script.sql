-- =============================================
-- Script t?o b?ng và d? li?u m?u cho h? th?ng Qu?n Lý Bán Hoa
-- Database: quanlybanhoa
-- =============================================

-- T?o database (n?u ch?a có)
CREATE DATABASE IF NOT EXISTS quanlybanhoa CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE quanlybanhoa;

-- =============================================
-- B?ng: hoa (Qu?n lý thông tin hoa)
-- =============================================
CREATE TABLE IF NOT EXISTS hoa (
    MaHoa INT AUTO_INCREMENT PRIMARY KEY,
    TenHoa VARCHAR(100) NOT NULL,
    Gia DECIMAL(18, 2) NOT NULL,
    SoLuong INT NOT NULL DEFAULT 0,
    MoTa TEXT NULL,
    CONSTRAINT CHK_Gia CHECK (Gia > 0),
    CONSTRAINT CHK_SoLuong CHECK (SoLuong >= 0)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- B?ng: khachhang (Qu?n lý thông tin khách hàng)
-- =============================================
CREATE TABLE IF NOT EXISTS khachhang (
    MaKH INT AUTO_INCREMENT PRIMARY KEY,
    TenKH VARCHAR(100) NOT NULL,
    DiaChi VARCHAR(200) NULL,
    SoDienThoai VARCHAR(15) NULL,
    Email VARCHAR(100) NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- B?ng: nhanvien (Qu?n lý thông tin nhân viên)
-- =============================================
CREATE TABLE IF NOT EXISTS nhanvien (
    MaNV INT AUTO_INCREMENT PRIMARY KEY,
    TenNV VARCHAR(100) NOT NULL,
    ChucVu VARCHAR(50) NULL,
    SoDienThoai VARCHAR(15) NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- B?ng: khuyenmai (Qu?n lý các ch??ng trình khuy?n mãi)
-- =============================================
CREATE TABLE IF NOT EXISTS khuyenmai (
    MaKM INT AUTO_INCREMENT PRIMARY KEY,
    TenCT VARCHAR(100) NOT NULL,
    TyLeGiam DECIMAL(5, 2) NOT NULL,
    NgayBD DATE NOT NULL,
    NgayKT DATE NOT NULL,
    CONSTRAINT CHK_TyLeGiam CHECK (TyLeGiam >= 0 AND TyLeGiam <= 100)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- B?ng: donhang (Qu?n lý ??n hàng)
-- =============================================
CREATE TABLE IF NOT EXISTS donhang (
    MaDH INT AUTO_INCREMENT PRIMARY KEY,
    MaKH INT NOT NULL,
    MaNV INT NOT NULL,
    NgayDatHang DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    TongTien DECIMAL(18, 2) NOT NULL DEFAULT 0,
    MaKM INT NULL,
    FOREIGN KEY (MaKH) REFERENCES khachhang(MaKH) ON DELETE RESTRICT,
    FOREIGN KEY (MaNV) REFERENCES nhanvien(MaNV) ON DELETE RESTRICT,
    FOREIGN KEY (MaKM) REFERENCES khuyenmai(MaKM) ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- B?ng: chitietdonhang (Chi ti?t các s?n ph?m trong ??n hàng)
-- =============================================
CREATE TABLE IF NOT EXISTS chitietdonhang (
    MaDH INT NOT NULL,
    MaHoa INT NOT NULL,
    SoLuong INT NOT NULL,
    ThanhTien DECIMAL(18, 2) NOT NULL,
    MaNV INT NOT NULL,
    PRIMARY KEY (MaDH, MaHoa),
    FOREIGN KEY (MaDH) REFERENCES donhang(MaDH) ON DELETE CASCADE,
    FOREIGN KEY (MaHoa) REFERENCES hoa(MaHoa) ON DELETE RESTRICT,
    FOREIGN KEY (MaNV) REFERENCES nhanvien(MaNV) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- =============================================
-- D? li?u m?u cho b?ng hoa
-- =============================================
INSERT INTO hoa (TenHoa, Gia, SoLuong, MoTa) VALUES
('Hoa H?ng ??', 50000, 100, 'Hoa h?ng ?? t??i, bi?u t??ng c?a tình yêu'),
('Hoa Lan H? ?i?p', 200000, 50, 'Hoa lan cao c?p, sang tr?ng'),
('Hoa Cúc H?a Mi', 30000, 150, 'Hoa cúc tr?ng tinh khôi'),
('Hoa Tulip', 80000, 80, 'Hoa tulip nh?p kh?u t? Hà Lan'),
('Hoa Ly', 120000, 60, 'Hoa ly tr?ng th?m ngát'),
('Hoa H??ng D??ng', 45000, 90, 'Hoa h??ng d??ng t??i sáng'),
('Hoa C?m Ch??ng', 35000, 120, 'Hoa c?m ch??ng nhi?u màu s?c'),
('Hoa Baby', 25000, 200, 'Hoa baby làm ph? ki?n cho hoa chính'),
('Hoa ??ng Ti?n', 40000, 100, 'Hoa ??ng ti?n t??ng tr?ng s? giàu có'),
('Hoa Cát T??ng', 55000, 70, 'Hoa cát t??ng tím nh?t');

-- =============================================
-- D? li?u m?u cho b?ng khachhang
-- =============================================
INSERT INTO khachhang (TenKH, DiaChi, SoDienThoai, Email) VALUES
('Nguy?n V?n An', '123 ???ng ABC, Q1, TP.HCM', '0901234567', 'nguyenvanan@gmail.com'),
('Tr?n Th? Bình', '456 ???ng DEF, Q3, TP.HCM', '0907654321', 'tranthibinh@gmail.com'),
('Lê V?n C??ng', '789 ???ng GHI, Q5, TP.HCM', '0912345678', 'levancuong@gmail.com');

-- =============================================
-- D? li?u m?u cho b?ng nhanvien
-- =============================================
INSERT INTO nhanvien (TenNV, ChucVu, SoDienThoai) VALUES
('Ph?m Th? Duyên', 'Qu?n lý', '0909876543'),
('Hoàng V?n Em', 'Nhân viên bán hàng', '0908765432'),
('Võ Th? Ph??ng', 'Nhân viên bán hàng', '0907654320');

-- =============================================
-- D? li?u m?u cho b?ng khuyenmai
-- =============================================
INSERT INTO khuyenmai (TenCT, TyLeGiam, NgayBD, NgayKT) VALUES
('Khuy?n mãi T?t', 15.00, '2024-01-15', '2024-02-15'),
('Gi?m giá mùa hè', 10.00, '2024-06-01', '2024-08-31'),
('Black Friday', 20.00, '2024-11-20', '2024-11-30');

-- =============================================
-- H??NG D?N S? D?NG
-- =============================================
-- 1. Ch?y script này trong MySQL Workbench ho?c phpMyAdmin
-- 2. C?p nh?t connection string trong file Database.cs:
--    server=localhost;uid=root;pwd=YOUR_PASSWORD;database=quanlybanhoa;charset=utf8mb4;
-- 3. Thay YOUR_PASSWORD b?ng m?t kh?u MySQL c?a b?n
-- 4. Ch?y ?ng d?ng và test các ch?c n?ng
