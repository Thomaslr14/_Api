using System.ComponentModel.DataAnnotations;
using _Api.Interfaces;
using _Api.Interfaces.EntityInterfaces;
using MongoDB.Bson;
using MongoDB.Driver.GeoJsonObjectModel;

namespace _Api.Data.Collections
{
    public class Infectado : IEntityInfectado
    {
        private IEntityInfectado newInfectado;

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

        public Infectado(IEntityInfectado newInfectado)
        {
            this.newInfectado = newInfectado;
        }
    }
    
}