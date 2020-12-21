CREATE TABLE MatchUpEntries
(
	Id INT NOT NULL PRIMARY KEY IDENTITY,
	MatchUpId INT NOT NULL,
	ParentMatchUpId INT NULL,
	CompetingTeamId INT NOT NULL,
	Score DECIMAL NOT NULL , 
    CONSTRAINT [FK_MatchUpEntries_ToMatchUp] FOREIGN KEY (MatchUpId) REFERENCES MatchUps(Id), 
    CONSTRAINT [FK_MatchUpEntries_ToParentMatchUp] FOREIGN KEY (ParentMatchUpId) REFERENCES MatchUps(Id), 
    CONSTRAINT [FK_MatchUpEntries_ToTeams] FOREIGN KEY (CompetingTeamId) REFERENCES Teams(Id), 
    CONSTRAINT [UQ_MatchUpEntries_MatchUpId_CompetingTeamId] UNIQUE (MatchUpId,CompetingTeamId),

)
