using model;
using usecase.common;
using System.Threading;

namespace usecase.matchUpEntry
{
    class SaveMatchUpEntryUseCase : BaseUseCase<MatchUpEntryModel, MatchUpEntryModel>
    {
        private readonly IRepository repository;

        public SaveMatchUpEntryUseCase(IRepository repository, CancellationToken cancellationToken) : base(cancellationToken) => this.repository = repository;

        protected override MatchUpEntryModel BuildUseCase(MatchUpEntryModel request)
        {
            return repository.SaveMatchUpEntry(request);
        }
    }
}
