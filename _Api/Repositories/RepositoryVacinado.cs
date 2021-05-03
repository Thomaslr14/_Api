using System.Collections.Generic;
using _Api.Data.Collections;
using _Api.Interfaces.BaseInterfaces;
using _Api.Interfaces.EntityInterfaces;
using _Api.Interfaces.RepositoriesInterfaces;
using MongoDB.Driver;
using System.Linq;
using System;

namespace _Api.Repositories
{
    public class RepositoryVacinado : IRepositoryVacinado
    {
        protected IMongoCollection<Vacinado> _ListVacinado;
        IMongoConnect _mongoDBConnect;
        private readonly FilterDefinition<Vacinado> _filter;

        public RepositoryVacinado(IMongoConnect connect)
        {
            _mongoDBConnect = connect;
            _ListVacinado = _mongoDBConnect.db.GetCollection<Vacinado>(typeof(Vacinado).Name);
            _filter = Builders<Vacinado>.Filter.Empty;
        }

        public void Create(IEntityVacinado newVacinado)
        {
            _ListVacinado.InsertOne((Vacinado)newVacinado);
        }

        public List<Vacinado> GetAll()
        {
            var vacinados = _ListVacinado.Find<Vacinado>(_filter).ToList();
            return vacinados;
        }

        public int GetNumberOfVacinados()
        {
            try 
            {
                var vac = (int)_ListVacinado.CountDocuments(_filter);
                return vac;
            }
            catch(NullReferenceException ex)
            {
                throw new NullReferenceException("A lista está vazia!", ex);
            }
        }
    }
}