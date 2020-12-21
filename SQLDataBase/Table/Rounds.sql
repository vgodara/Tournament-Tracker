CREATE TABLE Rounds
(
	Id INT NOT NULL PRIMARY KEY IDENTITY,
	RoundNumber INT NOT NULL,
	TournamnetId INT NOT NULL, 
    CONSTRAINT [FK_Rounds_ToTournamanets] FOREIGN KEY (TournamnetId) REFERENCES Tournaments(Id), 
    CONSTRAINT [UQ_Rounds_RoundNumber_TournamnetId] UNIQUE (RoundNumber,TournamnetId), 

)
