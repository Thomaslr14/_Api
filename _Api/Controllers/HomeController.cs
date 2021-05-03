using _Api.Interfaces;
using _Api.Interfaces.RepositoriesInterfaces;
using _Api.MVC.Views.Home;
using Microsoft.AspNetCore.Mvc;

namespace _Api.MVC.Controllers
{
    [ApiController]
    public class HomeController : Controller
    {
        private readonly IndexModel _index;
        
        private readonly IBaseController _repository;

        public HomeController(IBaseController repository)
        {
            _repository = repository;
            _index = new IndexModel(_repository);
        }

        [Route("/")]
        [Route("/Home")]
        [Route("/Index")]
        public IActionResult Index()
        {
            return View(_index);
        }
    }
}