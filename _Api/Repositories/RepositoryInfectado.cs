using System.Collections.Generic;
using _Api.Data.Collections;
using _Api.Interfaces.BaseInterfaces;
using _Api.Interfaces.EntityInterfaces;
using _Api.Interfaces.RepositoriesInterfaces;
using MongoDB.Driver.GeoJsonObjectModel;
using MongoDB.Driver;
using System.Linq;

namespace _Api.Repositories
{
    public class RepositoryInfectado : IRepositoryInfectado
    {
        protected IMongoCollection<Infectado> _ListInfectado; 
        IMongoConnect _mongoDBConnect;
        
        public RepositoryInfectado(IMongoConnect connect)
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

        public GeoJson2DGeographicCoordinates GetLocation()
        {
            var filter = Builders<Infectado>.Filter.Empty;
            var temp = _ListInfectado.Find<Infectado>(filter).ToList();
            var teste = temp.GetType().GetProperties().Where(_ => _.Name == "Id").Select(p => p.GetValue(_ListInfectado));


            var lat = 0;
            var longt = 0;
            var coordinates = new GeoJson2DGeographicCoordinates(lat, longt);
            return coordinates; 

        }
    }
}