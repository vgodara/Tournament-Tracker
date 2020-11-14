using model;
using usecase.common;
using System.Threading;

namespace usecase.tournament
{
    class RetriveTournamentUseCase : BaseUseCase<TournamentModel,int>
    {
        private readonly IRepository repository;

        public RetriveTournamentUseCase(IRepository repository, CancellationToken cancellationToken) : base(cancellationToken) => this.repository = repository;

        protected override TournamentModel BuildUseCase(int request)
        {
            return repository.GetTournament(request);
        }
    }
}
