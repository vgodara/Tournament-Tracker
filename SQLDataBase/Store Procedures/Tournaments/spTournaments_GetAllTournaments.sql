CREATE PROCEDURE spTournaments_GetAllTournaments
AS
BEGIN
	SET NOCOUNT ON
	SELECT  Id, TournamentName, EntryFee
	FROM Tournaments
END
