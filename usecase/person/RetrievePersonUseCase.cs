using model;
using usecase.common;
using System.Threading;
namespace usecase.person
{
    class RetrievePersonUseCase : BaseUseCase<PersonModel, int>
    {
        private readonly IRepository repository;
        public RetrievePersonUseCase(IRepository repository, CancellationToken cancellationToken) : base(cancellationToken) => this.repository = repository;
        protected override PersonModel BuildUseCase(int request)
        {
            return repository.GetPerson(request);
        }
    }
}
