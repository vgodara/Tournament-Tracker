using LanguageExt;
using model;
using System;
using System.Threading;

namespace usecase.baseUseCase
{
    class RetriveAllModelsUseCase<Model> : BaseUseCase<Lst<Model>,Unit> where Model : BaseModel
    {
        private readonly IRepository<Model> repository;
        public RetriveAllModelsUseCase(IRepository<Model> repository, CancellationToken cancellationToken) : base(cancellationToken)
        {

            this.repository = repository;
        }

        protected override Lst<Model> BuildUseCase(Unit request)
        {
            return repository.GetAlllModels();
        }
    }
}
