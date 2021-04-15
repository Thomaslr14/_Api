using System;
using Microsoft.Extensions.Configuration;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;

namespace _Api.Data.Collections
{
    public class MongoDBConnect
    {
        public IMongoDatabase db;

        public MongoDBConnect(IConfiguration _configuration)
        {   
            try
            {
                var _ConventionPack = new ConventionPack { new CamelCaseElementNameConvention() };
                ConventionRegistry.Register("camelCase",_ConventionPack, t => true);
                var _MongoDBClient = new MongoClient(_configuration.GetConnectionString("ConnectionString"));
                db = _MongoDBClient.GetDatabase(_configuration["NomeBanco"]);
                Mapping();
            }
            catch (Exception e)
            {
                throw new MongoException("Erro ao conectar ao banco de dados!", e);
            }
            
            
        }

        private void Mapping()
        {
            if (!BsonClassMap.IsClassMapRegistered(typeof(Infectado)))
            {
                BsonClassMap.RegisterClassMap<Infectado>(x =>
                {
                    x.SetIgnoreExtraElements(true);
                    x.MapIdMember(i => i.Id);
                    x.MapMember(i => i.Nome).SetIsRequired(true);
                    x.MapMember(i => i.Email).SetIsRequired(true);
                });
            }
            
            if (!BsonClassMap.IsClassMapRegistered(typeof(Vacinado)))
            {
                BsonClassMap.RegisterClassMap<Vacinado>(x =>
                {
                    x.SetIgnoreExtraElements(true);
                    x.MapIdMember(i => i.Id).SetIsRequired(true);
                    x.MapMember(i => i.Nome).SetIsRequired(true);
                    x.MapMember(i => i.Email).SetIsRequired(true);
                });
            }
            
        }

        
    }
}