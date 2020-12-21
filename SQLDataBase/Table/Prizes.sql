CREATE TABLE Prizes
(
	Id INT NOT NULL PRIMARY KEY IDENTITY, 
    PlaceName NVARCHAR(50) NOT NULL,
	PlaceNumber INT NOT NULL,
	PrizeMoney FLOAT NOT NULL,
	PrizePercentage FLOAT NOT NULL, 
    CONSTRAINT [CK_Prizes_PrizeAmount_PrizePercentage] CHECK (PrizePercentage=0 OR PrizeMoney=0)


)
