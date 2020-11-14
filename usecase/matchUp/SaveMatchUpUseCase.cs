using model;
using usecase.common;
using System.Threading;

namespace usecase.matchUp
{
    class SaveMatchUpUseCase : BaseUseCase<MatchUpModel, MatchUpModel>
    {
        private readonly IRepository repository;

        public SaveMatchUpUseCase(IRepository repository, CancellationToken cancellationToken) : base(cancellationToken) => this.repository = repository;

        protected override MatchUpModel BuildUseCase(MatchUpModel request)
        {
            return repository.SaveMatchUp(request);
        }
    }
}
