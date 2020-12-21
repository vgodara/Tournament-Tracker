CREATE TABLE TournamentPrizes
(
	Id INT NOT NULL PRIMARY KEY IDENTITY,
	TournamentId INT NOT NULL,
	PrizeId INT NOT NULL , 
	CONSTRAINT [FK_TournamentPrizes_ToTournaments] FOREIGN KEY (TournamentId) REFERENCES Tournaments(Id),
    CONSTRAINT [FK_TournamentPrizes_ToPrizes] FOREIGN KEY (PrizeId) REFERENCES Prizes(Id), 
    CONSTRAINT [UQ_TournamentPrizes_TournamnetId_PrizeId] UNIQUE (TournamentId,PrizeId), 
    
)
