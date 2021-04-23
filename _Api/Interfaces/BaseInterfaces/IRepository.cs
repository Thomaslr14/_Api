using System.Collections.Generic;

namespace _Api.Interfaces
{
    public interface IRepository<T>
    {
        bool Create(T t);
        List<T> GetAll();
    }
}