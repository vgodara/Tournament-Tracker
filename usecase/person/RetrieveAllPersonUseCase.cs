using LanguageExt;
using model;
using usecase.common;
using System.Threading;

namespace usecase.person
{
    class RetrieveAllPersonUseCase: BaseUseCase<Lst<PersonModel>, object>  
    {
        private readonly IRepository repository;

        public RetrieveAllPersonUseCase(IRepository repository, CancellationToken cancellationToken) : base(cancellationToken) => this.repository = repository;
        protected override Lst<PersonModel> BuildUseCase(object request)
        {
           return  repository.GetAllPersons();
        }
    }
}
