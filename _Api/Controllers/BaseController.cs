using _Api.Data.Collections;
using _Api.Interfaces;
using _Api.Repositories;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace _Api.Controllers
{
    public abstract class BaseController : ControllerBase, IController
    {
        protected RepositoryInfectado _repositoryInfectado;
        protected MongoDBConnect _mongoDBConnect;
        public string Nome {get;set;}
        public string Email {get;set;}
        public double Latitude {get;set;}
        public double Longitude {get;set;}
        public string Sexo { get; set; }
    }
}