CREATE PROCEDURE spRounds_SaveRounds
	@TournamentId INT,
	@InputRoundsJson NVARCHAR(MAX),
	@OutputRoundsJson NVARCHAR(MAX) OUTPUT
AS
BEGIN
	SET NOCOUNT ON
	IF(ISJSON(@InputRoundsJson)!=1)
		THROW 400, N'Invalid Json', 1
	DECLARE @CurrentRoundIndex INT =0,
			@TotalRounds INT =(SELECT COUNT(*) FROM OPENJSON(@InputRoundsJson,'$'))

	SET @OutputRoundsJson = N'[]' 
	WHILE(@CurrentRoundIndex<@TotalRounds)
	BEGIN
		DECLARE @Index VARCHAR = CAST(@CurrentRoundIndex AS VARCHAR),
				@InputRoundJson NVARCHAR(MAX) ,
				@OutputRoundJson NVARCHAR(MAX)

		SET @InputRoundJson = JSON_QUERY(@InputRoundsJson,'$['+@Index+']')
		
		EXEC spRounds_SaveRound @TournamentId=@TournamentId,
								@InputRoundJson=@InputRoundJson,
								@OutputRoundJson= @OutputRoundJson OUTPUT
		SET @OutputRoundsJson = 
				JSON_MODIFY(@OutputRoundsJson, 'append $['+@Index+']',@OutputRoundJson)
		SET @CurrentRoundIndex = @CurrentRoundIndex+1
	END
END 
