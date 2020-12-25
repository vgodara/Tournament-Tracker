using LanguageExt;
using model;

namespace usecase
{
    public interface IRepository<Model> where Model : BaseModel
    {
        public Model GetModel(int id);
        public Lst<Model> GetModels(Lst<int> ids);
        public Model GetModelAssociatedWithParent(int parentId);
        public Lst<Model> GetModelsAssociatedWithParent(int parentId);
        public Lst<Model> GetAlllModels();
        public Model SaveModel(Model model, int parentId = int.MinValue);
        public Lst<Model> SaveAllModel(Lst<Model> models, int parentId = int.MinValue);
        public Model AssociateModelWithParent(int id, int parentId = int.MinValue);
        public Lst<Model> AssociateModelsWithParent(Lst<int> ids, int parentId = int.MinValue);

    }
}
