using model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace usecase.baseUseCase
{
    class RetriveModelByParentIdUseCase<Model> : BaseUseCase<Model,int> where Model :BaseModel
    {
        private readonly IRepository<Model> repository;
        public RetriveModelByParentIdUseCase(IRepository<Model> repository, CancellationToken cancllationToken) : base(cancllationToken)
        {
            this.repository = repository;
        }

        protected override Model BuildUseCase(int request)
        {
            return repository.GetModelAssociatedWithParent(request);
        }
    }
}
