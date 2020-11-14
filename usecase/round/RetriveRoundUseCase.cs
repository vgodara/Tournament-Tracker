using model;
using usecase.common;
using System.Threading;

namespace usecase.round
{
    class RetriveRoundUseCase : BaseUseCase<RoundModel,int>
    {
        private readonly IRepository repository;

        public RetriveRoundUseCase(IRepository repository, CancellationToken cancellationToken) : base(cancellationToken) => this.repository = repository;

        protected override RoundModel BuildUseCase(int request)
        {
            return repository.GetRound(request);
        }
    }
}
