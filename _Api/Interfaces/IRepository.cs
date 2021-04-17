using System.Collections.Generic;

namespace _Api.Interfaces
{
    public interface IRepository<T>
    {
        void Create(T t);
        List<T> GetAll();
    }
}