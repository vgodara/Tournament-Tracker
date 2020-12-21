CREATE PROCEDURE spTournamentEntries_GetTournamentEntryById
	@tournamnetId INT 

AS
BEGIN
	SET NOCOUNT ON
	SELECT Id ,TournamentId, TeamId
	FROM TournamentEntries
	WHERE Id = @tournamnetId
END
