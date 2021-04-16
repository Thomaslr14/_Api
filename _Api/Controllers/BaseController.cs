using _Api.Data.Collections;
using _Api.Interfaces;
using _Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace _Api.Controllers
{
    
    public abstract class BaseController : ControllerBase, IController
    {
        protected RepositoryInfectado _repositoryInfectado;
        protected RepositoryVacinado _repositoryVacinado;
        public string Nome {get;set;}
        public string Email {get;set;}
        public double Latitude {get;set;}
        public double Longitude {get;set;}
        public string Sexo { get; set; }
    }
}