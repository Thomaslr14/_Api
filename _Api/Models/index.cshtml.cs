using Microsoft.AspNetCore.Mvc.RazorPages;
using _Api.Interfaces.MappingInterfaces;
using _Api.Interfaces.ModelInterfaces;
using _Api.Interfaces.RepositoriesInterfaces;
using _Api.Maps;

namespace _Api.Models
{
    public class IndexModel : PageModel, IIndexModel
    {
        private readonly IMapGeoLocationInfectado _geoLocation;
        public double[] latitude;
        public double[] longitute;
        public int tamanho;

        public IndexModel(IMapGeoLocationInfectado geoLocation)
        {
            _geoLocation = geoLocation;
            Geo();
        }
        
        private void Geo()
        {
            var tamanho = _geoLocation.arrayCoordenates.Length;
            latitude = new double[tamanho];
            longitute = new double[tamanho];
            for (int x = 0; x < tamanho;x++)
            {  
                latitude[x] = _geoLocation.arrayCoordenates[x][0,0];
                longitute[x] = _geoLocation.arrayCoordenates[x][0,1];
            }
        }

        void IIndexModel.Geo()
        {
            throw new System.NotImplementedException();
        }
    }
    
}