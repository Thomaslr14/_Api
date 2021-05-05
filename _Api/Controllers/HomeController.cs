using _Api.Controllers;
using _Api.Interfaces;
using _Api.Interfaces.RepositoriesInterfaces;
using _Api.Models;
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
        
        [Route("/Cadastrar")]
        public IActionResult Cadastrar()
        {
            CadastrarModel cadastrar = new CadastrarModel(_repository);
            return View();
        }

        [Route("/Cadastrar")]
        [HttpPost]
        public IActionResult Cadastrar(PessoaModel pessoa)
        {
            return View();
        }

        [Route("/Login")]
        public IActionResult Login()
        {
            return View();
        }

        [Route("/Login")]
        [HttpPost]
        public IActionResult LoginUser()
        {
            return View();
        }

    }
}