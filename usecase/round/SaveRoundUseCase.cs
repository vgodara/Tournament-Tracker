using model;
using usecase.common;
using System.Threading;

namespace usecase.round
{
    class SaveRoundUseCase : BaseUseCase<RoundModel, RoundModel>
    {
        private readonly IRepository repository;

        public SaveRoundUseCase(IRepository repository, CancellationToken cancellationToken) : base(cancellationToken) => this.repository = repository;

        protected override RoundModel BuildUseCase(RoundModel request)
        {
            return repository.SaveRound(request);
        }
    }
}
