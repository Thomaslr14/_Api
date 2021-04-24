using _Api.Interfaces;

namespace _Api.Models
{
    public class PessoaModel : IBase
    {
        public string Nome { get;set; }
        public string Email { get;set;}
        public string Sexo { get;set;}
        public double? Latitude { get;set;}
        public double? Longitude { get;set;}
    }
}