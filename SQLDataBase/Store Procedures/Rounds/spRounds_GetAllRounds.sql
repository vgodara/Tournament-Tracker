CREATE PROCEDURE spRounds_GetAllRounds
AS
BEGIN
	SET NOCOUNT ON
	SELECT Id ,TournamnetId, RoundNumber
	FROM Rounds
END 
