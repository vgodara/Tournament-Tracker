CREATE PROCEDURE spTournamentPrizes_SaveTournamentPrizes
	@TournamentId INT,
	@InputPrizesJson NVARCHAR(MAX),
	@OutputPrizesJson NVARCHAR(MAX)
AS
BEGIN
	IF(ISJSON(@InputPrizesJson)!=1)
		THROW 400, N'Invalid Json' ,1

	DECLARE @CurrentPrizeIndex INT = 0,
			@TotalPrizes INT = (SELECT COUNT(*) FROM OPENJSON(@InputPrizesJson, '$'))
    SET @OutputPrizesJson = N'[]'
	WHILE(@CurrentPrizeIndex< @TotalPrizes)
	BEGIN
		DECLARE @InputPrizeJson NVARCHAR(MAX),
				@OutputPrizeJson NVARCHAR(MAX)
		SET @InputPrizeJson = JSON_VALUE(@InputPrizesJson,'$['+CAST(@CurrentPrizeIndex AS VARCHAR)+']')
		EXEC spTournamentPrizes_SaveTournamentPrize @TournamentId = @TournamentId,
													@InputPrizeJson = @InputPrizeJson,
													@OutputPrizeJson = @OutputPrizeJson OUTPUT
		SET @OutputPrizesJson = JSON_MODIFY(@OutputPrizesJson,'append $',@OutputPrizeJson)
		SET @CurrentPrizeIndex= @CurrentPrizeIndex+1
	END
END
