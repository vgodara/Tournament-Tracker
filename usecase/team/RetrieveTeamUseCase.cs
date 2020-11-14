using System.Threading;
using model;
using usecase.common;
namespace usecase.team
{
    class RetrieveTeamUseCase : BaseUseCase<TeamModel, int>
    {
        private readonly IRepository repository;

        public RetrieveTeamUseCase(IRepository repository, CancellationToken cancellationToken) : base(cancellationToken) => this.repository = repository;

        protected override TeamModel BuildUseCase(int request)
        {
            return repository.GetTeam(request);
        }
    }
}
