using Microsoft.Extensions.Configuration;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace _Api.Data.Collections
{
    public class MongoDBConnect
    {
        public MongoDBConnect(IConfiguration _configuration)
        {
            var _MongoDBClient = new MongoClient(_configuration.GetConnectionString("ConnectionString"));
            BsonClassMap.RegisterClassMap<Infectado>(x =>
            {
                x.SetIgnoreExtraElements(true);
                x.MapIdMember(i => i.Id);
                x.MapMember(i => i.Nome).SetIsRequired(true);
                
            });
        }

        
    }
}