CREATE PROCEDURE spTournaments_SaveTournaments
	@InputTournamentsJson NVARCHAR(MAX),
	@OutputTournamentsJson NVARCHAR(MAX) OUTPUT
AS
BEGIN
	IF(ISJSON(@InputTournamentsJson)!=1)
		THROW 400, N'Invalid Json' ,1
	DECLARE @TournamentId INT ,
			@CurrentTournamentIndex INT ,
			@TotalTournaments INT 

	SET @OutputTournamentsJson = N'[]'
	SET @TournamentId = JSON_VALUE(@InputTournamentsJson, '$.Id')
	SET @CurrentTournamentIndex =0
	SET @TotalTournaments = (SELECT COUNT(*) FROM OPENJSON(@InputTournamentsJson, '$.'))
	WHILE(@CurrentTournamentIndex< @TotalTournaments)
	BEGIN
		DECLARE @InputTournamentJson NVARCHAR(MAX) ,
				@OutputTournamentJson NVARCHAR(MAX) 
		SET @InputTournamentJson = JSON_VALUE(@InputTournamentsJson,'$['+CAST(@CurrentTournamentIndex AS VARCHAR)+']')
		EXEC spTournaments_SaveTournament @InputTournamentJson = @InputTournamentJson,
										  @OutputTournamentJson= @OutputTournamentJson OUTPUT
		SET @OutputTournamentsJson = JSON_MODIFY(@OutputTournamentsJson, 'append $',@OutputTournamentJson)
		SET @CurrentTournamentIndex = @CurrentTournamentIndex+1
	END
END

