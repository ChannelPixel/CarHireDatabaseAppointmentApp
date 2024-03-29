/****** Script for SelectTopNRows command from SSMS  ******/
SELECT CASE WHEN EXISTS
(
	SELECT *
	FROM 
	[Contracts]
	WHERE 
	Contracts.VIN = '51324584' --Check the vehicle requested
	AND (pickupDate BETWEEN CAST('2018-02-15' AS date) AND CAST('2018-02-20' AS date)--Check DB PickupDate lies between create/alter contract dates.
	OR returnDate BETWEEN CAST('2018-02-15' AS date) AND CAST('2018-02-20' AS date)--Check DB ReturnDate lies between create/alter contract dates.
	OR ((pickupDate < CAST('2018-02-15' AS date) AND pickupDate < CAST('2018-02-20' AS date))
		AND (returnDate > CAST('2018-02-15' AS date) AND returnDate > CAST('2018-02-20' AS date))))--Check create/alter contract dates exist WITHIN a contract date.
)
THEN CAST(1 AS BIT)
ELSE CAST(0 AS BIT) END;