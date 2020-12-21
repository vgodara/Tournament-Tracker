CREATE PROCEDURE spPrizes_GetAllPrizes
	@json NVARCHAR(MAX) OUTPUT
AS
BEGIN 
	SET NOCOUNT ON
	SET @json =(SELECT Id, PlaceName, PlaceNumber, PrizeMoney, PrizePercentage
	FROM Prizes 
	FOR JSON AUTO,INCLUDE_NULL_VALUES)
END
