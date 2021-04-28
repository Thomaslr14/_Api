using System.Threading.Tasks;
using _Api.Interfaces.MappingInterfaces;
using _Api.Interfaces.RepositoriesInterfaces;
using _Api.Maps;
using _Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace _Api.Controllers
{
    [ApiController]
    [Route("Home")]
    public class HomeController : Controller
    {
        public IRepositoryInfectado _repoInfectado;
        private readonly IMapGeoLocationInfectado _mapGeoLocation;
        public HomeController(IRepositoryInfectado repoInfectado, IMapGeoLocationInfectado mapGeoLocation)
        {
            _repoInfectado = repoInfectado;
            _mapGeoLocation = mapGeoLocation;
        }

        public IActionResult Index()
        {
            IndexModel index = new IndexModel(_mapGeoLocation);
            return View(index);
        }
    }
}