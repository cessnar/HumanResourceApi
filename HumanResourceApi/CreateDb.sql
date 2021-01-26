USE [master]
GO

/****** Object:  Database [HumanResourceApplicationMainMain]    Script Date: 6/10/2019 4:05:22 PM ******/
CREATE DATABASE [HumanResourceApplicationMainMain]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HumanResourceApplicationMainMain', FILENAME = N'C:\Users\admin\HumanResourceApplicationMainMain.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HumanResourceApplicationMainMain_log', FILENAME = N'C:\Users\admin\HumanResourceApplicationMainMain_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HumanResourceApplicationMainMain].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [HumanResourceApplicationMainMain] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [HumanResourceApplicationMainMain] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [HumanResourceApplicationMainMain] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [HumanResourceApplicationMainMain] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [HumanResourceApplicationMainMain] SET ARITHABORT OFF 
GO

ALTER DATABASE [HumanResourceApplicationMainMain] SET AUTO_CLOSE ON 
GO

ALTER DATABASE [HumanResourceApplicationMainMain] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [HumanResourceApplicationMainMain] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [HumanResourceApplicationMainMain] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [HumanResourceApplicationMainMain] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [HumanResourceApplicationMainMain] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [HumanResourceApplicationMainMain] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [HumanResourceApplicationMainMain] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [HumanResourceApplicationMainMain] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [HumanResourceApplicationMainMain] SET  ENABLE_BROKER 
GO

ALTER DATABASE [HumanResourceApplicationMainMain] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [HumanResourceApplicationMainMain] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [HumanResourceApplicationMainMain] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [HumanResourceApplicationMainMain] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [HumanResourceApplicationMainMain] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [HumanResourceApplicationMainMain] SET READ_COMMITTED_SNAPSHOT ON 
GO

ALTER DATABASE [HumanResourceApplicationMainMain] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [HumanResourceApplicationMainMain] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [HumanResourceApplicationMainMain] SET  MULTI_USER 
GO

ALTER DATABASE [HumanResourceApplicationMainMain] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [HumanResourceApplicationMainMain] SET DB_CHAINING OFF 
GO

ALTER DATABASE [HumanResourceApplicationMainMain] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [HumanResourceApplicationMainMain] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [HumanResourceApplicationMainMain] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [HumanResourceApplicationMainMain] SET QUERY_STORE = OFF
GO

USE [HumanResourceApplicationMainMain]
GO

ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO

ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO

ALTER DATABASE [HumanResourceApplicationMainMain] SET  READ_WRITE 
GO

