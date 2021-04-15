using System.Collections.Generic;
using _Api.Data.Collections;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace _Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InfectadoController : BaseController
    {
        MongoDBConnect _mongoDBConnect;
        private IMongoCollection<Infectado> _ListInfectado; 

        public InfectadoController(MongoDBConnect mongoDbConnect)
        {
            _mongoDBConnect = mongoDbConnect;
            _ListInfectado = mongoDbConnect.db.GetCollection<Infectado>(typeof(Infectado).Name);
        }

        [HttpGet]
        public IActionResult GetList()
        {
            var filter = Builders<Infectado>.Filter.Empty;
            var infectados = _ListInfectado.Find<Infectado>(filter).ToList();
            return
        }
    }
}