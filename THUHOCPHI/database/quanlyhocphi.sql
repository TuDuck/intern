-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th10 11, 2023 lúc 11:02 AM
-- Phiên bản máy phục vụ: 10.4.28-MariaDB
-- Phiên bản PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `quanlyhocphi`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `bienlai`
--

CREATE TABLE `bienlai` (
  `MaSV` varchar(200) NOT NULL,
  `TenSV` varchar(200) NOT NULL,
  `SoTien` int(200) NOT NULL,
  `NgayDong` date NOT NULL,
  `Note` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `bienlai`
--

INSERT INTO `bienlai` (`MaSV`, `TenSV`, `SoTien`, `NgayDong`, `Note`) VALUES
('72DCTM20079', 'hoang anh tu', 1, '2023-10-05', 'dong hoc ky 1'),
('72DCTM20079', 'hoang anh tu', 1, '2023-10-07', 'dong hoc ky 1 lan 2'),
('72DCTM20079', 'hoang anh tu', 5000, '2023-10-10', 'hk 2'),
('72DCTM20079', 'hoang anh tu', 1, '2023-10-10', 'dong hk 2'),
('72DCTM20079', 'hoang anh tu', 10000, '2023-10-11', 'dong hoc ky 1');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `dongia`
--

CREATE TABLE `dongia` (
  `MaMon` varchar(200) NOT NULL,
  `TenMon` varchar(200) NOT NULL,
  `Sotinchi` int(100) NOT NULL,
  `Giatin` int(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `dongia`
--

INSERT INTO `dongia` (`MaMon`, `TenMon`, `Sotinchi`, `Giatin`) VALUES
('MH001', 'Lập trình Web', 4, 390000),
('MH002', 'Lập trình di động', 3, 390000),
('Mh003', 'Trí tuệ nhân tạo', 3, 429000),
('MH004', 'An toàn thông tin', 2, 429000),
('MH005', 'Tin học đại cương', 4, 390000);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `hocky`
--

CREATE TABLE `hocky` (
  `MaHK` varchar(100) NOT NULL,
  `TenHK` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `hocky`
--

INSERT INTO `hocky` (`MaHK`, `TenHK`) VALUES
('hk01', 'Học kỳ 1'),
('hk02', 'Học kỳ 2'),
('hk03', 'Học kỳ 3'),
('hk04', 'Học kỳ 4');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `lop`
--

CREATE TABLE `lop` (
  `MaLop` varchar(200) NOT NULL,
  `Tenlop` varchar(200) NOT NULL,
  `MaNganh` varchar(200) NOT NULL,
  `Siso` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `lop`
--

INSERT INTO `lop` (`MaLop`, `Tenlop`, `MaNganh`, `Siso`) VALUES
('72DCDT22', 'Điện tử viễn thông', 'CNTT', 22),
('72DCTM22', 'Truyền thông mạng', 'CNTT', 22),
('73DCKT23', 'Kế toán', 'KTVT', 30);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `monhoc`
--

CREATE TABLE `monhoc` (
  `MaMon` varchar(200) NOT NULL,
  `TenMon` varchar(200) NOT NULL,
  `MaHK` varchar(100) NOT NULL,
  `Sotinchi` int(100) NOT NULL,
  `MaNganh` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `monhoc`
--

INSERT INTO `monhoc` (`MaMon`, `TenMon`, `MaHK`, `Sotinchi`, `MaNganh`) VALUES
('MH001', 'Lập trình Web', 'hk01', 4, 'CNTT'),
('MH002', 'Lập trình di động', 'hk01', 3, 'CNTT'),
('MH003', 'Trí tuệ nhân tạo', 'hk02', 3, 'CNTT'),
('MH004', 'An toàn thông tin', 'hk02', 2, 'CNTT'),
('MH005', 'Tin học đại cương', 'hk01', 4, 'KTVT');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `nganh`
--

CREATE TABLE `nganh` (
  `Manganh` varchar(200) NOT NULL,
  `Tennganh` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `nganh`
--

INSERT INTO `nganh` (`Manganh`, `Tennganh`) VALUES
('CNTT', 'Công nghệ thông tin'),
('KTVT', 'Kinh tế vận tải');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `sinhvien`
--

CREATE TABLE `sinhvien` (
  `MaSV` varchar(200) NOT NULL,
  `TenSV` varchar(200) NOT NULL,
  `MaLop` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `sinhvien`
--

INSERT INTO `sinhvien` (`MaSV`, `TenSV`, `MaLop`) VALUES
('72DCTM200035', 'Nguyễn Thế Anh', '72DCTM22'),
('72DCTM20079', 'hoang anh tu', '72DCTM22'),
('DCDT200036', 'Nguyễn Hoàng Anh', '72DCDT22'),
('DCDT200039', 'Hoàng Công Doanh', '72DCDT22'),
('DCTM20062', 'Bùi Anh Đức', '72DCTM22'),
('DCTM20063', 'Đinh Việt Anh', '72DCTM22'),
('DCTM20064', 'Lê Minh Hiếu', '72DCTM22');

--
-- Bẫy `sinhvien`
--
DELIMITER $$
CREATE TRIGGER `update_thuno_after_insert` AFTER INSERT ON `sinhvien` FOR EACH ROW BEGIN
   INSERT INTO thuno (MaSV,TenSV)
   VALUES (NEW.MaSV,NEW.TenSV);
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `taikhoan`
--

CREATE TABLE `taikhoan` (
  `Tendangnhap` varchar(200) NOT NULL,
  `Matkhau` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `taikhoan`
--

INSERT INTO `taikhoan` (`Tendangnhap`, `Matkhau`) VALUES
('admin', 'admin'),
('admin1', 'admin2');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `thuno`
--

CREATE TABLE `thuno` (
  `MaSV` varchar(200) NOT NULL,
  `TenSV` varchar(200) NOT NULL,
  `Dadong` int(200) NOT NULL,
  `Phaidong` int(200) NOT NULL,
  `ConNo` int(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `thuno`
--

INSERT INTO `thuno` (`MaSV`, `TenSV`, `Dadong`, `Phaidong`, `ConNo`) VALUES
('72DCTM200035', 'Nguyễn Thế Anh', 15000, 4875000, 4860000),
('72DCTM20079', 'hoang anh tu', 375011, 4875000, 4499989);

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `dongia`
--
ALTER TABLE `dongia`
  ADD PRIMARY KEY (`MaMon`);

--
-- Chỉ mục cho bảng `hocky`
--
ALTER TABLE `hocky`
  ADD PRIMARY KEY (`MaHK`);

--
-- Chỉ mục cho bảng `lop`
--
ALTER TABLE `lop`
  ADD PRIMARY KEY (`MaLop`),
  ADD KEY `MaNganh` (`MaNganh`);

--
-- Chỉ mục cho bảng `monhoc`
--
ALTER TABLE `monhoc`
  ADD PRIMARY KEY (`MaMon`),
  ADD KEY `MaNganh` (`MaNganh`),
  ADD KEY `MaHK` (`MaHK`);

--
-- Chỉ mục cho bảng `nganh`
--
ALTER TABLE `nganh`
  ADD PRIMARY KEY (`Manganh`);

--
-- Chỉ mục cho bảng `sinhvien`
--
ALTER TABLE `sinhvien`
  ADD PRIMARY KEY (`MaSV`),
  ADD KEY `MaLop` (`MaLop`);

--
-- Chỉ mục cho bảng `thuno`
--
ALTER TABLE `thuno`
  ADD PRIMARY KEY (`MaSV`);

--
-- Các ràng buộc cho các bảng đã đổ
--

--
-- Các ràng buộc cho bảng `dongia`
--
ALTER TABLE `dongia`
  ADD CONSTRAINT `dongia_ibfk_1` FOREIGN KEY (`MaMon`) REFERENCES `monhoc` (`MaMon`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Các ràng buộc cho bảng `lop`
--
ALTER TABLE `lop`
  ADD CONSTRAINT `lop_ibfk_1` FOREIGN KEY (`MaNganh`) REFERENCES `nganh` (`Manganh`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Các ràng buộc cho bảng `monhoc`
--
ALTER TABLE `monhoc`
  ADD CONSTRAINT `monhoc_ibfk_1` FOREIGN KEY (`MaNganh`) REFERENCES `nganh` (`Manganh`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `monhoc_ibfk_2` FOREIGN KEY (`MaHK`) REFERENCES `hocky` (`MaHK`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Các ràng buộc cho bảng `sinhvien`
--
ALTER TABLE `sinhvien`
  ADD CONSTRAINT `sinhvien_ibfk_1` FOREIGN KEY (`MaLop`) REFERENCES `lop` (`MaLop`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Các ràng buộc cho bảng `thuno`
--
ALTER TABLE `thuno`
  ADD CONSTRAINT `thuno_ibfk_1` FOREIGN KEY (`MaSV`) REFERENCES `sinhvien` (`MaSV`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
