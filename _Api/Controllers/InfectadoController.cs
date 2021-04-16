using _Api.Data.Collections;
using _Api.Models;
using _Api.Repositories;
using Microsoft.AspNetCore.Http;
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

        /// <summary>
        /// Contabiliza um novo Infectado
        /// </summary>
        /// <remarks>
        /// Request de teste:
        ///
        ///     {
        ///        "Nome": "João",
        ///        "Email": "teste@hotmail.com",
        ///        "Sexo": "M",
        ///        "Latitude": -19.8997227,
        ///        "Longitude": -44.0793538
        ///     }
        ///
        /// </remarks>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
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
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult GetList()
        {
            try
            {
                var infectados = _repositoryInfectado.GetAll();
                return Ok(infectados);
            }
            catch (System.TimeoutException e)
            {
                throw new System.TimeoutException("Erro de timeout", e);
            }
            
        }
    }
}