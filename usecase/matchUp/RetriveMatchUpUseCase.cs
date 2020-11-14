using model;
using usecase.common;
using System.Threading;

namespace usecase.matchUp
{
    class RetriveMatchUpUseCase : BaseUseCase<MatchUpModel,int>
    {
        private readonly IRepository repository;

        public RetriveMatchUpUseCase(IRepository repository, CancellationToken cancellationToken) : base(cancellationToken) => this.repository = repository;

        protected override MatchUpModel BuildUseCase(int request)
        {
            return repository.GetMatchUp(request);
        }
    }
}
