using model;
using System;
using System.Threading;
using usecase.common;

namespace usecase.person
{
    class SavePersonUseCase : BaseUseCase<PersonModel, PersonModel>
    {
        private readonly IRepository repository;

        public SavePersonUseCase(IRepository repository, CancellationToken cancellationToken) : base(cancellationToken) => this.repository = repository;
        protected override PersonModel BuildUseCase(PersonModel request)
        {
          return  repository.SavePerson(request);
        }
    }
}
