using LanguageExt;
using model;
using System.Threading;
using usecase.common;


namespace usecase.round
{
    class RetriveAllTournamentUseCase : BaseUseCase<Lst<TournamentModel>, object>
    {
        private readonly IRepository repository;

        public RetriveAllTournamentUseCase(IRepository repository, CancellationToken cancellationToken) : base(cancellationToken) => this.repository = repository;

        protected override Lst<TournamentModel> BuildUseCase(object request)
        {
            return repository.GetAllTournaments();
        }
    }
}
