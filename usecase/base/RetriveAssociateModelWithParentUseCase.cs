using model;
using System;
using System.Threading;

namespace usecase.baseUseCase
{
    class RetriveAssociateModelWithParentUseCase<Model> : BaseUseCase<Model,Tuple<int,int>> where Model : BaseModel

    {
        private readonly IRepository<Model> repository;
        public RetriveAssociateModelWithParentUseCase(IRepository<Model> repository, CancellationToken cancellationToken) : base(cancellationToken)
        {

            this.repository = repository;
        }

        protected override Model BuildUseCase(Tuple<int, int> request)
        {
           return repository.AssociateModelWithParent(request.Item1,request.Item2);
        }
    }
}
