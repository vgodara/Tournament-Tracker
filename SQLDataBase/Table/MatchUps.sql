CREATE TABLE MatchUps
(
	Id INT NOT NULL PRIMARY KEY IDENTITY,
	WinnerId INT, 
	RoundId INT NOT NULL, 
	CONSTRAINT [FK_MatchUps_ToTeams] FOREIGN KEY (WinnerId) REFERENCES Teams(Id),
    CONSTRAINT [FK_MatchUps_ToRounds] FOREIGN KEY (RoundId) REFERENCES Rounds(Id), 
    CONSTRAINT [CK_MatchUps_WinnerId_RoundId] UNIQUE (WinnerId,RoundId), 
    
)
