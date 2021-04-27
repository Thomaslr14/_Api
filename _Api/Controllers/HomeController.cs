using System.Threading.Tasks;
using _Api.Interfaces.RepositoriesInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace _Api.Controllers
{
    [ApiController]
    [Route("Home")]
    public class HomeController : Controller
    {
        public IRepositoryInfectado _repoInfectado;
        public HomeController(IRepositoryInfectado repoInfectado)
        {
            _repoInfectado = repoInfectado;
        }

        public IActionResult Index()
        {
            _repoInfectado.GetLocation();
            return View("Views/Home/index.cshtml");
        }
    }
}