namespace model
{
    /// <summary>
    /// Represents one team in a match-up
    /// </summary>
    public class MatchUpEntryModel : BaseModel
    {
        /// <summary>
        /// Represents One Team in the match-up
        /// </summary>
        public TeamModel CompeteingTeam { get; }
        /// <summary>
        /// Represents the score for this particular team 
        /// for corresponding match-up
        /// </summary>
        public double Score { get; }
        /// <summary>
        /// Represents the match-up that this team came from 
        /// as winner
        /// </summary>
        public MatchUpModel ParentMatchUp { get; }

        public MatchUpEntryModel (int id,
                                  TeamModel competeingTeam,
                                  double score,
                                  MatchUpModel parentMatchUp ) : base ( id )
        {

            CompeteingTeam = competeingTeam;
            Score = score;
            ParentMatchUp = parentMatchUp;

        }
        public MatchUpEntryModel ( int id,
                                  TeamModel competeingTeam,
                                  double score ) : this ( id, competeingTeam, score, null )
        {

        }
        public MatchUpEntryModel (TeamModel competeingTeam,
                                  double score,
                                  MatchUpModel parentMatchUp ) : base ()
        {

            CompeteingTeam = competeingTeam;
            Score = score;
            ParentMatchUp = parentMatchUp;

        }
        public MatchUpEntryModel ( TeamModel competeingTeam,
                                  double score ) :this(competeingTeam,score,null)
        {

        }
    }
}
