CREATE PROCEDURE spTeamMember_saveTeamMembers
		@TeamId INT,
		@InputTeamMembersJson NVARCHAR(MAX),
		@OutputTeamMembersJson NVARCHAR(MAX)
	
AS
BEGIN
	SET NOCOUNT ON 
	IF(ISJSON(@InputTeamMembersJson)!=1)
		THROW 400, N'Invalid Json', 1
	DECLARE @CurrentTeamMemberIndex INT=0,
			@TotalTeamMembers INT = (SELECT COUNT(*) FROM OPENJSON(@InputTeamMembersJson, '$'))

	SET @OutputTeamMembersJson = N'[]'
	WHILE (@CurrentTeamMemberIndex < @TotalTeamMembers)
	BEGIN
		DECLARE @InputTeamMemberJson NVARCHAR(MAX), 
				@OutputTeamMemberJson NVARCHAR(MAX)
				
		SET @InputTeamMemberJson = JSON_QUERY(@InputTeamMembersJson, '$['+CAST(@CurrentTeamMemberIndex AS VARCHAR)+']' )
		EXEC spTeamMember_saveTeamMember @TeamId = @TeamId, 
										 @InputTeamMemberJson = @InputTeamMemberJson, 
										@OutputTeamMemberJson = @OutputTeamMemberJson
		SET @OutputTeamMembersJson = JSON_MODIFY(@OutputTeamMembersJson, 'append $' ,@OutputTeamMemberJson)
		SET @CurrentTeamMemberIndex = @CurrentTeamMemberIndex+1
	END
END
RETURN 0
