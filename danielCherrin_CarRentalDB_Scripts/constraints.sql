USE CarRental;
GO
----FOREIGN KEY CONTRAINTS
--CONTRACTS
ALTER TABLE [dbo].[Contracts]
ADD CONSTRAINT fk_empNoContractsEmployees
FOREIGN KEY (empNo)
REFERENCES [dbo].[Employees](empNo)

ALTER TABLE [dbo].[Contracts]
ADD CONSTRAINT fk_customerNoContractsCustomers
FOREIGN KEY (customerNo)
REFERENCES [dbo].[Customers](customerNo)

ALTER TABLE [dbo].[Contracts]
ADD CONSTRAINT fk_VINContractsVehicles
FOREIGN KEY (VIN)
REFERENCES [dbo].[Vehicles](VIN)

--VEHICLE SERVICES
ALTER TABLE [dbo].[Vehicle_Services]
ADD CONSTRAINT fk_VINVehicle_ServicesVehicle
FOREIGN KEY (VIN)
REFERENCES [dbo].[Vehicles](VIN)
GO

----CHECK CONTRAINTS
ALTER TABLE [dbo].[Vehicles] WITH NOCHECK
ADD CONSTRAINT chk_bodyType
CHECK ([bodyType] IN ('Sedan', 'Station Wagon', 'SUV', 'Utility', 'Sports Car'));

ALTER TABLE [dbo].[Customers] WITH NOCHECK
ADD CONSTRAINT chk_creditCardNoLength
CHECK ([creditCardNo] <= 99999999 AND [creditCardNo] >= 10000000);

ALTER TABLE [dbo].[Customers] WITH NOCHECK
ADD CONSTRAINT chk_creditCardType
CHECK ([creditCardType] IN ('RasterCard', 'Bisa', 'Merican Expresso', 'Tiscover'));
GO