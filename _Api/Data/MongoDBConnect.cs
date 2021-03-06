using System;
using _Api.Interfaces.BaseInterfaces;
using Microsoft.Extensions.Configuration;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;

namespace _Api.Data.Collections
{
    public class MongoDBConnect : IMongoConnect
    {
        public IMongoDatabase db { get;set; }

        public MongoDBConnect(IConfiguration _configuration)
        {   
            try
            {
                var _ConventionPack = new ConventionPack { new CamelCaseElementNameConvention() };
                ConventionRegistry.Register("camelCase",_ConventionPack, t => true);
                var _MongoDBClient = new MongoClient(_configuration.GetSection("ConnectionString").
                                            GetSection("DefaultConnection").Value.ToString());
                db = _MongoDBClient.GetDatabase(_configuration["NomeBanco"]);
                MappingClass();
            }
            catch (Exception e)
            {
                throw new MongoException("Erro ao conectar ao banco de dados!", e);
            }
        }

        
        public void MappingClass()
        {
            if (!BsonClassMap.IsClassMapRegistered(typeof(Infectado)))
            {
                BsonClassMap.RegisterClassMap<Infectado>(x =>
                {
                    x.SetIgnoreExtraElements(true);
                    x.MapIdField(i => i.Id).SetIsRequired(true);
                    x.MapField(i => i.Nome);
                    x.MapField(i => i.Email);
                    x.MapField(i => i.Sexo).SetIsRequired(true);
                    x.MapField(i => i.Localização);
                });
            }
            
            if (!BsonClassMap.IsClassMapRegistered(typeof(Vacinado)))
            {
                BsonClassMap.RegisterClassMap<Vacinado>(x =>
                {
                    x.SetIgnoreExtraElements(true);
                    x.MapIdField(i => i.Id).SetIsRequired(true);
                    x.MapField(i => i.Nome);
                    x.MapField(i => i.Email);
                    x.MapField(i => i.Sexo).SetIsRequired(true);
                    x.MapField(i => i.Localização);
                });
            }
            
        }
    }
}