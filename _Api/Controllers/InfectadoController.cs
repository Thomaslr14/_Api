using _Api.Data.Collections;
using _Api.Models;
using _Api.Repositories;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace _Api.Controllers
{
    [ApiController]
    [Route("infectado")]
    public class InfectadoController : BaseController
    {
        public InfectadoController(RepositoryInfectado repository)
        {
            _repositoryInfectado = repository;
        }

        [HttpPost]
        public ActionResult CreateInfectado([FromBody] PessoaModel mod)
        {
            var infectado = new Infectado(mod.Nome, mod.Email, mod.Sexo, mod.Latitude, mod.Longitude);
            try 
            {
                _repositoryInfectado.Create(infectado);
                return StatusCode(200, "Infectado contabilizado!");
            }
            catch (MongoException mongoException)
            {
                throw new MongoException("Erro ao contabilizar infectado", mongoException);
            }
        }

        [HttpGet]
        public ActionResult GetList()
        {
            var infectados = _repositoryInfectado.Get();
            return Ok(infectados);
        }
    }
}