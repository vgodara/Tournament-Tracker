

using model;
using System.Threading;

namespace usecase.baseUseCase
{
    class SaveIndepedentModelUseCase<Model> : BaseUseCase<Model,Model> where Model : BaseModel
     {
        private readonly IRepository<Model> repository;

        public SaveIndepedentModelUseCase(IRepository<Model> repository, CancellationToken cancellationToken) : base(cancellationToken) {

            this.repository = repository;
        }

        protected override Model BuildUseCase(Model request)
        {
            return repository.SaveModel(request);
        }
    }
}
