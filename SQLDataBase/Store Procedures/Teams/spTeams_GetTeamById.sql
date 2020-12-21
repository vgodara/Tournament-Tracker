CREATE PROCEDURE spTeams_GetTeamById
		@TeamId INT,
		@TeamJson NVARCHAR(MAX) OUTPUT
AS
BEGIN  
	SET NOCOUNT ON
	SET @TeamJson = (SELECT Teams.Id as Id, TeamName, 
				TeamMember.Id as Id, FirstName, LastName, EmailAddress, CellPhoneNumber
	FROM Teams
	INNER JOIN TeamMembers 
	ON Teams.Id = TeamMembers.TeamId
	INNER JOIN People AS TeamMember
	ON TeamMembers.PersonId = TeamMember.Id
	WHERE Teams.Id = @TeamId
	FOR JSON AUTO,INCLUDE_NULL_VALUES,WITHOUT_ARRAY_WRAPPER)
END