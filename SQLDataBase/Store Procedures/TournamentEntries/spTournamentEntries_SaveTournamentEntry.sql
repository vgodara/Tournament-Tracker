CREATE PROCEDURE spTournamentEntries_SaveTournamentEntry
	@TournamnetId INT,
	@InputEnteredTeamJson NVARCHAR(MAX),
	@OutputEnteredTeamJson NVARCHAR(MAX) OUTPUT
AS
BEGIN
	IF(ISJSON(@InputEnteredTeamJson)!=1)
		THROW 400, N'Invalid Json', 1

	DECLARE @InputTeamId INT,
			@OutputTeamId INT,
			@TournamentEntryId INT
	SET @InputTeamId = JSON_VALUE(@InputEnteredTeamJson,'$.Id')
	INSERT INTO TournamentEntries(TournamentId,TeamId) VALUES (@TournamnetId,@InputTeamId)
	SET @TournamentEntryId = SCOPE_IDENTITY()
	SET @OutputTeamId = (SELECT TeamId FROM TournamentEntries WHERE Id = @TournamentEntryId)
	EXEC spTeams_GetTeamById @TeamId = @OutputTeamId, @TeamJson = @OutputEnteredTeamJson OUTPUT


END 
