CREATE PROCEDURE spTeamMember_saveTeamMember
	@TeamId INT,
	@InputTeamMemberJson NVARCHAR(MAX),
	@OutputTeamMemberJson NVARCHAR(MAX) OUTPUT  
AS
BEGIN
	IF(ISJSON(@InputTeamMemberJson)!=1)
		THROW 400, N'Invalid Json', 1
	DECLARE @InputPersonId INT, 
			@OutputPersonId INT,
			@TeamMemberId INT

	SET @InputPersonId = JSON_VALUE(@InputTeamMemberJson,'$.Id')
	INSERT INTO TeamMembers(TeamId,PersonId) VALUES (@TeamId,@InputPersonId)
	SET @TeamMemberId = SCOPE_IDENTITY()
	SET @OutputPersonId = (SELECT PersonId FROM TeamMembers WHERE Id = @TeamMemberId)
	EXEC spPeopel_GetPersonById @PersonId = @OutputPersonId,@OutputJson = @OutputTeamMemberJson
END 
