using System.Collections.Generic;
using _Api.Data.Collections;
using _Api.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;


namespace _Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InfectadoController : BaseController
    {
        public InfectadoController(MongoDBConnect mongoDbConnect)
        {
            
        }

        [HttpPost]
        public ActionResult CreateInfectado([FromBody] InfectadoModel mod)
        {
            var infectado = new Infectado(mod.Nome, mod.Email, mod.Sexo, mod.Latitude, mod.Longitude);
            try 
            {
                _repositoryInfectado.Create();
                return StatusCode(200, "Infectado contabilizado!");
            }
            catch (MongoException mongoException)
            {
                throw new MongoException("Erro ao contabilizar infectado", mongoException);
            }
        }

        // [HttpGet]
        // public ActionResult<Infectado> GetList()
        // {
        //     var filter = Builders<Infectado>.Filter.Empty;
        //     var infectados = _ListInfectado.Find<Infectado>(filter).ToList();
        //     Ok(infectados);
        // }
    }
}