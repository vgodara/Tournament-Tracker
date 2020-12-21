CREATE PROCEDURE spMatchUpEntries_SaveMatchUpEntries
	@MatchUpId INT,
	@InputMatchUpEntriesJson NVARCHAR(MAX),
	@OutputMatchUpEntriesJson NVARCHAR (MAX) OUTPUT

AS
BEGIN
	SET NOCOUNT ON
	IF(ISJSON(@InputMatchUpEntriesJson)!=1)
		THROW 400, N'Invalid Json', 1

	DECLARE	@TotalMatchUpEntries INT =(SELECT COUNT(*) FROM OPENJSON(@InputMatchUpEntriesJson,'$')),
			@CurrentMatchUpEntryIndex INT =0

	SET @OutputMatchUpEntriesJson = N'[]'
	WHILE(@CurrentMatchUpEntryIndex<@TotalMatchUpEntries)
	BEGIN
		DECLARE @InputMatchUpEntryJson NVARCHAR(MAX),
				@OutputMatchUpEntryJson NVARCHAR(MAX)
		SET @InputMatchUpEntryJson = JSON_QUERY(@InputMatchUpEntriesJson,'$['+CAST(@CurrentMatchUpEntryIndex AS VARCHAR)+']')
		EXEC spMatchUpEntries_SaveMatchUpEntry @MatchUpId = @MatchUpId ,
											   @InputMatchUpEntryJson = @InputMatchUpEntryJson,
											   @OutputMatchUpEntryJson = @OutputMatchUpEntryJson OUTPUT
		SET @OutputMatchUpEntriesJson = 
			JSON_MODIFY(@OutputMatchUpEntriesJson,'append $',@OutputMatchUpEntryJson)
		SET @CurrentMatchUpEntryIndex = @CurrentMatchUpEntryIndex+1
	END	
END 
