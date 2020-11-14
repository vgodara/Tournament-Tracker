using model;
using usecase.common;
using System.Threading;
using LanguageExt;

namespace usecase.prize
{
    class RetrieveAllPrizeUseCase : BaseUseCase<Lst<PrizeModel>, object>
    {
        private readonly IRepository repository;

        public RetrieveAllPrizeUseCase  (IRepository repository, CancellationToken cancellationToken) : base(cancellationToken) => this.repository = repository;

        protected override Lst<PrizeModel> BuildUseCase(object request)
        {
            return repository.GetAllPrizes();
        }
    }
}
