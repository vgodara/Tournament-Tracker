CREATE PROCEDURE spTeamMember_saveTeamMember
	@TeamId INT,
	@TeamMemberJson NVARCHAR(MAX)
AS
BEGIN
	IF(ISJSON(@TeamMemberJson)!=1)
		THROW 400, N'Invalid Json', 1
	DECLARE @PersonId INT 

	SET @PersonId = JSON_VALUE(@TeamMemberJson,'$.Id')
	INSERT INTO TeamMembers(TeamId,PersonId) VALUES (@TeamId,@PersonId)
END 
