using System.Collections.Generic;
using _Api.Data.Collections;
using MongoDB.Driver;

namespace _Api.Repositories
{
    public class RepositoryVacinado
    {
        protected IMongoCollection<Vacinado> _ListVacinado;
        MongoDBConnect _mongoDBConnect;

        public RepositoryVacinado(MongoDBConnect connect)
        {
            _mongoDBConnect = connect;
            _ListVacinado = _mongoDBConnect.db.GetCollection<Vacinado>(typeof(Vacinado).Name);
        }

        public void Create(Vacinado newVacinado)
        {
            _ListVacinado.InsertOne(newVacinado);
        }

        public List<Vacinado> Get()
        {
            var filter = Builders<Vacinado>.Filter.Empty;
            var vacinados = _ListVacinado.Find<Vacinado>(filter).ToList();
            return vacinados;
        }
    }
}