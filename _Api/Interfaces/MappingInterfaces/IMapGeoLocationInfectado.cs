using _Api.Maps;

namespace _Api.Interfaces.MappingInterfaces
{
    public interface IMapGeoLocationInfectado
    {
        double[][,] arrayCoordenates {get;set;}
        void MapLocationsInfectados();
    }
}