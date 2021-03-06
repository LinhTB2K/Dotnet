USE [master]
GO
/****** Object:  Database [QLKho]    Script Date: 6/10/2022 5:59:42 PM ******/
CREATE DATABASE [QLKho]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLKho', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLKho.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLKho_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLKho_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLKho] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLKho].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLKho] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLKho] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLKho] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLKho] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLKho] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLKho] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLKho] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLKho] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLKho] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLKho] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLKho] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLKho] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLKho] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLKho] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLKho] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLKho] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLKho] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLKho] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLKho] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLKho] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLKho] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLKho] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLKho] SET RECOVERY FULL 
GO
ALTER DATABASE [QLKho] SET  MULTI_USER 
GO
ALTER DATABASE [QLKho] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLKho] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLKho] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLKho] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLKho] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLKho] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLKho', N'ON'
GO
ALTER DATABASE [QLKho] SET QUERY_STORE = OFF
GO
USE [QLKho]
GO
/****** Object:  User [vanlinh]    Script Date: 6/10/2022 5:59:42 PM ******/
CREATE USER [vanlinh] FOR LOGIN [vanlinh] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[CTPhieuNhap]    Script Date: 6/10/2022 5:59:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPhieuNhap](
	[MaCTPhieu] [nchar](10) NOT NULL,
	[MaPhieuNhap] [nchar](10) NULL,
	[MaSP] [nchar](10) NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_CTPhieuNhap_1] PRIMARY KEY CLUSTERED 
(
	[MaCTPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kho]    Script Date: 6/10/2022 5:59:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kho](
	[Makho] [nchar](10) NOT NULL,
	[Diachi] [nchar](10) NULL,
	[Succhua] [nchar](10) NULL,
 CONSTRAINT [PK_Kho] PRIMARY KEY CLUSTERED 
(
	[Makho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nguoidung]    Script Date: 6/10/2022 5:59:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nguoidung](
	[TaiKhoan] [nchar](10) NULL,
	[MatKhau] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 6/10/2022 5:59:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPhieuNhap] [nchar](10) NOT NULL,
	[MaKho] [nchar](10) NULL,
	[NgayNhap] [nchar](10) NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 6/10/2022 5:59:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [nchar](10) NOT NULL,
	[TenSp] [nchar](10) NULL,
	[MoTa] [ntext] NULL,
	[TonKho] [nchar](10) NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[CTPhieuNhap] ([MaCTPhieu], [MaPhieuNhap], [MaSP], [SoLuong]) VALUES (N'CT01      ', N'P01       ', N'SP01      ', 3)
INSERT [dbo].[CTPhieuNhap] ([MaCTPhieu], [MaPhieuNhap], [MaSP], [SoLuong]) VALUES (N'CT02      ', N'P01       ', N'SP02      ', 4)
INSERT [dbo].[CTPhieuNhap] ([MaCTPhieu], [MaPhieuNhap], [MaSP], [SoLuong]) VALUES (N'CT03      ', N'P02       ', N'SP03      ', 4)
GO
INSERT [dbo].[Kho] ([Makho], [Diachi], [Succhua]) VALUES (N'K01       ', N'Thai Binh ', N'3         ')
INSERT [dbo].[Kho] ([Makho], [Diachi], [Succhua]) VALUES (N'K02       ', N'Nam Định  ', N'4         ')
INSERT [dbo].[Kho] ([Makho], [Diachi], [Succhua]) VALUES (N'K03       ', N'Hòa Bình  ', N'4         ')
GO
INSERT [dbo].[Nguoidung] ([TaiKhoan], [MatKhau]) VALUES (N'admin     ', N'123456    ')
GO
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaKho], [NgayNhap]) VALUES (N'P01       ', N'K01       ', N'31/05/2022')
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaKho], [NgayNhap]) VALUES (N'P02       ', N'K02       ', N'1/6/2022  ')
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [MoTa], [TonKho]) VALUES (N'SP01      ', N'Hoa Hồng  ', N'Hoa màu đỏ', N'5         ')
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [MoTa], [TonKho]) VALUES (N'SP02      ', N'Hoa Cúc   ', N'Hoa màu vàng', N'4         ')
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [MoTa], [TonKho]) VALUES (N'SP03      ', N'Hoa Lan   ', N'Hoa màu trắng', N'5         ')
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [MoTa], [TonKho]) VALUES (N'SP04      ', N'Hoa Nhài  ', N'Hoa màu vàng', N'6         ')
INSERT [dbo].[SanPham] ([MaSP], [TenSp], [MoTa], [TonKho]) VALUES (N'SP05      ', N'Hoa Đào   ', N'Hoa màu đỏ', N'1         ')
GO
ALTER TABLE [dbo].[CTPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuNhap_PhieuNhap] FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PhieuNhap] ([MaPhieuNhap])
GO
ALTER TABLE [dbo].[CTPhieuNhap] CHECK CONSTRAINT [FK_CTPhieuNhap_PhieuNhap]
GO
ALTER TABLE [dbo].[CTPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuNhap_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[CTPhieuNhap] CHECK CONSTRAINT [FK_CTPhieuNhap_SanPham]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_Kho] FOREIGN KEY([MaKho])
REFERENCES [dbo].[Kho] ([Makho])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_Kho]
GO
USE [master]
GO
ALTER DATABASE [QLKho] SET  READ_WRITE 
GO
