using System.Collections.Generic;
using _Api.Data.Collections;
using _Api.Interfaces.EntityInterfaces;

namespace _Api.Interfaces.RepositoriesInterfaces
{
    public interface IRepositoryVacinado
    {
        void Create(IEntityVacinado newVacinado);

        List<Vacinado> GetAll();
    }
}