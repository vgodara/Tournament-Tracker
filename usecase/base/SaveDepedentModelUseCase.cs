using model;
using System;
using System.Threading;

namespace usecase.baseUseCase
{
    class SaveDepedentModelUseCase<Model> : BaseUseCase<Model, Tuple<Model, int>> where Model : BaseModel
    {

        private readonly IRepository<Model> repository;

        public SaveDepedentModelUseCase(IRepository<Model> repository, CancellationToken cancellationToken) : base(cancellationToken)
        {

            this.repository = repository;
        }

        protected override Model BuildUseCase(Tuple<Model, int> request)
        {
            return repository.SaveModel(request.Item1, request.Item2);
        }
    }
}
