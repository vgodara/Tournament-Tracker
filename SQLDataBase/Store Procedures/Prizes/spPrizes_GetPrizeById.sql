CREATE PROCEDURE spPrizes_GetPrizeById
	@PrizeId INT,
	@PrizeJson NVARCHAR(MAX) OUTPUT

AS
BEGIN
	SET NOCOUNT ON
	SET @PrizeJson = (SELECT Id, PlaceName, PlaceNumber, PrizeMoney, PrizePercentage
	FROM Prizes 
	WHERE Id = @PrizeId
	FOR JSON AUTO,INCLUDE_NULL_VALUES,WITHOUT_ARRAY_WRAPPER)
END
