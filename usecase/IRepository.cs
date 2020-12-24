using model;
using LanguageExt;

namespace usecase
{
   public  interface IRepository
    {
        Lst<PersonModel> GetAllPersons();
        Lst<PersonModel> GetAllPersonInTeam(int teamId);
        Lst<PersonModel> GetPersons(Lst<int> ids);
        Lst<PersonModel> SavePersons(Lst<PersonModel> persons);


        Lst<TeamModel> GetAllTeams();
        Lst<TeamModel> GetAllTeamEntredInTournament(int tournamentId);
        Lst<TeamModel> GetTeams(Lst<int> ids);
        Lst<TeamModel> SaveTeams(Lst<TeamModel> teams);


        Lst<PrizeModel> GetAllPrizes();
        Lst<PrizeModel> GetAllPrizeInTournament(int tournamentId);
        Lst<PrizeModel> GetPrizes(Lst<int> ids);
        Lst<PrizeModel> SavePrizes(Lst<PrizeModel> prizes);
        Lst<PrizeModel> AssociatePrizeWithTournament(int tournamentId, Lst<int> prizeIds);

        Lst<MatchUpEntryModel> GetAllMatchUpEntries();
        Lst<MatchUpEntryModel> GetMatchUpEntriesInMatchUp(int matchupId);
        Lst<MatchUpEntryModel> GetMatchUpEntries(Lst<int> ids);
        Lst<MatchUpEntryModel> SaveMatchUpEntries(int matchUpId, Lst<MatchUpEntryModel> matchUpEntries);


        Lst<MatchUpModel> GetAllMatchUps();
        Lst<MatchUpModel> GetMatchUpsInRound(int roundId);
        Lst<MatchUpModel> GetMatchUps(Lst<int> ids);
        Lst<MatchUpModel> SaveMatchUps(int roundId, Lst<MatchUpModel> matchUps);

        Lst<RoundModel> GetAllRounds();
        Lst<RoundModel> GetRoundsInTournamnet(int tournamentId);
        Lst<RoundModel> GetRounds(Lst<int> ids);
        Lst<RoundModel> SaveRounds(int tournamentId, Lst<RoundModel> rounds);


        Lst<TournamentModel> GetAllTournaments();
        Lst<TournamentModel> GetTournaments(Lst<int> ids);
        Lst<TournamentModel> SaveTournaments(Lst<TournamentModel> tournaments);
    }
}
