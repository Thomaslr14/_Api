using _Api.Data.Collections;
using MongoDB.Driver;

namespace _Api.Repositories
{
    public class RepositoryInfectado
    {
        protected IMongoCollection<Infectado> _ListInfectado; 
        MongoDBConnect _mongoDBConnect;
        Infectado _infectado;
        
        public RepositoryInfectado(Infectado newInfectado, MongoDBConnect connect)
        {
            _infectado = newInfectado;
            _mongoDBConnect = connect;
            _ListInfectado = _mongoDBConnect.db.GetCollection<Infectado>(typeof(Infectado).Name);
        }

        public void Create()
        {
            _ListInfectado.InsertOne(_infectado);
        }
    }
}