using System.Collections.Generic;
using _Api.Data.Collections;
using _Api.Interfaces.EntityInterfaces;
using MongoDB.Driver.GeoJsonObjectModel;

namespace _Api.Interfaces.RepositoriesInterfaces
{
    public interface IRepositoryInfectado
    {
        void Create(IEntityInfectado newInfectado);

        List<Infectado> GetAll();

        GeoJson2DGeographicCoordinates GetLocation();

    }
}