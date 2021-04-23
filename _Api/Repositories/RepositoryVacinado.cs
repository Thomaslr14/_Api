using System.Collections.Generic;
using _Api.Data.Collections;
using _Api.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;

namespace _Api.Repositories
{
    public class RepositoryVacinado : IRepository<Vacinado>
    {
        protected IMongoCollection<Vacinado> _ListVacinado;
        MongoDBConnect _mongoDBConnect;

        public RepositoryVacinado(MongoDBConnect connect)
        {
            _mongoDBConnect = connect;
            _ListVacinado = _mongoDBConnect.db.GetCollection<Vacinado>(typeof(Vacinado).Name);
        }

        public bool Create(Vacinado newVacinado)
        {
            _ListVacinado.InsertOne(newVacinado);
            return true;
        }

        public List<Vacinado> GetAll()
        {
            var filter = Builders<Vacinado>.Filter.Empty;
            var vacinados = _ListVacinado.Find<Vacinado>(filter).ToList();
            return vacinados;
        }
        public void Delete(ObjectId _id)
        {
            // var vacinado = _ListVacinado.Find<Vacinado>(_ => _.Id == _id).Filter;
            // _ListVacinado.DeleteOne(vacinado);
        }
    }
}