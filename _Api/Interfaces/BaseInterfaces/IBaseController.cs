using _Api.Interfaces.RepositoriesInterfaces;
using _Api.Models;

namespace _Api.Interfaces
{
    public interface IBaseController
    {
        IRepositoryInfectado _repositoryInfectado {get; set;}
        IRepositoryVacinado _repositoryVacinado {get; set;}
        string Nome {get;set;}
        string Email {get;set;}
        string Sexo {get;set;}
        double? Latitude {get;set;}
        double? Longitude {get;set;}
        bool CheckIfIsNull(PessoaModel _pessoaModel);
    }
}