CREATE PROCEDURE spRounds_SaveRound
	@TournamentId INT,
	@InputRoundJson NVARCHAR(MAX),
	@OutputRoundJson NVARCHAR(MAX)
AS
BEGIN
	IF(ISJSON(@InputRoundJson)!=1)
		THROW 400, N'Invalid Json', 1

	DECLARE @RoundId INT ,
			@RoundNumber INT ,
			@InputMatchUpsJson NVARCHAR(MAX) ,
			@OutputMatchUpsJson NVARCHAR(MAX) 
	
	SET @RoundNumber = JSON_VALUE(@InputRoundJson, '$.RoundNumber')
	INSERT INTO Rounds(TournamnetId,RoundNumber) VALUES(@TournamentId,@RoundNumber)
	SET @RoundId = SCOPE_IDENTITY()

	--Save MatchUps 
	EXEC spMatchUps_SaveMatchUps @RoundId = @RoundId,
								 @InputMatchUpsJson = @InputMatchUpsJson,
								 @OutputMatchUpsJson= @OutputMatchUpsJson OUTPUT
	SET @OutputRoundJson = N'{}'
	SET @OutputRoundJson = JSON_MODIFY(@OutputRoundJson,'$.Id',@RoundId)
	SET @InputMatchUpsJson = JSON_QUERY(@InputRoundJson,'$.MatchUps')
	SET @OutputRoundJson = JSON_MODIFY(@OutputRoundJson, '$.MatchUps' ,@OutputMatchUpsJson)		
END
