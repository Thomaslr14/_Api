using System.Collections.Generic;
using _Api.Data.Collections;
using MongoDB.Bson;

namespace _Api.Interfaces
{
    public interface IRepository<T>
    {
        void Create(T t);
        List<T> GetAll();
        void Delete(ObjectId id);
        
    }
}