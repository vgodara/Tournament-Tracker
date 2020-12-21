CREATE PROCEDURE spMatchUps_SaveMatchUps
	@RoundId INT,
	@InputMatchUpsJson NVARCHAR(MAX),
	@OutputMatchUpsJson NVARCHAR(MAX)  OUTPUT
AS
BEGIN 
	SET NOCOUNT ON
	IF(ISJSON(@InputMatchUpsJson)!=1)
		THROW 400, N'Invalid Json', 1
	DECLARE	@CurrentMatchUpIndex INT ,
			@TotalMatchUps INT 

			
	SET @OutputMatchUpsJson = N'[]'
	SET @RoundId = JSON_VALUE(@InputMatchUpsJson, '$.Id')
	SET @TotalMatchUps = (SELECT COUNT(*) FROM OPENJSON(@InputMatchUpsJson,'$'))
	SET @CurrentMatchUpIndex =0
	WHILE(@CurrentMatchUpIndex<@TotalMatchUps)
	BEGIN
		DECLARE @InputMatchUpJson NVARCHAR(MAX) ,
				@OutputMatchUpJson NVARCHAR(MAX) 

		SET @InputMatchUpJson = JSON_QUERY(@InputMatchUpsJson,'$['+CAST(@CurrentMatchUpIndex AS VARCHAR)+']')
		EXEC spMatchUps_SaveMatchUp @RoundId =@RoundId, 
									@InputMatchUpJson = @InputMatchUpJson,
									@OutputMatchUpJson = @OutputMatchUpJson OUTPUT
		SET @OutputMatchUpsJson 
			= JSON_MODIFY(@OutputMatchUpsJson,'append $',@OutputMatchUpJson)
		SET @CurrentMatchUpIndex = @CurrentMatchUpIndex+1
	END
END
