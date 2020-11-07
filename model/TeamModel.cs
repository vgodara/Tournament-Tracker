using System.Collections.Generic;

namespace model
{
   public class TeamModel : BaseModel
    {
        /// <summary>
        /// Represents the list of people for this particular team
        /// </summary>
        public List<PersonModel> TeamMember { get; }
        /// <summary>
        /// Represents the official name of the team 
        /// </summary>
        public string TeamName { get; }

        public TeamModel ( List<PersonModel> teamMember,
                          string teamName ) : base()
        {

            TeamMember = teamMember;
            TeamName = teamName;
        }

        public TeamModel ( int id,
                          List<PersonModel> teamMember,
                          string teamName ) : base (id)
        {

            TeamMember = teamMember;
            TeamName = teamName;
        }
    }
}
