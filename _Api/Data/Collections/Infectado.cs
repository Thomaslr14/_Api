using _Api.Interfaces;

namespace _Api.Data.Collections
{
    public class Infectado : IPessoa
    {
        public int Id {get;set;}
        public string Nome {get;set;}
        public string Email {get;set;}
        public string Localização {get;set;}
        public Infectado()
        {
            
        }
    }
    
}