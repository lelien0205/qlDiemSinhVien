USE [master]
GO
CREATE DATABASE [quanlysinhvien]
GO
ALTER DATABASE [quanlysinhvien] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [quanlysinhvien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [quanlysinhvien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [quanlysinhvien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [quanlysinhvien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [quanlysinhvien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [quanlysinhvien] SET ARITHABORT OFF 
GO
ALTER DATABASE [quanlysinhvien] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [quanlysinhvien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [quanlysinhvien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [quanlysinhvien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [quanlysinhvien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [quanlysinhvien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [quanlysinhvien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [quanlysinhvien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [quanlysinhvien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [quanlysinhvien] SET  DISABLE_BROKER 
GO
ALTER DATABASE [quanlysinhvien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [quanlysinhvien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [quanlysinhvien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [quanlysinhvien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [quanlysinhvien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [quanlysinhvien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [quanlysinhvien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [quanlysinhvien] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [quanlysinhvien] SET  MULTI_USER 
GO
ALTER DATABASE [quanlysinhvien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [quanlysinhvien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [quanlysinhvien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [quanlysinhvien] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [quanlysinhvien] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [quanlysinhvien] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [quanlysinhvien] SET QUERY_STORE = ON
GO
ALTER DATABASE [quanlysinhvien] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [quanlysinhvien]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_diem](
	[id_diem] [int] IDENTITY(1,1) NOT NULL,
	[id_sv] [int] NULL,
	[id_monhoc] [int] NULL,
	[diemchuyencan] [float] NULL,
	[diemheso1] [float] NULL,
	[diemheso2_t1] [float] NULL,
	[diemheso2_t2] [float] NULL,
	[diemquatrinh] [float] NULL,
	[diemthi] [float] NULL,
	[diemhocphan] [float] NULL,
 CONSTRAINT [PK__tbl_diem__9739FEB7B043A996] PRIMARY KEY CLUSTERED 
(
	[id_diem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_giaovien](
	[id_gv] [int] IDENTITY(1,1) NOT NULL,
	[hoten_gv] [nvarchar](50) NULL,
	[ngaysinh] [date] NULL,
	[id_khoa] [int] NULL,
	[tendangnhap] [nvarchar](50) NULL,
 CONSTRAINT [PK__tbl_giao__00B7FE6EE158F4BC] PRIMARY KEY CLUSTERED 
(
	[id_gv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_khoa](
	[id_khoa] [int] IDENTITY(1,1) NOT NULL,
	[tenkhoa] [nvarchar](50) NULL,
 CONSTRAINT [PK__tbl_khoa__AD2771B2BC9343F9] PRIMARY KEY CLUSTERED 
(
	[id_khoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_lophoc](
	[id_lophoc] [int] IDENTITY(1,1) NOT NULL,
	[tenlop] [nvarchar](50) NULL,
	[khoahoc] [nvarchar](50) NULL,
	[hedaotao] [nvarchar](50) NULL,
	[namnhaphoc] [int] NULL,
	[id_khoa] [int] NULL,
 CONSTRAINT [PK__tbl_loph__E0EC3A86A06093F6] PRIMARY KEY CLUSTERED 
(
	[id_lophoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_lophocphan](
	[id_lophocphan] [int] IDENTITY(1,1) NOT NULL,
	[id_lophoc] [int] NULL,
	[id_monhoc] [int] NULL,
	[id_gv] [int] NULL,
	[hocky] [int] NULL,
	[nam] [int] NULL,
 CONSTRAINT [PK__tbl_loph__EE3A334E01005D05] PRIMARY KEY CLUSTERED 
(
	[id_lophocphan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_monhoc](
	[id_monhoc] [int] IDENTITY(1,1) NOT NULL,
	[tenmonhoc] [nvarchar](50) NULL,
	[sotinchi] [int] NULL,
 CONSTRAINT [PK__tbl_monh__8EF087A0F434457A] PRIMARY KEY CLUSTERED 
(
	[id_monhoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_nguoidung](
	[tendangnhap] [nvarchar](50) NOT NULL,
	[matkhau] [varchar](50) NULL,
	[loainguoidung] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_nguoidung] PRIMARY KEY CLUSTERED 
(
	[tendangnhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_sinhvien](
	[id_sv] [int] IDENTITY(1,1) NOT NULL,
	[hodem] [nvarchar](50) NULL,
	[ten] [nvarchar](50) NULL,
	[ngaysinh] [date] NULL,
	[gioitinh] [bit] NULL,
	[quequan] [nvarchar](50) NULL,
	[sdt] [int] NULL,
	[id_lophoc] [int] NULL,
	[tendangnhap] [nvarchar](50) NULL,
 CONSTRAINT [PK__tbl_sinh__014858E90061D095] PRIMARY KEY CLUSTERED 
(
	[id_sv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_diem] ON 

INSERT [dbo].[tbl_diem] ([id_diem], [id_sv], [id_monhoc], [diemchuyencan], [diemheso1], [diemheso2_t1], [diemheso2_t2], [diemquatrinh], [diemthi], [diemhocphan]) VALUES (1, 1, 1, 10, 10, 9, 9, 9.5, 10, 9.8)
INSERT [dbo].[tbl_diem] ([id_diem], [id_sv], [id_monhoc], [diemchuyencan], [diemheso1], [diemheso2_t1], [diemheso2_t2], [diemquatrinh], [diemthi], [diemhocphan]) VALUES (2, 2, 1, 8, 8, 10, 10, 9, 7, 7.8)
INSERT [dbo].[tbl_diem] ([id_diem], [id_sv], [id_monhoc], [diemchuyencan], [diemheso1], [diemheso2_t1], [diemheso2_t2], [diemquatrinh], [diemthi], [diemhocphan]) VALUES (3, 1, 2, 8, 8, 8, 7, 7.75, 9, 8.5)
INSERT [dbo].[tbl_diem] ([id_diem], [id_sv], [id_monhoc], [diemchuyencan], [diemheso1], [diemheso2_t1], [diemheso2_t2], [diemquatrinh], [diemthi], [diemhocphan]) VALUES (4, 2, 2, 6, 5, 8, 10, 7.38, 10, 8.95)
INSERT [dbo].[tbl_diem] ([id_diem], [id_sv], [id_monhoc], [diemchuyencan], [diemheso1], [diemheso2_t1], [diemheso2_t2], [diemquatrinh], [diemthi], [diemhocphan]) VALUES (5, 4, 2, 10, 5, 8, 10, 8.88, 8, 8.35)
INSERT [dbo].[tbl_diem] ([id_diem], [id_sv], [id_monhoc], [diemchuyencan], [diemheso1], [diemheso2_t1], [diemheso2_t2], [diemquatrinh], [diemthi], [diemhocphan]) VALUES (6, 3, 1, 10, 10, 10, 10, 10, 8, 8.8)
INSERT [dbo].[tbl_diem] ([id_diem], [id_sv], [id_monhoc], [diemchuyencan], [diemheso1], [diemheso2_t1], [diemheso2_t2], [diemquatrinh], [diemthi], [diemhocphan]) VALUES (7, 4, 1, 9, 8, 8, 8, 8.38, 10, 9.35)
SET IDENTITY_INSERT [dbo].[tbl_diem] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_giaovien] ON 

INSERT [dbo].[tbl_giaovien] ([id_gv], [hoten_gv], [ngaysinh], [id_khoa], [tendangnhap]) VALUES (1, N'Trần Thị Hoa', CAST(N'2002-08-28' AS Date), 1, N'hoa')
INSERT [dbo].[tbl_giaovien] ([id_gv], [hoten_gv], [ngaysinh], [id_khoa], [tendangnhap]) VALUES (2, N'Lê Văn Bách', CAST(N'1989-02-08' AS Date), 2, N'bach')
SET IDENTITY_INSERT [dbo].[tbl_giaovien] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_khoa] ON 

INSERT [dbo].[tbl_khoa] ([id_khoa], [tenkhoa]) VALUES (1, N'CNTT')
INSERT [dbo].[tbl_khoa] ([id_khoa], [tenkhoa]) VALUES (2, N'Kế Toán')
INSERT [dbo].[tbl_khoa] ([id_khoa], [tenkhoa]) VALUES (3, N'Điện Tử')
INSERT [dbo].[tbl_khoa] ([id_khoa], [tenkhoa]) VALUES (4, N'Thương Mại')
SET IDENTITY_INSERT [dbo].[tbl_khoa] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_lophoc] ON 

INSERT [dbo].[tbl_lophoc] ([id_lophoc], [tenlop], [khoahoc], [hedaotao], [namnhaphoc], [id_khoa]) VALUES (1, N'DHTI14A9HN', N'K14', N'Đại Học', 2020, 1)
INSERT [dbo].[tbl_lophoc] ([id_lophoc], [tenlop], [khoahoc], [hedaotao], [namnhaphoc], [id_khoa]) VALUES (2, N'DHDT16A10HN', N'K16', N'Đại Học', 2020, 3)
INSERT [dbo].[tbl_lophoc] ([id_lophoc], [tenlop], [khoahoc], [hedaotao], [namnhaphoc], [id_khoa]) VALUES (3, N'DHKT17A8ND', N'K17', N'Đại Học', 2025, 2)
INSERT [dbo].[tbl_lophoc] ([id_lophoc], [tenlop], [khoahoc], [hedaotao], [namnhaphoc], [id_khoa]) VALUES (4, N'CDTM14A1HN', N'K14', N'Cao Đẳng', 2020, 4)
SET IDENTITY_INSERT [dbo].[tbl_lophoc] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_lophocphan] ON 

INSERT [dbo].[tbl_lophocphan] ([id_lophocphan], [id_lophoc], [id_monhoc], [id_gv], [hocky], [nam]) VALUES (1, 1, 1, 1, 1, 2020)
INSERT [dbo].[tbl_lophocphan] ([id_lophocphan], [id_lophoc], [id_monhoc], [id_gv], [hocky], [nam]) VALUES (2, 1, 2, 1, 2, 2020)
INSERT [dbo].[tbl_lophocphan] ([id_lophocphan], [id_lophoc], [id_monhoc], [id_gv], [hocky], [nam]) VALUES (3, 2, 3, 1, 1, 2021)
INSERT [dbo].[tbl_lophocphan] ([id_lophocphan], [id_lophoc], [id_monhoc], [id_gv], [hocky], [nam]) VALUES (4, 2, 1, 1, 3, 2022)
INSERT [dbo].[tbl_lophocphan] ([id_lophocphan], [id_lophoc], [id_monhoc], [id_gv], [hocky], [nam]) VALUES (5, 3, 4, 1, 5, 2025)
INSERT [dbo].[tbl_lophocphan] ([id_lophocphan], [id_lophoc], [id_monhoc], [id_gv], [hocky], [nam]) VALUES (6, 3, 2, 1, 4, 2024)
SET IDENTITY_INSERT [dbo].[tbl_lophocphan] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_monhoc] ON 

INSERT [dbo].[tbl_monhoc] ([id_monhoc], [tenmonhoc], [sotinchi]) VALUES (1, N'.net', 3)
INSERT [dbo].[tbl_monhoc] ([id_monhoc], [tenmonhoc], [sotinchi]) VALUES (2, N'java', 3)
INSERT [dbo].[tbl_monhoc] ([id_monhoc], [tenmonhoc], [sotinchi]) VALUES (3, N'PHP', 3)
INSERT [dbo].[tbl_monhoc] ([id_monhoc], [tenmonhoc], [sotinchi]) VALUES (4, N'Triết', 2)
INSERT [dbo].[tbl_monhoc] ([id_monhoc], [tenmonhoc], [sotinchi]) VALUES (5, N'Thể dục', 1)
INSERT [dbo].[tbl_monhoc] ([id_monhoc], [tenmonhoc], [sotinchi]) VALUES (6, N'An toàn thông tin', 2)
SET IDENTITY_INSERT [dbo].[tbl_monhoc] OFF
GO
INSERT [dbo].[tbl_nguoidung] ([tendangnhap], [matkhau], [loainguoidung]) VALUES (N'admin', N'admin', N'0')
INSERT [dbo].[tbl_nguoidung] ([tendangnhap], [matkhau], [loainguoidung]) VALUES (N'hoa', N'456', N'1')
INSERT [dbo].[tbl_nguoidung] ([tendangnhap], [matkhau], [loainguoidung]) VALUES (N'bach', N'456', N'1')
INSERT [dbo].[tbl_nguoidung] ([tendangnhap], [matkhau], [loainguoidung]) VALUES (N'ha', N'123', N'3')
INSERT [dbo].[tbl_nguoidung] ([tendangnhap], [matkhau], [loainguoidung]) VALUES (N'thao', N'123', N'3')
INSERT [dbo].[tbl_nguoidung] ([tendangnhap], [matkhau], [loainguoidung]) VALUES (N'mai', N'123', N'3')
INSERT [dbo].[tbl_nguoidung] ([tendangnhap], [matkhau], [loainguoidung]) VALUES (N'van', N'123', N'3')
INSERT [dbo].[tbl_nguoidung] ([tendangnhap], [matkhau], [loainguoidung]) VALUES (N'quan', N'123', N'3')
INSERT [dbo].[tbl_nguoidung] ([tendangnhap], [matkhau], [loainguoidung]) VALUES (N'lien', N'123', N'3')
INSERT [dbo].[tbl_nguoidung] ([tendangnhap], [matkhau], [loainguoidung]) VALUES (N'giang', N'123', N'3')
GO
SET IDENTITY_INSERT [dbo].[tbl_sinhvien] ON 

INSERT [dbo].[tbl_sinhvien] ([id_sv], [hodem], [ten], [ngaysinh], [gioitinh], [quequan], [sdt], [id_lophoc], [tendangnhap]) VALUES (1, N'Ngô Khánh', N'Hạ', CAST(N'2002-08-04' AS Date), 1, N'Hà Nội', 123456789, 1, N'ha')
INSERT [dbo].[tbl_sinhvien] ([id_sv], [hodem], [ten], [ngaysinh], [gioitinh], [quequan], [sdt], [id_lophoc], [tendangnhap]) VALUES (2, N'Hoàng Thị Thu', N'Thảo', CAST(N'2002-08-28' AS Date), 1, N'Hà Nội', 25896325, 1, N'thao')
INSERT [dbo].[tbl_sinhvien] ([id_sv], [hodem], [ten], [ngaysinh], [gioitinh], [quequan], [sdt], [id_lophoc], [tendangnhap]) VALUES (3, N'Nguyễn Thảo', N'Vân', CAST(N'2002-02-04' AS Date), 1, N'Hà Nội', 36985214, 1, N'van')
INSERT [dbo].[tbl_sinhvien] ([id_sv], [hodem], [ten], [ngaysinh], [gioitinh], [quequan], [sdt], [id_lophoc], [tendangnhap]) VALUES (4, N'Nguyễn Thị Thanh', N'Mai', CAST(N'2002-01-17' AS Date), 1, N'Hà Nội', 369852147, 1, N'mai')
INSERT [dbo].[tbl_sinhvien] ([id_sv], [hodem], [ten], [ngaysinh], [gioitinh], [quequan], [sdt], [id_lophoc], [tendangnhap]) VALUES (5, N'Chu Minh', N'Quân', CAST(N'2002-08-08' AS Date), 0, N'Nam Định', 582369859, 2, N'quan')
INSERT [dbo].[tbl_sinhvien] ([id_sv], [hodem], [ten], [ngaysinh], [gioitinh], [quequan], [sdt], [id_lophoc], [tendangnhap]) VALUES (6, N'Lê Thị Phương', N'Liên', CAST(N'2002-01-01' AS Date), 1, N'Thanh Hóa', 859665856, 2, N'liên')
INSERT [dbo].[tbl_sinhvien] ([id_sv], [hodem], [ten], [ngaysinh], [gioitinh], [quequan], [sdt], [id_lophoc], [tendangnhap]) VALUES (7, N'Nguyễn Thị', N'Giang', CAST(N'2002-08-08' AS Date), 1, N'Bắc Ninh', 789456585, 2, N'giang')
SET IDENTITY_INSERT [dbo].[tbl_sinhvien] OFF
GO
ALTER TABLE [dbo].[tbl_diem]  WITH CHECK ADD  CONSTRAINT [FK_tbl_diem_tbl_diem] FOREIGN KEY([id_sv])
REFERENCES [dbo].[tbl_sinhvien] ([id_sv])
GO
ALTER TABLE [dbo].[tbl_diem] CHECK CONSTRAINT [FK_tbl_diem_tbl_diem]
GO
ALTER TABLE [dbo].[tbl_diem]  WITH CHECK ADD  CONSTRAINT [FK_tbl_diem_tbl_monhoc] FOREIGN KEY([id_monhoc])
REFERENCES [dbo].[tbl_monhoc] ([id_monhoc])
GO
ALTER TABLE [dbo].[tbl_diem] CHECK CONSTRAINT [FK_tbl_diem_tbl_monhoc]
GO
ALTER TABLE [dbo].[tbl_giaovien]  WITH CHECK ADD  CONSTRAINT [FK_tbl_giaovien_tbl_khoa] FOREIGN KEY([id_khoa])
REFERENCES [dbo].[tbl_khoa] ([id_khoa])
GO
ALTER TABLE [dbo].[tbl_giaovien] CHECK CONSTRAINT [FK_tbl_giaovien_tbl_khoa]
GO
ALTER TABLE [dbo].[tbl_giaovien]  WITH CHECK ADD  CONSTRAINT [FK_tbl_giaovien_tbl_nguoidung] FOREIGN KEY([tendangnhap])
REFERENCES [dbo].[tbl_nguoidung] ([tendangnhap])
GO
ALTER TABLE [dbo].[tbl_giaovien] CHECK CONSTRAINT [FK_tbl_giaovien_tbl_nguoidung]
GO
ALTER TABLE [dbo].[tbl_lophoc]  WITH CHECK ADD  CONSTRAINT [FK_tbl_lophoc_tbl_khoa] FOREIGN KEY([id_khoa])
REFERENCES [dbo].[tbl_khoa] ([id_khoa])
GO
ALTER TABLE [dbo].[tbl_lophoc] CHECK CONSTRAINT [FK_tbl_lophoc_tbl_khoa]
GO
ALTER TABLE [dbo].[tbl_lophocphan]  WITH CHECK ADD  CONSTRAINT [FK_tbl_lophocphan_tbl_giaovien] FOREIGN KEY([id_gv])
REFERENCES [dbo].[tbl_giaovien] ([id_gv])
GO
ALTER TABLE [dbo].[tbl_lophocphan] CHECK CONSTRAINT [FK_tbl_lophocphan_tbl_giaovien]
GO
ALTER TABLE [dbo].[tbl_lophocphan]  WITH CHECK ADD  CONSTRAINT [FK_tbl_lophocphan_tbl_lophocphan] FOREIGN KEY([id_lophoc])
REFERENCES [dbo].[tbl_lophoc] ([id_lophoc])
GO
ALTER TABLE [dbo].[tbl_lophocphan] CHECK CONSTRAINT [FK_tbl_lophocphan_tbl_lophocphan]
GO
ALTER TABLE [dbo].[tbl_lophocphan]  WITH CHECK ADD  CONSTRAINT [FK_tbl_lophocphan_tbl_monhoc] FOREIGN KEY([id_monhoc])
REFERENCES [dbo].[tbl_monhoc] ([id_monhoc])
GO
ALTER TABLE [dbo].[tbl_lophocphan] CHECK CONSTRAINT [FK_tbl_lophocphan_tbl_monhoc]
GO
ALTER TABLE [dbo].[tbl_sinhvien]  WITH CHECK ADD  CONSTRAINT [FK_tbl_sinhvien_tbl_lophoc] FOREIGN KEY([id_lophoc])
REFERENCES [dbo].[tbl_lophoc] ([id_lophoc])
GO
ALTER TABLE [dbo].[tbl_sinhvien] CHECK CONSTRAINT [FK_tbl_sinhvien_tbl_lophoc]
GO
ALTER TABLE [dbo].[tbl_sinhvien]  WITH CHECK ADD  CONSTRAINT [FK_tbl_sinhvien_tbl_nguoidung] FOREIGN KEY([tendangnhap])
REFERENCES [dbo].[tbl_nguoidung] ([tendangnhap])
GO
ALTER TABLE [dbo].[tbl_sinhvien] CHECK CONSTRAINT [FK_tbl_sinhvien_tbl_nguoidung]
GO
USE [master]
GO
ALTER DATABASE [quanlysinhvien] SET  READ_WRITE 
GO
