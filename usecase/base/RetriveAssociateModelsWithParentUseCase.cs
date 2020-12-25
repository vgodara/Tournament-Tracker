using LanguageExt;
using model;
using System;
using System.Threading;

namespace usecase.baseUseCase
{
    class RetriveAssociateModelsWithParentUseCase<Model> : BaseUseCase<Lst<Model>,Tuple<Lst<int>,int>> where Model : BaseModel
    {
        private readonly IRepository<Model> repository;
        public RetriveAssociateModelsWithParentUseCase(IRepository<Model> repository, CancellationToken cancellationToken) : base(cancellationToken)
        {

            this.repository = repository;
        }

        protected override Lst<Model> BuildUseCase(Tuple<Lst<int>, int> request)
        {
            return repository.AssociateModelsWithParent(request.Item1,request.Item2);
        }
    }
}
