CREATE PROCEDURE spTeams_GetAllTeams
	@json NVARCHAR(MAX) OUTPUT
AS
BEGIN
	SET NOCOUNT ON
	SET @json = (SELECT Teams.Id as Id, TeamName, TeamMember.Id as Id, FirstName, LastName, EmailAddress, CellPhoneNumber
	FROM Teams
	INNER JOIN TeamMembers 
	ON Teams.Id = TeamMembers.TeamId
	INNER JOIN People AS TeamMember
	ON TeamMembers.PersonId = TeamMember.Id
	FOR JSON AUTO,INCLUDE_NULL_VALUES)
END
