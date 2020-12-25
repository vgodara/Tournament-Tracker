using LanguageExt;
using model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace usecase.baseUseCase
{
    class SaveIndepedentModelsUseCase<Model> : BaseUseCase<Lst<Model>, Lst<Model>> where Model : BaseModel
    {
        private readonly IRepository<Model> repository;

        public SaveIndepedentModelsUseCase(IRepository<Model> repository, CancellationToken cancellationToken) : base(cancellationToken)
        {

            this.repository = repository;
        }

        protected override Lst<Model> BuildUseCase(Lst<Model> request)
        {
            return repository.SaveAllModel(request);
        }
    }
 
}
