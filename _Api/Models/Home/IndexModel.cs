using System.Threading;
using System.Threading.Tasks;
using _Api.Interfaces;
using _Api.Interfaces.RepositoriesInterfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.JSInterop;

namespace _Api.Models
{
    public class IndexModel : PageModel
    {
        private readonly IBaseController _repository;
        public int _numberInfectados;
        public int _numberVacinados;
        public int _totalContabilizados;

        public IndexModel(IBaseController repository)
        {
            _repository = repository;
            _numberInfectados = _repository._repositoryInfectado.GetNumberOfInfectados();
            _numberVacinados = _repository._repositoryVacinado.GetNumberOfVacinados();
            _totalContabilizados = SumOfAll();
        }

        private int SumOfAll()
        {
            return _numberInfectados + _numberVacinados;
        }
    }
}