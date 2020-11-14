using model;
using usecase.common;
using System.Threading;

namespace usecase.matchUpEntry
{
    class RetriveMatchUpEntryUseCase : BaseUseCase<MatchUpEntryModel,int>
    {
        private readonly IRepository repository;

        public RetriveMatchUpEntryUseCase(IRepository repository, CancellationToken cancellationToken) : base(cancellationToken) => this.repository = repository;

        protected override MatchUpEntryModel BuildUseCase(int request)
        {
            return repository.GetMatchUpEntry(request);
        }
    }
}
