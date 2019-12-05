USE [CarRental]
GO

/****** Object:  Table [dbo].[Customers]    Script Date: 1/03/2018 4:01:19 PM ******/

CREATE TABLE [dbo].[Customers](
	[customerNo] [int] NOT NULL IDENTITY(0,1) PRIMARY KEY,
	[firstName] [nvarchar](50) NOT NULL,
	[lastName] [nvarchar](50) NOT NULL,
	[streetNo] [int] NOT NULL,
	[streetName] [nvarchar](50) NOT NULL,
	[steetPostcode] [int] NOT NULL,
	[residencySuburb] [nvarchar](50) NOT NULL,
	[residencyState] [nchar](10) NOT NULL,
	[mobPhone] [int] NOT NULL,
	[creditCardNo] [int] NOT NULL,
	[creditCardName] [nvarchar](50) NOT NULL,
	[creditCardType] [nvarchar](50) NOT NULL,
	[creditCardExp] [date] NOT NULL,
	[driverLicenceNo] [int] NOT NULL,
)
GO

CREATE TABLE [dbo].[Contracts](
	[contractNo] [int] NOT NULL IDENTITY(0,1) PRIMARY KEY,
	[empNo] [int] NOT NULL,
	[customerNo] [int] NOT NULL,
	[VIN] [nvarchar](50) NOT NULL,
	[pickupDate] [date] NOT NULL,
	[pickupTime] [time](7) NOT NULL,
	[returnDate] [date] NOT NULL,
	[returnTime] [time](7) NOT NULL,
	[discount] [float] NULL,
	[cost] [money] NOT NULL,
	[odoReadingOutbound] [int] NOT NULL,
	[odoReadingInbound] [int] NULL,
	[observationsOut] [nvarchar](300) NULL,
	[observationsIn] [nvarchar](300) NULL,
)
GO

CREATE TABLE [dbo].[Employees](
	[empNo] [int] NOT NULL IDENTITY(0,1) PRIMARY KEY,
	[firstName] [nvarchar](50) NOT NULL,
	[lastName] [nvarchar](50) NOT NULL,
	[mobPhone] [int] NOT NULL,
	[homePhone] [int] NULL,
	[streetAddr] [nvarchar](50) NOT NULL,
	[steetPostcode] [nchar](10) NOT NULL,
	[residencySuburb] [nvarchar](50) NOT NULL,
	[residencyState] [nchar](10) NOT NULL,
	[driverLicenceNo] [nchar](10) NOT NULL,
)
GO

CREATE TABLE [dbo].[Vehicles](
	[VIN] [nvarchar](17) NOT NULL,
	[manufacturer] [nvarchar](50) NOT NULL,
	[model] [nvarchar](50) NOT NULL,
	[colour] [nvarchar](50) NOT NULL,
	[transmissionType] [nchar](10) NOT NULL,
	[odoCurrent] [int] NOT NULL,
	[fuelType] [nvarchar](50) NOT NULL,
	[regoNo] [nchar](10) NOT NULL,
	[regoExp] [date] NOT NULL,
	[dailyRate] [money] NOT NULL,
	[hourlyRate] [money] NOT NULL,
	[observations] [nvarchar](300) NOT NULL,
)
GO

CREATE TABLE [dbo].[Vehicle_Services](
	[serviceNo] [int] NOT NULL IDENTITY(0,1) PRIMARY KEY,
	[VIN] [nchar](10) NOT NULL,
	[odoReading] [int] NOT NULL,
	[serviceDate] [date] NOT NULL,
	[serviceChanges] [nvarchar](300) NULL,
)
GO