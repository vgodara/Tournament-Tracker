using System.Collections.Generic;

namespace model
{
   public class MatchUpModel : BaseModel
    {
        /// <summary>
        /// Represents List of match-up entry for this match up 
        /// </summary>
        public List<MatchUpEntryModel> MatchUpEntries { get; }
        /// <summary>
        /// Represents Winner Team for this match up
        /// </summary>
        public TeamModel WinnerTeam { get; }

        public MatchUpModel ( List<MatchUpEntryModel> matchUpEntries,
                             TeamModel winnerTeam ) : base()
        {
            MatchUpEntries = matchUpEntries;
            WinnerTeam = winnerTeam;
        }

        public MatchUpModel ( int id,
                             List<MatchUpEntryModel> matchUpEntries,
                             TeamModel winnerTeam ) : base(id)
        {
            MatchUpEntries = matchUpEntries;
            WinnerTeam = winnerTeam;
        }
    }
}