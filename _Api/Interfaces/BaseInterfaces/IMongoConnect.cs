using MongoDB.Driver;

namespace _Api.Interfaces.BaseInterfaces
{
    public interface IMongoConnect
    {
        IMongoDatabase db{get;set;}
        void MappingClass();
    }
}