using model;
using usecase.common;
using System.Threading;

namespace usecase.prize
{
    class SavePrizeUseCase : BaseUseCase<PrizeModel, PrizeModel>
    {
        private readonly IRepository repository;

        public SavePrizeUseCase(IRepository repository,
                                CancellationToken cancellationToken) : base(cancellationToken) => this.repository = repository;

        protected override PrizeModel BuildUseCase(PrizeModel request)
        {
            return repository.SavePrize(request);
        }
    }
}
