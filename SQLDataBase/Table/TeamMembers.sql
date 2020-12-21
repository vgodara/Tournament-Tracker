CREATE TABLE TeamMembers
(
	Id INT NOT NULL PRIMARY KEY IDENTITY,
	TeamId INT NOT NULL,
	PersonId INT NOT NULL, 
	CONSTRAINT [FK_TeamMembers_ToTeams] FOREIGN KEY (TeamId) REFERENCES Teams(Id),
    CONSTRAINT [FK_TeamMembers_ToPeopel] FOREIGN KEY (PersonId) REFERENCES People(Id), 
    CONSTRAINT [UQ_TeamMembers_TeamId_PersonId] UNIQUE (TeamId,PersonId), 
)
