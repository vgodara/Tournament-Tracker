CREATE PROCEDURE spPrizes_SavePrize
	@InputTeamJson NVARCHAR(MAX),
	@OutputTeamJson NVARCHAR(MAX) OUTPUT


AS
BEGIN
	SET NOCOUNT ON
	DECLARE @PrizeId INT ,
			@PlaceName NVARCHAR(50) ,
			@PlaceNumber INT ,
			@PrizeMoney DECIMAL  ,
			@PrizePercentage DECIMAL 

	IF(ISJSON(@InputTeamJson)!=1)
		THROW 400, N'Invalid Json' ,1;

	SET @PlaceName = JSON_VALUE(@InputTeamJson,'$.PlaceName')
	SET @PlaceNumber = JSON_VALUE(@InputTeamJson,'$.PlaceNumber')
	SET @PrizeMoney = JSON_VALUE(@InputTeamJson,'$.PrizeMoney')
	SET @PrizePercentage = JSON_VALUE(@InputTeamJson,'$.PrizePercentage')
		
	INSERT 
	INTO Prizes(PlaceName,
				PlaceNumber,
				PrizeMoney,
				PrizePercentage)
	VALUES (@PlaceName ,
			@PlaceNumber ,
			@PrizeMoney ,
			@PrizePercentage)


	SET @PrizeId= SCOPE_IDENTITY()
	EXEC spPrizes_GetPrizeById @PrizeId = @PrizeId, @PrizeJson = @OutputTeamJson OUTPUT
END
