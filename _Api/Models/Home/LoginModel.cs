using _Api.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _Api.Models
{
    public class LoginModel : PageModel
    {
        private readonly IBaseController _repository;

        public LoginModel()
        {
        }
    }
}