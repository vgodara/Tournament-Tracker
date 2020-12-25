using LanguageExt;
using model;
using System.Threading;

namespace usecase.baseUseCase
{
    class RetriveModelsByParentIdUseCase <Model> : BaseUseCase<Lst<Model>,int> where Model : BaseModel
    {
        private readonly IRepository<Model> repository;
        public RetriveModelsByParentIdUseCase(IRepository<Model> repository, CancellationToken cancllationToken) : base(cancllationToken)
        {
            this.repository = repository;
        }

        protected override Lst<Model> BuildUseCase(int request)
        {
            return repository.GetModelsAssociatedWithParent(request);
        }
    }
}
