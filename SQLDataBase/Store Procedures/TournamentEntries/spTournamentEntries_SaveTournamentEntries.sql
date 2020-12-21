CREATE PROCEDURE spTournamentEntries_SaveTournamentEntries
	@TournamentId INT,
	@InputEnteredTeamsJson NVARCHAR(MAX),
	@OutputEnteredTeamsJson NVARCHAR(MAX) OUTPUT
AS
BEGIN
	SET NOCOUNT ON
	IF(ISJSON(@InputEnteredTeamsJson)!=1)
		THROW 400, N'Invalid Json', 1

	DECLARE @CurrerntTeamIndex INT = 0 ,
			@TotalEnteredTeams INT = (SELECT COUNT(*) FROM OPENJSON(@InputEnteredTeamsJson,'$'))
	SET @OutputEnteredTeamsJson = N'[]'
	WHILE(@CurrerntTeamIndex< @TotalEnteredTeams)
	BEGIN
		DECLARE @InputEnteredTeamJson NVARCHAR(MAX),
				@OutputEnteredTeamJson NVARCHAR(MAX)
		SET @InputEnteredTeamJson = JSON_QUERY(@InputEnteredTeamsJson,'$['+CAST(@CurrerntTeamIndex AS VARCHAR)+']')
		EXEC spTournamentEntries_SaveTournamentEntry @TournamnetId = @TournamentId, 
													 @InputEnteredTeamJson = @InputEnteredTeamJson,
													 @OutputEnteredTeamJson = @OutputEnteredTeamJson
		SET @OutputEnteredTeamsJson = JSON_MODIFY(@OutputEnteredTeamsJson, 'append $', @OutputEnteredTeamJson)
		SET @CurrerntTeamIndex = @CurrerntTeamIndex+1
	END

END