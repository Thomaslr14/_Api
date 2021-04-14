namespace _Api.Interfaces
{
    public interface IPessoa
    {
        int Id {get;set;}
        string Nome {get;set;}
        string Email {get;set;}
        string Localização {get;set;}
    }
}