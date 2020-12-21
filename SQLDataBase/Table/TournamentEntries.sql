CREATE TABLE TournamentEntries
(
	Id INT NOT NULL PRIMARY KEY IDENTITY,
	TournamentId INT NOT NULL ,
	TeamId INT NOT NULL, 
    CONSTRAINT [FK_TournamentEntries_ToTournamnets] FOREIGN KEY (TournamentId) REFERENCES Tournaments(Id), 
    CONSTRAINT [FK_TournamentEntries_ToTeams] FOREIGN KEY (TeamId) REFERENCES Teams(Id), 
    CONSTRAINT [UQ_TournamentEntries_TournamnetId_TeamId] UNIQUE (TournamentId,TeamId),
	)
