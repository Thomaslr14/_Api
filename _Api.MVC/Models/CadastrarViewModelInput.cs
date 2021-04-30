using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace _Api.MVC.Models
{
    public class CadastrarViewModelInput
    {
        public string Nome {get;set;}
        public string Email {get;set;}
        public string Sexo {get;set;}
        public double Latitude {get;set;}
        public double Longitude {get;set;}
    }
}