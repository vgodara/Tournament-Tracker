CREATE PROCEDURE spMatchUpEntries_GetAllMatchEntries

AS
BEGIN
	SET NOCOUNT ON
	SELECT MatchUpEntries.Id as Id,  
	ParentMatchUpId as Id, 
	CompetingTeamId as Id, TeamName, 
	People.Id as Id, FirstName,LastName,EmailAddress,CellPhoneNumber,
	Score
	FROM MatchUpEntries
	INNER JOIN MatchUps 
	ON ParentMatchUpId = MatchUps.Id
	INNER JOIN Teams
	ON CompetingTeamId = Teams.Id
	INNER JOIN TeamMembers
	ON TeamId = TeamMembers.Id
	INNER JOIN People
	ON PersonId = People.Id
	FOR JSON AUTO
END