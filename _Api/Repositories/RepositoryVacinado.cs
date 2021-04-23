using System.Collections.Generic;
using _Api.Data.Collections;
using _Api.Interfaces;
using _Api.Interfaces.EntityInterfaces;
using _Api.Interfaces.RepositoriesInterfaces;
using MongoDB.Bson;
using MongoDB.Driver;

namespace _Api.Repositories
{
    public class RepositoryVacinado : IRepositoryVacinado
    {
        protected IMongoCollection<Vacinado> _ListVacinado;
        MongoDBConnect _mongoDBConnect;

        public RepositoryVacinado(MongoDBConnect connect)
        {
            _mongoDBConnect = connect;
            _ListVacinado = _mongoDBConnect.db.GetCollection<Vacinado>(typeof(Vacinado).Name);
        }

        public void Create(IEntityVacinado newVacinado)
        {
            _ListVacinado.InsertOne((Vacinado)newVacinado);
        }

        public List<Vacinado> GetAll()
        {
            var filter = Builders<Vacinado>.Filter.Empty;
            var vacinados = _ListVacinado.Find<Vacinado>(filter).ToList();
            return vacinados;
        }

    }
}