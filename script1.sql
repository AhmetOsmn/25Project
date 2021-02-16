USE [master]
GO
/****** Object:  Database [DbNotKayit]    Script Date: 17.02.2021 02:10:00 ******/
CREATE DATABASE [DbNotKayit]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DbNotKayit', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DbNotKayit.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DbNotKayit_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DbNotKayit_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DbNotKayit] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DbNotKayit].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DbNotKayit] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DbNotKayit] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DbNotKayit] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DbNotKayit] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DbNotKayit] SET ARITHABORT OFF 
GO
ALTER DATABASE [DbNotKayit] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DbNotKayit] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DbNotKayit] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DbNotKayit] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DbNotKayit] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DbNotKayit] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DbNotKayit] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DbNotKayit] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DbNotKayit] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DbNotKayit] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DbNotKayit] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DbNotKayit] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DbNotKayit] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DbNotKayit] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DbNotKayit] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DbNotKayit] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DbNotKayit] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DbNotKayit] SET RECOVERY FULL 
GO
ALTER DATABASE [DbNotKayit] SET  MULTI_USER 
GO
ALTER DATABASE [DbNotKayit] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DbNotKayit] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DbNotKayit] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DbNotKayit] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DbNotKayit] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DbNotKayit] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DbNotKayit', N'ON'
GO
ALTER DATABASE [DbNotKayit] SET QUERY_STORE = OFF
GO
USE [DbNotKayit]
GO
/****** Object:  Table [dbo].[TblDers]    Script Date: 17.02.2021 02:10:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblDers](
	[OgrenciId] [smallint] IDENTITY(1,1) NOT NULL,
	[OgrenciNumara] [nchar](4) NULL,
	[OgrenciAd] [varchar](20) NULL,
	[OgrenciSoyad] [varchar](30) NULL,
	[OgrenciSinav1] [tinyint] NULL,
	[OgrenciSinav2] [tinyint] NULL,
	[Ortalama] [decimal](18, 2) NULL,
	[Durum] [bit] NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [DbNotKayit] SET  READ_WRITE 
GO
