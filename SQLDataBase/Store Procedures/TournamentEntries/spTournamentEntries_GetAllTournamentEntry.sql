CREATE PROCEDURE spTournamentEntries_GetAllTournamentEntry
	
AS
BEGIN
	SET NOCOUNT ON
	SELECT Id ,TournamentId, TeamId
	FROM TournamentEntries
END
