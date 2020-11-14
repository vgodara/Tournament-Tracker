using model;
using usecase.common;
using System.Threading;

namespace usecase.tournament
{
    class SaveTournamentUseCase : BaseUseCase<TournamentModel, TournamentModel>
    {
        private readonly IRepository repository;

        public SaveTournamentUseCase(IRepository repository, CancellationToken cancellationToken) : base(cancellationToken) => this.repository = repository;

        protected override TournamentModel BuildUseCase(TournamentModel request)
        {
            return repository.SaveTournament(request);
        }
    }
}
