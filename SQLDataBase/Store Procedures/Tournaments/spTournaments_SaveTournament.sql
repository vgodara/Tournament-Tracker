CREATE PROCEDURE spTournaments_SaveTournament
	@InputTournamentJson NVARCHAR(MAX),
	@OutputTournamentJson NVARCHAR(MAX) OUTPUT 

AS
BEGIN
	IF(ISJSON(@InputTournamentJson)!=1)
		THROW 400 , N'InValid Json', 1

	DECLARE @TournamentId INT ,
			@InputTournamentName NVARCHAR(50) ,
			@InputEntryFee DECIMAL ,
			@InputEnteredTeamsJson NVARCHAR(MAX),
			@OutputEnteredTeamsJson NVARCHAR(MAX),
			@InputPrizesJson NVARCHAR(MAX),
			@OutputPrizesJson NVARCHAR(MAX),
			@InputRoundsJson NVARCHAR(MAX),
			@OutputRoundsJson NVARCHAR(MAX)

	SET @InputTournamentName = JSON_VALUE(@InputTournamentJson, '$.TournamentName')
	SET @InputEntryFee = JSON_VALUE(@InputTournamentJson, '$.EnteryFee')
	SET @InputEnteredTeamsJson = JSON_QUERY(@InputTournamentJson,'$.EnteredTeams')
	SET @InputPrizesJson = JSON_QUERY(@InputTournamentJson,'$.Prizes')
	SEt @InputRoundsJson = JSON_QUERY(@InputTournamentJson,'$.Rounds')
	INSERT INTO Tournaments(TournamentName,EntryFee) VALUES (@InputTournamentName,@InputEntryFee)
	SET @TournamentId = SCOPE_IDENTITY()

	-- TournamentEntries 
	EXEC spTournamentEntries_SaveTournamentEntries @TournamentId = @TournamentId,
												   @InputEnteredTeamsJson = @InputEnteredTeamsJson,
												   @OutputEnteredTeamsJson = @OutputEnteredTeamsJson OUTPUT
	
	-- Tournament Prize Entries
	EXEC spTournamentPrizes_SaveTournamentPrizes @TournamentId = @TournamentId,
												 @InputPrizesJson = @InputPrizesJson,
												 @OutputPrizesJson = @OutputPrizesJson OUTPUT

	-- Rounds
	EXEC spRounds_SaveRounds @TournamentId = @TournamentId,
							 @InputRoundsJson = @InputRoundsJson,
							 @OutputRoundsJson = @OutputRoundsJson OUTPUT

	SET @OutputTournamentJson = (SELECT Id, TournamentName, EntryFee FROM Tournaments WHERE Id = @TournamentId
	FOR JSON AUTO,INCLUDE_NULL_VALUES,WITHOUT_ARRAY_WRAPPER)
	SET @OutputTournamentJson = JSON_MODIFY(@OutputTournamentJson,'$.EnteredTeams',@OutputEnteredTeamsJson)
	SET @OutputTournamentJson = JSON_MODIFY(@OutputTournamentJson,'$.Prizes',@OutputPrizesJson)
	SET @OutputTournamentJson = JSON_MODIFY(@OutputTournamentJson,'$.Rounds',@OutputRoundsJson)

END
