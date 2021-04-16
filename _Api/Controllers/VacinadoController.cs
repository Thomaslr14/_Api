using _Api.Data.Collections;
using _Api.Models;
using _Api.Repositories;
using Microsoft.AspNetCore.Http;
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

        /// <summary>
        /// Contabiliza um novo Vacinado
        /// </summary>
        /// <remarks>
        /// Request de teste:
        ///
        ///     {
        ///        "Nome": "Maria",
        ///        "Email": "teste@gmail.com",
        ///        "Sexo": "F",
        ///        "Latitude": -19.8400227,
        ///        "Longitude": -44.0793538
        ///     }
        ///
        /// </remarks>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
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
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult GetList()
        {
            var vacinados = _repositoryVacinado.GetAll();
            return Ok(vacinados);
        }
    }
}