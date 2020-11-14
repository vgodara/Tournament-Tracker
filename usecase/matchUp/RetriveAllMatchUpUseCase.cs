using LanguageExt;
using model;
using System.Threading;
using usecase.common;


namespace usecase.matchUp
{
    class RetriveAllMatchUpUseCase : BaseUseCase<Lst<MatchUpModel>, object>
    {
        private readonly IRepository repository;

        public RetriveAllMatchUpUseCase(IRepository repository, CancellationToken cancellationToken) : base(cancellationToken) => this.repository = repository;

        protected override Lst<MatchUpModel> BuildUseCase(object request)
        {
            return repository.GetAllMatchUps();
        }
    }
}
