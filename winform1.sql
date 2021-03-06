USE [master]
GO
/****** Object:  Database [winform1]    Script Date: 6/10/2022 6:02:33 PM ******/
CREATE DATABASE [winform1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'winform1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\winform1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'winform1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\winform1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [winform1] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [winform1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [winform1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [winform1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [winform1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [winform1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [winform1] SET ARITHABORT OFF 
GO
ALTER DATABASE [winform1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [winform1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [winform1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [winform1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [winform1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [winform1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [winform1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [winform1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [winform1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [winform1] SET  DISABLE_BROKER 
GO
ALTER DATABASE [winform1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [winform1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [winform1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [winform1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [winform1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [winform1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [winform1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [winform1] SET RECOVERY FULL 
GO
ALTER DATABASE [winform1] SET  MULTI_USER 
GO
ALTER DATABASE [winform1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [winform1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [winform1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [winform1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [winform1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [winform1] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'winform1', N'ON'
GO
ALTER DATABASE [winform1] SET QUERY_STORE = OFF
GO
USE [winform1]
GO
/****** Object:  User [vanlinh]    Script Date: 6/10/2022 6:02:33 PM ******/
CREATE USER [vanlinh] FOR LOGIN [vanlinh] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 6/10/2022 6:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[id] [nchar](10) NOT NULL,
	[hoten] [nchar](10) NULL,
	[chucvu] [nchar](10) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbuser]    Script Date: 6/10/2022 6:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbuser](
	[user] [nchar](30) NULL,
	[password] [nchar](32) NULL,
	[admin_role] [nchar](10) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[NhanVien] ([id], [hoten], [chucvu]) VALUES (N'1         ', N'Ex Linh   ', N'Người Dùng')
INSERT [dbo].[NhanVien] ([id], [hoten], [chucvu]) VALUES (N'2         ', N'Nam Vũ    ', N'Người Dùng')
INSERT [dbo].[NhanVien] ([id], [hoten], [chucvu]) VALUES (N'3         ', N'Huy       ', N'Người Dùng')
GO
INSERT [dbo].[tbuser] ([user], [password], [admin_role]) VALUES (N'vanlinh                       ', N'123456                          ', N'1         ')
INSERT [dbo].[tbuser] ([user], [password], [admin_role]) VALUES (N'linh                          ', N'123456                          ', N'n         ')
GO
USE [master]
GO
ALTER DATABASE [winform1] SET  READ_WRITE 
GO
