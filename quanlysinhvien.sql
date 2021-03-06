USE [master]
GO
/****** Object:  Database [quanlysinhvien]    Script Date: 6/10/2022 6:01:57 PM ******/
CREATE DATABASE [quanlysinhvien]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'quanlysinhvien', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\quanlysinhvien.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'quanlysinhvien_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\quanlysinhvien_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [quanlysinhvien] SET COMPATIBILITY_LEVEL = 150
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
ALTER DATABASE [quanlysinhvien] SET RECOVERY FULL 
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
EXEC sys.sp_db_vardecimal_storage_format N'quanlysinhvien', N'ON'
GO
ALTER DATABASE [quanlysinhvien] SET QUERY_STORE = OFF
GO
USE [quanlysinhvien]
GO
/****** Object:  User [vanlinh]    Script Date: 6/10/2022 6:01:57 PM ******/
CREATE USER [vanlinh] FOR LOGIN [vanlinh] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[tbnhanvien]    Script Date: 6/10/2022 6:01:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbnhanvien](
	[student_code] [nvarchar](30) NOT NULL,
	[student_id] [int] NOT NULL,
	[student_fullname] [varchar](30) NOT NULL,
	[student_class] [varchar](30) NOT NULL,
	[student_address] [varchar](30) NOT NULL,
	[student_gender] [varchar](30) NOT NULL,
	[student_age] [int] NOT NULL,
	[student_email] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbnhanvien] PRIMARY KEY CLUSTERED 
(
	[student_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbuser]    Script Date: 6/10/2022 6:01:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbuser](
	[username] [varchar](30) NOT NULL,
	[password] [varchar](32) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[tbnhanvien] ([student_code], [student_id], [student_fullname], [student_class], [student_address], [student_gender], [student_age], [student_email]) VALUES (N'18810310325', 1, N'Nguyen Van Linh', N'D15CNPM4', N'Hoa Binh', N'Nam', 20, N'vanlinhkxtb@gmail.com')
INSERT [dbo].[tbnhanvien] ([student_code], [student_id], [student_fullname], [student_class], [student_address], [student_gender], [student_age], [student_email]) VALUES (N'20321261343', 2, N'Nguyen Huy Kien', N'D15CNPM4', N'Bac Giang', N'Nam', 20, N'kienbacgiangdz@gmail.com')
INSERT [dbo].[tbnhanvien] ([student_code], [student_id], [student_fullname], [student_class], [student_address], [student_gender], [student_age], [student_email]) VALUES (N'29743743847', 3, N'Tran Huy', N'D15CNPM4', N'Nam Dinh', N'Nam', 20, N'huytranhhaihaund@gmail.com')
INSERT [dbo].[tbnhanvien] ([student_code], [student_id], [student_fullname], [student_class], [student_address], [student_gender], [student_age], [student_email]) VALUES (N'29743744666', 4, N'Nguyen Lan Anh', N'D15CNPM4', N'Ha Noi', N'Nu', 20, N'lananhne@gmail.com')
GO
INSERT [dbo].[tbuser] ([username], [password]) VALUES (N'vanlinh', N'123456')
GO
USE [master]
GO
ALTER DATABASE [quanlysinhvien] SET  READ_WRITE 
GO
