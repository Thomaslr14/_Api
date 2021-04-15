using _Api.Interfaces;

namespace _Api.Models
{
    public class VacinadoModel : IModel
    {
        public string Nome { get;set; }
        public string Email { get;set;}
        public string Sexo { get;set;}
        public double Latitude { get;set;}
        public double Longitude { get;set;}
        public VacinadoModel(string _nomeModel, string _emailModel, string _sexoModel,
                             double _latitudeModel, double _longitudeModel)
        {
            this.Nome = _nomeModel;
            this.Email = _emailModel;
            this.Sexo = _sexoModel;
            this.Latitude = _latitudeModel;
            this.Longitude = _longitudeModel;
        }
    }
}