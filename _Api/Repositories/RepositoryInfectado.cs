using System.Collections.Generic;
using _Api.Data.Collections;
using _Api.Interfaces.BaseInterfaces;
using _Api.Interfaces.EntityInterfaces;
using _Api.Interfaces.RepositoriesInterfaces;
using MongoDB.Driver.GeoJsonObjectModel;
using MongoDB.Driver;
using System.Linq;
using System;

namespace _Api.Repositories
{
    public class RepositoryInfectado : IRepositoryInfectado
    {
        protected IMongoCollection<Infectado> _ListInfectado; 
        IMongoConnect _mongoDBConnect;
        private readonly FilterDefinition<Infectado> _filter;
        
        public RepositoryInfectado(IMongoConnect connect)
        {
            _mongoDBConnect = connect;
            _ListInfectado = _mongoDBConnect.db.GetCollection<Infectado>(typeof(Infectado).Name);
            _filter = Builders<Infectado>.Filter.Empty;
        }

        public void Create(IEntityInfectado newInfectado)
        {
            _ListInfectado.InsertOne((Infectado)newInfectado);
        }

        public List<Infectado> GetAll()
        {
            var infectados = _ListInfectado.Find<Infectado>(_filter).ToList();
            return infectados;
        }

        public List<GeoJson2DGeographicCoordinates> GetLocations()
        {
            var listCoordenates = _ListInfectado.Find<Infectado>(_filter).ToList().Select(p => p.Localização).ToList();
            return listCoordenates; 
        }


        public int GetNumberOfInfectados()
        {
            try 
            {
                var infec = (int)_ListInfectado.CountDocuments(_filter);
                return infec;
            }
            catch(NullReferenceException ex)
            {
                throw new NullReferenceException("A lista está vazia!", ex);
            }
        }
    }
}