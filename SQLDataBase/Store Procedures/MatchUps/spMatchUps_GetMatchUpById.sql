CREATE PROCEDURE spMatchUps_GetMatchUpById
	@matchUpId INT,
	@json NVARCHAR(MAX)
AS
BEGIN
	SET NOCOUNT ON
	SET NOCOUNT ON
	SET @json =(SELECT MatchUps.Id AS Id,
	MatchUpEntries.Id AS Id,
	WinnerTeam.Id AS Id, WinnerTeam.TeamName AS TeamName, 
	CompetingTeam.Id as Id,CompetingTeam.TeamName AS TeamName,
	FirstName, LastName,EmailAddress,CellPhoneNumber
	FROM MatchUps
	INNER JOIN MatchUpEntries
	ON MatchUps.Id = MatchUpEntries.MatchUpId
	INNER JOIN Teams AS CompetingTeam
	ON MatchUpEntries.CompetingTeamId= CompetingTeam.Id
	INNER JOIN TeamMembers
	ON CompetingTeam.Id= TeamMembers.Id
	INNER JOIN People AS TeamMember
	ON TeamMembers.PersonId = TeamMember.Id 
	INNER JOIN Teams  AS WinnerTeam
	ON WinnerId = WinnerTeam.Id
	INNER JOIN TeamMembers
	ON WinnerTeam.Id= TeamMembers.Id
	INNER JOIN People AS TeamMember
	ON TeamMembers.PersonId = TeamMember.Id
	WHERE MatchUps.Id = @matchUpId
	FOR JSON AUTO,INCLUDE_NULL_VALUES)
END
