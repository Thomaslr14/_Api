using System.Collections.Generic;
using System.Linq;
using _Api.Interfaces.MappingInterfaces;
using _Api.Interfaces.RepositoriesInterfaces;
using MongoDB.Driver.GeoJsonObjectModel;

namespace _Api.Maps
{
    public class MapGeoLocationInfectado : IMapGeoLocationInfectado
    {
        private readonly IRepositoryInfectado _repositoryInfectado;
        private readonly List<GeoJson2DGeographicCoordinates> _listCoordenatesInfectados;
        public double[][,] arrayCoordenates {get;set;}

        public MapGeoLocationInfectado(IRepositoryInfectado repositoryInfectado)
        {
            _repositoryInfectado = repositoryInfectado;
            _listCoordenatesInfectados = _repositoryInfectado.GetLocations();
            arrayCoordenates = new double[_listCoordenatesInfectados.Count][,];
            MapLocationsInfectados();
        }
        
        public void MapLocationsInfectados()
        {   
            var coordenates = _listCoordenatesInfectados.Select(p => new 
            {
                p.Latitude,
                p.Longitude
            }).ToList();

            int i = 0;
            foreach(var item in coordenates)
            {
                arrayCoordenates[i] = new double[,] {{item.Latitude, item.Longitude}};
                i++;
            }
        }
    }
}