
using model;
using usecase;

namespace datasource
{
   public interface IRemoteRepositry<Model> : IRepository<Model> where Model : BaseModel
    {
    }
}
