CREATE PROCEDURE spTeamMember_saveTeamMembers
		@TeamJson NVARCHAR(MAX)
	
AS
BEGIN
	SET NOCOUNT ON 
	IF(ISJSON(@TeamJson)!=1)
		THROW 400, N'Invalid Json', 1
	DECLARE @TeamId INT,
			@CurrentTeamMemberIndex INT,
			@TotalTeamMembers INT

	SET @TeamId = JSON_VALUE(@TeamJson,'$.Id')
	SET @CurrentTeamMemberIndex = 0
	SET @TotalTeamMembers = (SELECT COUNT(*) FROM OPENJSON(@TeamJson, '$.TeamMembers'))
	WHILE (@CurrentTeamMemberIndex < @TotalTeamMembers)
	BEGIN
		DECLARE @TeamMemberJson NVARCHAR(MAX) 
		SET @TeamMemberJson = JSON_QUERY(@TeamJson, '$.TeamMembers['+CAST(@CurrentTeamMemberIndex AS VARCHAR)+']' )
		EXEC spTeamMember_saveTeamMember @TeamId = @TeamId, @TeamMemberJson = @TeamMemberJson 
		SET @CurrentTeamMemberIndex = @CurrentTeamMemberIndex+1
	END
END
RETURN 0
