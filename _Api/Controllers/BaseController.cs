using System.ComponentModel.DataAnnotations;
using System.Linq;
using _Api.Interfaces;
using _Api.Interfaces.RepositoriesInterfaces;
using _Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace _Api.Controllers
{
    public class BaseController : Controller,IBaseController
    {
        public IRepositoryInfectado _repositoryInfectado {get; set;}
        public IRepositoryVacinado _repositoryVacinado {get; set;}
        public string Nome {get;set;}
        public string Email {get;set;}
        public double? Latitude {get;set;}
        public double? Longitude {get;set;}
        public string Sexo { get; set; }

        public BaseController(IRepositoryInfectado repositoryInfectado, IRepositoryVacinado repositoryVacinado)
        {
            _repositoryInfectado = repositoryInfectado;
            _repositoryVacinado = repositoryVacinado;
        }
        public bool CheckIfIsNull(PessoaModel _pessoaModel)
        {
            var propertiesDouble = _pessoaModel.GetType().GetProperties().Where(p => p.PropertyType == (typeof(double?))).Select(p => (double?)p.GetValue(_pessoaModel))
            .Any(value => value == null);

            var propertiesString = _pessoaModel.GetType().GetProperties().Where(p => p.Name == "Sexo").Select(p => (string)p.GetValue(_pessoaModel))
            .Any(value => string.IsNullOrEmpty(value));

            if (propertiesDouble || propertiesString)
                throw new ValidationException();
            else
                return false;
        }
       
    }
}