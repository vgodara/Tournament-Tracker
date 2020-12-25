using LanguageExt;
using model;
using System;
using System.Threading;

namespace usecase.baseUseCase
{
    class SaveDepedentModelsUseCase <Model>: BaseUseCase<Lst<Model>,Tuple<Lst<Model>, int>> where Model : BaseModel
    {
        private readonly IRepository<Model> repository;

        public SaveDepedentModelsUseCase(IRepository<Model> repository, CancellationToken cancellationToken) : base(cancellationToken)
        {

            this.repository = repository;
        }

        protected override Lst<Model> BuildUseCase(Tuple<Lst<Model>, int> request)
        {
            return repository.SaveAllModel(request.Item1, request.Item2);
        }
    }
}
