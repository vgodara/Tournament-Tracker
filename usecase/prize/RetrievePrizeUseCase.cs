using model;
using usecase.common;
using System.Threading;

namespace usecase.prize
{
    class RetrievePrizeUseCase : BaseUseCase<PrizeModel,int>
    {
        private readonly IRepository repository;

        public RetrievePrizeUseCase(IRepository repository, CancellationToken cancellationToken) : base(cancellationToken) => this.repository = repository;

        protected override PrizeModel BuildUseCase(int request)
        {
            return repository.GetPrize(request);
        }
    }
}
