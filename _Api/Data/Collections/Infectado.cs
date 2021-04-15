using _Api.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver.GeoJsonObjectModel;

namespace _Api.Data.Collections
{
    public class Infectado : IPessoa
    {
        public ObjectId Id {get;set;}
        public string Nome {get;set;}
        public string Email {get;set;}
        public string Sexo {get;set;}
        public GeoJson2DGeographicCoordinates Localização {get;set;}
        public Infectado(string _nome, string _email, string _sexo, double _latitude, double _longitude)
        {
            Id = ObjectId.GenerateNewId();
            Nome = _nome;
            Sexo = _sexo;
            Email = _email;
            Localização = new GeoJson2DGeographicCoordinates(_latitude, _longitude);
        }
    }
    
}