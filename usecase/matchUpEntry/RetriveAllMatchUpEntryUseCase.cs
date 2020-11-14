using LanguageExt;
using model;
using System.Threading;
using usecase.common;


namespace usecase.matchUpEntry
{
    class RetriveAllMatchUpEntryUseCase : BaseUseCase<Lst<MatchUpEntryModel>, object>
    {
        private readonly IRepository repository;

        public RetriveAllMatchUpEntryUseCase(IRepository repository, CancellationToken cancellationToken) : base(cancellationToken) => this.repository = repository;

        protected override Lst<MatchUpEntryModel> BuildUseCase(object request)
        {
            return repository.GetAllMatchUpEntries();
        }
    }
}
