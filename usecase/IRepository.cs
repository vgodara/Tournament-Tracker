using model;
using LanguageExt;

namespace usecase
{
   public  interface IRepository
    {
        Lst<PersonModel> GetAllPersons();
        PersonModel GetPerson(int id);
        PersonModel SavePerson(PersonModel person);


        Lst<TeamModel> GetAllTeams();
        TeamModel GetTeam(int id);
        TeamModel SaveTeam(TeamModel team);


        Lst<PrizeModel> GetAllPrizes();
        PrizeModel GetPrize(int id);
        PrizeModel SavePrize(PrizeModel prize);

        Lst<MatchUpEntryModel> GetAllMatchUpEntries();
        MatchUpEntryModel GetMatchUpEntry(int id);
        MatchUpEntryModel SaveMatchUpEntry(MatchUpEntryModel matchUpEntry);


        Lst<MatchUpModel> GetAllMatchUps();
        MatchUpModel GetMatchUp(int id);
        MatchUpModel SaveMatchUp(MatchUpModel matchUp);

        Lst<RoundModel> GetAllRounds();
        RoundModel GetRound(int id);
        RoundModel SaveRound(RoundModel round);


        Lst<TournamentModel> GetAllTournaments();
        TournamentModel GetTournament(int id);
        TournamentModel SaveTournament(TournamentModel tournament);
    }
}
