using MongoDB.Bson;
using MongoDB.Driver.GeoJsonObjectModel;

namespace _Api.Interfaces
{
    public interface IPessoa
    {
        ObjectId Id {get;set;}
        string Nome {get;set;}
        string Email {get;set;}
        string Sexo {get;set;}
        GeoJson2DGeographicCoordinates Localização {get;set;}
    }
}