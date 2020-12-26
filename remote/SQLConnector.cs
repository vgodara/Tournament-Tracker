using datasource;
using LanguageExt;
using model;
using System;

namespace remote
{
   public class SQLConnector<Model> : IRemoteRepositry<Model> where Model : BaseModel
    {
        private readonly string connectionString;
        public SQLConnector(string connectionString) {
            this.connectionString = connectionString;
        }

        public Lst<Model> AssociateModelsWithParent(Lst<int> ids, int parentId)
        {
            switch (typeof(Model)) {
                case Type type when type == typeof(PersonModel):
                    break;
                case Type type when type == typeof(PrizeModel):
                    break;
                case Type type when type == typeof(TeamModel):
                    break;
                case Type type when type == typeof(MatchUpEntryModel):
                    break;
                case Type type when type == typeof(MatchUpModel):
                    break;
                case Type type when type == typeof(RoundModel):
                    break;
                case Type type when type == typeof(TournamentModel):
                    break;
                default :
                    throw new NotSupportedException();

            }
            throw new System.NotImplementedException();
        }

        public Model AssociateModelWithParent(int id, int parentId)
        {
            switch (typeof(Model))
            {
                case Type type when type == typeof(PersonModel):
                    break;
                case Type type when type == typeof(PrizeModel):
                    break;
                case Type type when type == typeof(TeamModel):
                    break;
                case Type type when type == typeof(MatchUpEntryModel):
                    break;
                case Type type when type == typeof(MatchUpModel):
                    break;
                case Type type when type == typeof(RoundModel):
                    break;
                case Type type when type == typeof(TournamentModel):
                    break;
                default:
                    throw new NotSupportedException();

            }
            throw new System.NotImplementedException();
        }

        public Lst<Model> GetAlllModels()
        {
            switch (typeof(Model))
            {
                case Type type when type == typeof(PersonModel):
                    break;
                case Type type when type == typeof(PrizeModel):
                    break;
                case Type type when type == typeof(TeamModel):
                    break;
                case Type type when type == typeof(MatchUpEntryModel):
                    break;
                case Type type when type == typeof(MatchUpModel):
                    break;
                case Type type when type == typeof(RoundModel):
                    break;
                case Type type when type == typeof(TournamentModel):
                    break;
                default:
                    throw new NotSupportedException();

            }
            throw new System.NotImplementedException();
        }

        public Model GetModel(int id)
        {
            switch (typeof(Model))
            {
                case Type type when type == typeof(PersonModel):
                    break;
                case Type type when type == typeof(PrizeModel):
                    break;
                case Type type when type == typeof(TeamModel):
                    break;
                case Type type when type == typeof(MatchUpEntryModel):
                    break;
                case Type type when type == typeof(MatchUpModel):
                    break;
                case Type type when type == typeof(RoundModel):
                    break;
                case Type type when type == typeof(TournamentModel):
                    break;
                default:
                    throw new NotSupportedException();

            }
            throw new System.NotImplementedException();
        }

        public Model GetModelAssociatedWithParent(int parentId)
        {
            switch (typeof(Model))
            {
                case Type type when type == typeof(PersonModel):
                    break;
                case Type type when type == typeof(PrizeModel):
                    break;
                case Type type when type == typeof(TeamModel):
                    break;
                case Type type when type == typeof(MatchUpEntryModel):
                    break;
                case Type type when type == typeof(MatchUpModel):
                    break;
                case Type type when type == typeof(RoundModel):
                    break;
                case Type type when type == typeof(TournamentModel):
                    break;
                default:
                    throw new NotSupportedException();

            }
            throw new System.NotImplementedException();
        }

        public Lst<Model> GetModels(Lst<int> ids)
        {
            switch (typeof(Model))
            {
                case Type type when type == typeof(PersonModel):
                    break;
                case Type type when type == typeof(PrizeModel):
                    break;
                case Type type when type == typeof(TeamModel):
                    break;
                case Type type when type == typeof(MatchUpEntryModel):
                    break;
                case Type type when type == typeof(MatchUpModel):
                    break;
                case Type type when type == typeof(RoundModel):
                    break;
                case Type type when type == typeof(TournamentModel):
                    break;
                default:
                    throw new NotSupportedException();

            }
            throw new System.NotImplementedException();
        }

        public Lst<Model> GetModelsAssociatedWithParent(int parentId)
        {
            switch (typeof(Model))
            {
                case Type type when type == typeof(PersonModel):
                    break;
                case Type type when type == typeof(PrizeModel):
                    break;
                case Type type when type == typeof(TeamModel):
                    break;
                case Type type when type == typeof(MatchUpEntryModel):
                    break;
                case Type type when type == typeof(MatchUpModel):
                    break;
                case Type type when type == typeof(RoundModel):
                    break;
                case Type type when type == typeof(TournamentModel):
                    break;
                default:
                    throw new NotSupportedException();

            }
            throw new System.NotImplementedException();
        }

        public Lst<Model> SaveAllModel(Lst<Model> models, int parentId = int.MinValue)
        {
            switch (typeof(Model))
            {
                case Type type when type == typeof(PersonModel):
                    break;
                case Type type when type == typeof(PrizeModel):
                    break;
                case Type type when type == typeof(TeamModel):
                    break;
                case Type type when type == typeof(MatchUpEntryModel):
                    break;
                case Type type when type == typeof(MatchUpModel):
                    break;
                case Type type when type == typeof(RoundModel):
                    break;
                case Type type when type == typeof(TournamentModel):
                    break;
                default:
                    throw new NotSupportedException();

            }
            throw new System.NotImplementedException();
        }

        public Model SaveModel(Model model, int parentId = int.MinValue)
        {
            switch (typeof(Model))
            {
                case Type type when type == typeof(PersonModel):
                    break;
                case Type type when type == typeof(PrizeModel):
                    break;
                case Type type when type == typeof(TeamModel):
                    break;
                case Type type when type == typeof(MatchUpEntryModel):
                    break;
                case Type type when type == typeof(MatchUpModel):
                    break;
                case Type type when type == typeof(RoundModel):
                    break;
                case Type type when type == typeof(TournamentModel):
                    break;
                default:
                    throw new NotSupportedException();

            }
            throw new System.NotImplementedException();
        }
    }
}
