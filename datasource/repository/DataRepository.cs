using LanguageExt;
using model;
using System;
using usecase;

namespace datasource.repository
{


   public class DataRepository<Model> : IRepository<Model> where Model : BaseModel
    {
   
        private readonly IRemoteRepositry<Model> remoteRepositry;
        private readonly ConnectionType connectionType;

        public DataRepository(IRemoteRepositry<Model> remoteRepositry, ConnectionType connectionType) {
            this.remoteRepositry = remoteRepositry;
            this.connectionType = connectionType;
        }

        public Lst<Model> AssociateModelsWithParent(Lst<int> ids, int parentId = int.MinValue)
        {
            return GetRepository().AssociateModelsWithParent(ids, parentId);
        }

        public Model AssociateModelWithParent(int id, int parentId = int.MinValue)
        {
            return GetRepository().AssociateModelWithParent(id, parentId);
        }

        public Lst<Model> GetAlllModels()
        {
            return GetRepository().GetAlllModels() ;
        }

        public Model GetModel(int id)
        {
            return GetRepository().GetModel(id) ;
        }

        public Model GetModelAssociatedWithParent(int parentId)
        {
            return remoteRepositry.GetModelAssociatedWithParent(parentId);
        }

        public Lst<Model> GetModels(Lst<int> ids)
        {
            return GetRepository().GetModels(ids) ;
        }

        public Lst<Model> GetModelsAssociatedWithParent(int parentId)
        {
            return remoteRepositry.GetModelsAssociatedWithParent(parentId);
        }

        public Lst<Model> SaveAllModel(Lst<Model> models, int parentId = int.MinValue)
        {
            return GetRepository().SaveAllModel(models,parentId) ;
        }

        public Model SaveModel(Model model, int parentId = int.MinValue)
        {
            return GetRepository().SaveModel(model,parentId) ;
        }

        private IRepository<Model> GetRepository() {

            switch (connectionType) 
            {

                case ConnectionType.SQL:
                    {
                        return remoteRepositry;
                    }
                default: 
                    {
                        throw new NotSupportedException();
                    }
            }
        }

    }
}
