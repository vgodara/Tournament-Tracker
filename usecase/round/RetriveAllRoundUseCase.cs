using LanguageExt;
using model;
using System.Threading;
using usecase.common;


namespace usecase.round
{
    class RetriveAllRoundUseCase : BaseUseCase<Lst<RoundModel>, object>
    {
        private readonly IRepository repository;

        public RetriveAllRoundUseCase(IRepository repository, CancellationToken cancellationToken) : base(cancellationToken) => this.repository = repository;

        protected override Lst<RoundModel> BuildUseCase(object request)
        {
            return repository.GetAllRounds();
        }
    }
}
