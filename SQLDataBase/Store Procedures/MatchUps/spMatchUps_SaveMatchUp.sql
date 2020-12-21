CREATE PROCEDURE spMatchUps_SaveMatchUp
	@RoundId INT,
	@InputMatchUpJson NVARCHAR(MAX),
	@OutputMatchUpJson NVARCHAR(MAX) OUTPUT
	
AS
BEGIN
	DECLARE @MatchUpId INT ,
			@InputMatchUpEntriesJson NVARCHAR(MAX) ,
			@OutputMatchUpEntriesJson NVARCHAR (MAX) 
	
	IF(ISJSON(@InputMatchUpJson)!=1)
		THROW 400, N'Invalid Json', 1

	INSERT INTO MatchUps(RoundId) VALUES(@RoundId)
	SET @MatchUpId = SCOPE_IDENTITY()
	SET @InputMatchUpEntriesJson = JSON_QUERY(@InputMatchUpJson,'$.MatchUpEntries')

	-- Save MatchUpEntries 
	EXEC spMatchUpEntries_SaveMatchUpEntries @MatchUpId = @MatchUpId,
											 @InputMatchUpEntriesJson = @InputMatchUpEntriesJson,
											 @OutputMatchUpEntriesJson = @OutputMatchUpEntriesJson OUTPUT
	SET @OutputMatchUpJson = N'{}'
	SET @OutputMatchUpJson = JSON_MODIFY(@OutputMatchUpJson, '$.Id',@MatchUpId)
	SET @OutputMatchUpJson = JSON_MODIFY(@OutputMatchUpJson,'$.MatchUpEntries',@OutputMatchUpEntriesJson)
END
	