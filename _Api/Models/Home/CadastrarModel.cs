using _Api.Interfaces;
using _Api.Interfaces.ModelInterfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _Api.Models
{
    public class CadastrarModel : PageModel
    {
        private readonly IBaseController _repository;
        public CadastrarModel(IBaseController repository)
        {
            _repository = repository;
        }
    }
}