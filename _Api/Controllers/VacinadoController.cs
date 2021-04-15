using _Api.Data.Collections;
using _Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace _Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VacinadoController : BaseController
    {
        // public VacinadoController(MongoDBConnect mongoDbConnect)
        // {
        //     _mongoDBConnect = mongoDbConnect;
        //     _ListVacinado = mongoDbConnect.db.GetCollection<Vacinado>(typeof(Vacinado).Name);
        // }

        // [HttpPost]
        // public ActionResult CreateVacinado([FromBody] VacinadoModel mod)
        // {
        //     var vacinado = new Vacinado(mod.Nome, mod.Email, mod.Sexo, mod.Latitude, mod.Longitude);
        //     //_ListVacinado.InsertOne(vacinado);
        //     return StatusCode(200, "Vacinado contabilizado!");
        // }
    }
}