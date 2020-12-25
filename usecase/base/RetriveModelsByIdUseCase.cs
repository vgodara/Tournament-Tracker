

using LanguageExt;
using model;
using System.Threading;

namespace usecase.baseUseCase
{
    class RetriveModelsByIdUseCase<Model> : BaseUseCase<Lst<Model>, Lst<int>> where Model : BaseModel
    {
        private readonly IRepository<Model> repository;
        public RetriveModelsByIdUseCase(IRepository<Model> repository, CancellationToken cancllationToken) : base(cancllationToken)
        {
            this.repository = repository;
        }
        protected override Lst<Model> BuildUseCase(Lst<int> request)
        {
            return repository.GetModels(request);
        }
    }
}
