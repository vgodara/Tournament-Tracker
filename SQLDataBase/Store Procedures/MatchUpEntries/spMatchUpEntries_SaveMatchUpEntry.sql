CREATE PROCEDURE spMatchUpEntries_SaveMatchUpEntry
	@MatchUpId INT,
	@InputMatchUpEntryJson NVARCHAR(MAX),
	@OutputMatchUpEntryJson NVARCHAR(MAX) OUTPUT
AS
BEGIN
	IF(ISJSON(@InputMatchUpEntryJson)!=1)
		THROW 400, N'Invalid Json', 1
	DECLARE @ParentMatchUpId INT, 
			@CompetingTeamId INT ,
			@Score DECIMAL,
			@MatchUpEntryId INT 


		SET @CompetingTeamId = JSON_VALUE(@InputMatchUpEntryJson,'$.CompeteingTeam.Id')
		SET @ParentMatchUpId = JSON_VALUE(@InputMatchUpEntryJson,'$..ParentMatchUp.Id')
		SET @Score = JSON_VALUE(@InputMatchUpEntryJson,'$.Score')
		IF(@Score=null)
			SET @Score=0
		INSERT INTO MatchUpEntries(CompetingTeamId,MatchUpId,ParentMatchUpId,Score) 
			   VALUES(@CompetingTeamId,@MatchUpId,@ParentMatchUpId,@Score)
		SET @MatchUpEntryId = SCOPE_IDENTITY()
		SET @OutputMatchUpEntryJson = JSON_MODIFY(@InputMatchUpEntryJson, '$.Id', @MatchUpEntryId)
END
