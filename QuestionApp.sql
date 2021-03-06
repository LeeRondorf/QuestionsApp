USE [master]
GO

/****** Object:  Database [QuestionApp]    Script Date: 4/16/2019 10:18:08 AM ******/
CREATE DATABASE [QuestionApp]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuestionApp', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QuestionApp.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuestionApp_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QuestionApp_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [QuestionApp] SET COMPATIBILITY_LEVEL = 120
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuestionApp].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [QuestionApp] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [QuestionApp] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [QuestionApp] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [QuestionApp] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [QuestionApp] SET ARITHABORT OFF 
GO

ALTER DATABASE [QuestionApp] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [QuestionApp] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [QuestionApp] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [QuestionApp] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [QuestionApp] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [QuestionApp] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [QuestionApp] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [QuestionApp] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [QuestionApp] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [QuestionApp] SET  DISABLE_BROKER 
GO

ALTER DATABASE [QuestionApp] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [QuestionApp] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [QuestionApp] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [QuestionApp] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [QuestionApp] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [QuestionApp] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [QuestionApp] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [QuestionApp] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [QuestionApp] SET  MULTI_USER 
GO

ALTER DATABASE [QuestionApp] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [QuestionApp] SET DB_CHAINING OFF 
GO

ALTER DATABASE [QuestionApp] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [QuestionApp] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [QuestionApp] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [QuestionApp] SET  READ_WRITE 
GO

