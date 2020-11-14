using System.Threading;
using LanguageExt;
using model;
using usecase.common;

namespace usecase.team
{
    class RetrieveAllTeamUseCase : BaseUseCase<Lst<TeamModel>,object>
    {
        private readonly IRepository repository;

        public RetrieveAllTeamUseCase(IRepository repository, CancellationToken cancellationToken) : base(cancellationToken) => this.repository = repository;

        protected override Lst<TeamModel> BuildUseCase(object request)
        {
            return repository.GetAllTeams();
        }
    }
}
