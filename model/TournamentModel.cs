using LanguageExt;
using System.Collections.Generic;

namespace model
{
  public  class TournamentModel : BaseModel
    {
        /// <summary>
        /// Official Tournament Name 
        /// </summary>
        public string TournamentName { get; }
        /// <summary>
        /// Entry fee for this particular tournament
        /// </summary>
        public decimal EnteryFee { get; }
        /// <summary>
        /// List of Teams participating in this particular tournament
        /// </summary>
        public Lst<TeamModel> EnteredTeams { get; }
        /// <summary>
        /// Total amount of prize for this particular tournament
        /// </summary>
        public Lst<PrizeModel> Prizes { get; }
        /// <summary>
        /// List of rounds to held for this particular tournament
        /// </summary>
        public Lst<RoundModel> Rounds { get; }

        public TournamentModel ( string tournamentName,
                                decimal entryFee,
                                Lst<TeamModel> enteredTeams,
                                Lst<PrizeModel> prizes,
                                Lst<RoundModel> rounds ) : base ()
        {

            TournamentName = tournamentName;
            EnteryFee = entryFee;
            EnteredTeams = enteredTeams;
            Prizes = prizes;
            Rounds = rounds;
        }
        public TournamentModel ( int id,
                                string tournamentName,
                                decimal entryFee,
                                Lst<TeamModel> enteredTeams,
                                Lst<PrizeModel> prizes,
                                Lst<RoundModel> rounds ) : base (id)
        {

            TournamentName = tournamentName;
            EnteryFee = entryFee;
            EnteredTeams = enteredTeams;
            Prizes = prizes;
            Rounds = rounds;
        }
    }
}
