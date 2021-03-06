USE [master]
GO
/****** Object:  Database [QLSinhVien]    Script Date: 6/10/2022 6:01:19 PM ******/
CREATE DATABASE [QLSinhVien]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLSinhVien', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLSinhVien.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLSinhVien_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLSinhVien_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLSinhVien] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLSinhVien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLSinhVien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLSinhVien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLSinhVien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLSinhVien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLSinhVien] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLSinhVien] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLSinhVien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLSinhVien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLSinhVien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLSinhVien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLSinhVien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLSinhVien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLSinhVien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLSinhVien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLSinhVien] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLSinhVien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLSinhVien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLSinhVien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLSinhVien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLSinhVien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLSinhVien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLSinhVien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLSinhVien] SET RECOVERY FULL 
GO
ALTER DATABASE [QLSinhVien] SET  MULTI_USER 
GO
ALTER DATABASE [QLSinhVien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLSinhVien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLSinhVien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLSinhVien] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLSinhVien] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLSinhVien] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLSinhVien', N'ON'
GO
ALTER DATABASE [QLSinhVien] SET QUERY_STORE = OFF
GO
USE [QLSinhVien]
GO
/****** Object:  User [vanlinh]    Script Date: 6/10/2022 6:01:19 PM ******/
CREATE USER [vanlinh] FOR LOGIN [vanlinh] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 6/10/2022 6:01:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[username] [nchar](10) NOT NULL,
	[password] [nchar](10) NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 6/10/2022 6:01:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[id] [int] NULL,
	[masinhvien] [nchar](25) NULL,
	[tensinhvien] [nchar](50) NULL,
	[tuoisinhvien] [nchar](10) NULL,
	[gioitinh] [nchar](10) NULL,
	[diachi] [nchar](255) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Admin] ([username], [password]) VALUES (N'          ', N'          ')
INSERT [dbo].[Admin] ([username], [password]) VALUES (N'admin     ', N'123456    ')
INSERT [dbo].[Admin] ([username], [password]) VALUES (N'linh      ', N'111111    ')
GO
INSERT [dbo].[SinhVien] ([id], [masinhvien], [tensinhvien], [tuoisinhvien], [gioitinh], [diachi]) VALUES (1, N'18810923                 ', N'Nguyễn Văn Linh                                   ', N'22        ', N'Nam       ', N'Thái Bình                                                                                                                                                                                                                                                      ')
INSERT [dbo].[SinhVien] ([id], [masinhvien], [tensinhvien], [tuoisinhvien], [gioitinh], [diachi]) VALUES (3, N'123546546                ', N'Linh Not Ninh                                     ', N'22        ', N'Nam       ', N'Thái Bình                                                                                                                                                                                                                                                      ')
INSERT [dbo].[SinhVien] ([id], [masinhvien], [tensinhvien], [tuoisinhvien], [gioitinh], [diachi]) VALUES (2, N'1881092837               ', N'Vũ Huy Huy                                        ', N'20        ', N'Nam       ', N'Ninh Bình                                                                                                                                                                                                                                                      ')
GO
USE [master]
GO
ALTER DATABASE [QLSinhVien] SET  READ_WRITE 
GO
