USE [master]
GO
/****** Object:  Database [btl_9]    Script Date: 6/14/2023 7:50:52 PM ******/
CREATE DATABASE [btl_9]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'masters', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\masters.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'masters_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\masters_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [btl_9] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [btl_9].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [btl_9] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [btl_9] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [btl_9] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [btl_9] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [btl_9] SET ARITHABORT OFF 
GO
ALTER DATABASE [btl_9] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [btl_9] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [btl_9] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [btl_9] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [btl_9] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [btl_9] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [btl_9] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [btl_9] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [btl_9] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [btl_9] SET  DISABLE_BROKER 
GO
ALTER DATABASE [btl_9] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [btl_9] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [btl_9] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [btl_9] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [btl_9] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [btl_9] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [btl_9] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [btl_9] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [btl_9] SET  MULTI_USER 
GO
ALTER DATABASE [btl_9] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [btl_9] SET DB_CHAINING OFF 
GO
ALTER DATABASE [btl_9] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [btl_9] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [btl_9] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [btl_9] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [btl_9] SET QUERY_STORE = ON
GO
ALTER DATABASE [btl_9] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [btl_9]
GO
/****** Object:  Table [dbo].[dang_nhap]    Script Date: 6/14/2023 7:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dang_nhap](
	[tendangnhap] [nvarchar](50) NOT NULL,
	[matkhau] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_dangnhap] PRIMARY KEY CLUSTERED 
(
	[tendangnhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dongia]    Script Date: 6/14/2023 7:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dongia](
	[mamh] [nvarchar](50) NOT NULL,
	[tenmh] [nvarchar](50) NULL,
	[sotin] [nvarchar](50) NULL,
	[giatin] [int] NULL,
 CONSTRAINT [PK_hoc_phan] PRIMARY KEY CLUSTERED 
(
	[mamh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hocki]    Script Date: 6/14/2023 7:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hocki](
	[maHK] [nvarchar](50) NOT NULL,
	[tenHK] [nvarchar](50) NULL,
 CONSTRAINT [PK_hocki] PRIMARY KEY CLUSTERED 
(
	[maHK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lop]    Script Date: 6/14/2023 7:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lop](
	[malop] [nvarchar](50) NOT NULL,
	[tenlop] [nvarchar](50) NULL,
	[tennganh] [nvarchar](50) NULL,
 CONSTRAINT [PK_lop] PRIMARY KEY CLUSTERED 
(
	[malop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[monhoc]    Script Date: 6/14/2023 7:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[monhoc](
	[mamh] [nvarchar](50) NOT NULL,
	[tenmh] [nvarchar](50) NULL,
	[sotin] [int] NULL,
	[maHK] [nvarchar](50) NULL,
	[nganh] [nvarchar](50) NULL,
	[giatin] [int] NULL,
 CONSTRAINT [PK_monhoc] PRIMARY KEY CLUSTERED 
(
	[mamh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nganh]    Script Date: 6/14/2023 7:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nganh](
	[manganh] [nvarchar](50) NOT NULL,
	[tennganh] [nvarchar](50) NULL,
	[maHK] [nvarchar](50) NULL,
	[tongtien] [int] NULL,
 CONSTRAINT [PK_nganh] PRIMARY KEY CLUSTERED 
(
	[manganh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sinhvien]    Script Date: 6/14/2023 7:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sinhvien](
	[masv] [nvarchar](50) NOT NULL,
	[tensv] [nvarchar](50) NULL,
	[malop] [nvarchar](50) NULL,
	[tennganh] [nvarchar](50) NULL,
	[ngaysinh] [date] NULL,
 CONSTRAINT [PK_sinhvien] PRIMARY KEY CLUSTERED 
(
	[masv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[thuno]    Script Date: 6/14/2023 7:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[thuno](
	[mamh] [nvarchar](50) NULL,
	[masv] [nvarchar](50) NOT NULL,
	[tensv] [nvarchar](50) NULL,
	[dadong] [int] NULL,
	[phaidong] [int] NULL,
	[maHK] [nvarchar](50) NULL,
	[nganh] [nvarchar](50) NULL,
 CONSTRAINT [PK_thuno] PRIMARY KEY CLUSTERED 
(
	[masv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[dang_nhap] ([tendangnhap], [matkhau]) VALUES (N'admin1', N'123')
INSERT [dbo].[dang_nhap] ([tendangnhap], [matkhau]) VALUES (N'admin2', N'456')
INSERT [dbo].[dang_nhap] ([tendangnhap], [matkhau]) VALUES (N'duong', N'0209')
GO
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'	DC2TT31', N'Phần mềm mã nguồn mở', N'8', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'	DC3HT32', N'Quản lý dự án phần mềm', N'3', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC1CB11', N'Toán 1', N'2', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC1CB20', N'Lý thuyết xác suất - thống kê', N'2', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC1LL08', N'Chủ nghĩa xã hội khoa học', N'2', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC1LL09
', N'Lịch sử Đảng cộng sản Việt Nam
', N'2', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC1QP05
', N'Đường lối QPAN
', N'3', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC1QP06', N'Công tác quốc phòng và an ninh', N'2', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC1TD32', N'Cầu lông', N'2', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC1TD33', N'Aerobic', N'2', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC1TT25', N'Vật lý đại cương 1', N'2', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC1TT44', N'Tin học cơ sở', N'3', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC1TT45', N'Lý thuyết cơ khí', N'3', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC2CK32', N'Vật liệu cơ khí', N'3', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC2CK42', N'Động cơ điện', N'2', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC2CO12', N'Hình học họa hình', N'2', 500000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC2CO26
', N'Sức bền vật liệu
', N'2', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC2DT68
', N'Điện tử tương tự
', N'4', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC2HT27', N'JAVA
', N'3', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC2HT36
', N'Lập trình trên môi trường Web
', N'4', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC2HT38
', N'Công nghệ phần mềm
', N'4', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC2HT42
', N'Toán học rời rạc
', N'4', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC2KV63
', N'Kinh tế lượng
', N'3', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC2KV67
', N'Tài chính tiền tệ
', N'3', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC2KV78
', N'Kinh tế chính trị
', N'2', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC2TT11
', N'Kiến trúc máy tính
', N'2', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC2TT31
', N'Phần mềm mã hoá
', N'3', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC2TT32
', N'Điện toán đám mây
', N'2', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC2TT35
', N'C++
', N'3', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC2TT54
', N'Nguyên lý Hệ điều hành
', N'2', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC2TT56
', N'An ninh mạng
', N'3', 500000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC2TT76
', N'Toán 2
', N'3', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC3CM30
', N'Robot công nghiệp
', N'4', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC3HT12
', N'Kinh tế vĩ mô
', N'3', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC3HT16
', N'Kinh tế lượng
', N'3', 500000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC3HT21
', N'Hệ quản trị Cơ sở dữ liệu
', N'3', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC3HT23
', N'Hệ cơ sở tri thức
', N'4', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC3HT28
', N'Nguyên lý thống kê

', N'3', 500000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC3HT31
', N'Lập trình di động
', N'3', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC3HT32
', N'Quản lý dự án phần mềm
', N'4', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC3HT41
', N'Kiểm thử phần mềm
', N'3', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC3HT47
', N'Cơ sở dữ liệu phân tán
', N'3', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC3HT51
', N'An toàn và bảo mật hệ thống thông tin
', N'4', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC3HT56
', N'Tiếng Anh chuyên ngành
', N'3', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC3TM48
', N'Công nghệ phần cứng
', N'3', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC3TM64
', N'Phần mềm mã hoá
', N'3', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC3TT17
', N'Nhập môn tương tác người - máy
', N'3', 430000)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DC3TT34
', N'Giao thông thông minh - ITS
', N'3', NULL)
INSERT [dbo].[dongia] ([mamh], [tenmh], [sotin], [giatin]) VALUES (N'DCTT235
', N'Cầu đường
', N'4', NULL)
GO
INSERT [dbo].[hocki] ([maHK], [tenHK]) VALUES (N'HK1', N'Học Kỳ 1 - 2022_2023 ')
INSERT [dbo].[hocki] ([maHK], [tenHK]) VALUES (N'HK2', N'Học Kỳ 2 - 2022_2023')
GO
INSERT [dbo].[lop] ([malop], [tenlop], [tennganh]) VALUES (N'72DCTM21', N'TM21', N'Mạng MT')
INSERT [dbo].[lop] ([malop], [tenlop], [tennganh]) VALUES (N'72DCTM22', N'TM22', N'Mạng MT')
INSERT [dbo].[lop] ([malop], [tenlop], [tennganh]) VALUES (N'72DCTM23', N'TM23', N'Hệ thống thông tin
')
INSERT [dbo].[lop] ([malop], [tenlop], [tennganh]) VALUES (N'72DCTM24', N'TM24', N'Tài chính
')
GO
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC1CB11', N'Toán 1', 2, N'HK1', N'Mạng MT', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC1CB20', N'Lý thuyết xác suất - thống kê', 2, N'HK1', N'Mạng MT', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC1LL08', N'Chủ nghĩa xã hội khoa học', 2, N'HK1', N'Mạng MT', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC1LL09', N'Lịch sử Đảng cộng sản Việt Nam', 2, N'HK1', N'Tài chính
', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC1QP05', N'Đường lối QPAN', 3, N'HK1', N'Tài chính
', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC1QP06', N'Công tác quốc phòng và an ninh', 2, N'HK1', N'Tài chính
', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC1TD32', N'Cầu lông', 2, N'HK1', N'Tài chính
', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC1TD33', N'Aerobic', 2, N'HK1', N'Tài chính
', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC1TT25', N'Vật lý đại cương 1', 2, N'HK1', N'Kĩ thuật cơ khí
', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC1TT44', N'Tin học cơ sở', 3, N'HK1', N'Kĩ thuật cơ khí
', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC1TT45', N'Lý thuyết cơ khí', 3, N'HK1', N'Kĩ thuật cơ khí
', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC2CK32', N'Vật liệu cơ khí', 3, N'HK1', N'Kĩ thuật cơ khí
', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC2CK42', N'Động cơ điện', 2, N'HK1', N'Kĩ thuật cơ khí
', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC2CO12', N'Hình học họa hình', 2, N'HK1', N'CNKT Điện tử viễn thông
', 500000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC2CO26', N'Sức bền vật liệu', 2, N'HK1', N'CNKT Điện tử viễn thông
', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC2DT68', N'Điện tử tương tự', 4, N'HK1', N'CNKT Điện tử viễn thông
', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC2HT27', N'JAVA', 3, N'HK1', N'CNKT Điện tử viễn thông
', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC2HT36', N'Lập trình trên môi trường Web', 4, N'HK1', N'CNKT Điện tử viễn thông
', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC2HT38
', N'Công nghệ phần mềm', 4, N'HK1', N'Hệ thống thông tin
', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC2HT42', N'Toán học rời rạc', 4, N'HK1', N'Hệ thống thông tin
', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC2KV63', N'Kinh tế lượng', 3, N'HK1', N'Hệ thống thông tin
', 500000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC2KV67', N'Tài chính tiền tệ', 3, N'HK1', N'Hệ thống thông tin
', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC2KV78', N'Kinh tế chính trị', 2, N'HK1', N'Hệ thống thông tin
', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC2TT11', N'Kiến trúc máy tính', 2, N'HK2', N'Mạng MT', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC2TT31', N'Phần mềm mã nguồn mở', 8, N'HK1', N'Mạng MT', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC2TT31
', N'Phần mềm mã hoá', 3, N'HK2', N'Mạng MT', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC2TT32 ', N'Điện toán đám mây', 2, N'HK2', N'Mạng MT', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC2TT35', N'C++', 3, N'HK2', N'Mạng MT', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC2TT54', N'Nguyên lý Hệ điều hành', 2, N'HK2', N'Mạng MT', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC2TT56', N'An ninh mạng', 3, N'HK2', N'Tài chính
', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC2TT76', N'Toán 2', 3, N'HK2', N'Tài chính
', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC3CM30', N'Robot công nghiệp', 4, N'HK2', N'Tài chính
', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC3HT12', N'Kinh tế vĩ mô', 3, N'HK2', N'Tài chính
', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC3HT16', N'Kinh tế lượng ', 3, N'HK2', N'Tài chính
', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC3HT21', N'Hệ quản trị Cơ sở dữ liệu', 3, N'HK2', N'Kĩ thuật cơ khí
', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC3HT23', N'Hệ cơ sở tri thức', 4, N'HK2', N'Kĩ thuật cơ khí
', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC3HT28', N'Nguyên lý thống kê', 3, N'HK2', N'Kĩ thuật cơ khí
', 500000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC3HT31', N'Lập trình di động', 3, N'HK2', N'Kĩ thuật cơ khí
', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC3HT32', N'Quản lý dự án phần mềm', 3, N'HK1', N'Mạng MT', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC3HT32
', N'Quản lý dự án phần mềm
', 4, N'HK2', N'Kĩ thuật cơ khí
', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC3HT41', N'Kiểm thử phần mềm', 3, N'HK2', N'CNKT Điện tử viễn thông
', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC3HT47', N'Cơ sở dữ liệu phân tán', 3, N'HK2', N'CNKT Điện tử viễn thông
', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC3HT51', N'An toàn và bảo mật hệ thống thông tin', 4, N'HK2', N'CNKT Điện tử viễn thông
', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC3HT56', N'Tiếng Anh chuyên ngành', 3, N'HK2', N'CNKT Điện tử viễn thông
', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC3TM48', N'Công nghệ phần cứng', 3, N'HK2', N'CNKT Điện tử viễn thông
', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC3TM64', N'Phần mềm mã hoá', 3, N'HK2', N'Hệ thống thông tin
', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC3TT17', N'Nhập môn tương tác người - máy', 3, N'HK2', N'Hệ thống thông tin
', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DC3TT34', N'Giao thông thông minh - ITS', 3, N'HK2', N'Hệ thống thông tin
', 430000)
INSERT [dbo].[monhoc] ([mamh], [tenmh], [sotin], [maHK], [nganh], [giatin]) VALUES (N'DCTT235', N'Cầu đường', 4, N'HK2', N'Hệ thống thông tin
', 430000)
GO
INSERT [dbo].[nganh] ([manganh], [tennganh], [maHK], [tongtien]) VALUES (N'1', N'Mạng MT', N'HK1', 7310000)
INSERT [dbo].[nganh] ([manganh], [tennganh], [maHK], [tongtien]) VALUES (N'10', N'Hệ thống thông tin
', N'HK2', 5590000)
INSERT [dbo].[nganh] ([manganh], [tennganh], [maHK], [tongtien]) VALUES (N'2', N'Mạng MT', N'HK2', 5160000)
INSERT [dbo].[nganh] ([manganh], [tennganh], [maHK], [tongtien]) VALUES (N'3', N'Tài chính
', N'HK1', 4730000)
INSERT [dbo].[nganh] ([manganh], [tennganh], [maHK], [tongtien]) VALUES (N'4', N'Tài chính
', N'HK2', 6880000)
INSERT [dbo].[nganh] ([manganh], [tennganh], [maHK], [tongtien]) VALUES (N'5', N'Kĩ thuật cơ khí
', N'HK1', 5590000)
INSERT [dbo].[nganh] ([manganh], [tennganh], [maHK], [tongtien]) VALUES (N'6', N'Kĩ thuật cơ khí
', N'HK2', 7520000)
INSERT [dbo].[nganh] ([manganh], [tennganh], [maHK], [tongtien]) VALUES (N'7', N'CNKT Điện tử viễn thông
', N'HK1', 6590000)
INSERT [dbo].[nganh] ([manganh], [tennganh], [maHK], [tongtien]) VALUES (N'8', N'CNKT Điện tử viễn thông
', N'HK2', 6880000)
INSERT [dbo].[nganh] ([manganh], [tennganh], [maHK], [tongtien]) VALUES (N'9', N'Hệ thống thông tin
', N'HK1', 7090000)
GO
INSERT [dbo].[sinhvien] ([masv], [tensv], [malop], [tennganh], [ngaysinh]) VALUES (N'72DCTM20010', N'Lê Anh Quân', N'72DCQM21', N'Mạng MT', CAST(N'2002-08-04' AS Date))
INSERT [dbo].[sinhvien] ([masv], [tensv], [malop], [tennganh], [ngaysinh]) VALUES (N'72DCTM20047', N'Nguyễn Minh Thảo', N'72DCHM23', N'Mạng MT', CAST(N'2001-07-04' AS Date))
INSERT [dbo].[sinhvien] ([masv], [tensv], [malop], [tennganh], [ngaysinh]) VALUES (N'72DCTM20058', N'Đinh Thế Anh', N'72DCTM22', N'Mạng MT', CAST(N'2003-12-26' AS Date))
INSERT [dbo].[sinhvien] ([masv], [tensv], [malop], [tennganh], [ngaysinh]) VALUES (N'72DCTM20061', N'Phí Huyền Trang', N'71DCQE23', N'Mạng MT', CAST(N'2002-08-06' AS Date))
INSERT [dbo].[sinhvien] ([masv], [tensv], [malop], [tennganh], [ngaysinh]) VALUES (N'72DCTM20066', N'Nguyễn Quốc Khánh', N'72DCQM23', N'Hệ thống thông tin
', CAST(N'2003-08-01' AS Date))
INSERT [dbo].[sinhvien] ([masv], [tensv], [malop], [tennganh], [ngaysinh]) VALUES (N'72DCTM20067', N'Nguyễn Trung Đức', N'72DCTM24', N'Tài chính
', CAST(N'2003-04-05' AS Date))
INSERT [dbo].[sinhvien] ([masv], [tensv], [malop], [tennganh], [ngaysinh]) VALUES (N'72DCTM20068', N'Nguyễn Văn Tuấn ', N'72DCTM25', N'Tài chính
', CAST(N'2001-08-03' AS Date))
INSERT [dbo].[sinhvien] ([masv], [tensv], [malop], [tennganh], [ngaysinh]) VALUES (N'72DCTM20069', N'Trương Anh Ngọc', N'72DCTM26', N'Tài chính
', CAST(N'2001-06-07' AS Date))
INSERT [dbo].[sinhvien] ([masv], [tensv], [malop], [tennganh], [ngaysinh]) VALUES (N'72DCTM20070', N'Nguyễn Hoàng Việt', N'71DCTM56', N'Tài chính
', CAST(N'2002-03-04' AS Date))
INSERT [dbo].[sinhvien] ([masv], [tensv], [malop], [tennganh], [ngaysinh]) VALUES (N'72DCTM20071', N'Hà Hải Nam', N'73DCTM98', N'Kĩ thuật cơ khí
', CAST(N'2004-05-07' AS Date))
INSERT [dbo].[sinhvien] ([masv], [tensv], [malop], [tennganh], [ngaysinh]) VALUES (N'72DCTM20072', N'Hoàng Anh Tú', N'72DCOY78', N'Kĩ thuật cơ khí
', CAST(N'2003-05-09' AS Date))
INSERT [dbo].[sinhvien] ([masv], [tensv], [malop], [tennganh], [ngaysinh]) VALUES (N'72DCTM20073', N'Đào Huy Dương', N'72DCPI87', N'Kĩ thuật cơ khí
', CAST(N'2002-03-05' AS Date))
INSERT [dbo].[sinhvien] ([masv], [tensv], [malop], [tennganh], [ngaysinh]) VALUES (N'72DCTM20077', N'Vũ Tùng Lâm', N'72DCKT22', N'Hệ thống thông tin
', CAST(N'2002-05-02' AS Date))
INSERT [dbo].[sinhvien] ([masv], [tensv], [malop], [tennganh], [ngaysinh]) VALUES (N'72DCTM20079', N'Vũ Thu Phương', N'72DCTG71', N'Kĩ thuật cơ khí
', CAST(N'2023-06-05' AS Date))
INSERT [dbo].[sinhvien] ([masv], [tensv], [malop], [tennganh], [ngaysinh]) VALUES (N'72DCTM20080', N'Nguyễn Đinh Việt Anh', N'71DCTM22', N'CNKT Điện tử viễn thông
', CAST(N'2000-02-01' AS Date))
INSERT [dbo].[sinhvien] ([masv], [tensv], [malop], [tennganh], [ngaysinh]) VALUES (N'72DCTM20081', N'Vũ Đức Duy', N'73DCTM23', N'CNKT Điện tử viễn thông
', CAST(N'2001-05-04' AS Date))
INSERT [dbo].[sinhvien] ([masv], [tensv], [malop], [tennganh], [ngaysinh]) VALUES (N'72DCTM20082', N'Trần Thành Nam', N'72DJQM27', N'CNKT Điện tử viễn thông
', CAST(N'2002-06-20' AS Date))
INSERT [dbo].[sinhvien] ([masv], [tensv], [malop], [tennganh], [ngaysinh]) VALUES (N'72DCTM20094', N'Ngô Mạnh Tuân', N'73DCKT24', N'Hệ thống thông tin
', CAST(N'2003-05-06' AS Date))
INSERT [dbo].[sinhvien] ([masv], [tensv], [malop], [tennganh], [ngaysinh]) VALUES (N'72DCTM20095', N'Phạm Hồng Sơn', N'72DCXT21', N'CNKT Điện tử viễn thông
', CAST(N'2003-06-12' AS Date))
INSERT [dbo].[sinhvien] ([masv], [tensv], [malop], [tennganh], [ngaysinh]) VALUES (N'72DCTM20108', N'Đào Trung Kiên', N'71DCQM22', N'Hệ thống thông tin
', CAST(N'2002-07-04' AS Date))
GO
INSERT [dbo].[thuno] ([mamh], [masv], [tensv], [dadong], [phaidong], [maHK], [nganh]) VALUES (NULL, N'72DCTM20010', N'Lê Anh Quân', 1900000, 5410000, N'HK1', N'Mạng MT')
INSERT [dbo].[thuno] ([mamh], [masv], [tensv], [dadong], [phaidong], [maHK], [nganh]) VALUES (NULL, N'72DCTM20047', N'Nguyễn Minh Thảo', 2000000, 5310000, N'HK1', N'Mạng MT')
INSERT [dbo].[thuno] ([mamh], [masv], [tensv], [dadong], [phaidong], [maHK], [nganh]) VALUES (NULL, N'72DCTM20058', N'Đinh Thế Anh', NULL, 0, N'HK2', N'Mạng MT')
INSERT [dbo].[thuno] ([mamh], [masv], [tensv], [dadong], [phaidong], [maHK], [nganh]) VALUES (NULL, N'72DCTM20061', N'Phí Huyền Trang', 3500000, 1660000, N'HK2', N'Mạng MT')
INSERT [dbo].[thuno] ([mamh], [masv], [tensv], [dadong], [phaidong], [maHK], [nganh]) VALUES (NULL, N'72DCTM20066', N'Nguyễn Quốc Khánh', 2600000, 4490000, N'HK1', N'Hệ thống thông tin
')
INSERT [dbo].[thuno] ([mamh], [masv], [tensv], [dadong], [phaidong], [maHK], [nganh]) VALUES (NULL, N'72DCTM20067', N'Nguyễn Trung Đức', 3550000, 1180000, N'HK1', N'Tài chính
')
INSERT [dbo].[thuno] ([mamh], [masv], [tensv], [dadong], [phaidong], [maHK], [nganh]) VALUES (NULL, N'72DCTM20068', N'Nguyễn Văn Tuấn ', NULL, 0, N'HK1', N'Tài chính
')
INSERT [dbo].[thuno] ([mamh], [masv], [tensv], [dadong], [phaidong], [maHK], [nganh]) VALUES (NULL, N'72DCTM20069', N'Trương Anh Ngọc', 4600000, 2280000, N'HK2', N'Tài chính
')
INSERT [dbo].[thuno] ([mamh], [masv], [tensv], [dadong], [phaidong], [maHK], [nganh]) VALUES (NULL, N'72DCTM20070', N'Nguyễn Hoàng Việt', 3200000, 3680000, N'HK2', N'Tài chính
')
INSERT [dbo].[thuno] ([mamh], [masv], [tensv], [dadong], [phaidong], [maHK], [nganh]) VALUES (NULL, N'72DCTM20071', N'Hà Hải Nam', NULL, 0, N'HK1', N'Kĩ thuật cơ khí
')
INSERT [dbo].[thuno] ([mamh], [masv], [tensv], [dadong], [phaidong], [maHK], [nganh]) VALUES (NULL, N'72DCTM20072', N'Hoàng Anh Tú', 2400000, 3190000, N'HK1', N'Kĩ thuật cơ khí
')
INSERT [dbo].[thuno] ([mamh], [masv], [tensv], [dadong], [phaidong], [maHK], [nganh]) VALUES (NULL, N'72DCTM20073', N'Đào Huy Dương', 3500000, 4020000, N'HK2', N'Kĩ thuật cơ khí
')
INSERT [dbo].[thuno] ([mamh], [masv], [tensv], [dadong], [phaidong], [maHK], [nganh]) VALUES (NULL, N'72DCTM20077', N'Vũ Tùng Lâm', NULL, 0, N'HK2', N'Hệ thống thông tin
')
INSERT [dbo].[thuno] ([mamh], [masv], [tensv], [dadong], [phaidong], [maHK], [nganh]) VALUES (NULL, N'72DCTM20079', N'Vũ Thu Phương', 4160000, 3360000, N'HK2', N'Kĩ thuật cơ khí
')
INSERT [dbo].[thuno] ([mamh], [masv], [tensv], [dadong], [phaidong], [maHK], [nganh]) VALUES (NULL, N'72DCTM20080', N'Nguyễn Đinh Việt Anh', NULL, 0, N'HK1', N'CNKT Điện tử viễn thông
')
INSERT [dbo].[thuno] ([mamh], [masv], [tensv], [dadong], [phaidong], [maHK], [nganh]) VALUES (NULL, N'72DCTM20081', N'Vũ Đức Duy', 4000000, 2590000, N'HK1', N'CNKT Điện tử viễn thông
')
INSERT [dbo].[thuno] ([mamh], [masv], [tensv], [dadong], [phaidong], [maHK], [nganh]) VALUES (NULL, N'72DCTM20082', N'Trần Thành Nam', NULL, 0, N'HK2', N'CNKT Điện tử viễn thông
')
INSERT [dbo].[thuno] ([mamh], [masv], [tensv], [dadong], [phaidong], [maHK], [nganh]) VALUES (NULL, N'72DCTM20094', N'Ngô Mạnh Tuân', NULL, 0, N'HK1', N'Hệ thống thông tin
')
INSERT [dbo].[thuno] ([mamh], [masv], [tensv], [dadong], [phaidong], [maHK], [nganh]) VALUES (NULL, N'72DCTM20095', N'Phạm Hồng Sơn', 3100000, 3780000, N'HK2', N'CNKT Điện tử viễn thông
')
INSERT [dbo].[thuno] ([mamh], [masv], [tensv], [dadong], [phaidong], [maHK], [nganh]) VALUES (NULL, N'72DCTM20108', N'Đào Trung Kiên', 4570000, 1020000, N'HK2', N'Hệ thống thông tin
')
GO
/****** Object:  StoredProcedure [dbo].[CheckMasv]    Script Date: 6/14/2023 7:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[CheckMasv] 
	@masv nvarchar(30),
	@kq int output
AS
BEGIN
	set @kq = 0
	if(exists(select * from sinhvien where masv = @masv))
	begin
		set @kq = 1
	end
END
GO
/****** Object:  StoredProcedure [dbo].[ChecktrungMahp]    Script Date: 6/14/2023 7:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ChecktrungMahp]
	@mamh nvarchar(50),
	@ketqua int output
AS
BEGIN
	Set @ketqua =0
	if(exists(Select mamh From monhoc Where mamh =@mamh))
	
		Set @ketqua =1;
		
END
GO
/****** Object:  StoredProcedure [dbo].[checktrungmasv]    Script Date: 6/14/2023 7:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[checktrungmasv]
	-- Add the parameters for the stored procedure here
	@masv nvarchar(50),
	@ketqua int output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	set @ketqua=0
	if (exists (select masv from sinhvien where masv=@masv))
	set @ketqua=1;
	
END
GO
/****** Object:  StoredProcedure [dbo].[ChecktrungMatkhau]    Script Date: 6/14/2023 7:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ChecktrungMatkhau]
	@matkhau nvarchar(50),
	@ketqua int output
AS
BEGIN
	Set @ketqua =0
	if(exists(Select matkhau From dang_nhap Where matkhau =@matkhau))
	
		Set @ketqua =1;
		
END
GO
/****** Object:  StoredProcedure [dbo].[ChecktrungTaikhoan]    Script Date: 6/14/2023 7:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ChecktrungTaikhoan]
	@tendangnhap nvarchar(50),
	@ketqua int output
AS
BEGIN
	Set @ketqua =0
	if(exists(Select tendangnhap From dang_nhap Where tendangnhap =@tendangnhap))
	
		Set @ketqua =1;
		
END
GO
/****** Object:  StoredProcedure [dbo].[ChecktrungTenmh]    Script Date: 6/14/2023 7:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ChecktrungTenmh]
	@tenmh nvarchar(50),
	@ketqua int output
AS
BEGIN
	Set @ketqua =0
	if(exists(Select tenmh From monhoc Where tenmh =@tenmh))
	
		Set @ketqua =1;
		
END
GO
/****** Object:  StoredProcedure [dbo].[Dongia_find]    Script Date: 6/14/2023 7:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Dongia_find]
	@mamh nvarchar(50)
	
	
As
Begin
	select mamh, tenmh, sotin, giatin from dongia where  mamh like '%'+@mamh+'%'			
End
GO
/****** Object:  StoredProcedure [dbo].[Find_DN]    Script Date: 6/14/2023 7:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Find_DN]
	@tendangnhap nvarchar(50)
as
begin
	select tendangnhap, matkhau from dang_nhap where  tendangnhap like '%'+@tendangnhap+'%'	
end
GO
/****** Object:  StoredProcedure [dbo].[Hocphan_find]    Script Date: 6/14/2023 7:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Hocphan_find](
	@mamh nvarchar(50),	
	@tenmh nvarchar(50),
	@sotin nvarchar(50),
	@maHK nvarchar(50)
	)
	
As
Begin
	if(@sotin=0)
	Begin
		SELECT * FROM monhoc						
		Where	mamh like '%'+@mamh+'%' and				
				tenmh like '%'+@tenmh+'%' and
				
				maHK like '%'+@maHK+'%' 
				
				
	End
	else
	Begin
		SELECT * FROM monhoc						
		Where	mamh like '%'+@mamh+'%' and				
				tenmh like '%'+@tenmh+'%' and
				sotin = @sotin and
				maHK like '%'+@maHK+'%' 
				
	End

End
GO
/****** Object:  StoredProcedure [dbo].[login]    Script Date: 6/14/2023 7:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[login]
@tendangnhap nvarchar(50),
@matkhau nvarchar(50),
@check int output

as
begin
    if exists (select * from dang_nhap where tendangnhap = @tendangnhap and matkhau = @matkhau )
        Select @check = 1
	else 
	select @check = 0
end
GO
/****** Object:  StoredProcedure [dbo].[Monhoc_find]    Script Date: 6/14/2023 7:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Monhoc_find]
	@tenmh nvarchar(50)
		
As
Begin
	select mamh, tenmh, sotin, maHK from monhoc where tenmh like '%'+@tenmh+'%'			
End
GO
/****** Object:  StoredProcedure [dbo].[nguoithan_find]    Script Date: 6/14/2023 7:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[nguoithan_find] 
	@tenphuhuynh nvarchar(50),
	@masv nvarchar(50),
	@diachi nvarchar(50),
	@sdt int
	
AS
BEGIN
	select * from nguoithan where 
	tenphuhuynh like '%'+ @tenphuhuynh +'%' and
	masv like '%'+@masv+'%' and
	diachi like '%'+@diachi+'%' and
	sdt = @sdt
END
GO
/****** Object:  StoredProcedure [dbo].[Thuno_find]    Script Date: 6/14/2023 7:50:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Thuno_find](
	@masv nvarchar(50)
	)
	
As
Begin
	select masv, tensv, tenmh, dadong, phaidong from thuno, monhoc where thuno.mamh = monhoc.mamh and masv like '%'+@masv+'%'			
End
/****** Object:  StoredProcedure [dbo].[login]    Script Date: 10/06/2023 11:34:50 AM ******/
SET ANSI_NULLS ON
GO
USE [master]
GO
ALTER DATABASE [btl_9] SET  READ_WRITE 
GO
