using System.Collections.Generic;

namespace model
{
  public  class RoundModel : BaseModel
    {
        /// <summary>
        /// Round number in a particular tournament
        /// </summary>
        public int RoundNumber { get; }
        /// <summary>
        /// List of match held for this round
        /// </summary>
        public List<MatchUpModel> MatchUps { get; }

        public RoundModel ( int roundNumber,
                           List<MatchUpModel> matchUps ) : base ()
        {
            RoundNumber = roundNumber;
            MatchUps = matchUps;
        }

        public RoundModel ( int id,
                           int roundNumber,
                           List<MatchUpModel> matchUps ) : base (id)
        {
            RoundNumber = roundNumber;
            MatchUps = matchUps;
        }
    }
}
