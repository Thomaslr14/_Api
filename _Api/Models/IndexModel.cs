using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;

namespace _Api.Models
{
    public class IndexModel : PageModel
    {
        public IndexModel()
        {
        }
    }
}


// @{
//             @* var a = new Maps.MapGeoLocationInfectado(); *@
//             @* Coordenadas _coordinates = a.MapLocationsInfectados(); *@
//             public Coordenadas MapLocationsInfectados() => 
//             var internalLatitude = (double)_coordinates.lat[0];
//             var internalLongitude = (double)_coordinates.longt[0];
//         }
//         var lat = @internalLatitude
//         var longt = @internalLongitude