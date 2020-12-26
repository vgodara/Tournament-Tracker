using LanguageExt;
using System.Collections.Generic;

namespace model
{
   public class TeamModel : BaseModel
    {
        /// <summary>
        /// Represents the list of people for this particular team
        /// </summary>
        public Lst<PersonModel> TeamMembers { get; }
        /// <summary>
        /// Represents the official name of the team 
        /// </summary>
        public string TeamName { get; }

        public TeamModel ( Lst<PersonModel> teamMember,
                          string teamName ) : base()
        {

            TeamMembers = teamMember;
            TeamName = teamName;
        }

        public TeamModel ( int id,
                          Lst<PersonModel> teamMember,
                          string teamName ) : base (id)
        {

            TeamMembers = teamMember;
            TeamName = teamName;
        }
    }
}
