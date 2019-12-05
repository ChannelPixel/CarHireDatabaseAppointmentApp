USE [CarRental]
GO

/****** Object:  Table [dbo].[Customers]    Script Date: 1/03/2018 4:01:19 PM ******/

CREATE TABLE [dbo].[Customers](
	[Customer_No] [int] NOT NULL IDENTITY(00000,00001) PRIMARY KEY,
	[Contract_No] [nchar](10) NOT NULL,
	[First_Name] [nvarchar](50) NOT NULL,
	[Last_Name] [nvarchar](50) NOT NULL,
	[Street_No] [nchar](10) NOT NULL,
	[Street_Address] [nvarchar](50) NOT NULL,
	[Street_Postcode] [nchar](10) NOT NULL,
	[Residence_City] [nvarchar](50) NOT NULL,
	[Residence_State] [nchar](10) NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
	[Credit_Card_No] [nvarchar](50) NOT NULL,
	[Credit_Card_Provider] [nvarchar](50) NOT NULL,
	[Credit_Card_Type] [nvarchar](50) NOT NULL,
	[Driver_Licence_No] [nchar](10) NOT NULL,
)
GO

CREATE TABLE [dbo].[Contracts](
	[Contract_No] [int] NOT NULL IDENTITY(00000,00001) PRIMARY KEY,
	[Customer_No] [nchar](10) NOT NULL,
	[VIN] [nvarchar](50) NOT NULL,
	[Pickup_Date] [date] NOT NULL,
	[Pickup_Time] [time](0) NOT NULL,
	[Return_Date] [date] NOT NULL,
	[Return_Time] [time](0) NOT NULL,
	[Deposit] [money] NOT NULL,
)
GO

CREATE TABLE [dbo].[Vehicle_Services](
	[Service_No] [int] NOT NULL IDENTITY(00000,00001) PRIMARY KEY,
	[VIN] [nchar](10) NOT NULL,
	[Service_Time] [time](0) NOT NULL,
	[Service_Date] [date] NOT NULL,
	[Return_Time] [time](0) NULL,
	[Return_Date] [date] NULL,
	[Service_Price] [money] NOT NULL,
	[Vehicle_Changes] [numeric](18, 0) NULL,
	[Vehicle_Changed] [bit] NOT NULL,
)
GO

CREATE TABLE [dbo].[Vehicles](
	[VIN] [nvarchar](50) NOT NULL,
	[Manufacturer] [nvarchar](50) NOT NULL,
	[Model] [nvarchar](50) NOT NULL,
	[Transmission_Type] [nchar](10) NOT NULL,
	[KMs] [numeric](18, 3) NOT NULL,
	[Fuel_Type] [nvarchar](50) NOT NULL,
	[Registration] [nchar](10) NOT NULL,
	[Daily_Rate] [numeric](18, 2) NOT NULL,
	[Hourly_Rate] [numeric](18, 2) NOT NULL,
	[Damages] [nvarchar](50) NOT NULL,
	[Available] [bit] NOT NULL,
)
GO