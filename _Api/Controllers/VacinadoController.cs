using System;
using System.ComponentModel.DataAnnotations;
using _Api.Data.Collections;
using _Api.Interfaces.EntityInterfaces;
using _Api.Interfaces.RepositoriesInterfaces;
using _Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace _Api.Controllers
{
    [ApiController]
    [Route("vacinado")]
    public class VacinadoController : BaseController
    {
        public VacinadoController(IRepositoryInfectado repositoryInfectado, IRepositoryVacinado repositoryVacinado) : base(repositoryInfectado, repositoryVacinado)
        {
            _repositoryVacinado = repositoryVacinado;
            _repositoryInfectado = repositoryInfectado;
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
            try 
            {
                CheckIfIsNull(mod);
                IEntityVacinado vacinado = new Vacinado(mod.Nome, mod.Email, mod.Sexo, Convert.ToDouble(mod.Latitude), Convert.ToDouble(mod.Longitude));
                _repositoryVacinado.Create(vacinado);
                return StatusCode(200, "Vacinado contabilizado!");  
            }
            catch (ValidationException)
            {
                return BadRequest("Erro! Campos obrigatórios não foram preenchidos!");
            }
            catch (MongoException ex)
            {
                throw new MongoException("Erro contabilizar vacinado!", ex);
            }
            
        }

        /// <summary>
        /// Busca a listagem de todoso os Vacinados
        /// </summary>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult GetList()
        {
            var vacinados = _repositoryVacinado.GetAll();
            if (vacinados.Count == 0)
            {
                return Ok("Lista de vacinados vazia!");
            }
            return Ok(vacinados);
        }
    }
}