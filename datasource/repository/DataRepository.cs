using LanguageExt;
using model;
using System;
using usecase;

namespace datasource.repository
{
   public class DataRepository : IRepository
    {
   
        private readonly IRemoteRepositry remoteRepositry;
        private readonly ConnectionType connectionType;

        private IRepository GetRepository() {

            switch (connectionType) 
            {

                case ConnectionType.SQL:
                    {
                        return remoteRepositry;
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

        public Lst<PersonModel> GetPersons(Lst<int> ids)
        {
             return GetRepository().GetPersons(ids);
        }

        public Lst<PersonModel> SavePersons(Lst<PersonModel> persons)
        {
             return GetRepository().SavePersons(persons);
        }

        public Lst<TeamModel> GetAllTeams()
        {
             return GetRepository().GetAllTeams();
        }

        public Lst<TeamModel> GetTeams(Lst<int> ids)
        {
             return GetRepository().GetTeams(ids);
        }

        public Lst<TeamModel> SaveTeams(Lst<TeamModel> teams)
        {
             return GetRepository().SaveTeams(teams);
        }

        public Lst<PrizeModel> GetAllPrizes()
        {
             return GetRepository().GetAllPrizes();
        }

        public Lst<PrizeModel> GetPrizes(Lst<int> ids)
        {
             return GetRepository().GetPrizes(ids);
        }

        public Lst<PrizeModel> SavePrizes(Lst<PrizeModel> prizes)
        {
             return GetRepository().SavePrizes(prizes);
        }

        public Lst<MatchUpEntryModel> GetAllMatchUpEntries()
        {
             return GetRepository().GetAllMatchUpEntries();
        }

        public Lst<MatchUpEntryModel> GetMatchUpEntries(Lst<int> ids)
        {
             return GetRepository().GetMatchUpEntries(ids);
        }

        public Lst<MatchUpEntryModel> SaveMatchUpEntries(int matchUpId, Lst<MatchUpEntryModel> matchUpEntries)
        {
             return GetRepository().SaveMatchUpEntries(matchUpId, matchUpEntries);
        }

        public Lst<MatchUpModel> GetAllMatchUps()
        {
             return GetRepository().GetAllMatchUps();
        }

        public Lst<MatchUpModel> GetMatchUps(Lst<int> id)
        {
             return GetRepository().GetMatchUps(id);
        }

        public Lst<MatchUpModel> SaveMatchUps(int roundId, Lst<MatchUpModel> matchUps)
        {
             return GetRepository().SaveMatchUps(roundId, matchUps);
        }

        public Lst<RoundModel> GetAllRounds()
        {
             return GetRepository().GetAllRounds();
        }

        public Lst<RoundModel> GetRounds(Lst<int> ids)
        {
             return GetRepository().GetRounds(ids);
        }

        public Lst<RoundModel> SaveRounds(int tournamentId, Lst<RoundModel> rounds)
        {
             return GetRepository().SaveRounds(tournamentId, rounds);
        }

        public Lst<TournamentModel> GetAllTournaments()
        {
             return GetRepository().GetAllTournaments();
        }

        public Lst<TournamentModel> GetTournaments(Lst<int> ids)
        {
             return GetRepository().GetTournaments(ids);
        }

        public Lst<TournamentModel> SaveTournaments(Lst<TournamentModel> tournaments)
        {
             return GetRepository().SaveTournaments(tournaments);
        }

        public Lst<PersonModel> GetAllPersonInTeam(int teamId)
        {
            return GetRepository().GetAllPersonInTeam(teamId);
        }

        public Lst<TeamModel> GetAllTeamEntredInTournament(int tournamentId)
        {
            return GetRepository().GetAllTeamEntredInTournament(tournamentId);
        }

        public Lst<PrizeModel> GetAllPrizeInTournament(int tournamentId)
        {
            return GetRepository().GetAllPrizeInTournament(tournamentId);
        }

        public Lst<PrizeModel> AssociatePrizeWithTournament(int tournamentId, Lst<int> prizeIds)
        {
            return GetRepository().AssociatePrizeWithTournament(tournamentId, prizeIds);
        }

        public Lst<MatchUpEntryModel> GetMatchUpEntriesInMatchUp(int matchupId)
        {
            return GetRepository().GetMatchUpEntriesInMatchUp(matchupId);
        }

        public Lst<MatchUpModel> GetMatchUpsInRound(int roundId)
        {
            return GetRepository().GetMatchUpsInRound(roundId);
        }

        public Lst<RoundModel> GetRoundsInTournamnet(int tournamentId)
        {
            return GetRepository().GetRoundsInTournamnet(tournamentId);
        }

        public DataRepository(IRemoteRepositry remoteRepositry, ConnectionType connectionType) {
            this.remoteRepositry = remoteRepositry;
            this.connectionType = connectionType;
        }
    }
}
