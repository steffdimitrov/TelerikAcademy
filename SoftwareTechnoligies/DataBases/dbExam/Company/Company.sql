USE [master]
GO
/****** Object:  Database [Company]    Script Date: 09/08/2014 12:46:00 ******/
CREATE DATABASE [Company] ON  PRIMARY 
( NAME = N'Company', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Company.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Company_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Company_log.ldf' , SIZE = 2304KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Company] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Company].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Company] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [Company] SET ANSI_NULLS OFF
GO
ALTER DATABASE [Company] SET ANSI_PADDING OFF
GO
ALTER DATABASE [Company] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [Company] SET ARITHABORT OFF
GO
ALTER DATABASE [Company] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [Company] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [Company] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [Company] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [Company] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [Company] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [Company] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [Company] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Company] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [Company] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [Company] SET  DISABLE_BROKER
GO
ALTER DATABASE [Company] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [Company] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [Company] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [Company] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [Company] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [Company] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [Company] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [Company] SET  READ_WRITE
GO
ALTER DATABASE [Company] SET RECOVERY FULL
GO
ALTER DATABASE [Company] SET  MULTI_USER
GO
ALTER DATABASE [Company] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [Company] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'Company', N'ON'
GO
USE [Company]
GO
/****** Object:  Table [dbo].[Projects]    Script Date: 09/08/2014 12:46:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Projects](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Projects] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 09/08/2014 12:46:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Departments_Name_Unique] ON [dbo].[Departments] 
(
	[Name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 09/08/2014 12:46:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](20) NOT NULL,
	[LastName] [nvarchar](20) NOT NULL,
	[YearSalary] [money] NOT NULL,
	[ManagerId] [int] NULL,
	[DepartmentId] [int] NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reports]    Script Date: 09/08/2014 12:46:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reports](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Time] [datetime] NOT NULL,
	[EmployeeId] [int] NOT NULL,
 CONSTRAINT [PK_Reports] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeesProjects]    Script Date: 09/08/2014 12:46:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeesProjects](
	[EmployeeId] [int] NOT NULL,
	[ProjectId] [int] NOT NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
 CONSTRAINT [PK_EmployeesProjects] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC,
	[ProjectId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Employees_Departments1]    Script Date: 09/08/2014 12:46:01 ******/
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Departments1] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Departments] ([Id])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Departments1]
GO
/****** Object:  ForeignKey [FK_Employees_Employees]    Script Date: 09/08/2014 12:46:01 ******/
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Employees] FOREIGN KEY([ManagerId])
REFERENCES [dbo].[Employees] ([Id])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Employees]
GO
/****** Object:  ForeignKey [FK_Reports_Employees]    Script Date: 09/08/2014 12:46:01 ******/
ALTER TABLE [dbo].[Reports]  WITH CHECK ADD  CONSTRAINT [FK_Reports_Employees] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employees] ([Id])
GO
ALTER TABLE [dbo].[Reports] CHECK CONSTRAINT [FK_Reports_Employees]
GO
/****** Object:  ForeignKey [FK_EmployeesProjects_Employees]    Script Date: 09/08/2014 12:46:01 ******/
ALTER TABLE [dbo].[EmployeesProjects]  WITH CHECK ADD  CONSTRAINT [FK_EmployeesProjects_Employees] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employees] ([Id])
GO
ALTER TABLE [dbo].[EmployeesProjects] CHECK CONSTRAINT [FK_EmployeesProjects_Employees]
GO
/****** Object:  ForeignKey [FK_EmployeesProjects_Projects]    Script Date: 09/08/2014 12:46:01 ******/
ALTER TABLE [dbo].[EmployeesProjects]  WITH CHECK ADD  CONSTRAINT [FK_EmployeesProjects_Projects] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Projects] ([Id])
GO
ALTER TABLE [dbo].[EmployeesProjects] CHECK CONSTRAINT [FK_EmployeesProjects_Projects]
GO
