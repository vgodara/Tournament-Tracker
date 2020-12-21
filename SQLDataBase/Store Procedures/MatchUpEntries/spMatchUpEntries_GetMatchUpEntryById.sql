CREATE PROCEDURE spMatchUpEntries_GetMatchUpEntryById
	@MatchUpEntryId INT,
	@MatchUpEntryJson NVARCHAR(MAX)
AS
BEGIN
-- TODO Recursion 
-- https://www.youtube.com/watch?v=7GpyHedM4pw
 SELECT MatchUpEntries.Id AS Id ,
 CompeteingTeam.Id AS Id, FirstName,LastName,EmailAddress,CellPhoneNumber,
 Score
 FROM MatchUpEntries
 INNER JOIN Teams AS CompeteingTeam
 ON CompetingTeamId = CompeteingTeam.Id
 INNER JOIN TeamMembers
 ON CompeteingTeam.Id = TeamMembers.TeamId
 INNER JOIN People AS TeamMember
 ON TeamMembers.PersonId = TeamMember.Id
END 
