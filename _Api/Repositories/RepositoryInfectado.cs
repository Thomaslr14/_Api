using System.Collections.Generic;
using _Api.Data.Collections;
using _Api.Interfaces;
using _Api.Interfaces.EntityInterfaces;
using _Api.Interfaces.RepositoriesInterfaces;
using MongoDB.Bson;
using MongoDB.Driver;

namespace _Api.Repositories
{
    public class RepositoryInfectado : IRepositoryInfectado
    {
        protected IMongoCollection<Infectado> _ListInfectado; 
        MongoDBConnect _mongoDBConnect;
        
        public RepositoryInfectado(MongoDBConnect connect)
        {
            _mongoDBConnect = connect;
            _ListInfectado = _mongoDBConnect.db.GetCollection<Infectado>(typeof(Infectado).Name);
        }

        public void Create(IEntityInfectado newInfectado)
        {
            _ListInfectado.InsertOne((Infectado)newInfectado);
        }

        public List<Infectado> GetAll()
        {
            var filter = Builders<Infectado>.Filter.Empty;
            var infectados = _ListInfectado.Find<Infectado>(filter).ToList();
            return infectados;
        }
    }
}