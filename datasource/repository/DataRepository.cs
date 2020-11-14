using LanguageExt;
using model;
using System;
using usecase;

namespace datasource.repository
{
   public class DataRepository : IRepository
    {
        private readonly ILocalRepository localRepository;
        private readonly IRemoteRepositry remoteRepositry;
        private readonly ConnectionType connectionType;

        private IRepository GetRepository() {

            switch (connectionType) 
            {

                case ConnectionType.SQL:
                    {
                        return remoteRepositry;
                    }
                case ConnectionType.LOCAL: 
                    {
                        return localRepository;
                    }
                default: 
                    {
                        throw new NotSupportedException();
                    }
            }
        }

        public Lst<PersonModel> GetAllPersons()
        {
            return GetRepository().GetAllPersons();
        }

        public PersonModel GetPerson(int id)
        {
             return GetRepository().GetPerson(id) ;
        }

        public PersonModel SavePerson(PersonModel person)
        {
             return GetRepository().SavePerson(person) ;
        }

        public Lst<TeamModel> GetAllTeams()
        {
             return GetRepository().GetAllTeams();
        }

        public TeamModel GetTeam(int id)
        {
             return GetRepository().GetTeam(id);
        }

        public TeamModel SaveTeam(TeamModel team)
        {
             return GetRepository().SaveTeam(team);
        }

        public Lst<PrizeModel> GetAllPrizes()
        {
             return GetRepository().GetAllPrizes();
        }

        public PrizeModel GetPrize(int id)
        {
             return GetRepository().GetPrize(id);
        }

        public PrizeModel SavePrize(PrizeModel prize)
        {
             return GetRepository().SavePrize(prize);
        }

        public Lst<MatchUpEntryModel> GetAllMatchUpEntries()
        {
             return GetRepository().GetAllMatchUpEntries();
        }

        public MatchUpEntryModel GetMatchUpEntry(int id)
        {
             return GetRepository().GetMatchUpEntry(id);
        }

        public MatchUpEntryModel SaveMatchUpEntry(MatchUpEntryModel matchUpEntry)
        {
             return GetRepository().SaveMatchUpEntry(matchUpEntry);
        }

        public Lst<MatchUpModel> GetAllMatchUps()
        {
             return GetRepository().GetAllMatchUps();
        }

        public MatchUpModel GetMatchUp(int id)
        {
             return GetRepository().GetMatchUp(id);
        }

        public MatchUpModel SaveMatchUp(MatchUpModel matchUp)
        {
             return GetRepository().SaveMatchUp(matchUp);
        }

        public Lst<RoundModel> GetAllRounds()
        {
             return GetRepository().GetAllRounds();
        }

        public RoundModel GetRound(int id)
        {
             return GetRepository().GetRound(id);
        }

        public RoundModel SaveRound(RoundModel round)
        {
             return GetRepository().SaveRound(round);
        }

        public Lst<TournamentModel> GetAllTournaments()
        {
             return GetRepository().GetAllTournaments();
        }

        public TournamentModel GetTournament(int id)
        {
             return GetRepository().GetTournament(id);
        }

        public TournamentModel SaveTournament(TournamentModel tournament)
        {
             return GetRepository().SaveTournament(tournament);
        }

        public DataRepository(ILocalRepository localRepository, IRemoteRepositry remoteRepositry, ConnectionType connectionType) {
           this.localRepository = localRepository;
            this.remoteRepositry = remoteRepositry;
            this.connectionType = connectionType;
        }
    }
}
