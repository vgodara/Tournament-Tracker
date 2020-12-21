CREATE PROCEDURE spTournaments_GetTournamentById
	@tournamnetId INT 
AS
BEGIN
	SET NOCOUNT ON
	SELECT  Id, TournamentName, EntryFee
	FROM Tournaments
	WHERE Id = @tournamnetId
END
