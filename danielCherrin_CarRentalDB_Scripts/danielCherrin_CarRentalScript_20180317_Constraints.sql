/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2016 (13.0.4001)
    Source Database Engine Edition : Microsoft SQL Server Standard Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2017
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/
USE [master]
GO
/****** Object:  Database [CarRental]    Script Date: 17-Mar-18 1:15:42 PM ******/
CREATE DATABASE [CarRental]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CarRental', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\CarRental.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CarRental_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\CarRental_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [CarRental] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CarRental].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CarRental] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CarRental] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CarRental] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CarRental] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CarRental] SET ARITHABORT OFF 
GO
ALTER DATABASE [CarRental] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CarRental] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CarRental] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CarRental] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CarRental] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CarRental] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CarRental] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CarRental] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CarRental] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CarRental] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CarRental] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CarRental] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CarRental] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CarRental] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CarRental] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CarRental] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CarRental] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CarRental] SET RECOVERY FULL 
GO
ALTER DATABASE [CarRental] SET  MULTI_USER 
GO
ALTER DATABASE [CarRental] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CarRental] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CarRental] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CarRental] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CarRental] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CarRental] SET QUERY_STORE = OFF
GO
USE [CarRental]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [CarRental]
GO
/****** Object:  Table [dbo].[Contracts]    Script Date: 17-Mar-18 1:15:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contracts](
	[contractNo] [int] IDENTITY(0,1) NOT NULL,
	[empNo] [int] NOT NULL,
	[customerNo] [int] NOT NULL,
	[VIN] [nvarchar](50) NOT NULL,
	[pickupDate] [date] NOT NULL,
	[pickupTime] [time](7) NOT NULL,
	[returnDate] [date] NOT NULL,
	[returnTime] [time](7) NOT NULL,
	[discount] [float] NULL,
	[cost] [money] NULL,
	[odoReadingOutbound] [int] NULL,
	[odoReadingInbound] [int] NULL,
	[observationsOut] [nvarchar](300) NULL,
	[observationsIn] [nvarchar](300) NULL,
 CONSTRAINT [PK_Contracts] PRIMARY KEY CLUSTERED 
(
	[contractNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 17-Mar-18 1:15:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[customerNo] [int] IDENTITY(0,1) NOT NULL,
	[firstName] [nvarchar](50) NOT NULL,
	[lastName] [nvarchar](50) NOT NULL,
	[streetNo] [int] NOT NULL,
	[streetName] [nvarchar](50) NOT NULL,
	[streetPostcode] [int] NOT NULL,
	[residencySuburb] [nvarchar](50) NOT NULL,
	[residencyState] [nchar](10) NOT NULL,
	[mobPhone] [int] NOT NULL,
	[creditCardNo] [int] NOT NULL,
	[creditCardName] [nvarchar](50) NOT NULL,
	[creditCardType] [nvarchar](50) NOT NULL,
	[creditCardExp] [date] NOT NULL,
	[driverLicenseNo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[customerNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 17-Mar-18 1:15:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[empNo] [int] IDENTITY(0,1) NOT NULL,
	[firstName] [nvarchar](50) NOT NULL,
	[lastName] [nvarchar](50) NOT NULL,
	[mobPhone] [int] NOT NULL,
	[homePhone] [int] NULL,
	[streetAddr] [nvarchar](50) NOT NULL,
	[streetPostcode] [nchar](10) NOT NULL,
	[residencySuburb] [nvarchar](50) NOT NULL,
	[residencyState] [nchar](10) NOT NULL,
	[driverLicenseNo] [nchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[empNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehicle_Services]    Script Date: 17-Mar-18 1:15:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehicle_Services](
	[serviceNo] [int] IDENTITY(0,1) NOT NULL,
	[VIN] [nvarchar](50) NOT NULL,
	[serviceDate] [date] NOT NULL,
	[serviceChanges] [nvarchar](300) NOT NULL,
	[odoReading] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[serviceNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehicles]    Script Date: 17-Mar-18 1:15:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehicles](
	[VIN] [nvarchar](50) NOT NULL,
	[manufacturer] [nvarchar](50) NOT NULL,
	[model] [nvarchar](50) NOT NULL,
	[colour] [nvarchar](50) NOT NULL,
	[bodyType] [nvarchar](50) NOT NULL,
	[odoCurrent] [int] NOT NULL,
	[regoNo] [nchar](10) NOT NULL,
	[regoExp] [date] NOT NULL,
	[dailyRate] [money] NOT NULL,
	[hourlyRate] [money] NOT NULL,
	[observations] [nvarchar](300) NOT NULL,
	[yearOfManuf] [int] NOT NULL,
 CONSTRAINT [PK_Vehicles] PRIMARY KEY CLUSTERED 
(
	[VIN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Contracts] ON 

INSERT [dbo].[Contracts] ([contractNo], [empNo], [customerNo], [VIN], [pickupDate], [pickupTime], [returnDate], [returnTime], [discount], [cost], [odoReadingOutbound], [odoReadingInbound], [observationsOut], [observationsIn]) VALUES (1, 4, 0, N'51324584', CAST(N'2018-02-10' AS Date), CAST(N'12:00:00' AS Time), CAST(N'2018-03-03' AS Date), CAST(N'12:00:00' AS Time), NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Contracts] ([contractNo], [empNo], [customerNo], [VIN], [pickupDate], [pickupTime], [returnDate], [returnTime], [discount], [cost], [odoReadingOutbound], [odoReadingInbound], [observationsOut], [observationsIn]) VALUES (2, 4, 2, N'54617894', CAST(N'2018-01-14' AS Date), CAST(N'12:00:00' AS Time), CAST(N'2018-01-28' AS Date), CAST(N'12:00:00' AS Time), NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Contracts] ([contractNo], [empNo], [customerNo], [VIN], [pickupDate], [pickupTime], [returnDate], [returnTime], [discount], [cost], [odoReadingOutbound], [odoReadingInbound], [observationsOut], [observationsIn]) VALUES (3, 0, 3, N'54617894', CAST(N'2018-02-28' AS Date), CAST(N'12:00:00' AS Time), CAST(N'2018-03-28' AS Date), CAST(N'12:00:00' AS Time), NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Contracts] ([contractNo], [empNo], [customerNo], [VIN], [pickupDate], [pickupTime], [returnDate], [returnTime], [discount], [cost], [odoReadingOutbound], [odoReadingInbound], [observationsOut], [observationsIn]) VALUES (4, 1, 4, N'46565874', CAST(N'2018-03-10' AS Date), CAST(N'12:00:00' AS Time), CAST(N'2018-04-10' AS Date), CAST(N'12:00:00' AS Time), NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Contracts] ([contractNo], [empNo], [customerNo], [VIN], [pickupDate], [pickupTime], [returnDate], [returnTime], [discount], [cost], [odoReadingOutbound], [odoReadingInbound], [observationsOut], [observationsIn]) VALUES (5, 1, 5, N'61323125', CAST(N'2018-03-01' AS Date), CAST(N'12:00:00' AS Time), CAST(N'2018-05-01' AS Date), CAST(N'12:00:00' AS Time), NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Contracts] OFF
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([customerNo], [firstName], [lastName], [streetNo], [streetName], [streetPostcode], [residencySuburb], [residencyState], [mobPhone], [creditCardNo], [creditCardName], [creditCardType], [creditCardExp], [driverLicenseNo]) VALUES (0, N'John', N'Smith', 123, N'Fake Street', 4541, N'Fakurb', N'WA        ', 45465465, 23155748, N'John M. Smith', N'RasterCard', CAST(N'2019-10-01' AS Date), 32158544)
INSERT [dbo].[Customers] ([customerNo], [firstName], [lastName], [streetNo], [streetName], [streetPostcode], [residencySuburb], [residencyState], [mobPhone], [creditCardNo], [creditCardName], [creditCardType], [creditCardExp], [driverLicenseNo]) VALUES (2, N'Sarah', N'Notreal', 7, N'Roe Road', 6565, N'Mayswater', N'WA        ', 478774561, 23456654, N'Sarah J. Notreal', N'RasterCard', CAST(N'2022-01-01' AS Date), 23161654)
INSERT [dbo].[Customers] ([customerNo], [firstName], [lastName], [streetNo], [streetName], [streetPostcode], [residencySuburb], [residencyState], [mobPhone], [creditCardNo], [creditCardName], [creditCardType], [creditCardExp], [driverLicenseNo]) VALUES (3, N'Alex', N'Allens', 47, N'Hugh Ave', 6884, N'Woonana', N'WA        ', 488541547, 36544875, N'Alex R. Allens', N'Merican Expresso', CAST(N'2020-05-01' AS Date), 42458445)
INSERT [dbo].[Customers] ([customerNo], [firstName], [lastName], [streetNo], [streetName], [streetPostcode], [residencySuburb], [residencyState], [mobPhone], [creditCardNo], [creditCardName], [creditCardType], [creditCardExp], [driverLicenseNo]) VALUES (4, N'Billy', N'Bob', 242, N'Toom Ave', 6883, N'Woonana', N'WA        ', 485621235, 78515671, N'Billy J. Bob', N'Bisa', CAST(N'2021-01-01' AS Date), 45468248)
INSERT [dbo].[Customers] ([customerNo], [firstName], [lastName], [streetNo], [streetName], [streetPostcode], [residencySuburb], [residencyState], [mobPhone], [creditCardNo], [creditCardName], [creditCardType], [creditCardExp], [driverLicenseNo]) VALUES (5, N'Roe', N'Johnson', 58, N'Abel Road', 5878, N'Roonay', N'WA        ', 484564856, 92665412, N'Roe H. Johnson', N'Caestro', CAST(N'2020-01-01' AS Date), 15467874)
SET IDENTITY_INSERT [dbo].[Customers] OFF
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([empNo], [firstName], [lastName], [mobPhone], [homePhone], [streetAddr], [streetPostcode], [residencySuburb], [residencyState], [driverLicenseNo]) VALUES (0, N'Timothy', N'Rumm', 423312484, NULL, N'56B Roe Road', N'6565      ', N'Mayswater', N'WA        ', N'64552163  ')
INSERT [dbo].[Employees] ([empNo], [firstName], [lastName], [mobPhone], [homePhone], [streetAddr], [streetPostcode], [residencySuburb], [residencyState], [driverLicenseNo]) VALUES (1, N'Sally', N'Rich', 465658842, 98795121, N'12A Babbel Street', N'6883      ', N'Wollinon', N'WA        ', N'45456461  ')
INSERT [dbo].[Employees] ([empNo], [firstName], [lastName], [mobPhone], [homePhone], [streetAddr], [streetPostcode], [residencySuburb], [residencyState], [driverLicenseNo]) VALUES (4, N'Carl', N'Consta', 456785152, NULL, N'56 Lori Ave', N'6884      ', N'Woonana', N'WA        ', N'78654851  ')
SET IDENTITY_INSERT [dbo].[Employees] OFF
SET IDENTITY_INSERT [dbo].[Vehicle_Services] ON 

INSERT [dbo].[Vehicle_Services] ([serviceNo], [VIN], [serviceDate], [serviceChanges], [odoReading]) VALUES (1, N'54617894  ', CAST(N'2017-06-20' AS Date), N'Tyre and oil change.', 10000)
INSERT [dbo].[Vehicle_Services] ([serviceNo], [VIN], [serviceDate], [serviceChanges], [odoReading]) VALUES (4, N'61323125  ', CAST(N'2017-06-12' AS Date), N'Oil change.', 10000)
INSERT [dbo].[Vehicle_Services] ([serviceNo], [VIN], [serviceDate], [serviceChanges], [odoReading]) VALUES (6, N'61323125  ', CAST(N'2018-01-24' AS Date), N'Tyre change. Axis re-aligned.', 20000)
SET IDENTITY_INSERT [dbo].[Vehicle_Services] OFF
INSERT [dbo].[Vehicles] ([VIN], [manufacturer], [model], [colour], [bodyType], [odoCurrent], [regoNo], [regoExp], [dailyRate], [hourlyRate], [observations], [yearOfManuf]) VALUES (N'46565874', N'Bazda', N'MX-5', N'Black', N'Sedan', 2128, N'2CHN841   ', CAST(N'2020-06-01' AS Date), 250.0000, 25.0000, N'Faulty stereo system.', 2016)
INSERT [dbo].[Vehicles] ([VIN], [manufacturer], [model], [colour], [bodyType], [odoCurrent], [regoNo], [regoExp], [dailyRate], [hourlyRate], [observations], [yearOfManuf]) VALUES (N'51324584', N'Cord', N'Ranger', N'Red', N'Utility', 5101, N'1NTH156   ', CAST(N'2020-01-01' AS Date), 56.5000, 5.5000, N'Scratches above the back left wheel panel.', 2015)
INSERT [dbo].[Vehicles] ([VIN], [manufacturer], [model], [colour], [bodyType], [odoCurrent], [regoNo], [regoExp], [dailyRate], [hourlyRate], [observations], [yearOfManuf]) VALUES (N'54617894', N'Witsubishi', N'Triton', N'Black', N'SUV', 12178, N'5ASD285   ', CAST(N'2022-10-01' AS Date), 68.2000, 6.8000, N'Dents in front bumper.', 2010)
INSERT [dbo].[Vehicles] ([VIN], [manufacturer], [model], [colour], [bodyType], [odoCurrent], [regoNo], [regoExp], [dailyRate], [hourlyRate], [observations], [yearOfManuf]) VALUES (N'61323125', N'Yoyota', N'Prius', N'White', N'Station Wagon', 21584, N'3QMU249   ', CAST(N'2019-12-01' AS Date), 48.0000, 4.8000, N'Side mirror controls not working.', 2010)
INSERT [dbo].[Vehicles] ([VIN], [manufacturer], [model], [colour], [bodyType], [odoCurrent], [regoNo], [regoExp], [dailyRate], [hourlyRate], [observations], [yearOfManuf]) VALUES (N'61389774', N'Yoyota', N'Prius', N'Silver', N'Station Wagon', 7523, N'1YTN795   ', CAST(N'2021-06-01' AS Date), 48.0000, 4.8000, N'None.', 2015)
ALTER TABLE [dbo].[Contracts]  WITH CHECK ADD  CONSTRAINT [fk_customerNoContractsCustomers] FOREIGN KEY([customerNo])
REFERENCES [dbo].[Customers] ([customerNo])
GO
ALTER TABLE [dbo].[Contracts] CHECK CONSTRAINT [fk_customerNoContractsCustomers]
GO
ALTER TABLE [dbo].[Contracts]  WITH CHECK ADD  CONSTRAINT [fk_empNoContractsEmployees] FOREIGN KEY([empNo])
REFERENCES [dbo].[Employees] ([empNo])
GO
ALTER TABLE [dbo].[Contracts] CHECK CONSTRAINT [fk_empNoContractsEmployees]
GO
ALTER TABLE [dbo].[Contracts]  WITH CHECK ADD  CONSTRAINT [fk_VINContractsVehicles] FOREIGN KEY([VIN])
REFERENCES [dbo].[Vehicles] ([VIN])
GO
ALTER TABLE [dbo].[Contracts] CHECK CONSTRAINT [fk_VINContractsVehicles]
GO
ALTER TABLE [dbo].[Vehicle_Services]  WITH CHECK ADD  CONSTRAINT [fk_VINVehicle_ServicesVehicle] FOREIGN KEY([VIN])
REFERENCES [dbo].[Vehicles] ([VIN])
GO
ALTER TABLE [dbo].[Vehicle_Services] CHECK CONSTRAINT [fk_VINVehicle_ServicesVehicle]
GO
ALTER TABLE [dbo].[Customers]  WITH NOCHECK ADD  CONSTRAINT [chk_creditCardNoLength] CHECK  (([creditCardNo]<=(99999999) AND [creditCardNo]>=(10000000)))
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [chk_creditCardNoLength]
GO
ALTER TABLE [dbo].[Customers]  WITH NOCHECK ADD  CONSTRAINT [chk_creditCardType] CHECK  (([creditCardType]='Tiscover' OR [creditCardType]='Merican Expresso' OR [creditCardType]='Bisa' OR [creditCardType]='RasterCard'))
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [chk_creditCardType]
GO
ALTER TABLE [dbo].[Vehicles]  WITH NOCHECK ADD  CONSTRAINT [chk_bodyType] CHECK  (([bodyType]='Sports Car' OR [bodyType]='Utility' OR [bodyType]='SUV' OR [bodyType]='Station Wagon' OR [bodyType]='Sedan'))
GO
ALTER TABLE [dbo].[Vehicles] CHECK CONSTRAINT [chk_bodyType]
GO
USE [master]
GO
ALTER DATABASE [CarRental] SET  READ_WRITE 
GO
