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

        public MapGeoLocationInfectado()
        {

        }

        public MapGeoLocationInfectado(IRepositoryInfectado repositoryInfectado)
        {
            _repositoryInfectado = repositoryInfectado;
            _listCoordenatesInfectados = _repositoryInfectado.GetLocations();
        }
        
        public Coordenadas MapLocationsInfectados()
        {
            double?[] lat = null;
            double?[] longt = null;
            var coordenates = _listCoordenatesInfectados.Select(p => new 
            {
                p.Latitude,
                p.Longitude
            }).ToList();
            
            for (int index = 0; index < coordenates.Count; index++)
            {
                lat[index] = coordenates[index].Latitude;
                longt[index] = coordenates[index].Longitude;
            }
            
            var _coordenates = new Coordenadas(lat, longt);
            return _coordenates;
        }

        
    }

    public class Coordenadas
    {
        public double?[] lat;
        public double?[] longt;

        public Coordenadas(double?[] lat, double?[] longt)
        {
            this.lat = lat;
            this.longt = longt;
        }
    }
}