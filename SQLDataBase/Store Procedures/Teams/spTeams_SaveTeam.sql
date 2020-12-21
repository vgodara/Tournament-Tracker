CREATE PROCEDURE spTeams_SaveTeam
	@InputTeamJson NVARCHAR(MAX),
	@OutputTeamJson NVARCHAR(MAX) OUTPUT
AS
BEGIN
SET NOCOUNT ON
	IF(ISJSON(@InputTeamJson)!=1)
		THROW 400, N'Invalid Json' ,1 
	DECLARE @TeamId INT ,
			@TeamName NVARCHAR(50)

	SET @TeamName = JSON_VALUE(@InputTeamJson,'$.TeamName')
	INSERT INTO Teams(TeamName) VALUES(@TeamName)
	SET @TeamId = SCOPE_IDENTITY()
	SET @InputTeamJson = JSON_MODIFY(@InputTeamJson,'$.Id',@TeamId)

	EXEC spTeamMember_saveTeamMembers @TeamJson = @InputTeamJson

	EXEC spTeams_GetTeamById @TeamId = @TeamId , @TeamJson = @OutputTeamJson OUTPUT
END 
