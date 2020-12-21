CREATE PROCEDURE spTournamentPrizes_SaveTournamentPrize
	@TournamentId INT,
	@InputPrizeJson NVARCHAR(MAX),
	@OutputPrizeJson NVARCHAR(MAX)
AS
BEGIN
	IF(ISJSON(@InputPrizeJson)!=1)
		THROW 400 , N'Invalid Json',1
	
	DECLARE @TournamentPrizeId INT,
			@InputPrizeId INT ,
			@OutputPrizeId INT 
	SET @InputPrizeId = JSON_VALUE(@InputPrizeJson, '$.Id')
	INSERT INTO TournamentPrizes(TournamentId,PrizeId) VALUES (@TournamentId,@InputPrizeId)
	SET @TournamentPrizeId = SCOPE_IDENTITY()
	SET @OutputPrizeId = (SELECT Id FROM TournamentPrizes WHERE Id = @TournamentPrizeId)
	EXEC spPrizes_GetPrizeById @PrizeId = @OutputPrizeId, @PrizeJson = @OutputPrizeJson OUTPUT
END
