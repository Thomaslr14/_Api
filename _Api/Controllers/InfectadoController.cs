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
    [Route("infectado")]
    public class InfectadoController : BaseController
    {
        public InfectadoController(IRepositoryInfectado repositoryInfectado, IRepositoryVacinado repositoryVacinado) : base(repositoryInfectado, repositoryVacinado)
        {
           _repositoryInfectado = repositoryInfectado;
           _repositoryVacinado = repositoryVacinado;
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
            try 
            {
                CheckIfIsNull(mod);
                IEntityInfectado infectado = new Infectado(mod.Nome, mod.Email, mod.Sexo, Convert.ToDouble(mod.Latitude), Convert.ToDouble(mod.Longitude));
                _repositoryInfectado.Create(infectado);
                return StatusCode(200, "Infectado contabilizado!");
            }
            catch (ValidationException)
            {
                return BadRequest("Erro! Campos obrigatórios não foram preenchidos!");
            }
            catch (MongoException mongoException)
            {
                throw new MongoException("Erro ao contabilizar infectado", mongoException);
            }

        }

        /// <summary>
        /// Busca a listagem de todos os Infectados
        /// </summary>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult GetList()
        {
            var infectados = _repositoryInfectado.GetAll();
            if (infectados.Count == 0)
            {
                return Ok("Lista de infectados vazia!");
            }
            return Ok(infectados);
        }
    }
}