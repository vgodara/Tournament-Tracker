using System.Threading;
using model;
using usecase.common;

namespace usecase.team
{
    class SaveTeamUseCase : BaseUseCase<TeamModel, TeamModel>
    {
        private readonly IRepository repository;

        public SaveTeamUseCase(IRepository repository, CancellationToken cancellationToken) : base(cancellationToken) => this.repository = repository;

        protected override TeamModel BuildUseCase(TeamModel request)
        {
            return repository.SaveTeam(request);
        }
    }
}
