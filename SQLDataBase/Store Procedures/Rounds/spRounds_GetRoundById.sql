CREATE PROCEDURE spRounds_GetRoundById
	@roundId INT 
AS
BEGIN
	SET NOCOUNT ON
	SELECT Id ,TournamnetId, RoundNumber
	FROM Rounds
	WHERE Id = @roundId
END 
