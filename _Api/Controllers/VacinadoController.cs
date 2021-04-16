using _Api.Data.Collections;
using _Api.Models;
using _Api.Repositories;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace _Api.Controllers
{
    [ApiController]
    [Route("vacinado")]
    public class VacinadoController : BaseController
    {
        public VacinadoController(RepositoryVacinado repository)
        {
            _repositoryVacinado = repository;   
        }

        [HttpPost]
        public ActionResult CreateVacinado([FromBody] PessoaModel mod)
        {
            var vacinado = new Vacinado(mod.Nome, mod.Email, mod.Sexo, mod.Latitude, mod.Longitude);
            try 
            {
                _repositoryVacinado.Create(vacinado);
                return StatusCode(200, "Vacinado contabilizado!");  
            }
            catch (MongoException ex)
            {
                throw new MongoException("Erro contabilizar vacinado!", ex);
            }
            
        }

        [HttpGet]
        public ActionResult GetList()
        {
            var vacinados = _repositoryVacinado.Get();
            return Ok(vacinados);
        }
    }
}