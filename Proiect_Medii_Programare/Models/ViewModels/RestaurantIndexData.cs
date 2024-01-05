using Proiect_Medii_Programare.Models;
using System.Security.Policy;

namespace Proiect_Medii_Programare.Models.ViewModels
{
    public class RestaurantIndexData
    {
        public IEnumerable<Restaurant> Restaurante { get; set; }
        public IEnumerable<Recenzie> Recenzii { get; set; }
    }
}
